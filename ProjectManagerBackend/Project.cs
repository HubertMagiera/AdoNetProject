using MySql.Data.MySqlClient;
using ProjectManagerBackend.DtoModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using Mysqlx.Crud;

namespace ProjectManagerBackend
{
    public class Project
    {
        public Project(int id, string name, string? description, string status, User creator, ProjectType type)
        {
            Id = id;
            Name = name;
            Description = description;
            Status = status;
            Creator = creator;
            Type = type;
        }
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Status { get; set; }
        public User Creator { get; set; }
        public ProjectType Type { get; set; }
        #endregion

        public static List<ViewProject>GetAllProjectsForUser(int userID)
        {
            var projectsToReturn = new List<ViewProject>();

            var connection = Database.GetConnection();
            string query = "Select p.project_id, p.project_name, p.project_description, ps.project_status_name, pt.project_type_name " +
                            "from project as p " +
                            "inner join project_status as ps on ps.project_status_id = p.project_status_id " +
                            "inner join project_type as pt on pt.project_type_id = p.project_type_id " +
                            "where p.project_creator_id = @id;";

            var command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", userID);

            var projects = new DataSet();
            var adapter = new MySqlDataAdapter(command);

            adapter.Fill(projects, "projects");

            for (int i = 0; i <= projects.Tables["projects"].Rows.Count-1; i++)
            {
                int id = Convert.ToInt32(projects.Tables["projects"].Rows[i]["project_id"]);
                string name = projects.Tables["projects"].Rows[i]["project_name"].ToString();
                string description = projects.Tables["projects"].Rows[i]["project_description"].ToString();
                string type = projects.Tables["projects"].Rows[i]["project_type_name"].ToString();
                string status = projects.Tables["projects"].Rows[i]["project_status_name"].ToString();

                var viewProject = new ViewProject(
                        id,
                        name,
                        description,
                        status,
                        type
                        );
                projectsToReturn.Add(viewProject);
            }
            if (projectsToReturn.Count == 0)
                throw new Exception("This user does not have any projects created.");
            return projectsToReturn;
        }
        public static void AddNewProject(AddProject projectToBeAdded)
        {
            //for new projects, status "new" is automatically asigned
            var statusNew = ProjectStatus.GetAllStatuses().FirstOrDefault(property => property.Name == "New");
            if (statusNew == null)
                throw new Exception("Apropriate project status not found in database.");
            int statusId = statusNew.Id;

            //assigning apropriate project type id based on user choose
            var projectType = ProjectType.GetAllProjectTypes().FirstOrDefault(property => property.TypeName == projectToBeAdded.TypeName);
            if (projectType == null)
                throw new Exception("Apropriate project type not found in database.");
            int projectTypeId = projectType.Id;

            //process with inserting new project
            string selectQuery = "select p.project_name, p.project_description, p.project_status_id, p.project_type_id, p.project_creator_id " +
                                "from project as p;";
            string insert = "insert into project (project_name,project_description,project_status_id,project_type_id,project_creator_id)" +
                                    "values(@name,@description,@status,@type,@creator);";

            var connection = Database.GetConnection();
            var adapter = new MySqlDataAdapter(selectQuery, connection);
            var insertCommand = new MySqlCommand(insert, connection);

            adapter.InsertCommand = insertCommand;
            insertCommand.Parameters.AddWithValue("@name", projectToBeAdded.Name);
            insertCommand.Parameters.AddWithValue("@description", projectToBeAdded.Description);
            insertCommand.Parameters.AddWithValue("@status", statusId);
            insertCommand.Parameters.AddWithValue("@type", projectTypeId);
            insertCommand.Parameters.AddWithValue("@creator", projectToBeAdded.CreatorId);


            var dataSet = new DataSet();
            adapter.Fill(dataSet, "project");

            var newRow = dataSet.Tables["project"].NewRow();
            newRow["project_name"] = projectToBeAdded.Name;
            newRow["project_description"] = projectToBeAdded.Description;
            newRow["project_status_id"] = statusId;
            newRow["project_type_id"] = projectTypeId;
            newRow["project_creator_id"] = projectToBeAdded.CreatorId;

            dataSet.Tables["project"].Rows.Add(newRow);
            if (dataSet.HasErrors)
            {
                dataSet.RejectChanges();
                throw new Exception("An error has occured during inserting new row");
            }
            adapter.Update(dataSet, "project");
        }

        public static void MoveProjectOnHold(int projectId)
        {
            //select queries for data adapters
            string selectProjectQuery = "select * from project as p where p.project_id = @id;";
            string selectTasksForProject = "select t.task_id, t.task_project_id, t.task_user_assigned_id, t.task_creation_date, t.task_deadline_date, " +
                                    "t.task_finished_date, t.task_status_id, t.task_description, t.task_priority_id, t.task_name " +
                                    "from task as t " +
                                    "where t.task_project_id = @id;";
            //update queries for data adapters
            string updateProjectQuery = "update project set project_status_id = @status where project_id = @id";
            string updateTaskQuery = "update task set task_status_id = @status where task_project_id = @id and task_id = @taskId";
           
            var connection = Database.GetConnection();
            var projectCommand = new MySqlCommand(selectProjectQuery, connection);
            projectCommand.Parameters.AddWithValue("@id", projectId);
            //adapter for managing project
            var adapterForProject = new MySqlDataAdapter(projectCommand);

            //list of all available statuses to determine whats the id of "on hold" status
            var projectStatuses = ProjectStatus.GetAllStatuses();
            int projectOnHoldId = projectStatuses.FirstOrDefault(property => property.Name == "On hold").Id;

            //list of all available task statuses to determine the reqiured id's
            var taskStatuses = TaskStatus.GetAllTaskStatuses();
            int taskOngoingId = taskStatuses.FirstOrDefault(property => property.Name == "Ongoing").Id;
            int taskWaitingForApprovalId = taskStatuses.FirstOrDefault(property => property.Name == "Waiting for approval").Id;
            int taskOnHoldId = taskStatuses.FirstOrDefault(property => property.Name == "On hold").Id;
            int taskNotStartedId = taskStatuses.FirstOrDefault(property => property.Name == "Not started").Id;

            //data set to store project and task data table
            var dataSet = new DataSet();
            //fill data set project table with project from db
            adapterForProject.Fill(dataSet, "project");
            //update command later used to update project status id
            adapterForProject.UpdateCommand = new MySqlCommand(updateProjectQuery, connection);
            adapterForProject.UpdateCommand.Parameters.AddWithValue("@id", projectId);
            adapterForProject.UpdateCommand.Parameters.AddWithValue("@status", projectOnHoldId);

            //adapter for managing tasks in a project
            var adapterForTasks = new MySqlDataAdapter();
            adapterForTasks.SelectCommand = new MySqlCommand(selectTasksForProject,connection);
            adapterForTasks.SelectCommand.Parameters.AddWithValue("@id", projectId);

            //fill data set tasks table with tasks assigned to a project
            adapterForTasks.Fill(dataSet, "tasks");
            //update command later used to update tasks statuses
            adapterForTasks.UpdateCommand = new MySqlCommand(updateTaskQuery, connection);
            adapterForTasks.UpdateCommand.Parameters.AddWithValue("@id", projectId);
            adapterForTasks.UpdateCommand.Parameters.AddWithValue("@status", taskOnHoldId);

            //loop to go through all tasks assigned to project
            for (int i = 0; i <= dataSet.Tables["tasks"].Rows.Count - 1; i++)
            {
                //if task status is ongoing, waiting for approval or not started, change its status to on hold
                int taskStatusId = Convert.ToInt32(dataSet.Tables["tasks"].Rows[i]["task_status_id"].ToString());
                if (taskStatusId == taskOngoingId || taskStatusId == taskWaitingForApprovalId || taskStatusId == taskNotStartedId)
                {
                    dataSet.Tables["tasks"].Rows[i]["task_status_id"] = taskOnHoldId;
                    //task id later used in update query
                    int taskID = Convert.ToInt32(dataSet.Tables["tasks"].Rows[i]["task_id"].ToString());
                    adapterForTasks.UpdateCommand.Parameters.AddWithValue("@taskId", taskID);
                    if(dataSet.HasErrors)
                    {
                        dataSet.RejectChanges();
                        throw new Exception("There were some errors while trying to move project task on hold");
                    }
                    //change tasks status to on hold
                    adapterForTasks.Update(dataSet, "tasks");
                }
                    
            }
            
            dataSet.Tables["project"].Rows[0]["project_status_id"] = projectOnHoldId;

            if(dataSet.HasErrors)
            {
                dataSet.RejectChanges();
                throw new Exception("There were some errors while trying to move project on hold");
            }
            //change projects status to on hold
            adapterForProject.Update(dataSet, "project");
        }
    }
}

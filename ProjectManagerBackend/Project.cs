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
        public void ChangeProjectStatus(string status)
        {
            throw new NotImplementedException();
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
    }
}

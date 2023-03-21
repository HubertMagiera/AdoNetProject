using MySql.Data.MySqlClient;
using ProjectManagerBackend.DtoModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerBackend
{
    public class Task
    {
        public Task(int id, Project project, User userAssigned, DateTime creationDate, DateTime deadlineDate, DateTime finishedDate, TaskStatus status, 
                    string? description, TaskPriority priority, string name)
        {
            Id = id;
            Project = project;
            UserAssigned = userAssigned;
            CreationDate = creationDate;
            DeadlineDate = deadlineDate;
            FinishedDate = finishedDate;
            Status = status;
            Description = description;
            Priority = priority;
            Name = name;
        }
        #region Properties
        public int Id { get; set; }
        public Project Project { get; set; }
        public User UserAssigned { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime DeadlineDate { get; set; }
        public DateTime FinishedDate { get; set; }
        public TaskStatus Status { get; set; }
        public string? Description { get; set; }
        public TaskPriority Priority { get; set; }
        public string Name { get; set; }
        #endregion

        public static List<Task>GetTasksForUser(int userID)
        {
            throw new NotImplementedException();
        }
        public void ChangeTaskStatus(string statusName)
        {
            throw new NotImplementedException();
        }
        public void ApproveTask()//available only for managers
        {
            throw new NotImplementedException();
        }
        public static void AddNewTask(AddTask taskToAdd)
        {
            //for new task, status "not started" is automatically asigned
            var statusNotStarted = TaskStatus.GetAllTaskStatuses().FirstOrDefault(property => property.Name == "Not started");
            if (statusNotStarted == null)
                throw new Exception("Apropriate task status not found in database.");
            int statusId = statusNotStarted.Id;

            //process with inserting new task
            string selectQuery = "select t.task_project_id, t.task_user_assigned_id, t.task_creation_date, t.task_deadline_date, " +
                                "t.task_status_id, t.task_description, t.task_priority_id, t.task_name " +
                                "from task as t " +
                                "where t.task_project_id = @id;";
            string insert = "insert into task (task_project_id, task_user_assigned_id, task_creation_date, task_deadline_date, " +
                            "task_status_id, task_description, task_priority_id, task_name) " +
                             "values(@projectId,@userId,@creationDate,@deadlineDate,@statusId,@description,@priority,@name);";

            var connection = Database.GetConnection();
            var adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@id", taskToAdd.ProjectId);
            var insertCommand = new MySqlCommand(insert, connection);

            var currentDate = DateTime.Now;

            adapter.InsertCommand = insertCommand;
            adapter.InsertCommand.Parameters.AddWithValue("@projectId", taskToAdd.ProjectId);
            adapter.InsertCommand.Parameters.AddWithValue("@userId", taskToAdd.UserId);
            adapter.InsertCommand.Parameters.AddWithValue("@creationDate", currentDate);
            adapter.InsertCommand.Parameters.AddWithValue("@deadlineDate", taskToAdd.DeadlineDate);
            adapter.InsertCommand.Parameters.AddWithValue("@statusId", statusId);
            adapter.InsertCommand.Parameters.AddWithValue("@description", taskToAdd.Description);
            adapter.InsertCommand.Parameters.AddWithValue("@priority", taskToAdd.PriorityId);
            adapter.InsertCommand.Parameters.AddWithValue("@name", taskToAdd.TaskName);


            var dataSet = new DataSet();
            adapter.Fill(dataSet, "task");

            var newRow = dataSet.Tables["task"].NewRow();
            newRow["task_project_id"] = taskToAdd.ProjectId;
            newRow["task_user_assigned_id"] = taskToAdd.UserId;
            newRow["task_creation_date"] = currentDate;
            newRow["task_deadline_date"] = taskToAdd.DeadlineDate;
            newRow["task_status_id"] = statusId;
            newRow["task_description"] = taskToAdd.Description;
            newRow["task_priority_id"] = taskToAdd.PriorityId;
            newRow["task_name"] = taskToAdd.TaskName;

            dataSet.Tables["task"].Rows.Add(newRow);
            if (dataSet.HasErrors)
            {
                dataSet.RejectChanges();
                throw new Exception("An error has occured during inserting new row");
            }
            adapter.Update(dataSet, "task");
        }

        public void DeleteTask() 
        {  
            throw new NotImplementedException();
        }
    }
}

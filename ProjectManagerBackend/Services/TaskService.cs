using MySql.Data.MySqlClient;
using ProjectManagerBackend.DtoModels;
using ProjectManagerBackend.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerBackend.Services
{
    public class TaskService:ITaskService
    {
        public List<ViewTask> GetTasksForUser(int userID)
        {
            throw new NotImplementedException();
        }
        public void DeleteTask(int taskId)
        {
            string selectQuery = "select * from task where task.task_id = @id;";
            string deleteQuery = "delete from task where task_id = @id;";

            var connection = Database.GetConnection();
            var selectCommand = new MySqlCommand(selectQuery, connection);
            var adapter = new MySqlDataAdapter(selectCommand);
            adapter.SelectCommand.Parameters.AddWithValue("@id", taskId);

            var taskDataSet = new DataSet();
            adapter.Fill(taskDataSet, "task");

            adapter.DeleteCommand = new MySqlCommand(deleteQuery, connection);
            adapter.DeleteCommand.Parameters.AddWithValue("@id", taskId);

            var row = taskDataSet.Tables["task"].Rows[0];

            row.Delete();
            adapter.Update(taskDataSet, "task");
        }

        public void AddNewTask(AddTask taskToAdd)
        {
            //for new task, status "not started" is automatically asigned
            var statusNotStarted = GetAllTaskStatuses().FirstOrDefault(property => property.Name == "Not started");
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

        public List<ViewTask> GetTasksForProject(int projectId)
        {
            var tasksToReturn = new List<ViewTask>();

            var connection = Database.GetConnection();
            string query = "select t.task_id, t.task_name, t.task_description, t.task_creation_date, t.task_deadline_date, t.task_finished_date, " +
                            "u.user_name, u.user_surname, tp.task_priority_name, ts.task_status_name " +
                            "from task as t " +
                            "inner join user as u on u.user_id = t.task_user_assigned_id " +
                            "inner join task_priority as tp on tp.task_priority_id = t.task_priority_id " +
                            "inner join task_status as ts on ts.task_status_id = t.task_status_id " +
                            "where t.task_project_id = @id;";

            var command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", projectId);

            var tasks = new DataSet();
            var adapter = new MySqlDataAdapter(command);

            adapter.Fill(tasks, "tasks");

            for (int i = 0; i <= tasks.Tables["tasks"].Rows.Count - 1; i++)
            {
                int id = Convert.ToInt32(tasks.Tables["tasks"].Rows[i]["task_id"]);
                string name = tasks.Tables["tasks"].Rows[i]["task_name"].ToString();
                string? description = tasks.Tables["tasks"].Rows[i]["task_description"].ToString();
                string created = tasks.Tables["tasks"].Rows[i]["task_creation_date"].ToString();
                string deadline = tasks.Tables["tasks"].Rows[i]["task_deadline_date"].ToString();
                string? finished = tasks.Tables["tasks"].Rows[i]["task_finished_date"].ToString();
                string userName = tasks.Tables["tasks"].Rows[i]["user_name"].ToString();
                string userSurname = tasks.Tables["tasks"].Rows[i]["user_surname"].ToString();
                string priority = tasks.Tables["tasks"].Rows[i]["task_priority_name"].ToString();
                string status = tasks.Tables["tasks"].Rows[i]["task_status_name"].ToString();

                var viewTask = new ViewTask(
                                    id,
                                    name,
                                    description,
                                    userName,
                                    userSurname,
                                    created,
                                    deadline,
                                    finished,
                                    status,
                                    priority);
                tasksToReturn.Add(viewTask);
            }
            if (tasksToReturn.Count == 0)
                throw new Exception("No tasks for this project.");
            return tasksToReturn;
        }

        public void ChangeTaskStatus(int taskId, string statusName)
        {
            string updateQuery = "";
            if (statusName.ToLower() == "finished")
                updateQuery = "update task set task_status_id = @status, task_finished_date = @date where task_id = @id";
            else
                updateQuery = "update task set task_status_id = @status where task_id = @id";

            string selectQuery = "select * from task where task.task_id = @id;";

            var status = GetAllTaskStatuses().FirstOrDefault(property => property.Name.ToLower() == statusName.ToLower());
            if (status == null)
                throw new Exception("Apropriate status not found in database.");
            int statusId = status.Id;

            var connection = Database.GetConnection();
            var selectCommand = new MySqlCommand(selectQuery, connection);
            var adapter = new MySqlDataAdapter(selectCommand);
            adapter.SelectCommand.Parameters.AddWithValue("@id", taskId);

            var taskDataSet = new DataSet();
            adapter.Fill(taskDataSet, "task");

            adapter.UpdateCommand = new MySqlCommand(updateQuery, connection);
            adapter.UpdateCommand.Parameters.AddWithValue("@id", taskId);
            adapter.UpdateCommand.Parameters.AddWithValue("@status", statusId);
            if (statusName.ToLower() == "finished")
            {
                adapter.UpdateCommand.Parameters.AddWithValue("@date", DateTime.Now);
                taskDataSet.Tables["task"].Rows[0]["task_finished_date"] = DateTime.Now;
            }

            taskDataSet.Tables["task"].Rows[0]["task_status_id"] = statusId;
            if (taskDataSet.HasErrors)
            {
                taskDataSet.RejectChanges();
                throw new Exception("An error occured while trying to update task status.");
            }
            adapter.Update(taskDataSet, "task");
        }

        public List<Models.TaskStatus> GetAllTaskStatuses()
        {
            var connection = Database.GetConnection();
            connection.Open();

            string query = "Select * from task_status";

            var command = new MySqlCommand(query, connection);
            var reader = command.ExecuteReader();

            List<Models.TaskStatus> statuses = new List<Models.TaskStatus>();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);

                statuses.Add(new Models.TaskStatus(id, name));
            }
            connection.Close();

            if (statuses.Count == 0)
            {
                throw new Exception("No task statuses found in database");
            }
            return statuses;
        }

        public List<TaskPriority> GetAllTaskPriorities()
        {
            //returns all task priorities

            List<TaskPriority> priorities = new List<TaskPriority>();

            var connection = Database.GetConnection();
            connection.Open();

            string query = "select * from task_priority;";
            var command = new MySqlCommand(query, connection);

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);

                priorities.Add(new TaskPriority(id, name));
            }
            connection.Close();
            return priorities;

        }
    }
}

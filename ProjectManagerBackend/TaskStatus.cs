using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerBackend
{
    public class TaskStatus
    {
        public TaskStatus(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static List<TaskStatus>GetAllTaskStatuses()
        {
            var connection = Database.GetConnection();
            connection.Open();

            string query = "Select * from task_status";

            var command = new MySqlCommand(query, connection);
            var reader = command.ExecuteReader();

            List<TaskStatus> statuses = new List<TaskStatus>();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);

                statuses.Add(new TaskStatus(id, name));
            }
            connection.Close();

            if (statuses.Count == 0)
            {
                throw new Exception("No task statuses found in database");
            }
            return statuses;
        }
    }
}

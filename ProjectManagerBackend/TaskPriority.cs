using MySql.Data.MySqlClient;
using ProjectManagerBackend.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerBackend
{
    public class TaskPriority
    {
        public TaskPriority(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static List<TaskPriority>GetAllTaskPriorities()
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

                priorities.Add(new TaskPriority(id,name));
            }
            connection.Close();
            return priorities;

        }

        public override string ToString()
        {
            return Id + " " + Name;
        }
    }
}

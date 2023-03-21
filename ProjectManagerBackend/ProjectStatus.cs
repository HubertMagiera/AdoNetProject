using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerBackend
{
    public class ProjectStatus
    {
        public ProjectStatus(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static List<ProjectStatus>GetAllStatuses()
        {
            var connection = Database.GetConnection();
            connection.Open();

            string query = "Select * from project_status";

            var command = new MySqlCommand(query, connection);
            var reader = command.ExecuteReader();

            List<ProjectStatus> statuses = new List<ProjectStatus>();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);

                statuses.Add(new ProjectStatus(id, name));
            }
            connection.Close();

            if (statuses.Count == 0)
            {
                throw new Exception("No project types found in database");
            }
            return statuses;
        }
    }
}

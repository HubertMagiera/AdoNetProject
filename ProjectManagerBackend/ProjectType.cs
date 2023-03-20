using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerBackend
{
    public class ProjectType
    {
        public ProjectType(int id, string typeName)
        {
            Id = id;
            TypeName = typeName;
        }

        public int Id { get; set; }
        public string TypeName { get; set; }

        public static List<ProjectType> GetAllProjectTypes()
        {
            var connection = Database.GetConnection();
            connection.Open();

            string query = "Select * from project_type";

            var command = new MySqlCommand(query, connection);
            var reader = command.ExecuteReader();

            List<ProjectType> roles = new List<ProjectType>();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);

                roles.Add(new ProjectType(id, name));
            }
            connection.Close();

            if (roles.Count == 0)
            {
                throw new Exception("No project types found in database");
            }
            return roles;
        }
    }
}

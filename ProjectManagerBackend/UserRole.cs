using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerBackend
{
    public class UserRole
    {
        public UserRole(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public static List<UserRole>GetAllUserRoles()
        {
            var connection = Database.GetConnection();
            connection.Open();

            string query = "Select * from user_role";

            var command = new MySqlCommand(query, connection);
            var reader = command.ExecuteReader();

            List<UserRole> roles = new List<UserRole>();
            while(reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);

                roles.Add(new UserRole(id, name));
            }
            connection.Close();

            if (roles.Count == 0)
            {
                throw new Exception("No user roles found in database");
            }
            return roles;
        }
    }
}

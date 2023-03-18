using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerBackend
{
    public class Database
    {
        private static readonly string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        /// <summary>
        /// public static MySqlConnection connection;
        /// </summary>
        /// <returns></returns>

        public static string GetConnectionString()
        {
            return connectionString;
        }

        public static MySqlConnection GetConnection()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                return connection;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }

        public static void CloseConnection(MySqlConnection connection)
        {
            connection.Close();
        }
    }
}

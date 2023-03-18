using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerBackend
{
    public class User
    {
        public User(int id, string name, string surname, string login, string password, UserRole role)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Login = login;
            Password = password;
            Role = role;
        }
        #region Properties
        public int Id {get; set;}
        public string Name { get; set;}
        public string Surname { get; set; }
        public string Login { get; set;}
        public string Password { get; set; }
        public UserRole Role { get; set; }
        #endregion

        public void AddNewUser()
        {
            throw new NotImplementedException();
        }
        public void ChangeUserRole(string role)
        {
            throw new NotImplementedException ();
        }

        public static User LoginUser(string login, string password)
        {
            User userToReturn = null;
            try
            {
                MySqlConnection connection = Database.GetConnection();

                string query = "select u.user_id,u.user_name,u.user_surname,u.user_login,u.user_password,u.user_role_id,role.user_role_name " +
                                "from user as u " +
                                "inner join user_role as role on u.user_role_id = role.user_role_id " +
                                "where u.user_login = @login;";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@login", login);

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);

                //MessageBox.Show(table.Rows[0]["user_login"].ToString());
                int rows = table.Rows.Count;
                if (rows > 1)
                    throw new Exception("More than one account created for this login!");
                else if (rows == 0)
                    throw new Exception("Wrong credentials provided");

                string userPassword = table.Rows[0]["user_password"].ToString();
                if (userPassword != password)
                    throw new Exception("Wrong credentials provided");

                int id = Convert.ToInt32(table.Rows[0]["user_id"].ToString());
                string name = table.Rows[0]["user_name"].ToString();
                string surname = table.Rows[0]["user_surname"].ToString();
                int roleId = Convert.ToInt32(table.Rows[0]["user_role_id"].ToString());
                string roleName = table.Rows[0]["user_role_name"].ToString();

                UserRole role = new UserRole(roleId, roleName);
                userToReturn = new User(id, name, surname, login, password, role);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return userToReturn;
        }

        private bool verifyLoginUnique(string login)
        {
            MySqlConnection connection = new MySqlConnection();
            try
            {
                connection = Database.GetConnection();
                connection.Open();

                string commandText = "select count(user_id) from user where user.user_login =@login";
                MySqlCommand command = new MySqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@login", login);
                int numberOfRows = Convert.ToInt32(command.ExecuteScalar());

                if (numberOfRows == 0)
                    return true;

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }          
        }
        private bool verifyPasswordMeetsRules(string password)
        {
            //password needs to be:
            //minimum 8 characters long
            //contain at least one upper case letter
            //contain at least one lower case letter
            //contain at least on digit
            //can not contain whitespaces
            //must contain one of the special characters

            if (password.Length < 8 || !password.Any(char.IsUpper) || !password.Any(char.IsLower) || !password.Any(char.IsDigit) || password.Any(char.IsWhiteSpace))
                return false;

            string specialCharacters = "!@#$%^&*+-/?<>;~`[]{}:,.|=_";//special characters. At least one of them needs to be present in provided password
            char[] specialCharactersArray = specialCharacters.ToCharArray();
            foreach (char ch in password)
            {
                if (specialCharactersArray.Contains(ch))//if char from password is visible in special characters list, return true
                    return true;
            }
            return false;
        }
    }
}

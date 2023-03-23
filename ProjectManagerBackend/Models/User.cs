using MySql.Data.MySqlClient;
using ProjectManagerBackend.DtoModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerBackend.Models
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
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
        #endregion

    }
}

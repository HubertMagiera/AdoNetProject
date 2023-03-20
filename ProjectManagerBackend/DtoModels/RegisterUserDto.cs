using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerBackend.DtoModels
{
    public class RegisterUserDto
    {
        public RegisterUserDto(string name, string surname, string login, string password, string roleName)
        {
            Name = name;
            Surname = surname;
            Login = login;
            Password = password;
            RoleName = roleName;
        }
        #region Properties
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string RoleName { get; set; }
        #endregion
    }
}

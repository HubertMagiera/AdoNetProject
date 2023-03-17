using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerBackend
{
    public class User
    {
        public User(int id, string name, string surname, string email, string password, UserRole role)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
            Role = role;
        }
        #region Properties
        public int Id {get; set;}
        public string Name { get; set;}
        public string Surname { get; set; }
        public string Email { get; set;}
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
    }
}

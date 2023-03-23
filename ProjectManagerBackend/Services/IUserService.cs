using ProjectManagerBackend.DtoModels;
using ProjectManagerBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerBackend.Services
{
    public interface IUserService
    {
        void AddNewUser(RegisterUserDto userToRegister);

        List<ViewUser> GetAllEmployees();

        User LoginUser(string login, string password);

        bool verifyLoginUnique(string login);

        bool verifyPasswordMeetsRules(string password);

        List<UserRole> GetAllUserRoles();

    }
}

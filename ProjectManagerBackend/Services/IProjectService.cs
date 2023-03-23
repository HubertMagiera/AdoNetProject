using ProjectManagerBackend.DtoModels;
using ProjectManagerBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerBackend.Services
{
    public interface IProjectService
    {
        List<ViewProject> GetAllProjectsForUser(int userID);

        void AddNewProject(AddProject projectToBeAdded);

        void MoveProjectOnHold(int projectId);

        void MarkProjectAsCompleted(int projectId);

        void ReactivateProject(int projectId);

        void MoveProjectToInProgress(int projectId);

        List<ProjectStatus> GetAllStatuses();

        List<ProjectType> GetAllProjectTypes();
    }
}

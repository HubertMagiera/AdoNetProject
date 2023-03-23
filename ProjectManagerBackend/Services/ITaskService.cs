using ProjectManagerBackend.DtoModels;
using ProjectManagerBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerBackend.Services
{
    public interface ITaskService
    {
        List<ViewTask> GetTasksForUser(int userId);

        void DeleteTask(int taskId);

        void AddNewTask(AddTask taskToAdd);

        List<ViewTask> GetTasksForProject(int projectId);

        void ChangeTaskStatus(int taskId, string statusName);

        List<Models.TaskStatus> GetAllTaskStatuses();

        List<TaskPriority> GetAllTaskPriorities();
    }
}

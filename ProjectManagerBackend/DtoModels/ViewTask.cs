using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerBackend.DtoModels
{
    public class ViewTask
    {
        public ViewTask(int id, string taskName, string? description, string userName, string userSurname, string creationDate, string deadlineDate, string? finishedDate, string taskStatus, string taskPriority)
        {
            Id = id;
            TaskName = taskName;
            Description = description;
            UserName = userName;
            UserSurname = userSurname;
            CreationDate = creationDate;
            DeadlineDate = deadlineDate;
            FinishedDate = finishedDate;
            TaskStatus = taskStatus;
            TaskPriority = taskPriority;
        }

        public int Id { get; set; }
        public string TaskName { get; set; }
        public string? Description { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string CreationDate { get; set; }
        public string DeadlineDate { get; set; }
        public string? FinishedDate { get; set; }
        public string TaskStatus { get; set; }
        public string TaskPriority { get; set; }

    }
}

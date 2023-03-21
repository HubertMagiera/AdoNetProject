using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerBackend.DtoModels
{
    public class AddTask
    {
        public AddTask(int projectId, int userId, DateTime deadlineDate, string? description, int priorityId, string taskName)
        {
            ProjectId = projectId;
            UserId = userId;
            DeadlineDate = deadlineDate;
            Description = description;
            PriorityId = priorityId;
            TaskName = taskName;
        }

        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public DateTime DeadlineDate { get; set; }
        public string? Description { get; set; }
        public int PriorityId { get; set; }
        public string TaskName { get; set; }
    }
}

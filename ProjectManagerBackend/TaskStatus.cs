using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerBackend
{
    public class TaskStatus
    {
        public TaskStatus(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static List<TaskStatus>GetAllTaskStatuses()
        {
            throw new NotImplementedException();
        }
    }
}

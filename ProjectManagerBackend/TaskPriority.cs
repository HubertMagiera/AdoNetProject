using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerBackend
{
    public class TaskPriority
    {
        public TaskPriority(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static List<TaskPriority>GetAllTaskPriorities()
        {
        throw new NotImplementedException();
       }
    }
}

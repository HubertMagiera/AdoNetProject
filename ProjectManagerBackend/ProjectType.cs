using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerBackend
{
    public class ProjectType
    {
        public ProjectType(string id, string typeName)
        {
            Id = id;
            TypeName = typeName;
        }

        public string Id { get; set; }
        public string TypeName { get; set; }

        public static List<ProjectType> GetAllProjectTypes()
        {
            throw new NotImplementedException();
        }
    }
}

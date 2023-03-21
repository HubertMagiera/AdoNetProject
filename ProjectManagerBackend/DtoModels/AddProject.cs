using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerBackend.DtoModels
{
    public class AddProject
    {
        public AddProject(string name, string? description, string typeName, int creatorId)
        {
            Name = name;
            Description = description;
            TypeName = typeName;
            CreatorId = creatorId;
        }

        public string Name { get; set; }
        public string? Description { get; set; }
        public string TypeName { get; set; }
        public int CreatorId { get; set; }
    }
}

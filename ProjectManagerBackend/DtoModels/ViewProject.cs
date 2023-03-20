using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerBackend.DtoModels
{
    public class ViewProject
    {
        public ViewProject(int id, string name, string? description, string status, string type)
        {
            Id = id;
            Name = name;
            Description = description;
            Status = status;
            Type = type;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Status { get; set; }

        public string Type { get; set; }
    }
}

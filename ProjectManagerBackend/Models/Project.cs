using MySql.Data.MySqlClient;
using ProjectManagerBackend.DtoModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using Mysqlx.Crud;

namespace ProjectManagerBackend.Models
{
    public class Project
    {
        public Project(int id, string name, string? description, string status, User creator, ProjectType type)
        {
            Id = id;
            Name = name;
            Description = description;
            Status = status;
            Creator = creator;
            Type = type;
        }
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Status { get; set; }
        public User Creator { get; set; }
        public ProjectType Type { get; set; }
        #endregion
    }
}

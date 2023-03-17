using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerBackend
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

        public static List<Project>GetAllProjectsForUser(int userID)
        {
            throw new NotImplementedException();
        }
        public void ChangeProjectStatus(string status)
        {
            throw new NotImplementedException();
        }
        public void AddNewProject()
        {
            throw new NotImplementedException ();
        }
    }
}

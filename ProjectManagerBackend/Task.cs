using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerBackend
{
    public class Task
    {
        public Task(int id, Project project, User userAssigned, DateTime creationDate, DateTime deadlineDate, DateTime finishedDate, TaskStatus status, 
                    string? description, TaskPriority priority, string name)
        {
            Id = id;
            Project = project;
            UserAssigned = userAssigned;
            CreationDate = creationDate;
            DeadlineDate = deadlineDate;
            FinishedDate = finishedDate;
            Status = status;
            Description = description;
            Priority = priority;
            Name = name;
        }
        #region Properties
        public int Id { get; set; }
        public Project Project { get; set; }
        public User UserAssigned { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime DeadlineDate { get; set; }
        public DateTime FinishedDate { get; set; }
        public TaskStatus Status { get; set; }
        public string? Description { get; set; }
        public TaskPriority Priority { get; set; }
        public string Name { get; set; }
        #endregion

        public static List<Task>GetTasksForUser(int userID)
        {
            throw new NotImplementedException();
        }
        public void ChangeTaskStatus(string statusName)
        {
            throw new NotImplementedException();
        }
        public void ApproveTask()//available only for managers
        {
            throw new NotImplementedException();
        }
        public void AddNewTask()
        {
            throw new NotImplementedException();
        }
        public void DeleteTask() 
        {  
            throw new NotImplementedException();
        }
    }
}

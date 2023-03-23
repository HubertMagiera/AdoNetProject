using ProjectManagerBackend.DtoModels;
using ProjectManagerBackend.Models;
using ProjectManagerBackend.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager
{
    public partial class AddTaskToProject : Form
    {
        private readonly int projectId;
        private readonly ITaskService _taskService;
        private readonly IUserService _userService;
        private readonly IProjectService _projectService;


        public AddTaskToProject(int projectId)
        {
            this.projectId = projectId;
            InitializeComponent();
            _taskService = new TaskService();
            _userService = new UserService();
            _projectService = new ProjectService();
            loadUsers();
            loadPriorities();
        }
        private void loadUsers()
        {
            comboBoxUsers.Items.Clear();
            var employees = _userService.GetAllEmployees();
            foreach (var employee in employees)
            {
                comboBoxUsers.Items.Add(employee.ToString());
            }
        }

        private void loadPriorities()
        {
            comboBoxTaskPriority.Items.Clear();
            var priorities = _taskService.GetAllTaskPriorities();
            foreach (var priority in priorities)
            {
                comboBoxTaskPriority.Items.Add(priority.ToString());
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClearData_Click(object sender, EventArgs e)
        {
            comboBoxUsers.SelectedIndex = -1;
            comboBoxTaskPriority.SelectedIndex = -1;
            textBoxName.Text = "";
            textBoxDescription.Text = "";
            dateTimePickerTaskDeadline.Value = dateTimePickerTaskDeadline.MinDate;
        }

        private void buttonCreateTask_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxUsers.SelectedIndex == -1 || comboBoxTaskPriority.SelectedIndex == -1 || string.IsNullOrEmpty(textBoxName.Text))
                    throw new Exception("Please provide all reqiured data.");

                string taskDescription = textBoxDescription.Text;
                if (string.IsNullOrEmpty(taskDescription))
                    taskDescription = "";

                int userId = Convert.ToInt32(comboBoxUsers.SelectedItem.ToString().Split(" ")[0]);
                int priorityId = Convert.ToInt32(comboBoxTaskPriority.SelectedItem.ToString().Split(" ")[0]);

                AddTask taskToBeAdded = new AddTask(
                                            projectId,
                                            userId,
                                            dateTimePickerTaskDeadline.Value,
                                            taskDescription,
                                            priorityId,
                                            textBoxName.Text);
                _taskService.AddNewTask(taskToBeAdded);
                _projectService.MoveProjectToInProgress(projectId);
                MessageBox.Show("New task successfully added to the project");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

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
    public partial class ProjectForManager : Form
    {
        private readonly IProjectService _projectService;
        public ProjectForManager()
        {
            InitializeComponent();
            _projectService = new ProjectService();
            radioButtonOngoing.Checked = true;
            loadProjectsIntoGridView(radioButtonOngoing.Text);
            dataGridViewProjects.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);
        }
        private void loadProjectsIntoGridView(string projectStatus)
        {
            try
            {
                dataGridViewProjects.DataSource = null;
                dataGridViewProjects.Rows.Clear();
                var projects = _projectService.GetAllProjectsForUser(Login.user.Id);
                if (projects.Count == 0)
                {
                    MessageBox.Show("This user does not have any projects created.");
                    return;
                }

                projects = projects.Where(property => property.Status == projectStatus).ToList();

                dataGridViewProjects.DataSource = projects;
                dataGridViewProjects.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void radioButtonNew_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNew.Checked)
            {
                loadProjectsIntoGridView(radioButtonNew.Text);
                buttonAddNewProject.Enabled = true;
                buttonAddTask.Enabled = true;
                buttonMarkAsCompleted.Enabled = true;
                buttonMoveToOnHold.Enabled = false;
                buttonReactivateProject.Enabled = false;
                buttonManageTasks.Enabled = true;
            }
        }

        private void radioButtonOngoing_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOngoing.Checked)
            {
                loadProjectsIntoGridView(radioButtonOngoing.Text);
                buttonAddNewProject.Enabled = true;
                buttonAddTask.Enabled = true;
                buttonMarkAsCompleted.Enabled = true;
                buttonMoveToOnHold.Enabled = true;
                buttonReactivateProject.Enabled = false;
                buttonManageTasks.Enabled = true;
            }
        }

        private void radioButtonCompleted_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCompleted.Checked)
            {
                loadProjectsIntoGridView(radioButtonCompleted.Text);
                buttonMoveToOnHold.Enabled = false;
                buttonAddTask.Enabled = false;
                buttonAddNewProject.Enabled = true;
                buttonMarkAsCompleted.Enabled = false;
                buttonReactivateProject.Enabled = false;
                buttonManageTasks.Enabled = false;
            }
        }

        private void radioButtonOnHold_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOnHold.Checked)
            {
                loadProjectsIntoGridView(radioButtonOnHold.Text);
                buttonAddNewProject.Enabled = true;
                buttonAddTask.Enabled = false;
                buttonMarkAsCompleted.Enabled = false;
                buttonMoveToOnHold.Enabled = false;
                buttonReactivateProject.Enabled = true;
                buttonManageTasks.Enabled = false;
            }
        }

        private void buttonAddNewProject_Click(object sender, EventArgs e)
        {
            AddNewProject newProjectForm = new AddNewProject();
            newProjectForm.Show();
            this.Close();
        }

        private void buttonMoveToOnHold_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewProjects.SelectedRows.Count == 0)
                    throw new Exception("Please indicate which project you want to move on hold.");
                int projectId = Convert.ToInt32(dataGridViewProjects.SelectedRows[0].Cells[0].Value);
                _projectService.MoveProjectOnHold(projectId);
                radioButtonOnHold.Checked = true;
                loadProjectsIntoGridView(radioButtonOnHold.Text);
                MessageBox.Show("Project is now moved on hold. You can reactivate it at any time.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonMarkAsCompleted_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewProjects.SelectedRows.Count == 0)
                    throw new Exception("Please indicate which project you want to mark as completed.");
                int projectId = Convert.ToInt32(dataGridViewProjects.SelectedRows[0].Cells[0].Value);
                _projectService.MarkProjectAsCompleted(projectId);
                radioButtonCompleted.Checked = true;
                loadProjectsIntoGridView(radioButtonCompleted.Text);
                MessageBox.Show("Project is now marked as completed. You can see it on 'all' projects view");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonReactivateProject_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewProjects.SelectedRows.Count == 0)
                    throw new Exception("Please indicate which project you want to reactivate.");
                int projectId = Convert.ToInt32(dataGridViewProjects.SelectedRows[0].Cells[0].Value);
                _projectService.ReactivateProject(projectId);
                radioButtonOngoing.Checked = true;
                loadProjectsIntoGridView(radioButtonOngoing.Text);
                MessageBox.Show("Project is now reactivated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewProjects.SelectedRows.Count == 0)
                    throw new Exception("Please indicate for which project you want to add new task.");
                int projectId = Convert.ToInt32(dataGridViewProjects.SelectedRows[0].Cells[0].Value);
                AddTaskToProject addTaskForm = new AddTaskToProject(projectId);
                addTaskForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonManageTasks_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewProjects.SelectedRows.Count == 0)
                    throw new Exception("Please indicate a project.");

                int projectId = Convert.ToInt32(dataGridViewProjects.SelectedRows[0].Cells[0].Value);
                string projectName = dataGridViewProjects.SelectedRows[0].Cells[1].Value.ToString();
                var tasksForProjectForm = new ProjectDetailedView(projectId, projectName);
                tasksForProjectForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

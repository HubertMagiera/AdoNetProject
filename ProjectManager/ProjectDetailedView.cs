using ProjectManagerBackend.DtoModels;
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
using Task = ProjectManagerBackend.Models.Task;

namespace ProjectManager
{
    public partial class ProjectDetailedView : Form
    {
        private readonly string _projectName;
        private readonly int _projectId;
        private readonly ITaskService _taskService;
        public ProjectDetailedView(int projectId, string projectName)
        {
            InitializeComponent();
            _taskService = new TaskService();
            _projectId = projectId;
            _projectName = projectName;
            radioButtonAll.Checked = true;
            labelProjectInfo.Text += projectName;
            loadTasksForProject(radioButtonAll.Text);
        }

        private void loadTasksForProject(string taskStatus)
        {
            try
            {
                dataGridViewTasks.DataSource = null;
                dataGridViewTasks.Rows.Clear();
                //var tasks = Task.GetTasksForProject(_projectId);
                var tasks = _taskService.GetTasksForProject(_projectId);

                if (taskStatus != "All")
                {
                    var list = tasks.Where(property => property.TaskStatus == taskStatus).ToList();
                    dataGridViewTasks.DataSource = list;
                }
                else
                {
                    dataGridViewTasks.DataSource = tasks;
                }
                dataGridViewTasks.Columns[0].Visible = false;
                dataGridViewTasks.Columns["Description"].Visible = false;
                dataGridViewTasks.Columns["CreationDate"].Visible = false;
                dataGridViewTasks.Columns["DeadlineDate"].Visible = false;
                dataGridViewTasks.Columns["FinishedDate"].Visible = false;
                dataGridViewTasks.Columns["TaskPriority"].Visible = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButtonNotStarted_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonNotStarted.Checked)
            {
                buttonApprove.Enabled = false;
                buttonDelete.Enabled = true;
                buttonPutOnHold.Enabled = true;
                buttonReactivateTask.Enabled = false;
                loadTasksForProject(radioButtonNotStarted.Text);
            }           
        }

        private void radioButtonOngoing_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonOngoing.Checked)
            {
                buttonApprove.Enabled = false;
                buttonDelete.Enabled = true;
                buttonPutOnHold.Enabled = true;
                buttonReactivateTask.Enabled = false;
                loadTasksForProject(radioButtonOngoing.Text);
            }

        }

        private void radioButtonWaitingForApproval_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonWaitingForApproval.Checked)
            {
                buttonApprove.Enabled = true;
                buttonDelete.Enabled = true;
                buttonPutOnHold.Enabled = true;
                buttonReactivateTask.Enabled = false;
                loadTasksForProject(radioButtonWaitingForApproval.Text);
            }

        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonAll.Checked)
            {
                buttonApprove.Enabled = false;
                buttonDelete.Enabled = false;
                buttonPutOnHold.Enabled = false;
                buttonReactivateTask.Enabled = false;
                loadTasksForProject(radioButtonAll.Text);
            }
        }

        private void radioButtonOnHold_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonOnHold.Checked)
            {
                buttonApprove.Enabled = false;
                buttonDelete.Enabled = true;
                buttonPutOnHold.Enabled = false;
                buttonReactivateTask.Enabled = true;
                loadTasksForProject(radioButtonOnHold.Text);
            }

        }

        private void radioButtonFinished_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonFinished.Checked)
            {
                buttonApprove.Enabled = false;
                buttonDelete.Enabled = false;
                buttonPutOnHold.Enabled = false;
                buttonReactivateTask.Enabled = false;
                loadTasksForProject(radioButtonFinished.Text);
            }

        }

        private void radioButtonDeleted_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonDeleted.Checked)
            {
                buttonApprove.Enabled = false;
                buttonDelete.Enabled = false;
                buttonPutOnHold.Enabled = false;
                buttonReactivateTask.Enabled = false;
                loadTasksForProject(radioButtonDeleted.Text);
            }

        }

        private void dataGridViewTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelTaskCreationDate.Text = Convert.ToDateTime(dataGridViewTasks.CurrentRow.Cells[5].Value.ToString()).ToString("dd/MMMM/yyyy");
            labelDeadlineDate.Text = Convert.ToDateTime(dataGridViewTasks.CurrentRow.Cells[6].Value.ToString()).ToString("dd/MMMM/yyyy");
            if (string.IsNullOrEmpty(dataGridViewTasks.CurrentRow.Cells[7].Value.ToString()))
                labelTaskFinishedDate.Text = "Task not finished yet";
            else
            {
                labelTaskFinishedDate.Text = Convert.ToDateTime(dataGridViewTasks.CurrentRow.Cells[7].Value.ToString()).ToString("dd/MMMM/yyyy");
            }
            labelTaskPriority.Text = dataGridViewTasks.CurrentRow.Cells[9].Value.ToString();
            if (string.IsNullOrEmpty(dataGridViewTasks.CurrentRow.Cells[2].Value.ToString()))
                textBoxTaskDescription.Text = "This task does not have any description.";
            else
                textBoxTaskDescription.Text = dataGridViewTasks.CurrentRow.Cells[2].Value.ToString();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            var projectsForm = new ProjectForManager();
            projectsForm.Show();
            this.Close();
        }

        private void buttonAddNewTask_Click(object sender, EventArgs e)
        {
            try
            {
                if (Login.user.Role.Name != "Manager")
                    throw new Exception("Only manager is allowed to add new task.");
                var addTaskForm = new AddTaskToProject(_projectId);
                addTaskForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonApprove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewTasks.SelectedRows.Count <= 0)
                    throw new Exception("Please indicate a task that you want to approve.");
                if (Login.user.Role.Name != "Manager")
                    throw new Exception("Only manager is allowed to approve a task");

                int taskId = Convert.ToInt32(dataGridViewTasks.SelectedRows[0].Cells[0].Value);
                //Task.ChangeTaskStatus(taskId, "finished");
                _taskService.ChangeTaskStatus(taskId, "finished");
                MessageBox.Show("Task has been approved.");
                radioButtonAll.Checked = true;
                loadTasksForProject(radioButtonAll.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewTasks.SelectedRows.Count <= 0)
                    throw new Exception("Please indicate a task that you want to delete.");
                if (Login.user.Role.Name != "Manager")
                    throw new Exception("Only manager is allowed to delete a task");

                int taskId = Convert.ToInt32(dataGridViewTasks.SelectedRows[0].Cells[0].Value);
                //Task.DeleteTask(taskId);
                _taskService.DeleteTask(taskId);
                MessageBox.Show("Task has been deleted.");
                radioButtonAll.Checked = true;
                loadTasksForProject(radioButtonAll.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPutOnHold_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewTasks.SelectedRows.Count <= 0)
                    throw new Exception("Please indicate a task that you want to put on hold.");
                if (Login.user.Role.Name != "Manager")
                    throw new Exception("Only manager is allowed to put a task on hold");

                int taskId = Convert.ToInt32(dataGridViewTasks.SelectedRows[0].Cells[0].Value);
                //Task.ChangeTaskStatus(taskId, "on hold");
                _taskService.ChangeTaskStatus(taskId, "on hold");
                MessageBox.Show("Task has been put on hold.");
                radioButtonAll.Checked = true;
                loadTasksForProject(radioButtonAll.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonReactivateTask_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewTasks.SelectedRows.Count <= 0)
                    throw new Exception("Please indicate a task that you want to reactivate.");
                if (Login.user.Role.Name != "Manager")
                    throw new Exception("Only manager is allowed to reactivate a task.");

                int taskId = Convert.ToInt32(dataGridViewTasks.SelectedRows[0].Cells[0].Value);
                //Task.ChangeTaskStatus(taskId, "ongoing");
                _taskService.ChangeTaskStatus(taskId, "ongoing");
                MessageBox.Show("Task has been reactivated.");
                radioButtonAll.Checked = true;
                loadTasksForProject(radioButtonAll.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

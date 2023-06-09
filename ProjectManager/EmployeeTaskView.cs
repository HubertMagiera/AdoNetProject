﻿using ProjectManagerBackend.Services;
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
    public partial class EmployeeTaskView : Form
    {
        private readonly ITaskService _taskService;

        public EmployeeTaskView()
        {
            InitializeComponent();
            _taskService = new TaskService();
            loadUserTasks(radioButtonOngoing.Text);
            radioButtonOngoing.Checked = true;
        }

        private void loadUserTasks(string taskStatus)
        {
            try
            {
                var tasks = _taskService.GetTasksForUser(Login.user.Id);
                dataGridViewTasks.DataSource = null;
                dataGridViewTasks.Rows.Clear();

                tasks = tasks.Where(property => property.TaskStatus == taskStatus).ToList();
                dataGridViewTasks.DataSource = tasks;

                dataGridViewTasks.Columns[0].Visible = false;
                dataGridViewTasks.Columns["Description"].Visible = false;
                dataGridViewTasks.Columns["UserName"].Visible = false;
                dataGridViewTasks.Columns["UserSurname"].Visible = false;
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
            if (radioButtonNotStarted.Checked)
            {
                buttonSendForApproval.Enabled = false;
                buttonStartWork.Enabled = true;
                loadUserTasks(radioButtonNotStarted.Text);
            }
        }

        private void radioButtonOngoing_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOngoing.Checked)
            {
                buttonSendForApproval.Enabled = true;
                buttonStartWork.Enabled = false;
                loadUserTasks(radioButtonOngoing.Text);
            }
        }

        private void radioButtonOnHold_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOnHold.Checked)
            {
                buttonSendForApproval.Enabled = false;
                buttonStartWork.Enabled = true;
                loadUserTasks(radioButtonOnHold.Text);
            }
        }

        private void radioButtonWaitingForApproval_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWaitingForApproval.Checked)
            {
                buttonSendForApproval.Enabled = false;
                buttonStartWork.Enabled = false;
                loadUserTasks(radioButtonWaitingForApproval.Text);
            }
        }

        private void radioButtonFinished_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFinished.Checked)
            {
                buttonSendForApproval.Enabled = false;
                buttonStartWork.Enabled = false;
                loadUserTasks(radioButtonFinished.Text);
            }
        }

        private void radioButtonDeleted_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDeleted.Checked)
            {
                buttonSendForApproval.Enabled = false;
                buttonStartWork.Enabled = false;
                loadUserTasks(radioButtonDeleted.Text);
            }
        }

        private void dataGridViewTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelTaskCreationDate.Text = Convert.ToDateTime(dataGridViewTasks.CurrentRow.Cells["CreationDate"].Value.ToString()).ToString("dd/MMMM/yyyy");
            labelDeadlineDate.Text = Convert.ToDateTime(dataGridViewTasks.CurrentRow.Cells["DeadlineDate"].Value.ToString()).ToString("dd/MMMM/yyyy");
            string? taskFinishedDate = dataGridViewTasks.CurrentRow.Cells["FinishedDate"].Value.ToString();
            if (string.IsNullOrEmpty(taskFinishedDate))
                labelTaskFinishedDate.Text = "Task not finished yet";
            else
            {
                labelTaskFinishedDate.Text = Convert.ToDateTime(taskFinishedDate).ToString("dd/MMMM/yyyy");
            }
            labelTaskPriority.Text = dataGridViewTasks.CurrentRow.Cells["TaskPriority"].Value.ToString();
            string? description = dataGridViewTasks.CurrentRow.Cells["Description"].Value.ToString();
            if (string.IsNullOrEmpty(description))
                textBoxTaskDescription.Text = "This task does not have any description.";
            else
                textBoxTaskDescription.Text = description;
        }

        private void buttonStartWork_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewTasks.SelectedRows.Count <= 0)
                    throw new Exception("Please indicate a task that you want to start working on.");

                int taskId = Convert.ToInt32(dataGridViewTasks.SelectedRows[0].Cells[0].Value);
                _taskService.ChangeTaskStatus(taskId, "Ongoing");
                MessageBox.Show("Task status has been updated.");
                radioButtonOngoing.Checked = true;
                loadUserTasks(radioButtonOngoing.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSendForApproval_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewTasks.SelectedRows.Count <= 0)
                    throw new Exception("Please indicate a task that you want tosend for an approval.");

                int taskId = Convert.ToInt32(dataGridViewTasks.SelectedRows[0].Cells[0].Value);
                _taskService.ChangeTaskStatus(taskId, "Waiting for approval");
                MessageBox.Show("Task has been sent for approval.");
                radioButtonWaitingForApproval.Checked = true;
                loadUserTasks(radioButtonWaitingForApproval.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

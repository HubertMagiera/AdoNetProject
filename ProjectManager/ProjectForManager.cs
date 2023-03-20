using ProjectManagerBackend;
using ProjectManagerBackend.DtoModels;
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
        private List<ViewProject> projects = new List<ViewProject>();
        public ProjectForManager()
        {
            InitializeComponent();
            radioButtonAll.Checked = true;
            projects = Project.GetAllProjectsForUser(Login.user.Id);
            loadProjectsIntoGridView(radioButtonAll.Text);
            dataGridViewProjects.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);
        }
        private void loadProjectsIntoGridView(string projectStatus)
        {
            try
            {
                dataGridViewProjects.DataSource = null;
                dataGridViewProjects.Rows.Clear();

                if (projectStatus != "All")
                {
                    var list = projects.Where(property => property.Status == projectStatus).ToList();
                    dataGridViewProjects.DataSource = list;
                    dataGridViewProjects.Columns[0].Visible = false;
                    return;
                }

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
            }
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAll.Checked)
            {
                loadProjectsIntoGridView(radioButtonAll.Text);
                buttonAddNewProject.Enabled = true;
                buttonAddTask.Enabled = false;
                buttonMarkAsCompleted.Enabled = false;
                buttonMoveToOnHold.Enabled = false;
                buttonReactivateProject.Enabled = false;
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
            }
        }

        private void buttonAddNewProject_Click(object sender, EventArgs e)
        {
            AddNewProject newProjectForm = new AddNewProject();
            newProjectForm.Show();
            this.Close();
        }
    }
}

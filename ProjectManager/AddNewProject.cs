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
    public partial class AddNewProject : Form
    {
        private readonly IProjectService _projectService;

        public AddNewProject()
        {
            InitializeComponent();
            _projectService = new ProjectService();
            loadProjectTypes();
            comboBoxProjectTypes.SelectedIndex = -1;
        }

        private void loadProjectTypes()
        {
            try
            {
                comboBoxProjectTypes.Items.Clear();
                var types = _projectService.GetAllProjectTypes();
                foreach (var type in types)
                {
                    comboBoxProjectTypes.Items.Add(type.TypeName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ProjectForManager projectForm = new ProjectForManager();
            projectForm.Show();
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBoxDescription.Text = "";
            comboBoxProjectTypes.SelectedIndex = -1;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxName.Text) || comboBoxProjectTypes.SelectedIndex == -1)
                    throw new Exception("Please provide project name and choose its type.");
                if (Login.user.Role.Name != "Manager")
                    throw new Exception("Only managers are allowed to create a new project.");
                string description = textBoxDescription.Text;
                if (string.IsNullOrEmpty(description))
                    description = "";
                var newProject = new AddProject(textBoxName.Text, 
                                                description, 
                                                comboBoxProjectTypes.SelectedItem.ToString(), 
                                                Login.user.Id
                                                );
                _projectService.AddNewProject(newProject);
                MessageBox.Show("New project has been successfully added to database. " +
                                    "You can find it by searching for 'New' projects in projects view panel.");
                ProjectForManager projectForm = new ProjectForManager();
                projectForm.Show();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

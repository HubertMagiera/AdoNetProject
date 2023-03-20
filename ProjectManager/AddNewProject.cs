using ProjectManagerBackend;
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
        public AddNewProject()
        {
            InitializeComponent();
            loadProjectTypes();
            comboBoxProjectTypes.SelectedIndex = -1;
        }

        private void loadProjectTypes()
        {
            try
            {
                comboBoxProjectTypes.Items.Clear();
                var types = ProjectType.GetAllProjectTypes();
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
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

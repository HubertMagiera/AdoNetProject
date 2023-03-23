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
    public partial class Login : Form
    {
        public static User user;
        private readonly IUserService _userService;

        public Login()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                user = _userService.LoginUser(textBoxLogin.Text, textBoxPassword.Text);

                if (user != null && user.Role.Name == "Manager")
                {
                    var project = new ProjectForManager();
                    project.Show();
                }
                else if(user!=null)
                {
                    var tasks = new EmployeeTaskView();
                    tasks.Show();
                }
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex.Message);
            }

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var registerForm = new Register();
            registerForm.Show();

        }
    }
}

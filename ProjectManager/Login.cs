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
    public partial class Login : Form
    {
        public static User user;

        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                user = User.LoginUser(textBoxLogin.Text, textBoxPassword.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex.Message);
            }
            
        }
    }
}

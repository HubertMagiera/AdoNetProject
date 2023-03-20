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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            comboBoxRole.Items.Clear();
            loadRoles();
        }
        private void loadRoles()
        {
            try
            {
                var roles = UserRole.GetAllUserRoles();
                foreach (var role in roles)
                {
                    comboBoxRole.Items.Add(role.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex.Message);
            }
        }

        private void buttonClearData_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                    ((TextBox)item).Text = "";
                else if (item.GetType() == typeof(ComboBox))
                    ((ComboBox)item).SelectedIndex = -1;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                checkReqiurementsForAddingUser();
                var userToRegister = new RegisterUserDto(
                    textBoxName.Text,
                    textBoxSurname.Text,
                    textBoxLogin.Text,
                    textBoxPassword.Text,
                    comboBoxRole.SelectedItem.ToString()
                    );
                User.AddNewUser(userToRegister);

                MessageBox.Show("New user added to database. Now you can proceed and login with provided credentials.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCloseRegister_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void checkReqiurementsForAddingUser()
        {
            foreach (var item in this.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    var txtBox = (TextBox)item;
                    if (string.IsNullOrEmpty(txtBox.Text))
                        throw new Exception("Please fill in all fields before registering new user.");
                }
                    
            }
            if (comboBoxRole.SelectedIndex == -1)
                throw new Exception("You need to choose user role.");
            if (textBoxPassword.Text != textBoxConfirmPassword.Text)
                throw new Exception("Provided passwords are not equal!");

            if (!User.verifyLoginUnique(textBoxLogin.Text))
                throw new Exception("User with provided login already exists in database. Please provide another one.");

            if (!User.verifyPasswordMeetsRules(textBoxPassword.Text))
                throw new Exception("Provided password does not meet security rules! Please provide another one.");
        }
    }
}

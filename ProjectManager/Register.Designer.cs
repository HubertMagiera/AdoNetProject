namespace ProjectManager
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            textBoxConfirmPassword = new TextBox();
            comboBoxRole = new ComboBox();
            buttonRegister = new Button();
            buttonClearData = new Button();
            buttonCloseRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 53);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(152, 9);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "Login";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(152, 106);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 3;
            label4.Text = "Confirm password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(152, 53);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 106);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 5;
            label6.Text = "Role";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(23, 27);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 6;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(23, 71);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(100, 23);
            textBoxSurname.TabIndex = 7;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(152, 27);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(100, 23);
            textBoxLogin.TabIndex = 8;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(152, 71);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(100, 23);
            textBoxPassword.TabIndex = 9;
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Location = new Point(152, 124);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.PasswordChar = '*';
            textBoxConfirmPassword.Size = new Size(100, 23);
            textBoxConfirmPassword.TabIndex = 10;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(23, 124);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(121, 23);
            comboBoxRole.TabIndex = 11;
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(23, 162);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(100, 23);
            buttonRegister.TabIndex = 12;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // buttonClearData
            // 
            buttonClearData.Location = new Point(152, 162);
            buttonClearData.Name = "buttonClearData";
            buttonClearData.Size = new Size(100, 23);
            buttonClearData.TabIndex = 13;
            buttonClearData.Text = "Clear data";
            buttonClearData.UseVisualStyleBackColor = true;
            buttonClearData.Click += buttonClearData_Click;
            // 
            // buttonCloseRegister
            // 
            buttonCloseRegister.Location = new Point(23, 191);
            buttonCloseRegister.Name = "buttonCloseRegister";
            buttonCloseRegister.Size = new Size(100, 23);
            buttonCloseRegister.TabIndex = 14;
            buttonCloseRegister.Text = "Cancel";
            buttonCloseRegister.UseVisualStyleBackColor = true;
            buttonCloseRegister.Click += buttonCloseRegister_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 220);
            Controls.Add(buttonCloseRegister);
            Controls.Add(buttonClearData);
            Controls.Add(buttonRegister);
            Controls.Add(comboBoxRole);
            Controls.Add(textBoxConfirmPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private TextBox textBoxConfirmPassword;
        private ComboBox comboBoxRole;
        private Button buttonRegister;
        private Button buttonClearData;
        private Button buttonCloseRegister;
    }
}
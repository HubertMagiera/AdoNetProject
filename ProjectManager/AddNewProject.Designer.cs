namespace ProjectManager
{
    partial class AddNewProject
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
            textBoxName = new TextBox();
            textBoxDescription = new TextBox();
            comboBoxProjectTypes = new ComboBox();
            buttonCreate = new Button();
            buttonCancel = new Button();
            buttonClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 12);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 108);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 64);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "Type";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(24, 30);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(165, 23);
            textBoxName.TabIndex = 4;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(24, 126);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(165, 117);
            textBoxDescription.TabIndex = 5;
            // 
            // comboBoxProjectTypes
            // 
            comboBoxProjectTypes.FormattingEnabled = true;
            comboBoxProjectTypes.Location = new Point(24, 82);
            comboBoxProjectTypes.Name = "comboBoxProjectTypes";
            comboBoxProjectTypes.Size = new Size(165, 23);
            comboBoxProjectTypes.TabIndex = 6;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(24, 249);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(75, 52);
            buttonCreate.TabIndex = 7;
            buttonCreate.Text = "Create Project";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(114, 278);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(114, 249);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 9;
            buttonClear.Text = "Clear Data";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // AddNewProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(206, 320);
            Controls.Add(buttonClear);
            Controls.Add(buttonCancel);
            Controls.Add(buttonCreate);
            Controls.Add(comboBoxProjectTypes);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddNewProject";
            Text = "AddNewProject";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxName;
        private TextBox textBoxDescription;
        private ComboBox comboBoxProjectTypes;
        private Button buttonCreate;
        private Button buttonCancel;
        private Button buttonClear;
    }
}
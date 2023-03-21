namespace ProjectManager
{
    partial class AddTaskToProject
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
            dateTimePickerTaskDeadline = new DateTimePicker();
            label2 = new Label();
            textBoxName = new TextBox();
            textBoxDescription = new TextBox();
            label3 = new Label();
            label4 = new Label();
            comboBoxTaskPriority = new ComboBox();
            label5 = new Label();
            comboBoxUsers = new ComboBox();
            buttonCreateTask = new Button();
            buttonClearData = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 16);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 0;
            label1.Text = "User assigned to task";
            // 
            // dateTimePickerTaskDeadline
            // 
            dateTimePickerTaskDeadline.Location = new Point(25, 78);
            dateTimePickerTaskDeadline.MinDate = new DateTime(2023, 3, 21, 0, 0, 0, 0);
            dateTimePickerTaskDeadline.Name = "dateTimePickerTaskDeadline";
            dateTimePickerTaskDeadline.Size = new Size(200, 23);
            dateTimePickerTaskDeadline.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 60);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 3;
            label2.Text = "Deadline date";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(25, 122);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(200, 23);
            textBoxName.TabIndex = 4;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(25, 166);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(200, 117);
            textBoxDescription.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 104);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 6;
            label3.Text = "Task name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 148);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 7;
            label4.Text = "Task description";
            // 
            // comboBoxTaskPriority
            // 
            comboBoxTaskPriority.FormattingEnabled = true;
            comboBoxTaskPriority.Location = new Point(25, 304);
            comboBoxTaskPriority.Name = "comboBoxTaskPriority";
            comboBoxTaskPriority.Size = new Size(200, 23);
            comboBoxTaskPriority.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 286);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 9;
            label5.Text = "Task priority";
            // 
            // comboBoxUsers
            // 
            comboBoxUsers.FormattingEnabled = true;
            comboBoxUsers.Location = new Point(25, 34);
            comboBoxUsers.Name = "comboBoxUsers";
            comboBoxUsers.Size = new Size(200, 23);
            comboBoxUsers.TabIndex = 10;
            // 
            // buttonCreateTask
            // 
            buttonCreateTask.Location = new Point(25, 337);
            buttonCreateTask.Name = "buttonCreateTask";
            buttonCreateTask.Size = new Size(98, 51);
            buttonCreateTask.TabIndex = 11;
            buttonCreateTask.Text = "Create task";
            buttonCreateTask.UseVisualStyleBackColor = true;
            buttonCreateTask.Click += buttonCreateTask_Click;
            // 
            // buttonClearData
            // 
            buttonClearData.Location = new Point(127, 337);
            buttonClearData.Name = "buttonClearData";
            buttonClearData.Size = new Size(98, 23);
            buttonClearData.TabIndex = 12;
            buttonClearData.Text = "Clear data";
            buttonClearData.UseVisualStyleBackColor = true;
            buttonClearData.Click += buttonClearData_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(127, 365);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(98, 23);
            buttonCancel.TabIndex = 13;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // AddTaskToProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 413);
            Controls.Add(buttonCancel);
            Controls.Add(buttonClearData);
            Controls.Add(buttonCreateTask);
            Controls.Add(comboBoxUsers);
            Controls.Add(label5);
            Controls.Add(comboBoxTaskPriority);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(dateTimePickerTaskDeadline);
            Controls.Add(label1);
            Name = "AddTaskToProject";
            Text = "AddTaskToProject";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePickerTaskDeadline;
        private Label label2;
        private TextBox textBoxName;
        private TextBox textBoxDescription;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxTaskPriority;
        private Label label5;
        private ComboBox comboBoxUsers;
        private Button buttonCreateTask;
        private Button buttonClearData;
        private Button buttonCancel;
    }
}
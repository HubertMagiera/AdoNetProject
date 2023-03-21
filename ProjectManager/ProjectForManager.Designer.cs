namespace ProjectManager
{
    partial class ProjectForManager
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
            dataGridViewProjects = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            radioButtonNew = new RadioButton();
            radioButtonOngoing = new RadioButton();
            radioButtonCompleted = new RadioButton();
            radioButtonOnHold = new RadioButton();
            groupBoxRadioButtons = new GroupBox();
            radioButtonAll = new RadioButton();
            buttonAddNewProject = new Button();
            buttonMoveToOnHold = new Button();
            buttonMarkAsCompleted = new Button();
            buttonAddTask = new Button();
            buttonReactivateProject = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjects).BeginInit();
            groupBoxRadioButtons.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewProjects
            // 
            dataGridViewProjects.AllowUserToAddRows = false;
            dataGridViewProjects.AllowUserToDeleteRows = false;
            dataGridViewProjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProjects.Location = new Point(16, 29);
            dataGridViewProjects.MultiSelect = false;
            dataGridViewProjects.Name = "dataGridViewProjects";
            dataGridViewProjects.ReadOnly = true;
            dataGridViewProjects.RowTemplate.Height = 25;
            dataGridViewProjects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProjects.Size = new Size(467, 214);
            dataGridViewProjects.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 11);
            label1.Name = "label1";
            label1.Size = new Size(215, 15);
            label1.TabIndex = 1;
            label1.Text = "Projects (double click to see the details)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(489, 29);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(489, 73);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(489, 47);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(489, 91);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 5;
            // 
            // radioButtonNew
            // 
            radioButtonNew.AutoSize = true;
            radioButtonNew.Location = new Point(6, 22);
            radioButtonNew.Name = "radioButtonNew";
            radioButtonNew.Size = new Size(49, 19);
            radioButtonNew.TabIndex = 6;
            radioButtonNew.TabStop = true;
            radioButtonNew.Text = "New";
            radioButtonNew.UseVisualStyleBackColor = true;
            radioButtonNew.CheckedChanged += radioButtonNew_CheckedChanged;
            // 
            // radioButtonOngoing
            // 
            radioButtonOngoing.AutoSize = true;
            radioButtonOngoing.Location = new Point(6, 47);
            radioButtonOngoing.Name = "radioButtonOngoing";
            radioButtonOngoing.Size = new Size(83, 19);
            radioButtonOngoing.TabIndex = 7;
            radioButtonOngoing.TabStop = true;
            radioButtonOngoing.Text = "In progress";
            radioButtonOngoing.UseVisualStyleBackColor = true;
            radioButtonOngoing.CheckedChanged += radioButtonOngoing_CheckedChanged;
            // 
            // radioButtonCompleted
            // 
            radioButtonCompleted.AutoSize = true;
            radioButtonCompleted.Location = new Point(89, 22);
            radioButtonCompleted.Name = "radioButtonCompleted";
            radioButtonCompleted.Size = new Size(84, 19);
            radioButtonCompleted.TabIndex = 8;
            radioButtonCompleted.TabStop = true;
            radioButtonCompleted.Text = "Completed";
            radioButtonCompleted.UseVisualStyleBackColor = true;
            radioButtonCompleted.CheckedChanged += radioButtonCompleted_CheckedChanged;
            // 
            // radioButtonOnHold
            // 
            radioButtonOnHold.AutoSize = true;
            radioButtonOnHold.Location = new Point(89, 47);
            radioButtonOnHold.Name = "radioButtonOnHold";
            radioButtonOnHold.Size = new Size(70, 19);
            radioButtonOnHold.TabIndex = 9;
            radioButtonOnHold.TabStop = true;
            radioButtonOnHold.Text = "On Hold";
            radioButtonOnHold.UseVisualStyleBackColor = true;
            radioButtonOnHold.CheckedChanged += radioButtonOnHold_CheckedChanged;
            // 
            // groupBoxRadioButtons
            // 
            groupBoxRadioButtons.Controls.Add(radioButtonAll);
            groupBoxRadioButtons.Controls.Add(radioButtonNew);
            groupBoxRadioButtons.Controls.Add(radioButtonOnHold);
            groupBoxRadioButtons.Controls.Add(radioButtonOngoing);
            groupBoxRadioButtons.Controls.Add(radioButtonCompleted);
            groupBoxRadioButtons.Location = new Point(16, 249);
            groupBoxRadioButtons.Name = "groupBoxRadioButtons";
            groupBoxRadioButtons.Size = new Size(267, 100);
            groupBoxRadioButtons.TabIndex = 10;
            groupBoxRadioButtons.TabStop = false;
            groupBoxRadioButtons.Text = "Filter projects by status";
            // 
            // radioButtonAll
            // 
            radioButtonAll.AutoSize = true;
            radioButtonAll.Location = new Point(6, 75);
            radioButtonAll.Name = "radioButtonAll";
            radioButtonAll.Size = new Size(39, 19);
            radioButtonAll.TabIndex = 10;
            radioButtonAll.TabStop = true;
            radioButtonAll.Text = "All";
            radioButtonAll.UseVisualStyleBackColor = true;
            radioButtonAll.CheckedChanged += radioButtonAll_CheckedChanged;
            // 
            // buttonAddNewProject
            // 
            buttonAddNewProject.Location = new Point(18, 361);
            buttonAddNewProject.Name = "buttonAddNewProject";
            buttonAddNewProject.Size = new Size(93, 48);
            buttonAddNewProject.TabIndex = 11;
            buttonAddNewProject.Text = "Add new project";
            buttonAddNewProject.UseVisualStyleBackColor = true;
            buttonAddNewProject.Click += buttonAddNewProject_Click;
            // 
            // buttonMoveToOnHold
            // 
            buttonMoveToOnHold.Location = new Point(117, 361);
            buttonMoveToOnHold.Name = "buttonMoveToOnHold";
            buttonMoveToOnHold.Size = new Size(93, 48);
            buttonMoveToOnHold.TabIndex = 12;
            buttonMoveToOnHold.Text = "Move to on hold";
            buttonMoveToOnHold.UseVisualStyleBackColor = true;
            buttonMoveToOnHold.Click += buttonMoveToOnHold_Click;
            // 
            // buttonMarkAsCompleted
            // 
            buttonMarkAsCompleted.Location = new Point(216, 361);
            buttonMarkAsCompleted.Name = "buttonMarkAsCompleted";
            buttonMarkAsCompleted.Size = new Size(93, 48);
            buttonMarkAsCompleted.TabIndex = 13;
            buttonMarkAsCompleted.Text = "Mark project as completed";
            buttonMarkAsCompleted.UseVisualStyleBackColor = true;
            buttonMarkAsCompleted.Click += buttonMarkAsCompleted_Click;
            // 
            // buttonAddTask
            // 
            buttonAddTask.Location = new Point(315, 361);
            buttonAddTask.Name = "buttonAddTask";
            buttonAddTask.Size = new Size(93, 48);
            buttonAddTask.TabIndex = 14;
            buttonAddTask.Text = "Add new task to project";
            buttonAddTask.UseVisualStyleBackColor = true;
            // 
            // buttonReactivateProject
            // 
            buttonReactivateProject.Location = new Point(414, 361);
            buttonReactivateProject.Name = "buttonReactivateProject";
            buttonReactivateProject.Size = new Size(93, 48);
            buttonReactivateProject.TabIndex = 15;
            buttonReactivateProject.Text = "Reactivate the project";
            buttonReactivateProject.UseVisualStyleBackColor = true;
            // 
            // ProjectForManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 450);
            Controls.Add(buttonReactivateProject);
            Controls.Add(buttonAddTask);
            Controls.Add(buttonMarkAsCompleted);
            Controls.Add(buttonMoveToOnHold);
            Controls.Add(buttonAddNewProject);
            Controls.Add(groupBoxRadioButtons);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewProjects);
            Name = "ProjectForManager";
            Text = "Project";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjects).EndInit();
            groupBoxRadioButtons.ResumeLayout(false);
            groupBoxRadioButtons.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProjects;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private RadioButton radioButtonNew;
        private RadioButton radioButtonOngoing;
        private RadioButton radioButtonCompleted;
        private RadioButton radioButtonOnHold;
        private GroupBox groupBoxRadioButtons;
        private RadioButton radioButtonAll;
        private Button buttonAddNewProject;
        private Button buttonMoveToOnHold;
        private Button buttonMarkAsCompleted;
        private Button buttonAddTask;
        private Button buttonReactivateProject;
    }
}
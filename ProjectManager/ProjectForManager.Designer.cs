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
            radioButtonNew = new RadioButton();
            radioButtonOngoing = new RadioButton();
            radioButtonCompleted = new RadioButton();
            radioButtonOnHold = new RadioButton();
            groupBoxRadioButtons = new GroupBox();
            buttonAddNewProject = new Button();
            buttonMoveToOnHold = new Button();
            buttonMarkAsCompleted = new Button();
            buttonAddTask = new Button();
            buttonReactivateProject = new Button();
            buttonManageTasks = new Button();
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
            dataGridViewProjects.Size = new Size(491, 214);
            dataGridViewProjects.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 11);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Projects";
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
            radioButtonOnHold.Size = new Size(68, 19);
            radioButtonOnHold.TabIndex = 9;
            radioButtonOnHold.TabStop = true;
            radioButtonOnHold.Text = "On hold";
            radioButtonOnHold.UseVisualStyleBackColor = true;
            radioButtonOnHold.CheckedChanged += radioButtonOnHold_CheckedChanged;
            // 
            // groupBoxRadioButtons
            // 
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
            // buttonAddNewProject
            // 
            buttonAddNewProject.Location = new Point(289, 256);
            buttonAddNewProject.Name = "buttonAddNewProject";
            buttonAddNewProject.Size = new Size(93, 48);
            buttonAddNewProject.TabIndex = 11;
            buttonAddNewProject.Text = "Add new project";
            buttonAddNewProject.UseVisualStyleBackColor = true;
            buttonAddNewProject.Click += buttonAddNewProject_Click;
            // 
            // buttonMoveToOnHold
            // 
            buttonMoveToOnHold.Location = new Point(289, 307);
            buttonMoveToOnHold.Name = "buttonMoveToOnHold";
            buttonMoveToOnHold.Size = new Size(93, 48);
            buttonMoveToOnHold.TabIndex = 12;
            buttonMoveToOnHold.Text = "Move to on hold";
            buttonMoveToOnHold.UseVisualStyleBackColor = true;
            buttonMoveToOnHold.Click += buttonMoveToOnHold_Click;
            // 
            // buttonMarkAsCompleted
            // 
            buttonMarkAsCompleted.Location = new Point(388, 256);
            buttonMarkAsCompleted.Name = "buttonMarkAsCompleted";
            buttonMarkAsCompleted.Size = new Size(93, 48);
            buttonMarkAsCompleted.TabIndex = 13;
            buttonMarkAsCompleted.Text = "Mark project as completed";
            buttonMarkAsCompleted.UseVisualStyleBackColor = true;
            buttonMarkAsCompleted.Click += buttonMarkAsCompleted_Click;
            // 
            // buttonAddTask
            // 
            buttonAddTask.Location = new Point(289, 361);
            buttonAddTask.Name = "buttonAddTask";
            buttonAddTask.Size = new Size(93, 48);
            buttonAddTask.TabIndex = 14;
            buttonAddTask.Text = "Add new task to project";
            buttonAddTask.UseVisualStyleBackColor = true;
            buttonAddTask.Click += buttonAddTask_Click;
            // 
            // buttonReactivateProject
            // 
            buttonReactivateProject.Location = new Point(388, 309);
            buttonReactivateProject.Name = "buttonReactivateProject";
            buttonReactivateProject.Size = new Size(93, 48);
            buttonReactivateProject.TabIndex = 15;
            buttonReactivateProject.Text = "Reactivate the project";
            buttonReactivateProject.UseVisualStyleBackColor = true;
            buttonReactivateProject.Click += buttonReactivateProject_Click;
            // 
            // buttonManageTasks
            // 
            buttonManageTasks.Location = new Point(388, 361);
            buttonManageTasks.Name = "buttonManageTasks";
            buttonManageTasks.Size = new Size(93, 48);
            buttonManageTasks.TabIndex = 16;
            buttonManageTasks.Text = "Manage tasks in project";
            buttonManageTasks.UseVisualStyleBackColor = true;
            buttonManageTasks.Click += buttonManageTasks_Click;
            // 
            // ProjectForManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 415);
            Controls.Add(buttonManageTasks);
            Controls.Add(buttonReactivateProject);
            Controls.Add(buttonAddTask);
            Controls.Add(buttonMarkAsCompleted);
            Controls.Add(buttonMoveToOnHold);
            Controls.Add(buttonAddNewProject);
            Controls.Add(groupBoxRadioButtons);
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
        private RadioButton radioButtonNew;
        private RadioButton radioButtonOngoing;
        private RadioButton radioButtonCompleted;
        private RadioButton radioButtonOnHold;
        private GroupBox groupBoxRadioButtons;
        private Button buttonAddNewProject;
        private Button buttonMoveToOnHold;
        private Button buttonMarkAsCompleted;
        private Button buttonAddTask;
        private Button buttonReactivateProject;
        private Button buttonManageTasks;
    }
}
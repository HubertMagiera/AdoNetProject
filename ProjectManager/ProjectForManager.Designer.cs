﻿namespace ProjectManager
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
            dataGridViewProjects.Location = new Point(18, 39);
            dataGridViewProjects.Margin = new Padding(3, 4, 3, 4);
            dataGridViewProjects.MultiSelect = false;
            dataGridViewProjects.Name = "dataGridViewProjects";
            dataGridViewProjects.ReadOnly = true;
            dataGridViewProjects.RowHeadersWidth = 51;
            dataGridViewProjects.RowTemplate.Height = 25;
            dataGridViewProjects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProjects.Size = new Size(561, 285);
            dataGridViewProjects.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 15);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 1;
            label1.Text = "Projects";
            // 
            // radioButtonNew
            // 
            radioButtonNew.AutoSize = true;
            radioButtonNew.Location = new Point(7, 29);
            radioButtonNew.Margin = new Padding(3, 4, 3, 4);
            radioButtonNew.Name = "radioButtonNew";
            radioButtonNew.Size = new Size(60, 24);
            radioButtonNew.TabIndex = 6;
            radioButtonNew.TabStop = true;
            radioButtonNew.Text = "New";
            radioButtonNew.UseVisualStyleBackColor = true;
            radioButtonNew.CheckedChanged += radioButtonNew_CheckedChanged;
            // 
            // radioButtonOngoing
            // 
            radioButtonOngoing.AutoSize = true;
            radioButtonOngoing.Location = new Point(7, 63);
            radioButtonOngoing.Margin = new Padding(3, 4, 3, 4);
            radioButtonOngoing.Name = "radioButtonOngoing";
            radioButtonOngoing.Size = new Size(103, 24);
            radioButtonOngoing.TabIndex = 7;
            radioButtonOngoing.TabStop = true;
            radioButtonOngoing.Text = "In progress";
            radioButtonOngoing.UseVisualStyleBackColor = true;
            radioButtonOngoing.CheckedChanged += radioButtonOngoing_CheckedChanged;
            // 
            // radioButtonCompleted
            // 
            radioButtonCompleted.AutoSize = true;
            radioButtonCompleted.Location = new Point(102, 29);
            radioButtonCompleted.Margin = new Padding(3, 4, 3, 4);
            radioButtonCompleted.Name = "radioButtonCompleted";
            radioButtonCompleted.Size = new Size(104, 24);
            radioButtonCompleted.TabIndex = 8;
            radioButtonCompleted.TabStop = true;
            radioButtonCompleted.Text = "Completed";
            radioButtonCompleted.UseVisualStyleBackColor = true;
            radioButtonCompleted.CheckedChanged += radioButtonCompleted_CheckedChanged;
            // 
            // radioButtonOnHold
            // 
            radioButtonOnHold.AutoSize = true;
            radioButtonOnHold.Location = new Point(102, 63);
            radioButtonOnHold.Margin = new Padding(3, 4, 3, 4);
            radioButtonOnHold.Name = "radioButtonOnHold";
            radioButtonOnHold.Size = new Size(83, 24);
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
            groupBoxRadioButtons.Location = new Point(18, 332);
            groupBoxRadioButtons.Margin = new Padding(3, 4, 3, 4);
            groupBoxRadioButtons.Name = "groupBoxRadioButtons";
            groupBoxRadioButtons.Padding = new Padding(3, 4, 3, 4);
            groupBoxRadioButtons.Size = new Size(305, 133);
            groupBoxRadioButtons.TabIndex = 10;
            groupBoxRadioButtons.TabStop = false;
            groupBoxRadioButtons.Text = "Filter projects by status";
            // 
            // buttonAddNewProject
            // 
            buttonAddNewProject.Location = new Point(330, 341);
            buttonAddNewProject.Margin = new Padding(3, 4, 3, 4);
            buttonAddNewProject.Name = "buttonAddNewProject";
            buttonAddNewProject.Size = new Size(106, 64);
            buttonAddNewProject.TabIndex = 11;
            buttonAddNewProject.Text = "Add new project";
            buttonAddNewProject.UseVisualStyleBackColor = true;
            buttonAddNewProject.Click += buttonAddNewProject_Click;
            // 
            // buttonMoveToOnHold
            // 
            buttonMoveToOnHold.Location = new Point(330, 409);
            buttonMoveToOnHold.Margin = new Padding(3, 4, 3, 4);
            buttonMoveToOnHold.Name = "buttonMoveToOnHold";
            buttonMoveToOnHold.Size = new Size(106, 64);
            buttonMoveToOnHold.TabIndex = 12;
            buttonMoveToOnHold.Text = "Move to on hold";
            buttonMoveToOnHold.UseVisualStyleBackColor = true;
            buttonMoveToOnHold.Click += buttonMoveToOnHold_Click;
            // 
            // buttonMarkAsCompleted
            // 
            buttonMarkAsCompleted.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMarkAsCompleted.Location = new Point(443, 341);
            buttonMarkAsCompleted.Margin = new Padding(3, 4, 3, 4);
            buttonMarkAsCompleted.Name = "buttonMarkAsCompleted";
            buttonMarkAsCompleted.Size = new Size(106, 64);
            buttonMarkAsCompleted.TabIndex = 13;
            buttonMarkAsCompleted.Text = "Mark project as completed";
            buttonMarkAsCompleted.UseVisualStyleBackColor = true;
            buttonMarkAsCompleted.Click += buttonMarkAsCompleted_Click;
            // 
            // buttonAddTask
            // 
            buttonAddTask.Location = new Point(330, 481);
            buttonAddTask.Margin = new Padding(3, 4, 3, 4);
            buttonAddTask.Name = "buttonAddTask";
            buttonAddTask.Size = new Size(106, 64);
            buttonAddTask.TabIndex = 14;
            buttonAddTask.Text = "Add new task to project";
            buttonAddTask.UseVisualStyleBackColor = true;
            buttonAddTask.Click += buttonAddTask_Click;
            // 
            // buttonReactivateProject
            // 
            buttonReactivateProject.Location = new Point(443, 412);
            buttonReactivateProject.Margin = new Padding(3, 4, 3, 4);
            buttonReactivateProject.Name = "buttonReactivateProject";
            buttonReactivateProject.Size = new Size(106, 64);
            buttonReactivateProject.TabIndex = 15;
            buttonReactivateProject.Text = "Reactivate the project";
            buttonReactivateProject.UseVisualStyleBackColor = true;
            buttonReactivateProject.Click += buttonReactivateProject_Click;
            // 
            // buttonManageTasks
            // 
            buttonManageTasks.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonManageTasks.Location = new Point(443, 481);
            buttonManageTasks.Margin = new Padding(3, 4, 3, 4);
            buttonManageTasks.Name = "buttonManageTasks";
            buttonManageTasks.Size = new Size(106, 64);
            buttonManageTasks.TabIndex = 16;
            buttonManageTasks.Text = "Manage tasks in project";
            buttonManageTasks.UseVisualStyleBackColor = true;
            buttonManageTasks.Click += buttonManageTasks_Click;
            // 
            // ProjectForManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 553);
            Controls.Add(buttonManageTasks);
            Controls.Add(buttonReactivateProject);
            Controls.Add(buttonAddTask);
            Controls.Add(buttonMarkAsCompleted);
            Controls.Add(buttonMoveToOnHold);
            Controls.Add(buttonAddNewProject);
            Controls.Add(groupBoxRadioButtons);
            Controls.Add(label1);
            Controls.Add(dataGridViewProjects);
            Margin = new Padding(3, 4, 3, 4);
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
namespace ProjectManager
{
    partial class EmployeeTaskView
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
            dataGridViewTasks = new DataGridView();
            groupBox1 = new GroupBox();
            radioButtonDeleted = new RadioButton();
            radioButtonFinished = new RadioButton();
            radioButtonWaitingForApproval = new RadioButton();
            radioButtonOnHold = new RadioButton();
            radioButtonOngoing = new RadioButton();
            radioButtonNotStarted = new RadioButton();
            label1 = new Label();
            buttonStartWork = new Button();
            buttonSendForApproval = new Button();
            labelTaskPriority = new Label();
            label6 = new Label();
            labelTaskFinishedDate = new Label();
            label5 = new Label();
            labelDeadlineDate = new Label();
            label4 = new Label();
            labelTaskCreationDate = new Label();
            textBoxTaskDescription = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewTasks
            // 
            dataGridViewTasks.AllowUserToAddRows = false;
            dataGridViewTasks.AllowUserToDeleteRows = false;
            dataGridViewTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTasks.Location = new Point(12, 24);
            dataGridViewTasks.MultiSelect = false;
            dataGridViewTasks.Name = "dataGridViewTasks";
            dataGridViewTasks.ReadOnly = true;
            dataGridViewTasks.RowTemplate.Height = 25;
            dataGridViewTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTasks.Size = new Size(417, 214);
            dataGridViewTasks.TabIndex = 2;
            dataGridViewTasks.CellClick += dataGridViewTasks_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonDeleted);
            groupBox1.Controls.Add(radioButtonFinished);
            groupBox1.Controls.Add(radioButtonWaitingForApproval);
            groupBox1.Controls.Add(radioButtonOnHold);
            groupBox1.Controls.Add(radioButtonOngoing);
            groupBox1.Controls.Add(radioButtonNotStarted);
            groupBox1.Location = new Point(12, 244);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(238, 107);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Task status";
            // 
            // radioButtonDeleted
            // 
            radioButtonDeleted.AutoSize = true;
            radioButtonDeleted.Location = new Point(102, 75);
            radioButtonDeleted.Name = "radioButtonDeleted";
            radioButtonDeleted.Size = new Size(65, 19);
            radioButtonDeleted.TabIndex = 4;
            radioButtonDeleted.TabStop = true;
            radioButtonDeleted.Text = "Deleted";
            radioButtonDeleted.UseVisualStyleBackColor = true;
            radioButtonDeleted.CheckedChanged += radioButtonDeleted_CheckedChanged;
            // 
            // radioButtonFinished
            // 
            radioButtonFinished.AutoSize = true;
            radioButtonFinished.Location = new Point(102, 50);
            radioButtonFinished.Name = "radioButtonFinished";
            radioButtonFinished.Size = new Size(69, 19);
            radioButtonFinished.TabIndex = 4;
            radioButtonFinished.TabStop = true;
            radioButtonFinished.Text = "Finished";
            radioButtonFinished.UseVisualStyleBackColor = true;
            radioButtonFinished.CheckedChanged += radioButtonFinished_CheckedChanged;
            // 
            // radioButtonWaitingForApproval
            // 
            radioButtonWaitingForApproval.AutoSize = true;
            radioButtonWaitingForApproval.Location = new Point(102, 25);
            radioButtonWaitingForApproval.Name = "radioButtonWaitingForApproval";
            radioButtonWaitingForApproval.Size = new Size(133, 19);
            radioButtonWaitingForApproval.TabIndex = 3;
            radioButtonWaitingForApproval.TabStop = true;
            radioButtonWaitingForApproval.Text = "Waiting for approval";
            radioButtonWaitingForApproval.UseVisualStyleBackColor = true;
            radioButtonWaitingForApproval.CheckedChanged += radioButtonWaitingForApproval_CheckedChanged;
            // 
            // radioButtonOnHold
            // 
            radioButtonOnHold.AutoSize = true;
            radioButtonOnHold.Location = new Point(12, 75);
            radioButtonOnHold.Name = "radioButtonOnHold";
            radioButtonOnHold.Size = new Size(68, 19);
            radioButtonOnHold.TabIndex = 2;
            radioButtonOnHold.TabStop = true;
            radioButtonOnHold.Text = "On hold";
            radioButtonOnHold.UseVisualStyleBackColor = true;
            radioButtonOnHold.CheckedChanged += radioButtonOnHold_CheckedChanged;
            // 
            // radioButtonOngoing
            // 
            radioButtonOngoing.AutoSize = true;
            radioButtonOngoing.Location = new Point(12, 50);
            radioButtonOngoing.Name = "radioButtonOngoing";
            radioButtonOngoing.Size = new Size(72, 19);
            radioButtonOngoing.TabIndex = 1;
            radioButtonOngoing.TabStop = true;
            radioButtonOngoing.Text = "Ongoing";
            radioButtonOngoing.UseVisualStyleBackColor = true;
            radioButtonOngoing.CheckedChanged += radioButtonOngoing_CheckedChanged;
            // 
            // radioButtonNotStarted
            // 
            radioButtonNotStarted.AutoSize = true;
            radioButtonNotStarted.Location = new Point(12, 25);
            radioButtonNotStarted.Name = "radioButtonNotStarted";
            radioButtonNotStarted.Size = new Size(84, 19);
            radioButtonNotStarted.TabIndex = 0;
            radioButtonNotStarted.TabStop = true;
            radioButtonNotStarted.Text = "Not started";
            radioButtonNotStarted.UseVisualStyleBackColor = true;
            radioButtonNotStarted.CheckedChanged += radioButtonNotStarted_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(156, 15);
            label1.TabIndex = 4;
            label1.Text = "List of tasks assigned to user";
            // 
            // buttonStartWork
            // 
            buttonStartWork.Location = new Point(256, 256);
            buttonStartWork.Name = "buttonStartWork";
            buttonStartWork.Size = new Size(173, 44);
            buttonStartWork.TabIndex = 5;
            buttonStartWork.Text = "Start working on a task";
            buttonStartWork.UseVisualStyleBackColor = true;
            buttonStartWork.Click += buttonStartWork_Click;
            // 
            // buttonSendForApproval
            // 
            buttonSendForApproval.Location = new Point(256, 306);
            buttonSendForApproval.Name = "buttonSendForApproval";
            buttonSendForApproval.Size = new Size(173, 44);
            buttonSendForApproval.TabIndex = 6;
            buttonSendForApproval.Text = "Send task for approval";
            buttonSendForApproval.UseVisualStyleBackColor = true;
            buttonSendForApproval.Click += buttonSendForApproval_Click;
            // 
            // labelTaskPriority
            // 
            labelTaskPriority.AutoSize = true;
            labelTaskPriority.Location = new Point(436, 184);
            labelTaskPriority.Name = "labelTaskPriority";
            labelTaskPriority.Size = new Size(16, 15);
            labelTaskPriority.TabIndex = 28;
            labelTaskPriority.Text = "...";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(435, 166);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 27;
            label6.Text = "Task priority:";
            // 
            // labelTaskFinishedDate
            // 
            labelTaskFinishedDate.AutoSize = true;
            labelTaskFinishedDate.Location = new Point(436, 139);
            labelTaskFinishedDate.Name = "labelTaskFinishedDate";
            labelTaskFinishedDate.Size = new Size(16, 15);
            labelTaskFinishedDate.TabIndex = 26;
            labelTaskFinishedDate.Text = "...";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(435, 121);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 25;
            label5.Text = "Task finished date:";
            // 
            // labelDeadlineDate
            // 
            labelDeadlineDate.AutoSize = true;
            labelDeadlineDate.Location = new Point(436, 92);
            labelDeadlineDate.Name = "labelDeadlineDate";
            labelDeadlineDate.Size = new Size(16, 15);
            labelDeadlineDate.TabIndex = 24;
            labelDeadlineDate.Text = "...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(435, 74);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 23;
            label4.Text = "Task deadline date:";
            // 
            // labelTaskCreationDate
            // 
            labelTaskCreationDate.AutoSize = true;
            labelTaskCreationDate.Location = new Point(436, 42);
            labelTaskCreationDate.Name = "labelTaskCreationDate";
            labelTaskCreationDate.Size = new Size(16, 15);
            labelTaskCreationDate.TabIndex = 22;
            labelTaskCreationDate.Text = "...";
            // 
            // textBoxTaskDescription
            // 
            textBoxTaskDescription.Enabled = false;
            textBoxTaskDescription.Location = new Point(435, 241);
            textBoxTaskDescription.Multiline = true;
            textBoxTaskDescription.Name = "textBoxTaskDescription";
            textBoxTaskDescription.Size = new Size(188, 64);
            textBoxTaskDescription.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(435, 24);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 20;
            label2.Text = "Task creation date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(435, 223);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 19;
            label3.Text = "Task description:";
            // 
            // EmployeeTaskView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 355);
            Controls.Add(labelTaskPriority);
            Controls.Add(label6);
            Controls.Add(labelTaskFinishedDate);
            Controls.Add(label5);
            Controls.Add(labelDeadlineDate);
            Controls.Add(label4);
            Controls.Add(labelTaskCreationDate);
            Controls.Add(textBoxTaskDescription);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(buttonSendForApproval);
            Controls.Add(buttonStartWork);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewTasks);
            Name = "EmployeeTaskView";
            Text = "EmployeeTaskView";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewTasks;
        private GroupBox groupBox1;
        private RadioButton radioButtonDeleted;
        private RadioButton radioButtonFinished;
        private RadioButton radioButtonWaitingForApproval;
        private RadioButton radioButtonOnHold;
        private RadioButton radioButtonOngoing;
        private RadioButton radioButtonNotStarted;
        private Label label1;
        private Button buttonStartWork;
        private Button buttonSendForApproval;
        private Label labelTaskPriority;
        private Label label6;
        private Label labelTaskFinishedDate;
        private Label label5;
        private Label labelDeadlineDate;
        private Label label4;
        private Label labelTaskCreationDate;
        private TextBox textBoxTaskDescription;
        private Label label2;
        private Label label3;
    }
}
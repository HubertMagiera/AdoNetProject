namespace ProjectManager
{
    partial class ProjectDetailedView
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
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            dataGridViewTasks = new DataGridView();
            labelProjectInfo = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            radioButtonDeleted = new RadioButton();
            radioButtonFinished = new RadioButton();
            radioButtonOnHold = new RadioButton();
            radioButtonWaitingForApproval = new RadioButton();
            radioButtonOngoing = new RadioButton();
            radioButtonNotStarted = new RadioButton();
            buttonAddNewTask = new Button();
            buttonDelete = new Button();
            buttonApprove = new Button();
            buttonPutOnHold = new Button();
            label2 = new Label();
            textBoxTaskDescription = new TextBox();
            labelTaskCreationDate = new Label();
            labelDeadlineDate = new Label();
            label4 = new Label();
            labelTaskFinishedDate = new Label();
            label5 = new Label();
            labelTaskPriority = new Label();
            label6 = new Label();
            buttonCancel = new Button();
            buttonReactivateTask = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // dataGridViewTasks
            // 
            dataGridViewTasks.AllowUserToAddRows = false;
            dataGridViewTasks.AllowUserToDeleteRows = false;
            dataGridViewTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTasks.Location = new Point(12, 37);
            dataGridViewTasks.MultiSelect = false;
            dataGridViewTasks.Name = "dataGridViewTasks";
            dataGridViewTasks.ReadOnly = true;
            dataGridViewTasks.RowTemplate.Height = 25;
            dataGridViewTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTasks.Size = new Size(417, 214);
            dataGridViewTasks.TabIndex = 1;
            dataGridViewTasks.CellClick += dataGridViewTasks_CellClick;
            // 
            // labelProjectInfo
            // 
            labelProjectInfo.AutoSize = true;
            labelProjectInfo.Location = new Point(12, 19);
            labelProjectInfo.Name = "labelProjectInfo";
            labelProjectInfo.Size = new Size(125, 15);
            labelProjectInfo.TabIndex = 2;
            labelProjectInfo.Text = "Tasks view for project: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(446, 236);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 3;
            label1.Text = "Task description:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonDeleted);
            groupBox1.Controls.Add(radioButtonFinished);
            groupBox1.Controls.Add(radioButtonOnHold);
            groupBox1.Controls.Add(radioButtonWaitingForApproval);
            groupBox1.Controls.Add(radioButtonOngoing);
            groupBox1.Controls.Add(radioButtonNotStarted);
            groupBox1.Location = new Point(12, 257);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(218, 122);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Task status";
            // 
            // radioButtonDeleted
            // 
            radioButtonDeleted.AutoSize = true;
            radioButtonDeleted.Location = new Point(146, 67);
            radioButtonDeleted.Name = "radioButtonDeleted";
            radioButtonDeleted.Size = new Size(65, 19);
            radioButtonDeleted.TabIndex = 7;
            radioButtonDeleted.TabStop = true;
            radioButtonDeleted.Text = "Deleted";
            radioButtonDeleted.UseVisualStyleBackColor = true;
            radioButtonDeleted.CheckedChanged += radioButtonDeleted_CheckedChanged;
            // 
            // radioButtonFinished
            // 
            radioButtonFinished.AutoSize = true;
            radioButtonFinished.Location = new Point(146, 42);
            radioButtonFinished.Name = "radioButtonFinished";
            radioButtonFinished.Size = new Size(69, 19);
            radioButtonFinished.TabIndex = 7;
            radioButtonFinished.TabStop = true;
            radioButtonFinished.Text = "Finished";
            radioButtonFinished.UseVisualStyleBackColor = true;
            radioButtonFinished.CheckedChanged += radioButtonFinished_CheckedChanged;
            // 
            // radioButtonOnHold
            // 
            radioButtonOnHold.AutoSize = true;
            radioButtonOnHold.Location = new Point(146, 17);
            radioButtonOnHold.Name = "radioButtonOnHold";
            radioButtonOnHold.Size = new Size(68, 19);
            radioButtonOnHold.TabIndex = 6;
            radioButtonOnHold.TabStop = true;
            radioButtonOnHold.Text = "On hold";
            radioButtonOnHold.UseVisualStyleBackColor = true;
            radioButtonOnHold.CheckedChanged += radioButtonOnHold_CheckedChanged;
            // 
            // radioButtonWaitingForApproval
            // 
            radioButtonWaitingForApproval.AutoSize = true;
            radioButtonWaitingForApproval.Location = new Point(6, 67);
            radioButtonWaitingForApproval.Name = "radioButtonWaitingForApproval";
            radioButtonWaitingForApproval.Size = new Size(133, 19);
            radioButtonWaitingForApproval.TabIndex = 5;
            radioButtonWaitingForApproval.TabStop = true;
            radioButtonWaitingForApproval.Text = "Waiting for approval";
            radioButtonWaitingForApproval.UseVisualStyleBackColor = true;
            radioButtonWaitingForApproval.CheckedChanged += radioButtonWaitingForApproval_CheckedChanged;
            // 
            // radioButtonOngoing
            // 
            radioButtonOngoing.AutoSize = true;
            radioButtonOngoing.Location = new Point(7, 42);
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
            radioButtonNotStarted.Location = new Point(7, 17);
            radioButtonNotStarted.Name = "radioButtonNotStarted";
            radioButtonNotStarted.Size = new Size(84, 19);
            radioButtonNotStarted.TabIndex = 0;
            radioButtonNotStarted.TabStop = true;
            radioButtonNotStarted.Text = "Not started";
            radioButtonNotStarted.UseVisualStyleBackColor = true;
            radioButtonNotStarted.CheckedChanged += radioButtonNotStarted_CheckedChanged;
            // 
            // buttonAddNewTask
            // 
            buttonAddNewTask.Location = new Point(241, 265);
            buttonAddNewTask.Name = "buttonAddNewTask";
            buttonAddNewTask.Size = new Size(91, 53);
            buttonAddNewTask.TabIndex = 5;
            buttonAddNewTask.Text = "Add New Task";
            buttonAddNewTask.UseVisualStyleBackColor = true;
            buttonAddNewTask.Click += buttonAddNewTask_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(338, 265);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(91, 55);
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "Delete Task";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonApprove
            // 
            buttonApprove.Location = new Point(241, 320);
            buttonApprove.Name = "buttonApprove";
            buttonApprove.Size = new Size(91, 59);
            buttonApprove.TabIndex = 7;
            buttonApprove.Text = "Approve Task";
            buttonApprove.UseVisualStyleBackColor = true;
            buttonApprove.Click += buttonApprove_Click;
            // 
            // buttonPutOnHold
            // 
            buttonPutOnHold.Location = new Point(338, 324);
            buttonPutOnHold.Name = "buttonPutOnHold";
            buttonPutOnHold.Size = new Size(91, 55);
            buttonPutOnHold.TabIndex = 8;
            buttonPutOnHold.Text = "Put Task On Hold";
            buttonPutOnHold.UseVisualStyleBackColor = true;
            buttonPutOnHold.Click += buttonPutOnHold_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(446, 37);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 10;
            label2.Text = "Task creation date:";
            // 
            // textBoxTaskDescription
            // 
            textBoxTaskDescription.Enabled = false;
            textBoxTaskDescription.Location = new Point(446, 254);
            textBoxTaskDescription.Multiline = true;
            textBoxTaskDescription.Name = "textBoxTaskDescription";
            textBoxTaskDescription.Size = new Size(188, 64);
            textBoxTaskDescription.TabIndex = 11;
            // 
            // labelTaskCreationDate
            // 
            labelTaskCreationDate.AutoSize = true;
            labelTaskCreationDate.Location = new Point(447, 55);
            labelTaskCreationDate.Name = "labelTaskCreationDate";
            labelTaskCreationDate.Size = new Size(0, 15);
            labelTaskCreationDate.TabIndex = 12;
            // 
            // labelDeadlineDate
            // 
            labelDeadlineDate.AutoSize = true;
            labelDeadlineDate.Location = new Point(447, 105);
            labelDeadlineDate.Name = "labelDeadlineDate";
            labelDeadlineDate.Size = new Size(0, 15);
            labelDeadlineDate.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(446, 87);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 13;
            label4.Text = "Task deadline date:";
            // 
            // labelTaskFinishedDate
            // 
            labelTaskFinishedDate.AutoSize = true;
            labelTaskFinishedDate.Location = new Point(447, 152);
            labelTaskFinishedDate.Name = "labelTaskFinishedDate";
            labelTaskFinishedDate.Size = new Size(0, 15);
            labelTaskFinishedDate.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(446, 134);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 15;
            label5.Text = "Task finished date:";
            // 
            // labelTaskPriority
            // 
            labelTaskPriority.AutoSize = true;
            labelTaskPriority.Location = new Point(447, 197);
            labelTaskPriority.Name = "labelTaskPriority";
            labelTaskPriority.Size = new Size(0, 15);
            labelTaskPriority.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(446, 179);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 17;
            label6.Text = "Task priority:";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(543, 320);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(91, 55);
            buttonCancel.TabIndex = 19;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonReactivateTask
            // 
            buttonReactivateTask.Location = new Point(446, 320);
            buttonReactivateTask.Name = "buttonReactivateTask";
            buttonReactivateTask.Size = new Size(91, 55);
            buttonReactivateTask.TabIndex = 20;
            buttonReactivateTask.Text = "Reactivate Task";
            buttonReactivateTask.UseVisualStyleBackColor = true;
            buttonReactivateTask.Click += buttonReactivateTask_Click;
            // 
            // ProjectDetailedView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 383);
            Controls.Add(buttonReactivateTask);
            Controls.Add(buttonCancel);
            Controls.Add(labelTaskPriority);
            Controls.Add(label6);
            Controls.Add(labelTaskFinishedDate);
            Controls.Add(label5);
            Controls.Add(labelDeadlineDate);
            Controls.Add(label4);
            Controls.Add(labelTaskCreationDate);
            Controls.Add(textBoxTaskDescription);
            Controls.Add(label2);
            Controls.Add(buttonPutOnHold);
            Controls.Add(buttonApprove);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAddNewTask);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(labelProjectInfo);
            Controls.Add(dataGridViewTasks);
            Name = "ProjectDetailedView";
            Text = "ProjectDetailedView";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private DataGridView dataGridViewTasks;
        private Label labelProjectInfo;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton radioButtonDeleted;
        private RadioButton radioButtonFinished;
        private RadioButton radioButtonOnHold;
        private RadioButton radioButtonWaitingForApproval;
        private RadioButton radioButtonOngoing;
        private RadioButton radioButtonNotStarted;
        private Button buttonAddNewTask;
        private Button buttonDelete;
        private Button buttonApprove;
        private Button buttonPutOnHold;
        private Label label2;
        private TextBox textBoxTaskDescription;
        private Label labelTaskCreationDate;
        private Label labelDeadlineDate;
        private Label label4;
        private Label labelTaskFinishedDate;
        private Label label5;
        private Label labelTaskPriority;
        private Label label6;
        private Button buttonCancel;
        private Button buttonReactivateTask;
    }
}
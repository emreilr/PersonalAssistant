namespace PersonalApplication
{
    partial class Reminder
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
            this.components = new System.ComponentModel.Container();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUptade = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.lblDateandTime = new System.Windows.Forms.Label();
            this.DateTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.mtxtboxTime = new System.Windows.Forms.MaskedTextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rdobtnMeeting = new System.Windows.Forms.RadioButton();
            this.rdobtnTask = new System.Windows.Forms.RadioButton();
            this.lblType = new System.Windows.Forms.Label();
            this.grpboxType = new System.Windows.Forms.GroupBox();
            this.txtboxDate = new System.Windows.Forms.TextBox();
            this.lstReminder = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnMainWindow = new System.Windows.Forms.Button();
            this.grpboxType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(346, 349);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(98, 29);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(654, 349);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 29);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUptade
            // 
            this.btnUptade.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUptade.Location = new System.Drawing.Point(551, 349);
            this.btnUptade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUptade.Name = "btnUptade";
            this.btnUptade.Size = new System.Drawing.Size(98, 29);
            this.btnUptade.TabIndex = 7;
            this.btnUptade.Text = "Update";
            this.btnUptade.UseVisualStyleBackColor = true;
            this.btnUptade.Click += new System.EventHandler(this.btnUptade_Click);
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(448, 349);
            this.btnList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(98, 29);
            this.btnList.TabIndex = 6;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // lblDateandTime
            // 
            this.lblDateandTime.AutoSize = true;
            this.lblDateandTime.Location = new System.Drawing.Point(9, 14);
            this.lblDateandTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateandTime.Name = "lblDateandTime";
            this.lblDateandTime.Size = new System.Drawing.Size(0, 13);
            this.lblDateandTime.TabIndex = 17;
            // 
            // DateTimeTimer
            // 
            this.DateTimeTimer.Enabled = true;
            this.DateTimeTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(138, 14);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(185, 20);
            this.dtpDate.TabIndex = 0;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(138, 180);
            this.txtSummary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(185, 83);
            this.txtSummary.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(138, 286);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(185, 83);
            this.txtDescription.TabIndex = 4;
            // 
            // mtxtboxTime
            // 
            this.mtxtboxTime.Location = new System.Drawing.Point(138, 139);
            this.mtxtboxTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtxtboxTime.Mask = "00:00";
            this.mtxtboxTime.Name = "mtxtboxTime";
            this.mtxtboxTime.Size = new System.Drawing.Size(185, 20);
            this.mtxtboxTime.TabIndex = 2;
            this.mtxtboxTime.ValidatingType = typeof(System.DateTime);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.Location = new System.Drawing.Point(39, 98);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 18);
            this.lblDate.TabIndex = 24;
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.Location = new System.Drawing.Point(35, 139);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(41, 18);
            this.lblTime.TabIndex = 25;
            this.lblTime.Text = "Time";
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSummary.Location = new System.Drawing.Point(35, 203);
            this.lblSummary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(72, 18);
            this.lblSummary.TabIndex = 26;
            this.lblSummary.Text = "Summary";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDescription.Location = new System.Drawing.Point(35, 315);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(83, 18);
            this.lblDescription.TabIndex = 27;
            this.lblDescription.Text = "Description";
            // 
            // rdobtnMeeting
            // 
            this.rdobtnMeeting.AutoSize = true;
            this.rdobtnMeeting.Location = new System.Drawing.Point(31, 4);
            this.rdobtnMeeting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdobtnMeeting.Name = "rdobtnMeeting";
            this.rdobtnMeeting.Size = new System.Drawing.Size(63, 17);
            this.rdobtnMeeting.TabIndex = 28;
            this.rdobtnMeeting.TabStop = true;
            this.rdobtnMeeting.Text = "Meeting";
            this.rdobtnMeeting.UseVisualStyleBackColor = true;
            // 
            // rdobtnTask
            // 
            this.rdobtnTask.AutoSize = true;
            this.rdobtnTask.Location = new System.Drawing.Point(254, 50);
            this.rdobtnTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdobtnTask.Name = "rdobtnTask";
            this.rdobtnTask.Size = new System.Drawing.Size(49, 17);
            this.rdobtnTask.TabIndex = 29;
            this.rdobtnTask.TabStop = true;
            this.rdobtnTask.Text = "Task";
            this.rdobtnTask.UseVisualStyleBackColor = true;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblType.Location = new System.Drawing.Point(35, 48);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(44, 18);
            this.lblType.TabIndex = 31;
            this.lblType.Text = " Type";
            // 
            // grpboxType
            // 
            this.grpboxType.Controls.Add(this.rdobtnMeeting);
            this.grpboxType.Location = new System.Drawing.Point(118, 46);
            this.grpboxType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpboxType.Name = "grpboxType";
            this.grpboxType.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpboxType.Size = new System.Drawing.Size(162, 21);
            this.grpboxType.TabIndex = 32;
            this.grpboxType.TabStop = false;
            // 
            // txtboxDate
            // 
            this.txtboxDate.Location = new System.Drawing.Point(138, 98);
            this.txtboxDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtboxDate.Name = "txtboxDate";
            this.txtboxDate.Size = new System.Drawing.Size(185, 20);
            this.txtboxDate.TabIndex = 1;
            // 
            // lstReminder
            // 
            this.lstReminder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstReminder.FullRowSelect = true;
            this.lstReminder.GridLines = true;
            this.lstReminder.HideSelection = false;
            this.lstReminder.Location = new System.Drawing.Point(346, 14);
            this.lstReminder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstReminder.Name = "lstReminder";
            this.lstReminder.Size = new System.Drawing.Size(534, 304);
            this.lstReminder.TabIndex = 10;
            this.lstReminder.UseCompatibleStateImageBehavior = false;
            this.lstReminder.View = System.Windows.Forms.View.Details;
            this.lstReminder.SelectedIndexChanged += new System.EventHandler(this.lstReminder_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Date";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Time";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Summary";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Description";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Type";
            this.columnHeader5.Width = 138;
            // 
            // btnMainWindow
            // 
            this.btnMainWindow.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainWindow.Location = new System.Drawing.Point(784, 356);
            this.btnMainWindow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMainWindow.Name = "btnMainWindow";
            this.btnMainWindow.Size = new System.Drawing.Size(111, 47);
            this.btnMainWindow.TabIndex = 9;
            this.btnMainWindow.Text = "Return";
            this.btnMainWindow.UseVisualStyleBackColor = true;
            this.btnMainWindow.Click += new System.EventHandler(this.btnMainWindow_Click);
            // 
            // Reminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 414);
            this.Controls.Add(this.rdobtnTask);
            this.Controls.Add(this.btnMainWindow);
            this.Controls.Add(this.lstReminder);
            this.Controls.Add(this.txtboxDate);
            this.Controls.Add(this.grpboxType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.mtxtboxTime);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDateandTime);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnUptade);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Reminder";
            this.Text = "Reminder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reminder_FormClosing);
            this.grpboxType.ResumeLayout(false);
            this.grpboxType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUptade;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label lblDateandTime;
        private System.Windows.Forms.Timer DateTimeTimer;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.MaskedTextBox mtxtboxTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RadioButton rdobtnMeeting;
        private System.Windows.Forms.RadioButton rdobtnTask;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.GroupBox grpboxType;
        private System.Windows.Forms.TextBox txtboxDate;
        private System.Windows.Forms.ListView lstReminder;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnMainWindow;
    }
}
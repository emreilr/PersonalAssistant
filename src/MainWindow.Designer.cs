namespace PersonalApplication
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.btnLogOut = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnUser_Management = new System.Windows.Forms.Button();
            this.lbluser_management = new System.Windows.Forms.Label();
            this.btnPhonebook = new System.Windows.Forms.Button();
            this.btnNotes = new System.Windows.Forms.Button();
            this.btnPersonalInformation = new System.Windows.Forms.Button();
            this.btnSalaryCalculator = new System.Windows.Forms.Button();
            this.btnReminder = new System.Windows.Forms.Button();
            this.ReminderTimer = new System.Windows.Forms.Timer(this.components);
            this.ShakeTimer = new System.Windows.Forms.Timer(this.components);
            this.MainFormLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogOut.Location = new System.Drawing.Point(724, 369);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(112, 109);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnUser_Management
            // 
            this.btnUser_Management.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUser_Management.Location = new System.Drawing.Point(176, 370);
            this.btnUser_Management.Margin = new System.Windows.Forms.Padding(4);
            this.btnUser_Management.Name = "btnUser_Management";
            this.btnUser_Management.Size = new System.Drawing.Size(188, 108);
            this.btnUser_Management.TabIndex = 5;
            this.btnUser_Management.Text = "User Management";
            this.btnUser_Management.UseVisualStyleBackColor = true;
            this.btnUser_Management.Click += new System.EventHandler(this.btnUser_Management_Click);
            // 
            // lbluser_management
            // 
            this.lbluser_management.AutoSize = true;
            this.lbluser_management.Location = new System.Drawing.Point(448, 80);
            this.lbluser_management.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbluser_management.Name = "lbluser_management";
            this.lbluser_management.Size = new System.Drawing.Size(0, 13);
            this.lbluser_management.TabIndex = 6;
            // 
            // btnPhonebook
            // 
            this.btnPhonebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPhonebook.Image = ((System.Drawing.Image)(resources.GetObject("btnPhonebook.Image")));
            this.btnPhonebook.Location = new System.Drawing.Point(0, 32);
            this.btnPhonebook.Margin = new System.Windows.Forms.Padding(2);
            this.btnPhonebook.Name = "btnPhonebook";
            this.btnPhonebook.Size = new System.Drawing.Size(211, 221);
            this.btnPhonebook.TabIndex = 7;
            this.btnPhonebook.UseVisualStyleBackColor = true;
            this.btnPhonebook.Click += new System.EventHandler(this.btnPhonebook_Click);
            // 
            // btnNotes
            // 
            this.btnNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotes.Image = ((System.Drawing.Image)(resources.GetObject("btnNotes.Image")));
            this.btnNotes.Location = new System.Drawing.Point(206, 31);
            this.btnNotes.Margin = new System.Windows.Forms.Padding(2);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(215, 222);
            this.btnNotes.TabIndex = 8;
            this.btnNotes.UseVisualStyleBackColor = true;
            this.btnNotes.Click += new System.EventHandler(this.btnNotes_Click);
            // 
            // btnPersonalInformation
            // 
            this.btnPersonalInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonalInformation.Location = new System.Drawing.Point(11, 369);
            this.btnPersonalInformation.Margin = new System.Windows.Forms.Padding(2);
            this.btnPersonalInformation.Name = "btnPersonalInformation";
            this.btnPersonalInformation.Size = new System.Drawing.Size(169, 109);
            this.btnPersonalInformation.TabIndex = 9;
            this.btnPersonalInformation.Text = "Personal Information";
            this.btnPersonalInformation.UseVisualStyleBackColor = true;
            this.btnPersonalInformation.Click += new System.EventHandler(this.btnPersonalInformation_Click);
            // 
            // btnSalaryCalculator
            // 
            this.btnSalaryCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalaryCalculator.Image = ((System.Drawing.Image)(resources.GetObject("btnSalaryCalculator.Image")));
            this.btnSalaryCalculator.Location = new System.Drawing.Point(413, 31);
            this.btnSalaryCalculator.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalaryCalculator.Name = "btnSalaryCalculator";
            this.btnSalaryCalculator.Size = new System.Drawing.Size(215, 222);
            this.btnSalaryCalculator.TabIndex = 10;
            this.btnSalaryCalculator.UseVisualStyleBackColor = true;
            this.btnSalaryCalculator.Click += new System.EventHandler(this.btnSalaryCalculator_Click);
            // 
            // btnReminder
            // 
            this.btnReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReminder.Image = ((System.Drawing.Image)(resources.GetObject("btnReminder.Image")));
            this.btnReminder.Location = new System.Drawing.Point(621, 32);
            this.btnReminder.Margin = new System.Windows.Forms.Padding(2);
            this.btnReminder.Name = "btnReminder";
            this.btnReminder.Size = new System.Drawing.Size(218, 221);
            this.btnReminder.TabIndex = 11;
            this.btnReminder.UseVisualStyleBackColor = true;
            this.btnReminder.Click += new System.EventHandler(this.btnReminder_Click);
            // 
            // ReminderTimer
            // 
            this.ReminderTimer.Enabled = true;
            this.ReminderTimer.Interval = 1000;
            this.ReminderTimer.Tick += new System.EventHandler(this.ReminderTimer_Tick);
            // 
            // ShakeTimer
            // 
            this.ShakeTimer.Enabled = true;
            this.ShakeTimer.Interval = 1000;
            // 
            // MainFormLbl
            // 
            this.MainFormLbl.AutoSize = true;
            this.MainFormLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainFormLbl.Location = new System.Drawing.Point(329, 9);
            this.MainFormLbl.Name = "MainFormLbl";
            this.MainFormLbl.Size = new System.Drawing.Size(158, 29);
            this.MainFormLbl.TabIndex = 12;
            this.MainFormLbl.Text = "MAIN FORM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnPhonebook);
            this.panel1.Controls.Add(this.btnNotes);
            this.panel1.Controls.Add(this.btnReminder);
            this.panel1.Controls.Add(this.btnSalaryCalculator);
            this.panel1.Location = new System.Drawing.Point(1, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 300);
            this.panel1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(691, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Reminder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(446, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Salary Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(279, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Notes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(46, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Phone Book";
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExport.Location = new System.Drawing.Point(488, 381);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(141, 86);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(836, 479);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainFormLbl);
            this.Controls.Add(this.btnPersonalInformation);
            this.Controls.Add(this.lbluser_management);
            this.Controls.Add(this.btnUser_Management);
            this.Controls.Add(this.btnLogOut);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnUser_Management;
        private System.Windows.Forms.Label lbluser_management;
        private System.Windows.Forms.Button btnPhonebook;
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.Button btnPersonalInformation;
        private System.Windows.Forms.Button btnSalaryCalculator;
        private System.Windows.Forms.Button btnReminder;
        private System.Windows.Forms.Timer ReminderTimer;
        private System.Windows.Forms.Timer ShakeTimer;
        private System.Windows.Forms.Label MainFormLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExport;
    }
}
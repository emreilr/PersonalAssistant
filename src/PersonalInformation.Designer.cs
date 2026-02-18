namespace PersonalApplication
{
    partial class PersonalInformation
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
            this.mtxtboxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.txtboxMail = new System.Windows.Forms.TextBox();
            this.txtboxAddress = new System.Windows.Forms.TextBox();
            this.txtboxSurname = new System.Windows.Forms.TextBox();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.picBoxPhoto = new System.Windows.Forms.PictureBox();
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnMainWindow = new System.Windows.Forms.Button();
            this.pnlChangePassword = new System.Windows.Forms.Panel();
            this.chckBxShowOldPassword = new System.Windows.Forms.CheckBox();
            this.chckBxShowNewPassword = new System.Windows.Forms.CheckBox();
            this.btnPanelChange = new System.Windows.Forms.Button();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPhoto)).BeginInit();
            this.pnlChangePassword.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtxtboxPhoneNumber
            // 
            this.mtxtboxPhoneNumber.Location = new System.Drawing.Point(166, 83);
            this.mtxtboxPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtboxPhoneNumber.Mask = "(999) 000 00 00";
            this.mtxtboxPhoneNumber.Name = "mtxtboxPhoneNumber";
            this.mtxtboxPhoneNumber.Size = new System.Drawing.Size(177, 20);
            this.mtxtboxPhoneNumber.TabIndex = 20;
            // 
            // txtboxMail
            // 
            this.txtboxMail.Location = new System.Drawing.Point(166, 146);
            this.txtboxMail.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxMail.Name = "txtboxMail";
            this.txtboxMail.Size = new System.Drawing.Size(177, 20);
            this.txtboxMail.TabIndex = 23;
            // 
            // txtboxAddress
            // 
            this.txtboxAddress.Location = new System.Drawing.Point(166, 114);
            this.txtboxAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxAddress.Name = "txtboxAddress";
            this.txtboxAddress.Size = new System.Drawing.Size(177, 20);
            this.txtboxAddress.TabIndex = 21;
            // 
            // txtboxSurname
            // 
            this.txtboxSurname.Location = new System.Drawing.Point(166, 51);
            this.txtboxSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxSurname.Name = "txtboxSurname";
            this.txtboxSurname.Size = new System.Drawing.Size(177, 20);
            this.txtboxSurname.TabIndex = 19;
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(166, 19);
            this.txtboxName.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(177, 20);
            this.txtboxName.TabIndex = 18;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.Location = new System.Drawing.Point(8, 144);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(65, 20);
            this.lblMail.TabIndex = 17;
            this.lblMail.Text = "E-Mail";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddress.Location = new System.Drawing.Point(8, 112);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(81, 20);
            this.lblAddress.TabIndex = 15;
            this.lblAddress.Text = "Address";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(8, 81);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(140, 20);
            this.lblPhoneNumber.TabIndex = 14;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSurname.Location = new System.Drawing.Point(8, 49);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(87, 20);
            this.lblSurname.TabIndex = 13;
            this.lblSurname.Text = "Surname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(8, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 20);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name";
            // 
            // picBoxPhoto
            // 
            this.picBoxPhoto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picBoxPhoto.Location = new System.Drawing.Point(31, 31);
            this.picBoxPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxPhoto.Name = "picBoxPhoto";
            this.picBoxPhoto.Size = new System.Drawing.Size(136, 176);
            this.picBoxPhoto.TabIndex = 27;
            this.picBoxPhoto.TabStop = false;
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddPhoto.Location = new System.Drawing.Point(31, 222);
            this.btnAddPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(136, 28);
            this.btnAddPhoto.TabIndex = 28;
            this.btnAddPhoto.Text = "Add Photo";
            this.btnAddPhoto.UseVisualStyleBackColor = true;
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEdit.Location = new System.Drawing.Point(175, 179);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(136, 38);
            this.btnEdit.TabIndex = 29;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnMainWindow
            // 
            this.btnMainWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMainWindow.Location = new System.Drawing.Point(461, 315);
            this.btnMainWindow.Margin = new System.Windows.Forms.Padding(2);
            this.btnMainWindow.Name = "btnMainWindow";
            this.btnMainWindow.Size = new System.Drawing.Size(128, 41);
            this.btnMainWindow.TabIndex = 30;
            this.btnMainWindow.Text = "Return";
            this.btnMainWindow.UseVisualStyleBackColor = true;
            this.btnMainWindow.Click += new System.EventHandler(this.btnMainWindow_Click);
            // 
            // pnlChangePassword
            // 
            this.pnlChangePassword.BackColor = System.Drawing.Color.Gray;
            this.pnlChangePassword.Controls.Add(this.chckBxShowOldPassword);
            this.pnlChangePassword.Controls.Add(this.chckBxShowNewPassword);
            this.pnlChangePassword.Controls.Add(this.btnPanelChange);
            this.pnlChangePassword.Controls.Add(this.txtOldPassword);
            this.pnlChangePassword.Controls.Add(this.lblOldPassword);
            this.pnlChangePassword.Controls.Add(this.txtNewPassword);
            this.pnlChangePassword.Controls.Add(this.lblNewPassword);
            this.pnlChangePassword.Location = new System.Drawing.Point(11, 239);
            this.pnlChangePassword.Margin = new System.Windows.Forms.Padding(2);
            this.pnlChangePassword.Name = "pnlChangePassword";
            this.pnlChangePassword.Size = new System.Drawing.Size(373, 117);
            this.pnlChangePassword.TabIndex = 31;
            this.pnlChangePassword.Visible = false;
            // 
            // chckBxShowOldPassword
            // 
            this.chckBxShowOldPassword.AutoSize = true;
            this.chckBxShowOldPassword.Location = new System.Drawing.Point(313, 51);
            this.chckBxShowOldPassword.Margin = new System.Windows.Forms.Padding(2);
            this.chckBxShowOldPassword.Name = "chckBxShowOldPassword";
            this.chckBxShowOldPassword.Size = new System.Drawing.Size(53, 17);
            this.chckBxShowOldPassword.TabIndex = 37;
            this.chckBxShowOldPassword.Text = "Show";
            this.chckBxShowOldPassword.UseVisualStyleBackColor = true;
            this.chckBxShowOldPassword.CheckedChanged += new System.EventHandler(this.chckBxShowOldPassword_CheckedChanged);
            // 
            // chckBxShowNewPassword
            // 
            this.chckBxShowNewPassword.AutoSize = true;
            this.chckBxShowNewPassword.Location = new System.Drawing.Point(313, 13);
            this.chckBxShowNewPassword.Margin = new System.Windows.Forms.Padding(2);
            this.chckBxShowNewPassword.Name = "chckBxShowNewPassword";
            this.chckBxShowNewPassword.Size = new System.Drawing.Size(53, 17);
            this.chckBxShowNewPassword.TabIndex = 36;
            this.chckBxShowNewPassword.Text = "Show";
            this.chckBxShowNewPassword.UseVisualStyleBackColor = true;
            this.chckBxShowNewPassword.CheckedChanged += new System.EventHandler(this.chckBxShowNewPassword_CheckedChanged);
            // 
            // btnPanelChange
            // 
            this.btnPanelChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPanelChange.Location = new System.Drawing.Point(219, 73);
            this.btnPanelChange.Margin = new System.Windows.Forms.Padding(2);
            this.btnPanelChange.Name = "btnPanelChange";
            this.btnPanelChange.Size = new System.Drawing.Size(88, 31);
            this.btnPanelChange.TabIndex = 33;
            this.btnPanelChange.Text = "Change";
            this.btnPanelChange.UseVisualStyleBackColor = true;
            this.btnPanelChange.Click += new System.EventHandler(this.btnPanelChange_Click);
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(155, 48);
            this.txtOldPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(153, 20);
            this.txtOldPassword.TabIndex = 35;
            this.txtOldPassword.UseSystemPasswordChar = true;
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOldPassword.Location = new System.Drawing.Point(11, 46);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(132, 20);
            this.lblOldPassword.TabIndex = 34;
            this.lblOldPassword.Text = "Old Password";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(155, 13);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(153, 20);
            this.txtNewPassword.TabIndex = 33;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNewPassword.Location = new System.Drawing.Point(11, 11);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(139, 20);
            this.lblNewPassword.TabIndex = 32;
            this.lblNewPassword.Text = "New Password";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChangePassword.Location = new System.Drawing.Point(9, 179);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(162, 38);
            this.btnChangePassword.TabIndex = 32;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.btnChangePassword);
            this.panel1.Controls.Add(this.lblSurname);
            this.panel1.Controls.Add(this.lblPhoneNumber);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.lblMail);
            this.panel1.Controls.Add(this.txtboxName);
            this.panel1.Controls.Add(this.txtboxSurname);
            this.panel1.Controls.Add(this.mtxtboxPhoneNumber);
            this.panel1.Controls.Add(this.txtboxAddress);
            this.panel1.Controls.Add(this.txtboxMail);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 223);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.picBoxPhoto);
            this.panel2.Controls.Add(this.btnAddPhoto);
            this.panel2.Location = new System.Drawing.Point(389, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 295);
            this.panel2.TabIndex = 34;
            // 
            // PersonalInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlChangePassword);
            this.Controls.Add(this.btnMainWindow);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PersonalInformation";
            this.Text = "PersonalInformation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonalInformation_FormClosing);
            this.Load += new System.EventHandler(this.PersonalInformation_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PersonalInformation_KeyDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPhoto)).EndInit();
            this.pnlChangePassword.ResumeLayout(false);
            this.pnlChangePassword.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtboxPhoneNumber;
        private System.Windows.Forms.TextBox txtboxMail;
        private System.Windows.Forms.TextBox txtboxAddress;
        private System.Windows.Forms.TextBox txtboxSurname;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picBoxPhoto;
        private System.Windows.Forms.Button btnAddPhoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnMainWindow;
        private System.Windows.Forms.Panel pnlChangePassword;
        private System.Windows.Forms.Button btnPanelChange;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.CheckBox chckBxShowOldPassword;
        private System.Windows.Forms.CheckBox chckBxShowNewPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
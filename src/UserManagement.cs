using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalApplication
{
    public partial class UserManagement : Form
    {
        private string secili;

        public UserManagement()
        {
            InitializeComponent();
        }
        private void btnShowUsers_Click(object sender, EventArgs e)
        {
            datagriedUserManagement.Rows.Clear();
            for (int i = 0; i < LoginForm.UserList.Count; i++)
            {
                if (LoginForm.UserList[i].Admin_Control == "*")
                {
                    datagriedUserManagement.Rows.Add(LoginForm.UserList[i].Username1, "Admin");
                }
                else if (LoginForm.UserList[i].Admin_Control == "+")
                {
                    datagriedUserManagement.Rows.Add(LoginForm.UserList[i].Username1, "User");
                }
                else
                    datagriedUserManagement.Rows.Add(LoginForm.UserList[i].Username1, "Part-Time User");
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            { 
                secili = comboBox1.SelectedItem.ToString();
                lblNamed.Text = secili + " who name is changed by admin";
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            for (int i = 1; i < LoginForm.UserList.Count; i++)
            {
                if (LoginForm.UserList[i].Username1 == secili && rdbtnAdmin.Checked)
                {
                    LoginForm.UserList[i].Admin_Control = "*";
                    Util.SaveCsv(LoginForm.UserList, LoginForm.UserFilePath);
                }
                else if (LoginForm.UserList[i].Username1 == secili && rdbtnUser.Checked)
                {
                    LoginForm.UserList[i].Admin_Control = "+";
                    Util.SaveCsv(LoginForm.UserList, LoginForm.UserFilePath);
                }
                else if (LoginForm.UserList[i].Username1 == secili && rdbtnParttime_User.Checked)
                {
                    LoginForm.UserList[i].Admin_Control = "-";
                    Util.SaveCsv(LoginForm.UserList, LoginForm.UserFilePath);
                }
            }
            btnShowUsers_Click(sender, e);
        }

        private void btnMainWindow_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void UserManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Util.reallyWant2Exit(e);
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < LoginForm.UserList.Count; i++)
            {
                comboBox1.Items.Add(LoginForm.UserList[i].Username1);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void datagriedUserManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string selectedUser = comboBox1.SelectedItem.ToString();
            int userIndex = 0;

            for (int i = 0; i < LoginForm.UserList.Count; i++)
            {
                if (LoginForm.UserList[i].Name == selectedUser)
                {
                    userIndex = i;
                    break;
                }
            }
            
            string selectedMail = LoginForm.UserList[userIndex].E_Mail;
            if(txtbxChangePassword.Text != "")
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("erncl148@gmail.com");
                    mail.To.Add(selectedMail);
                    mail.Subject = "Şifre Değişikliği";
                    mail.Body = "Şifre değiştirme talebinde bulundunuz. Yeni şifreniz: " + txtbxChangePassword.Text;

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.Credentials = new NetworkCredential("erncl148@gmail.com", "oeov gdpl ilca rqqg");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);

                    LoginForm.UserList[userIndex].Password1 = Util.ComputeSha256Hash(txtbxChangePassword.Text);

                    MessageBox.Show("Mail başarıyla gönderildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mail gönderilemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
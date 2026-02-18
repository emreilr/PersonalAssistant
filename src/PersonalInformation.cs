using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PersonalApplication
{
    public partial class PersonalInformation : Form
    {
        // Stacks to handle undo and redo functionality
        Memory memory = new Memory();
        Stack<Memento> undo = new Stack<Memento>();
        Stack<Memento> redo = new Stack<Memento>();
        public PersonalInformation()
        {
            InitializeComponent();
        }
        // Event handler for form closing to confirm if the user really wants to exit
        private void PersonalInformation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Util.reallyWant2Exit(e);
        }
        // Event handler for the add photo button click event to allow the user to select and add a photo
        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Resim Dosyası |*.jpg"; // Set the filter for the file dialog to show only .jpg files
            openFileDialog1.CheckFileExists = true; // Ensure the selected file exists
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage; // Set the picture box to stretch the image
                picBoxPhoto.ImageLocation = openFileDialog1.FileName; // Set the image location to the selected file
                                                                      // Update the user's photo in base64 format
                LoginForm.UserList[MainWindow.index].Photo = Util.GetBase64StringForImage(openFileDialog1.FileName);
                LoginForm.UserList.Insert(MainWindow.index, LoginForm.UserList[MainWindow.index]);
                LoginForm.UserList.RemoveAt(MainWindow.index + 1);
                Util.SaveCsv(LoginForm.UserList, LoginForm.UserFilePath); // Save the updated user list to the CSV file
            }
        }

        // Event handler for the edit button click event to update the user's personal information
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Update the user's information with the data from the text boxes
            LoginForm.UserList[MainWindow.index].Name = txtboxName.Text;
            LoginForm.UserList[MainWindow.index].Surname = txtboxSurname.Text;
            LoginForm.UserList[MainWindow.index].Phonenumber = mtxtboxPhoneNumber.Text;
            LoginForm.UserList[MainWindow.index].Address = txtboxAddress.Text;
            LoginForm.UserList[MainWindow.index].E_Mail = txtboxMail.Text;
            LoginForm.UserList.Insert(MainWindow.index, LoginForm.UserList[MainWindow.index]);
            LoginForm.UserList.RemoveAt(MainWindow.index + 1);
            Util.SaveCsv(LoginForm.UserList, LoginForm.UserFilePath); // Save the updated user list to the CSV file
        }

        // Event handler for form load to initialize the form with the user's data
        private void PersonalInformation_Load(object sender, EventArgs e)
        {
            Util.LoadCsv(LoginForm.UserList, LoginForm.UserFilePath); // Load the user list from the CSV file
                                                                      // Populate the text boxes with the user's information
            txtboxName.Text = LoginForm.UserList[MainWindow.index].Name;
            txtboxSurname.Text = LoginForm.UserList[MainWindow.index].Surname;
            mtxtboxPhoneNumber.Text = LoginForm.UserList[MainWindow.index].Phonenumber;
            txtboxAddress.Text = LoginForm.UserList[MainWindow.index].Address;
            txtboxMail.Text = LoginForm.UserList[MainWindow.index].E_Mail;
            // Convert the user's photo from base64 to an image and display it in the picture box
            picBoxPhoto.Image = Util.Base64ToImage(LoginForm.UserList[MainWindow.index].Photo);
            picBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            memory.ProductMemento = LoginForm.UserList[MainWindow.index].Save(); // Save the current state of the user's information
        }
        // Event handler for the main window button click event to navigate back to the main window
        private void btnMainWindow_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }
        // Event handler for the change password button click event to show the change password panel
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            pnlChangePassword.Visible = true;
        }
        // Event handler for the panel change button click event to handle password changes
        private void btnPanelChange_Click(object sender, EventArgs e)
        {
            // Verify the old password
            if (Util.ComputeSha256Hash(txtOldPassword.Text) == LoginForm.UserList[MainWindow.index].Password1)
            {
                // Update the password with the new password
                LoginForm.UserList[MainWindow.index].Password1 = Util.ComputeSha256Hash(txtNewPassword.Text);
                LoginForm.UserList.Insert(MainWindow.index, LoginForm.UserList[MainWindow.index]);
                LoginForm.UserList.RemoveAt(MainWindow.index + 1);
                Util.SaveCsv(LoginForm.UserList, LoginForm.UserFilePath); // Save the updated user list to the CSV file
                MessageBox.Show("Password was changed!");

                // If any user had 'Remember Me' enabled, disable it and save the changes
                bool flag = false;
                for (int i = 0; i < LoginForm.UserList.Count; i++)
                {
                    if (LoginForm.UserList[i].RememberMe1)
                    {
                        LoginForm.UserList[i].RememberMe1 = false;
                        flag = true;
                    }
                }
                if (flag == true)
                {
                    Util.SaveCsv(LoginForm.UserList, LoginForm.UserFilePath); // Save the updated user list to the CSV file
                }

                // Navigate back to the login form
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
                return;
            }
            MessageBox.Show("You have to type old password correctly");
        }
        // Event handler for showing or hiding the new password
        private void chckBxShowNewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(chckBxShowNewPassword.Checked == true)
            {
                txtNewPassword.UseSystemPasswordChar = false;
            }
            else
                txtNewPassword.UseSystemPasswordChar = true;
        }
        // Event handler for showing or hiding the old password
        private void chckBxShowOldPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBxShowOldPassword.Checked == true)
            {
                txtOldPassword.UseSystemPasswordChar = false;
            }
            else
                txtOldPassword.UseSystemPasswordChar = true;
        }

        // Event handler for key down events to handle undo and redo functionality
        private void PersonalInformation_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                Event(undo, redo); // Perform undo operation
            }
            else if (e.Control == false && e.KeyCode != Keys.Back)
            {
                // Save the current state of the user's information for undo
                User user = new User("", "", false, "", txtboxName.Text, txtboxSurname.Text, mtxtboxPhoneNumber.Text, txtboxAddress.Text,
                  txtboxMail.Text, "", 0);
                Memory memory = new Memory();
                memory.ProductMemento = user.Save();
                undo.Push(memory.ProductMemento);
                user.Undo(memory.ProductMemento);
            }
            if (e.Control && e.KeyCode == Keys.Y)
            {
                Event(redo, undo); // Perform redo operation
            }
            else if (e.Control == false && e.KeyCode != Keys.Back)
            {
                // Save the current state of the user's information for undo
                User user = new User("", "", false, "", txtboxName.Text, txtboxSurname.Text, mtxtboxPhoneNumber.Text, txtboxAddress.Text,
                  txtboxMail.Text, "", 0);
                Memory memory = new Memory();
                memory.ProductMemento = user.Save();
                undo.Push(memory.ProductMemento);
                user.Undo(memory.ProductMemento);
            }
        }

        // Method to handle undo and redo events
        private void Event(Stack<Memento> memory, Stack<Memento> temp_memory)
        {
            if (memory.Count != 0)
            {
                // Save the current state of the user's information
                User user = new User("", "", false, "", txtboxName.Text, txtboxSurname.Text, mtxtboxPhoneNumber.Text, txtboxAddress.Text,
                  txtboxMail.Text, "", 0);
                Memento new_memory = memory.Pop(); // Pop the latest state from the memory stack
                Memento old_memory = user.Save(); // Save the current state as the old memory
                temp_memory.Push(old_memory); // Push the old memory to the temp memory stack
                user.Undo(new_memory); // Restore the state from the new memory
                                       // Update the text boxes with the restored state
                txtboxSurname.Text = new_memory.Surname;
                txtboxName.Text = new_memory.Name;
                txtboxAddress.Text = new_memory.Address;
                txtboxMail.Text = new_memory.E_Mail;
                mtxtboxPhoneNumber.Text = new_memory.Phonenumber;
            }
        }


    }
}
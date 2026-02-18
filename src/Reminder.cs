using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalApplication
{
    public partial class Reminder : Form
    {
        public static string ReminderFilePath;
        public Reminder()
        {
            InitializeComponent();
        }
        // Event handler for timer tick to update the label with the current date and time
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateandTime.Text = System.DateTime.Now.ToString();
        }
        // Event handler for the create button click event to create a new reminder
        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Set the file path for the reminder
            ReminderFilePath = @"data/" + MainWindow.username + "Reminder.csv";
            // Determine the type of reminder (Meeting or Task)
            string type;
            if (rdobtnMeeting.Checked)
                type = rdobtnMeeting.Text;
            else
                type = rdobtnTask.Text;
            // Create a new reminder object
            MeetingTaskReminder reminder = new MeetingTaskReminder(txtboxDate.Text, mtxtboxTime.Text, txtSummary.Text, 
                txtDescription.Text,type, MainWindow.username);
            // Add the reminder to the user's reminder list
            LoginForm.UserList[MainWindow.index].Reminders.Add(reminder);
            // Save the reminder to a CSV file
            Util.SaveCsv(reminder, ReminderFilePath);
            // Display a message confirming the reminder was registered
            MessageBox.Show("Reminder registered", "Save", MessageBoxButtons.OK);
            // Clear the input fields
            txtboxDate.Text = "";
            txtDescription.Text = "";
            txtSummary.Text = "";
            mtxtboxTime.Text = "";
            if (rdobtnMeeting.Checked)
                rdobtnMeeting.Checked = false;
            else
                rdobtnTask.Checked = false;
        }
        // Event handler for date picker value change to update the date text box
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            txtboxDate.Text = dtpDate.Text;
        }
        // Event handler for the list button click event to list all reminders
        private void btnList_Click(object sender, EventArgs e)
        {
            // Set the file path for the reminder
            ReminderFilePath = @"data/" + MainWindow.username + "Reminder.csv";
            // Clear the existing items in the reminder list view
            lstReminder.Items.Clear();
            // Load the reminders from the CSV file
            Util.LoadCsv(LoginForm.UserList[MainWindow.index].Reminders, ReminderFilePath, MainWindow.username);
            // Add each reminder to the list view
            for (int i = 0; i < LoginForm.UserList[MainWindow.index].Reminders.Count; i++)
            {
                string[] row = {LoginForm.UserList[MainWindow.index].Reminders[i].Date,
                    LoginForm.UserList[MainWindow.index].Reminders[i].Time,
                    LoginForm.UserList[MainWindow.index].Reminders[i].Summary,
                    LoginForm.UserList[MainWindow.index].Reminders[i].Description,
                    LoginForm.UserList[MainWindow.index].Reminders[i].Type };
                ListViewItem itm = new ListViewItem(row);
                lstReminder.Items.Add(itm);
            }
        }
        // Event handler for the main window button click event to navigate back to the main window
        private void btnMainWindow_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }
        // Event handler for form closing to confirm if the user really wants to exit
        private void Reminder_FormClosing(object sender, FormClosingEventArgs e)
        {
            Util.reallyWant2Exit(e);
        }
        // Event handler for selected index change in the reminder list view
        private void lstReminder_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectedIndex = -1;
            SelectedIndex = lstReminder.FocusedItem.Index;
            // Populate the input fields with the selected reminder's details
            txtboxDate.Text = lstReminder.Items[SelectedIndex].SubItems[0].Text;
            mtxtboxTime.Text = lstReminder.Items[SelectedIndex].SubItems[1].Text;
            txtSummary.Text = lstReminder.Items[SelectedIndex].SubItems[2].Text;
            txtDescription.Text = lstReminder.Items[SelectedIndex].SubItems[3].Text;
            dtpDate.Text = txtboxDate.Text;
            // Set the appropriate radio button based on the type of reminder
            if (rdobtnMeeting.Text == lstReminder.Items[SelectedIndex].SubItems[4].Text)
                rdobtnMeeting.Checked = true;
            else
                rdobtnTask.Checked = true;
        }
        // Event handler for the update button click event to update an existing reminder
        private void btnUptade_Click(object sender, EventArgs e)
        {
            // Set the file path for the reminder
            ReminderFilePath = @"data/" + MainWindow.username + "Reminder.csv";
            // Determine the type of reminder (Meeting or Task)
            string type;
            if (rdobtnMeeting.Checked)
                type = rdobtnMeeting.Text;
            else
                type = rdobtnTask.Text;
            try
            {
                // Create a new reminder object with updated details
                MeetingTaskReminder reminder = new MeetingTaskReminder(txtboxDate.Text, mtxtboxTime.Text, txtSummary.Text,
                    txtDescription.Text, type, MainWindow.username);
                // Load the reminder file, update the specific reminder, and save it back
                var file = new List<string>(System.IO.File.ReadAllLines(ReminderFilePath));
                file.Insert(lstReminder.FocusedItem.Index, reminder.ReminderToCsv());
                file.RemoveAt(lstReminder.FocusedItem.Index + 1);
                System.IO.File.WriteAllLines(ReminderFilePath, file.ToArray());
                // Refresh the reminder list view
                btnList_Click(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Select a reminder for updating.");
            }
        }
        // Event handler for the delete button click event to delete an existing reminder
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Set the file path for the reminder
                ReminderFilePath = @"data/" + MainWindow.username + "Reminder.csv";
                // Load the reminder file, remove the specific reminder, and save it back
                var file = new List<string>(System.IO.File.ReadAllLines(ReminderFilePath));
                file.RemoveAt(lstReminder.FocusedItem.Index);
                System.IO.File.WriteAllLines(ReminderFilePath, file.ToArray());
                // Refresh the reminder list view
                btnList_Click(sender, e);
                // Clear the input fields
                mtxtboxTime.Text = "";
                txtSummary.Text = "";
                txtDescription.Text = "";
                rdobtnMeeting.Checked = false;
                rdobtnTask.Checked = false;
                dtpDate.ResetText();
                txtboxDate.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Select a reminder for deleting.");
            }
        }
    }
}
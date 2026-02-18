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
    public partial class Salary : Form
    {
        
        SalaryDirector salaryDirector = new SalaryDirector();

        public Salary()
        {
            InitializeComponent();
        }

        private void btnMainWindow_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void Salary_FormClosing(object sender, FormClosingEventArgs e)
        {
            Util.reallyWant2Exit(e);
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(experienceTextbox.Text) && locationCombobox.SelectedIndex != -1 &&
                  graduateschoolCombobox.SelectedIndex != -1 && languagesCombobox.SelectedIndex != -1 &&
                  managingCombobox.SelectedIndex != -1)
            {
                double salary = 17002;
                double katsayilarToplami = 0;

                int yearsOfexperience = int.Parse(experienceTextbox.Text);

                //Years of EXPERIENCE
                if (yearsOfexperience >= 0 && yearsOfexperience <= 2)
                {
                    katsayilarToplami += 0.2;
                }
                else if (yearsOfexperience >= 3 && yearsOfexperience < 6)
                {
                    katsayilarToplami += 0.3;
                }
                else if (yearsOfexperience >= 6 && yearsOfexperience < 10)
                {
                    katsayilarToplami += 0.4;
                }
                else if (yearsOfexperience >= 10 && yearsOfexperience < 15)
                {
                    katsayilarToplami += 0.5;
                }
                else if (yearsOfexperience >= 15 && yearsOfexperience < 20)
                {
                    katsayilarToplami += 0.6;
                }
                else if (yearsOfexperience >= 20)
                {
                    katsayilarToplami += 0.7;
                }
                else
                {
                    MessageBox.Show("0'dan büyük bir sayı giriniz.");
                }


                //LOCATIONS
                if (locationCombobox.SelectedIndex == 0)
                {
                    katsayilarToplami += 0.4;
                }
                else if (locationCombobox.SelectedIndex == 1)
                {
                    katsayilarToplami += 0.3;
                }
                else if (locationCombobox.SelectedIndex == 2)
                {
                    katsayilarToplami += 0.3;
                }
                else if (locationCombobox.SelectedIndex == 3)
                {
                    katsayilarToplami += 0.3;
                }
                else if (locationCombobox.SelectedIndex == 4)
                {
                    katsayilarToplami += 0.3;
                }
                else if (locationCombobox.SelectedIndex >= 5 && locationCombobox.SelectedIndex <= 11)
                {
                    katsayilarToplami += 0.2;
                }


                //EGITIM DURUMU
                if (graduateschoolCombobox.SelectedIndex == 0)
                {
                    katsayilarToplami += 0.2;
                }
                else if (graduateschoolCombobox.SelectedIndex == 1)
                {
                    katsayilarToplami += 0.2;
                }
                else if (graduateschoolCombobox.SelectedIndex == 2)
                {
                    katsayilarToplami += 0.3;
                }
                else if (graduateschoolCombobox.SelectedIndex == 3)
                {
                    katsayilarToplami += 0.5;
                }
                else if (graduateschoolCombobox.SelectedIndex == 4)
                {
                    katsayilarToplami += 0.7;
                }
                else if (graduateschoolCombobox.SelectedIndex == 5)
                {
                    katsayilarToplami += 0.8;
                }
                else if (graduateschoolCombobox.SelectedIndex == 6)
                {
                    katsayilarToplami += 0.2;
                }


                //BILINEN DIL Sayısı
                if (languagesCombobox.SelectedIndex == 0)
                {
                    katsayilarToplami += 0.2;
                }
                else if (languagesCombobox.SelectedIndex == 1)
                {
                    katsayilarToplami += 0.3;
                }
                else if (languagesCombobox.SelectedIndex == 2)
                {
                    katsayilarToplami += 0.4;
                }
                else if (languagesCombobox.SelectedIndex >= 3 && languagesCombobox.SelectedIndex < 6)
                {
                    katsayilarToplami += 0.5;
                }
                else if (languagesCombobox.SelectedIndex >= 6 && languagesCombobox.SelectedIndex < 10)
                {
                    katsayilarToplami += 0.6;
                }


                //Management position
                if (managingCombobox.SelectedIndex == 0)
                {
                    katsayilarToplami += 0.2;
                }
                else if (managingCombobox.SelectedIndex == 1)
                {
                    katsayilarToplami += 0.3;
                }
                else if (managingCombobox.SelectedIndex == 2)
                {
                    katsayilarToplami += 0.4;
                }
                else if (managingCombobox.SelectedIndex == 3)
                {
                    katsayilarToplami += 0.5;
                }
                else if (managingCombobox.SelectedIndex == 4)
                {
                    katsayilarToplami += 0.6;
                }
                else if (managingCombobox.SelectedIndex == 5)
                {
                    katsayilarToplami += 0.7;
                }

                //
                if (checkBox1.Checked) { katsayilarToplami += 0.1; }

                if (sifiraltiCocuk.Value > 0)
                {
                    katsayilarToplami += (double)(sifiraltiCocuk.Value * 0.1m);
                }
                if (yedionsekizCocuk.Value > 0)
                {
                    katsayilarToplami += (double)(yedionsekizCocuk.Value * 0.12m);
                }
                if (yedionsekizCocuk.Value > 0)
                {
                    katsayilarToplami += (double)(numericUpDown1.Value * 0.12m);
                }

                katsayilarToplami++;

                salary *= katsayilarToplami;
                if (checkBox2.Checked)
                {
                    txtResult.Text = "Your salary:\n" + (salary / 2).ToString();
                }
                else
                {
                    txtResult.Text = "Your salary:\n" + (salary).ToString();
                }
            }
            else
            {
                MessageBox.Show("Please fill out everything");
            }
        }
    }
}
    

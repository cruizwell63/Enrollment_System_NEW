using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System_NEW
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EnrollmentHomepage en = new EnrollmentHomepage();

            this.Hide();
            en.Show();
        }
        private void clear()
        {
            ID.Text = "";
            fname.Text = "";
            lname.Text = "";
            username.Text = "";
            password.Text = "";
            confirmpassword.Text = "";
        }

        private void Register_Click(object sender, EventArgs e)
        {
            /*Checks the ff before signing  up:
             *  1.if the ID Code and the name is accurate
             *  2. Username  if it already exists
             *  3. Password and confirm password is  the same
             */

            if (db.sp_signup_student(ID.Text, fname.Text, lname.Text) == 1)
            {
                if (db.sp_check_username(username.Text) == 1)
                {
                    MessageBox.Show("Username already exists");
                }
                else if (password.Text != confirmpassword.Text)
                {
                    MessageBox.Show("Password does not match");
                }
                else
                {
                    db.add_stud_account(ID.Text, username.Text, password.Text, "", 1, "Student");
                    MessageBox.Show("Account Created");
                    clear();
                }
            }

            else if (db.sp_signup_prof(ID.Text, fname.Text, lname.Text) == 2)
            {
                if (db.sp_check_username(username.Text) == 1)
                {
                    MessageBox.Show("Username already exists");
                }
                else if (password.Text != confirmpassword.Text)
                {
                    MessageBox.Show("Password does not match");
                }
                else
                {
                    db.add_stud_account(ID.Text, username.Text, password.Text, "", 1, "Teacher");
                    MessageBox.Show("Account Created");
                    clear();
                }
            }
            else
            {
                MessageBox.Show("Error, please review details", "Error");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

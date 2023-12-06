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
    public partial class EnrollmentHomepage : Form
    {
        public EnrollmentHomepage()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clear() {
            Username.Text = "";
            Password.Text = "";
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string role = string.Empty;
            string id_code = string.Empty;
            string username = string.Empty;

            db.sp_login(Username.Text, Password.Text, ref role);// retrieves the role of the user
            db.sp_ref_id(Username.Text, Password.Text, ref id_code);// retrieves the REF_ID of the user

            if (Username.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Please fill all fields.");
            }
            else if (db.sp_has_TempPass(Username.Text, Password.Text) == 1) //checks if user has temp password
            {
                ChangePass cp = new ChangePass(Username.Text);
                cp.Show();
                clear();
            }
            else if (role == "") // checks if username/password has returned a role
            {
                MessageBox.Show("Invalid Username/Password.");
            }
            else { //if login credentials has roles, checks which view to access
                if (role == "Admin")
                {
                    AdminHome adm = new AdminHome(Username.Text);
                    adm.Show();
                    this.Hide();
                    clear();
                }
                else if (role == "Student")
                {
                    StudentView sv = new StudentView(id_code); // sends student ID_Code to the StudentView form
                    this.Hide();
                    sv.Show();
                    clear();
                }
                else { // role = Teacher
                    ProfView pr = new ProfView(id_code); // sends student ID_Code to the ProfView form                                  
                    this.Hide();
                    pr.Show();
                    clear();
                }
            } 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup su = new Signup();
            su.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FaceLogin fl = new FaceLogin();
            fl.Show();
            this.Hide();
        }
    }
}

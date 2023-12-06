using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Enrollment_System_NEW
{
    public partial class Enrollment : Form
    {
        public Enrollment()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void Enrollment_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.sp_student_info();
            updateBtn.Hide();
        }

        int id = 0;

        private int age_calc(DateTime bdate)
        {
            int days = (DateTime.Now - bdate).Days;
            int age = days / 365;

            return age;
        }
        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            DateTime bdate = birthdate.Value;
            int age = age_calc(bdate);

            if (checker(stud_fname.Text, stud_lname.Text, stud_address.Text, stud_email.Text) == 1) {
                MessageBox.Show("Please fill all fields", "Error");
            }
            else if (checker(stud_fname.Text, stud_lname.Text, stud_address.Text, stud_email.Text) == 2) {
                MessageBox.Show("Invalid Email Address", "Error");
            }
            else {
                db.sp_add_student(stud_fname.Text, stud_mname.Text, stud_lname.Text, birthdate.Value, age, stud_address.Text, stud_email.Text);
                MessageBox.Show("Added Succesfully", "Successful");
            }
           
            dataGridView1.DataSource = db.sp_student_info();
        }

        private int checker(string fname, string lname, string address, string email) {
            int ret = 0;
            string emailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$";


            if (fname == "" || lname == "" || address == "" || email == "")
            {
                ret = 1; //return one if there are null fields
            }
            else if (!Regex.IsMatch(email, emailPattern))
            {
                ret = 2; //if email is invalid
            }
            else {
                ret = 0;
            }
                
            return ret;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            stud_fname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            stud_mname.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            stud_lname.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            birthdate.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            stud_address.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            stud_email.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

            AddStudentBtn.Hide();
            updateBtn.Show();
        }

        private void clear() {
            stud_fname.Text = "";
            stud_mname.Text = "";
            stud_lname.Text = "";
            birthdate.Value = DateTime.Now;
            stud_address.Text = "";
            stud_email.Text = "";
        }

        private void BackToHome_Click(object sender, EventArgs e)
        {
            AdminHome admin = new AdminHome();
            this.Hide();
            admin.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.sp_search(Search_key.Text);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void toEnrollmentForm_Click(object sender, EventArgs e)
        {
            Enrollment_form en_form = new Enrollment_form();
            en_form.Show();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            if (checker(stud_fname.Text, stud_lname.Text, stud_address.Text, stud_email.Text) == 1)
            {
                MessageBox.Show("Please fill all fields", "Error");
            }
            else if (checker(stud_fname.Text, stud_lname.Text, stud_address.Text, stud_email.Text) == 2)
            {
                MessageBox.Show("Invalid Email Address", "Error");
            }
            else {
                db.sp_stud_update(id, stud_fname.Text, stud_mname.Text, stud_lname.Text, birthdate.Value, stud_address.Text, stud_email.Text);
                MessageBox.Show("Updated Successfully", "Update");
                clear();
                updateBtn.Hide();
                AddStudentBtn.Show();
                dataGridView1.DataSource = db.sp_student_info();
            } 
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clear();
            updateBtn.Hide();
            AddStudentBtn.Show();
        }
    }
}

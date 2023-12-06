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
    public partial class Add_Teacher : Form
    {
        public Add_Teacher()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Add_Teacher_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.show_prof_active();
        }

        int id = 0;

        private int checker(string fname, string lname, string address, string email) {
            int ret = 0;

            string emailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$";

            if (fname == "" || lname == "" || address == "" || email == "") {
                ret = 1;
            }
            else if (!Regex.IsMatch(email,emailPattern)) {
                ret = 2;
            }
            return ret;
        }

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

            if (checker(prof_fname.Text, prof_lname.Text, prof_address.Text, prof_email.Text) == 1) {
                MessageBox.Show("Please fill all fields", "Error");
            }
            else if (checker(prof_fname.Text, prof_lname.Text, prof_address.Text, prof_email.Text) == 2)
            {
                MessageBox.Show("Invalid Email Address", "Error");
            }
            else {
                db.add_prof(prof_fname.Text, prof_mname.Text, prof_lname.Text, birthdate.Value, age ,prof_address.Text, prof_email.Text,1);
                MessageBox.Show("Added Successfully", "Successful");
                dataGridView1.DataSource = db.show_prof_active();
                clear();
             }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            DateTime bdate = birthdate.Value;
            int age = age_calc(bdate);

            if (checker(prof_fname.Text, prof_lname.Text, prof_address.Text, prof_email.Text) == 1)
            {
                MessageBox.Show("Please fill all fields", "Error");
            }
            else if (checker(prof_fname.Text, prof_lname.Text, prof_address.Text, prof_email.Text) == 2)
            {
                MessageBox.Show("Invalid Email Address", "Error");
            }
            else
            {
                db.update_prof(id, prof_fname.Text, prof_mname.Text, prof_lname.Text, birthdate.Value, age, prof_address.Text, prof_email.Text);
                MessageBox.Show("Updated!", "Successful");
                dataGridView1.DataSource = db.show_prof_active();
                clear();
                updateBtn.Hide();
                AddProfBtn.Show();
            }
            id = 0;
        }

        private void clear() {
            prof_fname.Text = "";
            prof_mname.Text = "";
            prof_lname.Text = "";
            birthdate.Value = DateTime.Now;
            prof_address.Text = "";
            prof_email.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            prof_fname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            prof_mname.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            prof_lname.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            birthdate.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            prof_address.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            prof_email.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

            AddProfBtn.Hide();
            updateBtn.Show();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clear();
            updateBtn.Hide();
            AddProfBtn.Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {
                dataGridView1.DataSource = db.sp_search_prof(Search_key.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminHome admin = new AdminHome();
            this.Hide();
            admin.Show();
        }

        private void Search_key_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rmv_teacher_Click(object sender, EventArgs e)
        {
            DialogResult diag = MessageBox.Show("Are you sure you want to remove Professor " + prof_fname.Text + " "  + prof_lname.Text +"?","", MessageBoxButtons.YesNo);
            if (diag == DialogResult.Yes) {
                db.sp_deact_prof(id);
                MessageBox.Show("Professor has been removed.", "Successful");
                id = 0;
                dataGridView1.DataSource = db.show_prof_active();
                clear();
                updateBtn.Hide();
                AddProfBtn.Show();
            }
        }
    }
}

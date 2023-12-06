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
    public partial class Enrollment_form : Form
    {

        DataClasses1DataContext db = new DataClasses1DataContext();
        public Enrollment_form()
        {
            InitializeComponent();
            combox_view();
        }

        private void combox_view()
        {
            comboBox2.DataSource = db.sp_all_sections().ToList();
            comboBox2.DisplayMember = "section_code";
            comboBox2.ValueMember = "section_id";

            comboBox3.DataSource = db.sp_all_programs().ToList();
            comboBox3.DisplayMember = "prog_name";
            comboBox3.ValueMember = "prg_id";

            comboBox4.DataSource = db.sp_all_ay().ToList();
            comboBox4.DisplayMember = "acad_year";
            comboBox4.ValueMember = "acd_id";
        }

        private void Enrollment_form_Load(object sender, EventArgs e)
        {
            combox_view();
        }

        private void clear() {
            textBox1.Text = "";
            Semester.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c2 = Convert.ToInt32(comboBox2.SelectedValue);
            int c3 = Convert.ToInt32(comboBox3.SelectedValue);
            int c4 = Convert.ToInt32(comboBox4.SelectedValue);
            int c5 = Convert.ToInt32(Semester.SelectedItem);
            int yearlvl = Convert.ToInt32(YearLvl.SelectedItem);

            if (textBox1.Text == "" || Semester.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields");
            }
            else if (db.check_enr(Convert.ToInt32(textBox1.Text), c4, c5) == 1) {
                MessageBox.Show("Student is already enrolled.");
            }

            else {
                int c1 = Convert.ToInt32(textBox1.Text);
                db.sp_enroll_student(c1, c2, c3, c4, c5, 1, yearlvl);
                MessageBox.Show("Successfully Enrolled", "Success");
            }
            clear();
        }


        private void BackToHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

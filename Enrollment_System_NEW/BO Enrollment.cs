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
    public partial class BOEnrollment : Form
    {
        public BOEnrollment()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        int sems;
        int ay;
        int key = 0;

        private void BOEnrollment_Load(object sender, EventArgs e)
        {
            AY.DataSource = db.sp_all_ay().ToList();
            AY.DisplayMember = "acad_year";
            AY.ValueMember = "acd_id";

            Sem.Text = "1";


            sems = Convert.ToInt32(Sem.SelectedItem.ToString());
            ay = Convert.ToInt32(AY.SelectedValue.ToString());
            dataGridView1.DataSource = db.sp_enr_students(ay, sems);

            Section.DataSource = db.sp_all_sections().ToList();
            Section.DisplayMember = "section_code";
            Section.ValueMember = "section_id";

            Program.DataSource = db.sp_all_programs().ToList();
            Program.DisplayMember = "prog_name";
            Program.ValueMember = "prg_id";

            Acad_Year.DataSource = db.sp_all_ay().ToList();
            Acad_Year.DisplayMember = "acad_year";
            Acad_Year.ValueMember = "acd_id";
        }



        private void BackToHome_Click(object sender, EventArgs e)
        {
            AdminHome adm = new AdminHome();
            this.Hide();
            adm.Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            sems = Convert.ToInt32(Sem.SelectedItem.ToString());
            ay = Convert.ToInt32(AY.SelectedValue.ToString());

            if (Searchbox.Text == "")
            {
                dataGridView1.DataSource = db.sp_enr_students(ay, sems);
            }
            else {
                dataGridView1.DataSource = db.sp_enr_specific(Searchbox.Text, ay, sems);
            }
        }

        private void EnrollBtn_Click(object sender, EventArgs e)
        {
            YearLvl.Text = "1";
            Semester.Text = "1";

            Section.DataSource = db.sp_all_sections().ToList();
            Section.DisplayMember = "section_code";
            Section.ValueMember = "section_id";

            Program.DataSource = db.sp_all_programs().ToList();
            Program.DisplayMember = "prog_name";
            Program.ValueMember = "prg_id";

            Acad_Year.DataSource = db.sp_all_ay().ToList();
            Acad_Year.DisplayMember = "acad_year";
            Acad_Year.ValueMember = "acd_id";
        }

        private void Update_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Int_ID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Int_ID.Enabled = false;
            YearLvl.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            Section.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            Program.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            Acad_Year.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            Semester.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            Submit_btn.Hide();
            Update_btn.Show();
        }

        private void en_clear()
        {
            Int_ID.Text = "";
            YearLvl.Text = "1";
            Semester.Text = "1";
        }

            private void Submit_btn_Click(object sender, EventArgs e)
        {
            int c2 = Convert.ToInt32(Section.SelectedValue);
            int c3 = Convert.ToInt32(Program.SelectedValue);
            int c4 = Convert.ToInt32(Acad_Year.SelectedValue);
            int c5 = Convert.ToInt32(Semester.SelectedItem);
            int yearlvl = Convert.ToInt32(YearLvl.SelectedItem);

            if (Int_ID.Text == "" || Semester.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields");
            }
            else if  (db.check_enr(Convert.ToInt32(Int_ID.Text),c4,c5) == 1) {
                MessageBox.Show("Student is already enrolled.", "Warning");
            }
            else
            {
                int c1 = Convert.ToInt32(Int_ID.Text);
                db.sp_enroll_student(c1, c2, c3, c4, c5, 1, yearlvl);
                MessageBox.Show("Successfully Enrolled", "Success");
            }
            en_clear();
            dataGridView1.DataSource = db.sp_enr_students(ay, sems);
        }

      

        private void Update_btn_Click(object sender, EventArgs e)
        {
            int c2 = Convert.ToInt32(Section.SelectedValue);
            int c3 = Convert.ToInt32(Program.SelectedValue);
            int c4 = Convert.ToInt32(Acad_Year.SelectedValue);
            int c5 = Convert.ToInt32(Semester.SelectedItem);
            int yearlvl = Convert.ToInt32(YearLvl.SelectedItem);

            if (Int_ID.Text != "") {
                db.sp_enr_update(key, c2, c3, c4, c5, yearlvl);
                MessageBox.Show("Updated!");
                en_clear();
                Int_ID.Enabled = true;
                Submit_btn.Show();
                Update_btn.Hide();
                key = 0;
                
            }
            dataGridView1.DataSource = db.sp_enr_students(ay, sems);

        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            Submit_btn.Show();
            Update_btn.Hide();
            en_clear();
            Int_ID.Enabled = true;
            key = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.sp_unenroll(key);
            MessageBox.Show("Unenrolled.");
            dataGridView1.DataSource = db.sp_enr_students(ay, sems);
            key = 0;
            en_clear();
            Submit_btn.Show();
            Update_btn.Hide();
            Int_ID.Enabled = true;
        }
    }
}

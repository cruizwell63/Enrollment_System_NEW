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
    public partial class Scheduling : Form
    {
        public Scheduling()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.sp_all_schedules();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        int sched_id = 0;

        private void Scheduling_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.sp_all_schedules();

            Acad_Year.DataSource = db.sp_all_ay();
            Acad_Year.DisplayMember = "acad_year";
            Acad_Year.ValueMember = "acd_id";

            Sections.DataSource = db.sp_all_sections();
            Sections.DisplayMember = "section_code";
            Sections.ValueMember = "section_id";

            Sched_prof.DataSource = db.sp_all_prof();
            Sched_prof.DisplayMember = "prof_name";
            Sched_prof.ValueMember = "prof_id";

            sched_subject.DataSource = db.sp_all_subjects();
            sched_subject.DisplayMember = "sub_code";
            sched_subject.ValueMember = "sub_id";
        }

        private void clear() {
            Semester.Text = "1";
            Sched_day.Text = "";
            Time_Start.Text = "";
            Time_end.Text = "";


            Sched_prof.DataSource = db.sp_all_prof();
            Sections.DataSource = db.sp_all_sections();
            Acad_Year.DataSource = db.sp_all_ay();
            Sched_prof.DataSource = db.sp_all_prof();
            sched_subject.DataSource = db.sp_all_subjects();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int sect = Convert.ToInt32(Sections.SelectedValue.ToString());
            int i_sem = Convert.ToInt32(Semester.SelectedItem.ToString());
            int prof_id = Convert.ToInt32(Sched_prof.SelectedValue.ToString());
            int acd_id = Convert.ToInt32(Acad_Year.SelectedValue.ToString());
            int sub_id = Convert.ToInt32(sched_subject.SelectedValue.ToString());

            if (Semester.Text != "" && Sched_day.Text != "" && Time_Start.Text != "" && Time_end.Text != "") {
                db.sp_add_schedule(sect,i_sem, acd_id,Sched_day.Text, sub_id, Time_Start.Text, Time_end.Text,prof_id,1);
                MessageBox.Show("Schedule has been added", "Success");
                clear();
            }
            dataGridView1.DataSource = db.sp_all_schedules();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminHome adm = new AdminHome();
            this.Hide();
            adm.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (sched_id != 0) {
                db.sp_delete_sched(sched_id);
                MessageBox.Show("Deleted!");
                sched_id = 0;
                clear();
            }
            dataGridView1.DataSource = db.sp_all_schedules();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sched_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Sections.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Acad_Year.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Semester.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Sched_day.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            Time_Start.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            Time_end.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            Sched_prof.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            sched_subject.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            Add.Hide();
            update.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {

            int sect = Convert.ToInt32(Sections.SelectedValue.ToString());
            int i_sem = Convert.ToInt32(Semester.SelectedItem.ToString());
            int prof_id = Convert.ToInt32(Sched_prof.SelectedValue.ToString());
            int acd_id = Convert.ToInt32(Acad_Year.SelectedValue.ToString());
            int sub_id = Convert.ToInt32(sched_subject.SelectedValue.ToString());

            if (sched_id != 0) {
               db.sp_update_schedule(sched_id, sect, i_sem, acd_id, Sched_day.Text, Time_Start.Text, Time_end.Text, prof_id, sub_id);
                MessageBox.Show("Updated!");
                sched_id = 0;
                clear();
                Add.Show();
                update.Hide();
            }
            dataGridView1.DataSource = db.sp_all_schedules();
        }
        private void Search_key_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Search_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.sp_search_schedules(Key.Text);
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            clear();
            update.Hide();
            Add.Show();
        }
    }
}

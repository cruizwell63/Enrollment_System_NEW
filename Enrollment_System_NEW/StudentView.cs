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
    public partial class StudentView : Form
    {
        public StudentView()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        string int_id = string.Empty;

        public StudentView(string id_code) { // receives the id_code
            InitializeComponent();
            this.ID = id_code;
        }

        public string ID { get; set; } // to make id_code  readable to an object

        private void StudentView_Load(object sender, EventArgs e)
        {
            string name = string.Empty;
           

            db.stud_det_name(ID, ref name); // takes full name using id_code
            db.stud_det_id(ID, ref int_id); // takes internal ID for reference of schedule
            label1.Text = name;

            acad_year.DataSource = db.sp_all_ay().ToList();
            acad_year.DisplayMember = "acad_year";
            acad_year.ValueMember = "acd_id";
            sem.Text = "1";
        }

        private void logout_Click(object sender, EventArgs e)
        {
            EnrollmentHomepage en = new EnrollmentHomepage();
            en.Show();
            this.Hide();
        }

        private void schedBtn_Click(object sender, EventArgs e)
        {
            string section = string.Empty;
            int ay = Convert.ToInt32(acad_year.SelectedValue.ToString());
            int semester = Convert.ToInt32(sem.SelectedItem.ToString());

            db.stud_det_section(int_id,Convert.ToInt32(acad_year.SelectedValue.ToString()), 
            Convert.ToInt32(sem.SelectedItem.ToString()),ref section); // retrieves the section code

            if (section == "") {
                label6.Text = "Not Enrolled";
            }
            else {
                label6.Text = section;
                dataGridView1.DataSource = db.sp_show_sched(section,ay,semester);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

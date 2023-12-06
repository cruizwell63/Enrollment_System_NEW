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
    public partial class ProfView : Form
    {
        public ProfView()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        string int_id = string.Empty;
        public ProfView(string id_code) {
            InitializeComponent();
            this.ID = id_code;
        }

        public string ID { get; set; } // to make id_code  readable to an object
        private void ProfView_Load(object sender, EventArgs e)
        {
            string name = string.Empty;
            

            db.sp_det_name(ID, ref name); // retrieves name from db
            db.sp_prof_id(ID,ref int_id); // retrieves internal ID of the prof
            
            label1.Text = name;
            

            acad_year.DataSource = db.sp_all_ay().ToList();
            acad_year.DisplayMember = "acad_year";
            acad_year.ValueMember = "acd_id";

            sem.Text = "1";
        }

        private void schedBtn_Click(object sender, EventArgs e)
        {
            int ay = Convert.ToInt32(acad_year.SelectedValue.ToString());
            int semester = Convert.ToInt32(sem.SelectedItem.ToString());

            dataGridView1.DataSource = db.sp_prof_sched(Convert.ToInt32(int_id), ay, semester);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            EnrollmentHomepage en = new EnrollmentHomepage();
            en.Show();
            this.Hide();
        }
    }
}

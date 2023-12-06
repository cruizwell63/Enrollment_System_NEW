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
    public partial class BackOffice2 : Form
    {
        public BackOffice2()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        int sub_id = 0;
        private void BackOffice2_Load(object sender, EventArgs e)
        {
            ProgramList.DataSource = db.sp_all_programs().ToList();
            ProgramList.DisplayMember = "prog_name";
            ProgramList.ValueMember = "prg_id";

            dataGridView1.DataSource = db.sp_active_subjects();
            AddSub.Show();
            UpdateSub.Hide();
        }

        private int checker(string subcode, string subname, string desc) {
            int ret = 0;

            if (subcode == "" || subname == "" || desc == "")
            { //if fields are not empty, send flag to control
                ret = 0;
            }
            else {
                ret = 1;
            }
            return ret;
        }

        private void clear() {
            sub_id = 0;
            SubCode.Text = "";
            SubName.Text = "";
            Sub_desc.Text = "";

            ProgramList.DataSource = db.sp_all_programs().ToList();
        }

        private void AddSub_Click(object sender, EventArgs e)
        {
            // add subject
            if (checker(SubCode.Text, SubName.Text, Sub_desc.Text) == 1)
            {
                db.sp_add_subjects(Convert.ToInt32(ProgramList.SelectedValue.ToString()), SubCode.Text, SubName.Text, Sub_desc.Text, 1);
                dataGridView1.DataSource = db.sp_active_subjects();
                clear();
                MessageBox.Show("Subject has been added.", "Successful");
            }
            else {
                MessageBox.Show("Please fill all fields.", "Warning");
            }
            dataGridView1.DataSource = db.sp_active_subjects();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sub_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            ProgramList.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            SubCode.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            SubName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Sub_desc.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            AddSub.Hide();
            UpdateSub.Show();
        }

        private void UpdateSub_Click(object sender, EventArgs e)
        {
            if (checker(SubCode.Text, SubName.Text, Sub_desc.Text) == 1)
            {
                db.sp_update_suubjects(sub_id, Convert.ToInt32(ProgramList.SelectedValue.ToString()), SubCode.Text, SubName.Text,Sub_desc.Text);
                MessageBox.Show("Updated Successfully", "Update");
                sub_id = 0;
                AddSub.Show();
                UpdateSub.Hide();
                clear();
                dataGridView1.DataSource = db.sp_active_subjects();
            }
            else {
                MessageBox.Show("Please fill all fields.", "Warning");
            }
        }

        private void ClearSub_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void DelSub_Click(object sender, EventArgs e)
        {
            // delete sub
            if (sub_id != 0) {
                db.sp_delete_subject(sub_id);
                MessageBox.Show("Subject has been deleted", "Deleted");
            }
            clear();
            dataGridView1.DataSource = db.sp_active_subjects();
        }

        private void BackToHome_Click(object sender, EventArgs e)
        {
            AdminHome adm = new AdminHome();
            this.Hide();
            adm.Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.search_subject(Key.Text);
        }
    }
}

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
    public partial class UserAccounts : Form
    {
        public UserAccounts()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        int id;

        private void button2_Click(object sender, EventArgs e)
        {
          
                AdminHome adm = new AdminHome();
                this.Hide();
                 adm.Show();
        }

        private void UserAccounts_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.show_users();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (UID.Text != "" && RefID.Text != "" && Username.Text != "" && isActive.Text != "" && Role.Text != "")
            {
                db.sp_user_update(id, Convert.ToInt32(isActive.SelectedItem), Role.SelectedItem.ToString());
                dataGridView1.DataSource = db.show_users();
                MessageBox.Show("Updated Successfully", "Update");
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (temp_pass.Text != "" && UID.Text != "" && RefID.Text != "" && Username.Text != "" && isActive.Text != "" && Role.Text != "")
            {
                db.sp_set_temppass(id, temp_pass.Text);
                MessageBox.Show("Temporary Password has been set!", "Successful");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PassGen pg = new PassGen();
            pg.Show();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.sp_search_users(Searchkey.Text);
            Filter.Text = "All";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            UID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            RefID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Username.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            isActive.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            Role.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Filter.SelectedItem.ToString() == "All")
            {
                dataGridView1.DataSource = db.show_users();
            }
            else if (Filter.SelectedItem.ToString() == "Active")
            {
                dataGridView1.DataSource = db.show_users_active();
            }
            else
            {
                dataGridView1.DataSource = db.show_users_inactive();
            }
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            UID.Text = "";
            RefID.Text = "";
            Username.Text = "";
        }
    }
}

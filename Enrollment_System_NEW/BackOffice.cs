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
    public partial class BackOffice : Form
    {
        public BackOffice()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        private void BackOffice_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.sp_acad_year();
            dataGridView2.DataSource = db.sp_active_program();
            dataGridView3.DataSource = db.sp_section_view();

            Program_List.DataSource = db.sp_all_programs().ToList();
            Program_List.DisplayMember = "prog_name";
            Program_List.ValueMember = "prg_id";
        }

        private void AY_save_btn_Click(object sender, EventArgs e)
        {
            string concat = textBox1.Text + "-" + textBox2.Text;

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please fill all fields", "Warning");
            }
            else {
                db.sp_add_ay(concat, 1);
                MessageBox.Show("A.Y. has been added.", "Successful");
                dataGridView1.DataSource = db.sp_acad_year();
            }
        }

        private void AY_del_btn_Click(object sender, EventArgs e)
        {
            if (id != 0) {
                db.sp_delete_ay(id);
                MessageBox.Show("Deleted", "Successful");
                AY.Text = "";
            }
            id = 0;
            dataGridView1.DataSource = db.sp_acad_year();
        }

        int id = 0; // AY ID
        int prog_id = 0; // Program ID
        int sec_id = 0; // Section ID

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)// academic year datagrid
        {

            AY.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            id = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void BackToHome_Click(object sender, EventArgs e)
        {
            AdminHome adm = new AdminHome();

            this.Hide();
            adm.Show();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (ProgCode.Text == "" || Description.Text == "")
            {
                MessageBox.Show("Please fill all fields", "Warning");
            }
            else {
                db.sp_add_program(ProgCode.Text, Description.Text, 1);
                MessageBox.Show("Program has been added.", "Successful");
                Program_List.DataSource = db.sp_all_programs().ToList(); // to refresh programs list
                dataGridView2.DataSource = db.sp_active_program();
            }
            prog_clear();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) // program datagrid
        {
            prog_id = Int32.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            ProgCode.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            Description.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();

            SaveBtn.Hide();
            Update.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (prog_id != 0) {
                db.sp_del_program(prog_id);
                MessageBox.Show("Deleted", "Delete");
                prog_id = 0;
                prog_clear();
                Update.Hide();
                SaveBtn.Show();
                Program_List.DataSource = db.sp_all_programs().ToList(); // to refresh programs list
            }
            dataGridView2.DataSource = db.sp_active_program();
        }

        private void prog_clear() {
            prog_id = 0;
            ProgCode.Text = "";
            Description.Text = "";
        }

        private void Update_Click(object sender, EventArgs e)
        {
            db.sp_prog_update(prog_id, ProgCode.Text, Description.Text);
            MessageBox.Show("Updated!", "Update");
            dataGridView2.DataSource = db.sp_active_program();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            prog_clear();
            SaveBtn.Show();
            Update.Hide();
        }

        private void AY_search_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.sp_search_ay(AY_Key.Text);
        }

        private void Prog_search_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = db.sp_search_program(Prog_key.Text);
        }

        private void Description_TextChanged(object sender, EventArgs e)
        {

        }

        private void sec_clear() {

            //section clear
            Program_List.DataSource = db.sp_all_programs().ToList();
            Program_List.DisplayMember = "prog_name";
            Program_List.ValueMember = "prg_id";

            Section_Code.Text = "";
        }

        private void Sec_Save_Click(object sender, EventArgs e)
        {
            //section save
            if (Program_List.Text != "" && Section_Code.Text != "")
            {
                db.sp_add_section(Convert.ToInt32(Program_List.SelectedValue.ToString()), Section_Code.Text, 1);
                MessageBox.Show("Sections has been added.", "Successful");
            }
            else {
                MessageBox.Show("Please fill all fields.","Warning");
            }
            dataGridView3.DataSource = db.sp_section_view();
        }

        private void Sec_Del_Click(object sender, EventArgs e)
        {
            //section delete
            if (sec_id != 0) {
                db.sp_del_section(sec_id);
                sec_id = 0;
                sec_update.Hide();
                Sec_Save.Show();
                sec_clear();
                MessageBox.Show("Deleted!", "Successful");
            }
            dataGridView3.DataSource = db.sp_section_view();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //section datagrid
            sec_id = Int32.Parse(dataGridView3.CurrentRow.Cells[0].Value.ToString());
            Program_List.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            Section_Code.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();

            sec_update.Show();
            Sec_Save.Hide();
        }

        private void sec_update_Click(object sender, EventArgs e)
        {
            //section update
            if (sec_id !=0 && Section_Code.Text != "") {
                db.sp_update_section(sec_id, Section_Code.Text, Convert.ToInt32(Program_List.SelectedValue.ToString()));
                MessageBox.Show("Updated Successfully", "Update");
                sec_id = 0;
                sec_update.Hide();
                Sec_Save.Show();
                sec_clear();
            }
            dataGridView3.DataSource = db.sp_section_view();
        }

        private void Sec_Delete_Click(object sender, EventArgs e)
        {
            //section clear
            sec_clear();
            sec_update.Hide();
            sec_id = 0;
            Sec_Save.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = db.sp_search_section(textBox4.Text);
        }
    }
}

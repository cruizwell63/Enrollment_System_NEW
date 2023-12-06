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
    public partial class AddAdmin : Form
    {
        public AddAdmin()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void AddAdmin_Load(object sender, EventArgs e)
        {

        }

        private void clear() {
            fname.Text = "";
            mname.Text = "";
            lname.Text = "";
            username.Text = "";
            password.Text = "";
            con_password.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fname.Text == "" || mname.Text == "" || lname.Text == "" || username.Text == "" || password.Text == "" || con_password.Text == "") {
                MessageBox.Show("Please fill all fields.");
            }
            else if (password.Text != con_password.Text) {
                MessageBox.Show("Password does not match");
            }
            else if (db.sp_username_check(username.Text) == 1) {
                MessageBox.Show("Username already taken");
            }
            else {
                db.add_adm_info(fname.Text, mname.Text, lname.Text);
                db.add_stud_account("ADM",username.Text,password.Text,"",1,"Admin");
                MessageBox.Show("Admin account created!");
                clear();
            }
        }
     
    }
}

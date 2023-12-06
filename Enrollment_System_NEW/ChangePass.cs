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
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();

        public ChangePass(string username)
        {
            InitializeComponent();
            this.uname = username;
        }

        private void ChangePass_Load(object sender, EventArgs e)
        {
            Username.Text = uname;
        }

        public string uname { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Pass1.Text == "" || Pass2.Text == "") {
                MessageBox.Show("Please fill all fields");
            }
            else if (Pass1.Text != Pass2.Text) {
                MessageBox.Show("Passwords do not match", "Error");
            }
            else{
                db.sp_new_pass(Username.Text, Pass1.Text);
               DialogResult diag = MessageBox.Show("Password Change!", "Return to Login Page?", MessageBoxButtons.YesNo);
                if (diag == DialogResult.Yes) {
                    this.Hide();
                }
            }
        }
    }
}

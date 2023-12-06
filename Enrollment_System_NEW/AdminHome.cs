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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        public AdminHome(string username) {
            InitializeComponent();
            this.get_username = username;
        }

        public string get_username { get; set; }

     
        private void button1_Click_1(object sender, EventArgs e)
        {
            Enrollment en = new Enrollment();
            this.Hide();
            en.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_Teacher at = new Add_Teacher();
            this.Hide();
            at.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserAccounts us = new UserAccounts();
            this.Hide();
            us.Show();
        }

        private void backoffice_Click(object sender, EventArgs e)
        {
            BackOffice bo = new BackOffice();
            this.Hide();
            bo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackOffice2 bo2 = new BackOffice2();
            this.Hide();
            bo2.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Scheduling sc = new Scheduling();
            this.Hide();
            sc.Show();
        }

        private void Enrollment_Click(object sender, EventArgs e)
        {
            BOEnrollment bo = new BOEnrollment();
            this.Hide();
            bo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddAdmin add_adm = new AddAdmin();
            add_adm.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            EnrollmentHomepage en = new EnrollmentHomepage();
            this.Hide();
            en.Show();
            
        }

        private void registerFaceRecognitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FaceRegister fr = new FaceRegister(get_username);
            fr.Show();
        }
    }
}

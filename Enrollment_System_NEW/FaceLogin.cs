using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;

namespace Enrollment_System_NEW
{
    public partial class FaceLogin : Form
    {
        public FaceLogin()
        {
            InitializeComponent();
        }

        FaceRec fr = new FaceRec();
        DataClasses1DataContext db = new DataClasses1DataContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //open cam
            fr.isTrained = true;
            fr.getPersonName(label1);
            fr.openCamera(pictureBox1,pictureBox2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //login
            if (db.sp_face_login(label1.Text) == 1)
            {
                AdminHome adm = new AdminHome(label1.Text);
                adm.Show();
                this.Close();
            }
            else {
                MessageBox.Show("Face Unrecognized");  
            }
        }

        private void BackToHome_Click(object sender, EventArgs e)
        {
            EnrollmentHomepage en = new EnrollmentHomepage();
            en.Show();
            this.Hide();
        }
    }
}

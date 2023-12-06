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
    public partial class FaceRegister : Form
    {
        public FaceRegister()
        {
            InitializeComponent();
        }

        FaceRec fr = new FaceRec();

        public FaceRegister(string username) {
            InitializeComponent();
            this.get_username = username;
        }

        public string get_username { get; set; }

        private void FaceRegister_Load(object sender, EventArgs e)
        {
            Username.Enabled = false;
            Username.Text = get_username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fr.openCamera(pictureBox1, pictureBox2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fr.Save_IMAGE(get_username);
            MessageBox.Show("Saved!");
        }
    }
}

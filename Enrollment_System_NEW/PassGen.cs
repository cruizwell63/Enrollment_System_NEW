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
    public partial class PassGen : Form
    {
        public PassGen()
        {
            InitializeComponent();
        }


        private void PassGen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string CharPool = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()";
            int len = 10;

            StringBuilder res = new StringBuilder();
            Random rand = new Random();

            while (0 <= len--)
            {
                res.Append(CharPool[rand.Next(CharPool.Length)]);
            }

            textBox1.Text = res.ToString();
        }

    }
}

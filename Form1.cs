using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InchiriereAuto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click_3(object sender, EventArgs e)
        {

        }

        private void guna2ImageCheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            progres.Value = startpoint;
            if (progres.Value == 100)
            {
                progres.Value = 0;
                timer1.Stop();
                Logare log = new Logare();
                log.Show();
                this.Hide();
            }
        }

        private void progres_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

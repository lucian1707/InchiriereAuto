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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Masina masina = new Masina();
            masina.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Client client = new Client();
            client.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chirie chirie= new Chirie();
            chirie.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Return ret = new Return();
            ret.Show();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Utilizator utilizator = new Utilizator();
            utilizator.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            PagPrincipala pagPrincipala = new PagPrincipala();
            pagPrincipala.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logare logare = new Logare();
            logare.Show();
        }
    }
}

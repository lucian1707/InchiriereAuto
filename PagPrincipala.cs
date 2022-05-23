using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InchiriereAuto
{
    public partial class PagPrincipala : Form
    {
        public PagPrincipala()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\InchiriereAuto\InchiriereAuto\InchiriereaAuto.mdf;Integrated Security=True");
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void PagPrincipala_Load(object sender, EventArgs e)
        {
            //numarul de masini inregistrate
            string queryMasina = "select Count(*) from MasinaTb1";
            SqlDataAdapter sda = new SqlDataAdapter(queryMasina, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MasinaLb.Text = dt.Rows[0][0].ToString();
            //Numarul de clienti inregistrati
            string queryClient = "select Count(*) from ClientTb1";
            SqlDataAdapter sda1 = new SqlDataAdapter(queryClient, Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            ClientLb.Text = dt1.Rows[0][0].ToString();
            //Numarul de utilizatori inregistrati
            string queryUtilizator = "select Count(*) from UtilizatorTb1";
            SqlDataAdapter sda2 = new SqlDataAdapter(queryUtilizator, Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            UtilizatorLb.Text = dt2.Rows[0][0].ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CarLb_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }
    }
}

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
    public partial class Logare : Form
    {
        public Logare()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\InchiriereAuto\InchiriereAuto\InchiriereaAuto.mdf;Integrated Security=True");
        private void guna2ImageCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            UserTb.Text = "";
            ParolaTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string query = "select count(*) from UtilizatorTb1 where Unume='" + UserTb.Text + "' and Uparola='" + ParolaTb.Text + "'";
            Con.Open();
            SqlDataAdapter sda =new  SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            { 
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();

            }else
            {
                MessageBox.Show("Username sau parolă este gresită");
            }

            Con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

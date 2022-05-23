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
    public partial class Chirie : Form
    {
        public Chirie()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\InchiriereAuto\InchiriereAuto\InchiriereaAuto.mdf;Integrated Security=True");


        private void populare()
        {
            Con.Open();

            string query = "select * from ChirieTb1 ";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder constructor = new SqlCommandBuilder(da);
            var setDate = new DataSet();
            da.Fill(setDate);
            ChirieDGV.DataSource = setDate.Tables[0];


            Con.Close();
        }
        private void completatiNrInmatriculare()
        {
            Con.Open();
            string query = "select  InmatriculareNr from MasinaTb1 where Disponibilitate='" +"DA"+ "'";
            SqlCommand cmd  = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("InmatriculareNr", typeof(string));
            dt.Load(rdr);
            ChirieMasinaCb.ValueMember = "InmatriculareNr";
            ChirieMasinaCb.DataSource = dt;
            Con.Close();    
        }

        private void completatiIdClient()
        {
            Con.Open();
            string query = "select  ClientId from ClientTb1";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ClientId", typeof(string));
            dt.Load(rdr);
            ClientIdCb.ValueMember = "ClientId";
            ClientIdCb.DataSource = dt;
            Con.Close();
        }

        private void aduceNumeClient()
        {
            Con.Open();

            string query = "select * from ClientTb1 where ClientId="+ClientIdCb.SelectedValue.ToString()+"";

            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                NumeClientTb.Text = dr["ClientNume"].ToString();
            }
            Con.Close();
        }

        private void ActualizareChirie()
        {
            Con.Open();
            string query = "update MasinaTb1 set Disponibilitate='" + "NU" + "' where InmatriculareNr='" + ChirieMasinaCb.SelectedValue.ToString() + "';";

            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Masina  sa modificat cu succes!");
            Con.Close();
        }

        private void StergeActualizareChirie()
        {
            Con.Open();
            string query = "update MasinaTb1 set Disponibilitate='" + "DA" + "' where InmatriculareNr='" + ChirieMasinaCb.SelectedValue.ToString() + "';";

            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Masina  sa modificat cu succes!");
            Con.Close();
        }


        private void Chirie_Load(object sender, EventArgs e)
        {
            completatiNrInmatriculare();
            completatiIdClient();
            populare();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void ChirieMasinaCb_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void ClientIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            aduceNumeClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ClientIdTb.Text == "" || NumeClientTb.Text == "" || TaxaTb.Text == "")
            {
                MessageBox.Show("Lipseste informatia");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into ChirieTb1 values(" + ClientIdTb.Text + ",'" + ChirieMasinaCb.SelectedValue.ToString() + "','" + NumeClientTb.Text + "','" + DataChirie.Value.ToString("yyyy-MM-dd") + "','" + DataReturn.Value.ToString("yyyy-MM-dd") + "'," + TaxaTb.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Masina sa inchiriat cu succes!");
                    Con.Close();
                    ActualizareChirie();

                    populare();

                }
                catch (Exception ExpectiMea)
                {
                    MessageBox.Show(ExpectiMea.Message);
                }
            }
        }

        private void DataChirie_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ClientIdTb.Text == "")
            {
                MessageBox.Show("Informatie pieduta");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from ChirieTb1 where ChirieID='" + ClientIdTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Inchirierea  este ștearsa cu succes");
                    Con.Close();
                    populare();
                    StergeActualizareChirie();
                }
                catch (Exception ExpectiMea)
                {
                    MessageBox.Show(ExpectiMea.Message);
                }
            }
        }

        private void ChirieDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClientIdTb.Text = ChirieDGV.SelectedRows[0].Cells[0].Value.ToString();
            ChirieMasinaCb.SelectedValue = ChirieDGV.SelectedRows[0].Cells[1].Value.ToString();
            NumeClientTb.Text = ChirieDGV.SelectedRows[0].Cells[2].Value.ToString();
            TaxaTb.Text = ChirieDGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

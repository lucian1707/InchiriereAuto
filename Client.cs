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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\InchiriereAuto\InchiriereAuto\InchiriereaAuto.mdf;Integrated Security=True");

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populare()
        {
            Con.Open();

            string query = "select * from ClientTb1 ";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder constructor = new SqlCommandBuilder(da);
            var setDate = new DataSet();
            da.Fill(setDate);
            ClientDGV.DataSource = setDate.Tables[0];


            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ClientAdrTb.Text == "" || ClientNumeTb.Text == "" || ClientAdrTb.Text == "" || TelefonTb.Text == "")
            {
                MessageBox.Show("Lipseste informatia");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into ClientTb1 values(" + ClientIdTb.Text + ", '" + ClientNumeTb.Text + "','" + ClientAdrTb.Text + "','" + TelefonTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Clientul sa adaugat cu succes!");
                    Con.Close();

                    populare();

                }
                catch (Exception ExpectiMea)
                {
                    MessageBox.Show(ExpectiMea.Message);
                }
            }
        }

        private void Client_Load(object sender, EventArgs e)
        {
            populare();
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
                    string query = "delete from ClientTb1 where ClientId='" + ClientIdTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Clientul este ștear cu succes");
                    Con.Close();
                    populare();
                }
                catch (Exception ExpectiMea)
                {
                    MessageBox.Show(ExpectiMea.Message);
                }
            }
        }

        private void ClientDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClientIdTb.Text = ClientDGV.SelectedRows[0].Cells[0].Value.ToString();
            ClientNumeTb.Text = ClientDGV.SelectedRows[0].Cells[1].Value.ToString();
            ClientAdrTb.Text = ClientDGV.SelectedRows[0].Cells[2].Value.ToString();
            TelefonTb.Text = ClientDGV.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ClientAdrTb.Text == "" || ClientNumeTb.Text == "" || ClientAdrTb.Text == "" || TelefonTb.Text == "")
            {
                MessageBox.Show("Lipseste informatia");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update ClientTb1 set ClientNume='" + ClientNumeTb.Text + "',ClientAdd='" + ClientAdrTb.Text + "',Telefon='" + TelefonTb.Text + "' where ClientId=" + ClientIdTb.Text + ";";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Masina  sa modificat cu succes!");
                    Con.Close();

                    populare();

                }
                catch (Exception ExpectiMea)
                {
                    MessageBox.Show(ExpectiMea.Message);
                }
            }
        }
    }
}

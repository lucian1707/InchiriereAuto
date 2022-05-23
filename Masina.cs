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
    public partial class Masina : Form
    {
        public Masina()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\InchiriereAuto\InchiriereAuto\InchiriereaAuto.mdf;Integrated Security=True");
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void populare()
        {
            Con.Open();

            string query = "select * from MasinaTb1 ";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder constructor = new SqlCommandBuilder(da);
            var setDate = new DataSet();
            da.Fill(setDate);
            MasinaDGV.DataSource = setDate.Tables[0];


            Con.Close();
        }

        private void completatiDisponibilitatea()
        {
            Con.Open();
            string query = "select Disponibilitate  from MasinaTb1 ";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Disponibilitate", typeof(string));
            dt.Load(rdr);
            CautareCb.ValueMember = "Disponibilitate";
            CautareCb.DataSource = dt;
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (InmatriculareNrTb.Text == "" || MarcaTb.Text == "" || ModelTb.Text == "" || PretTb.Text == "")
            {
                MessageBox.Show("Lipseste informatia");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into MasinaTb1 values('" + InmatriculareNrTb.Text + "', '" + MarcaTb.Text + "','" + ModelTb.Text + "','" + DisponibilCb.SelectedItem.ToString() + "','" + PretTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Masina sa adaugat cu succes!");
                    Con.Close();

                    populare();

                }
                catch (Exception ExpectiMea)
                {
                    MessageBox.Show(ExpectiMea.Message);
                }
            }
        }

        private void Masina_Load(object sender, EventArgs e)
        {
            populare();
            
        }

        private void InmatriculareNrTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void MarcaTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ModelTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (InmatriculareNrTb.Text == "")
            {
                MessageBox.Show("Informatie pieduta");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from MasinaTb1 where InmatriculareNr='" + InmatriculareNrTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Mașină ștearsă cu succes");
                    Con.Close();
                    populare();
                }
                catch (Exception ExpectiMea)
                {
                    MessageBox.Show(ExpectiMea.Message);
                }
            }
        }

        private void MasinaDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            InmatriculareNrTb.Text = MasinaDGV.SelectedRows[0].Cells[0].Value.ToString();
            MarcaTb.Text = MasinaDGV.SelectedRows[0].Cells[1].Value.ToString();
            ModelTb.Text = MasinaDGV.SelectedRows[0].Cells[2].Value.ToString();
            DisponibilCb.SelectedItem = MasinaDGV.SelectedRows[0].Cells[3].Value.ToString();
            PretTb.Text = MasinaDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (InmatriculareNrTb.Text == "" || MarcaTb.Text == "" || ModelTb.Text == "" || PretTb.Text == "")
            {
                MessageBox.Show("Lipseste informatia");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update MasinaTb1 set Brand='" + MarcaTb.Text + "',Model='" + ModelTb.Text + "', Disponibilitate='" + DisponibilCb.SelectedItem.ToString() + "',Pret='" + PretTb.Text + "' where InmatriculareNr='" + InmatriculareNrTb.Text + "';";

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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            populare();
        }

        private void CautareCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CautareCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string flag = "";
            if(CautareCb.SelectedItem.ToString() == "Disponibil	")
            {
                flag = "DA";
            }
            else
            {
                flag = "NU";
            }
            Con.Open();

            string query = "select * from MasinaTb1 where Disponibilitate = '"+flag+"' ";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder constructor = new SqlCommandBuilder(da);
            var setDate = new DataSet();
            da.Fill(setDate);
            MasinaDGV.DataSource = setDate.Tables[0];


            Con.Close();

        }
    }
}

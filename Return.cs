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
    public partial class Return : Form
    {
        public Return()
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

        private void populareRetur()
        {
            Con.Open();

            string query = "select * from ReturnTb1 ";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder constructor = new SqlCommandBuilder(da);
            var setDate = new DataSet();
            da.Fill(setDate);
            ReturnDGV.DataSource = setDate.Tables[0];


            Con.Close();
        }

        private void StergeReturn()
        {
            int rentId;
            rentId = Convert.ToInt32(ChirieDGV.SelectedRows[0].Cells[1].Value.ToString());
            Con.Open();
            string query = "delete from ChirieTb1 where ChirieID='" + ReturnIdTb.Text + "';";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inchirierea  este ștearsa cu succes");
            Con.Close();
            populare();
            //StergeActualizareChirie();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void Return_Load(object sender, EventArgs e)
        {
            populare();
            populareRetur();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChirieDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MasinaIdTb.Text = ChirieDGV.SelectedRows[0].Cells[1].Value.ToString();
            NumeClientTb.Text = ChirieDGV.SelectedRows[0].Cells[2].Value.ToString();
            DataReturn.Text = ChirieDGV.SelectedRows[0].Cells[4].Value.ToString();
            DateTime d1 = DataReturn.Value.Date;
            DateTime d2 = DateTime.Now;
            TimeSpan t = d2 - d1;
            int NrDeZile = Convert.ToInt32(t.TotalDays);
            if (NrDeZile<=0)
            {
                IntarziereTb.Text = "Nu sunt Intarzieri";
                AmendaTb.Text = "0";
            }else
            {
                IntarziereTb.Text =""+ NrDeZile;
                AmendaTb.Text = "" + (NrDeZile * 250);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ReturnIdTb.Text == "" || NumeClientTb.Text == ""  || IntarziereTb.Text == "" || AmendaTb.Text == "")
            {
                MessageBox.Show("Lipseste informatia");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into ReturnTb1 values(" + ReturnIdTb.Text + ",'" + MasinaIdTb.Text + "','" + NumeClientTb.Text + "','" + DataReturn.Value.ToString("yyyy-MM-dd") + "','" + IntarziereTb.Text + "'," + AmendaTb.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Masina sa inchiriat cu succes!");
                    Con.Close();
                    //ActualizareChirie();

                    populareRetur();
                    StergeReturn();

                }
                catch (Exception ExpectiMea)
                {
                    MessageBox.Show(ExpectiMea.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Utilizator : Form
    {
        public Utilizator()
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

            string query = "select * from UtilizatorTb1 ";
            SqlDataAdapter da= new SqlDataAdapter(query,Con);
            SqlCommandBuilder constructor = new SqlCommandBuilder(da);
            var setDate = new DataSet();
            da.Fill(setDate);
            UtilizatorDGV.DataSource = setDate.Tables[0];


            Con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Id.Text == "" || Unume.Text == "" || Uparola.Text == "")
            {
                MessageBox.Show("Lipseste informatia");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into UtilizatorTb1 values(" + Id.Text + ", '" + Unume.Text + "','" + Uparola.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Utilizatorul sa adaugat cu succes!");
                    Con.Close();

                    populare();

                }catch(Exception ExpectiMea)
                {
                    MessageBox.Show(ExpectiMea.Message);
                }
            }
        }

        private void Utilizator_Load(object sender, EventArgs e)
        {
            populare();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Id.Text=="")
            {
                MessageBox.Show("Informatie pieduta");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from UtilizatorTb1 where Id=" + Id.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Utilizator șters cu succes");
                    Con.Close();
                    populare();
                }catch(Exception ExpectiMea)
                {
                    MessageBox.Show(ExpectiMea.Message);
                }
            }
        }

        private void UtilizatorDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id.Text = UtilizatorDGV.SelectedRows[0].Cells[0].Value.ToString();
            Unume.Text = UtilizatorDGV.SelectedRows[0].Cells[1].Value.ToString();
            Uparola.Text = UtilizatorDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Id.Text == "" || Unume.Text == "" || Uparola.Text == "")
            {
                MessageBox.Show("Lipseste informatia");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update UtilizatorTb1 set Unume='" + Unume.Text + "',Uparola='" + Uparola.Text + "'where Id=" + Id.Text + ";";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Utilizatorul sa modificat cu succes!");
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

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main =new MainForm();
            main.Show();
        }
    }
}

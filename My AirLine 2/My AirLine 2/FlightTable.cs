using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Drawing;
namespace My_AirLine_2
{
    public partial class FlightTable : Form
    {
        public FlightTable()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\TanayAirlineDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (FcodeTb.Text == "" || Fsrc.Text ==""|| FDest.Text == "" || FDate.Text == "" || SeatNum.Text == "") 
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into FlightTbl values('"+ FcodeTb.Text +"','"+ Fsrc.SelectedItem.ToString()+"','"+ FDest.SelectedItem.ToString()+"','"+ FDate.Value.Date.ToString()+"','"+ SeatNum.Text +"')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Record Succefully");
                    Con.Close();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FcodeTb.Text = "";
            Fsrc.Text = "";
            FDest.Text = "";
            FDate.Text = "";
            SeatNum.Text = "";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ViewFlight viewflight = new ViewFlight();
            viewflight.Show();
            this.Hide();
        }

        private void FlightTable_Load(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

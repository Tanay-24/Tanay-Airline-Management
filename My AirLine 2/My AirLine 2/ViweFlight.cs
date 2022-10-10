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
    public partial class ViewFlight : Form
    {
        public ViewFlight()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\TanayAirlineDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void Populate()
        {
           Con.Open();
            string query = "select * from FlightTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
#pragma warning disable IDE0059 // Unnecessary assignment of a value
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
#pragma warning restore IDE0059 // Unnecessary assignment of a value
            var ds = new DataSet();
            sda.Fill(ds);
            FlightDGV.DataSource = ds.Tables[0];
           Con.Close();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (FcodeTb.Text == "" || SeatNum.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update FlightTbl set Fsrc = '"+ SrcCb.SelectedItem.ToString()+"', FDest = '"+ DstCb.SelectedItem.ToString()+"', FDate = '"+ FDate.Value.Date.ToString()+"', FCap = '"+ SeatNum.Text+"' where Fcode = '"+ FcodeTb.Text+"';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Upadte Successfully");
                    Con.Close();
                    Populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ViewFlight_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            FlightTable Addf1 = new FlightTable();
            Addf1.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FcodeTb.Text = "";
            SeatNum.Text = "";
            SrcCb.Text = "";
            DstCb.Text = "";
            FDate.Text = "";
        }

        private void FlightDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FcodeTb.Text = FlightDGV.SelectedRows[0].Cells[0].Value.ToString();
            SrcCb.SelectedItem = FlightDGV.SelectedRows[0].Cells[1].Value.ToString();
            SeatNum.Text = FlightDGV.SelectedRows[0].Cells[2].Value.ToString();
            DstCb.SelectedItem = FlightDGV.SelectedRows[0].Cells[3].Value.ToString();
            FDate.Text = FlightDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if(FcodeTb.Text == "")
            {
                MessageBox.Show("Enter the Flight");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from FlightTbl where FCode = '"+ FcodeTb.Text +"';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Delete Succfully");
                    Con.Close();
                    Populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ViewFlight_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure, you want to close this form", "Closeing information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult)
            {
                e.Cancel = true;
            }
        }

        private void Label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

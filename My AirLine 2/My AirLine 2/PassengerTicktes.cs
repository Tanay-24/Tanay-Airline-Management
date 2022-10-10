using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace My_AirLine_2
{
    public partial class PassengerTicktes : Form
    {
        public PassengerTicktes()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\TanayAirlineDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void PassengerTickte_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure, you want to close this form", "Closeing information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult)
            {
                e.Cancel = true;
            }
        }

        private void PassengerTicktes_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cbDest.SelectedItem = "";
            cbJT.SelectedItem = "";
            cbSrc.SelectedItem = "";
            cbST.SelectedItem = "";
            cbTC.SelectedItem = "";
            tbFN.Text = "";
            tbLN.Text = "";
            tbN.Text = "";
            tbNOS.Text = "";
            tbTotal.Text = "";
            JDate.Text = "";
            RDate.Text = "";
            cbG.SelectedItem = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbDest.SelectedItem = "";
            cbJT.SelectedItem = "";
            cbSrc.SelectedItem = "";
            cbST.SelectedItem = "";
            cbTC.SelectedItem = "";
            tbFN.Text = "";
            tbLN.Text = "";
            tbN.Text = "";
            tbNOS.Text = "";
            tbTotal.Text = "";
            JDate.Text = "";
            RDate.Text = "";
            cbG.SelectedItem = "";
        }

        private void cbG_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (tbFN.Text == "" || tbLN.Text == "" || tbN.Text == "" || tbNOS.Text == "") 
            {
                MessageBox.Show("Missing Information");
            }
           else 
            {
                try
                {
                    Con.Open();
                    string query = "insert into PassengerTicktesTbl values('" + cbTC.SelectedItem.ToString() + "','" + cbJT.SelectedItem.ToString() + "','" + cbST.SelectedItem.ToString() + "','" + tbNOS.Text + "','" + cbSrc.SelectedItem.ToString() + "','" + cbDest.SelectedItem.ToString() + "','"+ JDate.Value.Date.ToString() + "','" + RDate.Value.Date.ToString() + "','" + tbN.Text + "','" + tbFN.Text + "','" + tbLN.Text + "','" + cbG.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Booked Succefully");
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

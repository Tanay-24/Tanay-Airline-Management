using System;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace My_AirLine_2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
   
        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\TanayAirlineDb.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "select * from RegisterTbl2 where NameTb = '"+ NameTb.Text.Trim()+"'and PassTb = '"+ PassTb.Text.Trim()+"';";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count == 1)
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username OR Password WRONG!");
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            NameTb.Text = "";
            PassTb.Text = "";
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure, you want to close this form", "Closeing information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult)
            {
                e.Cancel = true;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void Label9_Click(object sender, EventArgs e)
        {
            PassengerTicktes passengerTicktes = new PassengerTicktes();
            passengerTicktes.Show();
            this.Hide(); 

            /* Ticktes ticktes = new Ticktes();   
            ticktes.Show();
            this.Hide(); */
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.Collections.Specialized;

namespace My_AirLine_2
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\TanayAirlineDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void Label6_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure, you want to close this form", "Closeing information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult)
            {
                e.Cancel = true;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || PassTb.Text == "" || MobileTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into RegisterTbl2 values('" + NameTb.Text + "','" + PassTb.Text + "', '" + MobileTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Record Succefully");
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            NameTb.Text = "";
            PassTb.Text = "";
                MobileTb.Text = "";
        }
    }
}

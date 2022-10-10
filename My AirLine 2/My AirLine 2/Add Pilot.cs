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
    public partial class Add_Pilot : Form
    {
        public Add_Pilot()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\TanayAirlineDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void Button1_Click(object sender, EventArgs e)
        {
            if(PilotID.Text == "" || PilotName.Text == "" || PassportNumber.Text == "" || PilotAddress.Text == "" || Phone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into PilotTbl values('"+PilotID.Text+ "','" + PilotName.Text + "','" + PassportNumber.Text + "','" + PilotAddress.Text + "','" + NationalityCb.SelectedItem.ToString() + "','" + GenderCb.SelectedItem.ToString()+ "','" + Phone.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pilot Record Succefully");
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Add_Pilot_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            View_Pilot viewpilot = new View_Pilot();
            viewpilot.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            PilotID.Text = "";
            PilotName.Text = "";
            PassportNumber.Text = "";
            PilotAddress.Text = "";
            NationalityCb.SelectedItem = "";
            GenderCb.SelectedItem = "";
            Phone.Text = "";
        }
    }
}

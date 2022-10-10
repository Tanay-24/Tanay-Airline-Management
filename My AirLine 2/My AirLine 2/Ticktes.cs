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
    public partial class Ticktes : Form
    {
        public Ticktes()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\TanayAirlineDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void Populate()
        {
            Con.Open();
            string query = "select * from TicketTbl";
            SqlDataAdapter sda  = new SqlDataAdapter(query, Con);
#pragma warning disable IDE0059 // Unnecessary assignment of a value
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
#pragma warning restore IDE0059 // Unnecessary assignment of a value
            var ds = new DataSet();
            sda.Fill(ds);
            TicketDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        public void FillPilot()
        {
           Con.Open();
            SqlCommand cmd = new SqlCommand("select PilotID from PilotTbl",Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PilotID", typeof(int));
            dt.Load(rdr);
            PIdCb.ValueMember = "PilotID";
            PIdCb.DataSource = dt;
           Con.Close();
        }
        public void FillFlightCode()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Fcode from FlightTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Fcode", typeof(string));
            dt.Load(rdr);
            FcodeCb.ValueMember = "Fcode";
            FcodeCb.DataSource = dt;
            Con.Close();
        }
        private void Label4_Click(object sender, EventArgs e)
        {

        }
        string pname, ppass, pnat;
        private void Fetchpilot()
        {
            Con.Open();
            string query = "select * from PilotTbl where PilotID = "+ PIdCb.SelectedValue.ToString() +";";
            SqlCommand cmd = new SqlCommand(query,Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                pname = dr["PilotName"].ToString();
                ppass = dr["PassportNumber"].ToString();
                pnat = dr["PilotNat"].ToString();
                PNameTb.Text = pname;
                PpassTb.Text = ppass;
                PNatTb.Text = pnat;
            }
            Con.Close();
        }


        private void Button1_Click_2(object sender, EventArgs e)
        {
            if(TId.Text == "" || PNameTb.Text =="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into TicketTbl values('"+ TId.Text+"','"+ FcodeCb.SelectedValue.ToString() +"', '"+ PIdCb.SelectedValue.ToString()+"', '"+ PNameTb.Text+"', '"+ PpassTb.Text+"', '"+ PNatTb.Text +"', '"+ PAmtTb.Text +"')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Booked Succefully");
                    Con.Close();
                    Populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            PNameTb.Text = "";
            PpassTb.Text = "";
            PNatTb.Text = "";
            PAmtTb.Text = "";
            TId.Text = "";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void TicketDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ticktes_Load(object sender, EventArgs e)
        {
           FillPilot();
            FillFlightCode();
            Populate();
        }

        private void PIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Fetchpilot();
        }
    }
}

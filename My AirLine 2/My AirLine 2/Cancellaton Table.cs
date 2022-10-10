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
    public partial class Cancellaton_Table : Form
    {
        public Cancellaton_Table()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\TanayAirlineDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void FillTicketId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select TId from TicketTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TId", typeof(string));
            dt.Load(rdr);
            TidCb.ValueMember = "TId";
            TidCb.DataSource = dt;
            Con.Close();
        }
        private void Fetchfcode()
        {
            Con.Open();
            string query = "select * from TicketTbl where TId = " + TidCb.SelectedValue.ToString() + ";";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                FcodeTb.Text = dr["Fcode"].ToString();
            }
            Con.Close();
        }
        private void Populate()
        {
            Con.Open();
            string query = "select * from CancelTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
#pragma warning disable IDE0059 // Unnecessary assignment of a value
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
#pragma warning restore IDE0059 // Unnecessary assignment of a value
            var ds = new DataSet();
            sda.Fill(ds);
            CancelDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Cancellaton_Table_Load(object sender, EventArgs e)
        {
            FillTicketId();
            Populate();
        }

        private void TidCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Fetchfcode();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        private void DeleteTicket()
        {
            try
            {
                Con.Open();
                string query = "delete from TicketTbl where TId = " + TidCb.SelectedValue.ToString() + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
               // MessageBox.Show("");
                Con.Close();
                Populate();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (CanId.Text == "" || FcodeTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = " insert into CancelTbl values('" + CanId.Text + "','" + TidCb.SelectedValue.ToString() + "','" + FcodeTb.Text + "','" + CancDate.Value.Date + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cancel Ticket Succefully");
                    Con.Close();
                    Populate();
                    DeleteTicket();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CanId.Text = "";
            FcodeTb.Text = "";
        }

        private void CancelDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}

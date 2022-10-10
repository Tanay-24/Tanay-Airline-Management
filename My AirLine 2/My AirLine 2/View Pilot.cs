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
    public partial class View_Pilot : Form
    {
        public View_Pilot()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\TanayAirlineDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void Populate()
        {
           Con.Open();
            string query = "select * from PilotTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
#pragma warning disable IDE0059 // Unnecessary assignment of a value
            SqlCommandBuilder builder = new SqlCommandBuilder();
#pragma warning restore IDE0059 // Unnecessary assignment of a value
            var ds = new DataSet();
            sda.Fill(ds);
            PilotDGV.DataSource = ds.Tables[0];
           Con.Close();
        }
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void View_Pilot_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Add_Pilot addpilot = new Add_Pilot();
            addpilot.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if(PilotID.Text == "")
            {
                MessageBox.Show("Enter The Passenger to Delete");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from PilotTbl where PilotID = "+ PilotID.Text +";"; 
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pilot Delete Succefully");
                    Con.Close();
                    Populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void PilotDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PilotID.Text = PilotDGV.SelectedRows[0].Cells[0].Value.ToString();
            PilotNameTb.Text = PilotDGV.SelectedRows[0].Cells[1].Value.ToString();
            PpassTb.Text = PilotDGV.SelectedRows[0].Cells[2].Value.ToString();
            PilotAddTb.Text = PilotDGV.SelectedRows[0].Cells[3].Value.ToString();
            natcb.SelectedItem = PilotDGV.SelectedRows[0].Cells[4].Value.ToString();
            Gendcb.SelectedItem = PilotDGV.SelectedRows[0].Cells[5].Value.ToString();
            PphoneTb.Text = PilotDGV.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            PilotID.Text = "";
            PilotNameTb.Text = "";
            PpassTb.Text = "";
            PilotAddTb.Text = "";
            natcb.SelectedItem = "";
            Gendcb.SelectedItem = "";
            PphoneTb.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(PilotID.Text == "" || PilotNameTb.Text == "" || PpassTb.Text == "" || PilotAddTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update PilotTbl set PilotName = '"+PilotNameTb.Text+ "',PassportNumber = '" + PpassTb.Text + "',PilotAddress = '" + PilotAddTb.Text + "',PilotNat = '" + natcb.SelectedItem.ToString() + "',PilotGend = '" + Gendcb.SelectedItem.ToString() + "',PilotPhone = '" + PphoneTb.Text + "' where PilotID = "+ PilotID.Text+";";      
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pilot Updated Succefully");
                    Con.Close();
                    Populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void View_Pilot_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure, you want to close this form", "Closeing information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult)
            {
                e.Cancel = true;
            }
        }
    }
}

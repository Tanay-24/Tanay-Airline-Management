using System;
using System.Windows.Forms;

namespace My_AirLine_2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FlightTable flight = new FlightTable();
            flight.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Add_Pilot pilot = new Add_Pilot();
            pilot.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Ticktes tick = new Ticktes();
            tick.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Cancellaton_Table Can = new Cancellaton_Table();
            Can.Show();
            this.Hide();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure, you want to close this form", "Closeing information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult)
            {
                e.Cancel = true;
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
     
        }

        private void Label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

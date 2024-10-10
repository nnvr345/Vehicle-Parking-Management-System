using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vehicle_parking_system
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Slots cs = new Slots();
            cs.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Arrival arrival = new Arrival();
            arrival.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Departure departure = new Departure();  
            departure.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reservation rb = new reservation();
            rb.Show();
            this.Hide();
        }
    }
}

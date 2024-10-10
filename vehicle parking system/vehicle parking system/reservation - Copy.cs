using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vehicle_parking_system
{
    public partial class reservation : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext(); 
            public reservation()
        {
            InitializeComponent();
        }

        private void labelid1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void reservation_Load(object sender, EventArgs e)
        {
            var id = db.tbldepartures.ToList();
            dataGridView1.DataSource = id;
            display();
        }
        public void display()
        {
            int sum = 0;
            for(int i=0;i<dataGridView1.Rows.Count;i++)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
            }
            lblammont.Text = sum.ToString();

            var slot = db.tbl_slots.Count();
            lblcp.Text = slot.ToString();
            var pca = db.tblarrivals.Count();
            lblttldep.Text = pca.ToString();

            var pca1 = db.tbldepartures.Count();
            labelarrive.Text = pca1.ToString();
                }

        private void textsearch_TextChanged(object sender, EventArgs e)
        {
            if (textsearch.Text == "")
            {
                load1();
            }
            else
            {
                var chk1 = db.tbldepartures.Where(s => s.carno == textsearch.Text || s.driver == textsearch.Text || s.type == textsearch.Text);
                if (chk1 != null)
                {
                    dataGridView1.DataSource = chk1;
                }
            }
        }
        private void load1()
        {
            var lb = db.tbldepartures.ToList();
            dataGridView1.DataSource = lb;
        }
        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            invoice i = new invoice();
            i.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       
            
    }
}

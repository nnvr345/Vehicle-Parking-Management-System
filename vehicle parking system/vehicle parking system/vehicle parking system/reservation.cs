using DGVPrinterHelper;
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
            labelarrive.Text = pca.ToString();
            var pcal  = db.tbldepartures.Count();
            lblttldep.Text = pca.ToString();
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
                    display();
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

            DGVPrinter p = new DGVPrinter();
            p.printDocument = printDocument1;
            p.Title = "TOTAL CAPACITY REPORT";
            p.SubTitle = string.Format("DATE:{0}", DateTime.Now);
            p.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            p.printDocument = printDocument1;
            p.PageNumbers = true;
            p.PageNumberInHeader = true;
            p.PorportionalColumns = true;
            p.HeaderCellAlignment = StringAlignment.Near;
            p.Footer = "vehicle parkig system";
            p.FooterSpacing = 15;
            p.PrintDataGridView(dataGridView1);
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

        private void button3_Click(object sender, EventArgs e)
        {
            Welcome wc = new Welcome();
            wc.Show();
            this.Hide();
        }

        private void lblttldep_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class invoice : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public invoice()
        {
            InitializeComponent();
        }

        private void textsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void invoice_Load(object sender, EventArgs e)
        {
            combocarno.DataSource = db.tbldepartures.ToList();
            combocarno.ValueMember = "carno";
            combocarno.DisplayMember = "carno";
        }
        Bitmap bitmap;

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Graphics myg = this.CreateGraphics();
               bitmap = new Bitmap(this.Size.Width, this.Size.Height, myg);
                Graphics mg = Graphics.FromImage(bitmap);
                mg.CopyFromScreen(this.Location.X, Location.Y, 0, 0, this.Size);
               printPreviewDialog1.Show();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "error");
                    }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                tbldeparture obj = combocarno.SelectedItem as tbldeparture;
                if (obj != null)
                {
                   lbldriver.Text = obj.driver.ToString();
                    labeltype.Text = obj.type.ToString();
                    labelentrytime.Text = obj.p_type.ToString();
                    labelamount.Text = obj.amoount.ToString();
                    lblcarno.Text = obj.carno.ToString();
                    labeldtime.Text = obj.departure_time.ToString();
                }
                Cursor.Current = Cursors.Default;

               
      
                    var chk1 = db.tbldepartures.Where(s => s.carno == combocarno.Text || s.driver == combocarno.Text || s.type == combocarno.Text);
                    if (chk1 != null)
                    {
                        dataGridView1.DataSource = chk1;
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }

        private void printPreview(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void labeldtime_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}

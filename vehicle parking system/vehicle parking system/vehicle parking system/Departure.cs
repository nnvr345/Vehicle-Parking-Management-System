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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using DGVPrinterHelper;
using System.Drawing.Printing;

namespace vehicle_parking_system
{
    public partial class Departure : Form
    {  DataClasses1DataContext db=new DataClasses1DataContext();

        public Departure()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (combocarno.Text != null & labelname.Text != null & labelptime.Text != null & labelptype.Text != null )
                {
                    
                        tbldeparture s = new tbldeparture();   
                        s.carno = combocarno.Text;
                        s.driver = labelname.Text;
                        s.type = labelptype.Text;
                        s.p_type = labelptime.Text;

                    decimal str = Convert.ToDecimal(labelptime.Text);
                    decimal amt = Convert.ToDecimal(textpammount.Text);
                    decimal amttotal  = str * amt;


                        s.amoount = amttotal;
                        s.departure_time = DateTime.Now;
                        db.tbldepartures.InsertOnSubmit(s);
                        db.SubmitChanges();
                        MessageBox.Show("departured succelfully");

                    load();
                    


                }
                else
                {
                    MessageBox.Show("Slot No or Location Box Empty");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void load()
        {
            var dbload = db.tbldepartures.ToList();
            dataGridView1.DataSource = dbload;
            combocarno.DataSource = db.tblarrivals.ToList();
            combocarno.ValueMember = "Car_No";
            combocarno.DisplayMember = "Car_No";
        }

        private void texttime_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Welcome wc = new Welcome(); 
            wc.Show();
            this.Hide();
        }

        private void Departure_Load(object sender, EventArgs e)
        {
            try
            {
                var dbload = db.tbldepartures.ToList();
                dataGridView1.DataSource = dbload;
                combocarno.DataSource = db.tblarrivals.ToList();
                combocarno.ValueMember = "Car_No";
                combocarno.DisplayMember = "Car_No";

            }
            catch (Exception ex){
                MessageBox.Show(ex.Message, "error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (combocarno.Text != null & labelname.Text != null & labelptime.Text != null & labelptype.Text != null & labelptime.Text != null)
                {
                   
                    if (MessageBox.Show("Do you Want to edit record!","edit",MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    {
                        tbldeparture s = new tbldeparture();
                        s.carno = combocarno.Text;
                        s.driver = labelname.Text;
                        s.type = labelptype.Text;
                        s.p_type = labelptime.Text;
                        decimal str = Convert.ToDecimal(labelptime.Text);
                        decimal amt = Convert.ToDecimal(textpammount.Text);
                        decimal amttotal = str * amt;
                        s.amoount = amttotal;
                        s.departure_time = DateTime.Now;
                        db.SubmitChanges();
                        MessageBox.Show("data inserted");
                        load();
                    }
                }
                else
                {
                    MessageBox.Show("Slot No or Location Box Empty");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void combocarno_SelectedIndexChanged(object sender, EventArgs e)
        {
try
            {
Cursor.Current = Cursors.WaitCursor;
                tblarrival obj = combocarno.SelectedItem as tblarrival;
                if (obj != null)
                {
                    labelname.Text = obj.driver_name.ToString();
                    labelptype.Text = obj.category.ToString();
                   labelptime.Text = obj.stay_time.ToString();
                }
            }
            catch(Exception ex) {
            MessageBox.Show(ex.Message, "error");
                    }
        }

        private void labelptime_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int  indexrow = e.RowIndex;
            labelid1.Text = dataGridView1.Rows[indexrow].Cells[0].Value.ToString();
            lbldtime.Text = dataGridView1.Rows[indexrow].Cells[6].Value.ToString();
            lbldtime.Text = dataGridView1.Rows[indexrow].Cells[5].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (labelid1.Text != null)
                {
                    if (MessageBox.Show("Do you want to edit record!..", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    {
                        
                            int st = Convert.ToInt32(labelid1.Text);
                            var s = db.tbldepartures.Where(o => o.ID == st).FirstOrDefault();
                        db.tbldepartures.DeleteOnSubmit(s);
                            db.SubmitChanges();
                            MessageBox.Show("data updated");

                            load();
                        
                    }

                    else
                    {
                        MessageBox.Show("record not selected please select and delete");
                    }
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indexrow = e.RowIndex;
            labelid1.Text = dataGridView1.Rows[indexrow].Cells[0].Value.ToString();
            lbldtime.Text = dataGridView1.Rows[indexrow].Cells[6].Value.ToString();
            lblfee.Text = dataGridView1.Rows[indexrow].Cells[5].Value.ToString();

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
           if(chk1 != null)
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

        private void textcarno_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
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

        private void button5_Click_1(object sender, EventArgs e)
        {
            Welcome wc = new Welcome();
            wc.Show();
            this.Hide();
        }
    }
}

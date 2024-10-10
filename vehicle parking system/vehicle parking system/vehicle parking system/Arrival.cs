using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace vehicle_parking_system
{
    public partial class Arrival : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public Arrival()
        {
            InitializeComponent();
        }
        public void load()
        {
            var lb = db.tblarrivals.ToList();
            dataGridView1.DataSource = lb;
            labelid.Text = "";
            textdriver.Text = "";
            textcarno.Text = "";
            texttime.Text = "";
            checkedListBox1.Text = "";
            var total = db.tblarrivals.Count();
            lbltotal.Text = total.ToString();
        }
        private void Arrival_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = db.tbl_slots.ToList();
            comboBox1.ValueMember = "Slot_No";
            comboBox1.DisplayMember = "Slot_No";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ir = e.RowIndex;
            labelid.Text = dataGridView1.Rows[ir].Cells[0].Value.ToString();
            textdriver.Text = dataGridView1.Rows[ir].Cells[1].Value.ToString();
            textcarno.Text = dataGridView1.Rows[ir].Cells[2].Value.ToString();
            texttime.Text = dataGridView1.Rows[ir].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[ir].Cells[4].Value.ToString();
            checkedListBox1.Text = dataGridView1.Rows[ir].Cells[5].Value.ToString();
            lblarrival.Text = dataGridView1.Rows[ir].Cells[6].Value.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Welcome wc = new Welcome();
            wc.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (labelid.Text != null)
                {
                    if (MessageBox.Show("Do you want to delete record!..", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    {

                        int st = Convert.ToInt32(labelid.Text);
                        var s = db.tblarrivals.Where(o => o.ID == st).FirstOrDefault();
                        db.tblarrivals.DeleteOnSubmit(s);
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

        private void textslot_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textdriver.Text != null & textcarno.Text != null & texttime.Text != null & checkedListBox1.Text != null & comboBox1.Text != null & checkBoxbike.Text != null || checkboxcar.Text!=null)
                {
                    string sno = textcarno.Text;
                    var chk = db.tblarrivals.Where(o => o.car_no == sno).FirstOrDefault();
                    if (chk == null)
                    {
                        tblarrival s = new tblarrival();
                        s.driver_name = textdriver.Text;
                        s.car_no = textcarno.Text;
                        s.category = checkedListBox1.Text;
                        s.stay_time = texttime.Text;
                        s.selected_slot = comboBox1.Text;
                        s.a_time = DateTime.Now;
                        db.tblarrivals.InsertOnSubmit(s);
                        db.SubmitChanges();
                        MessageBox.Show("data inserted");

                        load();
                        if (checkboxcar.Checked)
                        {
                            car c = new car();
                            c.drivername = textdriver.Text;
                            c.car_no = textcarno.Text;
                            c.stay_time = texttime.Text;
                            c.category = checkedListBox1.Text;
                            c.selected_slot= comboBox1.Text;
                            c.a_time = DateTime.Now;
                            db.cars.InsertOnSubmit(c);
                            db.SubmitChanges();
                            MessageBox.Show("data insertyed into car");
                            load();
                        }
                        else
                        {
                            MessageBox.Show("select a vehicle type");

                        }
                        if(checkBoxbike.Checked)
                        {
                            bike c= new bike();
                            c.drivername = textdriver.Text;
                            c.car_no = textcarno.Text;
                            c.stay_time = texttime.Text;
                            c.category = checkedListBox1.Text;
                            c.selected_slot = comboBox1.Text;
                            c.a_time = DateTime.Now;
                            db.bikes.InsertOnSubmit(c);
                            db.SubmitChanges();
                            MessageBox.Show("data insertyed into car");
                            load();

                        }
                        else
                        {
                            MessageBox.Show("select a vehicle type");

                        }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (labelid.Text != null & textdriver.Text != null & textcarno.Text != null & texttime.Text != null & checkedListBox1.Text != null & comboBox1.Text != null)
                {
                    string sno = textcarno.Text;
                    var chk = db.tblarrivals.Where(o => o.car_no == sno).FirstOrDefault();
                    if (chk == null)
                    {
                        tblarrival s = new tblarrival();
                        s.driver_name = textdriver.Text;
                        s.car_no = textcarno.Text;
                        s.category = checkedListBox1.Text;
                        s.stay_time = texttime.Text;
                        s.selected_slot = comboBox1.Text;
                        s.a_time = DateTime.Now;
                        db.SubmitChanges();
                        MessageBox.Show("data edited");
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

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textsearch_TextChanged(object sender, EventArgs e)
        {
            if (textsearch.Text == " ")
            {
                load();
            }
            else
            {
                searchdata();
            }
        }
        public void searchdata()
        {
            try
            {
                if (textsearch.Text != null)
                {
                    string sk = textsearch.Text;
                    var chk = db.tblarrivals.Where(o => o.driver_name == sk || o.car_no == sk || o.category == sk).ToList();
                    if (chk != null)
                    {

                        dataGridView1.DataSource = chk;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelid_Click(object sender, EventArgs e)
        {

        }

        private void textcarno_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblcarno_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblarrival_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void checkboxcar_CheckedChanged(object sender, EventArgs e)
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
        private void reset()
        {

        }
    }
}

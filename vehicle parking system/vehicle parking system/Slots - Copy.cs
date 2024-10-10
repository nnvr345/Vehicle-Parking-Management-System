using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vehicle_parking_system
{
    public partial class Slots : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Slots()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Welcome s = new Welcome();
            s.Show();
            this.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int ir = e.RowIndex;
            labelid.Text = dataGridView1.Rows[ir].Cells[0].Value.ToString();
            textslot.Text = dataGridView1.Rows[ir].Cells[1].Value.ToString();
            textlocation.Text = dataGridView1.Rows[ir].Cells[2].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textemail_TextChanged(object sender, EventArgs e)
        {

        }
        public void reset()
        {
            textslot.Text = "";
            textlocation.Text = "";
            labelid.Text = "";

        }

        public void load()
        {
            var load = db.tbl_slots.ToList();
            dataGridView1.DataSource = load;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textslot.Text != null && textlocation.Text != null)
                {
                    tbl_slot s = new tbl_slot();
                    s.Slot_No = textslot.Text;
                    s.Location = textlocation.Text;
                    db.tbl_slots.InsertOnSubmit(s);
                    db.SubmitChanges();
                    MessageBox.Show("data inserted");
                    reset();
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

        private void textlocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (labelid.Text != null & textslot.Text != null & textlocation.Text != null)
                {

                    if (MessageBox.Show("Do you want to edit record!..", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    {
                        string sno = textslot.Text;
                        var chk = db.tbl_slots.Where(o => o.Slot_No == sno).FirstOrDefault();
                        if (chk == null)
                        {
                            int st = Convert.ToInt32(labelid.Text);
                            var s = db.tbl_slots.Where(o => o.Id == st).FirstOrDefault();

                            s.Slot_No = textslot.Text;
                            s.Location = textlocation.Text;

                            db.SubmitChanges();
                            MessageBox.Show("data updated");
                            reset();
                            load();
                        }


                        else
                        {
                            MessageBox.Show("with this name slot already inserted");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Slot no or location box empty");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (labelid.Text != null)
                {

                    if (MessageBox.Show("Do you want to delete record..", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    {

                        int st = Convert.ToInt32(labelid.Text);
                        var s = db.tbl_slots.Where(o => o.Id == st).FirstOrDefault();

                        db.tbl_slots.DeleteOnSubmit(s);
                        db.SubmitChanges();
                        MessageBox.Show("DATA DELETED");
                        reset();
                        load();

                    }
                }
                else
                {
                    MessageBox.Show(" Record not selected please select it and then delete ..!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
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
                if (textsearch.Text!=null )
                {
                    string sk = textsearch.Text;
                    var chk = db.tbl_slots.Where(o => o.Slot_No == sk || o.Location == sk).FirstOrDefault();
                    if (chk != null)
                    {
                        
                        dataGridView1.DataSource = chk;
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error");

            }
        }
            
    }
    }


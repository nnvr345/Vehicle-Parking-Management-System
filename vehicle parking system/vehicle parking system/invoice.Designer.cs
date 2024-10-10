namespace vehicle_parking_system
{
    partial class invoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(invoice));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.combocarno = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.labeltype = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblcarno = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbldriver = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelamount = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.labeldtime = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelentrytime = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreview);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(1588, 537);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.combocarno);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.labeltype);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblcarno);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbldriver);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1502, 310);
            this.panel1.TabIndex = 0;
            // 
            // combocarno
            // 
            this.combocarno.FormattingEnabled = true;
            this.combocarno.Location = new System.Drawing.Point(756, 25);
            this.combocarno.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.combocarno.Name = "combocarno";
            this.combocarno.Size = new System.Drawing.Size(238, 33);
            this.combocarno.TabIndex = 28;
            this.combocarno.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.Location = new System.Drawing.Point(1030, 29);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "PRINT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labeltype
            // 
            this.labeltype.AutoSize = true;
            this.labeltype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltype.Location = new System.Drawing.Point(1252, 242);
            this.labeltype.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labeltype.Name = "labeltype";
            this.labeltype.Size = new System.Drawing.Size(36, 37);
            this.labeltype.TabIndex = 27;
            this.labeltype.Text = "a";
            this.labeltype.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1136, 242);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 37);
            this.label7.TabIndex = 26;
            this.label7.Text = "Type:";
            // 
            // lblcarno
            // 
            this.lblcarno.AutoSize = true;
            this.lblcarno.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcarno.Location = new System.Drawing.Point(772, 244);
            this.lblcarno.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblcarno.Name = "lblcarno";
            this.lblcarno.Size = new System.Drawing.Size(34, 40);
            this.lblcarno.TabIndex = 24;
            this.lblcarno.Text = "a";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(630, 244);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 40);
            this.label6.TabIndex = 23;
            this.label6.Text = "Car No:";
            // 
            // lbldriver
            // 
            this.lbldriver.AutoSize = true;
            this.lbldriver.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldriver.Location = new System.Drawing.Point(232, 244);
            this.lbldriver.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbldriver.Name = "lbldriver";
            this.lbldriver.Size = new System.Drawing.Size(34, 40);
            this.lbldriver.TabIndex = 20;
            this.lbldriver.Text = "a";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 244);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 40);
            this.label5.TabIndex = 19;
            this.label5.Text = "DriverName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(414, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(703, 56);
            this.label4.TabIndex = 18;
            this.label4.Text = "Vehicle Parking System(Receipt)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(558, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 40);
            this.label1.TabIndex = 16;
            this.label1.Text = "SEARCH:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelamount);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.labeldtime);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.labelentrytime);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(6, 328);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1502, 531);
            this.panel2.TabIndex = 1;
            // 
            // labelamount
            // 
            this.labelamount.AutoSize = true;
            this.labelamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelamount.Location = new System.Drawing.Point(1386, 81);
            this.labelamount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelamount.Name = "labelamount";
            this.labelamount.Size = new System.Drawing.Size(84, 37);
            this.labelamount.TabIndex = 37;
            this.labelamount.Text = "00.0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1198, 81);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(145, 37);
            this.label17.TabIndex = 36;
            this.label17.Text = "Amount:";
            // 
            // labeldtime
            // 
            this.labeldtime.AutoSize = true;
            this.labeldtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldtime.Location = new System.Drawing.Point(968, 81);
            this.labeldtime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labeldtime.Name = "labeldtime";
            this.labeldtime.Size = new System.Drawing.Size(109, 37);
            this.labeldtime.TabIndex = 35;
            this.labeldtime.Text = "e.time";
            this.labeldtime.Click += new System.EventHandler(this.labeldtime_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(660, 81);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(282, 37);
            this.label15.TabIndex = 34;
            this.label15.Text = "Departured Time:";
            // 
            // labelentrytime
            // 
            this.labelentrytime.AutoSize = true;
            this.labelentrytime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelentrytime.Location = new System.Drawing.Point(310, 73);
            this.labelentrytime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelentrytime.Name = "labelentrytime";
            this.labelentrytime.Size = new System.Drawing.Size(73, 36);
            this.labelentrytime.TabIndex = 33;
            this.labelentrytime.Text = "time";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(72, 71);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(219, 37);
            this.label13.TabIndex = 32;
            this.label13.Text = "Parked Time:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 46);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 25);
            this.label9.TabIndex = 29;
            this.label9.Text = "label9";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(304, 46);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 25);
            this.label10.TabIndex = 30;
            this.label10.Text = "label10";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1514, 865);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 865);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "invoice";
            this.Text = "invoice";
            this.Load += new System.EventHandler(this.invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labeltype;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblcarno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbldriver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ComboBox combocarno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelamount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labeldtime;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelentrytime;
        private System.Windows.Forms.Label label13;
    }
}
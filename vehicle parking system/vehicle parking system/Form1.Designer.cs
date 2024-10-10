namespace vehicle_parking_system
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textemail = new System.Windows.Forms.TextBox();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.LOGIN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "VEHICLE PARKING SYSTEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "EMAIL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 396);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSWORD:";
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(242, 223);
            this.textemail.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(348, 31);
            this.textemail.TabIndex = 3;
            this.textemail.TextChanged += new System.EventHandler(this.textemail_TextChanged);
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(242, 398);
            this.textpassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(348, 31);
            this.textpassword.TabIndex = 4;
            // 
            // LOGIN
            // 
            this.LOGIN.BackColor = System.Drawing.Color.OliveDrab;
            this.LOGIN.Location = new System.Drawing.Point(282, 610);
            this.LOGIN.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(198, 121);
            this.LOGIN.TabIndex = 5;
            this.LOGIN.Text = "LOGIN";
            this.LOGIN.UseVisualStyleBackColor = false;
            this.LOGIN.Click += new System.EventHandler(this.LOGIN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(750, 865);
            this.Controls.Add(this.LOGIN);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.Button LOGIN;
    }
}


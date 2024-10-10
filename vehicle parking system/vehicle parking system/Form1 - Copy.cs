using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace vehicle_parking_system
{
    public partial class Form1 : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            try
            {
                if( textemail.Text != null & textpassword.Text != null ) {
                var item = db.Accounts.Where(s => s.Email == textemail.Text  && s.Password == textpassword.Text).FirstOrDefault();
                    if( item != null ) {
                    Welcome wc = new Welcome();
                        wc.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("your enter account information not exists");
                    }
                }
                else
                {
                    MessageBox.Show("email or password is incorect");
                }
            }
            catch(Exception ex) {
            MessageBox.Show(ex.Message);
                   }
        }

        private void textemail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RsaAes
{
    public partial class Signup : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public Signup()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Server=LAPTOP-JC6558TK\SQLEXPRESS;Database=DataProtection_db;Trusted_Connection=True;");
            cn.Open();
            if (textBoxpassword.Text != string.Empty || textBoxusername.Text != string.Empty)
            {

                cmd = new SqlCommand("INSERT INTO tblusers (username, password) VALUES('"  + textBoxusername.Text + "' , '" + textBoxpassword.Text + "' ) ", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    
                    MessageBox.Show("Signed up success fully!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dr.Close();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Signed up success fully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Visible = true;
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye");
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

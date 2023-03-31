using MainGui;
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
    public partial class Login : Form
    {
      
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Server=LAPTOP-JC6558TK\SQLEXPRESS;Database=DataProtection_db;Trusted_Connection=True;");
            cn.Open();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (textBoxpassword.Text != string.Empty || textBoxusername.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from tblusers where username='" + textBoxusername.Text + "' and password='" + textBoxpassword.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                   
                    dr.Close();
                    this.Hide();
                    MainGui.GUI home = new GUI(textBoxusername.Text);
                    home.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
           this.Hide();
            Signup signup = new Signup();
            signup.Visible=true;
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye");
            this.Close();
        }
    }
}

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


namespace MainFrame
{
  
    
    public partial class UserLogin : Form
    {
        person p;

        
        public UserLogin()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project\MainFrame\MainFrame\ShoppinCart.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter(@"select * from [Customer] where C_ID='"+ Convert.ToInt32(userTextBox.Text) +"' and C_Password='"+ Convert.ToInt32(passTextBox.Text) +"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            p = new person(Convert.ToInt32(userTextBox.Text));

            if (dt.Rows.Count == 1)
            {
                CoustomerHome ch = new CoustomerHome(p);
                ch.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
                userTextBox.Text = passTextBox.Text = string.Empty;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            
            this.Close();
            mainForm mf = new mainForm();
            mf.Show();
        }

        private void userTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }

        private void showpasscheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (showpasscheckbox.Checked == true)
            {
                passTextBox.PasswordChar = '\0';
            }
            else
            {
                passTextBox.PasswordChar = '*';
            }
        }

        private void UserLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}

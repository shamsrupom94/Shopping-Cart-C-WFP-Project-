using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainFrame
{
    
    
    public partial class mainForm : Form
    {
        
        public mainForm()
        {
            InitializeComponent();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            UserLogin ul = new UserLogin();

            ul.Show();
            this.Hide();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            AdminLogin al = new AdminLogin();
            al.Show();
            this.Hide();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           Application.Exit();
        }
    }

    public class person
    {
        public int id;

        public person(int id) {
            this.id = id;
        }
    }
}

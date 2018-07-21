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
    public partial class Shopping_List : Form
    {
        person pp;
        public Shopping_List(person p)
        {
            pp=p;

            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
           /* DialogResult dr = MessageBox.Show("Are you sure you want to Go Back?", "Warning", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                CoustomerHome ch = new CoustomerHome(p);
                ch.Show();
                this.Hide();
            }
            else
            {

            }*/
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your list is now printing \n Thankyou for shopping with us");
            this.Close();
            ShoppingCartDataContext scdc = new ShoppingCartDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project\MainFrame\MainFrame\ShoppinCart.mdf;Integrated Security=True;Connect Timeout=30");
            Transaction t = new Transaction();
            var s = from a in scdc.Transactions
                    select a;

            scdc.Transactions.DeleteAllOnSubmit(s);
            scdc.SubmitChanges();
            

        }

        private void Shopping_List_Load(object sender, EventArgs e)
        {
            

            ShoppingCartDataContext scdc = new ShoppingCartDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project\MainFrame\MainFrame\ShoppinCart.mdf;Integrated Security=True;Connect Timeout=30");
            
            Customer u2 = scdc.Customers.SingleOrDefault(x => x.C_ID == pp.id);
            CF_name.Text = u2.C_Firstname;
            CLname.Text  = u2.C_Lastname;
            var s = from a in scdc.Transactions

                    select new
                    {
                        Product_ID = a.P_ID,
                        Product_Name = a.P_Name,

                        Price = a.Price,
                        Amount = a.Quantity,

                        Total = a.Total

                    };
            Final_ListGridView.DataSource = s.ToList();

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project\MainFrame\MainFrame\ShoppinCart.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand query = new SqlCommand("select sum(Total) from [Transaction]");
            query.Connection = con;
            decimal sum = Convert.ToDecimal(query.ExecuteScalar());

            regualTotalLabel.Text = Convert.ToString(sum);

            totalVatLabel.Text = "0.00";
            finalTotalLabel.Text = Convert.ToString(sum);
        }

        private void Shopping_List_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShoppingCartDataContext scdc = new ShoppingCartDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project\MainFrame\MainFrame\ShoppinCart.mdf;Integrated Security=True;Connect Timeout=30");
            Transaction t = new Transaction();
            var s = from a in scdc.Transactions
                    select a;

            scdc.Transactions.DeleteAllOnSubmit(s);
            scdc.SubmitChanges();
            Application.Exit();
        }
    }
}

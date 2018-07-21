
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
    public partial class CoustomerHome : Form
    {
        person pp;
       
        public CoustomerHome(person p)
        {
            pp = p;
            InitializeComponent();
            ShoppingCartDataContext scdc = new ShoppingCartDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project\MainFrame\MainFrame\ShoppinCart.mdf;Integrated Security=True;Connect Timeout=30");


            categoryComboBox.DataSource = scdc.Categories;
            categoryComboBox.DisplayMember = "Cat_Name";
            categoryComboBox.ValueMember = "Cat_ID";


            /*productnameComboBox.DataSource= scdc.Products;
            productnameComboBox.DisplayMember = "P_Name";
            productnameComboBox.ValueMember = "P_ID";*/

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CoustomerHome_Load(object sender, EventArgs e)
        {
            ShoppingCartDataContext scdc = new ShoppingCartDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project\MainFrame\MainFrame\ShoppinCart.mdf;Integrated Security=True;Connect Timeout=30");

            var s = from a in scdc.Products
                    from b in scdc.Categories
                    where a.Cat_ID == b.Cat_ID
                    select new
                    {
                        Product_Name = a.P_Name,
                       
                        Product_ID = a.P_ID,
                        Category_Name = b.Cat_Name,

                        Price = a.P_Price,
                        Stock = a.P_Stock,
                        CategoryID = b.Cat_ID,
                       
                    };

            productGridView.DataSource = s.ToList();


            UserLogin u1 = new UserLogin();

            Customer u2 = scdc.Customers.SingleOrDefault(x => x.C_ID == pp.id);

            cFirstnameTextBox.Text = u2.C_Firstname;
            cLastnameTextBox.Text = u2.C_Lastname;
            cUserIDTextBox.Text = Convert.ToString(u2.C_ID);
            cPasswordTextBox.Text = Convert.ToString(u2.C_Password);
            cEmailTextBox.Text = u2.C_Email;
            cPhoneTextBox.Text = u2.C_Phone;
            cAddressTextBox.Text = u2.C_Address;



            fnameLabel.Text = u2.C_Firstname;
            lanameLabel.Text = u2.C_Lastname;
            emailLabel.Text = u2.C_Email;
            phoneLabel.Text = u2.C_Phone;
            addressLabel.Text = u2.C_Address;
            idLabel.Text = Convert.ToString(u2.C_ID);
            passwordLabel.Text = Convert.ToString(u2.C_Password);

            categoryComboBox.Text = string.Empty;

        }

        private void Signout_Click(object sender, EventArgs e)
        {
            UserLogin ul = new UserLogin();
            ul.Show();
            this.Hide();

        }

       /* private void ConfirmList_Click(object sender, EventArgs e)
        {
           
        }*/

        private void showInfoButton_Click(object sender, EventArgs e)
        {

        }

       /* private void ConfirmList_Click_1(object sender, EventArgs e)
        {
            ShoppingCartDataContext scdc = new ShoppingCartDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project\MainFrame\MainFrame\ShoppinCart.mdf;Integrated Security=True;Connect Timeout=30");
            

            //Console.WriteLine(sum);

          
            
        }*/

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            ShoppingCartDataContext scdc = new ShoppingCartDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project\MainFrame\MainFrame\ShoppinCart.mdf;Integrated Security=True;Connect Timeout=30");
            int id = int.Parse(categoryComboBox.SelectedValue.ToString());
            Category cat = scdc.Categories.SingleOrDefault(x => x.Cat_ID == id);

        }

        private void showAll_Click(object sender, EventArgs e)
        {
            ShoppingCartDataContext scdc = new ShoppingCartDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project\MainFrame\MainFrame\ShoppinCart.mdf;Integrated Security=True;Connect Timeout=30");

            String s1 = categoryComboBox.Text;
            if (s1 == "")
            {

                var x = from a in scdc.Products
                        from b in scdc.Categories
                        where a.Cat_ID == b.Cat_ID
                        select new
                        {
                            Product_Name = a.P_Name,
                            Product_ID = a.P_ID,
                            Price = a.P_Price,
                            Stock = a.P_Stock,
                            CategoryID = b.Cat_ID,
                            Category_Name = b.Cat_Name

                        };

                productGridView.DataSource = x.ToList();
            }
            else
            {
                var s = from b in scdc.Products
                        join a in scdc.Categories on b.Cat_ID equals a.Cat_ID
                        where a.Cat_Name == s1
                        select new
                        {
                            Product_Name = b.P_Name,
                            Product_ID = b.P_ID,
                            Price = b.P_Price,
                            Stock = b.P_Stock,
                            CategoryID = b.Cat_ID,
                            Category_Name = a.Cat_Name

                        };
                productGridView.DataSource = s.ToList();
            }
            categoryComboBox.Text = string.Empty;
        }

        /*  private void productnameComboBox_SelectedIndexChanged(object sender, EventArgs e)
          {
         
        
          }
          */
        private void Search_Click(object sender, EventArgs e)
        {
            if (productIDTextBox.Text == "")
            {
                MessageBox.Show("Enter Valid Product ID");
            }
            else
            {
                ShoppingCartDataContext scdc = new ShoppingCartDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project\MainFrame\MainFrame\ShoppinCart.mdf;Integrated Security=True;Connect Timeout=30");

                var x = from a in scdc.Products
                        where a.P_ID == int.Parse(productIDTextBox.Text)
                        select a;
                priceTextBox.Text = Convert.ToString(x.FirstOrDefault().P_Price);
                productNameTextBox.Text = x.FirstOrDefault().P_Name;
            }
        }

        private void aClear_Click(object sender, EventArgs e)
        {
            cFirstnameTextBox.Text = cLastnameTextBox.Text = cPasswordTextBox.Text = cUserIDTextBox.Text = cAddressTextBox.Text = cEmailTextBox.Text = cPhoneTextBox.Text = string.Empty;
        }

        private void aEditButton_Click(object sender, EventArgs e)
        {
            ShoppingCartDataContext scdc = new ShoppingCartDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project\MainFrame\MainFrame\ShoppinCart.mdf;Integrated Security=True;Connect Timeout=30");

            Customer u2 = scdc.Customers.SingleOrDefault(x => x.C_ID == pp.id);

            u2.C_Firstname = cFirstnameTextBox.Text;
            u2.C_Lastname = cLastnameTextBox.Text;
            u2.C_ID = int.Parse(cUserIDTextBox.Text);
            u2.C_Password = int.Parse(cPasswordTextBox.Text);
            u2.C_Email = cEmailTextBox.Text;
            u2.C_Phone = cPhoneTextBox.Text;
            u2.C_Address = cAddressTextBox.Text;


            scdc.SubmitChanges();


            fnameLabel.Text = u2.C_Firstname;
            lanameLabel.Text = u2.C_Lastname;
            emailLabel.Text = u2.C_Email;
            phoneLabel.Text = u2.C_Phone;
            addressLabel.Text = u2.C_Address;
            idLabel.Text = Convert.ToString(u2.C_ID);
            passwordLabel.Text = Convert.ToString(u2.C_Password);


        }
        public void LoadShoppinList()
        {
            ShoppingCartDataContext scdc = new ShoppingCartDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project\MainFrame\MainFrame\ShoppinCart.mdf;Integrated Security=True;Connect Timeout=30");
            
            var s = from a in scdc.Transactions
                    
                    select new
                    {
                        Product_ID = a.P_ID,
                        Product_Name = a.P_Name,

                        Price = a.Price,
                        Amount = a.Quantity,

                        Total = a.Total

                    };

            shoppingListDataGridview.DataSource = s.ToList();
                    
            
        }
        private void InsertToList_Click(object sender, EventArgs e)
        {
            if (productIDTextBox.Text == "" || productNameTextBox.Text == "" || priceTextBox.Text == "" || quantityTextBox.Text == "")
            {
                MessageBox.Show("Please add quantity to product");
            }
            else
            {
                ShoppingCartDataContext scdc = new ShoppingCartDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project\MainFrame\MainFrame\ShoppinCart.mdf;Integrated Security=True;Connect Timeout=30");
                Transaction t = new Transaction();
                t.P_ID = Convert.ToInt32(productIDTextBox.Text);
                t.P_Name = productNameTextBox.Text;
                t.Price = int.Parse(priceTextBox.Text);
                t.Quantity = int.Parse(quantityTextBox.Text);
                t.Total = (int.Parse(quantityTextBox.Text)) * (int.Parse(priceTextBox.Text));

                scdc.Transactions.InsertOnSubmit(t);
                scdc.SubmitChanges();

                LoadShoppinList();

                productIDTextBox.Text = productNameTextBox.Text = priceTextBox.Text = quantityTextBox.Text = string.Empty;
            }
        }

        private void Cart_Click(object sender, EventArgs e)
        {

        }

        private void CoustomerHome_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void productGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void shoppingListDataGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listRefresh_Click(object sender, EventArgs e)
        {
            LoadShoppinList();
        }

        private void DeleteFromList_Click(object sender, EventArgs e)
        {
            if (productIDTextBox.Text == "")
            {
                MessageBox.Show("enter a valid PRODUCT ID");
            }
            else
            {
                ShoppingCartDataContext scdc = new ShoppingCartDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project\MainFrame\MainFrame\ShoppinCart.mdf;Integrated Security=True;Connect Timeout=30");

                Transaction p = scdc.Transactions.SingleOrDefault(x => x.P_ID == int.Parse(productIDTextBox.Text));

                scdc.Transactions.DeleteOnSubmit(p);
                scdc.SubmitChanges();
                LoadShoppinList();
                productNameTextBox.Text = productIDTextBox.Text = priceTextBox.Text = quantityTextBox.Text = string.Empty;
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to Confirm list?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {

                Shopping_List sl = new Shopping_List(pp);
                sl.Show();
                this.Hide();
            }
            else
            {

            }
        }
    }
}


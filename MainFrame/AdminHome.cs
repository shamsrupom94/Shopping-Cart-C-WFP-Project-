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
    public partial class AdminHome : Form
    {
        person pp;

        public AdminHome(person p)
        {
            pp = p;
            InitializeComponent();

            ShoppingCartDataContext scdc = new ShoppingCartDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project\MainFrame\MainFrame\ShoppinCart.mdf;Integrated Security=True;Connect Timeout=30");

            categoryComboBox.DataSource = scdc.Categories;
            categoryComboBox.DisplayMember = "Cat_ID";
            categoryComboBox.ValueMember = "Cat_ID";
            
        }

     

        private void Signout_Click(object sender, EventArgs e)
        {
            AdminLogin al = new AdminLogin();
            al.Show();
            this.Hide();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            ShoppingCartDataContext scdc = new ShoppingCartDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project\MainFrame\MainFrame\ShoppinCart.mdf;Integrated Security=True;Connect Timeout=30");
            
            //To show CUSTOMER LIST on gridview
            userlistDataGridView.DataSource = scdc.Customers;
            //To show CATEGORY LIST on gridView
            categoryDataGridView.DataSource = scdc.Categories;

            categorydataGridView2.DataSource = scdc.Categories;
            //Loadin ADMIN INFORMATION tab
            AdminLogin al = new AdminLogin();
            
            Admin a2 = scdc.Admins.SingleOrDefault(x => x.A_ID == pp.id);

            // on textbox
            aFirstnameTextBox.Text = a2.A_Firstname;
            aLastnameTextBox.Text = a2.A_Lastname;
            aUserIDTextBox.Text = Convert.ToString(a2.A_ID);
            aPasswordTextBox.Text = Convert.ToString(a2.A_Password);
            aEmailTextBox.Text = a2.A_Email;
            aPhoneTextBox.Text = a2.A_Phone;
            aAddressTextBox.Text =a2.A_Address;
            
            //on table panel

            fnameLabel.Text = a2.A_Firstname;
            lnamelabel.Text = a2.A_Lastname;
            emaillabel.Text = a2.A_Email;
            phonelabel.Text = a2.A_Phone;
            addresslabel.Text = a2.A_Address;
            idlabel.Text = Convert.ToString(a2.A_ID);
            passwordlabel.Text = Convert.ToString(a2.A_Password);


            //For Loading complete PRODUCT LIST on Product management tab

            var s = from a in scdc.Products
                    from b in scdc.Categories
                    where a.Cat_ID == b.Cat_ID
                    select new
                    {
                        Product_Name = a.P_Name,
                        Product_ID = a.P_ID,
                        Price = a.P_Price,
                        Stock = a.P_Stock,
                        CategoryID =b.Cat_ID,
                        Category_Name=b.Cat_Name

                    };
                    
                    productDatagridView.DataSource = s.ToList();

                    categoryComboBox.Text = string.Empty;

            
        }
        void categorylistGridViewUpdate()
        {
            
            ShoppingCartDataContext scdc = new ShoppingCartDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project\MainFrame\MainFrame\ShoppinCart.mdf;Integrated Security=True;Connect Timeout=30");
            categoryDataGridView.DataSource = scdc.Categories;
        }
        void UserlistGridViewUpdate()
        {
            ShoppingCartDataContext scdc = new ShoppingCartDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project\MainFrame\MainFrame\ShoppinCart.mdf;Integrated Security=True;Connect Timeout=30");
            userlistDataGridView.DataSource = scdc.Customers;
        }
        void productListGridViewUpdate()
        {
            ShoppingCartDataContext scdc = new ShoppingCartDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project\MainFrame\MainFrame\ShoppinCart.mdf;Integrated Security=True;Connect Timeout=30");
           
            var s = from a in scdc.Products
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

            productDatagridView.DataSource = s.ToList();

        }
        private void uAddButton_Click(object sender, EventArgs e)
        {
            if (uFirstnameTextBox.Text == "" || uLastNameTextBox.Text == "" || uEmailTextBox.Text == "" || uPhoneTextBox.Text == "" || uPasswordTextBox.Text == "" || uAddressTextBox.Text == "")
            {
                MessageBox.Show("please fill up all info except User ID");

            }
            else
            {
                ShoppingCartDataContext scdc = new ShoppingCartDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project\MainFrame\MainFrame\ShoppinCart.mdf;Integrated Security=True;Connect Timeout=30");

                Customer c = new Customer()
                {
                    C_Firstname = uFirstnameTextBox.Text,
                    C_Lastname = uLastNameTextBox.Text,
                    //C_ID =Convert.ToInt32(uUserIDTextBox.Text),
                    C_Password = Convert.ToInt32(uPasswordTextBox.Text),
                    C_Email = uEmailTextBox.Text,
                    C_Phone = uPhoneTextBox.Text,
                    C_Address = aAddressTextBox.Text
                };
                scdc.Customers.InsertOnSubmit(c);
                scdc.SubmitChanges();
                UserlistGridViewUpdate();
                uFirstnameTextBox.Text = uLastNameTextBox.Text = uPasswordTextBox.Text = uEmailTextBox.Text = uPhoneTextBox.Text = uAddressTextBox.Text = string.Empty;

            }
        }

        private void uSearchButton_Click(object sender, EventArgs e)
        {
            ShoppingCartDataContext scdc = new ShoppingCartDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project\MainFrame\MainFrame\ShoppinCart.mdf;Integrated Security=True;Connect Timeout=30");

            var x = from a in scdc.Customers
                    where a.C_ID == int.Parse(uUserIDTextBox.Text)
                    select a;
            uFirstnameTextBox.Text = x.FirstOrDefault().C_Firstname;
            uLastNameTextBox.Text = x.FirstOrDefault().C_Lastname;
           // uUserIDTextBox.Text = Convert.ToString(x.FirstOrDefault().C_ID);
            uPasswordTextBox.Text = Convert.ToString(x.FirstOrDefault().C_Password);
            uEmailTextBox.Text = x.FirstOrDefault().C_Email;
            uPhoneTextBox.Text = x.FirstOrDefault().C_Phone;
            uAddressTextBox.Text = x.FirstOrDefault().C_Address;

            userlistDataGridView.DataSource = x.ToList();

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {

            uFirstnameTextBox.Text = uLastNameTextBox.Text = uPasswordTextBox.Text = uEmailTextBox.Text = uPhoneTextBox.Text = uAddressTextBox.Text =uUserIDTextBox.Text= string.Empty;
            UserlistGridViewUpdate();     
        }

        private void uUpdateButton_Click(object sender, EventArgs e)
        {
            if (uFirstnameTextBox.Text == "" ||uUserIDTextBox.Text=="" || uLastNameTextBox.Text == "" || uEmailTextBox.Text == "" || uPhoneTextBox.Text == "" || uPasswordTextBox.Text == "" || uAddressTextBox.Text == "")
            {
                MessageBox.Show("please fill up all info");

            }
            else
            {
                ShoppingCartDataContext scdc = new ShoppingCartDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project\MainFrame\MainFrame\ShoppinCart.mdf;Integrated Security=True;Connect Timeout=30");

                Customer c = scdc.Customers.SingleOrDefault(x => x.C_ID == int.Parse(uUserIDTextBox.Text));

                c.C_Firstname = uFirstnameTextBox.Text;
                c.C_Lastname = uLastNameTextBox.Text;
                c.C_Email = uEmailTextBox.Text;
                c.C_Password = Convert.ToInt32(uPasswordTextBox.Text);
                c.C_Phone = uPhoneTextBox.Text;
                c.C_Address = uAddressTextBox.Text;

                scdc.SubmitChanges();
                UserlistGridViewUpdate();

                uUserIDTextBox.Text = string.Empty;

            }

        }

        private void uRemoveButton_Click(object sender, EventArgs e)
        {
            if (uUserIDTextBox.Text == "" )
            {
                MessageBox.Show("please enter User ID");

            }
            else
            {
                ShoppingCartDataContext scdc = new ShoppingCartDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project\MainFrame\MainFrame\ShoppinCart.mdf;Integrated Security=True;Connect Timeout=30");

                Customer c = scdc.Customers.SingleOrDefault(x => x.C_ID == int.Parse(uUserIDTextBox.Text));

                scdc.Customers.DeleteOnSubmit(c);
                scdc.SubmitChanges();
                UserlistGridViewUpdate();
                uUserIDTextBox.Text = string.Empty;
            }
       }
        
        private void insertCatButton_Click(object sender, EventArgs e)
        {
            if (catNameTextBox.Text == ""  || catDesTextBox.Text == "")
            {
                MessageBox.Show("Fill up all the textbox except Category ID");
            }
            else {

                ShoppingCartDataContext scdc = new ShoppingCartDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project\MainFrame\MainFrame\ShoppinCart.mdf;Integrated Security=True;Connect Timeout=30");
                Category cat = new Category
                {
                    //Cat_ID = Convert.ToInt32(catIDTextBox.Text),
                    Cat_Name = catNameTextBox.Text,
                    Cat_Des = catDesTextBox.Text

                };
                scdc.Categories.InsertOnSubmit(cat);
                scdc.SubmitChanges();
                categorylistGridViewUpdate();
                catIDTextBox.Text = catNameTextBox.Text = catDesTextBox.Text = string.Empty;
            }
          

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            catIDTextBox.Text = catNameTextBox.Text = catDesTextBox.Text = string.Empty;
            categorylistGridViewUpdate();
        }

        private void deleteCatButton_Click(object sender, EventArgs e)
        {
            if (catDesTextBox.Text == "")
            {
                MessageBox.Show("Please enter valid CATEGORY ID");
            }
            else
            {
                ShoppingCartDataContext scdc = new ShoppingCartDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project\MainFrame\MainFrame\ShoppinCart.mdf;Integrated Security=True;Connect Timeout=30");

                Category cat = scdc.Categories.SingleOrDefault(x => x.Cat_ID == int.Parse(catIDTextBox.Text));

                scdc.Categories.DeleteOnSubmit(cat);

                scdc.SubmitChanges();
                categorylistGridViewUpdate();
                catIDTextBox.Text = string.Empty;
            }
        }

        private void updateCatButton_Click(object sender, EventArgs e)
        {
            if (catDesTextBox.Text == "" || catNameTextBox.Text == "" || catDesTextBox.Text == "")
            {
                MessageBox.Show("please fill up all the informations");
            }
            else
            {
                ShoppingCartDataContext scdc = new ShoppingCartDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project\MainFrame\MainFrame\ShoppinCart.mdf;Integrated Security=True;Connect Timeout=30");

                Category cat = scdc.Categories.SingleOrDefault(x => x.Cat_ID == int.Parse(catIDTextBox.Text));

                cat.Cat_Name = catNameTextBox.Text;
                cat.Cat_Des = catDesTextBox.Text;

                scdc.SubmitChanges();

                catNameTextBox.Text = catIDTextBox.Text = catDesTextBox.Text = string.Empty;
                categorylistGridViewUpdate();
            }
        }

        private void aClear_Click(object sender, EventArgs e)
        {
            aFirstnameTextBox.Text = aLastnameTextBox.Text = aUserIDTextBox.Text = aPasswordTextBox.Text = aEmailTextBox.Text = aPhoneTextBox.Text = aAddressTextBox.Text = string.Empty;
        }

        private void aEditButton_Click(object sender, EventArgs e)
        {
            
            ShoppingCartDataContext scdc = new ShoppingCartDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project\MainFrame\MainFrame\ShoppinCart.mdf;Integrated Security=True;Connect Timeout=30");

            Admin c = scdc.Admins.SingleOrDefault(x => x.A_ID == int.Parse(aUserIDTextBox.Text));

            c.A_Firstname = aFirstnameTextBox.Text;
            c.A_Lastname = aLastnameTextBox.Text;
            c.A_Email = aEmailTextBox.Text;
            c.A_Password = Convert.ToInt32(aPasswordTextBox.Text);
            c.A_Phone = aPhoneTextBox.Text;
            c.A_Address = aAddressTextBox.Text;

            scdc.SubmitChanges();


            fnameLabel.Text = c.A_Firstname;
            lnamelabel.Text = c.A_Lastname;
            emaillabel.Text = c.A_Email;
            phonelabel.Text = c.A_Phone;
            addresslabel.Text = c.A_Address;
            idlabel.Text = Convert.ToString(c.A_ID);
            passwordlabel.Text = Convert.ToString(c.A_Password);


        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (productidTextBox.Text == "")
            { MessageBox.Show("please insert a valid PRODUCT ID"); }
            else
            {

                ShoppingCartDataContext scdc = new ShoppingCartDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project\MainFrame\MainFrame\ShoppinCart.mdf;Integrated Security=True;Connect Timeout=30");

                var x = from a in scdc.Products
                        join b in scdc.Categories
                        on a.Cat_ID equals b.Cat_ID
                        where a.P_ID == int.Parse(productidTextBox.Text)
                        select new { a.P_Name, a.P_Price, a.P_Stock, a.P_Des, a.Cat_ID, b.Cat_Name };
                productNameTextBox.Text = x.FirstOrDefault().P_Name;
                productPriceTextBox.Text = Convert.ToString(x.FirstOrDefault().P_Price);
                stockTextBox.Text = Convert.ToString(x.FirstOrDefault().P_Stock);
                productdesTextbox.Text = x.FirstOrDefault().P_Des;
                //categoryComboBox.Text= (Convert.ToString(x.FirstOrDefault().Cat_Name)); 
                categoryComboBox.Text = Convert.ToString(x.FirstOrDefault().Cat_ID);

                productDatagridView.DataSource = x.ToList();
            
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {

            if (productNameTextBox.Text == "" || productdesTextbox.Text == "" || productPriceTextBox.Text == "" || stockTextBox.Text == "" || categoryComboBox.Text == "")
            {
                MessageBox.Show("please fill up all information except PRODUCT ID");
            }
            else
            {

                ShoppingCartDataContext scdc = new ShoppingCartDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project\MainFrame\MainFrame\ShoppinCart.mdf;Integrated Security=True;Connect Timeout=30");


                Product p = new Product();
                Category cat = new Category();
                p.P_Name = productNameTextBox.Text;
                p.P_Price = Convert.ToDouble(productPriceTextBox.Text);
                p.P_Stock = Convert.ToInt32(stockTextBox.Text);
                p.P_Des = productdesTextbox.Text;
                p.Cat_ID = int.Parse(categoryComboBox.Text);
                /*if (categoryComboBox.Text == cat.Cat_Name)
                    {
                        p.Cat_ID = cat.Cat_ID;
                    }*/


                scdc.Products.InsertOnSubmit(p);
                scdc.SubmitChanges();
                productListGridViewUpdate();

                productNameTextBox.Text = productidTextBox.Text = productPriceTextBox.Text = productdesTextbox.Text = stockTextBox.Text = categoryComboBox.Text = string.Empty;
                MessageBox.Show("PRODUCT ADDED SUCCESSFULLY");
            }
            

        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            if (productidTextBox.Text == "")
            { MessageBox.Show("Please Insert Valid PRODUCT ID"); }
            else
            {
                ShoppingCartDataContext scdc = new ShoppingCartDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project\MainFrame\MainFrame\ShoppinCart.mdf;Integrated Security=True;Connect Timeout=30");

                Product p = scdc.Products.SingleOrDefault(x => x.P_ID == int.Parse(productidTextBox.Text));

                scdc.Products.DeleteOnSubmit(p);
                scdc.SubmitChanges();
                productListGridViewUpdate();
                productidTextBox.Text = string.Empty;
                MessageBox.Show("PRODUCT HAS BEEN DELETED");
            }
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (productNameTextBox.Text == "" || productdesTextbox.Text == "" || productPriceTextBox.Text == "" || stockTextBox.Text == "" || categoryComboBox.Text == "" || productidTextBox.Text == "")
            {
                MessageBox.Show("please fill up all information Correctly");
            }
            else
            {
                ShoppingCartDataContext scdc = new ShoppingCartDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project\MainFrame\MainFrame\ShoppinCart.mdf;Integrated Security=True;Connect Timeout=30");

                Product p = scdc.Products.SingleOrDefault(x => x.P_ID == int.Parse(productidTextBox.Text));

                p.P_Name = productNameTextBox.Text;
                p.P_Price = Convert.ToDouble(productPriceTextBox.Text);
                p.P_Stock = int.Parse(stockTextBox.Text);
                p.P_Des = productdesTextbox.Text;
                p.Cat_ID = int.Parse(categoryComboBox.Text);

                scdc.SubmitChanges();
                productListGridViewUpdate();
                productNameTextBox.Text = productidTextBox.Text = productPriceTextBox.Text = productdesTextbox.Text = stockTextBox.Text = categoryComboBox.Text = string.Empty;
                MessageBox.Show("PRODUCT UPDATED SUCCESSFULLY");
            }
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShoppingCartDataContext scdc = new ShoppingCartDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project\MainFrame\MainFrame\ShoppinCart.mdf;Integrated Security=True;Connect Timeout=30");
            int id = int.Parse(categoryComboBox.SelectedValue.ToString());
            Category cat = scdc.Categories.SingleOrDefault(x => x.Cat_ID == id);
        }

        private void AdminHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void ProductHome_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            productNameTextBox.Text = productidTextBox.Text = productPriceTextBox.Text = productdesTextbox.Text = stockTextBox.Text = categoryComboBox.Text = string.Empty;

            ShoppingCartDataContext scdc = new ShoppingCartDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project\MainFrame\MainFrame\ShoppinCart.mdf;Integrated Security=True;Connect Timeout=30");

            categorydataGridView2.DataSource = scdc.Categories;
            
            productListGridViewUpdate();
          
        }

        private void AdminInfo_Click(object sender, EventArgs e)
        {

        }
    }
}

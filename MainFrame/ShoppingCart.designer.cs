﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MainFrame
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ShoppinCart")]
	public partial class ShoppingCartDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    partial void InsertAdmin(Admin instance);
    partial void UpdateAdmin(Admin instance);
    partial void DeleteAdmin(Admin instance);
    partial void InsertCategory(Category instance);
    partial void UpdateCategory(Category instance);
    partial void DeleteCategory(Category instance);
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    partial void InsertTransaction(Transaction instance);
    partial void UpdateTransaction(Transaction instance);
    partial void DeleteTransaction(Transaction instance);
    #endregion
		
		public ShoppingCartDataContext() : 
				base(global::MainFrame.Properties.Settings.Default.ShoppinCartConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ShoppingCartDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ShoppingCartDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ShoppingCartDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ShoppingCartDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
		
		public System.Data.Linq.Table<Admin> Admins
		{
			get
			{
				return this.GetTable<Admin>();
			}
		}
		
		public System.Data.Linq.Table<Category> Categories
		{
			get
			{
				return this.GetTable<Category>();
			}
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
		
		public System.Data.Linq.Table<Transaction> Transactions
		{
			get
			{
				return this.GetTable<Transaction>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _C_ID;
		
		private int _C_Password;
		
		private string _C_Firstname;
		
		private string _C_Lastname;
		
		private string _C_Email;
		
		private string _C_Phone;
		
		private string _C_Address;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnC_IDChanging(int value);
    partial void OnC_IDChanged();
    partial void OnC_PasswordChanging(int value);
    partial void OnC_PasswordChanged();
    partial void OnC_FirstnameChanging(string value);
    partial void OnC_FirstnameChanged();
    partial void OnC_LastnameChanging(string value);
    partial void OnC_LastnameChanged();
    partial void OnC_EmailChanging(string value);
    partial void OnC_EmailChanged();
    partial void OnC_PhoneChanging(string value);
    partial void OnC_PhoneChanged();
    partial void OnC_AddressChanging(string value);
    partial void OnC_AddressChanged();
    #endregion
		
		public Customer()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_C_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int C_ID
		{
			get
			{
				return this._C_ID;
			}
			set
			{
				if ((this._C_ID != value))
				{
					this.OnC_IDChanging(value);
					this.SendPropertyChanging();
					this._C_ID = value;
					this.SendPropertyChanged("C_ID");
					this.OnC_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_C_Password", DbType="Int NOT NULL")]
		public int C_Password
		{
			get
			{
				return this._C_Password;
			}
			set
			{
				if ((this._C_Password != value))
				{
					this.OnC_PasswordChanging(value);
					this.SendPropertyChanging();
					this._C_Password = value;
					this.SendPropertyChanged("C_Password");
					this.OnC_PasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_C_Firstname", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string C_Firstname
		{
			get
			{
				return this._C_Firstname;
			}
			set
			{
				if ((this._C_Firstname != value))
				{
					this.OnC_FirstnameChanging(value);
					this.SendPropertyChanging();
					this._C_Firstname = value;
					this.SendPropertyChanged("C_Firstname");
					this.OnC_FirstnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_C_Lastname", DbType="VarChar(50)")]
		public string C_Lastname
		{
			get
			{
				return this._C_Lastname;
			}
			set
			{
				if ((this._C_Lastname != value))
				{
					this.OnC_LastnameChanging(value);
					this.SendPropertyChanging();
					this._C_Lastname = value;
					this.SendPropertyChanged("C_Lastname");
					this.OnC_LastnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_C_Email", DbType="VarChar(50)")]
		public string C_Email
		{
			get
			{
				return this._C_Email;
			}
			set
			{
				if ((this._C_Email != value))
				{
					this.OnC_EmailChanging(value);
					this.SendPropertyChanging();
					this._C_Email = value;
					this.SendPropertyChanged("C_Email");
					this.OnC_EmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_C_Phone", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string C_Phone
		{
			get
			{
				return this._C_Phone;
			}
			set
			{
				if ((this._C_Phone != value))
				{
					this.OnC_PhoneChanging(value);
					this.SendPropertyChanging();
					this._C_Phone = value;
					this.SendPropertyChanged("C_Phone");
					this.OnC_PhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_C_Address", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string C_Address
		{
			get
			{
				return this._C_Address;
			}
			set
			{
				if ((this._C_Address != value))
				{
					this.OnC_AddressChanging(value);
					this.SendPropertyChanging();
					this._C_Address = value;
					this.SendPropertyChanged("C_Address");
					this.OnC_AddressChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Admin")]
	public partial class Admin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _A_ID;
		
		private int _A_Password;
		
		private string _A_Firstname;
		
		private string _A_Lastname;
		
		private string _A_Email;
		
		private string _A_Phone;
		
		private string _A_Address;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnA_IDChanging(int value);
    partial void OnA_IDChanged();
    partial void OnA_PasswordChanging(int value);
    partial void OnA_PasswordChanged();
    partial void OnA_FirstnameChanging(string value);
    partial void OnA_FirstnameChanged();
    partial void OnA_LastnameChanging(string value);
    partial void OnA_LastnameChanged();
    partial void OnA_EmailChanging(string value);
    partial void OnA_EmailChanged();
    partial void OnA_PhoneChanging(string value);
    partial void OnA_PhoneChanged();
    partial void OnA_AddressChanging(string value);
    partial void OnA_AddressChanged();
    #endregion
		
		public Admin()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_A_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int A_ID
		{
			get
			{
				return this._A_ID;
			}
			set
			{
				if ((this._A_ID != value))
				{
					this.OnA_IDChanging(value);
					this.SendPropertyChanging();
					this._A_ID = value;
					this.SendPropertyChanged("A_ID");
					this.OnA_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_A_Password", DbType="Int NOT NULL")]
		public int A_Password
		{
			get
			{
				return this._A_Password;
			}
			set
			{
				if ((this._A_Password != value))
				{
					this.OnA_PasswordChanging(value);
					this.SendPropertyChanging();
					this._A_Password = value;
					this.SendPropertyChanged("A_Password");
					this.OnA_PasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_A_Firstname", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string A_Firstname
		{
			get
			{
				return this._A_Firstname;
			}
			set
			{
				if ((this._A_Firstname != value))
				{
					this.OnA_FirstnameChanging(value);
					this.SendPropertyChanging();
					this._A_Firstname = value;
					this.SendPropertyChanged("A_Firstname");
					this.OnA_FirstnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_A_Lastname", DbType="VarChar(50)")]
		public string A_Lastname
		{
			get
			{
				return this._A_Lastname;
			}
			set
			{
				if ((this._A_Lastname != value))
				{
					this.OnA_LastnameChanging(value);
					this.SendPropertyChanging();
					this._A_Lastname = value;
					this.SendPropertyChanged("A_Lastname");
					this.OnA_LastnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_A_Email", DbType="VarChar(50)")]
		public string A_Email
		{
			get
			{
				return this._A_Email;
			}
			set
			{
				if ((this._A_Email != value))
				{
					this.OnA_EmailChanging(value);
					this.SendPropertyChanging();
					this._A_Email = value;
					this.SendPropertyChanged("A_Email");
					this.OnA_EmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_A_Phone", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string A_Phone
		{
			get
			{
				return this._A_Phone;
			}
			set
			{
				if ((this._A_Phone != value))
				{
					this.OnA_PhoneChanging(value);
					this.SendPropertyChanging();
					this._A_Phone = value;
					this.SendPropertyChanged("A_Phone");
					this.OnA_PhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_A_Address", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string A_Address
		{
			get
			{
				return this._A_Address;
			}
			set
			{
				if ((this._A_Address != value))
				{
					this.OnA_AddressChanging(value);
					this.SendPropertyChanging();
					this._A_Address = value;
					this.SendPropertyChanged("A_Address");
					this.OnA_AddressChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Category")]
	public partial class Category : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Cat_ID;
		
		private string _Cat_Name;
		
		private string _Cat_Des;
		
		private EntitySet<Product> _Products;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCat_IDChanging(int value);
    partial void OnCat_IDChanged();
    partial void OnCat_NameChanging(string value);
    partial void OnCat_NameChanged();
    partial void OnCat_DesChanging(string value);
    partial void OnCat_DesChanged();
    #endregion
		
		public Category()
		{
			this._Products = new EntitySet<Product>(new Action<Product>(this.attach_Products), new Action<Product>(this.detach_Products));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cat_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Cat_ID
		{
			get
			{
				return this._Cat_ID;
			}
			set
			{
				if ((this._Cat_ID != value))
				{
					this.OnCat_IDChanging(value);
					this.SendPropertyChanging();
					this._Cat_ID = value;
					this.SendPropertyChanged("Cat_ID");
					this.OnCat_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cat_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Cat_Name
		{
			get
			{
				return this._Cat_Name;
			}
			set
			{
				if ((this._Cat_Name != value))
				{
					this.OnCat_NameChanging(value);
					this.SendPropertyChanging();
					this._Cat_Name = value;
					this.SendPropertyChanged("Cat_Name");
					this.OnCat_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cat_Des", DbType="VarChar(100)")]
		public string Cat_Des
		{
			get
			{
				return this._Cat_Des;
			}
			set
			{
				if ((this._Cat_Des != value))
				{
					this.OnCat_DesChanging(value);
					this.SendPropertyChanging();
					this._Cat_Des = value;
					this.SendPropertyChanged("Cat_Des");
					this.OnCat_DesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_Product", Storage="_Products", ThisKey="Cat_ID", OtherKey="Cat_ID")]
		public EntitySet<Product> Products
		{
			get
			{
				return this._Products;
			}
			set
			{
				this._Products.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Products(Product entity)
		{
			this.SendPropertyChanging();
			entity.Category = this;
		}
		
		private void detach_Products(Product entity)
		{
			this.SendPropertyChanging();
			entity.Category = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Product")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _P_ID;
		
		private string _P_Name;
		
		private double _P_Price;
		
		private int _P_Stock;
		
		private int _Cat_ID;
		
		private string _P_Des;
		
		private EntityRef<Category> _Category;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnP_IDChanging(int value);
    partial void OnP_IDChanged();
    partial void OnP_NameChanging(string value);
    partial void OnP_NameChanged();
    partial void OnP_PriceChanging(double value);
    partial void OnP_PriceChanged();
    partial void OnP_StockChanging(int value);
    partial void OnP_StockChanged();
    partial void OnCat_IDChanging(int value);
    partial void OnCat_IDChanged();
    partial void OnP_DesChanging(string value);
    partial void OnP_DesChanged();
    #endregion
		
		public Product()
		{
			this._Category = default(EntityRef<Category>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_P_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int P_ID
		{
			get
			{
				return this._P_ID;
			}
			set
			{
				if ((this._P_ID != value))
				{
					this.OnP_IDChanging(value);
					this.SendPropertyChanging();
					this._P_ID = value;
					this.SendPropertyChanged("P_ID");
					this.OnP_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_P_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string P_Name
		{
			get
			{
				return this._P_Name;
			}
			set
			{
				if ((this._P_Name != value))
				{
					this.OnP_NameChanging(value);
					this.SendPropertyChanging();
					this._P_Name = value;
					this.SendPropertyChanged("P_Name");
					this.OnP_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_P_Price", DbType="Float NOT NULL")]
		public double P_Price
		{
			get
			{
				return this._P_Price;
			}
			set
			{
				if ((this._P_Price != value))
				{
					this.OnP_PriceChanging(value);
					this.SendPropertyChanging();
					this._P_Price = value;
					this.SendPropertyChanged("P_Price");
					this.OnP_PriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_P_Stock", DbType="Int NOT NULL")]
		public int P_Stock
		{
			get
			{
				return this._P_Stock;
			}
			set
			{
				if ((this._P_Stock != value))
				{
					this.OnP_StockChanging(value);
					this.SendPropertyChanging();
					this._P_Stock = value;
					this.SendPropertyChanged("P_Stock");
					this.OnP_StockChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cat_ID", DbType="Int NOT NULL")]
		public int Cat_ID
		{
			get
			{
				return this._Cat_ID;
			}
			set
			{
				if ((this._Cat_ID != value))
				{
					if (this._Category.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCat_IDChanging(value);
					this.SendPropertyChanging();
					this._Cat_ID = value;
					this.SendPropertyChanged("Cat_ID");
					this.OnCat_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_P_Des", DbType="VarChar(100)")]
		public string P_Des
		{
			get
			{
				return this._P_Des;
			}
			set
			{
				if ((this._P_Des != value))
				{
					this.OnP_DesChanging(value);
					this.SendPropertyChanging();
					this._P_Des = value;
					this.SendPropertyChanged("P_Des");
					this.OnP_DesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_Product", Storage="_Category", ThisKey="Cat_ID", OtherKey="Cat_ID", IsForeignKey=true)]
		public Category Category
		{
			get
			{
				return this._Category.Entity;
			}
			set
			{
				Category previousValue = this._Category.Entity;
				if (((previousValue != value) 
							|| (this._Category.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Category.Entity = null;
						previousValue.Products.Remove(this);
					}
					this._Category.Entity = value;
					if ((value != null))
					{
						value.Products.Add(this);
						this._Cat_ID = value.Cat_ID;
					}
					else
					{
						this._Cat_ID = default(int);
					}
					this.SendPropertyChanged("Category");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Transaction]")]
	public partial class Transaction : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _P_ID;
		
		private string _P_Name;
		
		private System.Nullable<int> _Cat_ID;
		
		private string _Cat_Name;
		
		private System.Nullable<double> _Price;
		
		private System.Nullable<int> _Quantity;
		
		private System.Nullable<double> _Total;
		
		private int _T_ID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnP_IDChanging(int value);
    partial void OnP_IDChanged();
    partial void OnP_NameChanging(string value);
    partial void OnP_NameChanged();
    partial void OnCat_IDChanging(System.Nullable<int> value);
    partial void OnCat_IDChanged();
    partial void OnCat_NameChanging(string value);
    partial void OnCat_NameChanged();
    partial void OnPriceChanging(System.Nullable<double> value);
    partial void OnPriceChanged();
    partial void OnQuantityChanging(System.Nullable<int> value);
    partial void OnQuantityChanged();
    partial void OnTotalChanging(System.Nullable<double> value);
    partial void OnTotalChanged();
    partial void OnT_IDChanging(int value);
    partial void OnT_IDChanged();
    #endregion
		
		public Transaction()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_P_ID", DbType="Int NOT NULL")]
		public int P_ID
		{
			get
			{
				return this._P_ID;
			}
			set
			{
				if ((this._P_ID != value))
				{
					this.OnP_IDChanging(value);
					this.SendPropertyChanging();
					this._P_ID = value;
					this.SendPropertyChanged("P_ID");
					this.OnP_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_P_Name", DbType="VarChar(50)")]
		public string P_Name
		{
			get
			{
				return this._P_Name;
			}
			set
			{
				if ((this._P_Name != value))
				{
					this.OnP_NameChanging(value);
					this.SendPropertyChanging();
					this._P_Name = value;
					this.SendPropertyChanged("P_Name");
					this.OnP_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cat_ID", DbType="Int")]
		public System.Nullable<int> Cat_ID
		{
			get
			{
				return this._Cat_ID;
			}
			set
			{
				if ((this._Cat_ID != value))
				{
					this.OnCat_IDChanging(value);
					this.SendPropertyChanging();
					this._Cat_ID = value;
					this.SendPropertyChanged("Cat_ID");
					this.OnCat_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cat_Name", DbType="VarChar(50)")]
		public string Cat_Name
		{
			get
			{
				return this._Cat_Name;
			}
			set
			{
				if ((this._Cat_Name != value))
				{
					this.OnCat_NameChanging(value);
					this.SendPropertyChanging();
					this._Cat_Name = value;
					this.SendPropertyChanged("Cat_Name");
					this.OnCat_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Float")]
		public System.Nullable<double> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int")]
		public System.Nullable<int> Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total", DbType="Float")]
		public System.Nullable<double> Total
		{
			get
			{
				return this._Total;
			}
			set
			{
				if ((this._Total != value))
				{
					this.OnTotalChanging(value);
					this.SendPropertyChanging();
					this._Total = value;
					this.SendPropertyChanged("Total");
					this.OnTotalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_T_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int T_ID
		{
			get
			{
				return this._T_ID;
			}
			set
			{
				if ((this._T_ID != value))
				{
					this.OnT_IDChanging(value);
					this.SendPropertyChanging();
					this._T_ID = value;
					this.SendPropertyChanged("T_ID");
					this.OnT_IDChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591

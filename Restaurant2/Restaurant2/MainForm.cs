using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Restaurant2
{
    public partial class MainForm : Form
    {
        private Form _Form;
        public MainForm(Form form) : this()
        {
            _Form = form;
        }
        private ArrayList products = new ArrayList();
        private ProductCategory productCategory = new ProductCategory();
        private ArrayList categories = new ArrayList();

        public MainForm()
        {
            InitializeComponent();
            products.AddRange(new Product[]
            {
                new Product()
                {
                    Name="Dolma",
                    Price=7,
                    productCategory=ProductCategory.MainFood,
                    productID=1
                },

                 new Product()
                {
                    Name="Merci",
                    Price=3,
                    productCategory=ProductCategory.Soup,
                    productID=2
                },
                  new Product()
                {
                    Name="Pepsi",
                    Price=2,
                    productCategory=ProductCategory.Drinks,
                    productID=3
                },
                   new Product()
                {
                    Name="Akdeniz",
                    Price=2,
                    productCategory=ProductCategory.Salad,
                    productID=4
                },
                    new Product()
                {
                    Name="Kabab",
                    Price=7,
                    productCategory=ProductCategory.MainFood,
                    productID=5
                },
                     new Product()
                {
                    Name="Ayran",
                    Price=2,
                    productCategory=ProductCategory.Drinks,
                    productID=6
                },
                      new Product()
                {
                    Name="Tort",
                    Price=10,
                    productCategory=ProductCategory.Desserts,
                    productID=7
                },
            });
            loadCategory();

        }


        public void loadCategory()
        {
            cmbx_category.DataSource = Enum.GetValues(typeof(ProductCategory));
            //cmbx_category.DataSource = products;
            //cmbx_category.DisplayMember= "ProductCategory";
            
        }
        Basket basket = new Basket();
        private decimal totalPrice = 0;
        private void btn_order_Click(object sender, EventArgs e)
        {
            ProductItem productItem = new ProductItem();
            productItem.Name = cmbx_name.SelectedItem.ToString();
            productItem.Count = Convert.ToByte(txtbx_count.Text);
            productItem.TotalPrice = (Convert.ToDecimal(txtbx_price.Text)) * productItem.Count;
            foreach (Product item in products)
            {
                if (item.Name == productItem.Name)
                {
                    productItem.ID = item.productID;
                }
            }
            basket.productItems.Add(productItem);
           
            dataGrid.DataSource = null;
            dataGrid.DataSource = basket.productItems;
            totalPrice += productItem.TotalPrice;
            lbl_price.Text = totalPrice.ToString();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Form.Close();
        }

        private void cmbx_category_SelectedValueChanged(object sender, EventArgs e)
        {
            ProductCategory selectedCategory = (ProductCategory)(cmbx_category).SelectedItem;
            cmbx_name.Items.Clear();
            foreach (Product item in products)
            {
                if (selectedCategory == item.productCategory)
                {
                    cmbx_name.Items.Add(item.Name);
                }

            }
        }

        private void cmbx_name_SelectedValueChanged(object sender, EventArgs e)
        {
       
            foreach (Product item in products)
            {
                if (item.Name == cmbx_name.SelectedItem.ToString())
                {
                    txtbx_price.Text = item.Price.ToString();
                }
            }
           
        }

    }
}

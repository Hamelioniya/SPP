using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class ShopForm : Form
    {
        Stock stockProducts;
        Stock stockDiscounts;
        Tape tape;

        public ShopForm()
        {
            InitializeComponent();

            stockProducts = new Stock("products.xml");
            stockDiscounts = new Stock("discounts.xml");
            tape = new Tape();
        }

        private void складToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productNameLabel.Visible = true;
            productNameTextBox.Visible = true;
            productManufacturerLabel.Visible = true;
            productManufacturerTextBox.Visible = true;
            productIdLabel.Visible = true;
            productIdTextBox.Visible = true;
            productPriceLabel.Visible = true;
            productPriceTextBox.Visible = true;
            itemsListBox.Visible = true;
            addProductButton.Visible = true;
            deleteProductButton.Visible = true;
            scanProductButton.Visible = false;
            getCheckButton.Visible = false;
            scanProductsTextBox.Visible = false;
            totalPriceTextBox.Visible = false;
            totalPriceLabel.Visible = false;
            productsCountLabel.Visible = false;
            productsCountTextBox.Visible = false;
            addDiscountButton.Visible = false;
            deleteDiscountButton.Visible = false;

            InitializeProductsListBox();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product(productNameTextBox.Text, productManufacturerTextBox.Text, double.Parse(productPriceTextBox.Text), productIdTextBox.Text);
            MessageBox.Show(stockProducts.AddItem<Product>(newProduct));

            InitializeProductsListBox();
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            Product deleteProduct = (Product)itemsListBox.Items[itemsListBox.SelectedIndex];
            MessageBox.Show(stockProducts.DeleteItem<Product>(deleteProduct));

            InitializeProductsListBox();
        }

        private void InitializeProductsListBox()
        {
            itemsListBox.Items.Clear();

            foreach (Product product in stockProducts.GetListOfItems<Product>())
                itemsListBox.Items.Add(product);
        }

        private void InitializeDiscountsListBox()
        {
            itemsListBox.Items.Clear();

            foreach (Discount discount in stockDiscounts.GetListOfItems<Discount>())
                itemsListBox.Items.Add(discount);
        }

        private void productsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteProductButton.Enabled = true;
        }

        private void кассаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productNameLabel.Visible = false;
            productNameTextBox.Visible = false;
            productManufacturerLabel.Visible = false;
            productManufacturerTextBox.Visible = false;
            productIdLabel.Visible = false;
            productIdTextBox.Visible = false;
            productPriceLabel.Visible = false;
            productPriceTextBox.Visible = false;
            addProductButton.Visible = false;
            deleteProductButton.Visible = false;
            itemsListBox.Visible = true;
            scanProductButton.Visible = true;
            getCheckButton.Visible = true;
            scanProductsTextBox.Visible = true;
            totalPriceTextBox.Visible = true;
            totalPriceLabel.Visible = true;
            productsCountLabel.Visible = false;
            productsCountTextBox.Visible = false;
            addDiscountButton.Visible = false;
            deleteDiscountButton.Visible = false;

            InitializeProductsListBox();
        }

        private void scanProductButton_Click(object sender, EventArgs e)
        {
            tape.Scan((Product)itemsListBox.SelectedItem);

            scanProductsTextBox.Clear();
            foreach (KeyValuePair<Product, ScanProductInfo> product in tape.GetProducts())
                scanProductsTextBox.Text += product.Key.name+"   "+product.Value.count + "   " + product.Value.price+"р.\n";
            totalPriceTextBox.Text = tape.GetTotalPrice().ToString();
        }

        private void getCheckButton_Click(object sender, EventArgs e)
        {
            tape.CheckCreation();
            Process.Start("C:\\Windows\\System32\\notepad.exe", "check.txt");
        }

        private void акцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productNameLabel.Visible = true;
            productNameTextBox.Visible = true;
            productManufacturerLabel.Visible = true;
            productManufacturerTextBox.Visible = true;
            productIdLabel.Visible = true;
            productIdTextBox.Visible = true;
            productPriceLabel.Visible = true;
            productPriceTextBox.Visible = true;
            productsCountLabel.Visible = true;
            productsCountTextBox.Visible = true;
            addDiscountButton.Visible = true;
            deleteDiscountButton.Visible = true;
            itemsListBox.Visible = true;
            addProductButton.Visible = false;
            deleteProductButton.Visible = false;
            scanProductButton.Visible = false;
            getCheckButton.Visible = false;
            scanProductsTextBox.Visible = false;
            totalPriceTextBox.Visible = false;
            totalPriceLabel.Visible = false;

            InitializeDiscountsListBox();
        }

        private void addDiscountButton_Click(object sender, EventArgs e)
        {
            foreach (Product product in stockProducts.GetListOfItems<Product>())
            {
                if((productNameTextBox.Text == product.name) & (productManufacturerTextBox.Text == product.manufacturer) & (productIdTextBox.Text == product.id) )
                {
                    Discount newDiscount = new Discount(product, double.Parse(productPriceTextBox.Text), Int32.Parse(productsCountTextBox.Text));
                    MessageBox.Show(stockDiscounts.AddItem<Discount>(newDiscount));

                    InitializeDiscountsListBox();
                    break;
                }
            }
        }

        private void deleteDiscountButton_Click(object sender, EventArgs e)
        {
            Discount deleteDiscount = (Discount)itemsListBox.Items[itemsListBox.SelectedIndex];
            MessageBox.Show(stockDiscounts.DeleteItem<Discount>(deleteDiscount));

            InitializeDiscountsListBox();
        }
    }
}

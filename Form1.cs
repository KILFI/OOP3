using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MerchNamespace;
using StorageNamespace;


namespace OOP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Storage store = new Storage();

            Product _product = new Product("Хлеб", 20, "12.05.2019");
            List<Merch> product = store.Get_Product();
            int i = store.Get_Product().Count();
            product.Add(_product);
            textOut.Text += product[i].GetOutPut()+ " Номер в списке: " + i + Environment.NewLine;

            Toy _toy = new Toy("Машинка", 540, "1.10.2019", "5");
            List<Merch> toy = store.Get_Toy();
            toy.Add(_toy);
            textOut.Text += toy[0].GetOutPut() + " Номер в списке: " + i + Environment.NewLine;

            MilkProduct _milk_product = new MilkProduct("Молоко", 40, "19.04.2019", "7");
            List<Merch> milk_product = store.Get_Milk_Product();
            milk_product.Add(_milk_product);
            textOut.Text += milk_product[0].GetOutPut() + " Номер в списке: " + i + Environment.NewLine;

          
        }

        int productCount = 0;
        int milkProductCount = 0;
        int toyCount = 0;

        bool product_check = false;

        private void CreateProduct_Click(object sender, EventArgs e)
        {
            productTable.Visible = true;
            ageText.ReadOnly = true;
            expirationDateText.ReadOnly = true;
            product_check = true;
            milk_product_check = false;
            toy_check = false;
        }

        bool toy_check = false;

        private void CreateToy_Click(object sender, EventArgs e)
        {
            productTable.Visible = true;
            expirationDateText.ReadOnly = true;
            ageText.ReadOnly = false;
            toy_check = true;
            milk_product_check = false;
            product_check = false;
        }

        bool milk_product_check = false;

        private void CreateMilkProduct_Click(object sender, EventArgs e)
        {
            expirationDateText.ReadOnly = false;
            productTable.Visible = true;
            ageText.ReadOnly = true;
            milk_product_check = true;
            product_check = false;
            toy_check = false;
        }


        private void inputProduct_Click_1(object sender, EventArgs e)
        {
            Storage store = new Storage();
            string name = Convert.ToString(nameTextBox.Text);
            float price = float.Parse(priceTextBox.Text);
            string date = Convert.ToString(dateTextBox.Text);
            string expriration_date = Convert.ToString(expirationDateText.Text);
            string age = Convert.ToString(ageText.Text);


            if (toy_check == true)
            {
                Toy toy = new Toy(name, price,date, age);
                List<Merch> toys_list = store.Get_Toy();
                int i = store.Get_Toy().Count();
                toys_list.Add(toy);
                productTable.Visible = false;
                toy_check = false;
            }

            if (milk_product_check == true)
            {
                MilkProduct milk_product = new MilkProduct(name, price, date, expriration_date);
                List<Merch> milk_products_list = store.Get_Milk_Product();
                int i = store.Get_Milk_Product().Count();
                milk_products_list.Add(milk_product);
                productTable.Visible = false;
                milk_product_check = false;
            }

            if (product_check == true)
            {
                Product product = new Product(name, price, date);
                List<Merch> products_list = store.Get_Product();
                int i = store.Get_Product().Count();
                products_list.Add(product);
                productTable.Visible = false;
                product_check = false;
            }

            textOut.Clear();

            foreach (Product products in store.Get_Product())
            {
                textOut.Text += products.GetOutPut() + " Номер в списке: " + productCount + Environment.NewLine;
                productCount++;
            }

            textOut.Text += Environment.NewLine;

            foreach (MilkProduct milk_products in store.Get_Milk_Product())
            {
                textOut.Text += milk_products.GetOutPut() + " Номер в списке: " + milkProductCount + Environment.NewLine;
                milkProductCount++;
            }

            textOut.Text += Environment.NewLine;

            foreach (Toy toys in store.Get_Toy())
            {
                textOut.Text += toys.GetOutPut() + " Номер в списке: " + toyCount + Environment.NewLine;
                toyCount++;
            }

            toyCount = 0;
            productCount = 0;
            milkProductCount = 0;

            allTextClear();
        }


        public void allTextClear()
        {
            ageText.Clear();
            nameTextBox.Clear();
            expirationDateText.Clear();
            dateTextBox.Clear();
            priceTextBox.Clear();
        }

        private void deleteObject_Click(object sender, EventArgs e)
        {
            Storage store = new Storage();
            Product.DeleteObject();
            List<Merch> products_list = store.Get_Product();
            int count = Convert.ToInt32(deleteProductTextBox.Text);
            products_list.Remove(products_list[count]);
            deleteProductTextBox.Clear();

            textOut.Clear();

            foreach (Merch products in store.Get_Product())
            {
                textOut.Text += products.GetOutPut() + " Номер в списке: " + productCount + Environment.NewLine;
                productCount++;
            }

            textOut.Text += Environment.NewLine;

            foreach (Merch milk_products in store.Get_Milk_Product())
            {
                textOut.Text += milk_products.GetOutPut() + " Номер в списке: " + milkProductCount + Environment.NewLine;
                milkProductCount++;
            }

            textOut.Text += Environment.NewLine;

            foreach (Merch toys in store.Get_Toy())
            {
                textOut.Text += toys.GetOutPut() + " Номер в списке: " + toyCount + Environment.NewLine;
                toyCount++;
            }

            toyCount = 0;
            productCount = 0;
            milkProductCount = 0;
        }

        private void deleteMilkProduct_Click(object sender, EventArgs e)
        {
            Storage store = new Storage();
            MilkProduct.DeleteObject();
            List<Merch> milk_products_list = store.Get_Milk_Product();
            int count = Convert.ToInt32(deleteMilkProductTextBox.Text);
            milk_products_list.Remove(milk_products_list[count]);
            deleteMilkProductTextBox.Clear();

            textOut.Clear();

            foreach (Merch products in store.Get_Product())
            {
                textOut.Text += products.GetOutPut() + " Номер в списке: " + productCount + Environment.NewLine;
                productCount++;
            }

            textOut.Text += Environment.NewLine;

            foreach (Merch milk_products in store.Get_Milk_Product())
            {
                textOut.Text += milk_products.GetOutPut() + " Номер в списке: " + milkProductCount + Environment.NewLine;
                milkProductCount++;
            }

            textOut.Text += Environment.NewLine;

            foreach (Merch toys in store.Get_Toy())
            {
                textOut.Text += toys.GetOutPut() + " Номер в списке: " + toyCount + Environment.NewLine;
                toyCount++;
            }

            toyCount = 0;
            productCount = 0;
            milkProductCount = 0;
        }

        private void deleteToy_Click(object sender, EventArgs e)
        {
            Storage store = new Storage();
            Toy.DeleteObject();
            List<Merch> toy_list = store.Get_Toy();
            int count = Convert.ToInt32(deleteToyTextBox.Text);
            toy_list.Remove(toy_list[count]);
            deleteToyTextBox.Clear();

            textOut.Clear();

            foreach (Merch products in store.Get_Product())
            {
                textOut.Text += products.GetOutPut() + " Номер в списке: " + productCount + Environment.NewLine;
                productCount++;
            }

            textOut.Text += Environment.NewLine;

            foreach (Merch milk_products in store.Get_Milk_Product())
            {
                textOut.Text += milk_products.GetOutPut() + " Номер в списке: " + milkProductCount + Environment.NewLine;
                milkProductCount++;
            }

            textOut.Text += Environment.NewLine;

            foreach (Merch toys in store.Get_Toy())
            {
                textOut.Text += toys.GetOutPut() + " Номер в списке: " + toyCount + Environment.NewLine;
                toyCount++;
            }

            toyCount = 0;
            productCount = 0;
            milkProductCount = 0;
        } 
    }
}

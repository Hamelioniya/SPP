using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Tape
    {
        private const string filePathCheck = @"C:\Users\Анастасия\Documents\Visual Studio 2015\Projects\Shop\Shop\bin\Debug\check.txt";
        private const string filePathProducts = @"C:\Users\Анастасия\Documents\Visual Studio 2015\Projects\Shop\Shop\bin\Debug\products.xml";
        private const string filePathDiscounts = @"C:\Users\Анастасия\Documents\Visual Studio 2015\Projects\Shop\Shop\bin\Debug\discounts.xml";

        private Dictionary<Product, ScanProductInfo> scanProductsList { get; set; }
        private double totalPrice { get; set; }

        public Tape()
        {
            scanProductsList = new Dictionary<Product, ScanProductInfo>();
        }

        public void Scan(Product product)
        {
            if (scanProductsList.ContainsKey(product))
            {
                ScanProductInfo info = scanProductsList[product];
                info.count++;
                info.price += product.price;

                Stock stockDiscounts = new Stock(filePathDiscounts);

                foreach (Discount discount in stockDiscounts.GetListOfItems<Discount>())
                    if (product.Equals(discount.product))
                        if (info.count % discount.countOfProductsForDiscount == 0)
                            info.price = discount.discountPrice * (int)(info.count / discount.countOfProductsForDiscount);
                scanProductsList[product] = info;
            }
            else
            {
                Stock stockProducts = new Stock(filePathProducts);
                foreach (Product currentProduct in stockProducts.GetListOfItems<Product>())
                {
                    if ((currentProduct.name == product.name) & (currentProduct.manufacturer == product.manufacturer) & (currentProduct.id == product.id))
                    {
                        ScanProductInfo info;
                        info.count = 1;
                        info.price = product.price;
                        scanProductsList.Add(product, info);
                        break;
                    }
                }
            }
        }

        public double GetTotalPrice()
        {
            totalPrice = 0;
            foreach (KeyValuePair<Product, ScanProductInfo> product in scanProductsList)
                totalPrice += product.Value.price;
            return totalPrice;
        }

        public Dictionary<Product, ScanProductInfo> GetProducts() => this.scanProductsList;

        public string CheckCreation()
        {
            string checkText = "";
            File.WriteAllText(filePathCheck, "");

            foreach (KeyValuePair<Product, ScanProductInfo> product in scanProductsList)
                checkText += product.Key.name + "(" + product.Key.manufacturer + " " + product.Key.id + ")" + "   " + (product.Value.count).ToString() + "   " + (product.Value.price).ToString() + "р.\r\n";
            checkText += "Сумма к оплате:   " + GetTotalPrice().ToString();
            File.AppendAllText(filePathCheck, checkText);

            return checkText;
        }
    }
}

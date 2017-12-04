using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Shop.NUnitTests
{
    [TestFixture]
    class TapeTests
    {
        [TestCase("Кофе", "Россия", 10.33, "334")]
        [TestCase("Чай", "Россия", 4.57, "333")]
        [TestCase("Молоко", "Беларусь", 1.29, "123")]
        public void Tape_SuccessScanProductTests(string productName, string productManufacturer, double productPrice, string productId)
        {
            Tape tape = new Tape();
            Product product = new Product(productName, productManufacturer, productPrice, productId);

            tape.Scan(product);

            Assert.Contains(product, tape.GetProducts().Keys);
        }

        [TestCase("Кофе", "Беларусь", 10.33, "334")]
        [TestCase("Кефир", "Россия", 10.33, "334")]
        [TestCase("Кофе", "Россия", 10.33, "338")]
        public void Tape_UnsuccessScanProductTests(string productName, string productManufacturer, double productPrice, string productId)
        {
            Tape tape = new Tape();
            Product product = new Product(productName, productManufacturer, productPrice, productId);

            tape.Scan(product);

            Assert.IsFalse(tape.GetProducts().ContainsKey(product));
        }

        [TestCase("Кофе", "Россия", 10.33, "334", @"C:\Users\Анастасия\Documents\Visual Studio 2015\Projects\Shop\Shop\bin\Debug\discounts.xml")]
        [TestCase("Чай", "Россия", 4.57, "333", @"C:\Users\Анастасия\Documents\Visual Studio 2015\Projects\Shop\Shop\bin\Debug\discounts.xml")]
        [TestCase("Молоко", "Беларусь", 1.29, "123", @"C:\Users\Анастасия\Documents\Visual Studio 2015\Projects\Shop\Shop\bin\Debug\discounts.xml")]
        public void Tape_ScanDiscountProductDiscountTimesTests(string productName, string productManufacturer, double productPrice, string productId, string filePath)
        {
            Tape tape = new Tape();
            Stock stockDiscounts = new Stock(filePath);
            Product product = new Product(productName, productManufacturer, productPrice, productId);
            
            foreach(Discount discount in stockDiscounts.GetListOfItems<Discount>())
                if((discount.product.name == product.name) & (discount.product.manufacturer == product.manufacturer) & (discount.product.id == product.id))
                {
                    for (int i = 0; i < discount.countOfProductsForDiscount - 1; i++)
                    {
                        tape.Scan(product);
                        Assert.AreEqual(product.price*(i+1), tape.GetProducts()[product].price);
                    }
                    tape.Scan(product);
                    Assert.AreEqual(discount.discountPrice, tape.GetProducts()[product].price);
                    return;
                }         
        }

        [TestCase("Кофе", "Россия", 10.33, "334", @"C:\Users\Анастасия\Documents\Visual Studio 2015\Projects\Shop\Shop\bin\Debug\discounts.xml", 1)]
        [TestCase("Чай", "Россия", 4.57, "333", @"C:\Users\Анастасия\Documents\Visual Studio 2015\Projects\Shop\Shop\bin\Debug\discounts.xml", 2)]
        [TestCase("Молоко", "Беларусь", 1.29, "123", @"C:\Users\Анастасия\Documents\Visual Studio 2015\Projects\Shop\Shop\bin\Debug\discounts.xml", 5)]
        public void Tape_GetTotalPriceTests(string productName, string productManufacturer, double productPrice, string productId, string filePath, int loopTimes)
        {
            Tape tape = new Tape();
            Stock stockDiscounts = new Stock(filePath);
            Product product = new Product(productName, productManufacturer, productPrice, productId);
            double totalPrice = 0;

            for(int i = 0; i < loopTimes; i++)
            {
                tape.Scan(product);
            }

            foreach (Discount discount in stockDiscounts.GetListOfItems<Discount>())
                if ((discount.product.name == product.name) & (discount.product.manufacturer == product.manufacturer) & (discount.product.id == product.id) & (loopTimes/discount.countOfProductsForDiscount > 0))
                {
                    var discountPart = loopTimes / discount.countOfProductsForDiscount;
                    totalPrice = (discount.discountPrice * discountPart) + product.price * (loopTimes - discountPart * discount.countOfProductsForDiscount);

                    Assert.AreEqual(totalPrice, tape.GetTotalPrice());
                    return;
                }
            totalPrice = product.price * loopTimes;
            Assert.AreEqual(totalPrice, tape.GetTotalPrice());
        }

        [TestCase("Кофе", "Россия", 10.33, "334", @"C:\Users\Анастасия\Documents\Visual Studio 2015\Projects\Shop\Shop\bin\Debug\check.txt")]
        [TestCase("Чай", "Россия", 4.57, "333", @"C:\Users\Анастасия\Documents\Visual Studio 2015\Projects\Shop\Shop\bin\Debug\check.txt")]
        [TestCase("Молоко", "Беларусь", 1.29, "123", @"C:\Users\Анастасия\Documents\Visual Studio 2015\Projects\Shop\Shop\bin\Debug\check.txt")]
        public void Tape_GetCheckTests(string productName, string productManufacturer, double productPrice, string productId, string filePath)
        {
            Tape tape = new Tape();
            Product product = new Product(productName, productManufacturer, productPrice, productId);

            tape.Scan(product);
            tape.CheckCreation();

            FileAssert.Exists(filePath);
        }

    }
}

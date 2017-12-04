using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;

namespace Shop.NUnitTests
{
    [TestFixture]
    class ShopTests
    {
        #region Mock Tests

        [TestCase("Кефир", "Беларусь", 1.25, "111", @"C:\Users\Анастасия\Documents\Visual Studio 2015\Projects\Shop\Shop\bin\Debug\products.xml")]
        public void Shop_AddProductTests(string productName, string productManufacturer, double productPrice, string productId, string filePath)
        {
            Mock<IStock> mockStock = new Mock<IStock>();
            mockStock.SetupProperty(stockProducts => stockProducts.filePath, filePath);

            Shop shop = new Shop(mockStock.Object);

            Product newProduct = new Product(productName, productManufacturer, productPrice, productId);
            shop.AddProduct(newProduct);
           
            mockStock.Verify(stock => stock.AddItem(It.Is<Product>(product => product.Equals(newProduct))), Times.Once);
        }

        [TestCase("Кефир", "Беларусь", 1.25, "111", @"C:\Users\Анастасия\Documents\Visual Studio 2015\Projects\Shop\Shop\bin\Debug\products.xml")]
        public void Shop_DeleteProductTests(string productName, string productManufacturer, double productPrice, string productId, string filePath)
        {
            Mock<IStock> mockStock = new Mock<IStock>();
            mockStock.SetupProperty(stockProducts => stockProducts.filePath, filePath);

            Shop shop = new Shop(mockStock.Object);

            Product deleteProduct = new Product(productName, productManufacturer, productPrice, productId);
            shop.DeleteProduct(deleteProduct);

            mockStock.Verify(stock => stock.DeleteItem(It.Is<Product>(product => product.Equals(deleteProduct))), Times.Once);
        }

        [TestCase("Кефир", "Беларусь", 1.25, "111", @"C:\Users\Анастасия\Documents\Visual Studio 2015\Projects\Shop\Shop\bin\Debug\products.xml")]
        public void Shop_GetListOfProductsTests(string productName, string productManufacturer, double productPrice, string productId, string filePath)
        {
            Mock<IStock> mockStock = new Mock<IStock>();
            mockStock.SetupProperty(stockProducts => stockProducts.filePath, filePath);

            Shop shop = new Shop(mockStock.Object);

            Product product = new Product(productName, productManufacturer, productPrice, productId);
            shop.GetAllProducts();

            mockStock.Verify(stock => stock.GetListOfItems<Product>(), Times.Once);
        }

        #endregion //! Mock Tests

        #region Stab Tests

        [TestCase("Кефир", "Беларусь", 1.25, "126", @"C:\Users\Анастасия\Documents\Visual Studio 2015\Projects\Shop\Shop\bin\Debug\discounts.xml", 3.50, 3, ExpectedResult = "Добавление выполнено успешно!")]
        [TestCase("Молоко", "Беларусь", 1.29, "123", @"C:\Users\Анастасия\Documents\Visual Studio 2015\Projects\Shop\Shop\bin\Debug\discounts.xml", 3, 3, ExpectedResult = "Уже существует!")]
        public string Shop_AddDiscountTests(string productName, string productManufacturer, double productPrice, string productId, string filePath, double discountPrice, int countOfProductsForDiscount)
        {
            Mock<IStock> mockStock = new Mock<IStock>();
            mockStock.SetupProperty(stockProducts => stockProducts.filePath, filePath);

            Shop shop = new Shop(mockStock.Object);
            Stock stock = new Stock(filePath);

            Product product = new Product(productName, productManufacturer, productPrice, productId);
            Discount discount = new Discount(product, discountPrice, countOfProductsForDiscount);

            mockStock.Setup(stockDiscounts => stockDiscounts.AddItem<Discount>(discount)).Returns(stock.AddItem<Discount>(discount));

            return shop.AddDiscount(discount);
        }

        [TestCase("Кефир", "Беларусь", 1.25, "126", @"C:\Users\Анастасия\Documents\Visual Studio 2015\Projects\Shop\Shop\bin\Debug\discounts.xml", 3.50, 3, ExpectedResult = "Удаление выполнено успешно!")]
        [TestCase("Cыр", "Беларусь", 4.50, "127", @"C:\Users\Анастасия\Documents\Visual Studio 2015\Projects\Shop\Shop\bin\Debug\discounts.xml", 3, 3, ExpectedResult = "Не существует!")]
        public string Shop_DeleteDiscountTests(string productName, string productManufacturer, double productPrice, string productId, string filePath, double discountPrice, int countOfProductsForDiscount)
        {
            Mock<IStock> mockStock = new Mock<IStock>();
            mockStock.SetupProperty(stockProducts => stockProducts.filePath, filePath);

            Shop shop = new Shop(mockStock.Object);
            Stock stock = new Stock(filePath);

            Product product = new Product(productName, productManufacturer, productPrice, productId);
            Discount discount = new Discount(product, discountPrice, countOfProductsForDiscount);

            mockStock.Setup(stockDiscounts => stockDiscounts.DeleteItem<Discount>(discount)).Returns(stock.DeleteItem<Discount>(discount));

            return shop.DeletDiscount(discount);
        }

        [TestCase("Молоко", "Беларусь", 1.29, "123", @"C:\Users\Анастасия\Documents\Visual Studio 2015\Projects\Shop\Shop\bin\Debug\discounts.xml", 3, 3)]
        public void Shop_GetListOfDiscountsTests(string productName, string productManufacturer, double productPrice, string productId, string filePath, double discountPrice, int countOfProductsForDiscount)
        {
            Mock<IStock> mockStock = new Mock<IStock>();
            mockStock.SetupProperty(stockProducts => stockProducts.filePath, filePath);

            Shop shop = new Shop(mockStock.Object);
            Stock stock = new Stock(filePath);

            Product product = new Product(productName, productManufacturer, productPrice, productId);
            Discount discount = new Discount(product, discountPrice, countOfProductsForDiscount);

            mockStock.Setup(stockDiscounts => stockDiscounts.GetListOfItems<Discount>()).Returns(stock.GetListOfItems<Discount>());

            Assert.Contains(discount, shop.GetAllDiscounts());
        }

        #endregion //! Stab Tests
    }
}

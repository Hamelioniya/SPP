using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Shop
    {
        private readonly IStock stock;

        public Shop(IStock stock)
        {
            this.stock = stock;
        }

        public string AddProduct(Product product)
        {
            return stock.AddItem<Product>(product);
        }

        public string AddDiscount(Discount discount)
        {
            return stock.AddItem<Discount>(discount);
        }

        public string DeleteProduct(Product product)
        {
            return stock.DeleteItem<Product>(product);
        }

        public string DeletDiscount(Discount discount)
        {
            return stock.DeleteItem<Discount>(discount);
        }

        public List<Product> GetAllProducts() => stock.GetListOfItems<Product>();
        public List<Discount> GetAllDiscounts() => stock.GetListOfItems<Discount>();
    }
}

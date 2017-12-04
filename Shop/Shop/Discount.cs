using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    [Serializable]
    public class Discount
    {
        public Product product { get; set; }
        public string name { get; set; }
        public double discountPrice { get; set; }
        public int countOfProductsForDiscount { get; set; }

        public Discount() { }

        public Discount(Product product, double discountPrice, int countOfProductsForDiscount)
        {
            this.product = product;
            this.discountPrice = discountPrice;
            this.countOfProductsForDiscount = countOfProductsForDiscount;
            this.name = product.name;
        }

        public override bool Equals(object obj)
        {
            Discount discountForEqual = (Discount)obj;
            if ((this.product.name == discountForEqual.product.name) & (this.product.manufacturer == discountForEqual.product.manufacturer) & (this.product.id == discountForEqual.product.id))
                return true;
            return false;
        }
    }
}

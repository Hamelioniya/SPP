using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    [Serializable]
    public class Product
    {
        public string name { get; set; }
        public string manufacturer { get; set; }
        public double price { get; set; }
        public string id { get; set; }

        public Product() {  }

        public Product(string name, string manufacturer, double price, string id)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.price = price;
            this.id = id;
        }

        public override bool Equals(object obj)
        {
            Product productForEqual = (Product)obj;
            if ((this.name == productForEqual.name) & (this.manufacturer == productForEqual.manufacturer) & (this.id == productForEqual.id))
                return true;
            return false;
        }
    }
}

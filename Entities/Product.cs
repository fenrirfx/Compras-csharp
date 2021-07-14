using System;
using System.Collections.Generic;
using System.Text;

namespace Compras.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string priceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name + " $ " + Price);
            return sb.ToString();
        }
    }
}

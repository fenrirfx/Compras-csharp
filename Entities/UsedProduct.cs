using System;
using System.Collections.Generic;
using System.Text;

namespace Compras.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }
        public UsedProduct(string name, double price, DateTime manufactureDate) : base (name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string priceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name + " (Used) $ " + Price + " (Manufacture Date: "+ ManufactureDate.ToString("dd/MM/yyyy") + ")");
            return sb.ToString();
        }
    }
}

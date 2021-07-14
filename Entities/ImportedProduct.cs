using System;
using System.Collections.Generic;
using System.Text;

namespace Compras.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }
        public ImportedProduct(string name, double price, double customsFee) : base (name, price)
        {
            CustomsFee = customsFee;
        }

        public override string priceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name + " $ " + totalPrice() + " (Customs Fee: $" + CustomsFee+ ")");
            return sb.ToString();
        }

        public double totalPrice()
        {
            return Price + CustomsFee;
        }
    }
}

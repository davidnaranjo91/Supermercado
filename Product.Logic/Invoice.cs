using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Logic
{
    public class Invoice
    {
        private int _products;

        public static decimal AddProduct() { }

        public static decimal Invoice() { }

        public override string ToString()
        {
            return base.ToString();
        }
        public decimal ValueToPay() { };
    }
}

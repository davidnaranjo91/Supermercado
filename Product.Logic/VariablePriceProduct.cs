using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Logic
{
    public class VariablePriceProduct : Products
    {
        public decimal Measurement { get; set; }
        public int Quantity { get; set; }

        public override decimal ValueToPay()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

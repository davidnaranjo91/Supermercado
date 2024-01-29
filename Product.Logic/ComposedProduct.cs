using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Logic
{
    public class ComposedProduct : Products
    {
        public decimal Discount { get; set; }

        public string Products { get; set; }
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

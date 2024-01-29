using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Logic
{
    public abstract class Products
    {

        public string? Descripcion { get; set; }
        public string? Id { get; set; }
        public decimal Price { get; set; }
        public double Tax { get; set; }

        public abstract decimal ValueToPay();
        
        public override string ToString()
        {
            return $"Id de producto: {Id}\n" +
                   $"Nombre producto: {Descripcion}\n" +
                   $"Precio producto: {Price, 20:C2} \n" +
                   $"Impuestos: {Tax:P2}";
        }
    }
}

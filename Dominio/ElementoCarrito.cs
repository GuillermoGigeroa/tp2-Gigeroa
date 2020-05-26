using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ElementoCarrito
    {
        public Articulo articulo { get; set; }
        public int cantidad { get; set; }
        public ElementoCarrito()
        {
            Articulo articulo1 = new Articulo();
            articulo = articulo1;
        }
        public double precio()
        {
            return (double)articulo.Precio * (double)cantidad;
        }
    }
}

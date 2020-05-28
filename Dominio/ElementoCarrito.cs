using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ElementoCarrito
    {
        public int ID_elemento { get; set; }
        public Articulo Articulo { get; set; }
        public int Cantidad { get; set; }
        public ElementoCarrito()
        {
            Articulo = new Articulo();
        }
        public double precio()
        {
            return (double)Articulo.Precio * Cantidad;
        }
        
    }
}

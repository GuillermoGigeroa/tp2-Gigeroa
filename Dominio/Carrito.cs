using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Carrito
    {
        public string IdCarrito { get; set; }
        public List<ElementoCarrito> ListaDeElementos { get; set; }
        public Carrito()
        {
            List<ElementoCarrito> lista = new List<ElementoCarrito>();
            ListaDeElementos = lista;
        }
        public double Subtotal()
        {
            double precioSubtotal = 0;
            foreach (var elemento in ListaDeElementos)
            {
                precioSubtotal += elemento.precio();
            }
            return precioSubtotal;
        }
        public void AgregarArticulos(Articulo articulo, int cantidad)
        {
            ElementoCarrito elemento = new ElementoCarrito();
            elemento.articulo = articulo;
            elemento.cantidad = cantidad;
            ListaDeElementos.Add(elemento);
        }
    }
}

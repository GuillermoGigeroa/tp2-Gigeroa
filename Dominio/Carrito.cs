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
        public int CantElementos { get; set; }
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
            CantElementos += 1;
            elemento.Articulo = articulo;
            elemento.Cantidad = cantidad;
            elemento.ID_elemento = CantElementos;
            ListaDeElementos.Add(elemento);
        }
        public int getCantidad()
        {
            int Cantidad = 0;
            foreach (var elemento in ListaDeElementos)
            {
                Cantidad += elemento.Cantidad;
            }
            return Cantidad;
        }
        public void EliminarElemento(int ID_elemento)
        {
            foreach (var elemento in ListaDeElementos)
            {
                if(elemento.ID_elemento == ID_elemento)
                {
                    ListaDeElementos.Remove(elemento);
                    return;
                }
            }
        }
    }
}

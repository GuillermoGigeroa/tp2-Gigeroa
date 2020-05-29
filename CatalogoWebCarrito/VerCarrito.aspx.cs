using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace CatalogoWebCarrito
{
    public partial class VerCarrito : System.Web.UI.Page
    {
        public Carrito carrito = new Carrito();
        protected void Page_Load(object sender, EventArgs e)
        {
            carrito = (Carrito)Session["Carrito" + Session.SessionID];
            if (carrito != null)
            {
                listaCarrito.DataSource = carrito.ListaDeElementos;
                listaCarrito.DataBind();
            }
            string ID_elemento = Request.QueryString["eliminar"];
            if (ID_elemento != null)
            {
                if (ID_elemento == "todo")
                {
                    List<ElementoCarrito> listaVacia = new List<ElementoCarrito>();
                    carrito.ListaDeElementos = listaVacia;
                }
                else
                {
                    carrito.EliminarElemento(Convert.ToInt32(ID_elemento));
                }
                Response.Redirect("VerCarrito.aspx");
            }
        }
        protected int ContarCarrito()
        {
            if (carrito == null)
                return 0;
            return carrito.getCantidad();
        }
        protected double SubtotalCarrito()
        {
            if (carrito == null)
                return 0;
            return carrito.Subtotal();
        }
        protected string MensajeCarritoVacio()
        {
            if (ContarCarrito() == 0)
                return "Ups! Parece que no tienes ningún elemento en el carrito. Ve al catálogo para agregar más.";
            else
                return "";
        }
    }
}
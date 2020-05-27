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
        }
        protected int ContarCarrito()
        {
            if (carrito == null)
                return 0;
            return carrito.ListaDeElementos.Count();
        }
        protected double SubtotalCarrito()
        {
            if (carrito == null)
                return 0;
            return carrito.Subtotal();
        }
    }
}
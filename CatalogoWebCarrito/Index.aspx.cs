using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace CatalogoWebCarrito
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public Carrito carrito = new Carrito();
        public List<Articulo> lista = new List<Articulo>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if((Carrito)Session["Carrito" + Session.SessionID] != null)
            {
                carrito.IdCarrito = "c-"+Session.SessionID;
                carrito = (Carrito)Session["Carrito" + Session.SessionID];
            }
            NegocioCatalogo negocio = new NegocioCatalogo();
            lista = negocio.ListarArticulos();
            repetidor.DataSource = lista;
            repetidor.DataBind();
            string idArticulo = Request.QueryString["idArt"];
            string cantidad = Request.QueryString["cant"];
            if(idArticulo != null && cantidad != null)
                AgregarAlCarrito(idArticulo, cantidad);
            Session["Carrito" + Session.SessionID] = carrito;
        }
        protected int ContarCarrito()
        {
            if(carrito == null)
                return 0;
            return carrito.getCantidad();
        }
        protected double SubtotalCarrito()
        {
            if (carrito == null)
                return 0;
            return carrito.Subtotal();
        }
        protected void AgregarAlCarrito(string IdArticulo, string cant)
        {
            Articulo articuloParaAgregar = new Articulo();
            articuloParaAgregar = lista.Find(articulo => articulo.ID_Articulo == Convert.ToInt32(IdArticulo));
            carrito.AgregarArticulos(articuloParaAgregar, Convert.ToInt32(cant));
        }
    }
}
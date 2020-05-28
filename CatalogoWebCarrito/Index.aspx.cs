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
        public List<Marca> listaMarcas = new List<Marca>();
        public List<Categoria> listaCategorias = new List<Categoria>();
        protected void Page_Load(object sender, EventArgs e)
        {
            NegocioCatalogo negocio = new NegocioCatalogo();
            if((Carrito)Session["Carrito" + Session.SessionID] != null)
            {
                carrito.IdCarrito = "c-"+Session.SessionID;
                carrito = (Carrito)Session["Carrito" + Session.SessionID];
            }
            lista = negocio.ListarArticulos();
            repetidor.DataSource = lista;
            repetidor.DataBind();
            listaMarcas = negocio.ListarMarcas();
            listaCategorias = negocio.ListarCategorias();
            string idArticulo = Request.QueryString["idArt"];
            string cantidad = Request.QueryString["cant"];
            string filtroMarca = Request.QueryString["filtroMarca"];
            string filtroCategoria = Request.QueryString["filtroCategoria"];
            if(idArticulo != null && cantidad != null)
                AgregarAlCarrito(idArticulo, cantidad);
            if (filtroMarca != null)
                FiltrarPorMarca(filtroMarca);
            if (filtroCategoria != null)
                FiltrarPorCategoria(filtroCategoria);
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
        protected void FiltrarPorMarca(string idMarca)
        {
            List<Articulo> listaFiltrada = new List<Articulo>();
            listaFiltrada = lista.FindAll(articulo => articulo.Marca.ID_Marca == Convert.ToInt32(idMarca));
            lista = listaFiltrada;
            repetidor.DataSource = lista;
            repetidor.DataBind();
        }
        protected void FiltrarPorCategoria(string idCategoria)
        {
            List<Articulo> listaFiltrada = new List<Articulo>();
            listaFiltrada = lista.FindAll(articulo => articulo.Categoria.ID_Categoria == Convert.ToInt32(idCategoria));
            lista = listaFiltrada;
            repetidor.DataSource = lista;
            repetidor.DataBind();
        }
    }
}
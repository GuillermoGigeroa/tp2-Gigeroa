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
            NegocioCatalogo negocio = new NegocioCatalogo();
            lista = negocio.ListarArticulos();
            /*
            CargarCategorias();
            CargarMarcas();
            */
            ActualizarCantidad();
        }
        protected void ActualizarCantidad()
        {
            lblCantidad.Text = "Elementos en carrito: " + carrito.ListaDeElementos.Count();
        }
        /*
        protected void CargarMarcas()
        {
            try
            {
                NegocioCatalogo negocio = new NegocioCatalogo();
                listaMarcas.DataSource = negocio.ListarMarcas();
                listaMarcas.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }
        protected void CargarCategorias()
        {
            try
            {
                NegocioCatalogo negocio = new NegocioCatalogo();
                listaCategorias.DataSource = negocio.ListarCategorias();
                listaCategorias.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }
        */
        protected void Boton1_Click(object sender, EventArgs e)
        {
            lblPrueba.Text = Session.SessionID;
        }
        /*
        protected void BusquedaNombre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Articulo> listaFiltrada;
                if (BusquedaNombre.Text == "")
                {
                    listaFiltrada = lista;
                }
                else
                {
                    listaFiltrada = lista.FindAll(articulo => articulo.Nombre.ToLower().Contains(BusquedaNombre.Text.Trim().ToLower()));
                }
                listaDeArticulos.DataSource = listaFiltrada;
                listaDeArticulos.DataBind();
            }
            catch (Exception)
            {

            }
        }
        protected void BusquedaMarca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Articulo> listaFiltrada;
                if (BusquedaMarca.Text == "")
                {
                    listaFiltrada = lista;
                }
                else
                {
                    listaFiltrada = lista.FindAll(articulo => articulo.Marca.Nombre.ToLower().Contains(BusquedaMarca.Text.Trim().ToLower()));
                }
                listaDeArticulos.DataSource = listaFiltrada;
                listaDeArticulos.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }
        protected void BusquedaCodigo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Articulo> listaFiltrada;
                if (BusquedaCodigo.Text == "")
                {
                    listaFiltrada = lista;
                }
                else
                {
                    listaFiltrada = lista.FindAll(articulo => articulo.CodigoArticulo.ToLower().Contains(BusquedaCodigo.Text.Trim().ToLower()));
                }
                listaDeArticulos.DataSource = listaFiltrada;
                listaDeArticulos.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }
        protected void BusquedaCategoria_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Articulo> listaFiltrada;
                if (BusquedaCategoria.Text == "")
                {
                    listaFiltrada = lista;
                }
                else
                {
                    listaFiltrada = lista.FindAll(articulo => articulo.Categoria.Nombre.ToLower().Contains(BusquedaCategoria.Text.Trim().ToLower()));
                }
                listaDeArticulos.DataSource = listaFiltrada;
                listaDeArticulos.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }
        */
        protected void listaMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void listaCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
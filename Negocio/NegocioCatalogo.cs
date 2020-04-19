using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class NegocioCatalogo
    {
        public List<Articulo> ListarArticulos()
        {
            List<Articulo> listado = new List<Articulo>();
            try
            {
                Datos datos = new Datos();
                datos.ConfigurarConexion();
                datos.IngresarComando("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, M.Descripcion as [Marca], A.IdCategoria, C.Descripcion as [Categoria], A.ImagenUrl, A.Precio FROM ARTICULOS as A left join CATEGORIAS as C on A.IdCategoria = C.Id left join MARCAS as M on A.IdMarca = M.Id");
                datos.ConectarDB();
                datos.PrepararLectura();
                SqlDataReader datosLeidos;
                while (datos.Leer())
                {
                    datosLeidos = datos.Lectura();
                    Articulo articulo = new Articulo
                    {
                        ID_Articulo = (int)datosLeidos["Id"],
                        CodigoArticulo = datosLeidos["Codigo"].ToString(),
                        Nombre = datosLeidos["Nombre"].ToString(),
                        Descripcion = datosLeidos["Descripcion"].ToString(),
                        URL_Imagen = datosLeidos["ImagenUrl"].ToString(),
                        Precio = (decimal)datosLeidos["Precio"]
                    };
                    articulo.Marca.ID_Marca = (int)datosLeidos["IdMarca"];
                    articulo.Marca.Nombre = datosLeidos["Marca"].ToString();
                    articulo.Categoria.ID_Categoria = (int)datosLeidos["IDCategoria"];
                    articulo.Categoria.Nombre = datosLeidos["Categoria"].ToString();
                    
                    listado.Add(articulo);
                }
                return listado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Datos datos = new Datos();
                datos.DesconectarDB();
                //datos.IngresarComando("Delete...");
                datos.ConectarDB();

            }
        }
        /* SE DEBE IMPLEMENTAR BIEN ESTE MÉTODO
        public void AgregarArticulo(Articulo articulo)
        {
            try
            {
                Datos datos = new Datos();
                datos.ConfigurarConexion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }
        */
    }
}

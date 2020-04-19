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
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "data source=GUILLEGIGEROA\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, M.Descripcion as [Marca], A.IdCategoria, C.Descripcion as [Categoria], A.ImagenUrl, A.Precio FROM ARTICULOS as A left join CATEGORIAS as C on A.IdCategoria = C.Id left join MARCAS as M on A.IdMarca = M.Id";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Articulo articulo = new Articulo();
                    Marca marca = new Marca();
                    Categoria categoria = new Categoria();
                    articulo.Marca = marca;
                    articulo.Categoria = categoria;

                    articulo.CodigoArticulo = lector["Codigo"].ToString();
                    articulo.Nombre = lector["Nombre"].ToString();
                    articulo.Descripcion = lector["Descripcion"].ToString();
                    articulo.Marca.ID_Marca = (int)lector["IdMarca"];
                    articulo.Marca.Nombre = lector["Marca"].ToString();
                    articulo.Categoria.ID_Categoria = (int)lector["IDCategoria"];
                    articulo.Categoria.Nombre = lector["Categoria"].ToString();
                    articulo.URL_Imagen = lector["ImagenUrl"].ToString();
                    articulo.Precio = (decimal)lector["Precio"];
                    
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
                conexion.Close();
            }
        }
    }
}

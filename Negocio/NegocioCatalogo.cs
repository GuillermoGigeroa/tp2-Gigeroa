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

                    if (!Convert.IsDBNull(lector["Codigo"]))
                        articulo.CodigoArticulo = lector["Codigo"].ToString();
                    if (!Convert.IsDBNull(lector["Nombre"]))
                        articulo.Nombre = lector["Nombre"].ToString();
                    if (!Convert.IsDBNull(lector["Descripcion"]))
                        articulo.Descripcion = lector["Descripcion"].ToString();
                    if (!Convert.IsDBNull(lector["IdMarca"]))
                        articulo.Marca.ID_Marca = (int)lector["IdMarca"];
                    if (!Convert.IsDBNull(lector["Marca"]))
                        articulo.Marca.Nombre = lector["Marca"].ToString();
                    if (!Convert.IsDBNull(lector["IDCategoria"]))
                        articulo.Categoria.ID_Categoria = (int)lector["IDCategoria"];
                    if (!Convert.IsDBNull(lector["Categoria"]))
                        articulo.Categoria.Nombre = lector["Categoria"].ToString();
                    if (!Convert.IsDBNull(lector["ImagenUrl"]))
                        articulo.URL_Imagen = lector["ImagenUrl"].ToString();
                    if (!Convert.IsDBNull(lector["Precio"]))
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

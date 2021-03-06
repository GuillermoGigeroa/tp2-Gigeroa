﻿using System;
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
                datos.IngresarComando("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, M.Descripcion as [Marca], A.IdCategoria, C.Descripcion as [Categoria], A.ImagenUrl, A.Precio FROM ARTICULOS as A left join CATEGORIAS as C on A.IdCategoria = C.Id left join MARCAS as M on A.IdMarca = M.Id ORDER BY Precio");
                datos.ConectarDB();
                datos.PrepararLectura();
                SqlDataReader datosLeidos;
                Articulo articulo;
                while (datos.Leer())
                {
                    datosLeidos = datos.Lectura();
                    articulo = new Articulo();
                    if(!Convert.IsDBNull(datosLeidos["ID"]))
                    {
                        articulo.ID_Articulo = (int) datosLeidos["Id"];
                    }
                    else
                    {
                        articulo.ID_Articulo = -1;
                    }
                    if (!Convert.IsDBNull(datosLeidos["Codigo"]))
                    {
                        articulo.CodigoArticulo = datosLeidos["Codigo"].ToString();
                    }
                    else
                    {
                        articulo.CodigoArticulo = "N/A";
                    }
                    if (!Convert.IsDBNull(datosLeidos["Nombre"]))
                    {
                        articulo.Nombre = datosLeidos["Nombre"].ToString();
                    }
                    else
                    {
                        articulo.Nombre = "N/A";
                    }
                    if (!Convert.IsDBNull(datosLeidos["Descripcion"]))
                    {
                        articulo.Descripcion = datosLeidos["Descripcion"].ToString();
                    }
                    else
                    {
                        articulo.Descripcion = "N/A";
                    }
                    if (!Convert.IsDBNull(datosLeidos["ImagenUrl"]))
                    {
                        articulo.URL_Imagen = datosLeidos["ImagenUrl"].ToString();
                    }
                    else
                    {
                        articulo.URL_Imagen = "N/A";
                    }
                    if (!Convert.IsDBNull(datosLeidos["Precio"]))
                    {
                        articulo.Precio = (decimal)datosLeidos["Precio"];
                    }
                    else
                    {
                        articulo.Precio = -1;
                    }
                    if (!Convert.IsDBNull(datosLeidos["IdMarca"]))
                    {
                        articulo.Marca.ID_Marca = (int)datosLeidos["IdMarca"];
                    }
                    else
                    {
                        articulo.Marca.ID_Marca = -1;
                    }
                    if (!Convert.IsDBNull(datosLeidos["Marca"]))
                    {
                        articulo.Marca.Nombre = datosLeidos["Marca"].ToString();
                    }
                    else
                    {
                        articulo.Marca.Nombre = "N/A";
                    }
                    if (!Convert.IsDBNull(datosLeidos["IDCategoria"]))
                    {
                        articulo.Categoria.ID_Categoria = (int)datosLeidos["IDCategoria"];
                    }
                    else
                    {
                        articulo.Categoria.ID_Categoria = -1;
                    }
                    if (!Convert.IsDBNull(datosLeidos["Categoria"]))
                    {
                        articulo.Categoria.Nombre = datosLeidos["Categoria"].ToString();
                    }
                    else
                    {
                        articulo.Categoria.Nombre = "N/A";
                    }
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
                datos.ConfigurarConexion();
                datos.DesconectarDB();
            }
        }
        public void AgregarArticulo(Articulo articuloRecibido)
        {
            try
            {
                Datos datos = new Datos();
                datos.ConfigurarConexion();
                datos.AgregarParametro("@CodigoArticulo", articuloRecibido.CodigoArticulo);
                datos.AgregarParametro("@Nombre", articuloRecibido.Nombre);
                datos.AgregarParametro("@Descripcion", articuloRecibido.Descripcion);
                datos.AgregarParametro("@URL", articuloRecibido.URL_Imagen);
                datos.AgregarParametro("@Precio", articuloRecibido.Precio);
                datos.AgregarParametro("@IDMarca", articuloRecibido.Marca.ID_Marca);
                datos.AgregarParametro("@IDCategoria", articuloRecibido.Categoria.ID_Categoria);
                datos.IngresarComando("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values (@CodigoArticulo,@Nombre,@Descripcion,@IDMarca,@IDCategoria,@URL,@Precio)");
                datos.ConectarDB();
                datos.Ejecutar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Datos datos = new Datos();
                datos.ConfigurarConexion();
                datos.DesconectarDB();
            }
        }
        public void ModificarArticulo(Articulo articuloOriginal, Articulo articuloModificado)
        {
            try
            {
                Datos datos = new Datos();
                datos.ConfigurarConexion();
                datos.AgregarParametro("@CodigoArticulo", articuloModificado.CodigoArticulo);
                datos.AgregarParametro("@Nombre", articuloModificado.Nombre);
                datos.AgregarParametro("@Descripcion", articuloModificado.Descripcion);
                datos.AgregarParametro("@URL", articuloModificado.URL_Imagen);
                datos.AgregarParametro("@Precio", articuloModificado.Precio);
                datos.AgregarParametro("@IDMarca", articuloModificado.Marca.ID_Marca);
                datos.AgregarParametro("@IDCategoria", articuloModificado.Categoria.ID_Categoria);
                datos.AgregarParametro("@CodigoArticuloOriginal", articuloModificado.CodigoArticulo);
                datos.IngresarComando("UPDATE ARTICULOS SET Codigo = @CodigoArticulo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IDMarca, IdCategoria = @IDCategoria, ImagenUrl = @URL, Precio = @Precio WHERE Codigo = @CodigoArticuloOriginal");
                datos.ConectarDB();
                datos.Ejecutar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Datos datos = new Datos();
                datos.ConfigurarConexion();
                datos.DesconectarDB();
            }
        }
        public void EliminarArticulo(Articulo articulo)
        {
            try
            {
                Datos datos = new Datos();
                datos.ConfigurarConexion();
                datos.AgregarParametro("@CodigoArticulo", articulo.CodigoArticulo);
                datos.AgregarParametro("@Nombre", articulo.Nombre);
                datos.AgregarParametro("@Descripcion", articulo.Descripcion);
                datos.AgregarParametro("@URL", articulo.URL_Imagen);
                datos.AgregarParametro("@Precio", articulo.Precio);
                datos.AgregarParametro("@IDMarca", articulo.Marca.ID_Marca);
                datos.AgregarParametro("@IDCategoria", articulo.Categoria.ID_Categoria);
                datos.AgregarParametro("@CodigoArticuloOriginal", articulo.CodigoArticulo);
                datos.IngresarComando("DELETE FROM ARTICULOS WHERE Codigo = @CodigoArticulo AND Nombre = @Nombre AND Descripcion = @Descripcion AND IdMarca = @IDMarca AND IdCategoria = @IDCategoria AND ImagenUrl = @URL AND Precio = @Precio");
                datos.ConectarDB();
                datos.Ejecutar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Datos datos = new Datos();
                datos.ConfigurarConexion();
                datos.DesconectarDB();
            }
        }
        public List<Marca> ListarMarcas()
        {
            List<Marca> listado = new List<Marca>();
            try
            {
                Datos datos = new Datos();
                datos.ConfigurarConexion();
                datos.IngresarComando("SELECT Id, Descripcion FROM MARCAS");
                datos.ConectarDB();
                datos.PrepararLectura();
                SqlDataReader datosLeidos;
                Marca marca;
                while (datos.Leer())
                {
                    datosLeidos = datos.Lectura();
                    marca = new Marca();
                    marca.ID_Marca = (int)datosLeidos["Id"];
                    marca.Nombre = datosLeidos["Descripcion"].ToString();
                    listado.Add(marca);
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
                datos.ConfigurarConexion();
                datos.DesconectarDB();
            }
        }
        public List<Categoria> ListarCategorias()
        {
            List<Categoria> listado = new List<Categoria>();
            try
            {
                Datos datos = new Datos();
                datos.ConfigurarConexion();
                datos.IngresarComando("SELECT Id, Descripcion FROM CATEGORIAS");
                datos.ConectarDB();
                datos.PrepararLectura();
                SqlDataReader datosLeidos;
                Categoria categoria;
                while (datos.Leer())
                {
                    datosLeidos = datos.Lectura();
                    categoria = new Categoria();
                    categoria.ID_Categoria = (int)datosLeidos["Id"];
                    categoria.Nombre = datosLeidos["Descripcion"].ToString();
                    listado.Add(categoria);
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
                datos.ConfigurarConexion();
                datos.DesconectarDB();
            }
        }
    }
}

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
                datos.IngresarComando("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, M.Descripcion as [Marca], A.IdCategoria, C.Descripcion as [Categoria], A.ImagenUrl, A.Precio FROM ARTICULOS as A left join CATEGORIAS as C on A.IdCategoria = C.Id left join MARCAS as M on A.IdMarca = M.Id");
                datos.ConectarDB();
                datos.PrepararLectura();
                SqlDataReader datosLeidos;
                Articulo articulo;
                while (datos.Leer())
                {
                    datosLeidos = datos.Lectura();
                    articulo = new Articulo
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

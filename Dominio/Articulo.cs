﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public string CodigoArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string URL_Imagen { get; set; }
        public decimal Precio { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public Articulo()
        {
            Marca marca = new Marca();
            Categoria categoria = new Categoria();
            this.Marca = marca;
            this.Categoria = categoria;
        }
    }
}

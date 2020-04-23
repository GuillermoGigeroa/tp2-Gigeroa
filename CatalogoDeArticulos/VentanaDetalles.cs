using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoDeArticulos
{
    public partial class frmVentanaDetalles : Form
    {
        public frmVentanaDetalles()
        {
            InitializeComponent();
        }
        public void CargarDetalles(Articulo articulo)
        {
            try
            {
                imgArticulo.ImageLocation = articulo.URL_Imagen;
                txtCodigo.Text = articulo.CodigoArticulo;
                txtNombre.Text = articulo.Nombre;
                txtDescripcion.Text = articulo.Descripcion;
                txtMarca.Text = articulo.Marca.Nombre;
                txtCategoria.Text = articulo.Categoria.Nombre;
                txtPrecio.Text = Convert.ToDouble(articulo.Precio).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

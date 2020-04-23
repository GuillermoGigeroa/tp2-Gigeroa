using Dominio;
using Negocio;
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
    public partial class frmAgregar : Form
    {
        Articulo articuloRecibido;
        public frmAgregar()
        {
            InitializeComponent();
            articuloRecibido = new Articulo();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
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
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo articulo = new Articulo();
                articulo.CodigoArticulo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.URL_Imagen = txtURL.Text;
                articulo.Precio = Convert.ToDecimal(txtPrecioEntero.Text+","+txtPrecioCentavos.Text);
                articulo.Marca = (Marca)cboMarcas.SelectedItem;
                articulo.Categoria = (Categoria)cboCategorias.SelectedItem;
                NegocioCatalogo negocio = new NegocioCatalogo();
                if (lblAccion.Text == "Modificar artículo")
                {
                    negocio.ModificarArticulo(articuloRecibido, articulo);
                }
                else
                {
                    negocio.AgregarArticulo(articulo);
                }
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void frmAgregar_Load(object sender, EventArgs e)
        {
            try
            {
                NegocioCatalogo negocio = new NegocioCatalogo();
                cboMarcas.DataSource = negocio.ListarMarcas();
                cboCategorias.DataSource = negocio.ListarCategorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void txtPrecioEntero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void txtPrecioCentavos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }
        public void ConvertirEnModificarArticulo(Articulo articulo)
        {
            articuloRecibido = articulo;
            lblAccion.Text = "Modificar artículo";
            Text = "Modificar artículo";
            txtCodigo.Text = articulo.CodigoArticulo;
            txtNombre.Text = articulo.Nombre;
            txtDescripcion.Text = articulo.Descripcion;
            //TODO Ver, porque esto no funciona
            //cboMarcas.Text = articulo.Marca.Nombre;
            cboMarcas.SelectedText = articulo.Marca.Nombre;
            //TODO Ver, porque esto no funciona
            cboCategorias.SelectedText = articulo.Categoria.Nombre;
            txtURL.Text = articulo.URL_Imagen;
            txtPrecioEntero.Text = ((int)articulo.Precio).ToString();
            txtPrecioCentavos.Text = ((int)((articulo.Precio - Math.Truncate(articulo.Precio))*1000)).ToString();
            btnAgregar.Text = "&Modificar";
        }
    }
}

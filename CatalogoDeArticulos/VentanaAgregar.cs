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
                if (ComprobarSiEstaVacio(txtCodigo)){MessageBox.Show("Hay uno o más campos vacíos.");return;}
                if (ComprobarSiEstaVacio(txtNombre)){MessageBox.Show("Hay uno o más campos vacíos.");return;}
                if (ComprobarSiEstaVacio(txtDescripcion)){MessageBox.Show("Hay uno o más campos vacíos.");return;}
                if (ComprobarSiEstaVacio(txtURL)){MessageBox.Show("Hay uno o más campos vacíos.");return;}
                if (ComprobarSiEstaVacio(txtPrecioEntero)){MessageBox.Show("Hay uno o más campos vacíos.");return;}
                if (ComprobarSiEstaVacio(txtPrecioCentavos)){MessageBox.Show("Hay uno o más campos vacíos.");return;}
                if (cboMarcas.SelectedText == "Marca"){MessageBox.Show("La marca cargada no existe."); return; }
                if (cboCategorias.SelectedText == "Categoría"){MessageBox.Show("La categoría cargada no existe."); return; }
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
        private bool ComprobarSiEstaVacio(TextBox textBox)
        {
            if (textBox.Text == "" || textBox.Text == " " || textBox.Text == "  " || textBox.Text == "   " || textBox.Text == "    " || textBox.Text == "     " || textBox.Text == "      ")
            {
                textBox.BackColor = Color.Red;
                textBox.ForeColor = Color.White;
                return true;
            }
            else
            {
                textBox.BackColor = System.Drawing.SystemColors.Control;
                return false;
            }
        }
        private void frmAgregar_Load(object sender, EventArgs e)
        {
            try
            {
                NegocioCatalogo negocio = new NegocioCatalogo();
                cboMarcas.DisplayMember = "Nombre";
                cboMarcas.ValueMember = "ID_Marca";
                cboMarcas.DataSource = negocio.ListarMarcas();
                cboCategorias.DisplayMember = "Nombre";
                cboCategorias.ValueMember = "ID_Categoria";
                cboCategorias.DataSource = negocio.ListarCategorias();
                cboMarcas.AutoCompleteMode = AutoCompleteMode.Append;
                cboMarcas.DropDownStyle = ComboBoxStyle.DropDown;
                cboMarcas.AutoCompleteSource = AutoCompleteSource.ListItems;
                cboCategorias.AutoCompleteMode = AutoCompleteMode.Append;
                cboCategorias.DropDownStyle = ComboBoxStyle.DropDown;
                cboCategorias.AutoCompleteSource = AutoCompleteSource.ListItems;
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
            try
            {
                articuloRecibido = articulo;
                lblAccion.Text = "Modificar artículo";
                Text = "Modificar artículo";
                txtCodigo.Text = articulo.CodigoArticulo;
                txtNombre.Text = articulo.Nombre;
                txtDescripcion.Text = articulo.Descripcion;
                cboMarcas.SelectedValue = articulo.Marca.ID_Marca;
                cboCategorias.SelectedValue = articulo.Categoria.ID_Categoria;
                txtURL.Text = articulo.URL_Imagen;
                txtPrecioEntero.Text = ((int)articulo.Precio).ToString();
                txtPrecioCentavos.Text = ((int)((articulo.Precio - Math.Truncate(articulo.Precio))*1000)).ToString();
                btnAgregar.Text = "&Modificar";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void cboMarcas_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar != 00) e.Handled = true;
        }
        private void cboCategorias_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar != 00) e.Handled = true;
        }
    }
}

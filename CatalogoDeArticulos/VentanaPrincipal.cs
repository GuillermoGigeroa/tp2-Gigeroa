using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace CatalogoDeArticulos
{
    public partial class frmVentanaPrincipal : Form
    {
        public frmVentanaPrincipal()
        {
            InitializeComponent();
        }
        public void CargarDGV()
        {
            try
            {
                NegocioCatalogo negocio = new NegocioCatalogo();
                dgvListaDeArticulos.DataSource = negocio.ListarArticulos();
                dgvListaDeArticulos.Columns[0].Visible = false;//Oculto la columna que tiene el ID del artículo
                dgvListaDeArticulos.Columns[4].Visible = false;//Oculto la columna que tiene la URL de la imagen
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void frmVentanaPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                frmVentanaDetalles detalle = new frmVentanaDetalles();
                Articulo articulo = new Articulo();
                articulo = (Articulo)dgvListaDeArticulos.CurrentRow.DataBoundItem;
                detalle.CargarDetalles(articulo);
                detalle.ShowDialog();
                CargarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                frmConfirmar confirmar = new frmConfirmar();
                Articulo articulo = new Articulo();
                articulo = (Articulo)dgvListaDeArticulos.CurrentRow.DataBoundItem;
                confirmar.CargarElementoParaEliminar(articulo);
                confirmar.ShowDialog();
                CargarDGV();
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
                frmAgregar agregar = new frmAgregar();
                agregar.ShowDialog();
                CargarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                frmAgregar modificar = new frmAgregar();
                Articulo articulo = new Articulo();
                articulo = (Articulo)dgvListaDeArticulos.CurrentRow.DataBoundItem;
                modificar.ConvertirEnModificarArticulo(articulo);
                modificar.ShowDialog();
                CargarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void txtBuscarCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void txtBuscarNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void txtBuscarMarca_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}

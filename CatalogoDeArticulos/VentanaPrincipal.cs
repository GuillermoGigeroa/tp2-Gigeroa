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

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            articulo = (Articulo)dgvListaDeArticulos.CurrentRow.DataBoundItem;
            //TODO Falta terminar este método
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar agregar = new frmAgregar();
            agregar.ShowDialog();
            CargarDGV();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmAgregar modificar = new frmAgregar();
            Articulo articulo = new Articulo();
            articulo = (Articulo)dgvListaDeArticulos.CurrentRow.DataBoundItem;
            modificar.ConvertirEnModificarArticulo(articulo);
            modificar.ShowDialog();
            CargarDGV();
        }
    }
}

using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CatalogoDeArticulos
{
    public partial class frmVentanaPrincipal : Form
    {
        private List<Articulo> listaDeArticulos;
        private List<Articulo> listaFiltrada;
        public frmVentanaPrincipal()
        {
            InitializeComponent();
        }
        public void CargarDGV()
        {
            try
            {
                NegocioCatalogo negocio = new NegocioCatalogo();
                listaDeArticulos = negocio.ListarArticulos();
                dgvListaDeArticulos.DataSource = listaDeArticulos;
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
                if (dgvListaDeArticulos.CurrentRow == null)
                {
                    MessageBox.Show("No se ha seleccionado ningún elemento.");
                    return;
                }
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
                if (dgvListaDeArticulos.CurrentRow == null)
                {
                    MessageBox.Show("No se ha seleccionado ningún elemento.");
                    return;
                }
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
                Articulo articulo = new Articulo();
                if(dgvListaDeArticulos.CurrentRow == null)
                {
                    MessageBox.Show("No se ha seleccionado ningún elemento.");
                    return;
                }
                articulo = (Articulo)dgvListaDeArticulos.CurrentRow.DataBoundItem;
                frmAgregar modificar = new frmAgregar(articulo);
                modificar.ShowDialog();
                CargarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtBuscarCodigo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Articulo> listaFiltrada;
                if (txtBuscarCodigo.Text == "")
                {
                    listaFiltrada = listaDeArticulos;
                }
                else
                {
                    listaFiltrada = listaDeArticulos.FindAll(articulo => articulo.CodigoArticulo.ToLower().Contains(txtBuscarCodigo.Text.Trim().ToLower()));
                }
                dgvListaDeArticulos.DataSource = listaFiltrada;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Articulo> listaFiltrada;
                if (txtBuscarNombre.Text == "")
                {
                    listaFiltrada = listaDeArticulos;
                }
                else
                {
                    listaFiltrada = listaDeArticulos.FindAll(articulo => articulo.Nombre.ToLower().Contains(txtBuscarNombre.Text.Trim().ToLower()));
                }
                dgvListaDeArticulos.DataSource = listaFiltrada;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void txtBuscarMarca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Articulo> listaFiltrada;
                if (txtBuscarMarca.Text == "")
                {
                    listaFiltrada = listaDeArticulos;
                }
                else
                {
                    listaFiltrada = listaDeArticulos.FindAll(articulo => articulo.Marca.Nombre.ToLower().Contains(txtBuscarMarca.Text.Trim().ToLower()));
                }
                dgvListaDeArticulos.DataSource = listaFiltrada;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Articulo> listaFiltrada;
                if (txtBuscarCategoria.Text == "")
                {
                    listaFiltrada = listaDeArticulos;
                }
                else
                {
                    listaFiltrada = listaDeArticulos.FindAll(articulo => articulo.Categoria.Nombre.ToLower().Contains(txtBuscarCategoria.Text.Trim().ToLower()));
                }
                dgvListaDeArticulos.DataSource = listaFiltrada;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void imgBorrarCodigo_Click(object sender, EventArgs e)
        {
            txtBuscarCodigo.Text = "";
        }
        private void imgBorrarNombre_Click(object sender, EventArgs e)
        {
            txtBuscarNombre.Text = "";
        }
        private void imgBorrarMarcas_Click(object sender, EventArgs e)
        {
            txtBuscarMarca.Text = "";
        }
        private void imgBorrarCategorias_Click(object sender, EventArgs e)
        {
            txtBuscarCategoria.Text = "";
        }
        private void txtBuscarCodigo_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscarCodigo.Enabled = true;
            txtBuscarNombre.Text = "";
            txtBuscarMarca.Text = "";
            txtBuscarCategoria.Text = "";
        }
        private void txtBuscarNombre_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscarNombre.Enabled = true;
            txtBuscarCodigo.Text = "";
            txtBuscarMarca.Text = "";
            txtBuscarCategoria.Text = "";
        }

        private void txtBuscarMarca_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscarCodigo.Text = "";
            txtBuscarNombre.Text = "";
            txtBuscarCategoria.Text = "";
        }

        private void txtBuscarCategoria_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscarCategoria.Enabled = true;
            txtBuscarCodigo.Text = "";
            txtBuscarNombre.Text = "";
            txtBuscarMarca.Text = "";
        }
    }
}

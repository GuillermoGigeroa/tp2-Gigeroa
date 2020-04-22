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
using Negocio;

namespace CatalogoDeArticulos
{
    public partial class frmConfirmar : Form
    {
        public frmConfirmar()
        {
            InitializeComponent();
        }
        private void frmConfirmar_Load(object sender, EventArgs e)
        {

        }
        public void CargarElementoParaEliminar(Articulo articulo)
        {
            try
            {
                List<Articulo> lista = new List<Articulo>();
                lista.Add(articulo);
                dgvListaParaEliminar.DataSource = lista;
                dgvListaParaEliminar.Columns[0].Visible = false;//Oculto la columna que tiene el ID del artículo
                dgvListaParaEliminar.Columns[4].Visible = false;//Oculto la columna que tiene la URL de la imagen
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            NegocioCatalogo negocio = new NegocioCatalogo();
            Articulo articulo = new Articulo();
            articulo = (Articulo)dgvListaParaEliminar.CurrentRow.DataBoundItem;
            negocio.EliminarArticulo(articulo);
            Dispose();
        }
    }
}

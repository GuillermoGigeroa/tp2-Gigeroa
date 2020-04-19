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
        private void CargarDGV()
        {
            NegocioCatalogo negocio = new NegocioCatalogo();
            dgvListaDeArticulos.DataSource = negocio.ListarArticulos();
        }
        private void frmVentanaPrincipal_Load(object sender, EventArgs e)
        {
            CargarDGV();
        }
    }
}

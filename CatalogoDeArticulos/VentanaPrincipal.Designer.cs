namespace CatalogoDeArticulos
{
    partial class frmVentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentanaPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvListaDeArticulos = new System.Windows.Forms.DataGridView();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtBuscarCategoria = new System.Windows.Forms.TextBox();
            this.txtBuscarMarca = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtBuscarCodigo = new System.Windows.Forms.TextBox();
            this.grupoFiltros = new System.Windows.Forms.GroupBox();
            this.imgBorrarCodigo = new System.Windows.Forms.PictureBox();
            this.imgIcono = new System.Windows.Forms.PictureBox();
            this.imgBorrarNombre = new System.Windows.Forms.PictureBox();
            this.imgBorrarMarcas = new System.Windows.Forms.PictureBox();
            this.imgBorrarCategorias = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeArticulos)).BeginInit();
            this.grupoFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBorrarCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBorrarNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBorrarMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBorrarCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Administración";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "de artículos";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(12, 328);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 39);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(12, 261);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(117, 39);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(12, 216);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(117, 39);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvListaDeArticulos
            // 
            this.dgvListaDeArticulos.AllowUserToAddRows = false;
            this.dgvListaDeArticulos.AllowUserToDeleteRows = false;
            this.dgvListaDeArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaDeArticulos.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvListaDeArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListaDeArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDeArticulos.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.dgvListaDeArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListaDeArticulos.Location = new System.Drawing.Point(143, 131);
            this.dgvListaDeArticulos.MultiSelect = false;
            this.dgvListaDeArticulos.Name = "dgvListaDeArticulos";
            this.dgvListaDeArticulos.ReadOnly = true;
            this.dgvListaDeArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaDeArticulos.ShowCellErrors = false;
            this.dgvListaDeArticulos.ShowCellToolTips = false;
            this.dgvListaDeArticulos.ShowEditingIcon = false;
            this.dgvListaDeArticulos.ShowRowErrors = false;
            this.dgvListaDeArticulos.Size = new System.Drawing.Size(645, 307);
            this.dgvListaDeArticulos.TabIndex = 0;
            // 
            // btnDetalle
            // 
            this.btnDetalle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetalle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalle.Location = new System.Drawing.Point(12, 373);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(117, 39);
            this.btnDetalle.TabIndex = 4;
            this.btnDetalle.Text = "&Ver detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Trajan Pro", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(201, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(547, 51);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Catálogo de artículos";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(370, 14);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(63, 19);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marcas";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(519, 14);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(99, 19);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categorías";
            // 
            // txtBuscarCategoria
            // 
            this.txtBuscarCategoria.Location = new System.Drawing.Point(494, 37);
            this.txtBuscarCategoria.MaxLength = 24;
            this.txtBuscarCategoria.Name = "txtBuscarCategoria";
            this.txtBuscarCategoria.Size = new System.Drawing.Size(145, 23);
            this.txtBuscarCategoria.TabIndex = 7;
            this.txtBuscarCategoria.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBuscarCategoria_MouseClick);
            this.txtBuscarCategoria.TextChanged += new System.EventHandler(this.txtCategoria_TextChanged);
            // 
            // txtBuscarMarca
            // 
            this.txtBuscarMarca.Location = new System.Drawing.Point(332, 37);
            this.txtBuscarMarca.MaxLength = 24;
            this.txtBuscarMarca.Name = "txtBuscarMarca";
            this.txtBuscarMarca.Size = new System.Drawing.Size(145, 23);
            this.txtBuscarMarca.TabIndex = 6;
            this.txtBuscarMarca.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBuscarMarca_MouseClick);
            this.txtBuscarMarca.TextChanged += new System.EventHandler(this.txtBuscarMarca_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(213, 14);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 19);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Location = new System.Drawing.Point(170, 37);
            this.txtBuscarNombre.MaxLength = 24;
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(145, 23);
            this.txtBuscarNombre.TabIndex = 6;
            this.txtBuscarNombre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBuscarNombre_MouseClick);
            this.txtBuscarNombre.TextChanged += new System.EventHandler(this.txtBuscarNombre_TextChanged);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(45, 14);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(63, 19);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Codigo";
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Location = new System.Drawing.Point(8, 37);
            this.txtBuscarCodigo.MaxLength = 24;
            this.txtBuscarCodigo.Name = "txtBuscarCodigo";
            this.txtBuscarCodigo.Size = new System.Drawing.Size(145, 23);
            this.txtBuscarCodigo.TabIndex = 5;
            this.txtBuscarCodigo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBuscarCodigo_MouseClick);
            this.txtBuscarCodigo.TextChanged += new System.EventHandler(this.txtBuscarCodigo_TextChanged);
            // 
            // grupoFiltros
            // 
            this.grupoFiltros.Controls.Add(this.imgBorrarCategorias);
            this.grupoFiltros.Controls.Add(this.imgBorrarMarcas);
            this.grupoFiltros.Controls.Add(this.imgBorrarNombre);
            this.grupoFiltros.Controls.Add(this.imgBorrarCodigo);
            this.grupoFiltros.Controls.Add(this.txtBuscarCodigo);
            this.grupoFiltros.Controls.Add(this.txtBuscarNombre);
            this.grupoFiltros.Controls.Add(this.txtBuscarMarca);
            this.grupoFiltros.Controls.Add(this.txtBuscarCategoria);
            this.grupoFiltros.Controls.Add(this.lblCategoria);
            this.grupoFiltros.Controls.Add(this.lblCodigo);
            this.grupoFiltros.Controls.Add(this.lblNombre);
            this.grupoFiltros.Controls.Add(this.lblMarca);
            this.grupoFiltros.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoFiltros.Location = new System.Drawing.Point(138, 66);
            this.grupoFiltros.Name = "grupoFiltros";
            this.grupoFiltros.Size = new System.Drawing.Size(658, 63);
            this.grupoFiltros.TabIndex = 6;
            this.grupoFiltros.TabStop = false;
            this.grupoFiltros.Text = "Filtros";
            // 
            // imgBorrarCodigo
            // 
            this.imgBorrarCodigo.Image = global::CatalogoDeArticulos.Properties.Resources.cruz_entrecruzada;
            this.imgBorrarCodigo.Location = new System.Drawing.Point(153, 38);
            this.imgBorrarCodigo.Name = "imgBorrarCodigo";
            this.imgBorrarCodigo.Size = new System.Drawing.Size(17, 20);
            this.imgBorrarCodigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBorrarCodigo.TabIndex = 8;
            this.imgBorrarCodigo.TabStop = false;
            this.imgBorrarCodigo.Click += new System.EventHandler(this.imgBorrarCodigo_Click);
            // 
            // imgIcono
            // 
            this.imgIcono.Image = global::CatalogoDeArticulos.Properties.Resources.dinero;
            this.imgIcono.Location = new System.Drawing.Point(9, 10);
            this.imgIcono.Name = "imgIcono";
            this.imgIcono.Size = new System.Drawing.Size(120, 120);
            this.imgIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgIcono.TabIndex = 4;
            this.imgIcono.TabStop = false;
            // 
            // imgBorrarNombre
            // 
            this.imgBorrarNombre.Image = global::CatalogoDeArticulos.Properties.Resources.cruz_entrecruzada;
            this.imgBorrarNombre.Location = new System.Drawing.Point(315, 38);
            this.imgBorrarNombre.Name = "imgBorrarNombre";
            this.imgBorrarNombre.Size = new System.Drawing.Size(17, 20);
            this.imgBorrarNombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBorrarNombre.TabIndex = 8;
            this.imgBorrarNombre.TabStop = false;
            this.imgBorrarNombre.Click += new System.EventHandler(this.imgBorrarNombre_Click);
            // 
            // imgBorrarMarcas
            // 
            this.imgBorrarMarcas.Image = global::CatalogoDeArticulos.Properties.Resources.cruz_entrecruzada;
            this.imgBorrarMarcas.Location = new System.Drawing.Point(477, 38);
            this.imgBorrarMarcas.Name = "imgBorrarMarcas";
            this.imgBorrarMarcas.Size = new System.Drawing.Size(17, 20);
            this.imgBorrarMarcas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBorrarMarcas.TabIndex = 8;
            this.imgBorrarMarcas.TabStop = false;
            this.imgBorrarMarcas.Click += new System.EventHandler(this.imgBorrarMarcas_Click);
            // 
            // imgBorrarCategorias
            // 
            this.imgBorrarCategorias.Image = global::CatalogoDeArticulos.Properties.Resources.cruz_entrecruzada;
            this.imgBorrarCategorias.Location = new System.Drawing.Point(639, 38);
            this.imgBorrarCategorias.Name = "imgBorrarCategorias";
            this.imgBorrarCategorias.Size = new System.Drawing.Size(17, 20);
            this.imgBorrarCategorias.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBorrarCategorias.TabIndex = 8;
            this.imgBorrarCategorias.TabStop = false;
            this.imgBorrarCategorias.Click += new System.EventHandler(this.imgBorrarCategorias_Click);
            // 
            // frmVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grupoFiltros);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.imgIcono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvListaDeArticulos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "frmVentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo de artículos";
            this.Load += new System.EventHandler(this.frmVentanaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeArticulos)).EndInit();
            this.grupoFiltros.ResumeLayout(false);
            this.grupoFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBorrarCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBorrarNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBorrarMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBorrarCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgIcono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvListaDeArticulos;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtBuscarCategoria;
        private System.Windows.Forms.TextBox txtBuscarMarca;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
        private System.Windows.Forms.GroupBox grupoFiltros;
        private System.Windows.Forms.PictureBox imgBorrarCodigo;
        private System.Windows.Forms.PictureBox imgBorrarCategorias;
        private System.Windows.Forms.PictureBox imgBorrarMarcas;
        private System.Windows.Forms.PictureBox imgBorrarNombre;
    }
}


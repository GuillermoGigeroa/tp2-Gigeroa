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
            this.dgvListaDeArticulos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imgIcono = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaDeArticulos
            // 
            this.dgvListaDeArticulos.AllowUserToAddRows = false;
            this.dgvListaDeArticulos.AllowUserToDeleteRows = false;
            this.dgvListaDeArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaDeArticulos.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvListaDeArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDeArticulos.Location = new System.Drawing.Point(143, 131);
            this.dgvListaDeArticulos.Name = "dgvListaDeArticulos";
            this.dgvListaDeArticulos.ReadOnly = true;
            this.dgvListaDeArticulos.Size = new System.Drawing.Size(645, 307);
            this.dgvListaDeArticulos.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(12, 225);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(117, 39);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(12, 270);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(117, 39);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // Eliminar
            // 
            this.Eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Eliminar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.Location = new System.Drawing.Point(12, 315);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(117, 39);
            this.Eliminar.TabIndex = 2;
            this.Eliminar.Text = "&Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Administración";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "de Artículos";
            // 
            // frmVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgIcono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Eliminar);
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
            ((System.ComponentModel.ISupportInitialize)(this.imgIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaDeArticulos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgIcono;
        private System.Windows.Forms.Label label2;
    }
}


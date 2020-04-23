namespace CatalogoDeArticulos
{
    partial class frmConfirmar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfirmar));
            this.dgvListaParaEliminar = new System.Windows.Forms.DataGridView();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.imgIcono = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaParaEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaParaEliminar
            // 
            this.dgvListaParaEliminar.AllowUserToAddRows = false;
            this.dgvListaParaEliminar.AllowUserToDeleteRows = false;
            this.dgvListaParaEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvListaParaEliminar.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvListaParaEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaParaEliminar.Location = new System.Drawing.Point(12, 29);
            this.dgvListaParaEliminar.Name = "dgvListaParaEliminar";
            this.dgvListaParaEliminar.ReadOnly = true;
            this.dgvListaParaEliminar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaParaEliminar.Size = new System.Drawing.Size(645, 44);
            this.dgvListaParaEliminar.TabIndex = 1;
            // 
            // lblPregunta
            // 
            this.lblPregunta.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.Location = new System.Drawing.Point(183, 4);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(310, 22);
            this.lblPregunta.TabIndex = 7;
            this.lblPregunta.Text = "¿Desea eliminar este artículo?";
            this.lblPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Esta acción es irreversible.";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConfirmar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(153, 105);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(117, 39);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "&Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(416, 105);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 39);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Canc&elar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // imgIcono
            // 
            this.imgIcono.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.imgIcono.Image = global::CatalogoDeArticulos.Properties.Resources.dinero;
            this.imgIcono.Location = new System.Drawing.Point(307, 74);
            this.imgIcono.Name = "imgIcono";
            this.imgIcono.Size = new System.Drawing.Size(70, 70);
            this.imgIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgIcono.TabIndex = 11;
            this.imgIcono.TabStop = false;
            // 
            // frmConfirmar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(669, 147);
            this.Controls.Add(this.imgIcono);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.dgvListaParaEliminar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(685, 186);
            this.MinimumSize = new System.Drawing.Size(685, 186);
            this.Name = "frmConfirmar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmar";
            this.Load += new System.EventHandler(this.frmConfirmar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaParaEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaParaEliminar;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox imgIcono;
    }
}
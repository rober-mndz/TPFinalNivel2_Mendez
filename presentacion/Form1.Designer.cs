namespace presentacion
{
    partial class Form1
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pbArticulo = new System.Windows.Forms.PictureBox();
            this.LabelCodigo = new System.Windows.Forms.Label();
            this.LabelNombre = new System.Windows.Forms.Label();
            this.LabelDescripcion = new System.Windows.Forms.Label();
            this.LabelMarca = new System.Windows.Forms.Label();
            this.LabelCategoria = new System.Windows.Forms.Label();
            this.LabelPrecio = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 103);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(724, 282);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBusqueda.Location = new System.Drawing.Point(12, 77);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(329, 20);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.Text = "Buscar...";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(636, 565);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 41);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar Articulo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(530, 565);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 41);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar Articulo";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminar.Location = new System.Drawing.Point(12, 564);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 41);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar Articulo";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // pbArticulo
            // 
            this.pbArticulo.Location = new System.Drawing.Point(12, 391);
            this.pbArticulo.Name = "pbArticulo";
            this.pbArticulo.Size = new System.Drawing.Size(166, 166);
            this.pbArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArticulo.TabIndex = 5;
            this.pbArticulo.TabStop = false;
            // 
            // LabelCodigo
            // 
            this.LabelCodigo.AutoSize = true;
            this.LabelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCodigo.Location = new System.Drawing.Point(184, 391);
            this.LabelCodigo.Name = "LabelCodigo";
            this.LabelCodigo.Size = new System.Drawing.Size(76, 24);
            this.LabelCodigo.TabIndex = 6;
            this.LabelCodigo.Text = "Codigo:";
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNombre.Location = new System.Drawing.Point(184, 415);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(84, 24);
            this.LabelNombre.TabIndex = 7;
            this.LabelNombre.Text = "Nombre:";
            // 
            // LabelDescripcion
            // 
            this.LabelDescripcion.AutoSize = true;
            this.LabelDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDescripcion.Location = new System.Drawing.Point(184, 439);
            this.LabelDescripcion.Name = "LabelDescripcion";
            this.LabelDescripcion.Size = new System.Drawing.Size(115, 24);
            this.LabelDescripcion.TabIndex = 8;
            this.LabelDescripcion.Text = "Descripcion:";
            // 
            // LabelMarca
            // 
            this.LabelMarca.AutoSize = true;
            this.LabelMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMarca.Location = new System.Drawing.Point(184, 463);
            this.LabelMarca.Name = "LabelMarca";
            this.LabelMarca.Size = new System.Drawing.Size(67, 24);
            this.LabelMarca.TabIndex = 9;
            this.LabelMarca.Text = "Marca:";
            // 
            // LabelCategoria
            // 
            this.LabelCategoria.AutoSize = true;
            this.LabelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCategoria.Location = new System.Drawing.Point(184, 487);
            this.LabelCategoria.Name = "LabelCategoria";
            this.LabelCategoria.Size = new System.Drawing.Size(95, 24);
            this.LabelCategoria.TabIndex = 10;
            this.LabelCategoria.Text = "Categoria:";
            // 
            // LabelPrecio
            // 
            this.LabelPrecio.AutoSize = true;
            this.LabelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrecio.Location = new System.Drawing.Point(184, 511);
            this.LabelPrecio.Name = "LabelPrecio";
            this.LabelPrecio.Size = new System.Drawing.Size(69, 24);
            this.LabelPrecio.TabIndex = 11;
            this.LabelPrecio.Text = "Precio:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(259, 391);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(21, 25);
            this.lblCodigo.TabIndex = 12;
            this.lblCodigo.Text = "c";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(266, 415);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(23, 25);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "n";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(296, 439);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(23, 25);
            this.lblDescripcion.TabIndex = 14;
            this.lblDescripcion.Text = "n";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(247, 463);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(29, 25);
            this.lblMarca.TabIndex = 15;
            this.lblMarca.Text = "m";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(252, 511);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(24, 25);
            this.lblPrecio.TabIndex = 16;
            this.lblPrecio.Text = "p";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(279, 487);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(37, 25);
            this.lblCategoria.TabIndex = 17;
            this.lblCategoria.Text = "cat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 626);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.LabelPrecio);
            this.Controls.Add(this.LabelCategoria);
            this.Controls.Add(this.LabelMarca);
            this.Controls.Add(this.LabelDescripcion);
            this.Controls.Add(this.LabelNombre);
            this.Controls.Add(this.LabelCodigo);
            this.Controls.Add(this.pbArticulo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.dgvArticulos);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Control Stock";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox pbArticulo;
        private System.Windows.Forms.Label LabelCodigo;
        private System.Windows.Forms.Label LabelNombre;
        private System.Windows.Forms.Label LabelDescripcion;
        private System.Windows.Forms.Label LabelMarca;
        private System.Windows.Forms.Label LabelCategoria;
        private System.Windows.Forms.Label LabelPrecio;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCategoria;
    }
}


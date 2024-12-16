namespace Ahora_si
{
    partial class Carrito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carrito));
            buttonPagar = new Button();
            buttonVaciar = new Button();
            buttonCancelar = new Button();
            label1 = new Label();
            dataGridViewCompra = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            CantidadCompra = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Imagen = new DataGridViewImageColumn();
            labelMprecio = new Label();
            labelMnombre = new Label();
            labelMcantidad = new Label();
            labelMid = new Label();
            labelPrecio = new Label();
            labelNombre = new Label();
            labelCantidad = new Label();
            labelId = new Label();
            pictureBoxImagen = new PictureBox();
            buttonBorrarPro = new Button();
            labelMonto = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).BeginInit();
            SuspendLayout();
            // 
            // buttonPagar
            // 
            buttonPagar.BackgroundImage = (Image)resources.GetObject("buttonPagar.BackgroundImage");
            buttonPagar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonPagar.FlatStyle = FlatStyle.Flat;
            buttonPagar.Location = new Point(296, 374);
            buttonPagar.Name = "buttonPagar";
            buttonPagar.Size = new Size(90, 80);
            buttonPagar.TabIndex = 0;
            buttonPagar.UseVisualStyleBackColor = true;
            buttonPagar.Click += buttonPagar_Click;
            // 
            // buttonVaciar
            // 
            buttonVaciar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonVaciar.FlatStyle = FlatStyle.Flat;
            buttonVaciar.Location = new Point(403, 374);
            buttonVaciar.Name = "buttonVaciar";
            buttonVaciar.Size = new Size(118, 27);
            buttonVaciar.TabIndex = 1;
            buttonVaciar.Text = "Vaciar carrito";
            buttonVaciar.UseVisualStyleBackColor = true;
            buttonVaciar.Click += buttonVaciar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackgroundImage = (Image)resources.GetObject("buttonCancelar.BackgroundImage");
            buttonCancelar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.Location = new Point(650, 471);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(71, 68);
            buttonCancelar.TabIndex = 3;
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 18);
            label1.Name = "label1";
            label1.Size = new Size(289, 36);
            label1.TabIndex = 4;
            label1.Text = "Carrito de compras";
            // 
            // dataGridViewCompra
            // 
            dataGridViewCompra.AllowUserToAddRows = false;
            dataGridViewCompra.AllowUserToDeleteRows = false;
            dataGridViewCompra.BackgroundColor = Color.White;
            dataGridViewCompra.BorderStyle = BorderStyle.None;
            dataGridViewCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCompra.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, CantidadCompra, Precio, Imagen });
            dataGridViewCompra.Location = new Point(35, 81);
            dataGridViewCompra.Margin = new Padding(3, 2, 3, 2);
            dataGridViewCompra.Name = "dataGridViewCompra";
            dataGridViewCompra.ReadOnly = true;
            dataGridViewCompra.RowHeadersWidth = 51;
            dataGridViewCompra.Size = new Size(482, 275);
            dataGridViewCompra.TabIndex = 5;
            dataGridViewCompra.SelectionChanged += dataGridViewCompra_SelectionChanged;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 125;
            // 
            // CantidadCompra
            // 
            CantidadCompra.HeaderText = "Cantidad";
            CantidadCompra.MinimumWidth = 6;
            CantidadCompra.Name = "CantidadCompra";
            CantidadCompra.ReadOnly = true;
            CantidadCompra.Width = 125;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 125;
            // 
            // Imagen
            // 
            Imagen.HeaderText = "Imagen";
            Imagen.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Imagen.MinimumWidth = 6;
            Imagen.Name = "Imagen";
            Imagen.ReadOnly = true;
            Imagen.Resizable = DataGridViewTriState.True;
            Imagen.SortMode = DataGridViewColumnSortMode.Automatic;
            Imagen.Width = 125;
            // 
            // labelMprecio
            // 
            labelMprecio.AutoSize = true;
            labelMprecio.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            labelMprecio.Location = new Point(664, 182);
            labelMprecio.Name = "labelMprecio";
            labelMprecio.Size = new Size(0, 18);
            labelMprecio.TabIndex = 33;
            // 
            // labelMnombre
            // 
            labelMnombre.AutoSize = true;
            labelMnombre.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            labelMnombre.Location = new Point(664, 149);
            labelMnombre.Name = "labelMnombre";
            labelMnombre.Size = new Size(0, 18);
            labelMnombre.TabIndex = 32;
            // 
            // labelMcantidad
            // 
            labelMcantidad.AutoSize = true;
            labelMcantidad.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            labelMcantidad.Location = new Point(664, 120);
            labelMcantidad.Name = "labelMcantidad";
            labelMcantidad.Size = new Size(0, 18);
            labelMcantidad.TabIndex = 31;
            // 
            // labelMid
            // 
            labelMid.AutoSize = true;
            labelMid.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            labelMid.Location = new Point(664, 91);
            labelMid.Name = "labelMid";
            labelMid.Size = new Size(0, 18);
            labelMid.TabIndex = 30;
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrecio.Location = new Point(556, 177);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(57, 19);
            labelPrecio.TabIndex = 28;
            labelPrecio.Text = "Precio";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(556, 148);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(73, 19);
            labelNombre.TabIndex = 27;
            labelNombre.Text = "Nombre";
            // 
            // labelCantidad
            // 
            labelCantidad.AutoSize = true;
            labelCantidad.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCantidad.Location = new Point(556, 119);
            labelCantidad.Name = "labelCantidad";
            labelCantidad.Size = new Size(83, 19);
            labelCantidad.TabIndex = 26;
            labelCantidad.Text = "Cantidad";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelId.Location = new Point(556, 91);
            labelId.Name = "labelId";
            labelId.Size = new Size(24, 19);
            labelId.TabIndex = 25;
            labelId.Text = "Id";
            // 
            // pictureBoxImagen
            // 
            pictureBoxImagen.BackColor = Color.Transparent;
            pictureBoxImagen.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxImagen.Enabled = false;
            pictureBoxImagen.Location = new Point(540, 210);
            pictureBoxImagen.Name = "pictureBoxImagen";
            pictureBoxImagen.Size = new Size(147, 150);
            pictureBoxImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImagen.TabIndex = 24;
            pictureBoxImagen.TabStop = false;
            // 
            // buttonBorrarPro
            // 
            buttonBorrarPro.FlatStyle = FlatStyle.Flat;
            buttonBorrarPro.Location = new Point(540, 378);
            buttonBorrarPro.Margin = new Padding(3, 2, 3, 2);
            buttonBorrarPro.Name = "buttonBorrarPro";
            buttonBorrarPro.Size = new Size(147, 48);
            buttonBorrarPro.TabIndex = 35;
            buttonBorrarPro.Text = "Borrar producto seleccionado";
            buttonBorrarPro.UseVisualStyleBackColor = true;
            buttonBorrarPro.Click += buttonBorrarPro_Click;
            // 
            // labelMonto
            // 
            labelMonto.AutoSize = true;
            labelMonto.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            labelMonto.Location = new Point(174, 379);
            labelMonto.Name = "labelMonto";
            labelMonto.Size = new Size(55, 18);
            labelMonto.TabIndex = 37;
            labelMonto.Text = "Monto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(47, 378);
            label3.Name = "label3";
            label3.Size = new Size(121, 19);
            label3.TabIndex = 36;
            label3.Text = "Total a pagar: ";
            // 
            // Carrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(945, 560);
            Controls.Add(labelMonto);
            Controls.Add(label3);
            Controls.Add(buttonBorrarPro);
            Controls.Add(labelMprecio);
            Controls.Add(labelMnombre);
            Controls.Add(labelMcantidad);
            Controls.Add(labelMid);
            Controls.Add(labelPrecio);
            Controls.Add(labelNombre);
            Controls.Add(labelCantidad);
            Controls.Add(labelId);
            Controls.Add(pictureBoxImagen);
            Controls.Add(dataGridViewCompra);
            Controls.Add(label1);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonVaciar);
            Controls.Add(buttonPagar);
            Name = "Carrito";
            Text = "Carrito";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompra).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPagar;
        private Button buttonVaciar;
        private Button buttonCancelar;
        private Label label1;
        private DataGridView dataGridViewCompra;
        private Label labelMprecio;
        private Label labelMnombre;
        private Label labelMcantidad;
        private Label labelMid;
        private Label labelPrecio;
        private Label labelNombre;
        private Label labelCantidad;
        private Label labelId;
        private PictureBox pictureBoxImagen;
        private Button buttonBorrarPro;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn CantidadCompra;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewImageColumn Imagen;
        private Label labelMonto;
        private Label label3;
    }
}
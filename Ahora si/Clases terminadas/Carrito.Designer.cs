﻿namespace Ahora_si
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).BeginInit();
            SuspendLayout();
            // 
            // buttonPagar
            // 
            buttonPagar.BackgroundImage = (Image)resources.GetObject("buttonPagar.BackgroundImage");
            buttonPagar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonPagar.FlatStyle = FlatStyle.Flat;
            buttonPagar.Location = new Point(37, 528);
            buttonPagar.Margin = new Padding(3, 4, 3, 4);
            buttonPagar.Name = "buttonPagar";
            buttonPagar.Size = new Size(103, 107);
            buttonPagar.TabIndex = 0;
            buttonPagar.UseVisualStyleBackColor = true;
            buttonPagar.Click += buttonPagar_Click;
            // 
            // buttonVaciar
            // 
            buttonVaciar.BackgroundImage = (Image)resources.GetObject("buttonVaciar.BackgroundImage");
            buttonVaciar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonVaciar.FlatStyle = FlatStyle.Flat;
            buttonVaciar.Location = new Point(235, 528);
            buttonVaciar.Margin = new Padding(3, 4, 3, 4);
            buttonVaciar.Name = "buttonVaciar";
            buttonVaciar.Size = new Size(75, 104);
            buttonVaciar.TabIndex = 1;
            buttonVaciar.UseVisualStyleBackColor = true;
            buttonVaciar.Click += buttonVaciar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackgroundImage = (Image)resources.GetObject("buttonCancelar.BackgroundImage");
            buttonCancelar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.Location = new Point(150, 659);
            buttonCancelar.Margin = new Padding(3, 4, 3, 4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(81, 91);
            buttonCancelar.TabIndex = 3;
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 9);
            label1.Name = "label1";
            label1.Size = new Size(367, 44);
            label1.TabIndex = 4;
            label1.Text = "Carrito de compras";
            // 
            // dataGridViewCompra
            // 
            dataGridViewCompra.AllowUserToAddRows = false;
            dataGridViewCompra.AllowUserToDeleteRows = false;
            dataGridViewCompra.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCompra.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, CantidadCompra, Precio, Imagen });
            dataGridViewCompra.Location = new Point(54, 81);
            dataGridViewCompra.Name = "dataGridViewCompra";
            dataGridViewCompra.ReadOnly = true;
            dataGridViewCompra.RowHeadersWidth = 51;
            dataGridViewCompra.Size = new Size(446, 367);
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
            labelMprecio.Location = new Point(863, 215);
            labelMprecio.Name = "labelMprecio";
            labelMprecio.Size = new Size(0, 23);
            labelMprecio.TabIndex = 33;
            // 
            // labelMnombre
            // 
            labelMnombre.AutoSize = true;
            labelMnombre.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            labelMnombre.Location = new Point(863, 171);
            labelMnombre.Name = "labelMnombre";
            labelMnombre.Size = new Size(0, 23);
            labelMnombre.TabIndex = 32;
            // 
            // labelMcantidad
            // 
            labelMcantidad.AutoSize = true;
            labelMcantidad.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            labelMcantidad.Location = new Point(863, 132);
            labelMcantidad.Name = "labelMcantidad";
            labelMcantidad.Size = new Size(0, 23);
            labelMcantidad.TabIndex = 31;
            // 
            // labelMid
            // 
            labelMid.AutoSize = true;
            labelMid.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            labelMid.Location = new Point(863, 93);
            labelMid.Name = "labelMid";
            labelMid.Size = new Size(0, 23);
            labelMid.TabIndex = 30;
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrecio.Location = new Point(739, 208);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(71, 23);
            labelPrecio.TabIndex = 28;
            labelPrecio.Text = "Precio";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(739, 169);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(89, 23);
            labelNombre.TabIndex = 27;
            labelNombre.Text = "Nombre";
            // 
            // labelCantidad
            // 
            labelCantidad.AutoSize = true;
            labelCantidad.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCantidad.Location = new Point(739, 131);
            labelCantidad.Name = "labelCantidad";
            labelCantidad.Size = new Size(101, 23);
            labelCantidad.TabIndex = 26;
            labelCantidad.Text = "Cantidad";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelId.Location = new Point(739, 92);
            labelId.Name = "labelId";
            labelId.Size = new Size(29, 23);
            labelId.TabIndex = 25;
            labelId.Text = "Id";
            // 
            // pictureBoxImagen
            // 
            pictureBoxImagen.BackColor = Color.Transparent;
            pictureBoxImagen.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxImagen.Enabled = false;
            pictureBoxImagen.Location = new Point(538, 78);
            pictureBoxImagen.Margin = new Padding(3, 4, 3, 4);
            pictureBoxImagen.Name = "pictureBoxImagen";
            pictureBoxImagen.Size = new Size(168, 200);
            pictureBoxImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImagen.TabIndex = 24;
            pictureBoxImagen.TabStop = false;
            // 
            // buttonBorrarPro
            // 
            buttonBorrarPro.Location = new Point(551, 296);
            buttonBorrarPro.Name = "buttonBorrarPro";
            buttonBorrarPro.Size = new Size(135, 28);
            buttonBorrarPro.TabIndex = 35;
            buttonBorrarPro.Text = "Borrar Producto";
            buttonBorrarPro.UseVisualStyleBackColor = true;
            buttonBorrarPro.Click += buttonBorrarPro_Click;
            // 
            // Carrito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1000, 844);
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
            Margin = new Padding(3, 4, 3, 4);
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
    }
}
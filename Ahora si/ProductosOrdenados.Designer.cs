namespace Ahora_si
{
    partial class ProductosOrdenados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductosOrdenados));
            panel1 = new Panel();
            Cerrar = new Button();
            labelMdescripcion = new Label();
            labelMprecio = new Label();
            labelMnombre = new Label();
            labelMcantidad = new Label();
            labelMid = new Label();
            labelDescripcion = new Label();
            labelPrecio = new Label();
            labelNombre = new Label();
            labelCantidad = new Label();
            labelId = new Label();
            pictureBoxImagen = new PictureBox();
            labelInformacion = new Label();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Imagen = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(Cerrar);
            panel1.Controls.Add(labelMdescripcion);
            panel1.Controls.Add(labelMprecio);
            panel1.Controls.Add(labelMnombre);
            panel1.Controls.Add(labelMcantidad);
            panel1.Controls.Add(labelMid);
            panel1.Controls.Add(labelDescripcion);
            panel1.Controls.Add(labelPrecio);
            panel1.Controls.Add(labelNombre);
            panel1.Controls.Add(labelCantidad);
            panel1.Controls.Add(labelId);
            panel1.Controls.Add(pictureBoxImagen);
            panel1.Controls.Add(labelInformacion);
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1026, 410);
            panel1.TabIndex = 0;
            // 
            // Cerrar
            // 
            Cerrar.BackgroundImage = (Image)resources.GetObject("Cerrar.BackgroundImage");
            Cerrar.BackgroundImageLayout = ImageLayout.Zoom;
            Cerrar.Location = new Point(929, 330);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(69, 68);
            Cerrar.TabIndex = 37;
            Cerrar.UseVisualStyleBackColor = true;
            // 
            // labelMdescripcion
            // 
            labelMdescripcion.AutoSize = true;
            labelMdescripcion.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMdescripcion.Location = new Point(803, 168);
            labelMdescripcion.Name = "labelMdescripcion";
            labelMdescripcion.Size = new Size(0, 18);
            labelMdescripcion.TabIndex = 35;
            // 
            // labelMprecio
            // 
            labelMprecio.AutoSize = true;
            labelMprecio.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            labelMprecio.Location = new Point(793, 136);
            labelMprecio.Name = "labelMprecio";
            labelMprecio.Size = new Size(0, 18);
            labelMprecio.TabIndex = 34;
            // 
            // labelMnombre
            // 
            labelMnombre.AutoSize = true;
            labelMnombre.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            labelMnombre.Location = new Point(793, 106);
            labelMnombre.Name = "labelMnombre";
            labelMnombre.Size = new Size(0, 18);
            labelMnombre.TabIndex = 33;
            // 
            // labelMcantidad
            // 
            labelMcantidad.AutoSize = true;
            labelMcantidad.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            labelMcantidad.Location = new Point(793, 77);
            labelMcantidad.Name = "labelMcantidad";
            labelMcantidad.Size = new Size(0, 18);
            labelMcantidad.TabIndex = 32;
            // 
            // labelMid
            // 
            labelMid.AutoSize = true;
            labelMid.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            labelMid.Location = new Point(793, 48);
            labelMid.Name = "labelMid";
            labelMid.Size = new Size(0, 18);
            labelMid.TabIndex = 31;
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDescripcion.Location = new Point(685, 168);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(100, 19);
            labelDescripcion.TabIndex = 30;
            labelDescripcion.Text = "Descripcion";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrecio.Location = new Point(685, 135);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(57, 19);
            labelPrecio.TabIndex = 29;
            labelPrecio.Text = "Precio";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(685, 106);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(73, 19);
            labelNombre.TabIndex = 28;
            labelNombre.Text = "Nombre";
            // 
            // labelCantidad
            // 
            labelCantidad.AutoSize = true;
            labelCantidad.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCantidad.Location = new Point(685, 77);
            labelCantidad.Name = "labelCantidad";
            labelCantidad.Size = new Size(83, 19);
            labelCantidad.TabIndex = 27;
            labelCantidad.Text = "Cantidad";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelId.Location = new Point(685, 48);
            labelId.Name = "labelId";
            labelId.Size = new Size(24, 19);
            labelId.TabIndex = 26;
            labelId.Text = "Id";
            // 
            // pictureBoxImagen
            // 
            pictureBoxImagen.BackColor = Color.Transparent;
            pictureBoxImagen.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxImagen.Enabled = false;
            pictureBoxImagen.Location = new Point(533, 26);
            pictureBoxImagen.Name = "pictureBoxImagen";
            pictureBoxImagen.Size = new Size(138, 150);
            pictureBoxImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImagen.TabIndex = 25;
            pictureBoxImagen.TabStop = false;
            // 
            // labelInformacion
            // 
            labelInformacion.AutoSize = true;
            labelInformacion.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInformacion.Location = new Point(676, 9);
            labelInformacion.Name = "labelInformacion";
            labelInformacion.Size = new Size(309, 28);
            labelInformacion.TabIndex = 24;
            labelInformacion.Text = "Informacion del producto";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Precio, Cantidad, Imagen });
            dataGridView1.Location = new Point(10, 9);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(503, 392);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
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
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 125;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 125;
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
            // ProductosOrdenados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 410);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProductosOrdenados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductosOrdenados";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Label labelMdescripcion;
        private Label labelMprecio;
        private Label labelMnombre;
        private Label labelMcantidad;
        private Label labelMid;
        private Label labelDescripcion;
        private Label labelPrecio;
        private Label labelNombre;
        private Label labelCantidad;
        private Label labelId;
        private PictureBox pictureBoxImagen;
        private Label labelInformacion;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewImageColumn Imagen;
        private Button Cerrar;
    }
}
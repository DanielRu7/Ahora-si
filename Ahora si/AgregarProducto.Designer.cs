namespace Ahora_si
{
    partial class AgregarProducto
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
            panel1 = new Panel();
            buttonRegresar = new Button();
            buttonAgregar = new Button();
            textBoxCantidad = new TextBox();
            textBoxPrecio = new TextBox();
            textBoxNombre = new TextBox();
            textBoxId = new TextBox();
            pictureBoxImagen = new PictureBox();
            label1 = new Label();
            richTextBoxDescripcion = new RichTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(richTextBoxDescripcion);
            panel1.Controls.Add(buttonRegresar);
            panel1.Controls.Add(buttonAgregar);
            panel1.Controls.Add(textBoxCantidad);
            panel1.Controls.Add(textBoxPrecio);
            panel1.Controls.Add(textBoxNombre);
            panel1.Controls.Add(textBoxId);
            panel1.Controls.Add(pictureBoxImagen);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 484);
            panel1.TabIndex = 0;
            // 
            // buttonRegresar
            // 
            buttonRegresar.Location = new Point(521, 432);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(94, 29);
            buttonRegresar.TabIndex = 7;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(261, 440);
            buttonAgregar.Margin = new Padding(3, 4, 3, 4);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(86, 31);
            buttonAgregar.TabIndex = 6;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += button1_Click;
            // 
            // textBoxCantidad
            // 
            textBoxCantidad.Location = new Point(306, 231);
            textBoxCantidad.Margin = new Padding(3, 4, 3, 4);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.PlaceholderText = "Cantidad";
            textBoxCantidad.Size = new Size(215, 27);
            textBoxCantidad.TabIndex = 4;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(306, 185);
            textBoxPrecio.Margin = new Padding(3, 4, 3, 4);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.PlaceholderText = "Precio";
            textBoxPrecio.Size = new Size(215, 27);
            textBoxPrecio.TabIndex = 3;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(306, 127);
            textBoxNombre.Margin = new Padding(3, 4, 3, 4);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Nombre";
            textBoxNombre.Size = new Size(215, 27);
            textBoxNombre.TabIndex = 2;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(306, 68);
            textBoxId.Margin = new Padding(3, 4, 3, 4);
            textBoxId.Name = "textBoxId";
            textBoxId.PlaceholderText = "Id";
            textBoxId.Size = new Size(215, 27);
            textBoxId.TabIndex = 1;
            // 
            // pictureBoxImagen
            // 
            pictureBoxImagen.BackColor = Color.Transparent;
            pictureBoxImagen.BackgroundImage = Properties.Resources.OIP_removebg_preview;
            pictureBoxImagen.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxImagen.Location = new Point(74, 61);
            pictureBoxImagen.Margin = new Padding(3, 4, 3, 4);
            pictureBoxImagen.Name = "pictureBoxImagen";
            pictureBoxImagen.Size = new Size(168, 200);
            pictureBoxImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImagen.TabIndex = 0;
            pictureBoxImagen.TabStop = false;
            pictureBoxImagen.Click += pictureBoxImagen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(306, 278);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 19;
            label1.Text = "Descripcion";
            // 
            // richTextBoxDescripcion
            // 
            richTextBoxDescripcion.Location = new Point(306, 301);
            richTextBoxDescripcion.Name = "richTextBoxDescripcion";
            richTextBoxDescripcion.Size = new Size(215, 125);
            richTextBoxDescripcion.TabIndex = 18;
            richTextBoxDescripcion.Text = "";
            // 
            // AgregarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 484);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AgregarProducto";
            Text = "AgregarProducto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBoxCantidad;
        private TextBox textBoxPrecio;
        private TextBox textBoxNombre;
        private TextBox textBoxId;
        private PictureBox pictureBoxImagen;
        private Button buttonAgregar;
        private Button buttonRegresar;
        private Label label1;
        private RichTextBox richTextBoxDescripcion;
    }
}
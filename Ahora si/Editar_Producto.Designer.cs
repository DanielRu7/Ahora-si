namespace Ahora_si
{
    partial class Editar_Producto
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
            label1 = new Label();
            richTextBoxDescripcion = new RichTextBox();
            buttonRegresar = new Button();
            buttonEditar = new Button();
            textBoxCantidad = new TextBox();
            textBoxPrecio = new TextBox();
            textBoxNombre = new TextBox();
            textBoxId = new TextBox();
            pictureBoxImagen = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(richTextBoxDescripcion);
            panel1.Controls.Add(buttonRegresar);
            panel1.Controls.Add(buttonEditar);
            panel1.Controls.Add(textBoxCantidad);
            panel1.Controls.Add(textBoxPrecio);
            panel1.Controls.Add(textBoxNombre);
            panel1.Controls.Add(textBoxId);
            panel1.Controls.Add(pictureBoxImagen);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(611, 450);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(303, 240);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 17;
            label1.Text = "Descripcion";
            // 
            // richTextBoxDescripcion
            // 
            richTextBoxDescripcion.Location = new Point(303, 263);
            richTextBoxDescripcion.Name = "richTextBoxDescripcion";
            richTextBoxDescripcion.Size = new Size(215, 125);
            richTextBoxDescripcion.TabIndex = 16;
            richTextBoxDescripcion.Text = "";
            // 
            // buttonRegresar
            // 
            buttonRegresar.Location = new Point(505, 409);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(94, 29);
            buttonRegresar.TabIndex = 15;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(123, 334);
            buttonEditar.Margin = new Padding(3, 4, 3, 4);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(86, 31);
            buttonEditar.TabIndex = 14;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // textBoxCantidad
            // 
            textBoxCantidad.Location = new Point(303, 192);
            textBoxCantidad.Margin = new Padding(3, 4, 3, 4);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.PlaceholderText = "Cantidad";
            textBoxCantidad.Size = new Size(215, 27);
            textBoxCantidad.TabIndex = 12;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(303, 146);
            textBoxPrecio.Margin = new Padding(3, 4, 3, 4);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.PlaceholderText = "Precio";
            textBoxPrecio.Size = new Size(215, 27);
            textBoxPrecio.TabIndex = 11;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(303, 88);
            textBoxNombre.Margin = new Padding(3, 4, 3, 4);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Nombre";
            textBoxNombre.Size = new Size(215, 27);
            textBoxNombre.TabIndex = 10;
            // 
            // textBoxId
            // 
            textBoxId.Enabled = false;
            textBoxId.Location = new Point(303, 29);
            textBoxId.Margin = new Padding(3, 4, 3, 4);
            textBoxId.Name = "textBoxId";
            textBoxId.PlaceholderText = "Id";
            textBoxId.Size = new Size(215, 27);
            textBoxId.TabIndex = 9;
            // 
            // pictureBoxImagen
            // 
            pictureBoxImagen.BackColor = Color.Transparent;
            pictureBoxImagen.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxImagen.Location = new Point(71, 61);
            pictureBoxImagen.Margin = new Padding(3, 4, 3, 4);
            pictureBoxImagen.Name = "pictureBoxImagen";
            pictureBoxImagen.Size = new Size(168, 200);
            pictureBoxImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImagen.TabIndex = 8;
            pictureBoxImagen.TabStop = false;
            pictureBoxImagen.Click += pictureBoxImagen_Click_1;
            // 
            // Editar_Producto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 450);
            Controls.Add(panel1);
            Name = "Editar_Producto";
            Text = "Editar_Producto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonRegresar;
        private Button buttonEditar;
        private TextBox textBoxCantidad;
        private TextBox textBoxPrecio;
        private TextBox textBoxNombre;
        private TextBox textBoxId;
        private PictureBox pictureBoxImagen;
        private Label label1;
        private RichTextBox richTextBoxDescripcion;
    }
}
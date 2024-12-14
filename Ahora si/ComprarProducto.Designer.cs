namespace Ahora_si
{
    partial class ComprarProducto
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
            buttonCancelar = new Button();
            buttonAgregar = new Button();
            richTextBoxDescripcion = new RichTextBox();
            pictureBoxImagen = new PictureBox();
            labelInformacion = new Label();
            textBoxPrecio = new TextBox();
            textBoxNombre = new TextBox();
            textBoxCantidad = new TextBox();
            textBoxId = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonCancelar);
            panel1.Controls.Add(buttonAgregar);
            panel1.Controls.Add(richTextBoxDescripcion);
            panel1.Controls.Add(pictureBoxImagen);
            panel1.Controls.Add(labelInformacion);
            panel1.Controls.Add(textBoxPrecio);
            panel1.Controls.Add(textBoxNombre);
            panel1.Controls.Add(textBoxCantidad);
            panel1.Controls.Add(textBoxId);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 338);
            panel1.TabIndex = 0;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(603, 303);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 13;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(364, 303);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(75, 23);
            buttonAgregar.TabIndex = 11;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // richTextBoxDescripcion
            // 
            richTextBoxDescripcion.Enabled = false;
            richTextBoxDescripcion.Location = new Point(339, 168);
            richTextBoxDescripcion.Name = "richTextBoxDescripcion";
            richTextBoxDescripcion.Size = new Size(100, 96);
            richTextBoxDescripcion.TabIndex = 10;
            richTextBoxDescripcion.Text = "";
            // 
            // pictureBoxImagen
            // 
            pictureBoxImagen.BackColor = Color.Transparent;
            pictureBoxImagen.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxImagen.Enabled = false;
            pictureBoxImagen.Location = new Point(91, 37);
            pictureBoxImagen.Name = "pictureBoxImagen";
            pictureBoxImagen.Size = new Size(147, 150);
            pictureBoxImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImagen.TabIndex = 9;
            pictureBoxImagen.TabStop = false;
            // 
            // labelInformacion
            // 
            labelInformacion.AutoSize = true;
            labelInformacion.Location = new Point(339, 18);
            labelInformacion.Name = "labelInformacion";
            labelInformacion.Size = new Size(72, 15);
            labelInformacion.TabIndex = 6;
            labelInformacion.Text = "Informacion";
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.BorderStyle = BorderStyle.None;
            textBoxPrecio.Enabled = false;
            textBoxPrecio.Location = new Point(339, 135);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(100, 16);
            textBoxPrecio.TabIndex = 3;
            // 
            // textBoxNombre
            // 
            textBoxNombre.BorderStyle = BorderStyle.None;
            textBoxNombre.Enabled = false;
            textBoxNombre.Location = new Point(339, 106);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(100, 16);
            textBoxNombre.TabIndex = 2;
            // 
            // textBoxCantidad
            // 
            textBoxCantidad.BorderStyle = BorderStyle.None;
            textBoxCantidad.Enabled = false;
            textBoxCantidad.Location = new Point(339, 77);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.Size = new Size(100, 16);
            textBoxCantidad.TabIndex = 1;
            // 
            // textBoxId
            // 
            textBoxId.BorderStyle = BorderStyle.None;
            textBoxId.Enabled = false;
            textBoxId.Location = new Point(339, 48);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(100, 16);
            textBoxId.TabIndex = 0;
            // 
            // ComprarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ComprarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ComprarProducto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelInformacion;
        private TextBox textBoxPrecio;
        private TextBox textBoxNombre;
        private TextBox textBoxCantidad;
        private TextBox textBoxId;
        private PictureBox pictureBoxImagen;
        private RichTextBox richTextBoxDescripcion;
        private Button buttonCancelar;
        private Button buttonAgregar;
    }
}
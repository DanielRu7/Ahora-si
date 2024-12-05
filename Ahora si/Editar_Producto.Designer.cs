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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar_Producto));
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
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
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 546);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(203, 289);
            label5.Name = "label5";
            label5.Size = new Size(124, 23);
            label5.TabIndex = 25;
            label5.Text = "Descripcion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(203, 220);
            label4.Name = "label4";
            label4.Size = new Size(104, 23);
            label4.TabIndex = 24;
            label4.Text = "Cantidad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(203, 152);
            label1.Name = "label1";
            label1.Size = new Size(73, 23);
            label1.TabIndex = 23;
            label1.Text = "Precio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(203, 81);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 22;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(203, 12);
            label2.Name = "label2";
            label2.Size = new Size(33, 23);
            label2.TabIndex = 21;
            label2.Text = "Id:";
            // 
            // richTextBoxDescripcion
            // 
            richTextBoxDescripcion.Location = new Point(203, 314);
            richTextBoxDescripcion.Margin = new Padding(3, 2, 3, 2);
            richTextBoxDescripcion.Name = "richTextBoxDescripcion";
            richTextBoxDescripcion.Size = new Size(189, 95);
            richTextBoxDescripcion.TabIndex = 16;
            richTextBoxDescripcion.Text = "";
            // 
            // buttonRegresar
            // 
            buttonRegresar.BackgroundImage = (Image)resources.GetObject("buttonRegresar.BackgroundImage");
            buttonRegresar.Location = new Point(327, 426);
            buttonRegresar.Margin = new Padding(3, 2, 3, 2);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(65, 64);
            buttonRegresar.TabIndex = 15;
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.BackgroundImage = (Image)resources.GetObject("buttonEditar.BackgroundImage");
            buttonEditar.Location = new Point(203, 426);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(66, 66);
            buttonEditar.TabIndex = 14;
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // textBoxCantidad
            // 
            textBoxCantidad.Location = new Point(203, 246);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.PlaceholderText = "Cantidad";
            textBoxCantidad.Size = new Size(189, 23);
            textBoxCantidad.TabIndex = 12;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(203, 178);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.PlaceholderText = "Precio";
            textBoxPrecio.Size = new Size(189, 23);
            textBoxPrecio.TabIndex = 11;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(203, 107);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Nombre";
            textBoxNombre.Size = new Size(189, 23);
            textBoxNombre.TabIndex = 10;
            // 
            // textBoxId
            // 
            textBoxId.Enabled = false;
            textBoxId.Location = new Point(203, 38);
            textBoxId.Name = "textBoxId";
            textBoxId.PlaceholderText = "Id";
            textBoxId.Size = new Size(189, 23);
            textBoxId.TabIndex = 9;
            // 
            // pictureBoxImagen
            // 
            pictureBoxImagen.BackColor = Color.Transparent;
            pictureBoxImagen.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxImagen.Location = new Point(22, 18);
            pictureBoxImagen.Name = "pictureBoxImagen";
            pictureBoxImagen.Size = new Size(147, 150);
            pictureBoxImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImagen.TabIndex = 8;
            pictureBoxImagen.TabStop = false;
            pictureBoxImagen.Click += pictureBoxImagen_Click_1;
            // 
            // Editar_Producto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 546);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
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
        private RichTextBox richTextBoxDescripcion;
        private Label label5;
        private Label label4;
        private Label label1;
        private Label label3;
        private Label label2;
    }
}
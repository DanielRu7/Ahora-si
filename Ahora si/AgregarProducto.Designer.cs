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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProducto));
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            label2 = new Label();
            richTextBoxDescripcion = new RichTextBox();
            buttonRegresar = new Button();
            buttonAgregar = new Button();
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
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
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
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 546);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(203, 273);
            label5.Name = "label5";
            label5.Size = new Size(124, 23);
            label5.TabIndex = 28;
            label5.Text = "Descripcion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(203, 210);
            label4.Name = "label4";
            label4.Size = new Size(104, 23);
            label4.TabIndex = 27;
            label4.Text = "Cantidad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(201, 148);
            label3.Name = "label3";
            label3.Size = new Size(73, 23);
            label3.TabIndex = 26;
            label3.Text = "Precio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(203, 86);
            label7.Name = "label7";
            label7.Size = new Size(90, 23);
            label7.TabIndex = 25;
            label7.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(203, 18);
            label2.Name = "label2";
            label2.Size = new Size(33, 23);
            label2.TabIndex = 20;
            label2.Text = "Id:";
            // 
            // richTextBoxDescripcion
            // 
            richTextBoxDescripcion.Location = new Point(203, 298);
            richTextBoxDescripcion.Margin = new Padding(3, 2, 3, 2);
            richTextBoxDescripcion.Name = "richTextBoxDescripcion";
            richTextBoxDescripcion.Size = new Size(189, 95);
            richTextBoxDescripcion.TabIndex = 18;
            richTextBoxDescripcion.Text = "";
            // 
            // buttonRegresar
            // 
            buttonRegresar.BackColor = Color.Transparent;
            buttonRegresar.BackgroundImage = (Image)resources.GetObject("buttonRegresar.BackgroundImage");
            buttonRegresar.Location = new Point(320, 417);
            buttonRegresar.Margin = new Padding(3, 2, 3, 2);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(72, 67);
            buttonRegresar.TabIndex = 7;
            buttonRegresar.UseVisualStyleBackColor = false;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackgroundImage = (Image)resources.GetObject("buttonAgregar.BackgroundImage");
            buttonAgregar.Location = new Point(201, 417);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(68, 67);
            buttonAgregar.TabIndex = 6;
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += button1_Click;
            // 
            // textBoxCantidad
            // 
            textBoxCantidad.Location = new Point(203, 236);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.PlaceholderText = "Cantidad";
            textBoxCantidad.Size = new Size(189, 23);
            textBoxCantidad.TabIndex = 4;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(203, 174);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.PlaceholderText = "Precio";
            textBoxPrecio.Size = new Size(189, 23);
            textBoxPrecio.TabIndex = 3;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(203, 112);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Nombre";
            textBoxNombre.Size = new Size(189, 23);
            textBoxNombre.TabIndex = 2;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(203, 44);
            textBoxId.Name = "textBoxId";
            textBoxId.PlaceholderText = "Id";
            textBoxId.Size = new Size(189, 23);
            textBoxId.TabIndex = 1;
            // 
            // pictureBoxImagen
            // 
            pictureBoxImagen.BackColor = Color.Transparent;
            pictureBoxImagen.BackgroundImage = Properties.Resources.OIP_removebg_preview;
            pictureBoxImagen.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxImagen.Location = new Point(12, 19);
            pictureBoxImagen.Name = "pictureBoxImagen";
            pictureBoxImagen.Size = new Size(147, 150);
            pictureBoxImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImagen.TabIndex = 0;
            pictureBoxImagen.TabStop = false;
            pictureBoxImagen.Click += pictureBoxImagen_Click;
            // 
            // AgregarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 546);
            Controls.Add(panel1);
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
        private RichTextBox richTextBoxDescripcion;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
    }
}
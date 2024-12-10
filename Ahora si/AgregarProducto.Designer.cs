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
            buttonRegresar = new Button();
            buttonAgregar = new Button();
            richTextBoxDescripcion = new RichTextBox();
            label5 = new Label();
            richTextBox1 = new RichTextBox();
            label6 = new Label();
            pictureBox6 = new PictureBox();
            textBoxCantidad = new TextBox();
            textBox4 = new TextBox();
            textBoxPrecio = new TextBox();
            textBox3 = new TextBox();
            textBoxNombre = new TextBox();
            textBox2 = new TextBox();
            textBoxId = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            label2 = new Label();
            pictureBoxImagen = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(buttonAgregar);
            panel1.Controls.Add(richTextBoxDescripcion);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(textBoxCantidad);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBoxPrecio);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBoxNombre);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBoxId);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBoxImagen);
            panel1.Controls.Add(buttonRegresar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 728);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // buttonRegresar
            // 
            buttonRegresar.BackColor = Color.Transparent;
            buttonRegresar.BackgroundImage = (Image)resources.GetObject("buttonRegresar.BackgroundImage");
            buttonRegresar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonRegresar.Location = new Point(366, 556);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(82, 89);
            buttonRegresar.TabIndex = 7;
            buttonRegresar.UseVisualStyleBackColor = false;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackgroundImage = (Image)resources.GetObject("buttonAgregar.BackgroundImage");
            buttonAgregar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAgregar.Location = new Point(230, 556);
            buttonAgregar.Margin = new Padding(3, 4, 3, 4);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(78, 89);
            buttonAgregar.TabIndex = 6;
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += button1_Click;
            // 
            // richTextBoxDescripcion
            // 
            richTextBoxDescripcion.BorderStyle = BorderStyle.None;
            richTextBoxDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxDescripcion.Location = new Point(246, 410);
            richTextBoxDescripcion.Name = "richTextBoxDescripcion";
            richTextBoxDescripcion.Size = new Size(216, 127);
            richTextBoxDescripcion.TabIndex = 41;
            richTextBoxDescripcion.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(243, 377);
            label5.Name = "label5";
            label5.Size = new Size(157, 28);
            label5.TabIndex = 46;
            label5.Text = "Descripcion:";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Black;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Enabled = false;
            richTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(245, 409);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(218, 129);
            richTextBox1.TabIndex = 51;
            richTextBox1.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(21, 476);
            label6.Name = "label6";
            label6.Size = new Size(231, 19);
            label6.TabIndex = 53;
            label6.Text = "Estas editando un producto";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.BackgroundImage = Properties.Resources.circulo;
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Location = new Point(-7, 365);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(273, 240);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 52;
            pictureBox6.TabStop = false;
            // 
            // textBoxCantidad
            // 
            textBoxCantidad.BorderStyle = BorderStyle.None;
            textBoxCantidad.Font = new Font("Segoe UI", 12F);
            textBoxCantidad.Location = new Point(246, 328);
            textBoxCantidad.Margin = new Padding(3, 4, 3, 4);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.PlaceholderText = "Cantidad";
            textBoxCantidad.Size = new Size(216, 27);
            textBoxCantidad.TabIndex = 40;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Black;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Enabled = false;
            textBox4.Font = new Font("Segoe UI", 12F);
            textBox4.Location = new Point(246, 329);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(216, 27);
            textBox4.TabIndex = 50;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.BorderStyle = BorderStyle.None;
            textBoxPrecio.Font = new Font("Segoe UI", 12F);
            textBoxPrecio.Location = new Point(246, 245);
            textBoxPrecio.Margin = new Padding(3, 4, 3, 4);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.PlaceholderText = "Precio";
            textBoxPrecio.Size = new Size(216, 27);
            textBoxPrecio.TabIndex = 39;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Black;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Enabled = false;
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(246, 246);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(216, 27);
            textBox3.TabIndex = 49;
            // 
            // textBoxNombre
            // 
            textBoxNombre.BorderStyle = BorderStyle.None;
            textBoxNombre.Font = new Font("Segoe UI", 12F);
            textBoxNombre.Location = new Point(246, 162);
            textBoxNombre.Margin = new Padding(3, 4, 3, 4);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Nombre";
            textBoxNombre.Size = new Size(216, 27);
            textBoxNombre.TabIndex = 38;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Black;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Enabled = false;
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(246, 164);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(216, 27);
            textBox2.TabIndex = 48;
            // 
            // textBoxId
            // 
            textBoxId.BorderStyle = BorderStyle.None;
            textBoxId.Font = new Font("Segoe UI", 12F);
            textBoxId.Location = new Point(246, 72);
            textBoxId.Margin = new Padding(3, 4, 3, 4);
            textBoxId.Name = "textBoxId";
            textBoxId.PlaceholderText = "Id";
            textBoxId.Size = new Size(216, 27);
            textBoxId.TabIndex = 37;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(246, 73);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 27);
            textBox1.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(242, 293);
            label4.Name = "label4";
            label4.Size = new Size(129, 28);
            label4.TabIndex = 45;
            label4.Text = "Cantidad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(243, 210);
            label3.Name = "label3";
            label3.Size = new Size(91, 28);
            label3.TabIndex = 44;
            label3.Text = "Precio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(243, 128);
            label7.Name = "label7";
            label7.Size = new Size(114, 28);
            label7.TabIndex = 43;
            label7.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(243, 37);
            label2.Name = "label2";
            label2.Size = new Size(42, 28);
            label2.TabIndex = 42;
            label2.Text = "Id:";
            // 
            // pictureBoxImagen
            // 
            pictureBoxImagen.BackColor = Color.Transparent;
            pictureBoxImagen.BackgroundImage = Properties.Resources.OIP_removebg_preview;
            pictureBoxImagen.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxImagen.Location = new Point(28, 38);
            pictureBoxImagen.Margin = new Padding(3, 4, 3, 4);
            pictureBoxImagen.Name = "pictureBoxImagen";
            pictureBoxImagen.Size = new Size(168, 200);
            pictureBoxImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImagen.TabIndex = 36;
            pictureBoxImagen.TabStop = false;
            // 
            // AgregarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 728);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AgregarProducto";
            Text = "AgregarProducto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonAgregar;
        private Button buttonRegresar;
        private RichTextBox richTextBoxDescripcion;
        private Label label5;
        private RichTextBox richTextBox1;
        private Label label6;
        private PictureBox pictureBox6;
        private TextBox textBoxCantidad;
        private TextBox textBox4;
        private TextBox textBoxPrecio;
        private TextBox textBox3;
        private TextBox textBoxNombre;
        private TextBox textBox2;
        private TextBox textBoxId;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label2;
        private PictureBox pictureBoxImagen;
    }
}
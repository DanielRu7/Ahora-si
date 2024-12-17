namespace Ahora_si
{
    partial class ReciboCompra
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
            buttonCerrar = new Button();
            labelFecha = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxRecibo = new RichTextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(buttonCerrar);
            panel1.Controls.Add(labelFecha);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxRecibo);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 453);
            panel1.TabIndex = 0;
            // 
            // buttonCerrar
            // 
            buttonCerrar.BackgroundImage = Properties.Resources.regresar_removebg_preview__1_;
            buttonCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonCerrar.FlatStyle = FlatStyle.Flat;
            buttonCerrar.Location = new Point(312, 384);
            buttonCerrar.Margin = new Padding(3, 2, 3, 2);
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.Size = new Size(61, 58);
            buttonCerrar.TabIndex = 11;
            buttonCerrar.UseVisualStyleBackColor = true;
            buttonCerrar.Click += buttonCerrar_Click;
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFecha.Location = new Point(12, 64);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(58, 18);
            labelFecha.TabIndex = 10;
            labelFecha.Text = "Fecha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(12, 25);
            label2.Name = "label2";
            label2.Size = new Size(258, 18);
            label2.TabIndex = 8;
            label2.Text = "\"Sabores que Iluminan la Pantalla\"";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(77, 5);
            label1.Name = "label1";
            label1.Size = new Size(133, 23);
            label1.TabIndex = 7;
            label1.Text = "CANDY SHOP";
            // 
            // textBoxRecibo
            // 
            textBoxRecibo.Location = new Point(10, 93);
            textBoxRecibo.Margin = new Padding(3, 2, 3, 2);
            textBoxRecibo.Name = "textBoxRecibo";
            textBoxRecibo.Size = new Size(364, 276);
            textBoxRecibo.TabIndex = 9;
            textBoxRecibo.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logodulceria_removebg_preview;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(299, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 68);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // ReciboCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 453);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ReciboCompra";
            Text = "ReciboCompra";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private RichTextBox textBoxRecibo;
        private Button buttonCerrar;
        private Label labelFecha;
    }
}
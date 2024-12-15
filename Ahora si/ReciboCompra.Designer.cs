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
            pictureBox1 = new PictureBox();
            textBoxRecibo = new RichTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonCerrar);
            panel1.Controls.Add(labelFecha);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxRecibo);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(440, 572);
            panel1.TabIndex = 0;
            // 
            // buttonCerrar
            // 
            buttonCerrar.Location = new Point(327, 523);
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.Size = new Size(91, 28);
            buttonCerrar.TabIndex = 11;
            buttonCerrar.Text = "Cerrar";
            buttonCerrar.UseVisualStyleBackColor = true;
            buttonCerrar.Click += buttonCerrar_Click;
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFecha.Location = new Point(47, 86);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(71, 22);
            labelFecha.TabIndex = 10;
            labelFecha.Text = "Fecha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(23, 53);
            label2.Name = "label2";
            label2.Size = new Size(309, 22);
            label2.TabIndex = 8;
            label2.Text = "\"Sabores que Iluminan la Pantalla\"";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(97, 26);
            label1.Name = "label1";
            label1.Size = new Size(160, 27);
            label1.TabIndex = 7;
            label1.Text = "CANDY SHOP";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logodulceria_removebg_preview;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(327, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 139);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // textBoxRecibo
            // 
            textBoxRecibo.Location = new Point(12, 124);
            textBoxRecibo.Name = "textBoxRecibo";
            textBoxRecibo.Size = new Size(416, 367);
            textBoxRecibo.TabIndex = 9;
            textBoxRecibo.Text = "";
            // 
            // ReciboCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 572);
            Controls.Add(panel1);
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
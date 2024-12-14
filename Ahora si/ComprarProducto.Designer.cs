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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComprarProducto));
            panel1 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonCancelar = new Button();
            buttonAgregar = new Button();
            pictureBoxImagen = new PictureBox();
            labelInformacion = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonCancelar);
            panel1.Controls.Add(buttonAgregar);
            panel1.Controls.Add(pictureBoxImagen);
            panel1.Controls.Add(labelInformacion);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 311);
            panel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label9.Location = new Point(336, 143);
            label9.Name = "label9";
            label9.Size = new Size(0, 18);
            label9.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label8.Location = new Point(336, 110);
            label8.Name = "label8";
            label8.Size = new Size(0, 18);
            label8.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label7.Location = new Point(336, 81);
            label7.Name = "label7";
            label7.Size = new Size(0, 18);
            label7.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label6.Location = new Point(336, 52);
            label6.Name = "label6";
            label6.Size = new Size(0, 18);
            label6.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(230, 167);
            label5.Name = "label5";
            label5.Size = new Size(100, 19);
            label5.TabIndex = 18;
            label5.Text = "Descripcion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(230, 135);
            label4.Name = "label4";
            label4.Size = new Size(57, 19);
            label4.TabIndex = 17;
            label4.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(230, 106);
            label3.Name = "label3";
            label3.Size = new Size(73, 19);
            label3.TabIndex = 16;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(230, 77);
            label2.Name = "label2";
            label2.Size = new Size(83, 19);
            label2.TabIndex = 15;
            label2.Text = "Cantidad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(230, 48);
            label1.Name = "label1";
            label1.Size = new Size(24, 19);
            label1.TabIndex = 14;
            label1.Text = "Id";
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackgroundImage = (Image)resources.GetObject("buttonCancelar.BackgroundImage");
            buttonCancelar.Location = new Point(461, 231);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(69, 68);
            buttonCancelar.TabIndex = 13;
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackgroundImage = Properties.Resources.agregarprod;
            buttonAgregar.Location = new Point(230, 231);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(66, 68);
            buttonAgregar.TabIndex = 11;
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // pictureBoxImagen
            // 
            pictureBoxImagen.BackColor = Color.Transparent;
            pictureBoxImagen.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxImagen.Enabled = false;
            pictureBoxImagen.Location = new Point(29, 64);
            pictureBoxImagen.Name = "pictureBoxImagen";
            pictureBoxImagen.Size = new Size(147, 150);
            pictureBoxImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImagen.TabIndex = 9;
            pictureBoxImagen.TabStop = false;
            // 
            // labelInformacion
            // 
            labelInformacion.AutoSize = true;
            labelInformacion.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInformacion.Location = new Point(221, 9);
            labelInformacion.Name = "labelInformacion";
            labelInformacion.Size = new Size(309, 28);
            labelInformacion.TabIndex = 6;
            labelInformacion.Text = "Informacion del producto";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(336, 168);
            label10.Name = "label10";
            label10.Size = new Size(0, 18);
            label10.TabIndex = 23;
            // 
            // ComprarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 311);
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
        private PictureBox pictureBoxImagen;
        private Button buttonCancelar;
        private Button buttonAgregar;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label10;
    }
}
﻿namespace Ahora_si
{
    partial class Borrar_producto
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
            buttonAceptar = new Button();
            labelProducto = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(buttonCancelar);
            panel1.Controls.Add(buttonAceptar);
            panel1.Controls.Add(labelProducto);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(442, 175);
            panel1.TabIndex = 0;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackgroundImage = Properties.Resources.image__1_;
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.Location = new Point(256, 80);
            buttonCancelar.Margin = new Padding(3, 2, 3, 2);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(82, 73);
            buttonCancelar.TabIndex = 25;
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonAceptar
            // 
            buttonAceptar.BackgroundImage = Properties.Resources.image1;
            buttonAceptar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAceptar.FlatStyle = FlatStyle.Flat;
            buttonAceptar.Location = new Point(129, 94);
            buttonAceptar.Margin = new Padding(3, 2, 3, 2);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(46, 44);
            buttonAceptar.TabIndex = 24;
            buttonAceptar.UseVisualStyleBackColor = true;
            buttonAceptar.Click += buttonAceptar_Click;
            // 
            // labelProducto
            // 
            labelProducto.AutoSize = true;
            labelProducto.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProducto.ForeColor = SystemColors.ControlLightLight;
            labelProducto.Location = new Point(176, 62);
            labelProducto.Name = "labelProducto";
            labelProducto.Size = new Size(85, 23);
            labelProducto.TabIndex = 23;
            labelProducto.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(53, 28);
            label2.Name = "label2";
            label2.Size = new Size(336, 23);
            label2.TabIndex = 22;
            label2.Text = "Estas seguro de borrar el producto?";
            // 
            // Borrar_producto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 175);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Borrar_producto";
            Text = "Borrar_producto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonCancelar;
        private Button buttonAceptar;
        private Label labelProducto;
        private Label label2;
    }
}
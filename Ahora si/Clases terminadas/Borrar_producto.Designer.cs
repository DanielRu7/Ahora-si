namespace Ahora_si
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
            panel1.Controls.Add(buttonCancelar);
            panel1.Controls.Add(buttonAceptar);
            panel1.Controls.Add(labelProducto);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(505, 233);
            panel1.TabIndex = 0;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(362, 174);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 29);
            buttonCancelar.TabIndex = 25;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonAceptar
            // 
            buttonAceptar.Location = new Point(50, 174);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(94, 29);
            buttonAceptar.TabIndex = 24;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = true;
            buttonAceptar.Click += buttonAceptar_Click;
            // 
            // labelProducto
            // 
            labelProducto.AutoSize = true;
            labelProducto.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProducto.ForeColor = SystemColors.ActiveCaptionText;
            labelProducto.Location = new Point(189, 83);
            labelProducto.Name = "labelProducto";
            labelProducto.Size = new Size(107, 28);
            labelProducto.TabIndex = 23;
            labelProducto.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(50, 39);
            label2.Name = "label2";
            label2.Size = new Size(406, 28);
            label2.TabIndex = 22;
            label2.Text = "Estas Seguro De Borrar El Producto";
            // 
            // Borrar_producto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 233);
            Controls.Add(panel1);
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
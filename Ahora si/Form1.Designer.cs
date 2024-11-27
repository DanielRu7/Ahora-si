namespace Ahora_si
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxNombre = new TextBox();
            textBoxCuenta = new TextBox();
            label1 = new Label();
            textBoxContrasena = new TextBox();
            SuspendLayout();
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(236, 82);
            textBoxNombre.Margin = new Padding(3, 2, 3, 2);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Nombre";
            textBoxNombre.Size = new Size(179, 23);
            textBoxNombre.TabIndex = 0;
            textBoxNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxCuenta
            // 
            textBoxCuenta.Location = new Point(236, 127);
            textBoxCuenta.Margin = new Padding(3, 2, 3, 2);
            textBoxCuenta.Name = "textBoxCuenta";
            textBoxCuenta.PlaceholderText = "Cuenta";
            textBoxCuenta.Size = new Size(179, 23);
            textBoxCuenta.TabIndex = 1;
            textBoxCuenta.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(298, 42);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 2;
            label1.Text = "Login in";
            label1.Click += label1_Click;
            // 
            // textBoxContrasena
            // 
            textBoxContrasena.Location = new Point(236, 175);
            textBoxContrasena.Margin = new Padding(3, 2, 3, 2);
            textBoxContrasena.Name = "textBoxContrasena";
            textBoxContrasena.PlaceholderText = "Contraseña";
            textBoxContrasena.Size = new Size(179, 23);
            textBoxContrasena.TabIndex = 3;
            textBoxContrasena.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(textBoxContrasena);
            Controls.Add(label1);
            Controls.Add(textBoxCuenta);
            Controls.Add(textBoxNombre);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNombre;
        private TextBox textBoxCuenta;
        private Label label1;
        private TextBox textBoxContrasena;
    }
}

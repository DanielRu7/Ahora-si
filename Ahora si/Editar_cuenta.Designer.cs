namespace Ahora_si
{
    partial class Editar_cuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar_cuenta));
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            buttonRegresar = new Button();
            buttonEditar = new Button();
            textBoxContrasena = new TextBox();
            textBoxCuenta = new TextBox();
            textBoxNombre = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(buttonRegresar);
            panel1.Controls.Add(buttonEditar);
            panel1.Controls.Add(textBoxContrasena);
            panel1.Controls.Add(textBoxCuenta);
            panel1.Controls.Add(textBoxNombre);
            panel1.Location = new Point(-3, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 580);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(104, 253);
            label3.Name = "label3";
            label3.Size = new Size(154, 28);
            label3.TabIndex = 23;
            label3.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(104, 165);
            label1.Name = "label1";
            label1.Size = new Size(104, 28);
            label1.TabIndex = 22;
            label1.Text = "Cuenta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(104, 72);
            label2.Name = "label2";
            label2.Size = new Size(114, 28);
            label2.TabIndex = 21;
            label2.Text = "Nombre:";
            // 
            // buttonRegresar
            // 
            buttonRegresar.BackgroundImage = (Image)resources.GetObject("buttonRegresar.BackgroundImage");
            buttonRegresar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonRegresar.Location = new Point(227, 375);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(81, 92);
            buttonRegresar.TabIndex = 7;
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Anchor = AnchorStyles.Top;
            buttonEditar.BackgroundImage = (Image)resources.GetObject("buttonEditar.BackgroundImage");
            buttonEditar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonEditar.Location = new Point(104, 375);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(78, 92);
            buttonEditar.TabIndex = 10;
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // textBoxContrasena
            // 
            textBoxContrasena.Anchor = AnchorStyles.Top;
            textBoxContrasena.Location = new Point(104, 287);
            textBoxContrasena.Name = "textBoxContrasena";
            textBoxContrasena.PlaceholderText = "Contraseña";
            textBoxContrasena.Size = new Size(204, 27);
            textBoxContrasena.TabIndex = 9;
            textBoxContrasena.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxCuenta
            // 
            textBoxCuenta.Anchor = AnchorStyles.Top;
            textBoxCuenta.Location = new Point(104, 199);
            textBoxCuenta.Name = "textBoxCuenta";
            textBoxCuenta.PlaceholderText = "Cuenta";
            textBoxCuenta.Size = new Size(204, 27);
            textBoxCuenta.TabIndex = 8;
            textBoxCuenta.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Anchor = AnchorStyles.Top;
            textBoxNombre.Location = new Point(104, 105);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Nombre";
            textBoxNombre.Size = new Size(204, 27);
            textBoxNombre.TabIndex = 6;
            textBoxNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // Editar_cuenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 579);
            Controls.Add(panel1);
            Name = "Editar_cuenta";
            Text = "Editar_cuenta";
            Load += Editar_cuenta_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonRegresar;
        private Button buttonEditar;
        private TextBox textBoxContrasena;
        private TextBox textBoxCuenta;
        private TextBox textBoxNombre;
        private Label label3;
        private Label label1;
        private Label label2;
    }
}
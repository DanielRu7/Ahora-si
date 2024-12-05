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
            buttonRegresar = new Button();
            buttonEditar = new Button();
            textBoxContrasena = new TextBox();
            textBoxCuenta = new TextBox();
            textBoxNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
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
            panel1.Location = new Point(-3, -2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(378, 435);
            panel1.TabIndex = 0;
            // 
            // buttonRegresar
            // 
            buttonRegresar.BackgroundImage = (Image)resources.GetObject("buttonRegresar.BackgroundImage");
            buttonRegresar.Location = new Point(199, 281);
            buttonRegresar.Margin = new Padding(3, 2, 3, 2);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(71, 69);
            buttonRegresar.TabIndex = 7;
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Anchor = AnchorStyles.Top;
            buttonEditar.BackgroundImage = (Image)resources.GetObject("buttonEditar.BackgroundImage");
            buttonEditar.Location = new Point(91, 281);
            buttonEditar.Margin = new Padding(3, 2, 3, 2);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(68, 69);
            buttonEditar.TabIndex = 10;
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // textBoxContrasena
            // 
            textBoxContrasena.Anchor = AnchorStyles.Top;
            textBoxContrasena.Location = new Point(91, 215);
            textBoxContrasena.Margin = new Padding(3, 2, 3, 2);
            textBoxContrasena.Name = "textBoxContrasena";
            textBoxContrasena.PlaceholderText = "Contraseña";
            textBoxContrasena.Size = new Size(179, 23);
            textBoxContrasena.TabIndex = 9;
            textBoxContrasena.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxCuenta
            // 
            textBoxCuenta.Anchor = AnchorStyles.Top;
            textBoxCuenta.Location = new Point(91, 149);
            textBoxCuenta.Margin = new Padding(3, 2, 3, 2);
            textBoxCuenta.Name = "textBoxCuenta";
            textBoxCuenta.PlaceholderText = "Cuenta";
            textBoxCuenta.Size = new Size(179, 23);
            textBoxCuenta.TabIndex = 8;
            textBoxCuenta.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Anchor = AnchorStyles.Top;
            textBoxNombre.Location = new Point(91, 79);
            textBoxNombre.Margin = new Padding(3, 2, 3, 2);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Nombre";
            textBoxNombre.Size = new Size(179, 23);
            textBoxNombre.TabIndex = 6;
            textBoxNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(91, 54);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 21;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(91, 124);
            label1.Name = "label1";
            label1.Size = new Size(83, 23);
            label1.TabIndex = 22;
            label1.Text = "Cuenta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(91, 190);
            label3.Name = "label3";
            label3.Size = new Size(122, 23);
            label3.TabIndex = 23;
            label3.Text = "Contraseña:";
            // 
            // Editar_cuenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 434);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
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
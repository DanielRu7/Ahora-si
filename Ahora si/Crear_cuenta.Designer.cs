namespace Ahora_si
{
    partial class Crear_cuenta
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
            SignUp = new Panel();
            buttonRegresar = new Button();
            buttonCrear = new Button();
            LogIn = new Panel();
            buttonAcceder = new Button();
            labelLogIn = new Label();
            textBoxContrasena1 = new TextBox();
            textBoxCuenta1 = new TextBox();
            linkLabel = new LinkLabel();
            SignUp.SuspendLayout();
            LogIn.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxNombre
            // 
            textBoxNombre.Anchor = AnchorStyles.Top;
            textBoxNombre.Location = new Point(216, 100);
            textBoxNombre.Margin = new Padding(3, 2, 3, 2);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Nombre";
            textBoxNombre.Size = new Size(179, 23);
            textBoxNombre.TabIndex = 0;
            textBoxNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxCuenta
            // 
            textBoxCuenta.Anchor = AnchorStyles.Top;
            textBoxCuenta.Location = new Point(216, 146);
            textBoxCuenta.Margin = new Padding(3, 2, 3, 2);
            textBoxCuenta.Name = "textBoxCuenta";
            textBoxCuenta.PlaceholderText = "Cuenta";
            textBoxCuenta.Size = new Size(179, 23);
            textBoxCuenta.TabIndex = 1;
            textBoxCuenta.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(278, 61);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "Sign up";
            label1.Click += label1_Click;
            // 
            // textBoxContrasena
            // 
            textBoxContrasena.Anchor = AnchorStyles.Top;
            textBoxContrasena.Location = new Point(216, 194);
            textBoxContrasena.Margin = new Padding(3, 2, 3, 2);
            textBoxContrasena.Name = "textBoxContrasena";
            textBoxContrasena.PlaceholderText = "Contraseña";
            textBoxContrasena.Size = new Size(179, 23);
            textBoxContrasena.TabIndex = 3;
            textBoxContrasena.TextAlign = HorizontalAlignment.Center;
            // 
            // SignUp
            // 
            SignUp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SignUp.BackColor = Color.DimGray;
            SignUp.Controls.Add(buttonRegresar);
            SignUp.Controls.Add(buttonCrear);
            SignUp.Controls.Add(textBoxContrasena);
            SignUp.Controls.Add(label1);
            SignUp.Controls.Add(textBoxCuenta);
            SignUp.Controls.Add(textBoxNombre);
            SignUp.Location = new Point(52, 9);
            SignUp.Margin = new Padding(3, 2, 3, 2);
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(638, 320);
            SignUp.TabIndex = 4;
            // 
            // buttonRegresar
            // 
            buttonRegresar.Location = new Point(511, 253);
            buttonRegresar.Margin = new Padding(3, 2, 3, 2);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(82, 22);
            buttonRegresar.TabIndex = 1;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += button1_Click;
            // 
            // buttonCrear
            // 
            buttonCrear.Anchor = AnchorStyles.Top;
            buttonCrear.Location = new Point(265, 253);
            buttonCrear.Margin = new Padding(3, 2, 3, 2);
            buttonCrear.Name = "buttonCrear";
            buttonCrear.Size = new Size(82, 22);
            buttonCrear.TabIndex = 5;
            buttonCrear.Text = "Crear";
            buttonCrear.UseVisualStyleBackColor = true;
            buttonCrear.Click += buttonCrear_Click;
            // 
            // LogIn
            // 
            LogIn.BackColor = SystemColors.ButtonFace;
            LogIn.Controls.Add(buttonAcceder);
            LogIn.Controls.Add(labelLogIn);
            LogIn.Controls.Add(textBoxContrasena1);
            LogIn.Controls.Add(textBoxCuenta1);
            LogIn.Controls.Add(linkLabel);
            LogIn.Dock = DockStyle.Fill;
            LogIn.Location = new Point(0, 0);
            LogIn.Margin = new Padding(3, 2, 3, 2);
            LogIn.Name = "LogIn";
            LogIn.Size = new Size(700, 338);
            LogIn.TabIndex = 6;
            // 
            // buttonAcceder
            // 
            buttonAcceder.Location = new Point(286, 230);
            buttonAcceder.Margin = new Padding(3, 2, 3, 2);
            buttonAcceder.Name = "buttonAcceder";
            buttonAcceder.Size = new Size(82, 22);
            buttonAcceder.TabIndex = 4;
            buttonAcceder.Text = "Acceder";
            buttonAcceder.UseVisualStyleBackColor = true;
            buttonAcceder.Click += buttonAcceder_Click;
            // 
            // labelLogIn
            // 
            labelLogIn.AutoSize = true;
            labelLogIn.Location = new Point(311, 55);
            labelLogIn.Name = "labelLogIn";
            labelLogIn.Size = new Size(40, 15);
            labelLogIn.TabIndex = 3;
            labelLogIn.Text = "Log in";
            // 
            // textBoxContrasena1
            // 
            textBoxContrasena1.Location = new Point(271, 146);
            textBoxContrasena1.Margin = new Padding(3, 2, 3, 2);
            textBoxContrasena1.Name = "textBoxContrasena1";
            textBoxContrasena1.PasswordChar = '*';
            textBoxContrasena1.PlaceholderText = "Contrasena";
            textBoxContrasena1.Size = new Size(110, 23);
            textBoxContrasena1.TabIndex = 2;
            textBoxContrasena1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxCuenta1
            // 
            textBoxCuenta1.Location = new Point(271, 92);
            textBoxCuenta1.Margin = new Padding(3, 2, 3, 2);
            textBoxCuenta1.Name = "textBoxCuenta1";
            textBoxCuenta1.PlaceholderText = "Cuenta";
            textBoxCuenta1.Size = new Size(110, 23);
            textBoxCuenta1.TabIndex = 1;
            textBoxCuenta1.TextAlign = HorizontalAlignment.Center;
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.Location = new Point(298, 190);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new Size(53, 15);
            linkLabel.TabIndex = 0;
            linkLabel.TabStop = true;
            linkLabel.Text = "Sign Up?";
            linkLabel.LinkClicked += linkLabel_LinkClicked;
            // 
            // Crear_cuenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(LogIn);
            Controls.Add(SignUp);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Crear_cuenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear_cuenta";
            SignUp.ResumeLayout(false);
            SignUp.PerformLayout();
            LogIn.ResumeLayout(false);
            LogIn.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxNombre;
        private TextBox textBoxCuenta;
        private Label label1;
        private TextBox textBoxContrasena;
        private Panel SignUp;
        private Button buttonCrear;
        private Panel LogIn;
        private LinkLabel linkLabel;
        private Button buttonRegresar;
        private Label labelLogIn;
        private TextBox textBoxContrasena1;
        private TextBox textBoxCuenta1;
        private Button buttonAcceder;
    }
}

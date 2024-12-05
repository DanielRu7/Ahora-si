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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crear_cuenta));
            textBoxNombre = new TextBox();
            textBoxCuenta = new TextBox();
            label1 = new Label();
            textBoxContrasena = new TextBox();
            SignUp = new Panel();
            buttonRegresar = new Button();
            buttonCrear = new Button();
            ButtonInvitado = new Panel();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            buttonAcceder = new Button();
            textBoxContrasena1 = new TextBox();
            textBoxCuenta1 = new TextBox();
            linkLabel = new LinkLabel();
            SignUp.SuspendLayout();
            ButtonInvitado.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(52, 111);
            textBoxNombre.Margin = new Padding(3, 2, 3, 2);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Nombre";
            textBoxNombre.Size = new Size(179, 23);
            textBoxNombre.TabIndex = 0;
            textBoxNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxCuenta
            // 
            textBoxCuenta.Location = new Point(51, 157);
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
            label1.Location = new Point(113, 37);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "Sign up";
            // 
            // textBoxContrasena
            // 
            textBoxContrasena.Location = new Point(51, 205);
            textBoxContrasena.Margin = new Padding(3, 2, 3, 2);
            textBoxContrasena.Name = "textBoxContrasena";
            textBoxContrasena.PlaceholderText = "Contraseña";
            textBoxContrasena.Size = new Size(179, 23);
            textBoxContrasena.TabIndex = 3;
            textBoxContrasena.TextAlign = HorizontalAlignment.Center;
            // 
            // SignUp
            // 
            SignUp.BackColor = Color.DimGray;
            SignUp.Controls.Add(buttonRegresar);
            SignUp.Controls.Add(buttonCrear);
            SignUp.Controls.Add(textBoxContrasena);
            SignUp.Controls.Add(label1);
            SignUp.Controls.Add(textBoxCuenta);
            SignUp.Controls.Add(textBoxNombre);
            SignUp.Location = new Point(2, 0);
            SignUp.Margin = new Padding(3, 2, 3, 2);
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(460, 547);
            SignUp.TabIndex = 4;
            // 
            // buttonRegresar
            // 
            buttonRegresar.Location = new Point(133, 304);
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
            buttonCrear.Location = new Point(100, 264);
            buttonCrear.Margin = new Padding(3, 2, 3, 2);
            buttonCrear.Name = "buttonCrear";
            buttonCrear.Size = new Size(82, 22);
            buttonCrear.TabIndex = 5;
            buttonCrear.Text = "Crear";
            buttonCrear.UseVisualStyleBackColor = true;
            buttonCrear.Click += buttonCrear_Click;
            // 
            // ButtonInvitado
            // 
            ButtonInvitado.BackColor = SystemColors.ControlLightLight;
            ButtonInvitado.Controls.Add(label2);
            ButtonInvitado.Controls.Add(linkLabel1);
            ButtonInvitado.Controls.Add(buttonAcceder);
            ButtonInvitado.Controls.Add(textBoxContrasena1);
            ButtonInvitado.Controls.Add(textBoxCuenta1);
            ButtonInvitado.Controls.Add(linkLabel);
            ButtonInvitado.Location = new Point(2, 2);
            ButtonInvitado.Margin = new Padding(3, 2, 3, 2);
            ButtonInvitado.Name = "ButtonInvitado";
            ButtonInvitado.Size = new Size(443, 545);
            ButtonInvitado.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(155, 35);
            label2.Name = "label2";
            label2.Size = new Size(113, 36);
            label2.TabIndex = 22;
            label2.Text = "LOGIN ";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.DimGray;
            linkLabel1.Location = new Point(157, 520);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(130, 15);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Acceder como invitado";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // buttonAcceder
            // 
            buttonAcceder.BackgroundImage = (Image)resources.GetObject("buttonAcceder.BackgroundImage");
            buttonAcceder.Location = new Point(179, 214);
            buttonAcceder.Margin = new Padding(3, 2, 3, 2);
            buttonAcceder.Name = "buttonAcceder";
            buttonAcceder.Size = new Size(75, 69);
            buttonAcceder.TabIndex = 4;
            buttonAcceder.Text = "    ";
            buttonAcceder.UseVisualStyleBackColor = true;
            buttonAcceder.Click += buttonAcceder_Click;
            // 
            // textBoxContrasena1
            // 
            textBoxContrasena1.Location = new Point(133, 153);
            textBoxContrasena1.Margin = new Padding(3, 2, 3, 2);
            textBoxContrasena1.Name = "textBoxContrasena1";
            textBoxContrasena1.PasswordChar = '*';
            textBoxContrasena1.PlaceholderText = "Contrasena";
            textBoxContrasena1.Size = new Size(154, 23);
            textBoxContrasena1.TabIndex = 2;
            textBoxContrasena1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxCuenta1
            // 
            textBoxCuenta1.Location = new Point(130, 109);
            textBoxCuenta1.Margin = new Padding(3, 2, 3, 2);
            textBoxCuenta1.Name = "textBoxCuenta1";
            textBoxCuenta1.PlaceholderText = "Cuenta";
            textBoxCuenta1.Size = new Size(157, 23);
            textBoxCuenta1.TabIndex = 1;
            textBoxCuenta1.TextAlign = HorizontalAlignment.Center;
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.LinkColor = Color.Gray;
            linkLabel.Location = new Point(155, 302);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new Size(127, 15);
            linkLabel.TabIndex = 0;
            linkLabel.TabStop = true;
            linkLabel.Text = "Aun no eres miembro?";
            linkLabel.LinkClicked += linkLabel_LinkClicked;
            // 
            // Crear_cuenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 546);
            Controls.Add(ButtonInvitado);
            Controls.Add(SignUp);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Crear_cuenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear_cuenta";
            SignUp.ResumeLayout(false);
            SignUp.PerformLayout();
            ButtonInvitado.ResumeLayout(false);
            ButtonInvitado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxNombre;
        private TextBox textBoxCuenta;
        private Label label1;
        private TextBox textBoxContrasena;
        private Panel SignUp;
        private Button buttonCrear;
        private Panel ButtonInvitado;
        private LinkLabel linkLabel;
        private Button buttonRegresar;
        private TextBox textBoxContrasena1;
        private TextBox textBoxCuenta1;
        private Button buttonAcceder;
        private LinkLabel linkLabel1;
        private Label label2;
    }
}

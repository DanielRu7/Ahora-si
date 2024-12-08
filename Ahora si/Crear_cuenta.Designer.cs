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
            textBoxNombre.Location = new Point(59, 148);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Nombre";
            textBoxNombre.Size = new Size(204, 27);
            textBoxNombre.TabIndex = 0;
            textBoxNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxCuenta
            // 
            textBoxCuenta.Location = new Point(58, 209);
            textBoxCuenta.Name = "textBoxCuenta";
            textBoxCuenta.PlaceholderText = "Cuenta";
            textBoxCuenta.Size = new Size(204, 27);
            textBoxCuenta.TabIndex = 1;
            textBoxCuenta.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 49);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 2;
            label1.Text = "Sign up";
            // 
            // textBoxContrasena
            // 
            textBoxContrasena.Location = new Point(58, 273);
            textBoxContrasena.Name = "textBoxContrasena";
            textBoxContrasena.PlaceholderText = "Contraseña";
            textBoxContrasena.Size = new Size(204, 27);
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
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(526, 729);
            SignUp.TabIndex = 4;
            // 
            // buttonRegresar
            // 
            buttonRegresar.Location = new Point(152, 405);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(94, 29);
            buttonRegresar.TabIndex = 1;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += button1_Click;
            // 
            // buttonCrear
            // 
            buttonCrear.Location = new Point(114, 352);
            buttonCrear.Name = "buttonCrear";
            buttonCrear.Size = new Size(94, 29);
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
            ButtonInvitado.Location = new Point(2, 3);
            ButtonInvitado.Name = "ButtonInvitado";
            ButtonInvitado.Size = new Size(506, 727);
            ButtonInvitado.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(177, 47);
            label2.Name = "label2";
            label2.Size = new Size(144, 44);
            label2.TabIndex = 22;
            label2.Text = "LOGIN ";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.DimGray;
            linkLabel1.Location = new Point(179, 693);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(163, 20);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Acceder como invitado";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // buttonAcceder
            // 
            buttonAcceder.BackgroundImage = (Image)resources.GetObject("buttonAcceder.BackgroundImage");
            buttonAcceder.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAcceder.Location = new Point(205, 285);
            buttonAcceder.Name = "buttonAcceder";
            buttonAcceder.Size = new Size(86, 92);
            buttonAcceder.TabIndex = 4;
            buttonAcceder.Text = "    ";
            buttonAcceder.UseVisualStyleBackColor = true;
            buttonAcceder.Click += buttonAcceder_Click;
            // 
            // textBoxContrasena1
            // 
            textBoxContrasena1.Location = new Point(152, 204);
            textBoxContrasena1.Name = "textBoxContrasena1";
            textBoxContrasena1.PasswordChar = '*';
            textBoxContrasena1.PlaceholderText = "Contrasena";
            textBoxContrasena1.Size = new Size(175, 27);
            textBoxContrasena1.TabIndex = 2;
            textBoxContrasena1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxCuenta1
            // 
            textBoxCuenta1.Location = new Point(149, 145);
            textBoxCuenta1.Name = "textBoxCuenta1";
            textBoxCuenta1.PlaceholderText = "Cuenta";
            textBoxCuenta1.Size = new Size(179, 27);
            textBoxCuenta1.TabIndex = 1;
            textBoxCuenta1.TextAlign = HorizontalAlignment.Center;
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.LinkColor = Color.Gray;
            linkLabel.Location = new Point(177, 403);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new Size(159, 20);
            linkLabel.TabIndex = 0;
            linkLabel.TabStop = true;
            linkLabel.Text = "Aun no eres miembro?";
            linkLabel.LinkClicked += linkLabel_LinkClicked;
            // 
            // Crear_cuenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 728);
            Controls.Add(ButtonInvitado);
            Controls.Add(SignUp);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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

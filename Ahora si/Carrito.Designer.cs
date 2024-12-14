namespace Ahora_si
{
    partial class Carrito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carrito));
            buttonPagar = new Button();
            buttonVaciar = new Button();
            richTextBoxCarrito = new RichTextBox();
            buttonCancelar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonPagar
            // 
            buttonPagar.BackgroundImage = (Image)resources.GetObject("buttonPagar.BackgroundImage");
            buttonPagar.FlatStyle = FlatStyle.Flat;
            buttonPagar.Location = new Point(108, 395);
            buttonPagar.Name = "buttonPagar";
            buttonPagar.Size = new Size(90, 80);
            buttonPagar.TabIndex = 0;
            buttonPagar.UseVisualStyleBackColor = true;
            // 
            // buttonVaciar
            // 
            buttonVaciar.BackgroundImage = (Image)resources.GetObject("buttonVaciar.BackgroundImage");
            buttonVaciar.FlatStyle = FlatStyle.Flat;
            buttonVaciar.Location = new Point(281, 395);
            buttonVaciar.Name = "buttonVaciar";
            buttonVaciar.Size = new Size(66, 78);
            buttonVaciar.TabIndex = 1;
            buttonVaciar.UseVisualStyleBackColor = true;
            buttonVaciar.Click += buttonVaciar_Click;
            // 
            // richTextBoxCarrito
            // 
            richTextBoxCarrito.Enabled = false;
            richTextBoxCarrito.Location = new Point(108, 67);
            richTextBoxCarrito.Name = "richTextBoxCarrito";
            richTextBoxCarrito.Size = new Size(239, 293);
            richTextBoxCarrito.TabIndex = 2;
            richTextBoxCarrito.Text = "";
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackgroundImage = (Image)resources.GetObject("buttonCancelar.BackgroundImage");
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.Location = new Point(191, 516);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(71, 68);
            buttonCancelar.TabIndex = 3;
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(85, 9);
            label1.Name = "label1";
            label1.Size = new Size(289, 36);
            label1.TabIndex = 4;
            label1.Text = "Carrito de compras";
            // 
            // Carrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(455, 633);
            Controls.Add(label1);
            Controls.Add(buttonCancelar);
            Controls.Add(richTextBoxCarrito);
            Controls.Add(buttonVaciar);
            Controls.Add(buttonPagar);
            Name = "Carrito";
            Text = "Carrito";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPagar;
        private Button buttonVaciar;
        private RichTextBox richTextBoxCarrito;
        private Button buttonCancelar;
        private Label label1;
    }
}
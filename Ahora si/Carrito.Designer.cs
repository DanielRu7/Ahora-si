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
            buttonPagar = new Button();
            buttonVaciar = new Button();
            richTextBoxCarrito = new RichTextBox();
            buttonCancelar = new Button();
            SuspendLayout();
            // 
            // buttonPagar
            // 
            buttonPagar.Location = new Point(254, 321);
            buttonPagar.Name = "buttonPagar";
            buttonPagar.Size = new Size(75, 23);
            buttonPagar.TabIndex = 0;
            buttonPagar.Text = "Pagar";
            buttonPagar.UseVisualStyleBackColor = true;
            // 
            // buttonVaciar
            // 
            buttonVaciar.Location = new Point(416, 321);
            buttonVaciar.Name = "buttonVaciar";
            buttonVaciar.Size = new Size(136, 23);
            buttonVaciar.TabIndex = 1;
            buttonVaciar.Text = "Vaciar carro";
            buttonVaciar.UseVisualStyleBackColor = true;
            buttonVaciar.Click += buttonVaciar_Click;
            // 
            // richTextBoxCarrito
            // 
            richTextBoxCarrito.Location = new Point(217, 51);
            richTextBoxCarrito.Name = "richTextBoxCarrito";
            richTextBoxCarrito.Size = new Size(349, 182);
            richTextBoxCarrito.TabIndex = 2;
            richTextBoxCarrito.Text = "";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(705, 408);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(83, 30);
            buttonCancelar.TabIndex = 3;
            buttonCancelar.Text = "Canacelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // Carrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCancelar);
            Controls.Add(richTextBoxCarrito);
            Controls.Add(buttonVaciar);
            Controls.Add(buttonPagar);
            Name = "Carrito";
            Text = "Carrito";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonPagar;
        private Button buttonVaciar;
        private RichTextBox richTextBoxCarrito;
        private Button buttonCancelar;
    }
}
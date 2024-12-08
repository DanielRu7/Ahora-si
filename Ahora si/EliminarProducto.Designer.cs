namespace Ahora_si
{
    partial class EliminarProducto
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
            textBoxIdEliminar = new TextBox();
            buttonEliminar = new Button();
            buttonCancelar = new Button();
            SuspendLayout();
            // 
            // textBoxIdEliminar
            // 
            textBoxIdEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxIdEliminar.Location = new Point(144, 85);
            textBoxIdEliminar.Name = "textBoxIdEliminar";
            textBoxIdEliminar.PlaceholderText = "id";
            textBoxIdEliminar.Size = new Size(100, 29);
            textBoxIdEliminar.TabIndex = 0;
            // 
            // buttonEliminar
            // 
            buttonEliminar.FlatStyle = FlatStyle.Flat;
            buttonEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEliminar.Location = new Point(149, 137);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(88, 33);
            buttonEliminar.TabIndex = 1;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCancelar.Location = new Point(149, 176);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(88, 33);
            buttonCancelar.TabIndex = 2;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // EliminarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 241);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonEliminar);
            Controls.Add(textBoxIdEliminar);
            Name = "EliminarProducto";
            Text = "EliminarProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxIdEliminar;
        private Button buttonEliminar;
        private Button buttonCancelar;
    }
}
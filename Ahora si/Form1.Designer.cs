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
            panel1 = new Panel();
            etiquetaputa = new Label();
            button2 = new Button();
            button1 = new Button();
            Risa = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(etiquetaputa);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Risa);
            panel1.Location = new Point(11, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 424);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // etiquetaputa
            // 
            etiquetaputa.AutoSize = true;
            etiquetaputa.Location = new Point(553, 108);
            etiquetaputa.Name = "etiquetaputa";
            etiquetaputa.Size = new Size(0, 20);
            etiquetaputa.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(447, 276);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(276, 31);
            button2.TabIndex = 2;
            button2.Text = "puto el que me apriete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(299, 276);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Risa
            // 
            Risa.AutoSize = true;
            Risa.Location = new Point(328, 108);
            Risa.Name = "Risa";
            Risa.Size = new Size(43, 20);
            Risa.TabIndex = 0;
            Risa.Text = "Jotos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label Risa;
        private Button button1;
        private Button button2;
        private Label etiquetaputa;
    }
}

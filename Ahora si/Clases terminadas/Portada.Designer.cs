namespace Ahora_si
{
    partial class Portada
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Portada));
            panel1 = new Panel();
            lblhora = new Label();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            horafecha = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lblhora);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 450);
            panel1.TabIndex = 0;
            // 
            // lblhora
            // 
            lblhora.AutoSize = true;
            lblhora.BackColor = Color.Transparent;
            lblhora.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblhora.ForeColor = SystemColors.ActiveCaptionText;
            lblhora.Location = new Point(364, 426);
            lblhora.Name = "lblhora";
            lblhora.Size = new Size(0, 24);
            lblhora.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(342, 358);
            button1.Name = "button1";
            button1.Size = new Size(108, 52);
            button1.TabIndex = 7;
            button1.Text = "¡PLAY!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(250, 268);
            label6.Name = "label6";
            label6.Size = new Size(311, 28);
            label6.TabIndex = 6;
            label6.Text = "Alonso Herrera Benavidez";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(206, 327);
            label5.Name = "label5";
            label5.Size = new Size(416, 28);
            label5.TabIndex = 5;
            label5.Text = "Edson Leonardo Sánchez Montalvo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(230, 296);
            label4.Name = "label4";
            label4.Size = new Size(357, 28);
            label4.TabIndex = 4;
            label4.Text = "Diana Ruth Gutiérrez Márquez";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(258, 240);
            label3.Name = "label3";
            label3.Size = new Size(303, 28);
            label3.TabIndex = 3;
            label3.Text = "Georgina Salazar Partida";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(323, 200);
            label2.Name = "label2";
            label2.Size = new Size(148, 28);
            label2.TabIndex = 2;
            label2.Text = "CandyShop";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(297, 172);
            label1.Name = "label1";
            label1.Size = new Size(198, 28);
            label1.TabIndex = 1;
            label1.Text = "Programación II";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.uaa;
            pictureBox1.Location = new Point(292, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // horafecha
            // 
            horafecha.Enabled = true;
            horafecha.Tick += horafecha_Tick;
            // 
            // Portada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Portada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Portada";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblhora;
        private Button button1;
        private System.Windows.Forms.Timer horafecha;
    }
}
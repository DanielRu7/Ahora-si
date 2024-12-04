namespace Ahora_si
{
    partial class MenuProductos
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
            pictureBoxMenu = new PictureBox();
            labelCuenta = new Label();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            panelSidebar = new Panel();
            buttonFiniquitar = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button4 = new Button();
            button5 = new Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            button6 = new Button();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            button7 = new Button();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMenu).BeginInit();
            panel1.SuspendLayout();
            panelSidebar.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxMenu
            // 
            pictureBoxMenu.Image = Properties.Resources.barra_de_menus;
            pictureBoxMenu.Location = new Point(14, 9);
            pictureBoxMenu.Margin = new Padding(3, 4, 3, 4);
            pictureBoxMenu.Name = "pictureBoxMenu";
            pictureBoxMenu.Size = new Size(46, 48);
            pictureBoxMenu.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMenu.TabIndex = 0;
            pictureBoxMenu.TabStop = false;
            pictureBoxMenu.Click += pictureBoxMenu_Click;
            // 
            // labelCuenta
            // 
            labelCuenta.AutoSize = true;
            labelCuenta.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCuenta.ForeColor = Color.White;
            labelCuenta.Location = new Point(720, 16);
            labelCuenta.Name = "labelCuenta";
            labelCuenta.Size = new Size(108, 31);
            labelCuenta.TabIndex = 3;
            labelCuenta.Text = "Usuario";
            labelCuenta.TextAlign = ContentAlignment.MiddleLeft;
            labelCuenta.Click += labelCuenta_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(42, 42, 42);
            button2.ForeColor = Color.White;
            button2.Location = new Point(3, 240);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(186, 71);
            button2.TabIndex = 1;
            button2.Text = "editar cuenta";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(42, 42, 42);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 82);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(186, 71);
            button1.TabIndex = 0;
            button1.Text = "Log out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(42, 42, 42);
            button3.ForeColor = Color.White;
            button3.Location = new Point(3, 3);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(186, 71);
            button3.TabIndex = 2;
            button3.Text = "Parar musica";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(170, 170, 170);
            panel1.Controls.Add(pictureBoxMenu);
            panel1.Controls.Add(labelCuenta);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 65);
            panel1.TabIndex = 4;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(42, 42, 42);
            panelSidebar.Controls.Add(buttonFiniquitar);
            panelSidebar.Controls.Add(button3);
            panelSidebar.Controls.Add(button1);
            panelSidebar.Controls.Add(button2);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 65);
            panelSidebar.Margin = new Padding(3, 4, 3, 4);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(0, 535);
            panelSidebar.TabIndex = 5;
            // 
            // buttonFiniquitar
            // 
            buttonFiniquitar.BackColor = Color.FromArgb(42, 42, 42);
            buttonFiniquitar.ForeColor = Color.White;
            buttonFiniquitar.Location = new Point(3, 161);
            buttonFiniquitar.Margin = new Padding(3, 4, 3, 4);
            buttonFiniquitar.Name = "buttonFiniquitar";
            buttonFiniquitar.Size = new Size(186, 71);
            buttonFiniquitar.TabIndex = 3;
            buttonFiniquitar.Text = "Cerrar Sistema";
            buttonFiniquitar.UseVisualStyleBackColor = false;
            buttonFiniquitar.Click += buttonFiniquitar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(button7);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(914, 535);
            panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(60, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 131);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 161);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre producto";
            // 
            // button4
            // 
            button4.Location = new Point(70, 184);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 2;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(255, 184);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 5;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 161);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 4;
            label2.Text = "Nombre producto";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaptionText;
            pictureBox2.Location = new Point(245, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(118, 131);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // button6
            // 
            button6.Location = new Point(430, 184);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 8;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(420, 161);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 7;
            label3.Text = "Nombre producto";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ActiveCaptionText;
            pictureBox3.Location = new Point(420, 22);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(118, 131);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // button7
            // 
            button7.Location = new Point(617, 184);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 11;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(607, 161);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 10;
            label4.Text = "Nombre producto";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ActiveCaptionText;
            pictureBox4.Location = new Point(607, 22);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(118, 131);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // MenuProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel2);
            Controls.Add(panelSidebar);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuProductos";
            FormClosing += MenuProductos_FormClosing;
            Load += MenuProductos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxMenu).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelSidebar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private PictureBox pictureBoxMenu;
        private System.Windows.Forms.Timer sidebarTransition;
        private Button button2;
        private Button button3;
        private Label labelCuenta;
        private Panel panel1;
        private Panel panelSidebar;
        private Panel panel2;
        private Button buttonFiniquitar;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button7;
        private Label label4;
        private PictureBox pictureBox4;
        private Button button6;
        private Label label3;
        private PictureBox pictureBox3;
        private Button button5;
        private Label label2;
        private PictureBox pictureBox2;
        private Button button4;
    }
}
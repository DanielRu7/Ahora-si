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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuProductos));
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
            buttonBorrar10 = new Button();
            buttonBorrar9 = new Button();
            buttonBorrar8 = new Button();
            buttonBorrar7 = new Button();
            buttonBorrar6 = new Button();
            buttonBorrar5 = new Button();
            buttonBorrar4 = new Button();
            buttonBorrar3 = new Button();
            buttonBorrar2 = new Button();
            buttonBorrar1 = new Button();
            pictureBox10 = new PictureBox();
            label10 = new Label();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMenu).BeginInit();
            panel1.SuspendLayout();
            panelSidebar.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            button1.Location = new Point(3, 83);
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
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(buttonBorrar10);
            panel2.Controls.Add(buttonBorrar9);
            panel2.Controls.Add(buttonBorrar8);
            panel2.Controls.Add(buttonBorrar7);
            panel2.Controls.Add(buttonBorrar6);
            panel2.Controls.Add(buttonBorrar5);
            panel2.Controls.Add(buttonBorrar4);
            panel2.Controls.Add(buttonBorrar3);
            panel2.Controls.Add(buttonBorrar2);
            panel2.Controls.Add(buttonBorrar1);
            panel2.Controls.Add(pictureBox10);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(pictureBox9);
            panel2.Controls.Add(pictureBox8);
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(914, 535);
            panel2.TabIndex = 6;
            // 
            // buttonBorrar10
            // 
            buttonBorrar10.Location = new Point(737, 425);
            buttonBorrar10.Name = "buttonBorrar10";
            buttonBorrar10.Size = new Size(118, 25);
            buttonBorrar10.TabIndex = 36;
            buttonBorrar10.Tag = "9";
            buttonBorrar10.Text = "B";
            buttonBorrar10.UseVisualStyleBackColor = true;
            buttonBorrar10.Visible = false;
            // 
            // buttonBorrar9
            // 
            buttonBorrar9.Location = new Point(567, 425);
            buttonBorrar9.Name = "buttonBorrar9";
            buttonBorrar9.Size = new Size(118, 25);
            buttonBorrar9.TabIndex = 35;
            buttonBorrar9.Tag = "8";
            buttonBorrar9.Text = "B";
            buttonBorrar9.UseVisualStyleBackColor = true;
            buttonBorrar9.Visible = false;
            // 
            // buttonBorrar8
            // 
            buttonBorrar8.Location = new Point(390, 425);
            buttonBorrar8.Name = "buttonBorrar8";
            buttonBorrar8.Size = new Size(118, 25);
            buttonBorrar8.TabIndex = 34;
            buttonBorrar8.Tag = "7";
            buttonBorrar8.Text = "B";
            buttonBorrar8.UseVisualStyleBackColor = true;
            buttonBorrar8.Visible = false;
            // 
            // buttonBorrar7
            // 
            buttonBorrar7.Location = new Point(215, 425);
            buttonBorrar7.Name = "buttonBorrar7";
            buttonBorrar7.Size = new Size(118, 25);
            buttonBorrar7.TabIndex = 33;
            buttonBorrar7.Tag = "6";
            buttonBorrar7.Text = "B";
            buttonBorrar7.UseVisualStyleBackColor = true;
            buttonBorrar7.Visible = false;
            // 
            // buttonBorrar6
            // 
            buttonBorrar6.Location = new Point(31, 425);
            buttonBorrar6.Name = "buttonBorrar6";
            buttonBorrar6.Size = new Size(118, 25);
            buttonBorrar6.TabIndex = 32;
            buttonBorrar6.Tag = "5";
            buttonBorrar6.Text = "B";
            buttonBorrar6.UseVisualStyleBackColor = true;
            buttonBorrar6.Visible = false;
            // 
            // buttonBorrar5
            // 
            buttonBorrar5.Location = new Point(744, 207);
            buttonBorrar5.Name = "buttonBorrar5";
            buttonBorrar5.Size = new Size(118, 25);
            buttonBorrar5.TabIndex = 31;
            buttonBorrar5.Tag = "4";
            buttonBorrar5.Text = "B";
            buttonBorrar5.UseVisualStyleBackColor = true;
            buttonBorrar5.Visible = false;
            // 
            // buttonBorrar4
            // 
            buttonBorrar4.Location = new Point(574, 208);
            buttonBorrar4.Name = "buttonBorrar4";
            buttonBorrar4.Size = new Size(118, 25);
            buttonBorrar4.TabIndex = 30;
            buttonBorrar4.Tag = "3";
            buttonBorrar4.Text = "B";
            buttonBorrar4.UseVisualStyleBackColor = true;
            buttonBorrar4.Visible = false;
            // 
            // buttonBorrar3
            // 
            buttonBorrar3.Location = new Point(397, 208);
            buttonBorrar3.Name = "buttonBorrar3";
            buttonBorrar3.Size = new Size(118, 25);
            buttonBorrar3.TabIndex = 29;
            buttonBorrar3.Tag = "2";
            buttonBorrar3.Text = "B";
            buttonBorrar3.UseVisualStyleBackColor = true;
            buttonBorrar3.Visible = false;
            // 
            // buttonBorrar2
            // 
            buttonBorrar2.Location = new Point(222, 207);
            buttonBorrar2.Name = "buttonBorrar2";
            buttonBorrar2.Size = new Size(118, 25);
            buttonBorrar2.TabIndex = 28;
            buttonBorrar2.Tag = "1";
            buttonBorrar2.Text = "B";
            buttonBorrar2.UseVisualStyleBackColor = true;
            buttonBorrar2.Visible = false;
            // 
            // buttonBorrar1
            // 
            buttonBorrar1.Location = new Point(38, 208);
            buttonBorrar1.Name = "buttonBorrar1";
            buttonBorrar1.Size = new Size(118, 25);
            buttonBorrar1.TabIndex = 27;
            buttonBorrar1.Tag = "0";
            buttonBorrar1.Text = "B";
            buttonBorrar1.UseVisualStyleBackColor = true;
            buttonBorrar1.Visible = false;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.Transparent;
            pictureBox10.BackgroundImage = (Image)resources.GetObject("pictureBox10.BackgroundImage");
            pictureBox10.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox10.Location = new Point(737, 288);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(118, 131);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 26;
            pictureBox10.TabStop = false;
            pictureBox10.Tag = "9";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(737, 265);
            label10.Name = "label10";
            label10.Size = new Size(129, 20);
            label10.TabIndex = 25;
            label10.Text = "Nombre producto";
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.Transparent;
            pictureBox9.BackgroundImage = (Image)resources.GetObject("pictureBox9.BackgroundImage");
            pictureBox9.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox9.Location = new Point(567, 288);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(118, 131);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 24;
            pictureBox9.TabStop = false;
            pictureBox9.Tag = "8";
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.BackgroundImage = (Image)resources.GetObject("pictureBox8.BackgroundImage");
            pictureBox8.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox8.Location = new Point(390, 288);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(118, 131);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 23;
            pictureBox8.TabStop = false;
            pictureBox8.Tag = "7";
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox7.Location = new Point(215, 288);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(118, 131);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 22;
            pictureBox7.TabStop = false;
            pictureBox7.Tag = "6";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(567, 265);
            label9.Name = "label9";
            label9.Size = new Size(129, 20);
            label9.TabIndex = 21;
            label9.Text = "Nombre producto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(381, 265);
            label8.Name = "label8";
            label8.Size = new Size(129, 20);
            label8.TabIndex = 20;
            label8.Text = "Nombre producto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(205, 265);
            label7.Name = "label7";
            label7.Size = new Size(129, 20);
            label7.TabIndex = 19;
            label7.Text = "Nombre producto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 265);
            label6.Name = "label6";
            label6.Size = new Size(129, 20);
            label6.TabIndex = 18;
            label6.Text = "Nombre producto";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Location = new Point(31, 288);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(118, 131);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 17;
            pictureBox6.TabStop = false;
            pictureBox6.Tag = "5";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(744, 71);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(118, 131);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 16;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(753, 48);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 15;
            label5.Text = "Nombre producto";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(574, 71);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(118, 131);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "3";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(397, 71);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(118, 131);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "2";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(222, 71);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(118, 131);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(583, 48);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 10;
            label4.Text = "Nombre producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(398, 48);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 7;
            label3.Text = "Nombre producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 48);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 4;
            label2.Text = "Nombre producto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 48);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre producto";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(38, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "0";
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
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private Label label5;
        private PictureBox pictureBox10;
        private Label label10;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private PictureBox pictureBox6;
        private Button buttonBorrar1;
        private Button buttonBorrar10;
        private Button buttonBorrar9;
        private Button buttonBorrar8;
        private Button buttonBorrar7;
        private Button buttonBorrar6;
        private Button buttonBorrar5;
        private Button buttonBorrar4;
        private Button buttonBorrar3;
        private Button buttonBorrar2;
    }
}
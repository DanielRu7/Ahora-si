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
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBoxMenu = new PictureBox();
            panelSidebar = new FlowLayoutPanel();
            button1 = new Button();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            button3 = new Button();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMenu).BeginInit();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(pictureBoxMenu);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(914, 68);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBoxMenu
            // 
            pictureBoxMenu.Image = Properties.Resources.barra_de_menus;
            pictureBoxMenu.Location = new Point(3, 4);
            pictureBoxMenu.Margin = new Padding(3, 4, 3, 4);
            pictureBoxMenu.Name = "pictureBoxMenu";
            pictureBoxMenu.Size = new Size(47, 56);
            pictureBoxMenu.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMenu.TabIndex = 0;
            pictureBoxMenu.TabStop = false;
            pictureBoxMenu.Click += pictureBoxMenu_Click;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(42, 42, 42);
            panelSidebar.Controls.Add(button1);
            panelSidebar.Controls.Add(button2);
            panelSidebar.Controls.Add(button3);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 68);
            panelSidebar.Margin = new Padding(3, 4, 3, 4);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(193, 532);
            panelSidebar.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(42, 42, 42);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 4);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(186, 71);
            button1.TabIndex = 0;
            button1.Text = "Log out";
            button1.UseVisualStyleBackColor = false;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(42, 42, 42);
            button2.ForeColor = Color.White;
            button2.Location = new Point(3, 83);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(186, 71);
            button2.TabIndex = 1;
            button2.Text = "editar cuenta";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(42, 42, 42);
            button3.ForeColor = Color.White;
            button3.Location = new Point(3, 162);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(186, 71);
            button3.TabIndex = 2;
            button3.Text = "parar musica";
            button3.UseVisualStyleBackColor = false;
            // 
            // MenuProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panelSidebar);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuProductos";
            Text = "MenuProductos";
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxMenu).EndInit();
            panelSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel panelSidebar;
        private Button button1;
        private PictureBox pictureBoxMenu;
        private System.Windows.Forms.Timer sidebarTransition;
        private Button button2;
        private Button button3;
    }
}
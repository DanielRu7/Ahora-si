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
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 51);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBoxMenu
            // 
            pictureBoxMenu.Image = Properties.Resources.barra_de_menus;
            pictureBoxMenu.Location = new Point(3, 3);
            pictureBoxMenu.Name = "pictureBoxMenu";
            pictureBoxMenu.Size = new Size(41, 42);
            pictureBoxMenu.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMenu.TabIndex = 0;
            pictureBoxMenu.TabStop = false;
            pictureBoxMenu.Click += pictureBoxMenu_Click;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(42, 42, 42);
            panelSidebar.Controls.Add(button1);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 51);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(169, 399);
            panelSidebar.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(42, 42, 42);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(163, 53);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // MenuProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelSidebar);
            Controls.Add(flowLayoutPanel1);
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
    }
}
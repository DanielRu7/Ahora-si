﻿namespace Ahora_si
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
            pictureBoxMusica = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox11 = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBoxMusica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
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
            pictureBoxMenu.BackColor = Color.White;
            pictureBoxMenu.Image = Properties.Resources.barra_de_menus;
            pictureBoxMenu.Location = new Point(6, 7);
            pictureBoxMenu.Name = "pictureBoxMenu";
            pictureBoxMenu.Size = new Size(40, 36);
            pictureBoxMenu.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMenu.TabIndex = 0;
            pictureBoxMenu.TabStop = false;
            // 
            // labelCuenta
            // 
            labelCuenta.AutoSize = true;
            labelCuenta.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold);
            labelCuenta.ForeColor = Color.Transparent;
            labelCuenta.Location = new Point(841, 8);
            labelCuenta.Name = "labelCuenta";
            labelCuenta.Size = new Size(118, 36);
            labelCuenta.TabIndex = 3;
            labelCuenta.Text = "Usuario";
            labelCuenta.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(42, 42, 42);
            button2.Font = new Font("Segoe UI", 11.25F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 54);
            button2.Name = "button2";
            button2.Size = new Size(170, 53);
            button2.TabIndex = 1;
            button2.Text = "Editar cuenta";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(42, 42, 42);
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 417);
            button1.Name = "button1";
            button1.Size = new Size(170, 53);
            button1.TabIndex = 0;
            button1.Text = "Cerrar sesión";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(42, 42, 42);
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Size = new Size(170, 53);
            button3.TabIndex = 2;
            button3.Text = "Stop Music";
            button3.UseVisualStyleBackColor = false;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBoxMenu);
            panel1.Controls.Add(labelCuenta);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(971, 49);
            panel1.TabIndex = 4;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(42, 42, 42);
            panelSidebar.BorderStyle = BorderStyle.FixedSingle;
            panelSidebar.Controls.Add(pictureBoxMusica);
            panelSidebar.Controls.Add(pictureBox13);
            panelSidebar.Controls.Add(pictureBox12);
            panelSidebar.Controls.Add(pictureBox11);
            panelSidebar.Controls.Add(buttonFiniquitar);
            panelSidebar.Controls.Add(button3);
            panelSidebar.Controls.Add(button1);
            panelSidebar.Controls.Add(button2);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 49);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(0, 525);
            panelSidebar.TabIndex = 5;
            // 
            // pictureBoxMusica
            // 
            pictureBoxMusica.Image = Properties.Resources.boton_de_pausa;
            pictureBoxMusica.Location = new Point(9, 7);
            pictureBoxMusica.Name = "pictureBoxMusica";
            pictureBoxMusica.Size = new Size(30, 38);
            pictureBoxMusica.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMusica.TabIndex = 7;
            pictureBoxMusica.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.Image = Properties.Resources.perfil_del_usuario;
            pictureBox13.Location = new Point(10, 65);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(29, 31);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 6;
            pictureBox13.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = Properties.Resources.poder;
            pictureBox12.Location = new Point(10, 486);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(26, 23);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 5;
            pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.cerrar_sesion;
            pictureBox11.Location = new Point(9, 430);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(26, 28);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 4;
            pictureBox11.TabStop = false;
            // 
            // buttonFiniquitar
            // 
            buttonFiniquitar.BackColor = Color.FromArgb(42, 42, 42);
            buttonFiniquitar.Font = new Font("Segoe UI", 11.25F);
            buttonFiniquitar.ForeColor = Color.White;
            buttonFiniquitar.Location = new Point(0, 471);
            buttonFiniquitar.Name = "buttonFiniquitar";
            buttonFiniquitar.Size = new Size(170, 53);
            buttonFiniquitar.TabIndex = 3;
            buttonFiniquitar.Text = "Cerrar sistema";
            buttonFiniquitar.UseVisualStyleBackColor = false;
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
            panel2.Location = new Point(0, 49);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(971, 525);
            panel2.TabIndex = 6;
            // 
            // buttonBorrar10
            // 
            buttonBorrar10.Font = new Font("Segoe UI", 12F);
            buttonBorrar10.Location = new Point(790, 455);
            buttonBorrar10.Margin = new Padding(3, 2, 3, 2);
            buttonBorrar10.Name = "buttonBorrar10";
            buttonBorrar10.Size = new Size(103, 38);
            buttonBorrar10.TabIndex = 36;
            buttonBorrar10.Text = "Borrar";
            buttonBorrar10.UseVisualStyleBackColor = true;
            // 
            // buttonBorrar9
            // 
            buttonBorrar9.Font = new Font("Segoe UI", 12F);
            buttonBorrar9.Location = new Point(613, 455);
            buttonBorrar9.Margin = new Padding(3, 2, 3, 2);
            buttonBorrar9.Name = "buttonBorrar9";
            buttonBorrar9.Size = new Size(103, 38);
            buttonBorrar9.TabIndex = 35;
            buttonBorrar9.Text = "Borrar";
            buttonBorrar9.UseVisualStyleBackColor = true;
            // 
            // buttonBorrar8
            // 
            buttonBorrar8.Font = new Font("Segoe UI", 12F);
            buttonBorrar8.Location = new Point(435, 455);
            buttonBorrar8.Margin = new Padding(3, 2, 3, 2);
            buttonBorrar8.Name = "buttonBorrar8";
            buttonBorrar8.Size = new Size(103, 38);
            buttonBorrar8.TabIndex = 34;
            buttonBorrar8.Text = "Borrar";
            buttonBorrar8.UseVisualStyleBackColor = true;
            // 
            // buttonBorrar7
            // 
            buttonBorrar7.Font = new Font("Segoe UI", 12F);
            buttonBorrar7.Location = new Point(255, 455);
            buttonBorrar7.Margin = new Padding(3, 2, 3, 2);
            buttonBorrar7.Name = "buttonBorrar7";
            buttonBorrar7.Size = new Size(103, 38);
            buttonBorrar7.TabIndex = 33;
            buttonBorrar7.Text = "Borrar";
            buttonBorrar7.UseVisualStyleBackColor = true;
            // 
            // buttonBorrar6
            // 
            buttonBorrar6.Font = new Font("Segoe UI", 12F);
            buttonBorrar6.Location = new Point(80, 455);
            buttonBorrar6.Margin = new Padding(3, 2, 3, 2);
            buttonBorrar6.Name = "buttonBorrar6";
            buttonBorrar6.Size = new Size(103, 38);
            buttonBorrar6.TabIndex = 32;
            buttonBorrar6.Text = "Borrar";
            buttonBorrar6.UseVisualStyleBackColor = true;
            // 
            // buttonBorrar5
            // 
            buttonBorrar5.Font = new Font("Segoe UI", 12F);
            buttonBorrar5.Location = new Point(790, 198);
            buttonBorrar5.Margin = new Padding(3, 2, 3, 2);
            buttonBorrar5.Name = "buttonBorrar5";
            buttonBorrar5.Size = new Size(103, 38);
            buttonBorrar5.TabIndex = 31;
            buttonBorrar5.Text = "Borrar";
            buttonBorrar5.UseVisualStyleBackColor = true;
            // 
            // buttonBorrar4
            // 
            buttonBorrar4.Font = new Font("Segoe UI", 12F);
            buttonBorrar4.Location = new Point(613, 198);
            buttonBorrar4.Margin = new Padding(3, 2, 3, 2);
            buttonBorrar4.Name = "buttonBorrar4";
            buttonBorrar4.Size = new Size(103, 38);
            buttonBorrar4.TabIndex = 30;
            buttonBorrar4.Text = "Borrar";
            buttonBorrar4.UseVisualStyleBackColor = true;
            // 
            // buttonBorrar3
            // 
            buttonBorrar3.Font = new Font("Segoe UI", 12F);
            buttonBorrar3.Location = new Point(435, 198);
            buttonBorrar3.Margin = new Padding(3, 2, 3, 2);
            buttonBorrar3.Name = "buttonBorrar3";
            buttonBorrar3.Size = new Size(103, 38);
            buttonBorrar3.TabIndex = 29;
            buttonBorrar3.Text = "Borrar";
            buttonBorrar3.UseVisualStyleBackColor = true;
            // 
            // buttonBorrar2
            // 
            buttonBorrar2.Font = new Font("Segoe UI", 12F);
            buttonBorrar2.Location = new Point(255, 198);
            buttonBorrar2.Margin = new Padding(3, 2, 3, 2);
            buttonBorrar2.Name = "buttonBorrar2";
            buttonBorrar2.Size = new Size(103, 38);
            buttonBorrar2.TabIndex = 28;
            buttonBorrar2.Text = "Borrar";
            buttonBorrar2.UseVisualStyleBackColor = true;
            // 
            // buttonBorrar1
            // 
            buttonBorrar1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBorrar1.Location = new Point(80, 198);
            buttonBorrar1.Margin = new Padding(3, 2, 3, 2);
            buttonBorrar1.Name = "buttonBorrar1";
            buttonBorrar1.Size = new Size(103, 38);
            buttonBorrar1.TabIndex = 27;
            buttonBorrar1.Text = "Borrar";
            buttonBorrar1.UseVisualStyleBackColor = true;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.Transparent;
            pictureBox10.BackgroundImage = Properties.Resources.botonagregar_removebg_preview1;
            pictureBox10.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox10.Location = new Point(777, 318);
            pictureBox10.Margin = new Padding(3, 2, 3, 2);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(129, 124);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 26;
            pictureBox10.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(777, 273);
            label10.Name = "label10";
            label10.Size = new Size(135, 21);
            label10.TabIndex = 25;
            label10.Text = "Nombre producto";
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.Transparent;
            pictureBox9.BackgroundImage = Properties.Resources.botonagregar_removebg_preview1;
            pictureBox9.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox9.Location = new Point(600, 318);
            pictureBox9.Margin = new Padding(3, 2, 3, 2);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(129, 124);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 24;
            pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.BackgroundImage = Properties.Resources.botonagregar_removebg_preview1;
            pictureBox8.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox8.Location = new Point(421, 318);
            pictureBox8.Margin = new Padding(3, 2, 3, 2);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(129, 124);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 23;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.BackgroundImage = Properties.Resources.botonagregar_removebg_preview1;
            pictureBox7.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox7.Location = new Point(242, 318);
            pictureBox7.Margin = new Padding(3, 2, 3, 2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(129, 124);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 22;
            pictureBox7.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(600, 273);
            label9.Name = "label9";
            label9.Size = new Size(135, 21);
            label9.TabIndex = 21;
            label9.Text = "Nombre producto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(421, 273);
            label8.Name = "label8";
            label8.Size = new Size(135, 21);
            label8.TabIndex = 20;
            label8.Text = "Nombre producto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(243, 273);
            label7.Name = "label7";
            label7.Size = new Size(135, 21);
            label7.TabIndex = 19;
            label7.Text = "Nombre producto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(66, 272);
            label6.Name = "label6";
            label6.Size = new Size(135, 21);
            label6.TabIndex = 18;
            label6.Text = "Nombre producto";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.BackgroundImage = Properties.Resources.botonagregar_removebg_preview1;
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Location = new Point(66, 318);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(129, 124);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 17;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImage = Properties.Resources.botonagregar_removebg_preview;
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(777, 68);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(129, 124);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 16;
            pictureBox5.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(776, 33);
            label5.Name = "label5";
            label5.Size = new Size(135, 21);
            label5.TabIndex = 15;
            label5.Text = "Nombre producto";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = Properties.Resources.botonagregar_removebg_preview;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(600, 68);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(129, 124);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.botonagregar_removebg_preview;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(421, 68);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(129, 124);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.botonagregar_removebg_preview;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(242, 68);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(129, 124);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(598, 33);
            label4.Name = "label4";
            label4.Size = new Size(135, 21);
            label4.TabIndex = 10;
            label4.Text = "Nombre producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(420, 33);
            label3.Name = "label3";
            label3.Size = new Size(135, 21);
            label3.TabIndex = 7;
            label3.Text = "Nombre producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(242, 33);
            label2.Name = "label2";
            label2.Size = new Size(135, 21);
            label2.TabIndex = 4;
            label2.Text = "Nombre producto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(65, 33);
            label1.Name = "label1";
            label1.Size = new Size(135, 21);
            label1.TabIndex = 1;
            label1.Text = "Nombre producto";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.botonagregar_removebg_preview;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(66, 68);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MenuProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 574);
            Controls.Add(panel2);
            Controls.Add(panelSidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuProductos";
            FormClosing += MenuProductos_FormClosing;
            Load += MenuProductos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxMenu).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxMusica).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
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
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBoxMusica;
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
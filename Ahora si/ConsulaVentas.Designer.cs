namespace Ahora_si
{
    partial class ConsulaVentas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            Grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            labelGanancias = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grafica).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Grafica);
            panel1.Controls.Add(labelGanancias);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // Grafica
            // 
            chartArea1.Name = "ChartArea1";
            Grafica.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            Grafica.Legends.Add(legend1);
            Grafica.Location = new Point(31, 89);
            Grafica.Name = "Grafica";
            Grafica.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.BorderWidth = 10;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Ganancias";
            Grafica.Series.Add(series1);
            Grafica.Size = new Size(738, 349);
            Grafica.TabIndex = 33;
            Grafica.Text = "Grafica";
            // 
            // labelGanancias
            // 
            labelGanancias.AutoSize = true;
            labelGanancias.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGanancias.ForeColor = SystemColors.ActiveCaptionText;
            labelGanancias.Location = new Point(252, 9);
            labelGanancias.Name = "labelGanancias";
            labelGanancias.Size = new Size(0, 28);
            labelGanancias.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(234, 28);
            label2.TabIndex = 31;
            label2.Text = "Ganancias Totales:";
            // 
            // ConsulaVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "ConsulaVentas";
            Text = "ConsulaVentas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Grafica).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label labelGanancias;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grafica;
    }
}
namespace Zad_1_Graf
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.WykresBleduKwantyzacji = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.WykresBleduKwantyzacji)).BeginInit();
            this.SuspendLayout();
            // 
            // WykresBleduKwantyzacji
            // 
            this.WykresBleduKwantyzacji.AccessibleName = "WykresBleduKwantyzacji";
            chartArea1.AxisX.Title = "Ilosc Iteracji";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            chartArea1.AxisY.Title = "Dokladnosc";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            chartArea1.Name = "Dokladnosc";
            this.WykresBleduKwantyzacji.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.WykresBleduKwantyzacji.Legends.Add(legend1);
            this.WykresBleduKwantyzacji.Location = new System.Drawing.Point(12, 12);
            this.WykresBleduKwantyzacji.Name = "WykresBleduKwantyzacji";
            series1.ChartArea = "Dokladnosc";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Dane 1";
            series2.ChartArea = "Dokladnosc";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "Dane 2";
            this.WykresBleduKwantyzacji.Series.Add(series1);
            this.WykresBleduKwantyzacji.Series.Add(series2);
            this.WykresBleduKwantyzacji.Size = new System.Drawing.Size(1150, 727);
            this.WykresBleduKwantyzacji.TabIndex = 1;
            this.WykresBleduKwantyzacji.Text = "WykresBledu";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title1.Name = "Wykres Błędu Kwantyzacji";
            title1.Text = "Wykres Błędu Kwantyzacji";
            this.WykresBleduKwantyzacji.Titles.Add(title1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 752);
            this.Controls.Add(this.WykresBleduKwantyzacji);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.WykresBleduKwantyzacji)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart WykresBleduKwantyzacji;
    }
}
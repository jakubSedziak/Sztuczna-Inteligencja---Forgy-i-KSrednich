namespace Zad_1_Graf
{
    partial class Form1
    {
        /// <sumry>
        /// Required designer variable.
        /// </sumry>
        private System.ComponentModel.IContainer components = null;

        /// <sumry>
        /// Clean up any resources being used.
        /// </sumry>
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

        /// <sumry>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </sumry>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Wykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label21 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.iloscK = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Wykres)).BeginInit();
            this.SuspendLayout();
            // 
            // Wykres
            // 
            this.Wykres.AccessibleName = "";
            chartArea1.AxisX.Title = "Ilosc Iteracji";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            chartArea1.AxisY.Title = "Dokladnosc";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            chartArea1.Name = "Dokladnosc";
            this.Wykres.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Wykres.Legends.Add(legend1);
            this.Wykres.Location = new System.Drawing.Point(33, 41);
            this.Wykres.Name = "Wykres";
            series1.ChartArea = "Dokladnosc";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Dane 1";
            series2.ChartArea = "Dokladnosc";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "Dane 2";
            series3.ChartArea = "Dokladnosc";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Dane 3";
            this.Wykres.Series.Add(series1);
            this.Wykres.Series.Add(series2);
            this.Wykres.Series.Add(series3);
            this.Wykres.Size = new System.Drawing.Size(1150, 727);
            this.Wykres.TabIndex = 0;
            this.Wykres.Text = "Wykres";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title1.Name = "Title1";
            this.Wykres.Titles.Add(title1);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1211, 44);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(14, 13);
            this.label21.TabIndex = 26;
            this.label21.Text = "K";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1235, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 86);
            this.button2.TabIndex = 31;
            this.button2.Text = "zad2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // iloscK
            // 
            this.iloscK.AutoCompleteCustomSource.AddRange(new string[] {
            "6",
            "12",
            "30"});
            this.iloscK.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.iloscK.FormattingEnabled = true;
            this.iloscK.Items.AddRange(new object[] {
            "6",
            "12",
            "30"});
            this.iloscK.Location = new System.Drawing.Point(1241, 41);
            this.iloscK.Name = "iloscK";
            this.iloscK.Size = new System.Drawing.Size(75, 21);
            this.iloscK.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1209, 678);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Rysuj Punkty";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1209, 707);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 23);
            this.button3.TabIndex = 35;
            this.button3.Text = "Rysuj Blad";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1343, 780);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.iloscK);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.Wykres);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "K-means";
            ((System.ComponentModel.ISupportInitialize)(this.Wykres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Wykres;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox iloscK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}


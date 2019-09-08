namespace PDI_Photoshop
{
    partial class FormHistograma
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.graficoHistR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graficoHistG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graficoHistB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficoHistR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoHistG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoHistB)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.graficoHistR);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(841, 649);
            this.splitContainer1.SplitterDistance = 216;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.graficoHistG);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.graficoHistB);
            this.splitContainer2.Size = new System.Drawing.Size(841, 429);
            this.splitContainer2.SplitterDistance = 217;
            this.splitContainer2.TabIndex = 0;
            // 
            // graficoHistR
            // 
            chartArea1.Name = "ChartArea1";
            this.graficoHistR.ChartAreas.Add(chartArea1);
            this.graficoHistR.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.graficoHistR.Legends.Add(legend1);
            this.graficoHistR.Location = new System.Drawing.Point(0, 0);
            this.graficoHistR.Name = "graficoHistR";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Red;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Red";
            this.graficoHistR.Series.Add(series1);
            this.graficoHistR.Size = new System.Drawing.Size(841, 216);
            this.graficoHistR.TabIndex = 1;
            this.graficoHistR.Text = "chart1";
            // 
            // graficoHistG
            // 
            chartArea2.Name = "ChartArea1";
            this.graficoHistG.ChartAreas.Add(chartArea2);
            this.graficoHistG.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.graficoHistG.Legends.Add(legend2);
            this.graficoHistG.Location = new System.Drawing.Point(0, 0);
            this.graficoHistG.Name = "graficoHistG";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Green";
            this.graficoHistG.Series.Add(series2);
            this.graficoHistG.Size = new System.Drawing.Size(841, 217);
            this.graficoHistG.TabIndex = 0;
            this.graficoHistG.Text = "chart1";
            // 
            // graficoHistB
            // 
            chartArea3.Name = "ChartArea1";
            this.graficoHistB.ChartAreas.Add(chartArea3);
            this.graficoHistB.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.graficoHistB.Legends.Add(legend3);
            this.graficoHistB.Location = new System.Drawing.Point(0, 0);
            this.graficoHistB.Name = "graficoHistB";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.Blue;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Blue";
            this.graficoHistB.Series.Add(series3);
            this.graficoHistB.Size = new System.Drawing.Size(841, 208);
            this.graficoHistB.TabIndex = 0;
            this.graficoHistB.Text = "chart2";
            // 
            // FormHistograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 649);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormHistograma";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Histograma";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graficoHistR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoHistG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoHistB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoHistR;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoHistG;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoHistB;
    }
}
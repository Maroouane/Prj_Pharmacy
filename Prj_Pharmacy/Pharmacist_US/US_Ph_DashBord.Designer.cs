namespace Prj_Pharmacy.Pharmacist_US
{
    partial class US_Ph_DashBord
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(US_Ph_DashBord));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReload = new Guna.UI.WinForms.GunaButton();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.chart);
            this.panel1.Location = new System.Drawing.Point(77, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 605);
            this.panel1.TabIndex = 2;
            // 
            // btnReload
            // 
            this.btnReload.AnimationHoverSpeed = 0.07F;
            this.btnReload.AnimationSpeed = 0.03F;
            this.btnReload.BackColor = System.Drawing.Color.Transparent;
            this.btnReload.BaseColor = System.Drawing.Color.SpringGreen;
            this.btnReload.BorderColor = System.Drawing.Color.Black;
            this.btnReload.BorderSize = 1;
            this.btnReload.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReload.FocusedColor = System.Drawing.Color.Empty;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.Black;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageSize = new System.Drawing.Size(25, 25);
            this.btnReload.Location = new System.Drawing.Point(300, 454);
            this.btnReload.Name = "btnReload";
            this.btnReload.OnHoverBaseColor = System.Drawing.Color.Black;
            this.btnReload.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReload.OnHoverForeColor = System.Drawing.Color.SpringGreen;
            this.btnReload.OnHoverImage = null;
            this.btnReload.OnPressedColor = System.Drawing.Color.Black;
            this.btnReload.Radius = 18;
            this.btnReload.Size = new System.Drawing.Size(124, 36);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Reload";
            this.btnReload.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(199, 128);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.SpringGreen;
            series1.Legend = "Legend1";
            series1.Name = "Expired Medicines";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.Name = "Valid Medicines";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(300, 300);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(353, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "DashBord";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // US_Ph_DashBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "US_Ph_DashBord";
            this.Size = new System.Drawing.Size(859, 770);
            this.Load += new System.EventHandler(this.US_Ph_DashBord_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnReload;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}

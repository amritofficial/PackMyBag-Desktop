namespace WindowsFormsApplication1
{
    partial class GenerateStats
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateStats));
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.btnHome = new Bunifu.Framework.UI.BunifuImageButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
			this.label1 = new System.Windows.Forms.Label();
			this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
			this.profit = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.bunifuCircleProgressbar2 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.bunifuCircleProgressbar3 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.profit)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.White;
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.btnHome);
			this.panel3.Location = new System.Drawing.Point(366, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(586, 67);
			this.panel3.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(145, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(302, 29);
			this.label2.TabIndex = 2;
			this.label2.Text = "G E N E R A T E  S T A T S";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnHome
			// 
			this.btnHome.BackColor = System.Drawing.Color.Transparent;
			this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
			this.btnHome.ImageActive = null;
			this.btnHome.Location = new System.Drawing.Point(9, 14);
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(52, 41);
			this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnHome.TabIndex = 0;
			this.btnHome.TabStop = false;
			this.btnHome.Zoom = 10;
			this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(137)))));
			this.panel2.Controls.Add(this.bunifuImageButton5);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.bunifuImageButton4);
			this.panel2.Location = new System.Drawing.Point(-2, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(367, 67);
			this.panel2.TabIndex = 2;
			// 
			// bunifuImageButton5
			// 
			this.bunifuImageButton5.BackColor = System.Drawing.Color.Transparent;
			this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
			this.bunifuImageButton5.ImageActive = null;
			this.bunifuImageButton5.Location = new System.Drawing.Point(256, 11);
			this.bunifuImageButton5.Name = "bunifuImageButton5";
			this.bunifuImageButton5.Size = new System.Drawing.Size(18, 18);
			this.bunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton5.TabIndex = 2;
			this.bunifuImageButton5.TabStop = false;
			this.bunifuImageButton5.Zoom = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(82, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(168, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "P a c k  M y  B a g";
			// 
			// bunifuImageButton4
			// 
			this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
			this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
			this.bunifuImageButton4.ImageActive = null;
			this.bunifuImageButton4.Location = new System.Drawing.Point(1, -3);
			this.bunifuImageButton4.Name = "bunifuImageButton4";
			this.bunifuImageButton4.Size = new System.Drawing.Size(95, 67);
			this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton4.TabIndex = 0;
			this.bunifuImageButton4.TabStop = false;
			this.bunifuImageButton4.Zoom = 10;
			// 
			// profit
			// 
			this.profit.BackSecondaryColor = System.Drawing.Color.Transparent;
			this.profit.BorderlineColor = System.Drawing.Color.Transparent;
			chartArea1.Name = "ChartArea1";
			this.profit.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.profit.Legends.Add(legend1);
			this.profit.Location = new System.Drawing.Point(-2, 61);
			this.profit.Name = "profit";
			series1.BackImage = " ";
			series1.BackImageTransparentColor = System.Drawing.Color.Transparent;
			series1.BackSecondaryColor = System.Drawing.Color.Transparent;
			series1.BorderColor = System.Drawing.Color.Purple;
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series1.Color = System.Drawing.Color.Red;
			series1.Legend = "Legend1";
			series1.Name = "Profits";
			this.profit.Series.Add(series1);
			this.profit.Size = new System.Drawing.Size(864, 284);
			this.profit.TabIndex = 4;
			this.profit.Text = "Profits";
			title1.Name = "Title1";
			title1.Text = "Profits";
			this.profit.Titles.Add(title1);
			// 
			// bunifuCircleProgressbar2
			// 
			this.bunifuCircleProgressbar2.animated = false;
			this.bunifuCircleProgressbar2.animationIterval = 5;
			this.bunifuCircleProgressbar2.animationSpeed = 300;
			this.bunifuCircleProgressbar2.BackColor = System.Drawing.Color.Transparent;
			this.bunifuCircleProgressbar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar2.BackgroundImage")));
			this.bunifuCircleProgressbar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
			this.bunifuCircleProgressbar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(2)))), ((int)(((byte)(152)))));
			this.bunifuCircleProgressbar2.LabelVisible = true;
			this.bunifuCircleProgressbar2.LineProgressThickness = 8;
			this.bunifuCircleProgressbar2.LineThickness = 5;
			this.bunifuCircleProgressbar2.Location = new System.Drawing.Point(15, 9);
			this.bunifuCircleProgressbar2.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
			this.bunifuCircleProgressbar2.MaxValue = 100;
			this.bunifuCircleProgressbar2.Name = "bunifuCircleProgressbar2";
			this.bunifuCircleProgressbar2.ProgressBackColor = System.Drawing.Color.Gainsboro;
			this.bunifuCircleProgressbar2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(2)))), ((int)(((byte)(152)))));
			this.bunifuCircleProgressbar2.Size = new System.Drawing.Size(136, 136);
			this.bunifuCircleProgressbar2.TabIndex = 6;
			this.bunifuCircleProgressbar2.Value = 62;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.bunifuCircleProgressbar2);
			this.panel1.Location = new System.Drawing.Point(70, 365);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(310, 156);
			this.panel1.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(181, 28);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(93, 24);
			this.label3.TabIndex = 7;
			this.label3.Text = "U S E R S";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.panel4.Controls.Add(this.bunifuCircleProgressbar3);
			this.panel4.Location = new System.Drawing.Point(474, 365);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(310, 156);
			this.panel4.TabIndex = 8;
			// 
			// bunifuCircleProgressbar3
			// 
			this.bunifuCircleProgressbar3.animated = false;
			this.bunifuCircleProgressbar3.animationIterval = 5;
			this.bunifuCircleProgressbar3.animationSpeed = 300;
			this.bunifuCircleProgressbar3.BackColor = System.Drawing.Color.Transparent;
			this.bunifuCircleProgressbar3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar3.BackgroundImage")));
			this.bunifuCircleProgressbar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
			this.bunifuCircleProgressbar3.ForeColor = System.Drawing.Color.SeaGreen;
			this.bunifuCircleProgressbar3.LabelVisible = true;
			this.bunifuCircleProgressbar3.LineProgressThickness = 8;
			this.bunifuCircleProgressbar3.LineThickness = 5;
			this.bunifuCircleProgressbar3.Location = new System.Drawing.Point(15, 9);
			this.bunifuCircleProgressbar3.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
			this.bunifuCircleProgressbar3.MaxValue = 100;
			this.bunifuCircleProgressbar3.Name = "bunifuCircleProgressbar3";
			this.bunifuCircleProgressbar3.ProgressBackColor = System.Drawing.Color.Gainsboro;
			this.bunifuCircleProgressbar3.ProgressColor = System.Drawing.Color.SeaGreen;
			this.bunifuCircleProgressbar3.Size = new System.Drawing.Size(136, 136);
			this.bunifuCircleProgressbar3.TabIndex = 6;
			this.bunifuCircleProgressbar3.Value = 55;
			// 
			// GenerateStats
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(860, 542);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.profit);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.MaximizeBox = false;
			this.Name = "GenerateStats";
			this.Text = "GenerateStats";
			this.Load += new System.EventHandler(this.GenerateStats_Load);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.profit)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton btnHome;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton5;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private System.Windows.Forms.DataVisualization.Charting.Chart profit;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar3;
        private System.Windows.Forms.Label label3;
    }
}
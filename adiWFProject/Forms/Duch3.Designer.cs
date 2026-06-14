namespace adiWFProject
{
    partial class Duch3
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
            this.cmJourney = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalRegistered = new System.Windows.Forms.Label();
            this.chartTribes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartTribes)).BeginInit();
            this.SuspendLayout();
            // 
            // cmJourney
            // 
            this.cmJourney.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmJourney.FormattingEnabled = true;
            this.cmJourney.Location = new System.Drawing.Point(551, 76);
            this.cmJourney.Name = "cmJourney";
            this.cmJourney.Size = new System.Drawing.Size(151, 28);
            this.cmJourney.TabIndex = 0;
            this.cmJourney.DropDown += new System.EventHandler(this.cmJourney_SelectedIndexChanged);
            this.cmJourney.DropDownStyleChanged += new System.EventHandler(this.cmJourney_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "רשומים לפי מסע";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(714, 79);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "בחר טיול:";
            // 
            // lblTotalRegistered
            // 
            this.lblTotalRegistered.AutoSize = true;
            this.lblTotalRegistered.Location = new System.Drawing.Point(81, 405);
            this.lblTotalRegistered.Name = "lblTotalRegistered";
            this.lblTotalRegistered.Size = new System.Drawing.Size(153, 20);
            this.lblTotalRegistered.TabIndex = 3;
            this.lblTotalRegistered.Text = "סה\"כ רשומים לטיול: 0";
            // 
            // chartTribes
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTribes.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTribes.Legends.Add(legend1);
            this.chartTribes.Location = new System.Drawing.Point(147, 120);
            this.chartTribes.Name = "chartTribes";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTribes.Series.Add(series1);
            this.chartTribes.Size = new System.Drawing.Size(463, 244);
            this.chartTribes.TabIndex = 4;
            this.chartTribes.Text = "chart1";
            // 
            // Duch3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartTribes);
            this.Controls.Add(this.lblTotalRegistered);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmJourney);
            this.Name = "Duch3";
            this.Text = "Duch3";
            this.Load += new System.EventHandler(this.Duch3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTribes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmJourney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalRegistered;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTribes;
    }
}
namespace adiWFProject.Forms
{
    partial class menuForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.חניכיםToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.התנתקותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.מסעותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.רישוםלמסעToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.מסעחדשToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.פעולותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.דווחעלפעולהToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.חוותדעתעלהפעולהToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.חניכיםToolStripMenuItem,
            this.התנתקותToolStripMenuItem,
            this.מסעותToolStripMenuItem,
            this.פעולותToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // חניכיםToolStripMenuItem
            // 
            this.חניכיםToolStripMenuItem.Name = "חניכיםToolStripMenuItem";
            this.חניכיםToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.חניכיםToolStripMenuItem.Text = "חניכים";
            this.חניכיםToolStripMenuItem.Click += new System.EventHandler(this.חניכיםToolStripMenuItem_Click);
            // 
            // התנתקותToolStripMenuItem
            // 
            this.התנתקותToolStripMenuItem.Name = "התנתקותToolStripMenuItem";
            this.התנתקותToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.התנתקותToolStripMenuItem.Text = "התנתקות";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(568, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(649, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // מסעותToolStripMenuItem
            // 
            this.מסעותToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.רישוםלמסעToolStripMenuItem,
            this.מסעחדשToolStripMenuItem});
            this.מסעותToolStripMenuItem.Name = "מסעותToolStripMenuItem";
            this.מסעותToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.מסעותToolStripMenuItem.Text = "מסעות";
            // 
            // רישוםלמסעToolStripMenuItem
            // 
            this.רישוםלמסעToolStripMenuItem.Name = "רישוםלמסעToolStripMenuItem";
            this.רישוםלמסעToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.רישוםלמסעToolStripMenuItem.Text = "רישום למסע";
            this.רישוםלמסעToolStripMenuItem.Click += new System.EventHandler(this.רישוםלמסעToolStripMenuItem_Click);
            // 
            // מסעחדשToolStripMenuItem
            // 
            this.מסעחדשToolStripMenuItem.Name = "מסעחדשToolStripMenuItem";
            this.מסעחדשToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.מסעחדשToolStripMenuItem.Text = "מסע חדש";
            this.מסעחדשToolStripMenuItem.Click += new System.EventHandler(this.מסעחדשToolStripMenuItem_Click);
            // 
            // פעולותToolStripMenuItem
            // 
            this.פעולותToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.דווחעלפעולהToolStripMenuItem,
            this.חוותדעתעלהפעולהToolStripMenuItem});
            this.פעולותToolStripMenuItem.Name = "פעולותToolStripMenuItem";
            this.פעולותToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.פעולותToolStripMenuItem.Text = "פעולות";
            // 
            // דווחעלפעולהToolStripMenuItem
            // 
            this.דווחעלפעולהToolStripMenuItem.Name = "דווחעלפעולהToolStripMenuItem";
            this.דווחעלפעולהToolStripMenuItem.Size = new System.Drawing.Size(279, 34);
            this.דווחעלפעולהToolStripMenuItem.Text = "דווח על פעולה";
            this.דווחעלפעולהToolStripMenuItem.Click += new System.EventHandler(this.דווחעלפעולהToolStripMenuItem_Click);
            // 
            // חוותדעתעלהפעולהToolStripMenuItem
            // 
            this.חוותדעתעלהפעולהToolStripMenuItem.Name = "חוותדעתעלהפעולהToolStripMenuItem";
            this.חוותדעתעלהפעולהToolStripMenuItem.Size = new System.Drawing.Size(279, 34);
            this.חוותדעתעלהפעולהToolStripMenuItem.Text = "חוות דעת על הפעולה";
            this.חוותדעתעלהפעולהToolStripMenuItem.Click += new System.EventHandler(this.חוותדעתעלהפעולהToolStripMenuItem_Click);
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menuForm";
            this.Text = "menuForm";
            this.Load += new System.EventHandler(this.menuForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem חניכיםToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem התנתקותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem מסעותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem רישוםלמסעToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem מסעחדשToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem פעולותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem דווחעלפעולהToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem חוותדעתעלהפעולהToolStripMenuItem;
    }
}
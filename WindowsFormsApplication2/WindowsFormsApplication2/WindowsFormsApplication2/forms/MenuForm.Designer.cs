namespace WindowsFormsApplication2
{
    partial class MenuForm
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
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ספריםToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.דוחותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.רשימתמלאיToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.מכירותבתקופתזמןToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.m1,
            this.MenuItemOrder,
            this.דוחותToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1040, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "טופס קניה";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ספריםToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.customerToolStripMenuItem.Text = "טבלאות";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(171, 34);
            this.toolStripMenuItem1.Text = "לקוחות";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ספריםToolStripMenuItem
            // 
            this.ספריםToolStripMenuItem.Name = "ספריםToolStripMenuItem";
            this.ספריםToolStripMenuItem.Size = new System.Drawing.Size(171, 34);
            this.ספריםToolStripMenuItem.Text = "ספרים";
            this.ספריםToolStripMenuItem.Click += new System.EventHandler(this.ספריםToolStripMenuItem_Click);
            // 
            // m1
            // 
            this.m1.Name = "m1";
            this.m1.Size = new System.Drawing.Size(122, 29);
            this.m1.Text = "טופס מכירה";
            this.m1.Click += new System.EventHandler(this.טופסמכירהToolStripMenuItem_Click);
            // 
            // MenuItemOrder
            // 
            this.MenuItemOrder.Name = "MenuItemOrder";
            this.MenuItemOrder.Size = new System.Drawing.Size(109, 29);
            this.MenuItemOrder.Text = "טופס קניה";
            this.MenuItemOrder.Click += new System.EventHandler(this.MenuItemOrder_Click);
            // 
            // דוחותToolStripMenuItem
            // 
            this.דוחותToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.רשימתמלאיToolStripMenuItem,
            this.מכירותבתקופתזמןToolStripMenuItem});
            this.דוחותToolStripMenuItem.Name = "דוחותToolStripMenuItem";
            this.דוחותToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            this.דוחותToolStripMenuItem.Text = "דוחות";
            this.דוחותToolStripMenuItem.Click += new System.EventHandler(this.דוחותToolStripMenuItem_Click);
            // 
            // רשימתמלאיToolStripMenuItem
            // 
            this.רשימתמלאיToolStripMenuItem.Name = "רשימתמלאיToolStripMenuItem";
            this.רשימתמלאיToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.רשימתמלאיToolStripMenuItem.Text = "רשימת מלאי";
            this.רשימתמלאיToolStripMenuItem.Click += new System.EventHandler(this.רשימתמלאיToolStripMenuItem_Click);
            // 
            // מכירותבתקופתזמןToolStripMenuItem
            // 
            this.מכירותבתקופתזמןToolStripMenuItem.Name = "מכירותבתקופתזמןToolStripMenuItem";
            this.מכירותבתקופתזמןToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.מכירותבתקופתזמןToolStripMenuItem.Text = "מכירות בתקופת זמן";
            this.מכירותבתקופתזמןToolStripMenuItem.Click += new System.EventHandler(this.מכירותבתקופתזמןToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.Stud_04;
            this.pictureBox1.Location = new System.Drawing.Point(236, 151);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 286);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(860, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(798, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(921, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "שלום";
            this.label3.Visible = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 669);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem m1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem דוחותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem רשימתמלאיToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem מכירותבתקופתזמןToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ספריםToolStripMenuItem;
    }
}


namespace adiWFProject
{
    partial class Duch2
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
            this.cmShevet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmSort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPupils = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblYoungest = new System.Windows.Forms.Label();
            this.lblPupilCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPupils)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmShevet
            // 
            this.cmShevet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmShevet.FormattingEnabled = true;
            this.cmShevet.Location = new System.Drawing.Point(812, 94);
            this.cmShevet.Name = "cmShevet";
            this.cmShevet.Size = new System.Drawing.Size(85, 28);
            this.cmShevet.TabIndex = 0;
            this.cmShevet.SelectedIndexChanged += new System.EventHandler(this.cmShevet_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(903, 96);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "בחר שבט:";
            // 
            // cmSort
            // 
            this.cmSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmSort.FormattingEnabled = true;
            this.cmSort.Items.AddRange(new object[] {
            "תאריך לידה",
            "שמות פרטיים",
            "שמות משפחה",
            "כתובת",
            "בית ספר"});
            this.cmSort.Location = new System.Drawing.Point(502, 94);
            this.cmSort.Name = "cmSort";
            this.cmSort.Size = new System.Drawing.Size(139, 28);
            this.cmSort.TabIndex = 2;
            this.cmSort.SelectedIndexChanged += new System.EventHandler(this.cmSort_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(647, 96);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "מיין לפי:";
            // 
            // dgvPupils
            // 
            this.dgvPupils.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPupils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPupils.Location = new System.Drawing.Point(431, 208);
            this.dgvPupils.Name = "dgvPupils";
            this.dgvPupils.RowHeadersWidth = 62;
            this.dgvPupils.RowTemplate.Height = 28;
            this.dgvPupils.Size = new System.Drawing.Size(768, 444);
            this.dgvPupils.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblYoungest);
            this.groupBox1.Controls.Add(this.lblPupilCount);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(48, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 251);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "נתוני שבט";
            // 
            // lblYoungest
            // 
            this.lblYoungest.AutoSize = true;
            this.lblYoungest.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYoungest.Location = new System.Drawing.Point(74, 202);
            this.lblYoungest.Name = "lblYoungest";
            this.lblYoungest.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblYoungest.Size = new System.Drawing.Size(141, 21);
            this.lblYoungest.TabIndex = 6;
            this.lblYoungest.Text = "החניך הצעיר צעיר: ";
            // 
            // lblPupilCount
            // 
            this.lblPupilCount.AutoSize = true;
            this.lblPupilCount.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPupilCount.Location = new System.Drawing.Point(91, 93);
            this.lblPupilCount.Name = "lblPupilCount";
            this.lblPupilCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPupilCount.Size = new System.Drawing.Size(109, 21);
            this.lblPupilCount.TabIndex = 7;
            this.lblPupilCount.Text = "כמות החניכים:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(509, 21);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(464, 54);
            this.label3.TabIndex = 6;
            this.label3.Text = "מיון חניכים לפי קטגוריה:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Duch2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1487, 696);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPupils);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmSort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmShevet);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Duch2";
            this.Text = "Duch2";
            this.Load += new System.EventHandler(this.Duch2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPupils)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmShevet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPupils;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblYoungest;
        private System.Windows.Forms.Label lblPupilCount;
        private System.Windows.Forms.Label label3;
    }
}
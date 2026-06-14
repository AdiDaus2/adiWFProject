namespace adiWFProject
{
    partial class Duch1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmAge = new System.Windows.Forms.ComboBox();
            this.dgvActivities = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalVotes = new System.Windows.Forms.Label();
            this.lblTopAction = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "חיפוש פעולות והערכתן לפי גיל";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(382, 94);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(156, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "בחר גיל החניכים:";
            // 
            // cmAge
            // 
            this.cmAge.BackColor = System.Drawing.SystemColors.Window;
            this.cmAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmAge.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmAge.FormattingEnabled = true;
            this.cmAge.Location = new System.Drawing.Point(295, 98);
            this.cmAge.Name = "cmAge";
            this.cmAge.Size = new System.Drawing.Size(81, 28);
            this.cmAge.TabIndex = 2;
            this.cmAge.SelectedIndexChanged += new System.EventHandler(this.cmAge_SelectedIndexChanged);
            // 
            // dgvActivities
            // 
            this.dgvActivities.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivities.Location = new System.Drawing.Point(339, 141);
            this.dgvActivities.Name = "dgvActivities";
            this.dgvActivities.RowHeadersWidth = 62;
            this.dgvActivities.RowTemplate.Height = 28;
            this.dgvActivities.Size = new System.Drawing.Size(449, 261);
            this.dgvActivities.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox1.Controls.Add(this.lblTotalVotes);
            this.groupBox1.Controls.Add(this.lblTopAction);
            this.groupBox1.Controls.Add(this.lblCount);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(333, 214);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "סיכום נתונים:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblTotalVotes
            // 
            this.lblTotalVotes.AutoSize = true;
            this.lblTotalVotes.Location = new System.Drawing.Point(15, 173);
            this.lblTotalVotes.Name = "lblTotalVotes";
            this.lblTotalVotes.Size = new System.Drawing.Size(144, 25);
            this.lblTotalVotes.TabIndex = 2;
            this.lblTotalVotes.Text = "כמות המדרגים: 0";
            this.lblTotalVotes.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTopAction
            // 
            this.lblTopAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTopAction.AutoSize = true;
            this.lblTopAction.Location = new System.Drawing.Point(15, 109);
            this.lblTopAction.Name = "lblTopAction";
            this.lblTopAction.Size = new System.Drawing.Size(177, 25);
            this.lblTopAction.TabIndex = 1;
            this.lblTopAction.Text = "הדירוג הגבוה ביותר: -";
            this.lblTopAction.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCount.Location = new System.Drawing.Point(15, 44);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(133, 25);
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "נמצאו 0 פעולות";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Duch1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvActivities);
            this.Controls.Add(this.cmAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Duch1";
            this.Text = "Duch1";
            this.Load += new System.EventHandler(this.Duch1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmAge;
        private System.Windows.Forms.DataGridView dgvActivities;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalVotes;
        private System.Windows.Forms.Label lblTopAction;
        private System.Windows.Forms.Label lblCount;
    }
}
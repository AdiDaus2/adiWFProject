namespace adiWFProject
{
    partial class activityReportForm
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.rating = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.activityDate = new System.Windows.Forms.Label();
            this.CANCEL = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.staffID = new System.Windows.Forms.Label();
            this.opinion = new System.Windows.Forms.Label();
            this.parashatShavua = new System.Windows.Forms.Label();
            this.participantAmount = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.activityNum = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(544, 311);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker.TabIndex = 76;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(14, 248);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.Size = new System.Drawing.Size(483, 274);
            this.dataGridView.TabIndex = 75;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.update.Location = new System.Drawing.Point(332, 548);
            this.update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(112, 35);
            this.update.TabIndex = 74;
            this.update.Text = "עדכן";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add.Location = new System.Drawing.Point(194, 548);
            this.add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(112, 35);
            this.add.TabIndex = 73;
            this.add.Text = "הוסף";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.search.Location = new System.Drawing.Point(321, 155);
            this.search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(112, 35);
            this.search.TabIndex = 72;
            this.search.Text = "חפש";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(540, 434);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox3.Size = new System.Drawing.Size(140, 26);
            this.textBox3.TabIndex = 71;
            // 
            // rating
            // 
            this.rating.AutoSize = true;
            this.rating.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rating.ForeColor = System.Drawing.Color.Navy;
            this.rating.Location = new System.Drawing.Point(694, 557);
            this.rating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rating.Name = "rating";
            this.rating.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rating.Size = new System.Drawing.Size(141, 29);
            this.rating.TabIndex = 69;
            this.rating.Text = "דירוג (1-10):";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(177, 40);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(620, 83);
            this.title.TabIndex = 68;
            this.title.Text = "חוות דעת על הפעולה";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(540, 375);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(140, 26);
            this.textBox2.TabIndex = 67;
            // 
            // activityDate
            // 
            this.activityDate.AutoSize = true;
            this.activityDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityDate.ForeColor = System.Drawing.Color.Navy;
            this.activityDate.Location = new System.Drawing.Point(752, 308);
            this.activityDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.activityDate.Name = "activityDate";
            this.activityDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.activityDate.Size = new System.Drawing.Size(166, 29);
            this.activityDate.TabIndex = 66;
            this.activityDate.Text = "תאריך הפעולה:";
            // 
            // CANCEL
            // 
            this.CANCEL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CANCEL.Location = new System.Drawing.Point(57, 548);
            this.CANCEL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(112, 35);
            this.CANCEL.TabIndex = 65;
            this.CANCEL.Text = "מחק";
            this.CANCEL.UseVisualStyleBackColor = false;
            this.CANCEL.Click += new System.EventHandler(this.CANCEL_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(540, 495);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox4.Size = new System.Drawing.Size(140, 26);
            this.textBox4.TabIndex = 63;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(548, 251);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(140, 26);
            this.textBox1.TabIndex = 62;
            // 
            // staffID
            // 
            this.staffID.AutoSize = true;
            this.staffID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffID.ForeColor = System.Drawing.Color.Navy;
            this.staffID.Location = new System.Drawing.Point(694, 248);
            this.staffID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.staffID.Name = "staffID";
            this.staffID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.staffID.Size = new System.Drawing.Size(301, 29);
            this.staffID.TabIndex = 61;
            this.staffID.Text = "הת.ז. של המדריך.ה הממלא: ";
            // 
            // opinion
            // 
            this.opinion.AutoSize = true;
            this.opinion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opinion.ForeColor = System.Drawing.Color.Navy;
            this.opinion.Location = new System.Drawing.Point(694, 495);
            this.opinion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.opinion.Name = "opinion";
            this.opinion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.opinion.Size = new System.Drawing.Size(125, 29);
            this.opinion.TabIndex = 60;
            this.opinion.Text = "משוב אישי:";
            // 
            // parashatShavua
            // 
            this.parashatShavua.AutoSize = true;
            this.parashatShavua.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parashatShavua.ForeColor = System.Drawing.Color.Navy;
            this.parashatShavua.Location = new System.Drawing.Point(694, 435);
            this.parashatShavua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.parashatShavua.Name = "parashatShavua";
            this.parashatShavua.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.parashatShavua.Size = new System.Drawing.Size(153, 29);
            this.parashatShavua.TabIndex = 59;
            this.parashatShavua.Text = "פרשת השבוע:";
            // 
            // participantAmount
            // 
            this.participantAmount.AutoSize = true;
            this.participantAmount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.participantAmount.ForeColor = System.Drawing.Color.Navy;
            this.participantAmount.Location = new System.Drawing.Point(694, 371);
            this.participantAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.participantAmount.Name = "participantAmount";
            this.participantAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.participantAmount.Size = new System.Drawing.Size(194, 29);
            this.participantAmount.TabIndex = 58;
            this.participantAmount.Text = "מספר החניכים.ות:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(440, 160);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(74, 28);
            this.comboBox1.TabIndex = 77;
            // 
            // activityNum
            // 
            this.activityNum.AutoSize = true;
            this.activityNum.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityNum.ForeColor = System.Drawing.Color.Navy;
            this.activityNum.Location = new System.Drawing.Point(520, 160);
            this.activityNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.activityNum.Name = "activityNum";
            this.activityNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.activityNum.Size = new System.Drawing.Size(132, 24);
            this.activityNum.TabIndex = 78;
            this.activityNum.Text = "מספר הפעולה:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(540, 562);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 28);
            this.comboBox2.TabIndex = 79;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // activityReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 691);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.activityNum);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.search);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.title);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.activityDate);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.staffID);
            this.Controls.Add(this.opinion);
            this.Controls.Add(this.parashatShavua);
            this.Controls.Add(this.participantAmount);
            this.Name = "activityReportForm";
            this.Text = "activityReport";
            this.Load += new System.EventHandler(this.activityReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label rating;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label activityDate;
        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label staffID;
        private System.Windows.Forms.Label opinion;
        private System.Windows.Forms.Label parashatShavua;
        private System.Windows.Forms.Label participantAmount;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label activityNum;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}
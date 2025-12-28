namespace adiWFProject
{
    partial class activitiesForm
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
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.maxAge = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this.CANCEL = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.staffID = new System.Windows.Forms.Label();
            this.minAge = new System.Windows.Forms.Label();
            this.activityDescrip = new System.Windows.Forms.Label();
            this.activityNum = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.update.Location = new System.Drawing.Point(341, 419);
            this.update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(112, 35);
            this.update.TabIndex = 53;
            this.update.Text = "עדכן";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add.Location = new System.Drawing.Point(203, 419);
            this.add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(112, 35);
            this.add.TabIndex = 52;
            this.add.Text = "הוסף";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.search.Location = new System.Drawing.Point(627, 130);
            this.search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(112, 35);
            this.search.TabIndex = 51;
            this.search.Text = "חפש";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(630, 312);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox3.Size = new System.Drawing.Size(140, 26);
            this.textBox3.TabIndex = 49;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(387, 135);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox6.Name = "textBox6";
            this.textBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox6.Size = new System.Drawing.Size(190, 26);
            this.textBox6.TabIndex = 48;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // maxAge
            // 
            this.maxAge.AutoSize = true;
            this.maxAge.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxAge.ForeColor = System.Drawing.Color.Navy;
            this.maxAge.Location = new System.Drawing.Point(778, 425);
            this.maxAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxAge.Name = "maxAge";
            this.maxAge.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.maxAge.Size = new System.Drawing.Size(251, 29);
            this.maxAge.TabIndex = 44;
            this.maxAge.Text = "גיל מקסימלי של חניך.ה:";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(364, 21);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(391, 83);
            this.title.TabIndex = 43;
            this.title.Text = "פעולה חדשה";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(630, 260);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(140, 26);
            this.textBox2.TabIndex = 41;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.ForeColor = System.Drawing.Color.Navy;
            this.address.Location = new System.Drawing.Point(267, 200);
            this.address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.address.Name = "address";
            this.address.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.address.Size = new System.Drawing.Size(238, 29);
            this.address.TabIndex = 40;
            this.address.Text = "תאריך כתיבת הפעולה:";
            // 
            // CANCEL
            // 
            this.CANCEL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CANCEL.Location = new System.Drawing.Point(67, 419);
            this.CANCEL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(112, 35);
            this.CANCEL.TabIndex = 39;
            this.CANCEL.Text = "מחק";
            this.CANCEL.UseVisualStyleBackColor = false;
            this.CANCEL.Click += new System.EventHandler(this.CANCEL_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(630, 427);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox5.Size = new System.Drawing.Size(140, 26);
            this.textBox5.TabIndex = 38;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(630, 367);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox4.Size = new System.Drawing.Size(140, 26);
            this.textBox4.TabIndex = 36;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(630, 204);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(140, 26);
            this.textBox1.TabIndex = 35;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // staffID
            // 
            this.staffID.AutoSize = true;
            this.staffID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffID.ForeColor = System.Drawing.Color.Navy;
            this.staffID.Location = new System.Drawing.Point(778, 202);
            this.staffID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.staffID.Name = "staffID";
            this.staffID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.staffID.Size = new System.Drawing.Size(411, 29);
            this.staffID.TabIndex = 34;
            this.staffID.Text = "הת.ז. של המדריך.ה הממלא את הטופס: ";
            // 
            // minAge
            // 
            this.minAge.AutoSize = true;
            this.minAge.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minAge.ForeColor = System.Drawing.Color.Navy;
            this.minAge.Location = new System.Drawing.Point(778, 365);
            this.minAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minAge.Name = "minAge";
            this.minAge.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.minAge.Size = new System.Drawing.Size(238, 29);
            this.minAge.TabIndex = 33;
            this.minAge.Text = "גיל מינימלי של חניך.ה:";
            // 
            // activityDescrip
            // 
            this.activityDescrip.AutoSize = true;
            this.activityDescrip.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityDescrip.ForeColor = System.Drawing.Color.Navy;
            this.activityDescrip.Location = new System.Drawing.Point(778, 310);
            this.activityDescrip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.activityDescrip.Name = "activityDescrip";
            this.activityDescrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.activityDescrip.Size = new System.Drawing.Size(222, 29);
            this.activityDescrip.TabIndex = 32;
            this.activityDescrip.Text = "תיאור מהלך הפעולה:";
            // 
            // activityNum
            // 
            this.activityNum.AutoSize = true;
            this.activityNum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityNum.ForeColor = System.Drawing.Color.Navy;
            this.activityNum.Location = new System.Drawing.Point(778, 259);
            this.activityNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.activityNum.Name = "activityNum";
            this.activityNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.activityNum.Size = new System.Drawing.Size(160, 29);
            this.activityNum.TabIndex = 31;
            this.activityNum.Text = "מספר הפעולה:";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(17, 245);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.Size = new System.Drawing.Size(483, 164);
            this.dataGridView.TabIndex = 56;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(32, 202);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 57;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // activitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 531);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.search);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.maxAge);
            this.Controls.Add(this.title);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.address);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.staffID);
            this.Controls.Add(this.minAge);
            this.Controls.Add(this.activityDescrip);
            this.Controls.Add(this.activityNum);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "activitiesForm";
            this.Text = "activities";
            this.Load += new System.EventHandler(this.activitiesForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label maxAge;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label staffID;
        private System.Windows.Forms.Label minAge;
        private System.Windows.Forms.Label activityDescrip;
        private System.Windows.Forms.Label activityNum;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
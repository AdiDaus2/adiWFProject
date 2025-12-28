namespace adiWFProject.Forms
{
    partial class staffForm
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
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.schoolName = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.phoneNum = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.cityName = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.birthDate = new System.Windows.Forms.Label();
            this.CANCEL = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.staffID = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.tribeName = new System.Windows.Forms.Label();
            this.staffName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.IDStaff = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(142, 126);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox9.Name = "textBox9";
            this.textBox9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox9.Size = new System.Drawing.Size(140, 26);
            this.textBox9.TabIndex = 130;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // schoolName
            // 
            this.schoolName.AutoSize = true;
            this.schoolName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolName.ForeColor = System.Drawing.Color.Navy;
            this.schoolName.Location = new System.Drawing.Point(657, 517);
            this.schoolName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.schoolName.Name = "schoolName";
            this.schoolName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.schoolName.Size = new System.Drawing.Size(106, 29);
            this.schoolName.TabIndex = 129;
            this.schoolName.Text = "בית ספר:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(618, 556);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox8.Name = "textBox8";
            this.textBox8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox8.Size = new System.Drawing.Size(140, 26);
            this.textBox8.TabIndex = 128;
            // 
            // phoneNum
            // 
            this.phoneNum.AutoSize = true;
            this.phoneNum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNum.ForeColor = System.Drawing.Color.Navy;
            this.phoneNum.Location = new System.Drawing.Point(657, 410);
            this.phoneNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneNum.Name = "phoneNum";
            this.phoneNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.phoneNum.Size = new System.Drawing.Size(139, 29);
            this.phoneNum.TabIndex = 127;
            this.phoneNum.Text = "מספר טלפון:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(506, 411);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox5.Size = new System.Drawing.Size(140, 26);
            this.textBox5.TabIndex = 126;
            // 
            // cityName
            // 
            this.cityName.AutoSize = true;
            this.cityName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityName.ForeColor = System.Drawing.Color.Navy;
            this.cityName.Location = new System.Drawing.Point(661, 465);
            this.cityName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityName.Name = "cityName";
            this.cityName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cityName.Size = new System.Drawing.Size(128, 29);
            this.cityName.TabIndex = 125;
            this.cityName.Text = "עיר מגורים:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(506, 519);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox7.Name = "textBox7";
            this.textBox7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox7.Size = new System.Drawing.Size(140, 26);
            this.textBox7.TabIndex = 124;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(506, 237);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(144, 26);
            this.dateTimePicker.TabIndex = 122;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(31, 219);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.Size = new System.Drawing.Size(365, 169);
            this.dataGridView.TabIndex = 121;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.update.Location = new System.Drawing.Point(293, 465);
            this.update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(112, 35);
            this.update.TabIndex = 120;
            this.update.Text = "עדכן";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add.Location = new System.Drawing.Point(155, 465);
            this.add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(112, 35);
            this.add.TabIndex = 119;
            this.add.Text = "הוסף";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.search.Location = new System.Drawing.Point(293, 121);
            this.search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(112, 35);
            this.search.TabIndex = 118;
            this.search.Text = "חפש";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(506, 297);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox3.Size = new System.Drawing.Size(140, 26);
            this.textBox3.TabIndex = 117;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(506, 467);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox6.Name = "textBox6";
            this.textBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox6.Size = new System.Drawing.Size(140, 26);
            this.textBox6.TabIndex = 116;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(333, 9);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(262, 83);
            this.title.TabIndex = 115;
            this.title.Text = "מדריכים";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(506, 180);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(140, 26);
            this.textBox2.TabIndex = 114;
            // 
            // birthDate
            // 
            this.birthDate.AutoSize = true;
            this.birthDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDate.ForeColor = System.Drawing.Color.Navy;
            this.birthDate.Location = new System.Drawing.Point(661, 239);
            this.birthDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.birthDate.Name = "birthDate";
            this.birthDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.birthDate.Size = new System.Drawing.Size(137, 29);
            this.birthDate.TabIndex = 113;
            this.birthDate.Text = "תאריך לידה:";
            // 
            // CANCEL
            // 
            this.CANCEL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CANCEL.Location = new System.Drawing.Point(20, 465);
            this.CANCEL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(112, 35);
            this.CANCEL.TabIndex = 112;
            this.CANCEL.Text = "מחק";
            this.CANCEL.UseVisualStyleBackColor = false;
            this.CANCEL.Click += new System.EventHandler(this.CANCEL_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(506, 357);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox4.Size = new System.Drawing.Size(140, 26);
            this.textBox4.TabIndex = 111;
            // 
            // staffID
            // 
            this.staffID.AutoSize = true;
            this.staffID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffID.ForeColor = System.Drawing.Color.Navy;
            this.staffID.Location = new System.Drawing.Point(773, 554);
            this.staffID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.staffID.Name = "staffID";
            this.staffID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.staffID.Size = new System.Drawing.Size(136, 29);
            this.staffID.TabIndex = 109;
            this.staffID.Text = "ת.ז המדריך:";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.ForeColor = System.Drawing.Color.Navy;
            this.address.Location = new System.Drawing.Point(661, 359);
            this.address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.address.Name = "address";
            this.address.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.address.Size = new System.Drawing.Size(148, 29);
            this.address.TabIndex = 108;
            this.address.Text = "כתובת מלאה:";
            // 
            // tribeName
            // 
            this.tribeName.AutoSize = true;
            this.tribeName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tribeName.ForeColor = System.Drawing.Color.Navy;
            this.tribeName.Location = new System.Drawing.Point(661, 296);
            this.tribeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tribeName.Name = "tribeName";
            this.tribeName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tribeName.Size = new System.Drawing.Size(239, 29);
            this.tribeName.TabIndex = 107;
            this.tribeName.Text = "שם השבט אליו שייכים:";
            // 
            // staffName
            // 
            this.staffName.AutoSize = true;
            this.staffName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffName.ForeColor = System.Drawing.Color.Navy;
            this.staffName.Location = new System.Drawing.Point(661, 179);
            this.staffName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.staffName.Name = "staffName";
            this.staffName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.staffName.Size = new System.Drawing.Size(241, 29);
            this.staffName.TabIndex = 106;
            this.staffName.Text = "שם מלא של המדריך.ה:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(505, 130);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(140, 26);
            this.textBox1.TabIndex = 132;
            // 
            // IDStaff
            // 
            this.IDStaff.AutoSize = true;
            this.IDStaff.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDStaff.ForeColor = System.Drawing.Color.Navy;
            this.IDStaff.Location = new System.Drawing.Point(660, 128);
            this.IDStaff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDStaff.Name = "IDStaff";
            this.IDStaff.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.IDStaff.Size = new System.Drawing.Size(136, 29);
            this.IDStaff.TabIndex = 131;
            this.IDStaff.Text = "ת.ז המדריך:";
            // 
            // staffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 559);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.IDStaff);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.schoolName);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.phoneNum);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.cityName);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.search);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.title);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.staffID);
            this.Controls.Add(this.address);
            this.Controls.Add(this.tribeName);
            this.Controls.Add(this.staffName);
            this.Name = "staffForm";
            this.Text = "staffForm";
            this.Load += new System.EventHandler(this.staffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label schoolName;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label phoneNum;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label cityName;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label birthDate;
        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label staffID;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label tribeName;
        private System.Windows.Forms.Label staffName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label IDStaff;
    }
}

namespace adiWFProject
{
    partial class pupilForm
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
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.pupilID = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.birthDate = new System.Windows.Forms.Label();
            this.CANCEL = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.staffID = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.tribeName = new System.Windows.Forms.Label();
            this.pupilName = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.cityName = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.parentPhone = new System.Windows.Forms.Label();
            this.schoolName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(789, 597);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox7.Name = "textBox7";
            this.textBox7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox7.Size = new System.Drawing.Size(140, 26);
            this.textBox7.TabIndex = 99;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // pupilID
            // 
            this.pupilID.AutoSize = true;
            this.pupilID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pupilID.ForeColor = System.Drawing.Color.Navy;
            this.pupilID.Location = new System.Drawing.Point(944, 208);
            this.pupilID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pupilID.Name = "pupilID";
            this.pupilID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pupilID.Size = new System.Drawing.Size(177, 29);
            this.pupilID.TabIndex = 98;
            this.pupilID.Text = "ת.ז של החניך.ה:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(789, 315);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(144, 26);
            this.dateTimePicker.TabIndex = 97;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(81, 271);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.Size = new System.Drawing.Size(483, 288);
            this.dataGridView.TabIndex = 96;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.update.Location = new System.Drawing.Point(420, 611);
            this.update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(112, 35);
            this.update.TabIndex = 95;
            this.update.Text = "עדכן";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add.Location = new System.Drawing.Point(282, 611);
            this.add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(112, 35);
            this.add.TabIndex = 94;
            this.add.Text = "הוסף";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.search.Location = new System.Drawing.Point(639, 138);
            this.search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(112, 35);
            this.search.TabIndex = 93;
            this.search.Text = "חפש";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(789, 545);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox6.Name = "textBox6";
            this.textBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox6.Size = new System.Drawing.Size(140, 26);
            this.textBox6.TabIndex = 91;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(504, 46);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(220, 83);
            this.title.TabIndex = 90;
            this.title.Text = "חניכים";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(789, 258);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(140, 26);
            this.textBox2.TabIndex = 89;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // birthDate
            // 
            this.birthDate.AutoSize = true;
            this.birthDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDate.ForeColor = System.Drawing.Color.Navy;
            this.birthDate.Location = new System.Drawing.Point(944, 317);
            this.birthDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.birthDate.Name = "birthDate";
            this.birthDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.birthDate.Size = new System.Drawing.Size(137, 29);
            this.birthDate.TabIndex = 88;
            this.birthDate.Text = "תאריך לידה:";
            // 
            // CANCEL
            // 
            this.CANCEL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CANCEL.Location = new System.Drawing.Point(147, 611);
            this.CANCEL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(112, 35);
            this.CANCEL.TabIndex = 87;
            this.CANCEL.Text = "מחק";
            this.CANCEL.UseVisualStyleBackColor = false;
            this.CANCEL.Click += new System.EventHandler(this.CANCEL_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(789, 435);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox4.Size = new System.Drawing.Size(140, 26);
            this.textBox4.TabIndex = 86;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(789, 209);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(140, 26);
            this.textBox1.TabIndex = 85;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // staffID
            // 
            this.staffID.AutoSize = true;
            this.staffID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffID.ForeColor = System.Drawing.Color.Navy;
            this.staffID.Location = new System.Drawing.Point(944, 649);
            this.staffID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.staffID.Name = "staffID";
            this.staffID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.staffID.Size = new System.Drawing.Size(136, 29);
            this.staffID.TabIndex = 84;
            this.staffID.Text = "ת.ז המדריך:";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.ForeColor = System.Drawing.Color.Navy;
            this.address.Location = new System.Drawing.Point(944, 437);
            this.address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.address.Name = "address";
            this.address.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.address.Size = new System.Drawing.Size(148, 29);
            this.address.TabIndex = 83;
            this.address.Text = "כתובת מלאה:";
            this.address.Click += new System.EventHandler(this.address_Click);
            // 
            // tribeName
            // 
            this.tribeName.AutoSize = true;
            this.tribeName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tribeName.ForeColor = System.Drawing.Color.Navy;
            this.tribeName.Location = new System.Drawing.Point(944, 374);
            this.tribeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tribeName.Name = "tribeName";
            this.tribeName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tribeName.Size = new System.Drawing.Size(239, 29);
            this.tribeName.TabIndex = 82;
            this.tribeName.Text = "שם השבט אליו שייכים:";
            // 
            // pupilName
            // 
            this.pupilName.AutoSize = true;
            this.pupilName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pupilName.ForeColor = System.Drawing.Color.Navy;
            this.pupilName.Location = new System.Drawing.Point(944, 257);
            this.pupilName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pupilName.Name = "pupilName";
            this.pupilName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pupilName.Size = new System.Drawing.Size(224, 29);
            this.pupilName.TabIndex = 81;
            this.pupilName.Text = "שם מלא של החניך.ה:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(789, 489);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox5.Size = new System.Drawing.Size(140, 26);
            this.textBox5.TabIndex = 101;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // cityName
            // 
            this.cityName.AutoSize = true;
            this.cityName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityName.ForeColor = System.Drawing.Color.Navy;
            this.cityName.Location = new System.Drawing.Point(944, 543);
            this.cityName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityName.Name = "cityName";
            this.cityName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cityName.Size = new System.Drawing.Size(128, 29);
            this.cityName.TabIndex = 100;
            this.cityName.Text = "עיר מגורים:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(491, 142);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox8.Name = "textBox8";
            this.textBox8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox8.Size = new System.Drawing.Size(140, 26);
            this.textBox8.TabIndex = 103;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // parentPhone
            // 
            this.parentPhone.AutoSize = true;
            this.parentPhone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentPhone.ForeColor = System.Drawing.Color.Navy;
            this.parentPhone.Location = new System.Drawing.Point(940, 488);
            this.parentPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.parentPhone.Name = "parentPhone";
            this.parentPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.parentPhone.Size = new System.Drawing.Size(254, 29);
            this.parentPhone.TabIndex = 102;
            this.parentPhone.Text = "מספר טלפון של ההורים:";
            // 
            // schoolName
            // 
            this.schoolName.AutoSize = true;
            this.schoolName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolName.ForeColor = System.Drawing.Color.Navy;
            this.schoolName.Location = new System.Drawing.Point(940, 595);
            this.schoolName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.schoolName.Name = "schoolName";
            this.schoolName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.schoolName.Size = new System.Drawing.Size(106, 29);
            this.schoolName.TabIndex = 104;
            this.schoolName.Text = "בית ספר:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(789, 653);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 28);
            this.comboBox1.TabIndex = 105;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(789, 374);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 28);
            this.comboBox2.TabIndex = 106;
            // 
            // pupilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 705);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.schoolName);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.parentPhone);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.cityName);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.pupilID);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.search);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.title);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.staffID);
            this.Controls.Add(this.address);
            this.Controls.Add(this.tribeName);
            this.Controls.Add(this.pupilName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "pupilForm";
            this.Text = "pupilForm";
            this.Load += new System.EventHandler(this.pupilForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label pupilID;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label birthDate;
        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label staffID;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label tribeName;
        private System.Windows.Forms.Label pupilName;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label cityName;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label parentPhone;
        private System.Windows.Forms.Label schoolName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}
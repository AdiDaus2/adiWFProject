
namespace adiWFProject.Forms
{
    partial class journiesForm
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
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.maxAge = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.journyDate = new System.Windows.Forms.Label();
            this.CANCEL = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.staffID = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.place = new System.Windows.Forms.Label();
            this.daysNum = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.journeyName = new System.Windows.Forms.Label();
            this.securtiyInsure = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(577, 240);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(144, 26);
            this.dateTimePicker.TabIndex = 76;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(15, 232);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.Size = new System.Drawing.Size(421, 186);
            this.dataGridView.TabIndex = 75;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.update.Location = new System.Drawing.Point(306, 466);
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
            this.add.Location = new System.Drawing.Point(168, 466);
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
            this.search.Location = new System.Drawing.Point(465, 145);
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
            this.textBox3.Location = new System.Drawing.Point(580, 330);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox3.Size = new System.Drawing.Size(140, 26);
            this.textBox3.TabIndex = 71;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(580, 476);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox6.Name = "textBox6";
            this.textBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox6.Size = new System.Drawing.Size(140, 26);
            this.textBox6.TabIndex = 70;
            // 
            // maxAge
            // 
            this.maxAge.AutoSize = true;
            this.maxAge.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxAge.ForeColor = System.Drawing.Color.Navy;
            this.maxAge.Location = new System.Drawing.Point(813, 720);
            this.maxAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxAge.Name = "maxAge";
            this.maxAge.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.maxAge.Size = new System.Drawing.Size(251, 29);
            this.maxAge.TabIndex = 69;
            this.maxAge.Text = "גיל מקסימלי של חניך.ה:";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(325, 22);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(225, 83);
            this.title.TabIndex = 68;
            this.title.Text = "מסעות";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(580, 281);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(140, 26);
            this.textBox2.TabIndex = 67;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // journyDate
            // 
            this.journyDate.AutoSize = true;
            this.journyDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.journyDate.ForeColor = System.Drawing.Color.Navy;
            this.journyDate.Location = new System.Drawing.Point(731, 241);
            this.journyDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.journyDate.Name = "journyDate";
            this.journyDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.journyDate.Size = new System.Drawing.Size(160, 29);
            this.journyDate.TabIndex = 66;
            this.journyDate.Text = "תאריך היציאה:";
            // 
            // CANCEL
            // 
            this.CANCEL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CANCEL.Location = new System.Drawing.Point(32, 466);
            this.CANCEL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(112, 35);
            this.CANCEL.TabIndex = 65;
            this.CANCEL.Text = "מחק";
            this.CANCEL.UseVisualStyleBackColor = false;
            this.CANCEL.Click += new System.EventHandler(this.CANCEL_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(662, 722);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox5.Size = new System.Drawing.Size(140, 26);
            this.textBox5.TabIndex = 64;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(580, 379);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox4.Size = new System.Drawing.Size(140, 26);
            this.textBox4.TabIndex = 63;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(580, 195);
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
            this.staffID.Location = new System.Drawing.Point(731, 279);
            this.staffID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.staffID.Name = "staffID";
            this.staffID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.staffID.Size = new System.Drawing.Size(136, 29);
            this.staffID.TabIndex = 61;
            this.staffID.Text = "ת.ז המדריך:";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.Navy;
            this.price.Location = new System.Drawing.Point(731, 472);
            this.price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.price.Name = "price";
            this.price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.price.Size = new System.Drawing.Size(133, 29);
            this.price.TabIndex = 60;
            this.price.Text = "עלות המסע:";
            // 
            // place
            // 
            this.place.AutoSize = true;
            this.place.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.place.ForeColor = System.Drawing.Color.Navy;
            this.place.Location = new System.Drawing.Point(731, 378);
            this.place.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.place.Name = "place";
            this.place.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.place.Size = new System.Drawing.Size(78, 29);
            this.place.TabIndex = 59;
            this.place.Text = "מיקום:";
            // 
            // daysNum
            // 
            this.daysNum.AutoSize = true;
            this.daysNum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysNum.ForeColor = System.Drawing.Color.Navy;
            this.daysNum.Location = new System.Drawing.Point(731, 328);
            this.daysNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.daysNum.Name = "daysNum";
            this.daysNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.daysNum.Size = new System.Drawing.Size(207, 29);
            this.daysNum.TabIndex = 58;
            this.daysNum.Text = "מספר הימים במסע:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(314, 149);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox7.Name = "textBox7";
            this.textBox7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox7.Size = new System.Drawing.Size(140, 26);
            this.textBox7.TabIndex = 78;
            // 
            // journeyName
            // 
            this.journeyName.AutoSize = true;
            this.journeyName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.journeyName.ForeColor = System.Drawing.Color.Navy;
            this.journeyName.Location = new System.Drawing.Point(731, 193);
            this.journeyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.journeyName.Name = "journeyName";
            this.journeyName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.journeyName.Size = new System.Drawing.Size(117, 29);
            this.journeyName.TabIndex = 77;
            this.journeyName.Text = "שם המסע:";
            // 
            // securtiyInsure
            // 
            this.securtiyInsure.AutoSize = true;
            this.securtiyInsure.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.securtiyInsure.ForeColor = System.Drawing.Color.Navy;
            this.securtiyInsure.Location = new System.Drawing.Point(720, 423);
            this.securtiyInsure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.securtiyInsure.Name = "securtiyInsure";
            this.securtiyInsure.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.securtiyInsure.Size = new System.Drawing.Size(159, 29);
            this.securtiyInsure.TabIndex = 79;
            this.securtiyInsure.Text = "אישור ביטחוני:";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(612, 428);
            this.checkBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(51, 24);
            this.checkBox.TabIndex = 80;
            this.checkBox.Text = "יש";
            this.checkBox.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // journiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 555);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.securtiyInsure);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.journeyName);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.search);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.maxAge);
            this.Controls.Add(this.title);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.journyDate);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.staffID);
            this.Controls.Add(this.price);
            this.Controls.Add(this.place);
            this.Controls.Add(this.daysNum);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "journiesForm";
            this.Text = "journiesForm";
            this.Load += new System.EventHandler(this.journiesForm_Load);
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
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label maxAge;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label journyDate;
        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label staffID;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label place;
        private System.Windows.Forms.Label daysNum;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label journeyName;
        private System.Windows.Forms.Label securtiyInsure;
        private System.Windows.Forms.CheckBox checkBox;
    }
}
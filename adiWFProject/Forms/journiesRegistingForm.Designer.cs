
namespace adiWFProject
{
    partial class journiesRegistingForm
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
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.securtiyInsure = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.pupilName = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.journyDate = new System.Windows.Forms.Label();
            this.CANCEL = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.journyName = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.place = new System.Windows.Forms.Label();
            this.journeyCode = new System.Windows.Forms.Label();
            this.pupilID = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.paymentType = new System.Windows.Forms.Label();
            this.creditCardType = new System.Windows.Forms.Label();
            this.cardNum = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.JourneyCodeFiled = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(849, 321);
            this.checkBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(51, 24);
            this.checkBox.TabIndex = 3;
            this.checkBox.Text = "יש";
            this.checkBox.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // securtiyInsure
            // 
            this.securtiyInsure.AutoSize = true;
            this.securtiyInsure.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.securtiyInsure.ForeColor = System.Drawing.Color.Navy;
            this.securtiyInsure.Location = new System.Drawing.Point(957, 316);
            this.securtiyInsure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.securtiyInsure.Name = "securtiyInsure";
            this.securtiyInsure.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.securtiyInsure.Size = new System.Drawing.Size(169, 29);
            this.securtiyInsure.TabIndex = 100;
            this.securtiyInsure.Text = "הצהרת בריאות:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(465, 473);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox7.Name = "textBox7";
            this.textBox7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox7.Size = new System.Drawing.Size(140, 26);
            this.textBox7.TabIndex = 99;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // pupilName
            // 
            this.pupilName.AutoSize = true;
            this.pupilName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pupilName.ForeColor = System.Drawing.Color.Navy;
            this.pupilName.Location = new System.Drawing.Point(956, 237);
            this.pupilName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pupilName.Name = "pupilName";
            this.pupilName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pupilName.Size = new System.Drawing.Size(140, 29);
            this.pupilName.TabIndex = 98;
            this.pupilName.Text = "שם החניך.ה:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(802, 469);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(144, 26);
            this.dateTimePicker.TabIndex = 97;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(36, 253);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.Size = new System.Drawing.Size(374, 154);
            this.dataGridView.TabIndex = 96;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.update.Location = new System.Drawing.Point(298, 429);
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
            this.add.Location = new System.Drawing.Point(160, 429);
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
            this.search.Location = new System.Drawing.Point(412, 162);
            this.search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(112, 35);
            this.search.TabIndex = 93;
            this.search.Text = "חפש";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(805, 418);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox3.Size = new System.Drawing.Size(140, 26);
            this.textBox3.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(465, 412);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox6.Name = "textBox6";
            this.textBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox6.Size = new System.Drawing.Size(140, 26);
            this.textBox6.TabIndex = 91;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(384, 42);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(462, 83);
            this.title.TabIndex = 90;
            this.title.Text = ":רישום למסעות";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(806, 278);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(140, 26);
            this.textBox2.TabIndex = 2;
            // 
            // journyDate
            // 
            this.journyDate.AutoSize = true;
            this.journyDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.journyDate.ForeColor = System.Drawing.Color.Navy;
            this.journyDate.Location = new System.Drawing.Point(957, 471);
            this.journyDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.journyDate.Name = "journyDate";
            this.journyDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.journyDate.Size = new System.Drawing.Size(160, 29);
            this.journyDate.TabIndex = 88;
            this.journyDate.Text = "תאריך היציאה:";
            // 
            // CANCEL
            // 
            this.CANCEL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CANCEL.Location = new System.Drawing.Point(25, 429);
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
            this.textBox4.Location = new System.Drawing.Point(469, 237);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox4.Size = new System.Drawing.Size(140, 26);
            this.textBox4.TabIndex = 86;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(805, 239);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(140, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // journyName
            // 
            this.journyName.AutoSize = true;
            this.journyName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.journyName.ForeColor = System.Drawing.Color.Navy;
            this.journyName.Location = new System.Drawing.Point(956, 417);
            this.journyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.journyName.Name = "journyName";
            this.journyName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.journyName.Size = new System.Drawing.Size(117, 29);
            this.journyName.TabIndex = 84;
            this.journyName.Text = "שם המסע:";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.Navy;
            this.price.Location = new System.Drawing.Point(619, 291);
            this.price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.price.Name = "price";
            this.price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.price.Size = new System.Drawing.Size(133, 29);
            this.price.TabIndex = 83;
            this.price.Text = "עלות המסע:";
            // 
            // place
            // 
            this.place.AutoSize = true;
            this.place.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.place.ForeColor = System.Drawing.Color.Navy;
            this.place.Location = new System.Drawing.Point(620, 237);
            this.place.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.place.Name = "place";
            this.place.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.place.Size = new System.Drawing.Size(78, 29);
            this.place.TabIndex = 82;
            this.place.Text = "מיקום:";
            // 
            // journeyCode
            // 
            this.journeyCode.AutoSize = true;
            this.journeyCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.journeyCode.ForeColor = System.Drawing.Color.Navy;
            this.journeyCode.Location = new System.Drawing.Point(956, 367);
            this.journeyCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.journeyCode.Name = "journeyCode";
            this.journeyCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.journeyCode.Size = new System.Drawing.Size(119, 29);
            this.journeyCode.TabIndex = 81;
            this.journeyCode.Text = "קוד המסע:";
            // 
            // pupilID
            // 
            this.pupilID.AutoSize = true;
            this.pupilID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pupilID.ForeColor = System.Drawing.Color.Navy;
            this.pupilID.Location = new System.Drawing.Point(686, 163);
            this.pupilID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pupilID.Name = "pupilID";
            this.pupilID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pupilID.Size = new System.Drawing.Size(140, 29);
            this.pupilID.TabIndex = 102;
            this.pupilID.Text = "תעודת זהות:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(467, 292);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox5.Size = new System.Drawing.Size(140, 26);
            this.textBox5.TabIndex = 104;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(957, 276);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(147, 29);
            this.label2.TabIndex = 103;
            this.label2.Text = "טלפון ההורה:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "מוזמן",
            "אשראי"});
            this.comboBox2.Location = new System.Drawing.Point(465, 349);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 28);
            this.comboBox2.TabIndex = 106;
            // 
            // paymentType
            // 
            this.paymentType.AutoSize = true;
            this.paymentType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentType.ForeColor = System.Drawing.Color.Navy;
            this.paymentType.Location = new System.Drawing.Point(620, 349);
            this.paymentType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paymentType.Name = "paymentType";
            this.paymentType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.paymentType.Size = new System.Drawing.Size(142, 29);
            this.paymentType.TabIndex = 107;
            this.paymentType.Text = "סוג התשלום:";
            // 
            // creditCardType
            // 
            this.creditCardType.AutoSize = true;
            this.creditCardType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditCardType.ForeColor = System.Drawing.Color.Navy;
            this.creditCardType.Location = new System.Drawing.Point(620, 414);
            this.creditCardType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.creditCardType.Name = "creditCardType";
            this.creditCardType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.creditCardType.Size = new System.Drawing.Size(150, 29);
            this.creditCardType.TabIndex = 108;
            this.creditCardType.Text = "חברת אשראי:";
            // 
            // cardNum
            // 
            this.cardNum.AutoSize = true;
            this.cardNum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNum.ForeColor = System.Drawing.Color.Navy;
            this.cardNum.Location = new System.Drawing.Point(620, 470);
            this.cardNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cardNum.Name = "cardNum";
            this.cardNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cardNum.Size = new System.Drawing.Size(146, 29);
            this.cardNum.TabIndex = 110;
            this.cardNum.Text = "מספר כרטיס:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(538, 167);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox8.Name = "textBox8";
            this.textBox8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox8.Size = new System.Drawing.Size(140, 26);
            this.textBox8.TabIndex = 109;
            this.textBox8.Text = "22";
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // JourneyCodeFiled
            // 
            this.JourneyCodeFiled.Location = new System.Drawing.Point(792, 355);
            this.JourneyCodeFiled.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JourneyCodeFiled.Name = "JourneyCodeFiled";
            this.JourneyCodeFiled.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.JourneyCodeFiled.Size = new System.Drawing.Size(140, 26);
            this.JourneyCodeFiled.TabIndex = 4;
            // 
            // journiesRegistingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 567);
            this.Controls.Add(this.JourneyCodeFiled);
            this.Controls.Add(this.cardNum);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.creditCardType);
            this.Controls.Add(this.paymentType);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pupilID);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.securtiyInsure);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.pupilName);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.search);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.title);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.journyDate);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.journyName);
            this.Controls.Add(this.price);
            this.Controls.Add(this.place);
            this.Controls.Add(this.journeyCode);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "journiesRegistingForm";
            this.Text = "journiesRegistingForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label securtiyInsure;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label pupilName;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label journyDate;
        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label journyName;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label place;
        private System.Windows.Forms.Label journeyCode;
        private System.Windows.Forms.Label pupilID;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label paymentType;
        private System.Windows.Forms.Label creditCardType;
        private System.Windows.Forms.Label cardNum;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox JourneyCodeFiled;
    }
}
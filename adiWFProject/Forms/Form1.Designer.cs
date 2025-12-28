
namespace adiWFProject
{
    partial class Form1
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
            this.custumerNum = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.fullName = new System.Windows.Forms.Label();
            this.phoneNum = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.CANCEL = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.currentCusNum = new System.Windows.Forms.Label();
            this.birthMonth = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // custumerNum
            // 
            this.custumerNum.AutoSize = true;
            this.custumerNum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custumerNum.ForeColor = System.Drawing.Color.Navy;
            this.custumerNum.Location = new System.Drawing.Point(603, 67);
            this.custumerNum.Name = "custumerNum";
            this.custumerNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.custumerNum.Size = new System.Drawing.Size(81, 19);
            this.custumerNum.TabIndex = 0;
            this.custumerNum.Text = "מספר לקוח";
            this.custumerNum.Click += new System.EventHandler(this.name_Click);
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.ForeColor = System.Drawing.Color.Navy;
            this.lastName.Location = new System.Drawing.Point(602, 112);
            this.lastName.Name = "lastName";
            this.lastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lastName.Size = new System.Drawing.Size(86, 19);
            this.lastName.TabIndex = 1;
            this.lastName.Text = "שם משפחה";
            this.lastName.Click += new System.EventHandler(this.bookID_Click);
            // 
            // fullName
            // 
            this.fullName.AutoSize = true;
            this.fullName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullName.ForeColor = System.Drawing.Color.Navy;
            this.fullName.Location = new System.Drawing.Point(593, 162);
            this.fullName.Name = "fullName";
            this.fullName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fullName.Size = new System.Drawing.Size(97, 19);
            this.fullName.TabIndex = 2;
            this.fullName.Text = "שם פרטי מלא";
            this.fullName.Click += new System.EventHandler(this.label3_Click);
            // 
            // phoneNum
            // 
            this.phoneNum.AutoSize = true;
            this.phoneNum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNum.ForeColor = System.Drawing.Color.Navy;
            this.phoneNum.Location = new System.Drawing.Point(600, 204);
            this.phoneNum.Name = "phoneNum";
            this.phoneNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.phoneNum.Size = new System.Drawing.Size(85, 19);
            this.phoneNum.TabIndex = 3;
            this.phoneNum.Text = "מספר טלפון";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(88, 348);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(580, 106);
            this.dataGridView1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(476, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(95, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(476, 205);
            this.textBox4.Name = "textBox4";
            this.textBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox4.Size = new System.Drawing.Size(95, 20);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(476, 248);
            this.textBox5.Name = "textBox5";
            this.textBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox5.Size = new System.Drawing.Size(95, 20);
            this.textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(128, 69);
            this.textBox6.Name = "textBox6";
            this.textBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox6.Size = new System.Drawing.Size(95, 20);
            this.textBox6.TabIndex = 13;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // CANCEL
            // 
            this.CANCEL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CANCEL.Location = new System.Drawing.Point(185, 204);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(75, 23);
            this.CANCEL.TabIndex = 14;
            this.CANCEL.Text = "מחק";
            this.CANCEL.UseVisualStyleBackColor = false;
            this.CANCEL.Click += new System.EventHandler(this.CANCEL_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(476, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(95, 20);
            this.textBox2.TabIndex = 16;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.ForeColor = System.Drawing.Color.Navy;
            this.address.Location = new System.Drawing.Point(620, 247);
            this.address.Name = "address";
            this.address.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.address.Size = new System.Drawing.Size(52, 19);
            this.address.TabIndex = 15;
            this.address.Text = "כתובת";
            this.address.Click += new System.EventHandler(this.label5_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(255, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(266, 57);
            this.title.TabIndex = 18;
            this.title.Text = "טופס לקוחות";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(128, 114);
            this.textBox7.Name = "textBox7";
            this.textBox7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox7.Size = new System.Drawing.Size(95, 20);
            this.textBox7.TabIndex = 26;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(476, 163);
            this.textBox3.Name = "textBox3";
            this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox3.Size = new System.Drawing.Size(95, 20);
            this.textBox3.TabIndex = 24;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(128, 265);
            this.textBox8.Name = "textBox8";
            this.textBox8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox8.Size = new System.Drawing.Size(128, 20);
            this.textBox8.TabIndex = 23;
            // 
            // currentCusNum
            // 
            this.currentCusNum.AutoSize = true;
            this.currentCusNum.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentCusNum.ForeColor = System.Drawing.Color.Navy;
            this.currentCusNum.Location = new System.Drawing.Point(262, 261);
            this.currentCusNum.Name = "currentCusNum";
            this.currentCusNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.currentCusNum.Size = new System.Drawing.Size(180, 23);
            this.currentCusNum.TabIndex = 22;
            this.currentCusNum.Text = "הכנס מספר לקוח עדכני";
            this.currentCusNum.Click += new System.EventHandler(this.label2_Click);
            // 
            // birthMonth
            // 
            this.birthMonth.AutoSize = true;
            this.birthMonth.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthMonth.ForeColor = System.Drawing.Color.Navy;
            this.birthMonth.Location = new System.Drawing.Point(252, 161);
            this.birthMonth.Name = "birthMonth";
            this.birthMonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.birthMonth.Size = new System.Drawing.Size(98, 19);
            this.birthMonth.TabIndex = 21;
            this.birthMonth.Text = "חודש יומולדת";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.Navy;
            this.email.Location = new System.Drawing.Point(262, 113);
            this.email.Name = "email";
            this.email.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.email.Size = new System.Drawing.Size(88, 19);
            this.email.TabIndex = 20;
            this.email.Text = "אימייל עדכני";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.ForeColor = System.Drawing.Color.Navy;
            this.city.Location = new System.Drawing.Point(273, 68);
            this.city.Name = "city";
            this.city.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.city.Size = new System.Drawing.Size(77, 19);
            this.city.TabIndex = 19;
            this.city.Text = "עיר מגורים";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.search.Location = new System.Drawing.Point(30, 263);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 27;
            this.search.Text = "חפש";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add.Location = new System.Drawing.Point(273, 204);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 28;
            this.add.Text = "הוסף";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.update.Location = new System.Drawing.Point(88, 205);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 29;
            this.update.Text = "עדכן";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(128, 160);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 21);
            this.comboBox1.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.search);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.currentCusNum);
            this.Controls.Add(this.birthMonth);
            this.Controls.Add(this.email);
            this.Controls.Add(this.city);
            this.Controls.Add(this.title);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.address);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.phoneNum);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.custumerNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label custumerNum;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label fullName;
        private System.Windows.Forms.Label phoneNum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label currentCusNum;
        private System.Windows.Forms.Label birthMonth;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}


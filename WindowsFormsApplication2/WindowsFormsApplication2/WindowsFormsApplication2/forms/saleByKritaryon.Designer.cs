
namespace WindowsFormsApplication2
{
    partial class saleByKritaryon
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtNameFilter = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtsuplierFilter = new System.Windows.Forms.TextBox();
            this.txtminPrice = new System.Windows.Forms.TextBox();
            this.txtmaxPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(907, 375);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(124, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "סנן לפי תפקיד";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNameFilter
            // 
            this.txtNameFilter.Location = new System.Drawing.Point(907, 141);
            this.txtNameFilter.Name = "txtNameFilter";
            this.txtNameFilter.Size = new System.Drawing.Size(144, 26);
            this.txtNameFilter.TabIndex = 4;
            this.txtNameFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.Location = new System.Drawing.Point(28, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(823, 295);
            this.dataGridView1.TabIndex = 3;
            // 
            // txtsuplierFilter
            // 
            this.txtsuplierFilter.Location = new System.Drawing.Point(907, 197);
            this.txtsuplierFilter.Name = "txtsuplierFilter";
            this.txtsuplierFilter.Size = new System.Drawing.Size(144, 26);
            this.txtsuplierFilter.TabIndex = 6;
            // 
            // txtminPrice
            // 
            this.txtminPrice.Location = new System.Drawing.Point(907, 249);
            this.txtminPrice.Name = "txtminPrice";
            this.txtminPrice.Size = new System.Drawing.Size(144, 26);
            this.txtminPrice.TabIndex = 7;
            // 
            // txtmaxPrice
            // 
            this.txtmaxPrice.Location = new System.Drawing.Point(907, 304);
            this.txtmaxPrice.Name = "txtmaxPrice";
            this.txtmaxPrice.Size = new System.Drawing.Size(144, 26);
            this.txtmaxPrice.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1107, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "שם מוצר";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1107, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "ספק";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1107, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "ממחיר";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1107, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "עד מחיר";
            // 
            // saleByKritaryon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 535);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmaxPrice);
            this.Controls.Add(this.txtminPrice);
            this.Controls.Add(this.txtsuplierFilter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNameFilter);
            this.Controls.Add(this.dataGridView1);
            this.Name = "saleByKritaryon";
            this.Text = "saleByKritaryon";
            this.Load += new System.EventHandler(this.saleByKritaryon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNameFilter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtsuplierFilter;
        private System.Windows.Forms.TextBox txtminPrice;
        private System.Windows.Forms.TextBox txtmaxPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
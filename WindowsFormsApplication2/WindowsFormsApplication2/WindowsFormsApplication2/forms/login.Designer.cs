namespace WindowsFormsApplication2
{
    partial class login
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
            this.buttCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loginID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.loginMessage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttCheck
            // 
            this.buttCheck.Location = new System.Drawing.Point(489, 278);
            this.buttCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttCheck.Name = "buttCheck";
            this.buttCheck.Size = new System.Drawing.Size(112, 35);
            this.buttCheck.TabIndex = 0;
            this.buttCheck.Text = "התחבר";
            this.buttCheck.UseVisualStyleBackColor = true;
            this.buttCheck.Click += new System.EventHandler(this.buttCheck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(656, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "תעודת זהות";
            // 
            // loginID
            // 
            this.loginID.Location = new System.Drawing.Point(452, 120);
            this.loginID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginID.Name = "loginID";
            this.loginID.Size = new System.Drawing.Size(148, 26);
            this.loginID.TabIndex = 2;
            this.loginID.TextChanged += new System.EventHandler(this.loginID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(656, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "סיסמה";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(452, 183);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 26);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // loginMessage
            // 
            this.loginMessage.AutoSize = true;
            this.loginMessage.BackColor = System.Drawing.Color.Yellow;
            this.loginMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginMessage.Location = new System.Drawing.Point(147, 278);
            this.loginMessage.Name = "loginMessage";
            this.loginMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.loginMessage.Size = new System.Drawing.Size(27, 29);
            this.loginMessage.TabIndex = 6;
            this.loginMessage.Text = "#";
            this.loginMessage.Visible = false;
            this.loginMessage.Click += new System.EventHandler(this.loginMessage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(57, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 618);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginMessage);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttCheck);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label loginMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
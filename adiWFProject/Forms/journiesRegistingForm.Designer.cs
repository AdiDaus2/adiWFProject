
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
            this.txtCreditCardNumber = new System.Windows.Forms.TextBox();
            this.pupilName = new System.Windows.Forms.Label();
            this.dtpRegisterDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.update = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnSearchPupil = new System.Windows.Forms.Button();
            this.txtJourneyName = new System.Windows.Forms.TextBox();
            this.txtCreditCompany = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.txtParentPhoneNum = new System.Windows.Forms.TextBox();
            this.journyDate = new System.Windows.Forms.Label();
            this.CANCEL = new System.Windows.Forms.Button();
            this.txtJourneyPlace = new System.Windows.Forms.TextBox();
            this.txtPupilName = new System.Windows.Forms.TextBox();
            this.journyName = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.place = new System.Windows.Forms.Label();
            this.journeyCode = new System.Windows.Forms.Label();
            this.pupilID = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmPaymentMethod = new System.Windows.Forms.ComboBox();
            this.paymentType = new System.Windows.Forms.Label();
            this.lblCreditCompany = new System.Windows.Forms.Label();
            this.lblCreditCardNumber = new System.Windows.Forms.Label();
            this.txtPupilID = new System.Windows.Forms.TextBox();
            this.cmJourneyCode = new System.Windows.Forms.ComboBox();
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
            // txtCreditCardNumber
            // 
            this.txtCreditCardNumber.Location = new System.Drawing.Point(465, 473);
            this.txtCreditCardNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCreditCardNumber.Name = "txtCreditCardNumber";
            this.txtCreditCardNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCreditCardNumber.Size = new System.Drawing.Size(140, 26);
            this.txtCreditCardNumber.TabIndex = 99;
            this.txtCreditCardNumber.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
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
            this.pupilName.Size = new System.Drawing.Size(166, 29);
            this.pupilName.TabIndex = 98;
            this.pupilName.Text = "שם הנרשם.מת:";
            // 
            // dtpRegisterDate
            // 
            this.dtpRegisterDate.Location = new System.Drawing.Point(802, 469);
            this.dtpRegisterDate.Name = "dtpRegisterDate";
            this.dtpRegisterDate.Size = new System.Drawing.Size(144, 26);
            this.dtpRegisterDate.TabIndex = 97;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(79, 523);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.Size = new System.Drawing.Size(1033, 329);
            this.dataGridView.TabIndex = 96;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.update.Location = new System.Drawing.Point(1009, 881);
            this.update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(112, 35);
            this.update.TabIndex = 95;
            this.update.Text = "עדכן";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegister.Location = new System.Drawing.Point(871, 881);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(112, 35);
            this.btnRegister.TabIndex = 94;
            this.btnRegister.Text = "הוסף";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnSearchPupil
            // 
            this.btnSearchPupil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearchPupil.Location = new System.Drawing.Point(412, 162);
            this.btnSearchPupil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchPupil.Name = "btnSearchPupil";
            this.btnSearchPupil.Size = new System.Drawing.Size(112, 35);
            this.btnSearchPupil.TabIndex = 93;
            this.btnSearchPupil.Text = "חפש";
            this.btnSearchPupil.UseVisualStyleBackColor = false;
            this.btnSearchPupil.Click += new System.EventHandler(this.btnSearchPupil_Click);
            // 
            // txtJourneyName
            // 
            this.txtJourneyName.Location = new System.Drawing.Point(805, 418);
            this.txtJourneyName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtJourneyName.Name = "txtJourneyName";
            this.txtJourneyName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtJourneyName.Size = new System.Drawing.Size(140, 26);
            this.txtJourneyName.TabIndex = 5;
            // 
            // txtCreditCompany
            // 
            this.txtCreditCompany.Location = new System.Drawing.Point(465, 412);
            this.txtCreditCompany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCreditCompany.Name = "txtCreditCompany";
            this.txtCreditCompany.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCreditCompany.Size = new System.Drawing.Size(140, 26);
            this.txtCreditCompany.TabIndex = 91;
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
            // txtParentPhoneNum
            // 
            this.txtParentPhoneNum.Location = new System.Drawing.Point(806, 278);
            this.txtParentPhoneNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtParentPhoneNum.Name = "txtParentPhoneNum";
            this.txtParentPhoneNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtParentPhoneNum.Size = new System.Drawing.Size(140, 26);
            this.txtParentPhoneNum.TabIndex = 2;
            // 
            // journyDate
            // 
            this.journyDate.AutoSize = true;
            this.journyDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.journyDate.ForeColor = System.Drawing.Color.Navy;
            this.journyDate.Location = new System.Drawing.Point(957, 466);
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
            this.CANCEL.Location = new System.Drawing.Point(734, 881);
            this.CANCEL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(112, 35);
            this.CANCEL.TabIndex = 87;
            this.CANCEL.Text = "מחק";
            this.CANCEL.UseVisualStyleBackColor = false;
            this.CANCEL.Click += new System.EventHandler(this.CANCEL_Click);
            // 
            // txtJourneyPlace
            // 
            this.txtJourneyPlace.Location = new System.Drawing.Point(469, 237);
            this.txtJourneyPlace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtJourneyPlace.Name = "txtJourneyPlace";
            this.txtJourneyPlace.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtJourneyPlace.Size = new System.Drawing.Size(140, 26);
            this.txtJourneyPlace.TabIndex = 86;
            // 
            // txtPupilName
            // 
            this.txtPupilName.Location = new System.Drawing.Point(805, 239);
            this.txtPupilName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPupilName.Name = "txtPupilName";
            this.txtPupilName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPupilName.Size = new System.Drawing.Size(140, 26);
            this.txtPupilName.TabIndex = 1;
            this.txtPupilName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // cmPaymentMethod
            // 
            this.cmPaymentMethod.FormattingEnabled = true;
            this.cmPaymentMethod.Items.AddRange(new object[] {
            "מוזמן",
            "אשראי"});
            this.cmPaymentMethod.Location = new System.Drawing.Point(465, 349);
            this.cmPaymentMethod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmPaymentMethod.Name = "cmPaymentMethod";
            this.cmPaymentMethod.Size = new System.Drawing.Size(140, 28);
            this.cmPaymentMethod.TabIndex = 106;
            this.cmPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cmPaymentMethod_SelectedIndexChanged);
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
            // lblCreditCompany
            // 
            this.lblCreditCompany.AutoSize = true;
            this.lblCreditCompany.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCompany.ForeColor = System.Drawing.Color.Navy;
            this.lblCreditCompany.Location = new System.Drawing.Point(620, 414);
            this.lblCreditCompany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreditCompany.Name = "lblCreditCompany";
            this.lblCreditCompany.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCreditCompany.Size = new System.Drawing.Size(150, 29);
            this.lblCreditCompany.TabIndex = 108;
            this.lblCreditCompany.Text = "חברת אשראי:";
            // 
            // lblCreditCardNumber
            // 
            this.lblCreditCardNumber.AutoSize = true;
            this.lblCreditCardNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCardNumber.ForeColor = System.Drawing.Color.Navy;
            this.lblCreditCardNumber.Location = new System.Drawing.Point(620, 470);
            this.lblCreditCardNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreditCardNumber.Name = "lblCreditCardNumber";
            this.lblCreditCardNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCreditCardNumber.Size = new System.Drawing.Size(146, 29);
            this.lblCreditCardNumber.TabIndex = 110;
            this.lblCreditCardNumber.Text = "מספר כרטיס:";
            // 
            // txtPupilID
            // 
            this.txtPupilID.Location = new System.Drawing.Point(538, 167);
            this.txtPupilID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPupilID.Name = "txtPupilID";
            this.txtPupilID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPupilID.Size = new System.Drawing.Size(140, 26);
            this.txtPupilID.TabIndex = 109;
            this.txtPupilID.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // cmJourneyCode
            // 
            this.cmJourneyCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmJourneyCode.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmJourneyCode.FormattingEnabled = true;
            this.cmJourneyCode.Location = new System.Drawing.Point(805, 371);
            this.cmJourneyCode.Name = "cmJourneyCode";
            this.cmJourneyCode.Size = new System.Drawing.Size(139, 29);
            this.cmJourneyCode.TabIndex = 111;
            this.cmJourneyCode.SelectedIndexChanged += new System.EventHandler(this.cmJourneyCode_SelectedIndexChanged);
            // 
            // journiesRegistingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 930);
            this.Controls.Add(this.cmJourneyCode);
            this.Controls.Add(this.lblCreditCardNumber);
            this.Controls.Add(this.txtPupilID);
            this.Controls.Add(this.lblCreditCompany);
            this.Controls.Add(this.paymentType);
            this.Controls.Add(this.cmPaymentMethod);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pupilID);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.securtiyInsure);
            this.Controls.Add(this.txtCreditCardNumber);
            this.Controls.Add(this.pupilName);
            this.Controls.Add(this.dtpRegisterDate);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.update);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnSearchPupil);
            this.Controls.Add(this.txtJourneyName);
            this.Controls.Add(this.txtCreditCompany);
            this.Controls.Add(this.title);
            this.Controls.Add(this.txtParentPhoneNum);
            this.Controls.Add(this.journyDate);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.txtJourneyPlace);
            this.Controls.Add(this.txtPupilName);
            this.Controls.Add(this.journyName);
            this.Controls.Add(this.price);
            this.Controls.Add(this.place);
            this.Controls.Add(this.journeyCode);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "journiesRegistingForm";
            this.Text = "journiesRegistingForm";
            this.Load += new System.EventHandler(this.journiesRegistingForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label securtiyInsure;
        private System.Windows.Forms.TextBox txtCreditCardNumber;
        private System.Windows.Forms.Label pupilName;
        private System.Windows.Forms.DateTimePicker dtpRegisterDate;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnSearchPupil;
        private System.Windows.Forms.TextBox txtJourneyName;
        private System.Windows.Forms.TextBox txtCreditCompany;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox txtParentPhoneNum;
        private System.Windows.Forms.Label journyDate;
        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.TextBox txtJourneyPlace;
        private System.Windows.Forms.TextBox txtPupilName;
        private System.Windows.Forms.Label journyName;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label place;
        private System.Windows.Forms.Label journeyCode;
        private System.Windows.Forms.Label pupilID;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmPaymentMethod;
        private System.Windows.Forms.Label paymentType;
        private System.Windows.Forms.Label lblCreditCompany;
        private System.Windows.Forms.Label lblCreditCardNumber;
        private System.Windows.Forms.TextBox txtPupilID;
        private System.Windows.Forms.ComboBox cmJourneyCode;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adiWFProject
{
    public partial class journiesRegistingForm : Form
    {
        public journiesRegistingForm()
        {
            InitializeComponent();
        }

        private void journiesRegistingForm_Load_1(object sender, EventArgs e)
        {
            cmPaymentMethod.Items.Clear();
            cmPaymentMethod.Items.Add("מזומן");
            cmPaymentMethod.Items.Add("אשראי");
            cmPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;

            HideCreditFields();
            dtpRegisterDate.Value = DateTime.Now;

            FillJourneyComboBox();
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            try
            {
                string sql = "SELECT * FROM journiesRegisting";
                DataTable dt = DbMain.GetTable(sql);
                if (dt != null)
                {
                    dataGridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בטעינת הנתונים לטבלה במסך:\n" + ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillJourneyComboBox()
        {
            cmJourneyCode.Items.Clear();
            try
            {
                string sql = "SELECT journeyCode FROM journies";
                DataTable dt = DbMain.GetTable(sql);

                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["journeyCode"] != DBNull.Value)
                        {
                            cmJourneyCode.Items.Add(row["journeyCode"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בטעינת קודי המסעות:\n" + ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchPupil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPupilID.Text))
            {
                MessageBox.Show("אנא הכנסי תעודת זהות לצורך חיפוש.", "הודעה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sqlPupil = $"SELECT * FROM pupil WHERE pupilID = '{txtPupilID.Text.Trim()}'";
                DataTable dtPupil = DbMain.GetTable(sqlPupil);

                if (dtPupil != null && dtPupil.Rows.Count > 0)
                {
                    DataRow row = dtPupil.Rows[0];
                    txtPupilName.Text = row["pupilName"].ToString();
                    txtParentPhoneNum.Text = row["parentPhone"].ToString();
                    return;
                }

                string sqlStaff = $"SELECT * FROM staff WHERE staffID = '{txtPupilID.Text.Trim()}'";
                DataTable dtStaff = DbMain.GetTable(sqlStaff);

                if (dtStaff != null && dtStaff.Rows.Count > 0)
                {
                    DataRow row = dtStaff.Rows[0];
                    txtPupilName.Text = row["staffFullName"].ToString();
                    txtParentPhoneNum.Text = row["phoneNumber"].ToString();
                    return;
                }

                MessageBox.Show("תעודת זהות זו לא נמצאה כחניך או כמדריך במערכת.", "לא נמצא", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בשליפת הנתונים:\n" + ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmJourneyCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmJourneyCode.SelectedItem == null) return;
            LoadJourneyDetails(cmJourneyCode.SelectedItem.ToString());
        }

        private void LoadJourneyDetails(string selectedCode)
        {
            try
            {
                string sql = $"SELECT * FROM journies WHERE journeyCode = {selectedCode}";
                DataTable dt = DbMain.GetTable(sql);

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtJourneyName.Text = row["journeyName"].ToString();
                    txtJourneyPlace.Text = row["place"].ToString();
                    textBox5.Text = row["price"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בשליפת פרטי המסע:\n" + ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmPaymentMethod.SelectedItem == null) return;
            string selectedMethod = cmPaymentMethod.SelectedItem.ToString();

            if (selectedMethod == "אשראי")
            {
                lblCreditCompany.Visible = true;
                txtCreditCompany.Visible = true;
                lblCreditCardNumber.Visible = true;
                txtCreditCardNumber.Visible = true;
            }
            else
            {
                HideCreditFields();
                txtCreditCompany.Text = "";
                txtCreditCardNumber.Text = "";
            }
        }

        private bool IsValidIsraeliID(string id)
        {
            if (string.IsNullOrWhiteSpace(id) || id.Length > 9 || !long.TryParse(id, out _))
                return false;

            id = id.PadLeft(9, '0');

            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                int digit = int.Parse(id[i].ToString());
                int weight = (i % 2 == 0) ? 1 : 2;
                int mul = digit * weight;

                sum += (mul > 9) ? (mul / 10 + mul % 10) : mul;
            }

            return (sum % 10 == 0);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (cmJourneyCode.SelectedItem == null || string.IsNullOrWhiteSpace(txtPupilID.Text))
            {
                MessageBox.Show("חובה לבחור קוד מסע ולהזין תעודת זהות תקינה.", "שגיאה בקלט", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidIsraeliID(txtPupilID.Text.Trim()))
            {
                MessageBox.Show("מספר תעודת הזהות אינו תקין לפי חוקי משרד הפנים!", "שגיאה בקלט", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmPaymentMethod.SelectedItem == null)
            {
                MessageBox.Show("אנא בחרי סוג תשלום.", "שגיאה בקלט", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string journeyCode = cmJourneyCode.SelectedItem.ToString();
                string pupilID = txtPupilID.Text.Trim();
                string journeyName = txtJourneyName.Text.Trim();
                string place = txtJourneyPlace.Text.Trim();
                string parentPhone = txtParentPhoneNum.Text.Trim();
                string totalPayment = textBox5.Text.Trim();
                string paymentMethod = cmPaymentMethod.SelectedItem.ToString();
                string creditCompany = txtCreditCompany.Text.Trim();

                bool healthStatement = checkBox.Checked;
                string regestingDate = dtpRegisterDate.Value.ToString("yyyy-MM-dd");

                string sqlCheckPupil = $"SELECT * FROM pupil WHERE pupilID = '{pupilID}'";
                DataTable dtCheckPupil = DbMain.GetTable(sqlCheckPupil);

                if (dtCheckPupil.Rows.Count == 0)
                {
                    string sqlCheckStaff = $"SELECT * FROM staff WHERE staffID = '{pupilID}'";
                    DataTable dtCheckStaff = DbMain.GetTable(sqlCheckStaff);

                    if (dtCheckStaff.Rows.Count > 0)
                    {
                        DataRow staffRow = dtCheckStaff.Rows[0];
                        string staffName = staffRow["staffFullName"].ToString();
                        string staffPhone = staffRow["phoneNumber"].ToString();
                        string staffTribe = staffRow["selfTribeName"].ToString();

                        string sqlInsertShadowPupil = $@"INSERT INTO pupil (pupilID, pupilName, tribeName, birthDate, address, parentPhone, schoolName, cityName) 
                                                         VALUES ('{pupilID}', '{staffName}', '{staffTribe}', #2000-01-01#, 'מדריך', '{staffPhone}', 'צוות', 'צוות')";
                        DbMain.InsDelUpd(sqlInsertShadowPupil);
                    }
                }

                string sqlCheck = $"SELECT * FROM journiesRegisting WHERE journeyCode = {journeyCode} AND pupilID = '{pupilID}'";
                DataTable dtCheck = DbMain.GetTable(sqlCheck);

                if (dtCheck != null && dtCheck.Rows.Count > 0)
                {
                    MessageBox.Show("חניך או מדריך זה כבר רשום למסע שנבחר!", "רישום כפול", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string sqlInsert = $@"INSERT INTO journiesRegisting (journeyCode, pupilID, joumeyName, place, parentPhoneNum, selfHealth, registerDate, totalPayment, paymentType, creditCardType) 
                                      VALUES ({journeyCode}, '{pupilID}', '{journeyName}', '{place}', '{parentPhone}', {healthStatement}, '{regestingDate}', {totalPayment}, '{paymentMethod}', '{creditCompany}')";

                bool isSuccess = DbMain.InsDelUpd(sqlInsert);

                if (isSuccess)
                {
                    MessageBox.Show("הרישום למסע בוצע בהצלחה!", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAllForm();
                    RefreshGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה במהלך השמירה באקסס:\n" + ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            try
            {
                DataGridViewRow row = dataGridView.CurrentRow;

                txtPupilID.Text = row.Cells["pupilID"].Value.ToString();
                string journeyCode = row.Cells["journeyCode"].Value.ToString();
                cmJourneyCode.SelectedItem = journeyCode;

                LoadJourneyDetails(journeyCode);

                txtParentPhoneNum.Text = row.Cells["parentPhoneNum"].Value.ToString();

                if (row.Cells["registerDate"].Value != DBNull.Value)
                    dtpRegisterDate.Value = Convert.ToDateTime(row.Cells["registerDate"].Value);

                if (row.Cells["selfHealth"].Value != DBNull.Value)
                {
                    checkBox.Checked = Convert.ToBoolean(row.Cells["selfHealth"].Value);
                }

                string paymentType = row.Cells["paymentType"].Value.ToString();
                cmPaymentMethod.SelectedItem = paymentType;

                if (paymentType == "אשראי")
                {
                    txtCreditCompany.Text = row.Cells["creditCardType"].Value.ToString();
                }

                try
                {
                    string sqlPupil = $"SELECT pupilName FROM pupil WHERE pupilID = '{txtPupilID.Text.Trim()}'";
                    DataTable dtPupil = DbMain.GetTable(sqlPupil);
                    if (dtPupil != null && dtPupil.Rows.Count > 0)
                    {
                        txtPupilName.Text = dtPupil.Rows[0]["pupilName"].ToString();
                    }
                    else
                    {
                        string sqlStaff = $"SELECT staffFullName FROM staff WHERE staffID = '{txtPupilID.Text.Trim()}'";
                        DataTable dtStaff = DbMain.GetTable(sqlStaff);
                        if (dtStaff != null && dtStaff.Rows.Count > 0)
                        {
                            txtPupilName.Text = dtStaff.Rows[0]["staffFullName"].ToString();
                        }
                    }
                }
                catch { }
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בבחירת שורה מהטבלה:\n" + ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (cmJourneyCode.SelectedItem == null || string.IsNullOrWhiteSpace(txtPupilID.Text))
            {
                MessageBox.Show("אנא בחרי שורה מהטבלה או מלאי קוד מסע ותעודת זהות לעדכון.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string journeyCode = cmJourneyCode.SelectedItem.ToString();
                string pupilID = txtPupilID.Text.Trim();
                string paymentMethod = cmPaymentMethod.SelectedItem?.ToString() ?? "מזומן";
                string creditCompany = txtCreditCompany.Text.Trim();
                string parentPhone = txtParentPhoneNum.Text.Trim();
                double totalPayment = string.IsNullOrEmpty(textBox5.Text) ? 0 : Convert.ToDouble(textBox5.Text);
                bool healthStatement = checkBox.Checked;

                string sqlUpdate = $@"UPDATE journiesRegisting 
                                      SET paymentType = '{paymentMethod}', creditCardType = '{creditCompany}', parentPhoneNum = '{parentPhone}', totalPayment = {totalPayment}, selfHealth = {healthStatement}
                                      WHERE journeyCode = {journeyCode} AND pupilID = '{pupilID}'";

                if (DbMain.InsDelUpd(sqlUpdate))
                {
                    MessageBox.Show("נתוני הרישום עודכנו בהצלחה!", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAllForm();
                    RefreshGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בעדכון הנתונים:\n" + ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            if (cmJourneyCode.SelectedItem == null || string.IsNullOrWhiteSpace(txtPupilID.Text))
            {
                MessageBox.Show("אנא בחרי שורה מהטבלה למחיקה.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult res = MessageBox.Show("האם את בטוחה שברצונך לבטל רישום זה?", "אישור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            try
            {
                string journeyCode = cmJourneyCode.SelectedItem.ToString();
                string pupilID = txtPupilID.Text.Trim();

                string sqlDelete = $"DELETE FROM journiesRegisting WHERE journeyCode = {journeyCode} AND pupilID = '{pupilID}'";

                if (DbMain.InsDelUpd(sqlDelete))
                {
                    MessageBox.Show("הרישום בבוטל ונמחק בהצלחה!", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAllForm();
                    RefreshGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה במחיקת הנתונים:\n" + ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HideCreditFields()
        {
            lblCreditCompany.Visible = false;
            txtCreditCompany.Visible = false;
            lblCreditCardNumber.Visible = false;
            txtCreditCardNumber.Visible = false;
        }

        private void ClearFormExceptID()
        {
            txtPupilName.Text = "";
            txtParentPhoneNum.Text = "";
            cmJourneyCode.SelectedIndex = -1;
            txtJourneyName.Text = "";
            txtJourneyPlace.Text = "";
            textBox5.Text = "";
            cmPaymentMethod.SelectedIndex = -1;
            dtpRegisterDate.Value = DateTime.Now;
            checkBox.Checked = false;
            HideCreditFields();
            txtCreditCompany.Text = "";
            txtCreditCardNumber.Text = "";
        }

        private void ClearAllForm()
        {
            txtPupilID.Text = "";
            ClearFormExceptID();
        }

        private void txtPupilID_TextChanged(object sender, EventArgs e)
        {
            ClearFormExceptID();
        }

        private void textBox7_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox8_TextChanged(object sender, EventArgs e) { }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StBill
{
    public partial class frmAddCheque : Form
    {
        private string _checkId;
        
        public frmAddCheque(string checkId, bool isUpdate=false)
        {
            InitializeComponent();
            LoadBasicData();

            if (isUpdate)
            {
                this.Text = "Delete of Update Check Details";
                buttonDelete.Visible = true;

                _checkId = checkId;
                buttonAdd.Text = "Update";

                var dr = Db.GetDataReader("SELECT * FROM TBL_CHEQUE_DTL WHERE ((CHQ_DTL_ID=" + checkId + "))");
                if (dr.HasRows)
                {
                    dr.Read();
                    dateTimePickerReceivingDate.Value = DateTime.Parse(dr["RECEIVING_DATE"].ToString());
                    comboBoxPbsList.SelectedValue = dr["PBS_ID"].ToString();
                    comboBoxBillType.SelectedValue = dr["BILL_TYPE_ID"].ToString();
                    comboBoxBankList.SelectedValue = dr["BANK_ID"].ToString();
                    textBoxChequeNumber.Text = dr["CHEQUE_NUMBER"].ToString();
                    dateTimePickerChequeDate.Value = DateTime.Parse(dr["CHEQUE_DATE"].ToString());
                    textBoxAmount.Text = dr["AMOUNT"].ToString();
                    dateTimePickerFrom.Value = DateTime.Parse(dr["DURATION_FROM"].ToString());
                    dateTimePickerTo.Value = DateTime.Parse(dr["DURATION_TO"].ToString());
                    richTextBoxRemark.Text = dr["REMARK"].ToString();
                }
            }

        }

        private void SaveCheque()
        {
            var query =
                "INSERT INTO TBL_CHEQUE_DTL (RECEIVING_DATE, PBS_ID, BILL_TYPE_ID, BANK_ID, CHEQUE_NUMBER, CHEQUE_DATE, " +
                "AMOUNT, DURATION_FROM, DURATION_TO, REMARK, CREATE_DATE, CREATE_BY) VALUES ('" + 
                dateTimePickerReceivingDate.Value.ToShortDateString() +
                "', " + comboBoxPbsList.SelectedValue + ", " + comboBoxBillType.SelectedValue + ", " +
                comboBoxBankList.SelectedValue + ", '" + textBoxChequeNumber.Text.Trim() + "', '" +
                dateTimePickerChequeDate.Value.ToShortDateString() + "', " + textBoxAmount.Text.Trim() + ", '" +
                GlobalSetting.GetFirstDate(dateTimePickerFrom.Value).ToShortDateString() + "', '" +
                GlobalSetting.GetFirstDate(dateTimePickerTo.Value).ToShortDateString() + "', '" +
                richTextBoxRemark.Text + "', '"+DateTime.Now+"','" + GlobalSetting.EmpUserName + "') ";
            var isSaved = Db.QueryExecute(query);
            if (isSaved)
            {
                textBoxChequeNumber.Clear();
                textBoxAmount.Clear();
                richTextBoxRemark.Clear();
            }
        }

        private void UpdateCheque(string checkId)
        {
            try
            {
                var query = "UPDATE TBL_CHEQUE_DTL SET RECEIVING_DATE='" + dateTimePickerReceivingDate.Value.ToShortDateString() + "', " +
                            "PBS_ID=" + comboBoxPbsList.SelectedValue + ", " + "BILL_TYPE_ID=" + comboBoxBillType.SelectedValue + ", " +
                            "BANK_ID=" + comboBoxBankList.SelectedValue + ", " + "CHEQUE_NUMBER='" + textBoxChequeNumber.Text.Trim() + "', " +
                            "CHEQUE_DATE='" + dateTimePickerChequeDate.Value.ToShortDateString() + "'," + "AMOUNT=" + textBoxAmount.Text.Trim() + ", " +
                            "DURATION_FROM='" + GlobalSetting.GetFirstDate(dateTimePickerFrom.Value).ToShortDateString() + "'," +
                            "DURATION_TO='" + GlobalSetting.GetFirstDate(dateTimePickerTo.Value).ToShortDateString() + "'," +
                            "REMARK='" + richTextBoxRemark.Text + "'," + "UPDATE_DATE='" + DateTime.Now + "', " +
                            "UPDATE_BY='" + GlobalSetting.EmpUserName + "' " +
                            "WHERE ((CHQ_DTL_ID = " + checkId + " )) ";
                var isUpdate = Db.QueryExecute(query);
                if (isUpdate)
                {
                    MessageBox.Show("Successfully update.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Try Again...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoadBasicData()
        {
            dateTimePickerReceivingDate.CustomFormat = GlobalSetting.DateFormat;
            dateTimePickerChequeDate.CustomFormat = GlobalSetting.DateFormat;
            dateTimePickerFrom.CustomFormat = GlobalSetting.DateFormatView;
            dateTimePickerTo.CustomFormat = GlobalSetting.DateFormatView;

            comboBoxPbsList.DataSource = null;
            comboBoxPbsList.DisplayMember = "PBS_NAME";
            comboBoxPbsList.ValueMember = "PBS_ID";
            comboBoxPbsList.DataSource = Db.GetDataTable("SELECT * FROM TBL_PBS");

            comboBoxBankList.DataSource = null;
            comboBoxBankList.DisplayMember = "BANK_NAME";
            comboBoxBankList.ValueMember = "BANK_ID";
            comboBoxBankList.DataSource = Db.GetDataTable("SELECT * FROM TBL_BANK");

            comboBoxBillType.DataSource = null;
            comboBoxBillType.DisplayMember = "BILL_TYPE";
            comboBoxBillType.ValueMember = "BILL_TYPE_ID";
            comboBoxBillType.DataSource = Db.GetDataTable("SELECT * FROM TBL_BILL_TYPE");
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(textBoxAmount.Text.Trim())>=0)
                {
                    
                }
                else
                {
                    textBoxAmount.Text = "0.00";
                    textBoxAmount.SelectAll();
                    textBoxAmount.Focus();
                }
            }
            catch 
            {
                textBoxAmount.Text = "0.00";
                textBoxAmount.SelectAll();
                textBoxAmount.Focus();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                switch (buttonAdd.Text)
                {
                    case "Add":
                        SaveCheque();
                        Application.DoEvents();
                        break;
                    case "Update":
                        UpdateCheque(_checkId);
                        Application.DoEvents();
                        Close();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure that you want to permanantly dekete this selected check?","Confirmation",MessageBoxButtons.OKCancel)==DialogResult.OK)
                {
                    var query = "DELETE FROM TBL_CHEQUE_DTL WHERE CHQ_DTL_ID=" + _checkId + "";
                    var isDelete = Db.QueryExecute(query);
                    if (isDelete)
                    {
                        MessageBox.Show("Successfully Delete.");
                        this.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

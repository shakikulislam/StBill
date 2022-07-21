using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StBill.Report;
using Microsoft.Reporting.WinForms;

namespace StBill
{
    public partial class frmHome : Form
    {
        private static DataTable _checkDetails = null;

        public frmHome()
        {
            InitializeComponent();
            base.FormClosing += this.AppClosing;
            labelUserName.Text = GlobalSetting.EmpName + @" (" + GlobalSetting.EmpUserName + @")";
            dateTimePickerFrom.CustomFormat = GlobalSetting.DateFormatView;
            dateTimePickerTo.CustomFormat = GlobalSetting.DateFormatView;

            comboBoxPbsList.DataSource = null;
            comboBoxPbsList.DisplayMember = "PBS_NAME";
            comboBoxPbsList.ValueMember = "PBS_ID";
            comboBoxPbsList.DataSource = Db.GetDataTable("SELECT * FROM TBL_PBS");

        }

        private void AppClosing(object sender, FormClosingEventArgs e)
        {
            Db.CloseConnection();
            Application.Exit();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            new frmAddCheque("").Show();
            buttonSearch.PerformClick();
            Application.DoEvents();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                _checkDetails = null;
                listViewChequeList.Items.Clear();
                var subQuery = "";

                if (radioButtonDurationBetween.Checked)
                {
                    subQuery += "(( CD.DURATION_FROM BETWEEN DateValue('" + GlobalSetting.GetFirstDate(dateTimePickerFrom.Value).ToShortDateString() +
                                "') AND DateValue('" + GlobalSetting.GetFirstDate(dateTimePickerTo.Value).ToShortDateString() + "')))";
                }
                else if (radioButtonOnlyDuration.Checked)
                {
                    subQuery += "(( CD.DURATION_FROM = DateValue('" + GlobalSetting.GetFirstDate(dateTimePickerFrom.Value).ToShortDateString() +
                                "') AND CD.DURATION_TO = DateValue('" + GlobalSetting.GetFirstDate(dateTimePickerTo.Value).ToShortDateString() + "')))";
                }

                if (!checkBoxAllPbs.Checked)
                {
                    subQuery += " AND ((CD.PBS_ID=" + comboBoxPbsList.SelectedValue + "))";
                }


                var query = "SELECT CD.*, B.BANK_NAME, P.PBS_NAME " +
                            "FROM (TBL_CHEQUE_DTL AS CD LEFT JOIN TBL_BANK AS B ON CD.BANK_ID = B.BANK_ID) " +
                            "INNER JOIN TBL_PBS AS P ON CD.PBS_ID = P.PBS_ID " +
                            "WHERE"+subQuery;

                _checkDetails = Db.GetDataTable(query);
                if (_checkDetails != null && _checkDetails.Rows.Count > 0)
                {
                    double totalAmount = 0;
                    int s = 1;
                    foreach (DataRow row in _checkDetails.Rows)
                    {
                        double amount = double.Parse(row["AMOUNT"].ToString());

                        var duration = DateTime.Parse(row["DURATION_FROM"].ToString()).ToString(GlobalSetting.DateFormatView);
                        duration += " - ";
                        duration += DateTime.Parse(row["DURATION_TO"].ToString()).ToString(GlobalSetting.DateFormatView);

                        var lvi=new ListViewItem(s.ToString());
                        lvi.SubItems.Add(DateTime.Parse(row["RECEIVING_DATE"].ToString()).ToString(GlobalSetting.DateFormat));
                        lvi.SubItems.Add(row["CHEQUE_NUMBER"].ToString());
                        lvi.SubItems.Add(DateTime.Parse(row["CHEQUE_DATE"].ToString()).ToString(GlobalSetting.DateFormat));
                        lvi.SubItems.Add(row["BANK_NAME"].ToString());
                        lvi.SubItems.Add(amount.ToString("N"));
                        lvi.SubItems.Add(row["PBS_NAME"].ToString());
                        lvi.SubItems.Add(row["REMARK"].ToString());
                        lvi.SubItems.Add(row["CREATE_BY"].ToString());
                        lvi.SubItems.Add(row["BANK_ID"].ToString());
                        lvi.SubItems.Add(row["PBS_ID"].ToString());
                        lvi.SubItems.Add(duration);
                        lvi.SubItems.Add(row["CHQ_DTL_ID"].ToString());

                        listViewChequeList.Items.Add(lvi);
                        totalAmount += amount;
                        s++;
                        Application.DoEvents();
                    }

                    labelTotalCheque.Text = listViewChequeList.Items.Count.ToString();
                    labelTotalAmount.Text = totalAmount.ToString("N");
                }
                else
                {
                    _checkDetails = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void checkBoxAllPbs_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxPbsList.Enabled = !checkBoxAllPbs.Checked;
        }

        private void listViewChequeList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                new frmAddCheque(listViewChequeList.SelectedItems[0].SubItems[columnHeaderCheckDtlId.Index].Text, true).ShowDialog();
                buttonSearch.PerformClick();
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (_checkDetails!=null)
                {
                    new CustomReportViewer("Chequ Details", "Report.rptChequDetail", 
                        new ReportDataSource("ChequDetails", _checkDetails)).PrintToPrinter();
                }
                else
                {
                    MessageBox.Show("Please Search first and try again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}

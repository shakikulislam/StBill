namespace StBill
{
    partial class frmHome
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listViewChequeList = new System.Windows.Forms.ListView();
            this.columnHeaderSl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderReceivingDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderChequeNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderChequeDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBankName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPbsName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRemark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBankId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPbsId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCheckDtlId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPbsList = new System.Windows.Forms.ComboBox();
            this.radioButtonDurationBetween = new System.Windows.Forms.RadioButton();
            this.radioButtonOnlyDuration = new System.Windows.Forms.RadioButton();
            this.checkBoxAllPbs = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTotalCheque = new System.Windows.Forms.Label();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(638, 71);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(124, 36);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(693, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome";
            // 
            // labelUserName
            // 
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.DarkRed;
            this.labelUserName.Location = new System.Drawing.Point(219, 22);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(547, 17);
            this.labelUserName.TabIndex = 6;
            this.labelUserName.Text = "-";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(216, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "to";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(238, 76);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(130, 23);
            this.dateTimePickerTo.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Duration";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(83, 76);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(130, 23);
            this.dateTimePickerFrom.TabIndex = 21;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(378, 71);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(124, 36);
            this.buttonSearch.TabIndex = 25;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // listViewChequeList
            // 
            this.listViewChequeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSl,
            this.columnHeaderReceivingDate,
            this.columnHeaderChequeNumber,
            this.columnHeaderChequeDate,
            this.columnHeaderBankName,
            this.columnHeaderAmount,
            this.columnHeaderPbsName,
            this.columnHeaderRemark,
            this.columnHeaderUserName,
            this.columnHeaderBankId,
            this.columnHeaderPbsId,
            this.columnHeaderDuration,
            this.columnHeaderCheckDtlId});
            this.listViewChequeList.FullRowSelect = true;
            this.listViewChequeList.GridLines = true;
            this.listViewChequeList.Location = new System.Drawing.Point(20, 113);
            this.listViewChequeList.MultiSelect = false;
            this.listViewChequeList.Name = "listViewChequeList";
            this.listViewChequeList.Size = new System.Drawing.Size(742, 307);
            this.listViewChequeList.TabIndex = 26;
            this.listViewChequeList.UseCompatibleStateImageBehavior = false;
            this.listViewChequeList.View = System.Windows.Forms.View.Details;
            this.listViewChequeList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewChequeList_MouseDoubleClick);
            // 
            // columnHeaderSl
            // 
            this.columnHeaderSl.Text = "#";
            this.columnHeaderSl.Width = 40;
            // 
            // columnHeaderReceivingDate
            // 
            this.columnHeaderReceivingDate.Text = "Receiving Date";
            this.columnHeaderReceivingDate.Width = 90;
            // 
            // columnHeaderChequeNumber
            // 
            this.columnHeaderChequeNumber.Text = "Cheque Number";
            this.columnHeaderChequeNumber.Width = 180;
            // 
            // columnHeaderChequeDate
            // 
            this.columnHeaderChequeDate.Text = "Cheque Date";
            this.columnHeaderChequeDate.Width = 80;
            // 
            // columnHeaderBankName
            // 
            this.columnHeaderBankName.Text = "Bank Name";
            this.columnHeaderBankName.Width = 200;
            // 
            // columnHeaderAmount
            // 
            this.columnHeaderAmount.Text = "Amount";
            this.columnHeaderAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderAmount.Width = 100;
            // 
            // columnHeaderPbsName
            // 
            this.columnHeaderPbsName.Text = "PBS Name";
            this.columnHeaderPbsName.Width = 120;
            // 
            // columnHeaderRemark
            // 
            this.columnHeaderRemark.Text = "Remark";
            this.columnHeaderRemark.Width = 120;
            // 
            // columnHeaderUserName
            // 
            this.columnHeaderUserName.Text = "User Name";
            this.columnHeaderUserName.Width = 100;
            // 
            // columnHeaderBankId
            // 
            this.columnHeaderBankId.Text = "Bank ID";
            this.columnHeaderBankId.Width = 0;
            // 
            // columnHeaderPbsId
            // 
            this.columnHeaderPbsId.Text = "PBS ID";
            this.columnHeaderPbsId.Width = 0;
            // 
            // columnHeaderDuration
            // 
            this.columnHeaderDuration.Text = "Duration";
            this.columnHeaderDuration.Width = 120;
            // 
            // columnHeaderCheckDtlId
            // 
            this.columnHeaderCheckDtlId.Text = "Check DTL ID";
            this.columnHeaderCheckDtlId.Width = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "PBS";
            // 
            // comboBoxPbsList
            // 
            this.comboBoxPbsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPbsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPbsList.FormattingEnabled = true;
            this.comboBoxPbsList.Location = new System.Drawing.Point(83, 43);
            this.comboBoxPbsList.Name = "comboBoxPbsList";
            this.comboBoxPbsList.Size = new System.Drawing.Size(285, 24);
            this.comboBoxPbsList.TabIndex = 27;
            // 
            // radioButtonDurationBetween
            // 
            this.radioButtonDurationBetween.AutoSize = true;
            this.radioButtonDurationBetween.Checked = true;
            this.radioButtonDurationBetween.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDurationBetween.Location = new System.Drawing.Point(485, 45);
            this.radioButtonDurationBetween.Name = "radioButtonDurationBetween";
            this.radioButtonDurationBetween.Size = new System.Drawing.Size(138, 21);
            this.radioButtonDurationBetween.TabIndex = 29;
            this.radioButtonDurationBetween.TabStop = true;
            this.radioButtonDurationBetween.Text = "Duration Between";
            this.radioButtonDurationBetween.UseVisualStyleBackColor = true;
            // 
            // radioButtonOnlyDuration
            // 
            this.radioButtonOnlyDuration.AutoSize = true;
            this.radioButtonOnlyDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOnlyDuration.Location = new System.Drawing.Point(629, 45);
            this.radioButtonOnlyDuration.Name = "radioButtonOnlyDuration";
            this.radioButtonOnlyDuration.Size = new System.Drawing.Size(113, 21);
            this.radioButtonOnlyDuration.TabIndex = 30;
            this.radioButtonOnlyDuration.Text = "Only Duration";
            this.radioButtonOnlyDuration.UseVisualStyleBackColor = true;
            // 
            // checkBoxAllPbs
            // 
            this.checkBoxAllPbs.AutoSize = true;
            this.checkBoxAllPbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAllPbs.Location = new System.Drawing.Point(381, 45);
            this.checkBoxAllPbs.Name = "checkBoxAllPbs";
            this.checkBoxAllPbs.Size = new System.Drawing.Size(73, 21);
            this.checkBoxAllPbs.TabIndex = 31;
            this.checkBoxAllPbs.Text = "All PBS";
            this.checkBoxAllPbs.UseVisualStyleBackColor = true;
            this.checkBoxAllPbs.CheckedChanged += new System.EventHandler(this.checkBoxAllPbs_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Total Cheque :";
            // 
            // labelTotalCheque
            // 
            this.labelTotalCheque.AutoSize = true;
            this.labelTotalCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCheque.Location = new System.Drawing.Point(134, 429);
            this.labelTotalCheque.Name = "labelTotalCheque";
            this.labelTotalCheque.Size = new System.Drawing.Size(16, 17);
            this.labelTotalCheque.TabIndex = 34;
            this.labelTotalCheque.Text = "0";
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAmount.Location = new System.Drawing.Point(396, 429);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(16, 17);
            this.labelTotalAmount.TabIndex = 36;
            this.labelTotalAmount.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(294, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Total Amount :";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(687, 423);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 39;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 24);
            this.label3.TabIndex = 40;
            this.label3.Text = "Startrek Associates";
            // 
            // buttonPrint
            // 
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Location = new System.Drawing.Point(508, 71);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(124, 36);
            this.buttonPrint.TabIndex = 41;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 455);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelTotalAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelTotalCheque);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxAllPbs);
            this.Controls.Add(this.radioButtonOnlyDuration);
            this.Controls.Add(this.radioButtonDurationBetween);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxPbsList);
            this.Controls.Add(this.listViewChequeList);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListView listViewChequeList;
        private System.Windows.Forms.ColumnHeader columnHeaderSl;
        private System.Windows.Forms.ColumnHeader columnHeaderReceivingDate;
        private System.Windows.Forms.ColumnHeader columnHeaderChequeNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderChequeDate;
        private System.Windows.Forms.ColumnHeader columnHeaderBankName;
        private System.Windows.Forms.ColumnHeader columnHeaderAmount;
        private System.Windows.Forms.ColumnHeader columnHeaderPbsName;
        private System.Windows.Forms.ColumnHeader columnHeaderRemark;
        private System.Windows.Forms.ColumnHeader columnHeaderUserName;
        private System.Windows.Forms.ColumnHeader columnHeaderBankId;
        private System.Windows.Forms.ColumnHeader columnHeaderPbsId;
        private System.Windows.Forms.ColumnHeader columnHeaderDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPbsList;
        private System.Windows.Forms.RadioButton radioButtonDurationBetween;
        private System.Windows.Forms.RadioButton radioButtonOnlyDuration;
        private System.Windows.Forms.CheckBox checkBoxAllPbs;
        private System.Windows.Forms.ColumnHeader columnHeaderCheckDtlId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTotalCheque;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonPrint;


    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StBill.Properties;

namespace StBill
{
    public partial class frmSetDataSource : Form
    {
        public frmSetDataSource()
        {
            InitializeComponent();
        }

        private void buttonBrows_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd=new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Filter = "Access DB (accdb)|*.accdb|Access DB (mdb)|*.mdb";
            if (ofd.ShowDialog()==DialogResult.OK)
            {
                textBoxFullLink.Text = ofd.FileName.ToString();
                textBoxDatabaseName.Text = ofd.SafeFileName.ToString();
            }
            else
            {
                textBoxFullLink.Clear();
                textBoxDatabaseName.Clear();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Settings.Default.DB_LINK = textBoxFullLink.Text;
            Settings.Default.Save();
            Db.CloseConnection();
            Application.Restart();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Db.CloseConnection();
            Application.Exit();
        }
    }
}

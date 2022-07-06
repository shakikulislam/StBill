using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StBill.Properties;

namespace StBill
{
    public class Db
    {
        public static OleDbConnection Connection;

        private static void GetConnection()
        {
            try
            {
                Connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
                                                 "Data Source=" + Settings.Default.DB_LINK + ";" +
                                                 "Jet OLEDB:Database Password=ST;");
                if (Connection.State == ConnectionState.Open || Connection.State == ConnectionState.Broken)
                {
                    Connection.Close();
                }
                Connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Settings.Default.DB_LINK = "";
                Settings.Default.Save();
                Application.Exit();
            }
        }

        public static void CloseConnection()
        {
            if (Connection!=null)
            {
                if (Connection.State==ConnectionState.Open || Connection.State==ConnectionState.Broken)
                {
                    Connection.Close();
                }

            }
        }

        public static DataTable GetDataTable(string query)
        {
            DataTable result = null;
            try
            {
                GetConnection();
                OleDbCommand cmd = new OleDbCommand(query, Connection);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                result = dt;
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public static bool Insert(string query)
        {
            var result = false;
            try
            {
                GetConnection();
                OleDbCommand cmd = new OleDbCommand(query, Connection);
                result = cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                result = false;
                throw new Exception(ex.ToString());
            }

            return result;
        }

        public static bool Update(string query)
        {
            var result = false;
            try
            {
                GetConnection();
                OleDbCommand cmd = new OleDbCommand(query, Connection);
                result = cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                result = false;
                throw new Exception(ex.ToString());
            }

            return result;
        }

        public static OleDbDataReader GetDataReader(string query)
        {
            OleDbDataReader result = null;
            try
            {
                GetConnection();
                OleDbCommand cmd = new OleDbCommand(query, Connection);
                result = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                result = null;
                throw new Exception(ex.ToString());
            }

            return result;
        }
    }
}

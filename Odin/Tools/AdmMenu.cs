using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Odin.Tools
{
    class AdmMenu
    {
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;


        public void CommitUserColumn(int UserId, string FormName, string gvname, DataGridView dgv)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            foreach (DataGridViewRow row in dgv.Rows)
            {
                SqlCommand sqlComm = new SqlCommand("sp_CommitUserGridViewColumn", sqlConn);
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.Parameters.AddWithValue("@id", Convert.ToInt32(row.Cells["cn_ColumnId"].Value));
                sqlComm.Parameters.AddWithValue("@userid", UserId);
                sqlComm.Parameters.AddWithValue("@formname", FormName);
                sqlComm.Parameters.AddWithValue("@gridname", gvname);
                sqlComm.Parameters.AddWithValue("@columnname", row.Cells["cn_ColumnName"].Value.ToString());
                sqlComm.Parameters.AddWithValue("@columntext", row.Cells["cn_ColumnText"].Value.ToString());
                sqlComm.Parameters.AddWithValue("@columnorder", Convert.ToInt32(row.Cells["cn_ColumnOrder"].Value));
                sqlComm.Parameters.AddWithValue("@columnvis", Convert.ToInt32(row.Cells["cn_ColumnVis"].Value));
                sqlComm.Parameters.AddWithValue("@columnwidth", Convert.ToInt32(row.Cells["cn_ColumnWidth"].Value));
                sqlComm.Parameters.AddWithValue("@columnexport", Convert.ToInt32(row.Cells["cn_ColumnExport"].Value));

                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                sqlConn.Close();

            }
        }
    }
}

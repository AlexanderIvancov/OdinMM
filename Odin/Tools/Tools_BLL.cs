using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Odin.Global_Classes;
using System.Data.SqlClient;
using System.Data;

namespace Odin.Tools
{
    public class Tools_BLL
    {
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        public static DataTable getUsers()
        {
            string query = "EXECUTE sp_UsersList";

            return Helper.QueryDT(query);
        }

        public void DeleteUser(int Id)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteUser", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@id", Id);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }


        #region Mailings

        public static DataTable getMailingsTypes()
        {
            string query = "EXECUTE sp_MailingTypesList";

            return Helper.QueryDT(query);
        }

        public static DataTable getMailings(int _typeid)
        {
            string query = "EXECUTE sp_MailingList @typeid = " + _typeid;

            return Helper.QueryDT(query);
        }

        public void SaveMailingType(int Id, string Description)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SaveMailingType", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@id", Id);
            sqlComm.Parameters.AddWithValue("@description", Description);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        public void SaveMailing(int id, int typeId, string addresses)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SaveMailing", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@typeid", typeId);
            sqlComm.Parameters.AddWithValue("@addresses", addresses);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        public void DeleteMailing(int Id)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteMailing", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@id", Id);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        #endregion

        #region Labels

        public static DataTable getLabelFields(int _id)
        {
            string query = "EXECUTE sp_SelectLabelTemplateFields @id = " + _id;

            return Helper.QueryDT(query);
        }

        int _templabelid = 0;

        public int TempLabelId
        {
            get { return _templabelid; }
            set { _templabelid = value;
                
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();

                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter("SELECT top 1 name, isnull(labeltext, '') as labeltext FROM BAS_LabelTemplate WHERE id = " + _templabelid.ToString(), conn);
                adapter.Fill(ds);

                conn.Close();

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        TempLabelName = dr["name"].ToString();
                        TempLabelText = dr["labeltext"].ToString();
                    }
                }
                else
                {
                    TempLabelName = string.Empty;
                    TempLabelText = string.Empty;
                }

            }
        }

        public string TempLabelText
        { get; set; }
        public string TempLabelName
        { get; set; }

        public int SaveLabelTemplate(int id, string labeltext)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SaveLabelTemplate", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@labeltext", labeltext);
            sqlComm.Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@result"].Value);
            sqlConn.Close();

            return _res;
        }

        #endregion

        #region Permissions

        public static DataTable getMenuItems(int _userid)
        {
            string query = "EXECUTE sp_SelectUserTabs @userid = " + _userid;

            return Helper.QueryDT(query);
        }


        public void SaveMenuUserTabs(int userid, DataTable tabids)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SaveUserMenuTabs", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@userid", userid);
            sqlComm.Parameters.Add("@tablestates", SqlDbType.Structured);
            sqlComm.Parameters["@tablestates"].TypeName = "UT_IDs";
            sqlComm.Parameters["@tablestates"].Value = tabids;
           
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        #endregion
    }
}

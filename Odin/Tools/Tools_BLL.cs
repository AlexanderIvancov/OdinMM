using Odin.Global_Classes;
using System.Data;

namespace Odin.Tools
{
    public class Tools_BLL
    {
        int _templabelid = 0;
        public string TempLabelText { get; set; }
        public string TempLabelName { get; set; }

        public int TempLabelId
        {
            get { return _templabelid; }
            set { _templabelid = value;
                
                DataTable dt = (DataTable)Helper.GetOneRecord("SELECT top 1 name, isnull(labeltext, '') as labeltext FROM BAS_LabelTemplate WHERE id = " + _templabelid.ToString());

                if (dt.Rows.Count > 0)
                    foreach (DataRow dr in dt.Rows)
                    {
                        TempLabelName = dr["name"].ToString();
                        TempLabelText = dr["labeltext"].ToString();
                    }
                else
                {
                    TempLabelName = string.Empty;
                    TempLabelText = string.Empty;
                }
            }
        }
    }
}
using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.CMB_Components.ToolsType
{
    public delegate void ToolsTypeEventHandler(object sender);

    public partial class cmb_ToolsType : UserControl
    {
        public event ToolsTypeEventHandler ToolsTypeChanged;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;
        
        int _ToolsTypeId = 0;
        int _PrevId = 0;

        bool _EnableSearchId = false;
        string _ToolsType = "";

        public cmb_ToolsType()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();

        }

        public string ToolsType
        {
            get { return txt_ToolsType.Text; }
            set
            {

                _ToolsType = value;
                txt_ToolsType.Text = value;
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT DISTINCT TOP 1 id FROM BAS_ToolsType WHERE name = '" + _ToolsType.ToString() + "'", sConnStr);

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                try
                {
                    ToolsTypeId = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                }
                catch
                {

                    _ToolsTypeId = 0;
                    return;
                }

                ToolsTypeChanged?.Invoke(this);
            }
        }

        public int ToolsTypeId
        {
            get
            {
                try { return _ToolsTypeId; }
                catch { return 0; }
            }
            set
            {


                _ToolsTypeId = value;

                if (_PrevId != _ToolsTypeId)
                {
                    SqlConnection conn = new SqlConnection(sConnStr);
                    conn.Open();

                    DataSet ds = new DataSet();

                    SqlDataAdapter adapter =
                        new SqlDataAdapter("SELECT top 1 * FROM BAS_ToolsType WHERE id = " + _ToolsTypeId.ToString(), conn);
                    adapter.Fill(ds);

                    conn.Close();

                    DataTable dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_ToolsType.Text = dr["name"].ToString();
                        }
                    }
                    else
                    {
                        txt_ToolsType.Text = string.Empty;
                    }

                    _PrevId = _ToolsTypeId;

                    ToolsTypeChanged?.Invoke(this);

                }
            }
        }
        public bool EnableSearchId
        {
            get
            {
                return _EnableSearchId;
            }
            set
            {
                _EnableSearchId = value;
            }
        }

        private void btn_AdvView_Click(object sender, EventArgs e)
        {
            Form f;
            f = this.FindForm();

            Point LocationPoint = this.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X;
            int ypos = LocationPoint.Y + this.Height;
            Point _location = new Point(xpos, ypos);

            frm_ToolsType popup = new frm_ToolsType();
            popup.cmb_ToolsTypeOne = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillData(ToolsType);
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            ToolsType = string.Empty;
        }

        private void txt_ToolsType_TextChanged(object sender, EventArgs e)
        {
            try { ToolsType = txt_ToolsType.Text; }
            catch { }
        }
    }
}

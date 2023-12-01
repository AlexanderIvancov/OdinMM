using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace Odin.CMB_Components.Units
{
    public delegate void UnitEventHandler(object sender);
    public partial class cmb_Units : UserControl
    {
        public event UnitEventHandler UnitChanged;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;

        UnitEventArgs args = new UnitEventArgs();
        int _UnitId = 0;
        int _PrevId = 0;
                
        bool _EnableSearchId = false;
        string _Unit = "";
                
        public cmb_Units()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public string Unit
        {
            get { return txt_Unit.Text; }
            set {

                _Unit = value;
                txt_Unit.Text = value;
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT DISTINCT TOP 1 id FROM BAS_Unit WHERE unit = '" + _Unit.ToString() + "'", sConnStr);

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                try
                {
                    UnitId = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                }
                catch
                {
                    
                    _UnitId = 0;
                    return;
                }

                if (UnitChanged != null)
                {
                    UnitChanged(this);
                }
            }
        }

        public int UnitId
        {
            get {
                try { return _UnitId; }
                catch { return 0; }
            }
            set {

                
                _UnitId = value;

                if (_PrevId != _UnitId)
                {
                    SqlConnection conn = new SqlConnection(sConnStr);
                    conn.Open();

                    DataSet ds = new DataSet();

                    SqlDataAdapter adapter =
                        new SqlDataAdapter("SELECT top 1 * FROM BAS_Unit WHERE id = " + _UnitId.ToString(), conn);
                    adapter.Fill(ds);

                    conn.Close();

                    DataTable dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_Unit.Text = dr["unit"].ToString();
                        }
                    }
                    else
                    {
                        txt_Unit.Text = string.Empty;
                    }

                    _PrevId = _UnitId;

                    if (UnitChanged != null)
                    {
                        UnitChanged(this);
                    }

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
            
            frm_Units popup = new frm_Units();
            popup.cmb_UnitOne = this;

            PopupHelper.ClosePopup();
           
            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillData(Unit);          
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            Unit = string.Empty;
        }

        private void txt_Unit_TextChanged(object sender, EventArgs e)
        {
            try { Unit = txt_Unit.Text; }
            catch { }
        }
    }
    public class UnitEventArgs : EventArgs
    {

    }
}

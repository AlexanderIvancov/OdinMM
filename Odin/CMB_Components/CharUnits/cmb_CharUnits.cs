using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace Odin.CMB_Components.CharUnits
{
    public delegate void CharUnitEventHandler(object sender);
    public partial class cmb_CharUnits : UserControl
    {
        public event CharUnitEventHandler UnitChanged;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;

        UnitEventArgs args = new UnitEventArgs();
        int _UnitId = 0;
        int _PrevId = 0;
                
        bool _EnableSearchId = false;
        string _Unit = "";

        int _BaseUnitId = 0;
        int _BaseUnitOnly = 0;

        public int BaseUnitId
        {
            get { return _BaseUnitId; }
            set { _BaseUnitId = value; }

        }
        public int BaseUnitOnly
        {
            get { return _BaseUnitOnly; }
            set { _BaseUnitOnly = value; }
        }

        public cmb_CharUnits()
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
                        "SELECT DISTINCT TOP 1 id FROM BAS_CharUnit WHERE unit = '" + _Unit.ToString() + "'", sConnStr);

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

                UnitChanged?.Invoke(this);
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
                        new SqlDataAdapter("SELECT top 1 * FROM BAS_CharUnit WHERE id = " + _UnitId.ToString(), conn);
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

                    UnitChanged?.Invoke(this);

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
            
            frm_CharUnits popup = new frm_CharUnits();
            popup.cmb_CharUnitOne = this;
            popup.BaseUnitId = BaseUnitId;
            popup.BaseUnitOnly = BaseUnitOnly;

            PopupHelper.ClosePopup();
           
            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillData(Unit, BaseUnitId, BaseUnitOnly);          
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

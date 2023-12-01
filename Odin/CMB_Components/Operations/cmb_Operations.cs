using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.CMB_Components.Operations
{
    public delegate void OperationEventHandler(object sender);

    public partial class cmb_Operations : UserControl
    {
        public cmb_Operations()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public event OperationEventHandler OperationChanged;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;

        bool _EnableSearchId = false;
        string _Operation = "";

        int _OperationId = 0;
        int _PrevId = 0;

        public string Formula
        {
            get;set;
        }

        public string Operation
        {
            get { return txt_Operation.Text; }
            set
            {

                _Operation = value;
                txt_Operation.Text = value;
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT DISTINCT TOP 1 id FROM BAS_Operations WHERE operation = '" + _Operation.ToString() + "'", sConnStr);

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                try
                {
                    OperationId = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                }
                catch
                {

                    _OperationId = 0;
                    return;
                }

                if (OperationChanged != null)
                {
                    OperationChanged(this);
                }
            }
        }
        public int OperationId
        {
            get
            {
                try { return _OperationId; }
                catch { return 0; }
            }
            set
            {


                _OperationId = value;

                if (_PrevId != _OperationId)
                {
                    SqlConnection conn = new SqlConnection(sConnStr);
                    conn.Open();

                    DataSet ds = new DataSet();

                    SqlDataAdapter adapter =
                        new SqlDataAdapter("SELECT top 1 * FROM BAS_Operations WHERE id = " + _OperationId.ToString(), conn);
                    adapter.Fill(ds);

                    conn.Close();

                    DataTable dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_Operation.Text = dr["operation"].ToString();
                            Formula = dr["formula"].ToString();
                        }
                    }
                    else
                    {
                        txt_Operation.Text = string.Empty;
                        Formula = "";
                    }

                    _PrevId = _OperationId;

                    if (OperationChanged != null)
                    {
                        OperationChanged(this);
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
        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Operation.Text = string.Empty;
        }

        private void txt_Operation_TextChanged(object sender, EventArgs e)
        {
            try { Operation = txt_Operation.Text; }
            catch { }
        }

        private void btn_AdvView_Click(object sender, EventArgs e)
        {
            Form f;
            f = this.FindForm();

            Point LocationPoint = this.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X;
            int ypos = LocationPoint.Y + this.Height;
            Point _location = new Point(xpos, ypos);

            frm_Operations popup = new frm_Operations();
            popup.cmb_OperationOne = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillData(Operation);
        }
    }
}

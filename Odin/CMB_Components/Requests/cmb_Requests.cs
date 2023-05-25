using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Odin.Global_Classes;
using System.Data.SqlClient;
using Odin.Warehouse.Requests;
using Odin.CMB_Components.BLL;


namespace Odin.CMB_Components.Requests
{
    public delegate void RequestEventHandler(object sender);
    public delegate void RequestSavedEventHandler(object sender);


    public partial class cmb_Requests : UserControl
    {
        public cmb_Requests()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public event RequestEventHandler RequestChanged;
        public event RequestSavedEventHandler RequestSaved;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;

        int _RequestId = 0;
        int _PrevId = 0;

        Requests_BLL SMBll = new Requests_BLL();
        CMB_BLL Bll = new CMB_BLL();

        bool _EnableSearchId = false;
        string _Request = "";

        public string Request
        {
            get { return txt_Request.Text; }
            set
            {

                _Request = value;
                txt_Request.Text = value;
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT DISTINCT TOP 1 id FROM REQ_Head WHERE name = '" + _Request.ToString() + "'", sConnStr);

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    RequestId = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                }
                else
                {

                    _RequestId = 0;
                    if (RequestChanged != null)
                    {
                        RequestChanged(this);
                    }
                    //return;
                }

                
            }
        }

        public int RequestId
        {
            get
            {
                try { return _RequestId; }
                catch { return 0; }
            }
            set
            {


                _RequestId = value;

                if (_PrevId != _RequestId)
                {
                    SqlConnection conn = new SqlConnection(sConnStr);
                    conn.Open();

                    DataSet ds = new DataSet();

                    SqlDataAdapter adapter =
                        new SqlDataAdapter("SELECT top 1 * FROM REQ_Head WHERE id = " + _RequestId.ToString(), conn);
                    adapter.Fill(ds);

                    conn.Close();

                    DataTable dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_Request.Text = dr["name"].ToString();
                        }

                        if (RequestChanged != null)
                        {
                            RequestChanged(this);
                        }
                    }
                    else
                    {
                        txt_Request.Text = string.Empty;
                    }

                    _PrevId = _RequestId;

                    //if (RequestChanged != null)
                    //{
                    //    RequestChanged(this);
                    //}

                }
            }
        }

        int _RequestSavedId = 0;

        public int RequestSavedId
        {
            get { return _RequestSavedId; }
            set
            {
                _RequestSavedId = value;
                if (RequestSaved != null)
                {
                    RequestSaved(this);
                }
            }
        }

        public void OutcomeDocSendSave()
        {
            if (RequestSaved != null)
            {
                RequestSaved(this);
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
            txt_Request.Text = string.Empty;
        }

        private void txt_Request_TextChanged(object sender, EventArgs e)
        {
            try { Request = txt_Request.Text; }
            catch { }
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            frm_AddRequest frm = new frm_AddRequest();

            frm.FillAutoDoc(7);

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                int _res = Bll.AddRequestHead(frm.Comments, frm.ProdPlaceId);
                RequestId = _res;
            }
            if (result == DialogResult.Cancel)
            {
                
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (RequestId != 0)
            {
                frm_AddRequest frm = new frm_AddRequest();

                frm.Id = RequestId;
                Bll.RequestId = RequestId;
                frm.Request = Bll.RequestName;
                frm.HeaderText = "Edit document: " + Bll.RequestName;
                frm.Comments = Bll.RequestComments;
                frm.ProdPlaceId = Bll.RequestProdPlace;
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Bll.EditRequestHead(RequestId, frm.Comments, frm.ProdPlaceId);
                    if (RequestChanged != null)
                    {
                        RequestChanged(this);
                    }
                }
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

            frm_Requests popup = new frm_Requests();
            popup.cmb_RequestOne = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillData(Request);
        }
    }
}

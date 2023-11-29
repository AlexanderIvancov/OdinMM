using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using Odin.Warehouse.StockOut;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.CMB_Components.OutcomeDocs
{
    public delegate void OutDocEventHandler(object sender);
    public delegate void OutDocSavedEventHandler(object sender);

    public partial class cmb_OutcomeDocs : UserControl
    {
        public cmb_OutcomeDocs()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public event OutDocEventHandler OutDocChanged;
        public event OutDocSavedEventHandler OutDocSaved;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;

        int _OutcomeDocId = 0;
        int _PrevId = 0;
        int _BatchId = 0;

        public int BatchId
        {
            get { return _BatchId; }
            set { _BatchId = value; }
        }

        StockOut_BLL SMBll = new StockOut_BLL();
        CMB_BLL Bll = new CMB_BLL();

        bool _EnableSearchId = false;
        string _OutcomeDoc = "";

        bool _EnableDN = false;
        public bool EnableDN
        {
            get { return _EnableDN; }
            set { _EnableDN = value; }
        }

        public string OutcomeDoc
        {
            get { return txt_OutcomeDoc.Text; }
            set
            {

                _OutcomeDoc = value;
                txt_OutcomeDoc.Text = value;
                DataSet ds = new DataSet();

                string strSQL = EnableDN == true
                    ? "SELECT DISTINCT TOP 1 id FROM STO_StockOutHead WHERE name = '" + _OutcomeDoc.ToString() + "' and (typeout = 5 or typeout = 15 or typeout = 17 or typeout = 28 or typeout = 4)"
                    : "SELECT DISTINCT TOP 1 id FROM STO_StockOutHead WHERE name = '" + _OutcomeDoc.ToString() + "' and (typeout = 5 or typeout = 15 or typeout = 17 or typeout = 28)";
                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        strSQL, sConnStr);

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        OutcomeDocId = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                        BatchId = Convert.ToInt32(dt.Rows[0]["batchid"].ToString());
                    }
                }
                else
                {
                    _OutcomeDocId = 0;
                    _BatchId = 0;

                    if (OutDocChanged != null)
                    {
                        OutDocChanged(this);
                    }



                    //return;
                }


            }
        }

        public int OutcomeDocId
        {
            get
            {
                try { return _OutcomeDocId; }
                catch { return 0; }
            }
            set
            {


                _OutcomeDocId = value;

                //if (_PrevId != _OutcomeDocId)
                // {
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();

                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter("SELECT top 1 name, isnull(batchid, 0) as batchid FROM STO_StockOutHead WHERE id = " + _OutcomeDocId.ToString(), conn);
                adapter.Fill(ds);

                conn.Close();

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        txt_OutcomeDoc.Text = dr["name"].ToString();
                        BatchId = Convert.ToInt32(dr["batchid"]);
                    }
                    if (OutDocChanged != null)
                    {
                        OutDocChanged(this);
                    }
                }
                else
                {
                    BatchId = 0;
                    txt_OutcomeDoc.Text = string.Empty;
                }

                // _PrevId = _OutcomeDocId;

                //if (OutDocChanged != null)
                //{
                //    OutDocChanged(this);
                //}

                //}
            }
        }

        int _OutcomeDocSavedId = 0;

        public int OutcomeDocSavedId
        {
            get { return _OutcomeDocSavedId; }
            set
            {
                _OutcomeDocSavedId = value;
                if (OutDocSaved != null)
                {
                    OutDocSaved(this);
                }
            }
        }

        public void OutcomeDocSendSave()
        {
            if (OutDocSaved != null)
            {
                OutDocSaved(this);
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
            //txt_OutcomeDoc.Text = string.Empty;
            OutcomeDoc = string.Empty;
        }

        private void txt_OutcomeDoc_TextChanged(object sender, EventArgs e)
        {
            try { OutcomeDoc = txt_OutcomeDoc.Text; }
            catch { }
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            frm_AddOutcomeDoc frm = new frm_AddOutcomeDoc();

            frm.FillAutoDoc(4);

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                int _res = Bll.AddOutcomeDocHead(frm.DocDate, frm.Comments, frm.TypeOff, frm.ReasonId, frm.BatchId);
                OutcomeDocId = _res;
                if (OutDocChanged != null)
                {
                    OutDocChanged(this);
                }
                if (OutDocSaved != null)
                    OutDocSaved(this);
            }

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (OutcomeDocId != 0)
            {
                frm_AddOutcomeDoc frm = new frm_AddOutcomeDoc();

                frm.Id = OutcomeDocId;
                Bll.OutDocHeadId = OutcomeDocId;
                frm.HeaderText = "Edit document: " + Bll.OutDocName;
                frm.OutDoc = Bll.OutDocName;
                frm.DocDate = Bll.OutDocDocDate;
                frm.TypeOff = Bll.OutDocTypeOff;
                frm.Comments = Bll.OutDocComments;
                frm.ReasonId = Bll.OutDocReasonId;
                frm.BatchId = Bll.OutDocBatchId;
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Bll.EditOutcomeDocHead(frm.Id, frm.DocDate, frm.Comments, frm.TypeOff, frm.ReasonId, frm.BatchId);

                    if (OutDocChanged != null)
                    {
                        OutDocChanged(this);
                    }
                    if (OutDocSaved != null)
                        OutDocSaved(this);
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

            frm_OutDocs popup = new frm_OutDocs();
            popup.cmb_OutcomeDocsOne = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };
            if (EnableDN == true)
                popup.FillDataAll(OutcomeDoc);
            else
                popup.FillData(OutcomeDoc);
        }

        private void txt_OutcomeDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
        }
    }
}

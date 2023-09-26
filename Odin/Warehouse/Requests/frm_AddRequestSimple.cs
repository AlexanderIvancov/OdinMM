using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.CMB_Components.BLL;
namespace Odin.Warehouse.Requests
{
    public delegate void RequestSimpleSavedEventHandler(object sender);

    public partial class frm_AddRequestSimple : KryptonForm
    {

        public frm_AddRequestSimple()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public event RequestSimpleSavedEventHandler RequestDetsSaved;
        Requests_BLL ReqBLL = new Requests_BLL();
        DAL_Functions Fun = new DAL_Functions();
        class_Global glob_Class = new class_Global();
        Helper MyHelper = new Helper();
        CMB_BLL Bll = new CMB_BLL();

        #region Variables

        public int BatchId
        {
            get { return cmb_Batches1.BatchId; }
            set { cmb_Batches1.BatchId = value; }
        }

        PopupWindowHelper PopupHelper = null;

        public int ProdPlaceId
        {
            get { return cmb_Common2.SelectedValue; }
            set { cmb_Common2.SelectedValue = value; }

        }

        #endregion

        #region Methods

        public void AddGridRow(int batchdetid, int artid, string article, double qty, string unit, string comments, int unitid)
        {
            int _countbdid = 0;

            //foreach (DataGridViewRow row in this.gv_List.Rows)
            //{
            //    if (Convert.ToInt32(row.Cells["cn_id"].Value) == batchdetid
            //        || Convert.ToInt32(row.Cells["cn_artid"].Value) == artid)
            //        _countbdid++;
            //}

            if (_countbdid == 0
                || batchdetid == 0)
            gv_List.Rows.Add(batchdetid,
                                cmb_Batches1.Batch,
                                artid,
                                article,
                                qty,
                                unit,
                                comments,
                                unitid, 
                                "");
        }

        public bool CheckEmpty()
        {
            bool _res = true;
            if (cmb_Common1.SelectedValue == 0)
                _res = false;

            return _res;

        }

        public bool CheckMB()
        {
            bool _res = true;

            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Fun.CheckMBLimit(Convert.ToInt32(row.Cells["cn_artid"].Value)) == true 
                    && (row.Cells["cn_serials"].Value.ToString()).Trim() == "")
                {
                    _res = false;
                    break;
                }
            }

            return _res;

        }


        public void ClearRows()
        {
            //foreach (DataGridViewRow row in gv_List.Rows)
            //{
            //    gv_List.Rows.Remove(row);
            //}
            gv_List.Rows.Clear();
        }

        #endregion

        #region Controls

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (CheckMB() == true)
            {
                if (CheckEmpty() == true)
                {
                    gv_List.EndEdit();

                    int _res = 0;

                    foreach (DataGridViewRow row in this.gv_List.Rows)
                    {
                        if (Convert.ToDouble(row.Cells["cn_qty"].Value) > 0)
                        {
                            _res = ReqBLL.AddRequestDetail(ReqBLL.RequestHeadId,
                                                        Convert.ToInt32(row.Cells["cn_artid"].Value),
                                                        row.Cells["cn_article"].Value.ToString(),
                                                        Convert.ToInt32(row.Cells["cn_id"].Value),
                                                        Convert.ToDouble(row.Cells["cn_qty"].Value.ToString().Trim()),
                                                        Convert.ToInt32(row.Cells["cn_unitid"].Value),
                                                        System.DateTime.Now.ToShortDateString(),
                                                        chk_urgent.CheckState == CheckState.Checked ? -1 : 0,
                                                        row.Cells["cn_comments"].Value.ToString(),
                                                        0,
                                                        0,
                                                        cmb_Common1.SelectedValue,
                                                        ProdPlaceId,
                                                        row.Cells["cn_serials"].Value.ToString());
                        }
                    }

                    Bll.RequestId = ReqBLL.RequestHeadId;

                    if (ReqBLL.RequestHeadId != 0)
                    {
                        if (chk_urgent.CheckState == CheckState.Checked)
                        {
                            //Send letter
                            string emailaddresses = "";
                            emailaddresses = Fun.EmailAddressesByType(4);

                            if (emailaddresses != "")
                            {

                                string strMessage = "Request number: " + Bll.RequestName;
                                strMessage = strMessage + "\r\nBatch: " + cmb_Batches1.Batch.ToString();
                                MyHelper.SendMessage(glob_Class.ReplaceChar(emailaddresses, ";", ","), "Urgent request NR : " + Bll.RequestName + " was created!", strMessage);
                            }

                        }

                        Clipboard.SetText(Bll.RequestName);
                        KryptonTaskDialog.Show("Creation was successful!",
                                                   "Request NR: " + Bll.RequestName + " was created!",
                                                    "",
                                                    MessageBoxIcon.Information,
                                                    TaskDialogButtons.OK);


                        if (RequestDetsSaved != null)
                            RequestDetsSaved(this);
                        ClearRows();
                        ReqBLL.RequestHeadId = 0;
                    }
                    else
                    {
                        KryptonTaskDialog.Show("Mistake during request creation!",
                                              "Request was not created!",
                                               "Something wrong! Please check lines!",
                                               MessageBoxIcon.Warning,
                                               TaskDialogButtons.OK);
                    }
                }
                else
                {
                    KryptonTaskDialog.Show("Mistake during request creation!",
                                               "Request was not created!",
                                                "Please check cause code!",
                                                MessageBoxIcon.Warning,
                                                TaskDialogButtons.OK);
                }
            }
            else
                glob_Class.ShowMessage("You have empty serial numbers fields!", "Enter serial numbers!", "Serial numbers warning!");
        }

        private void btn_AddPlaces_Click(object sender, EventArgs e)
        {
            if (cmb_Batches1.BatchId == 0
                && cmb_Articles1.ArticleId != 0
                )
            {
                AddGridRow(0, cmb_Articles1.ArticleId, cmb_Articles1.Article, 0, cmb_Articles1.Unit, "", cmb_Articles1.UnitId);
            }
            else
            {
                Form f;
                f = this.FindForm();

                Point LocationPoint = btn_AddPlaces.PointToScreen(Point.Empty);
                int xpos = LocationPoint.X;
                int ypos = LocationPoint.Y + btn_AddPlaces.Height;
                Point _location = new Point(xpos, ypos);

                frm_BatchArticles popup = new frm_BatchArticles();
                popup.frmAddRequestSimple = this;

                PopupHelper.ClosePopup();

                PopupHelper.ShowPopup(f, popup, _location);

                PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
                {
                    if (popup.ShowingModal)
                    {
                        _e.Cancel = true;
                    }
                };

                //MessageBox.Show(SupId.ToString());
                popup.FillList(cmb_Batches1.BatchId);
            }
        }
        
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gv_List.SelectedRows)
            {
                gv_List.Rows.Remove(row);
            }
            
        }

        #endregion

        private void cmb_Batches1_BatchChanged(object sender)
        {
            if (cmb_Batches1.IsActive == -1
                || cmb_Batches1.BatchId == 0)
                btn_AddPlaces.Enabled = true;
            else
                btn_AddPlaces.Enabled = false;
        }

        private void gv_List_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            try {
                if (gv_List.CurrentRow.Cells["cn_qty"].Selected == true)
                {
                    if (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_qty"].Value) < 0)
                        gv_List.CurrentRow.Cells["cn_qty"].Value = 0;
                    
                    if (Fun.CheckMBLimit(Convert.ToInt32(gv_List.CurrentRow.Cells["cn_artid"].Value)) == true && Convert.ToDouble(gv_List.CurrentRow.Cells["cn_qty"].Value) > 1)
                    {
                        glob_Class.ShowMessage("Qty can't be more than 1!", "Qty can't be more than 1!", "Serial numbers warning!");
                        gv_List.CurrentRow.Cells["cn_qty"].Value = 1;
                    }
                }

            }
            catch { }
        }

        private void btn_CopyRow_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = gv_List.CurrentRow;

            gv_List.Rows.Add(row.Cells[0].Value,
                                row.Cells[1].Value,
                                row.Cells[2].Value,
                                row.Cells[3].Value,
                                row.Cells[4].Value,
                                row.Cells[5].Value,
                                row.Cells[6].Value,
                                row.Cells[7].Value,
                                row.Cells[8].Value);

            //v_List.Rows.CopyTo()
        }
    }
}

using Odin.Global_Classes;
using Odin.Tools;
using Odin.Warehouse.StockIn;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace Odin.Warehouse.Deliveries
{
    public partial class ctl_Packing : UserControl
    {
        public ctl_Packing()
        {
            InitializeComponent();
        }

        #region Variables

        DelivNote_BLL BLL = new DelivNote_BLL();
        StockIn_BLL BLLIN = new StockIn_BLL();
        class_Global globClass = new class_Global();
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PrinterLabels PrintLabels = new PrinterLabels();

        public string HeaderText
        {
            get { return kryptonHeaderGroup1.ValuesPrimary.Heading; }
            set { kryptonHeaderGroup1.ValuesPrimary.Heading = value; }
        }

        int _delivenoteid = 0;
        
        public int DelivNoteId
        {
            get { return _delivenoteid; }
            set { _delivenoteid = value;

                ShowNotPackedDets(_delivenoteid);
                ShowPacking(_delivenoteid);
            }
        }

        public int PackId
        {
            get;
            set;
        }

        public int _PrevId = 0;


        #endregion

        #region Methods

        public void ShowNotPackedDets(int _delivnoteid)
        {
            var data = DelivNote_BLL.getDeliveryNotPacked(_delivenoteid);

            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;
            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });
        }

        public void ShowPackingDets(int _packid)
        {
            //MessageBox.Show(_packid.ToString());
            var data = DelivNote_BLL.getDeliveryPackageContent(_packid);

            gv_Content.ThreadSafeCall(delegate
            {
                gv_Content.AutoGenerateColumns = false;
                bs_Content.DataSource = data;
                gv_Content.DataSource = bs_Content;
            });


            bn_Content.ThreadSafeCall(delegate
            {
                bn_Content.BindingSource = bs_Content;
            });
        }

        public void ShowPacking(int _delivnoteid)
        {
            var data = DelivNote_BLL.getDeliveryPackage(_delivenoteid);

            gv_Package.ThreadSafeCall(delegate
            {
                gv_Package.AutoGenerateColumns = false;
                bs_Package.DataSource = data;
                gv_Package.DataSource = bs_Package;
            });


            bn_Package.ThreadSafeCall(delegate
            {
                bn_Package.BindingSource = bs_Package;
            });
        }


        private bool CheckOldRow()
        {

            try
            {
                PackId = Convert.ToInt32(gv_Package.CurrentRow.Cells["cn_pid"].Value);
            }
            catch
            {
                PackId = 0;
            }

            if (_PrevId == PackId)
            {
                return true;
            }
            else
            {
                _PrevId = PackId;
                return false;
            }
        }

        #endregion

        #region Controls

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int _packid = 0;
            try { _packid = Convert.ToInt32(gv_Package.CurrentRow.Cells["cn_pid"].Value); }
            catch { }

            if (_packid != 0)
            {
                foreach (DataGridViewRow row in this.gv_List.Rows)
                    if (Convert.ToDouble(row.Cells["cn_topack"].Value) > 0 && Convert.ToDouble(row.Cells["cn_weightnet"].Value) <= 0) { MessageBox.Show("Error! Weight net of box is 0!"); return; }
                foreach (DataGridViewRow row in this.gv_List.Rows)
                    if (Convert.ToDouble(row.Cells["cn_topack"].Value) > 0)
                        BLL.AddPackageContent(Convert.ToInt32(row.Cells["cn_id"].Value), _packid, 
                                                Convert.ToDouble(row.Cells["cn_topack"].Value), 
                                                Convert.ToDouble(row.Cells["cn_weightnet"].Value));
            }
            
            ShowNotPackedDets(DelivNoteId);
            ShowPackingDets(PackId);
        }

        private void gv_List_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Global_Resourses.bindingNavigatorAddNewItem_Image.Width;
                var h = Global_Resourses.bindingNavigatorAddNewItem_Image.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Global_Resourses.bindingNavigatorAddNewItem_Image, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void gv_Package_SelectionChanged(object sender, EventArgs e)
        {
            if (CheckOldRow() == false)
            {
                ShowPackingDets(PackId);
            }
        }

        private void btn_addpacking_Click(object sender, EventArgs e)
        {
            frm_AddPack frm = new frm_AddPack();
            frm.CheckEmpty();
            frm.HeaderText = "Add new package";
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK
                && DelivNoteId != 0)
            {
                int _res = BLL.AddPackage(DelivNoteId, frm.Package, frm.QtyPack, frm.WeightBrut, frm.Comments, frm.BoxNO);

                ShowPacking(DelivNoteId);
            }
        }

        private void btn_editpack_Click(object sender, EventArgs e)
        {
            int _id = 0;
            string _package = "";
            int _qtypack = 0;
            double _weightbrut = 0;
            string _comments = "";
            int _boxno = 0;

            try
            {
                _id = Convert.ToInt32(gv_Package.CurrentRow.Cells["cn_pid"].Value);
                _qtypack = Convert.ToInt32(gv_Package.CurrentRow.Cells["cn_pqty"].Value);
                _weightbrut = Convert.ToDouble(gv_Package.CurrentRow.Cells["cn_weightbrut"].Value);
                _comments = gv_Package.CurrentRow.Cells["cn_pcomments"].Value.ToString();
                _package = gv_Package.CurrentRow.Cells["cn_package"].Value.ToString();
                _boxno = Convert.ToInt32(gv_Package.CurrentRow.Cells["cn_boxno"].Value);
            }
            catch { }

            if (_id != 0)
            {
                frm_AddPack frm = new frm_AddPack();
                frm.HeaderText = "Edit package: " + _package;
                frm.Package = _package;
                frm.QtyPack = _qtypack;
                frm.WeightBrut = _weightbrut;
                frm.Comments = _comments;
                frm.BoxNO = _boxno;
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK
                    && DelivNoteId != 0)
                {
                    BLL.EditPackage(_id, DelivNoteId, frm.Package, frm.QtyPack, frm.WeightBrut, frm.Comments, frm.BoxNO);

                    ShowPacking(DelivNoteId);
                }
            }
        }

        private void btn_deletepack_Click(object sender, EventArgs e)
        {
            int _id = 0;

            try
            {
                _id = Convert.ToInt32(gv_Package.CurrentRow.Cells["cn_pid"].Value);

            }
            catch { }

            if (_id != 0
                && globClass.DeleteConfirm() == true)
            {

                BLL.DeletePackage(_id);
               
                ShowPacking(DelivNoteId);

            }
        }

        private void btn_deletecontent_Click(object sender, EventArgs e)
        {
            int _id = 0;

            try
            {
                _id = Convert.ToInt32(gv_Content.CurrentRow.Cells["cn_cid"].Value);

            }
            catch { }

            if (_id != 0
                && globClass.DeleteConfirm() == true)
            {

                BLL.DeletePackageContent(_id);
                ShowNotPackedDets(DelivNoteId);
                ShowPackingDets(PackId);
            }
        }

        private void gv_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gv_List.CurrentRow.Cells["btn_addpack"].Selected == true)
                {
                    gv_List.CurrentRow.Cells["cn_topack"].Value = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_notpacked"].Value);
                    gv_List.CurrentRow.Cells["cn_weightnet"].Value = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_topack"].Value) 
                                                                    * Convert.ToDouble(gv_List.CurrentRow.Cells["cn_netweight"].Value);
                    //MessageBox.Show((Convert.ToDouble(gv_List.CurrentRow.Cells["cn_topack"].Value)
                    //                                           * Convert.ToDouble(gv_List.CurrentRow.Cells["cn_netweight"].Value)).ToString());
                }
            }
            catch { }
        }

        private void gv_List_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            gv_List.EndEdit();
            if (gv_List.CurrentRow.Cells["cn_topack"].Selected == true)
            {
                if (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_topack"].Value) > Convert.ToDouble(gv_List.CurrentRow.Cells["cn_notpacked"].Value))
                    gv_List.CurrentRow.Cells["cn_topack"].Value = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_notpacked"].Value);
                gv_List.CurrentRow.Cells["cn_weightnet"].Value = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_topack"].Value) 
                                                                * Convert.ToDouble(gv_List.CurrentRow.Cells["cn_netweight"].Value);
                //MessageBox.Show((Convert.ToDouble(gv_List.CurrentRow.Cells["cn_topack"].Value)
                //                                                * Convert.ToDouble(gv_List.CurrentRow.Cells["cn_netweight"].Value)).ToString());
            }
        }


        #endregion

        private void btn_printlabel_Click(object sender, EventArgs e)
        {
            int _packid = 0;
            try { _packid = Convert.ToInt32(gv_Package.CurrentRow.Cells["cn_pid"].Value); }
            catch { }

            if (_packid != 0)
            {
                frm_Print frm = new frm_Print();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT DISTINCT TOP 1 lt.ip, sp.name, sp.dpi from bas_labeltemplate lt inner join sys_printers sp on sp.ipadress = lt.ip where lt.id = 7", sConnStr);

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                try
                {
                    frm.IP_Address = dt.Rows[0]["ip"].ToString();
                    frm.Printer_DPI = Convert.ToInt32(dt.Rows[0]["dpi"].ToString());
                    frm.PrinterName = dt.Rows[0]["name"].ToString();
                }
                catch
                {
                    frm.cmb_LabPrinter1.ShowDefaults();
                }
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    PrintLabels.PrinterIp = frm.IP_Address;
                    PrintLabels.PrinterDPI = frm.Printer_DPI;

                    var sqlparamsfields = new List<SqlParameter>()
                        {
                            new SqlParameter("@pack",SqlDbType.Int) {Value = _packid},
                            new SqlParameter("@labelqty",SqlDbType.Int) {Value = frm.LabelQty}
                        };
                    if (frm.LabelQty != 0)
                        PrintLabels.PrintLabel(PrintLabels.LabelConstructor(7, "sp_SelectBatchBoxDet", sqlparamsfields.ToArray()), 1/*frm.LabelQty*/);
                }
                else
                { }
            }
        }

        private void btn_SerialNumbers_Click(object sender, EventArgs e)
        {
            int _packid = 0;
            try { _packid = Convert.ToInt32(gv_Package.CurrentRow.Cells["cn_pid"].Value); }
            catch { }

            if (_packid != 0)
            {
                var _query = "sp_SelectBatchBoxContent";

                var sqlparams = new List<SqlParameter>()
                {
                    new SqlParameter("@packid",SqlDbType.Int) {Value = _packid}
                };

                Template_DataGridView frm = new Template_DataGridView();

                frm.Text = "Box content";
                frm.Query = _query;
                frm.SqlParams = sqlparams;
                frm.Show(); frm.GetKryptonFormFields();
            }
        }

        private void btn_AddSN_Click(object sender, EventArgs e)
        {
            int _id = 0;

            try
            {
                _id = Convert.ToInt32(gv_Package.CurrentRow.Cells["cn_pid"].Value);

            }
            catch { }

            if (_id != 0)
            {
                frm_cmbText frm = new frm_cmbText();
                frm.HeaderText = "Add serial number";
                frm.LabelText = "Serial number:";
               
                DialogResult result = frm.ShowDialog();
               
                if (result == DialogResult.OK
                    && frm.FormText != "")
                {

                    int _batchid = 0;
                    _batchid = Convert.ToInt32(Helper.GetOneRecord("select top 1 batchid from prod_serialtracing where (serial = '" + frm.FormText + "' or analog = '" + frm.FormText + "') and stageid = 7 "));

                    if (_batchid == 0)
                    {
                       globClass.ShowMessage("There is no such serial on FQC stage!", "Check FQC!", "Adding of serial impossible!");
                    }
                    else
                    {
                        DataTable dataserials = new DataTable();
                        dataserials.Columns.Add("serial", typeof(string));
                        dataserials.Columns.Add("tablename", typeof(string));

                        DataRow drser = dataserials.NewRow();
                        drser["serial"] = frm.FormText;
                        drser["tablename"] = "";
                        dataserials.Rows.Add(drser);

                        BLLIN.AddStockInBoxDets(_id, dataserials);
                    }
                }
            }
        }

        private void btn_EditContent_Click(object sender, EventArgs e)
        {
            int _id = 0;
            double _weight = 0;

            try
            {
                _id = Convert.ToInt32(gv_Content.CurrentRow.Cells["cn_cid"].Value);
                _weight = Convert.ToInt32(gv_Content.CurrentRow.Cells["cn_aweightnet"].Value);
            }
            catch { }
            if (_weight <= 0) { MessageBox.Show("Error! Weight net of box is 0!"); return; }

            if (_id != 0)
            {

                frm_cmbNumber frm = new frm_cmbNumber();
                frm.LabelText = "Weight net(kgs):";
                frm.FormNumber = _weight;
                frm.HeaderText = "Edit weight (net)";

                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    BLL.EditPackageContent(_id, frm.FormNumber);
                    ShowNotPackedDets(DelivNoteId);
                    ShowPackingDets(PackId);
                }
            }
        }

        private void btn_Serials_Click(object sender, EventArgs e)
        {

        }
    
    }
}

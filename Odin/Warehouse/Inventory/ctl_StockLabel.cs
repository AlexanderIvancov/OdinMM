using Odin.Global_Classes;
using Odin.Register;
using Odin.Warehouse.Movements;
using Odin.Warehouse.StockIn;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Odin.Warehouse.Inventory
{
    public delegate void LabelSavingEventHandler(object sender);
    public delegate void RemovingReservationEventHandler(object sender);

    public partial class ctl_StockLabel : UserControl
    {
        public ctl_StockLabel()
        {
            InitializeComponent();
            frm_Inventory.ReceiveArt += new ReceiveMyArt(RetArt);
        }

        public event LabelSavingEventHandler SaveLabel;
        public event RemovingReservationEventHandler RemoveReservation;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        StockInventory SIBll = new StockInventory();
        StockIn_BLL SINBll = new StockIn_BLL();
        DAL_Functions Fun = new DAL_Functions();
        class_Global globClass = new class_Global();
        Reg_BLL RegBll = new Reg_BLL();
        PrinterLabels PrintLabels = new PrinterLabels();
        StockMove_BLL MovBLL = new StockMove_BLL();


        #region Variables

        public int RetArt()
        {
            return cmb_Articles1.ArticleId;
        }

        public int Label
        {
            get
            {
                try { return Convert.ToInt32(txt_Label.Text); }
                catch { return 0; }
            }
            set { txt_Label.Text = value.ToString(); }
        }

        public int ParentLabel
        {
            get
            {
                try { return Convert.ToInt32(txt_ParentLabel.Text); }
                catch { return 0; }
            }
            set { txt_ParentLabel.Text = value.ToString(); }
        }

        public int ArtId
        {
            get { return cmb_Articles1.ArticleId; }
            set
            {
                cmb_Articles1.ArticleId = value;

            }
        }

        public string Article
        {
            get { return cmb_Articles1.Article; }
            set
            {
                cmb_Articles1.Article = value;

            }
        }

        public double Qty
        {
            get
            {
                try { return Convert.ToDouble(txt_Qty.Text); }
                catch { return 0; }
            }
            set { txt_Qty.Text = value.ToString(); }
        }

        public int UnitId
        {
            get { return cmb_Units1.UnitId; }
            set { cmb_Units1.UnitId = value; }
        }

        public string ExpDate
        {
            get
            {
                return txt_ExpDate.Value == null ? "" : txt_ExpDate.Value.ToString();
            }
            set
            {
                try
                {
                    txt_ExpDate.Value = Convert.ToDateTime(value);
                }
                catch { txt_ExpDate.Value = null; }
            }
        }

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }

        public int Available
        {
            get
            {
                return chk_Available.Checked == true ? -1 : 0;
            }
            set
            {
                chk_Available.Checked = value == -1;
            }
        }

        public int PlaceId
        {
            get { return cmb_Places1.PlaceId; }
            set { cmb_Places1.PlaceId = value; }
        }
        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }

        //public string Reservation
        //{
        //    get { return txt_Reservation.Text; }
        //    set { txt_Reservation.Text = value; }
        //}

        public string DataCode
        {
            get { return txt_DataCode.Text; }
            set { txt_DataCode.Text = value; }
        }

        public int NoExpDate
        {
            get
            {
                return chk_NoDate.Checked == true ? -1 : 0;
            }
            set
            {
                chk_NoDate.Checked = value == -1;

            }
        }

        public string ManufBatch
        {
            get { return txt_ManufBatch.Text; }
            set { txt_ManufBatch.Text = value; }
        }


        #endregion

        #region Methods

        public void FillSpecs(int Label)
        {
            var data = StockInventory.getSpecifications(Label);

            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

            });

        }

        public void FillReservations(int Label)
        {
            var data = StockInventory.getLabelReservations(Label);

            gv_Reservations.ThreadSafeCall(delegate
            {
                gv_Reservations.AutoGenerateColumns = false;
                bs_Reservations.DataSource = data;
                gv_Reservations.DataSource = bs_Reservations;

            });


            bn_Reservations.ThreadSafeCall(delegate
            {
                bn_Reservations.BindingSource = bs_Reservations;
            });

        }

        //public void FillInDocs(int Label)
        //{
        //    var data = StockInventory.getInDocs(Label);

        //    gv_Reservations.ThreadSafeCall(delegate
        //    {
        //        gv_Reservations.AutoGenerateColumns = false;
        //        bs_InDocs.DataSource = data;
        //        gv_Reservations.DataSource = bs_InDocs;

        //    });

        //}

        public void ShowDets(int Label)
        {
            SqlConnection conn = new SqlConnection(sConnStr);
            conn.Open();
            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                new SqlDataAdapter(
                    "execute sp_SelectStockLabelDets @id = " + Label, conn);


            conn.Close();

            adapter.Fill(ds);

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Qty = Convert.ToDouble(dr["qty"]);
                    ArtId = Convert.ToInt32(dr["artid"]);
                    UnitId = cmb_Articles1.UnitId;
                    PlaceId = Convert.ToInt32(dr["placeid"]);
                    ParentLabel = Convert.ToInt32(dr["parentlabel"]);
                    ExpDate = dr["expdate"].ToString();
                    Comments = dr["comments"].ToString();
                    Available = Convert.ToInt32(dr["usage"]);
                    //Reservation = dr["batch"].ToString();
                    DataCode = dr["datacode"].ToString();
                    NoExpDate = Convert.ToInt32(dr["nodate"]);
                    ManufBatch = dr["manufbatch"].ToString();
                }
            }
            else
            {
                ClearFields();
            }
        }

        public void ClearFields()
        {
            Qty = 0;
            ArtId = 0;
            UnitId = 0;
            ParentLabel = 0;
            ExpDate = null;
            Comments = "";
            Available = 0;
            PlaceId = 0;
            //Reservation = "";
            DataCode = "";
            NoExpDate = 0;
            ManufBatch = "";
        }
        #endregion

        private void txt_Label_TextChanged(object sender, EventArgs e)
        {
            //try {
            FillSpecs(Label);
            FillReservations(Label);
            ShowDets(Label);
            //}
            //catch { ClearFields(); }
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_ExpDate.Value = System.DateTime.Now;
        }

        #region Controls

        private void btn_OK_Click(object sender, EventArgs e)
        {
            SIBll.EditStockLabel(Label, ExpDate, Available, ParentLabel, Comments, DataCode, ManufBatch);
            if (NoExpDate == -1)
                SINBll.SetNoExpDate(Label);
            ShowDets(Label);
            if (SaveLabel != null)
                SaveLabel(this);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (Label != 0)
            {
                frm_AddSpecification frm = new frm_AddSpecification();

                frm.HeaderText = "Add new specification for: " + Label;
                frm.CheckEmpty();

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    RegBll.AddProperty(0, Label, frm.CategoryId, frm.Value, frm.Comments);

                    FillSpecs(Label);
                }
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {

            int _id = 0;

            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (Label != 0 && _id != 0)
            {

                frm_AddSpecification frm = new frm_AddSpecification();

                frm.CategoryId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_categoryid"].Value);
                frm.Value = gv_List.CurrentRow.Cells["cn_value"].Value.ToString();
                frm.Comments = gv_List.CurrentRow.Cells["cn_comments"].Value.ToString();

                frm.HeaderText = "Edit specification for: " + Label;

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    RegBll.EditProperty(_id, 0, Label, frm.CategoryId, frm.Value, frm.Comments);

                    FillSpecs(Label);
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _id = 0;

            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0 && globClass.DeleteConfirm() == true)
            {
                RegBll.DeleteProperty(_id);
                FillSpecs(Label);
            }
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {

        }

        private void btn_Merging_Click(object sender, EventArgs e)
        {

        }

        private void btn_RemoveReservation_Click(object sender, EventArgs e)
        {
            if (globClass.RemoveReservationConfirm() == true)
            {
                SIBll.RemoveLabelReservation(Label);
                ShowDets(Label);
                if (RemoveReservation != null)
                    RemoveReservation(this);
            }
        }

        #endregion

        private void btn_Print_Click(object sender, EventArgs e)
        {
            //var sqlparamsfields = new List<SqlParameter>()
            //    {
            //        new SqlParameter("@id",SqlDbType.Int) {Value = Label}
            //    };

            //MessageBox.Show(PrintLabels.LabelConstructor(1, "sp_SelectStockLabelDets", sqlparamsfields.ToArray()));

            frm_Print frm = new frm_Print();
            frm.cmb_LabPrinter1.ShowDefaults();
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                PrintLabels.PrinterIp = frm.IP_Address;
                PrintLabels.PrinterDPI = frm.Printer_DPI;

                var sqlparamsfields = new List<SqlParameter>()
                {
                    new SqlParameter("@id",SqlDbType.Int) {Value = Label},
                    new SqlParameter("@qty",SqlDbType.Float) {Value = Qty},
                    new SqlParameter("@labelqty",SqlDbType.Int) {Value = frm.LabelQty}
                };

                if (Fun.CheckMSL(ArtId) != "0"
                    && frm.LabelQty != 0)
                    PrintLabels.PrintLabel(PrintLabels.LabelConstructor(rb_Simple.Checked == true ? 1 : 3, "sp_SelectStockLabelDetsPrint", sqlparamsfields.ToArray()), 1/*frm.LabelQty*/);
                else
                    MessageBox.Show("MSL = 0! Printing impossible!");
            }
            else
            { }
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_DataCode.Text = string.Empty;
        }

        private void btn_Separate_Click(object sender, EventArgs e)
        {
            if (Label != 0
                && Qty > 0)
            {
                frm_SeparateLabels frm = new frm_SeparateLabels();
                frm.SeparType = 1;
                frm.QtyOnLabel = Qty;
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int c = 1;
                    while (c <= frm.QtyLabels)
                    {
                        if (frm.NewQty > 0)
                        {
                            MovBLL.SeparateLabel(Label, frm.NewQty);
                            c++;
                        }
                    }
                    ShowDets(Label);
                    if (SaveLabel != null)
                        SaveLabel(this);
                }
            }
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_ManufBatch.Text = string.Empty;
        }
    }
}

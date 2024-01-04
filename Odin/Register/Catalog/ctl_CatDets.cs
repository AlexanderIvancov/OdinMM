using Odin.Global_Classes;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace Odin.Register.Catalog
{
    public partial class ctl_CatDets : UserControl
    {
        public ctl_CatDets()
        {
            InitializeComponent();
        }

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        Reg_BLL BLL = new Reg_BLL();
        frm_AddCatItem frm = null;


        public int Id
        {
            get;
            set;
        }

        int _ArtId = 0;

        public int ArticleId
        {
            get { return cmb_Articles1.ArticleId; }
            set
            {
                //cmb_Articles1.ArticleId = value;
                _ArtId = value;
                FillCatalog(_ArtId);
                //SetCellsColor();
            }
        }

        public void FillCatalog(int ArtId)
        {
            var data = Reg_BLL.getCatalogArticle(ArtId);

            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

                SetCellsColor();
            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });
        }

        public void CatAdded(object sender)
        {
            int NewLineId = 0;

            NewLineId = BLL.AddCatalogItem(frm.BargType, frm.ArticleId, frm.FirmId, frm.FirmArt, frm.UnitId, frm.UnitPrice, frm.CurId, frm.Manufacturer, frm.Comments,
                                            frm.DelivTerms, frm.MOQ, frm.MPQ, frm.AsDefault, "", Convert.ToInt32(frm.Vat), frm.MinExpDays, frm.CoefConv, frm.DataCode, 
                                            frm.DelivTermTxt, frm.Quoted, frm.BarCode, frm.ForCustomer);

            FillCatalog(ArticleId);

            frm.Close();
        }

        public void CatEdited(object sender)
        {
            BLL.EditCatalogItem(frm.CatID, frm.BargType, frm.ArticleId, frm.FirmId, frm.FirmArt, frm.UnitId, frm.UnitPrice, frm.CurId, frm.Manufacturer, frm.Comments,
                                            frm.DelivTerms, frm.MOQ, frm.MPQ, frm.AsDefault, "", Convert.ToInt32(frm.Vat), frm.MinExpDays, frm.CoefConv, frm.DataCode,
                                            frm.DelivTermTxt, frm.Quoted, frm.BarCode, frm.ForCustomer);
            BLL.CatId = frm.CatID;
            FillCatalog(ArticleId);
            

            frm.Close();
        }

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                row.Cells["cn_firmart"].Style.BackColor = Convert.ToInt32(row.Cells["cn_bargtype"].Value) == -1
                    ? Color.Yellow
                    : Convert.ToInt32(row.Cells["cn_bargtype"].Value) == 1 ? Color.LightGreen : Color.Aqua;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm = new frm_AddCatItem();
            frm.ArticleId = ArticleId;
            frm.CatSaved += new CatSavedEventHandler(CatAdded);

            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0)
            {
                frm = new frm_AddCatItem();
                BLL.CatId = _id;
                frm.CatID = _id;
                frm.ArticleId = BLL.CatArtId;
                frm.BargType = BLL.CatBargain;
                frm.FirmArt = BLL.CatFirmArt;
                frm.FirmId = BLL.CatFirmId;
                frm.UnitId = BLL.CatUnitId;
                frm.UnitPrice = BLL.CatUnitPrice;
                frm.CurId = BLL.CatCurId;
                frm.Manufacturer = BLL.CatManufacturer;
                frm.DelivTerms = BLL.CatDelivDerm;
                frm.MOQ = BLL.CatMOQ;
                frm.MPQ = BLL.CatMPQ;
                frm.AsDefault = BLL.CatAsDefault;
                frm.MinExpDays = BLL.CatMinExpDays;
                frm.CoefConv = BLL.CatCoefConv;
                frm.Comments = BLL.CatComments;
                frm.Vat = BLL.CatVat;
                frm.DataCode = BLL.CatDataCode;
                frm.DelivTermTxt = BLL.CatDelivTermTxt;
                frm.Quoted = BLL.CatQuoted;
                frm.BarCode = BLL.CatBarCode;
                frm.ForCustomer = BLL.CatForCust;

                frm.CatSaved += new CatSavedEventHandler(CatEdited);
                

                frm.Show(); frm.GetKryptonFormFields();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (glob_Class.DeleteConfirm() == true
                && _id != 0)
            {
                BLL.DeleteCatalogItem(_id);

                FillCatalog(ArticleId);
            }
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            BLL.CatId = _id;
        }

        private void cmb_Articles1_ArticleChanged(object sender)
        {
            ArticleId = cmb_Articles1.ArticleId;
        }
    }
}

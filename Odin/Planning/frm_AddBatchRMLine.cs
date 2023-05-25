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
using ComponentFactory.Krypton.Ribbon;
using Odin.Global_Classes;
using System.Data.SqlClient;

namespace Odin.Planning
{
    public partial class frm_AddBatchRMLine : KryptonForm
    {
        public frm_AddBatchRMLine()
        {
            InitializeComponent();
        }

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        class_Global glob_Class = new class_Global();
        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }
        public int BatchDetId
        { get; set; }
        public int Id
        { get; set; }
        public int ArtId
        {
            get { return cmb_Articles1.ArticleId; }
            set { cmb_Articles1.ArticleId = value; }
        }
        public string Article
        {
            get
            {
                return cmb_Articles1.Article;
            }
            set { }
        }
        public string Unit
        {
            get { return txt_Unit.Text; }
            set { txt_Unit.Text = value; }
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


        public double QtyStock
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyStock.Text); }
                catch { return 0; }
            }
            set { txt_QtyStock.Text = value.ToString(); }
        }
        public double QtyAvailable
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyAvailable.Text); }
                catch { return 0; }
            }
            set { txt_QtyAvailable.Text = value.ToString(); }
        }
        public double WaitingPO
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyPO.Text); }
                catch { return 0; }
            }
            set { txt_QtyPO.Text = value.ToString(); }
        }
        
        public int SubBatch
        {
            get
            {
                if (chk_SubBatch.CheckState == CheckState.Checked)
                    return -1;
                else
                    return 0;
            }
            set
            {
                if (value == -1)
                    chk_SubBatch.CheckState = CheckState.Checked;
                else
                    chk_SubBatch.CheckState = CheckState.Unchecked;
            }
        }

        public int IsActive
        {
            get
            {
                if (chk_Active.CheckState == CheckState.Checked)
                    return -1;
                else
                    return 0;
            }
            set
            {
                if (value == -1)
                    chk_Active.CheckState = CheckState.Checked;
                else
                    chk_Active.CheckState = CheckState.Unchecked;
            }
        }

        public int DNP
        {
            get
            {
                if (chk_dnp.CheckState == CheckState.Checked)
                    return -1;
                else
                    return 0;
            }
            set
            {
                if (value == -1)
                    chk_dnp.CheckState = CheckState.Checked;
                else
                    chk_dnp.CheckState = CheckState.Unchecked;
            }
        }

        public string Stage
        {
            get { return txt_Stage.Text; }
            set { txt_Stage.Text = value;}

        }

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }

        }

        public string DelivDate
        {
            get { return txt_DelivDate.Text; }
            set { txt_DelivDate.Text = value; }

        }

        public string POrder
        {
            get { return txt_POrder.Text; }
            set { txt_POrder.Text = value; }

        }
        public string Supplier
        {
            get { return txt_Supplier.Text; }
            set { txt_Supplier.Text = value; }

        }
        private void cmb_Articles1_ArticleChanged(object sender)
        {
            Unit = cmb_Articles1.Unit;
            Stage = cmb_Articles1.Stage;
            SelectAvailable(cmb_Articles1.ArticleId);
            CheckEmpty();
        }

        private void txt_Qty_Validated(object sender, EventArgs e)
        {
            if (glob_Class.NES(txt_Qty.Text) == "")
                Qty = 0;
            CheckEmpty();
        }
        public void CheckEmpty()
        {
            if ((BatchDetId == 0 && Qty == 0)
                || ArtId == 0)
                btn_OK.Enabled = false;
            else
                btn_OK.Enabled = true;

        }

        private void txt_Qty_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }

        public void DisableFields()
        {
            txt_Qty.Enabled = false;
            chk_SubBatch.Enabled = false;
        }

        public void DisableArticle()
        { cmb_Articles1.Enabled = false; }

        public void SelectAvailable(int ArtId)
        {
            SqlConnection conn = new SqlConnection(sConnStr);
            conn.Open();
            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                new SqlDataAdapter(
                    "execute sp_SelectArticleAvail @artid = " + ArtId, conn);


            conn.Close();

            adapter.Fill(ds);

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                   
                    QtyStock = Convert.ToDouble(dr["QtyOnStock"]);
                    QtyAvailable = Convert.ToDouble(dr["QtyAvailable"]);
                    WaitingPO = Convert.ToDouble(dr["WaitingPOQty"]);
                    DelivDate = dr["WaitingPODate"].ToString();
                    POrder = dr["POrder"].ToString();
                    Supplier = dr["Supplier"].ToString();
                }
            }
            else
            {
                QtyStock = 0;
                QtyAvailable = 0;
                WaitingPO = 0;
                DelivDate = "";
                POrder = "";
                Supplier = "";
            }
        }

        private void frm_AddBatchRMLine_Load(object sender, EventArgs e)
        {
            CheckEmpty();
        }
    }
}

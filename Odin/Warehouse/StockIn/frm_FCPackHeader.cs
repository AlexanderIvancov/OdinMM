using ComponentFactory.Krypton.Toolkit;
using Odin.CustomControls;
using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Odin.Warehouse.StockIn
{
    public delegate void DisplayKeyboardSymbolEventHandler(string symbol, bool symremove);

    public partial class frm_FCPackHeader : KryptonForm
    {
        public frm_FCPackHeader()
        {
            InitializeComponent();
            NumericCheckHandler = new KeyPressEventHandler(NumericCheck);
            PopupHelper = new PopupWindowHelper();
        }

        private static KeyPressEventHandler NumericCheckHandler;
        frm_ScreenNumKeyboard popup;
        PopupWindowHelper PopupHelper = null;
        TextBox focusedtextbox;

        public int Id
        { get; set; }

        public int BatchId
        {
            get { return cmb_BatchPDA1.BatchId; }
            set { cmb_BatchPDA1.BatchId = value; }
        }

        public string Batch
        {
            get { return cmb_BatchPDA1.Batch; }
            set { cmb_BatchPDA1.Batch = value; }
        }

        public string Package
        {
            get { return cmb_PackagesPDA1.Package; }
            set { cmb_PackagesPDA1.Package = value; }
        }

        public string Article
        {
            get { return txt_Article.Text; }
            set { txt_Article.Text = value; }
        }

        public string Unit
        {
            get { return txt_Unit.Text; }
            set { txt_Unit.Text = value; }
        }

        public int ArtId
        { get; set; }

        public double Qty
        {
            get
            {
                try { return Convert.ToDouble(txt_Qty.Text); }
                catch { return 0; }
            }
            set { txt_Qty.Text = value.ToString(); }
        }

        public int BoxNO
        {
            get
            {
                try { return Convert.ToInt32(txt_BoxNO.Text); }
                catch { return 0; }
            }
            set { txt_BoxNO.Text = value.ToString(); }
        }

        public double WeightBrut
        {
            get
            {
                try
                {
                    var data = Helper.QueryDT("SELECT DISTINCT TOP 1 Weight FROM BAS_Articles WHERE ID = '" + ArtId.ToString() + "'");

                    double netw;
                    try
                    {
                        netw = Convert.ToDouble(data.Rows[0]["Weight"].ToString());
                    }
                    catch
                    {
                        MessageBox.Show("Error!"); return 0;
                    }
                    if (netw*Qty > Convert.ToDouble(txt_Weight.Text)) { MessageBox.Show("Error! Weight brutto of box is less than netto!"); return 0; }
                    else return Convert.ToDouble(txt_Weight.Text);
                }
                catch { return 0; }
            }
            set { txt_Weight.Text = value.ToString(); }
        }

        public int COId
        {
            get;set;
        }
        private float _measCellValue;
        public float MeasCellValue
        {
            get { return _measCellValue; }
            set { _measCellValue = value; }
        }

        public int IsClosed
        {
            get {
                return chk_Closed.Checked == true ? -1 : 0;
            }
            set
            {
                chk_Closed.Checked = value == -1;
            }
        }
        #region Controls
        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            Package = string.Empty;
            CheckEmpty();
        }

        public void CheckEmpty()
        {
            btn_OK.Enabled = BatchId != 0
                && ArtId != 0
                && Package != ""
                && String.IsNullOrEmpty(Package) != true
                && Qty > 0;
        }

        private void txt_Package_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }

        public void Mode(int mode)
        {
            if (mode == 1) //Serials
            {
                cmb_BatchPDA1.Enabled = false;
                txt_Qty.Enabled = false;

            }
            else if (mode == 0) //Batch
            {
                cmb_BatchPDA1.Enabled = true;
                txt_Qty.Enabled = true;
            }
            else //Edit 
            {
                cmb_BatchPDA1.Enabled = false;
                txt_Article.Enabled = false;
                //txt_Qty.Enabled = false;
            }
        }

        private void cmb_BatchPDA1_BatchChanged(object sender)
        {
            ArtId = cmb_BatchPDA1.ArticleId;
            Article = cmb_BatchPDA1.Article;
            Unit = cmb_BatchPDA1.Unit;
            //COId = cmb_BatchPDA1.CountID > 1 ? 0 : cmb_BatchPDA1.COId;
            COId = cmb_BatchPDA1.COId;
            CheckEmpty();
        }

        private void txt_Qty_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(txt_Qty.Text);
            CheckEmpty();
            try
            {
                popup.CellText = txt_Qty.Text.ToString();
                txt_Qty.SelectionStart = txt_Qty.Text.Length;
            }
            catch { }
            //Qty = Convert.ToDouble(txt_Qty.Text);
        }

        private void txt_Weight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // WeightBrut = Convert.ToDouble(txt_Weight.Text);
                popup.CellText = txt_Weight.Text.ToString();
                txt_Weight.SelectionStart = txt_Weight.Text.Length;
            }
            catch { }
            
        }

        private void insertKeyboardSymbol(string symbol, bool symremove)
        {
            if (symremove)
            {
                //dataGridView1.CurrentRow.Cells["cn_value"].Value = symbol;
                focusedtextbox.Text = symbol;
            }
            else
            {
                //dataGridView1.CurrentRow.Cells["cn_value"].Value += symbol;
                focusedtextbox.Text += symbol;
            }
        }

        private static void NumericCheck(object sender, KeyPressEventArgs e)
        {
            TextBox s = sender as TextBox;
            if (s != null && (e.KeyChar == '.' || e.KeyChar == ','))
            {
                e.KeyChar = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
                e.Handled = s.Text.Contains(e.KeyChar);
            }
            else
            {
                e.Handled = e.KeyChar == '-' ? s.Text.Contains(e.KeyChar) : !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
            }
        }

        private void ShowScreenNumKeyboard(TextBox _focusedtextbox)
        {
            //MessageBox.Show(focusedtextbox.Name);
            //focusedtextbox.Focus();
            popup = new frm_ScreenNumKeyboard();
            popup.DisplayKeyboardSymbol += new CustomControls.DisplayKeyboardSymbolEventHandler(insertKeyboardSymbol);
            //popup.frm_MainOne = this;

            Form f;
            f = this.FindForm();
            
            Point LocationPoint = _focusedtextbox.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X + _focusedtextbox.Width;
            int ypos = LocationPoint.Y;
            Point _location = new Point(xpos, ypos);

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);
        }

        private void txt_Qty_Enter(object sender, EventArgs e)
        {
            focusedtextbox = txt_Qty;
            txt_Qty.ThreadSafeCall(delegate
            {
                ShowScreenNumKeyboard(txt_Qty);
            });
            popup.CellText = txt_Qty.Text.ToString();
        }

        private void txt_Weight_Enter(object sender, EventArgs e)
        {
            focusedtextbox = txt_Weight;
            txt_Weight.ThreadSafeCall(delegate { ShowScreenNumKeyboard(txt_Weight); });
            popup.CellText = txt_Weight.Text.ToString();
        }

        public int ProdPlace
        {
            get
            {
                return rb_Valkas2.Checked == true ? 1 : rb_Valkas2B.Checked == true ? 2 : 0;

            }
            set
            {
                if (value == 1)
                {
                    rb_Valkas2.Checked = true;
                    rb_Valkas2B.Checked = false;
                }
                else if (value == 2)
                {
                    rb_Valkas2.Checked = false;
                    rb_Valkas2B.Checked = true;
                }
                else
                {
                    rb_Valkas2.Checked = false;
                    rb_Valkas2B.Checked = false;
                }
            
            }
        }

        #endregion

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_FCPackHeader_Load(object sender, EventArgs e)
        {            
            //txt_Qty.KeyPress += NumericCheckHandler;
            //txt_Weight.KeyPress += NumericCheckHandler;
        }

        private void txt_Qty_Leave(object sender, EventArgs e)
        {
           // Qty = Convert.ToDouble(txt_Qty.Text);
        }

        private void txt_Weight_Leave(object sender, EventArgs e)
        {
            //WeightBrut = Convert.ToDouble(txt_Weight.Text);
        }

        private void cmb_PackagesPDA1_PackagesChanged(object sender)
        {
            CheckEmpty();
        }

        private void txt_BoxNO_Enter(object sender, EventArgs e)
        {
            focusedtextbox = txt_BoxNO;
            txt_BoxNO.ThreadSafeCall(delegate { ShowScreenNumKeyboard(txt_BoxNO); });
            popup.CellText = txt_BoxNO.Text.ToString();
        }

        private void txt_BoxNO_TextChanged(object sender, EventArgs e)
        {
            try { 
            popup.CellText = txt_BoxNO.Text.ToString();
                if (BoxNO <= Convert.ToInt32(Helper.GetOneRecord(@"SELECT TOP 1[boxno]
                                                          FROM[OdinDB].[dbo].[STO_Package] where id in (SELECT[packid]
                                                          FROM[OdinDB].[dbo].[STO_DelivPackMapping] where batchid = " + BatchId + ") ORDER BY[boxno] DESC" )))
                {
                    txt_BoxNO.BackColor = Color.Gold;
                    MessageBox.Show("Error! Check Box No");
                }
                else
                {
                    txt_BoxNO.BackColor = Color.White;
                    txt_BoxNO.Enabled = true;
                }
                txt_BoxNO.SelectionStart = txt_BoxNO.Text.Length;
            }
            catch { }
        }

        private void btn_scan_Click(object sender, EventArgs e)
        {
            frm_cmbTextPDA frm = new frm_cmbTextPDA();
            frm.HeaderText = "Scan serial number";
            frm.LabelText = "Serial:";
            frm.txt_Text.Focus();

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK
                && frm.FormText != "")
            {
                string _batchtry = "L" + frm.FormText.Substring(0, frm.FormText.IndexOf("-") < 0 ? 0 : frm.FormText.IndexOf("-")).ToString();
                int _batchid = 0;
                _batchid = Convert.ToInt32(Helper.GetOneRecord("select top 1 batchid from prod_serialtracing where serial = '" + frm.FormText + "' and stageid = 7"));
                _batchid = _batchid == 0 ? Convert.ToInt32(Helper.GetOneRecord("select top 1 id from prod_batchhead where Batch = '" + _batchtry + "'")) : _batchid;

                BatchId = _batchid;
            }
        }
    }
}

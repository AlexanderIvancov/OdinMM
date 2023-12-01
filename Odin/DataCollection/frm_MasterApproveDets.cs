using ComponentFactory.Krypton.Toolkit;
using Odin.CustomControls;
using Odin.Global_Classes;
using Odin.Tools;
using Odin.Workshop;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Odin.DataCollection
{
    public delegate void DisplayKeyboardSymbolEventHandlerDet(string symbol, bool symremove);
    public delegate void ApplyApprovingChangesEventHandler(object sender);
    public partial class frm_MasterApproveDets : Form
    {
        public frm_MasterApproveDets()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
            NumericCheckHandler = new KeyPressEventHandler(NumericCheck);
            this.gv_List.EditingControlShowing +=
                new DataGridViewEditingControlShowingEventHandler(gv_List_EditingControlShowing);
        }

        #region Variables

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        public int ReadValue = 0;
        public string Result = "";

        class_Global globClass = new class_Global();
        AdmMenu mMenu = new AdmMenu();
        DAL_Functions DAL = new DAL_Functions();
        DC_BLL DCBll = new DC_BLL();
        Processing_BLL PBLL = new Processing_BLL();

        private static KeyPressEventHandler NumericCheckHandler;
        public event ApplyApprovingChangesEventHandler ApplyApproveChanges;

        PopupWindowHelper PopupHelper = null;
        frm_ScreenNumKeyboard popup;
        TextBox focusedtextbox;

        int _masterid = 0;
        int _prevstageid = 0;
        public int PrevStageId
        {
            get { return _prevstageid; }
            set { _prevstageid = value; }
        }

        int _launchid = 0;

        public int LaunchId
        {
            get { return _launchid; }
            set { _launchid = value; }
        }
     

        public double Qty
        {
            get { return Convert.ToDouble(txt_Qty.Text); }
            set { txt_Qty.Text = value.ToString(); }
        }

        public double QtyStarted
        {
            get;
            set;
        }

        public int MasterId
        {
            get { return _masterid; }
            set { _masterid = value; }
        }
        int _stateid = 0;
        /*
        0 - Available
        1 - At work
        2 - Paused             
        */
        public int StateId
        {
            get { return _stateid; }
            set { _stateid = value; }
        }
        public int NextStageId
        { get; set; }

        public string PrevStage
        { get; set; }

        public int AllowMoveBack
        { get; set; }

        public int IsNextStageLast
        { get; set; }

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

        public int StageId
        {
            get; set;
        }

        public double Freezed
        {
            get; set;
        }
        public double OldFreezed
        { get; set; }

        #endregion

        #region Methods

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_isapproved"].Value) == -1)
                    row.DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192);
            }
        }
        public void FillList(int launchid, int prodplace)
        {
            var data = DC_BLL.getSerialNumbersNotApproved(LaunchId, prodplace);


            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;


                foreach (DataGridViewRow row in this.gv_List.Rows)
                {
                    row.Cells["cn_toapprove"].Value = Convert.ToDouble(row.Cells["cn_qty"].Value);
                }


                SetCellsColor();
            });

            RecalcQty();
           
        }

        public void RecalcQty()
        {
            gv_List.EndEdit();
            double _qty = 0;

            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["chk_check"].Value) == -1)
                    try
                    {
                        _qty = _qty + Convert.ToDouble(row.Cells["cn_toapprove"].Value);
                    }
                    catch { _qty = _qty + 0; }
            }
            Qty = _qty;
        }

        private void insertKeyboardSymbol(string symbol, bool symremove)
        {
            if (symremove)
            {
                //dataGridView1.CurrentRow.Cells["cn_value"].Value = symbol;
                gv_List.CurrentCell.Value = symbol;
            }
            else
            {
                //dataGridView1.CurrentRow.Cells["cn_value"].Value += symbol;
                if (Convert.ToDouble(gv_List.CurrentCell.Value + symbol) <= Convert.ToDouble(gv_List.CurrentRow.Cells["cn_qty"].Value))
                    gv_List.CurrentCell.Value += symbol;
            }
            RecalcQty();
        }

        private void NumericCheck(object sender, KeyPressEventArgs e)
        {
            DataGridViewTextBoxEditingControl s = sender as DataGridViewTextBoxEditingControl;
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

        private void gv_List_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gv_List.CurrentCell.ColumnIndex == 8)
            {
                e.Control.KeyPress -= NumericCheckHandler;
                e.Control.KeyPress += NumericCheckHandler;
            }
            else
            {
                e.Control.KeyPress -= NumericCheckHandler;
            }
        }

        private float _measCellValue;
        public float MeasCellValue
        {
            get { return _measCellValue; }
            set { _measCellValue = value; }
        }

        private void ShowScreenNumKeyboard(DataGridViewCellEventArgs e, int columnIndex, int rowIndex)
        {
            string columnName = gv_List.Columns["cn_toapprove"].Name;

            //int rowHeight = dataGridView1.Rows[e.RowIndex].Height;
            int columnWidth = gv_List.Columns[columnName].Width;

            int ColumnIndex = columnIndex != -1 ? columnIndex : e.ColumnIndex;
            int RowIndex = rowIndex != -1 ? rowIndex : e.RowIndex;

            Rectangle cellRectangle = gv_List.GetCellDisplayRectangle(ColumnIndex, RowIndex, false);

            cellRectangle.X += gv_List.Left + columnWidth;
            cellRectangle.Y += gv_List.Top - 20;

            Point displayPoint = PointToScreen(new Point(cellRectangle.X, cellRectangle.Y));

            popup = new frm_ScreenNumKeyboard();
            popup.DisplayKeyboardSymbol += new CustomControls.DisplayKeyboardSymbolEventHandler(insertKeyboardSymbol);
            //popup.frm_MainOne = this;

            Form f;
            f = this.FindForm();

            PopupHelper.ShowPopup(f, popup, displayPoint);
        }

        #endregion

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            
            int _id = 0;
            int _issn = 0;
            
            if (globClass.DeleteConfirm() == true)
            {
                if (MasterId != 0)
                {
                    foreach (DataGridViewRow row in this.gv_List.SelectedRows)
                    {
                        try
                        {
                            _id = Convert.ToInt32(row.Cells["cn_id"].Value);
                            _issn = Convert.ToInt32(row.Cells["cn_issn"].Value);
                        }
                        catch { _id = 0;}
                        if (_id != 0)
                        {
                            DCBll.DeleteDataCollection(_id, _issn);
                        }
                    }                    
                    FillList(LaunchId, ProdPlace);
                    ApplyApproveChanges?.Invoke(this);
                }
                else
                {
                    System.Media.SystemSounds.Exclamation.Play();
                    frm_Error frm1 = new frm_Error();
                    frm1.HeaderText = "Select master!";
                    DialogResult result1 = frm1.ShowDialog();
                }
            }
        }

        private void btn_Approve_Click(object sender, EventArgs e)
        {
            gv_List.EndEdit();

            if (MasterId != 0
                && LaunchId != 0)
            {
                if (Qty <= QtyStarted)
                {
                    //Save info
                    DataTable data = new DataTable();
                    data.Columns.Add("id", typeof(int));
                    data.Columns.Add("issn", typeof(int));
                    data.Columns.Add("qty", typeof(double));

                    foreach (DataGridViewRow row in this.gv_List.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["chk_check"].Value) == -1
                            && Convert.ToDouble(row.Cells["cn_toapprove"].Value) > 0)
                        {
                            DataRow drser = data.NewRow();
                            drser["id"] = Convert.ToInt32(row.Cells["cn_id"].Value);
                            drser["issn"] = Convert.ToInt32(row.Cells["cn_issn"].Value);
                            drser["qty"] = Convert.ToDouble(row.Cells["cn_toapprove"].Value);
                            data.Rows.Add(drser);
                        }
                    }

                    double _qty = 0;

                    _qty = DCBll.ApproveDataCollection(data, MasterId);

                    if (_qty > 0 || Freezed != OldFreezed)
                    {
                        //MessageBox.Show("Save launch");
                        int _res = PBLL.SaveLaunchStageProcess(LaunchId,
                            PrevStageId, StageId, NextStageId,
                            0,
                            _qty,
                            Freezed,
                            IsNextStageLast == -1 ? 0 : ProdPlace);
                    }

                    DialogResult result = KryptonTaskDialog.Show("Approving of info was successful!",
                                                                    "Approving of info was successful!",
                                                                    "",
                                                                    MessageBoxIcon.Information,
                                                                    TaskDialogButtons.OK);

                    ApplyApproveChanges?.Invoke(this);
                    this.Close();

                }
                else
                {
                    System.Media.SystemSounds.Exclamation.Play();
                    frm_Error frm1 = new frm_Error();
                    frm1.HeaderText = "Started qty less than you want to approve!";
                    DialogResult result1 = frm1.ShowDialog();
                }
            }
            else
            {
                System.Media.SystemSounds.Exclamation.Play();
                frm_Error frm1 = new frm_Error();
                frm1.HeaderText = "Please check Master and Launch!";
                DialogResult result1 = frm1.ShowDialog();
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            //if (ApplyApproveChanges != null)
            //    ApplyApproveChanges(this);
            this.Close();
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            gv_List.ThreadSafeCall(delegate
            {

                foreach (DataGridViewRow row in this.gv_List.Rows)
                {
                    row.Cells["cn_toapprove"].Value = Convert.ToDouble(row.Cells["cn_qty"].Value);
                }


                SetCellsColor();

                RecalcQty();

            });
        }

        private void gv_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gv_List.EndEdit();
            if (gv_List.CurrentRow.Cells["chk_check"].Selected == true)
            {
                RecalcQty();
            }
        }

        private void gv_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 8
                    && Convert.ToInt32(gv_List.CurrentRow.Cells["cn_issn"].Value) == 0)
                {
                    //MessageBox.Show(gv_List.CurrentCell.OwningColumn.Name);
                    ShowScreenNumKeyboard(e, -1, -1);
                    popup.CellText = gv_List.CurrentRow.Cells["cn_toapprove"].FormattedValue.ToString();
                }
            }
        }

        private void gv_List_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                if (Convert.ToInt32(gv_List.CurrentRow.Cells["cn_issn"].Value) == -1)
                    gv_List.CurrentRow.Cells["cn_toapprove"].Value = 1;
                else
                {
                    if (gv_List.CurrentCell.Value != null &&
                        gv_List.CurrentCell.Value.ToString() == "-")
                    {
                        gv_List.CurrentCell.Value = null;
                    }

                    var cellValue = gv_List.CurrentCell.Value;
                    if (cellValue != null)
                    {

                        if (gv_List.Rows[e.RowIndex].Cells["cn_toapprove"].Value.ToString() != "")
                        {
                            MeasCellValue = float.Parse(gv_List.Rows[e.RowIndex].Cells["cn_toapprove"].Value.ToString());
                        }

                    }
                }
            }
        }

        private void gv_List_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gv_List.CurrentRow != null)
                {
                    popup.CellText = gv_List.CurrentRow.Cells["cn_toapprove"].Value.ToString();
                }
            }
            catch { }
        }

        private void frm_MasterApproveDets_Load(object sender, EventArgs e)
        {
            //FillList(LaunchId);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Odin.Global_Classes;
using Odin.Tools;
using Odin.CustomControls;
using System.Drawing;
using ComponentFactory.Krypton.Toolkit;

namespace Odin.DataCollection
{
    public partial class frm_RepairCardFin : BaseForm
    {
        private const int PageSize = 4;
        private int _currentPage = 0;
        private DataTable _dtCardsAll = new DataTable();
        private readonly List<uc_RepairCardItem> _cardSlots = new List<uc_RepairCardItem>();
        frm_ScreenNumKeyboard popup;
        PopupWindowHelper PopupHelper = new PopupWindowHelper();
        KryptonTextBox focusedtextbox;
        private int _selectedCardId = 0;
        private uc_RepairCardItem _selectedSlot = null;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        private DC_BLL DCBll = new DC_BLL();
        private DAL_Functions DAL = new DAL_Functions();
        private class_Global GLOB = new class_Global();
        private PrinterLabels PrintLabels = new PrinterLabels();
        private RepairCard RC = new RepairCard();
        public Main _frm_Main;

        public void FillPlace()
        {
            int _id = 0;
            try
            {
                _id = Convert.ToInt32(Helper.GetOneRecord("select placeid from SYS_PCPlaces where pcname = '" + System.Environment.MachineName + "'"));
            }
            catch { }
        }

        public string Worker
        {
            get { return txt_Worker.Text; }
            set
            {
                txt_Worker.Text = value;
            }
        }
        public int WorkerId { get; set; }

        public frm_RepairCardFin()
        {
            InitializeComponent();
            InitCardGridSlots();
        }

        private void InitCardGridSlots()
        {
            layoutCards.SuspendLayout();
            layoutCards.Controls.Clear();
            _cardSlots.Clear();

            for (int r = 0; r < 2; r++)
            {
                for (int c = 0; c < 2; c++) // 2 колонки
                {
                    var slot = new uc_RepairCardItem
                    {
                        Dock = DockStyle.Fill
                    };

                    slot.CardSelected += Slot_CardSelected;

                    // Подписываемся на возврат фокуса:
                    slot.NeedScannerFocus += (s, ev) =>
                    {
                        this.BeginInvoke(new Action(() =>
                        {
                            txt_Oper.Focus();
                            txt_Oper.SelectAll();
                        }));
                    };

                    layoutCards.Controls.Add(slot, c, r);
                    _cardSlots.Add(slot);
                }
            }
            layoutCards.ResumeLayout(true);
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (!txt_Oper.Focused && !char.IsControl(e.KeyChar))
            {
                txt_Oper.Focus();
                txt_Oper.AppendText(e.KeyChar.ToString());
                e.Handled = true;
            }
        }

        private void frm_RepairCardFin_Load(object sender, EventArgs e)
        {
            LoadData(-1);
            txt_Oper.Focus();
        }

        private void insertKeyboardSymbol(string symbol, bool symremove)
        {
            if (focusedtextbox == null) return;

            if (symremove)
            {
                focusedtextbox.Text = symbol;
            }
            else
            {
                focusedtextbox.Text += symbol;
            }

            focusedtextbox.SelectionStart = focusedtextbox.Text.Length;

            if (popup != null && !popup.IsDisposed)
                popup.CellText = focusedtextbox.Text;
        }
        private void ShowScreenNumKeyboard(KryptonTextBox _focusedtextbox)
        {
            popup = new frm_ScreenNumKeyboard();
            popup.RepairCardMode = true;
            popup.DisplayKeyboardSymbol += new CustomControls.DisplayKeyboardSymbolEventHandler(insertKeyboardSymbol);
            popup.FormClosing += new FormClosingEventHandler(popup_FormClosing);

            popup.CellText = _focusedtextbox.Text;

            var wa = Screen.FromControl(this).WorkingArea;
            int x = wa.Left + (wa.Width - popup.Width) / 2;
            int y = wa.Top + (wa.Height - popup.Height) / 2;
            Point _location = new Point(x, y);

            PopupHelper.ClosePopup();
            PopupHelper.ShowPopup(this, popup, _location);
        }

        private void popup_FormClosing(object sender, FormClosingEventArgs e)
        {
            txt_Oper.Focus();
            txt_Oper.SelectAll();
            if (focusedtextbox == txt_Oper)
            {
                BeginInvoke(new Action(() =>
                {
                    txt_Oper_KeyPress(
                        txt_Oper,
                        new KeyPressEventArgs((char)Keys.Enter)
                    );
                }));
            }
        }
        public void LoadData(int stateId, int targetCardId = 0)
        {
            var data = DC_BLL.getRepairCards(stateId);
            _dtCardsAll = data ?? new DataTable();

            if (targetCardId != 0)
            {
                _selectedCardId = targetCardId;
                RC.Id = targetCardId;

                // Ищем, на какой позиции в таблице оказалась новая карта:
                int targetIndex = -1;
                for (int i = 0; i < _dtCardsAll.Rows.Count; i++)
                {
                    if (Convert.ToInt32(_dtCardsAll.Rows[i]["id"]) == targetCardId)
                    {
                        targetIndex = i;
                        break;
                    }
                }

                // Если нашли — вычисляем её страницу (0, 1, 2...):
                if (targetIndex != -1)
                {
                    _currentPage = targetIndex / PageSize;
                }
                else
                {
                    _currentPage = 0;
                }
            }
            else
            {
                _currentPage = 0;
            }

            RenderCurrentPage();
        }

        private void ResetSelection()
        {
            _selectedCardId = 0;
            _selectedSlot = null;
            RC.Id = 0;

            foreach (var slot in _cardSlots)
            {
                slot.IsSelected = false;
            }
        }

        private void RenderCurrentPage()
        {
            int totalCards = _dtCardsAll.Rows.Count;
            int totalPages = (int)Math.Ceiling((double)totalCards / PageSize);
            if (totalPages == 0) totalPages = 1;

            if (_currentPage >= totalPages) _currentPage = totalPages - 1;
            if (_currentPage < 0) _currentPage = 0;

            lbl_PageInfo.Text = $"Page {_currentPage + 1} from {totalPages} ({totalCards})";
            btn_PrevPage.Enabled = _currentPage > 0;
            btn_NextPage.Enabled = _currentPage < totalPages - 1;

            int startIndex = _currentPage * PageSize;

            for (int i = 0; i < PageSize; i++)
            {
                int dataIndex = startIndex + i;
                var slot = _cardSlots[i];

                if (dataIndex < totalCards)
                {
                    DataRow row = _dtCardsAll.Rows[dataIndex];
                    int headId = Convert.ToInt32(row["id"]);

                    // Подгружаем детали и материалы для этой карточки
                    DataTable dtDets = DC_BLL.getRepairCardsDets(headId);
                    DataTable dtMats = DC_BLL.getRepairCardsMaterials(headId);

                    slot.BindData(row, dtDets, dtMats);
                    slot.IsSelected = (headId == _selectedCardId);
                    if (slot.IsSelected) _selectedSlot = slot;
                }
                else
                {
                    slot.BindData(null, null, null);
                }
            }
        }

        private void Slot_CardSelected(object sender, int cardId)
        {
            _selectedCardId = cardId;
            RC.Id = cardId;

            foreach (var slot in _cardSlots)
            {
                slot.IsSelected = (slot.CardId == cardId && slot.CardId != 0);
                if (slot.IsSelected) _selectedSlot = slot;
            }

            txt_Oper.Focus();
        }

        private void btn_PrevPage_Click(object sender, EventArgs e)
        {
            if (_currentPage > 0)
            {
                ResetSelection(); // Сбрасываем выбор перед переходом

                _currentPage--;
                RenderCurrentPage();
            }
            txt_Oper.Focus();
        }

        private void btn_NextPage_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)_dtCardsAll.Rows.Count / PageSize);
            if (_currentPage < totalPages - 1)
            {
                ResetSelection(); // Сбрасываем выбор перед переходом

                _currentPage++;
                RenderCurrentPage();
            }
            txt_Oper.Focus();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            ResetSelection(); // Сбрасываем выбор перед переходом

            LoadData(-1);
            txt_Oper.Focus();
        }


        #region Actions Logic (Подключено к активной карточке)

        private void btn_Create_Click(object sender, EventArgs e)
        {
            frm_AddRepairCard frm = new frm_AddRepairCard();
            frm.Serial = "";
            frm.SetFocus();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (CheckWorker())
                {
                    int resHead = DCBll.SaveRepairCardHead(0, frm.Serial, frm.Analog, frm.BatchId, -1, "", "", Worker);
                    DCBll.SaveRepairCardDets(0, resHead, frm.Defect, "", "", -99, "", "", 0, Worker, "");

                    // ПЕРЕДАЕМ ID СОЗДАННОЙ КАРТЫ:
                    LoadData(-1, resHead);

                    // (Здесь далее идет печать этикетки, если она нужна)
                    frm_Print frmp = new frm_Print();
                    frmp.cmb_LabPrinter1.ShowDefaults();
                    DialogResult resultp = frmp.ShowDialog();

                    if (resultp == DialogResult.OK)
                    {
                        PrintLabels.PrinterIp = frmp.IP_Address;
                        PrintLabels.PrinterDPI = frmp.Printer_DPI;

                        var sqlparamsfields = new List<SqlParameter>()
                        {
                            new SqlParameter("@id",SqlDbType.Int) {Value = resHead},
                            new SqlParameter("@labelqty",SqlDbType.Int) {Value = frmp.LabelQty}
                        };

                        if (frmp.LabelQty != 0)
                            PrintLabels.PrintLabel(PrintLabels.LabelConstructor(15, "sp_SelectRepairCardHeadPrint", sqlparamsfields.ToArray()), 1);
                        else
                            MessageBox.Show("Qty of label = 0! Printing impossible!");
                    }
                    else
                    { }
                }
            }
            txt_Oper.Focus();
        }

        private void btn_Actions_Click(object sender, EventArgs e)
        {
            if (_selectedSlot == null || _selectedCardId == 0)
            {
                ShowError("Select the card! (press on it)!");
                return;
            }

            int detId = _selectedSlot.GetSelectedDetailId();
            if (detId == 0)
            {
                ShowError("Select the defect!");
                return;
            }

            if (string.IsNullOrEmpty(Worker)) CheckWorker();
            if (!string.IsNullOrEmpty(Worker))
            {

                frm_AddRepairCardDet frm = new frm_AddRepairCardDet { FormMode = 0, Worker = Worker, HeadId = RC.Id };
                frm.SetFocus();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    DCBll.SaveRepairCardDets(detId, RC.Id, "", frm.FormText, "", -99, "", "", 0, Worker, "");
                    SaveScannedMaterials(frm);
                    RenderCurrentPage();
                }
            }
            txt_Oper.Focus();
        }

        private void btn_Repair_Click(object sender, EventArgs e)
        {
            if (_selectedSlot == null || _selectedCardId == 0)
            {
                ShowError("Select the card! (press on it)!");
                return;
            }

            int detId = _selectedSlot.GetSelectedDetailId();
            if (detId == 0)
            {
                ShowError("Select the defect/action!");
                return;
            }

            if (string.IsNullOrEmpty(Worker)) CheckWorker();
            if (!string.IsNullOrEmpty(Worker))
            {

                frm_AddRepairCardDet frm = new frm_AddRepairCardDet { FormMode = 1, Worker = Worker, HeadId = RC.Id };
                frm.SetFocus();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    DCBll.SaveRepairCardDets(detId, RC.Id, "", "", Worker, -99, "", frm.FormText, frm.WorkTime, "", "");
                    SaveScannedMaterials(frm);
                    RenderCurrentPage();
                }
            }

            txt_Oper.Focus();
        }

        private void btn_Approve_Click(object sender, EventArgs e)
        {
            if (_selectedSlot == null || _selectedCardId == 0) return;
            int detId = _selectedSlot.GetSelectedDetailId();
            if (detId != 0 && CheckWorker())
            {
                DCBll.SaveRepairCardDets(detId, RC.Id, "", "", "", -1, Worker, "", 0, Worker, "");
                RenderCurrentPage();
            }
            txt_Oper.Focus();
        }

        private void btn_Deny_Click(object sender, EventArgs e)
        {
            if (_selectedSlot == null || _selectedCardId == 0) return;
            int detId = _selectedSlot.GetSelectedDetailId();
            if (detId == 0) return;

            if (string.IsNullOrEmpty(Worker)) CheckWorker();
            if (!string.IsNullOrEmpty(Worker))
            {
                frm_AddRepairCardDet frm = new frm_AddRepairCardDet { FormMode = -1, Worker = Worker, HeadId = RC.Id };
                frm.SetFocus();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    DCBll.SaveRepairCardDets(detId, RC.Id, "", "", Worker, 0, "", frm.FormText, frm.WorkTime, Worker, "");
                    DCBll.SaveRepairCardDets(0, RC.Id, frm.FormText, "", "", -99, "", "", 0, Worker, "");
                    SaveScannedMaterials(frm);
                    RenderCurrentPage();
                }
            }
            txt_Oper.Focus();
        }

        private void btn_CloseCard_Click(object sender, EventArgs e)
        {
            if (_selectedCardId == 0 || RC.StateId == 0)
            {
                ShowError("Card is not selected or closed!");
                return;
            }
            if (string.IsNullOrEmpty(Worker)) CheckWorker();
            if (!string.IsNullOrEmpty(Worker))
            {
                frm_AddRepairCardDet frm = new frm_AddRepairCardDet { FormMode = 2, Worker = Worker, HeadId = RC.Id };
                frm.SetFocus();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    DCBll.SaveRepairCardHead(_selectedCardId, "", "", 0, 0, frm.FormText, "", Worker);
                    SaveScannedMaterials(frm);
                    LoadData(-1);
                }
            }
            txt_Oper.Focus();
        }

        private void btn_AddCard_Click(object sender, EventArgs e)
        {
            if (_selectedCardId == 0)
            {
                ShowError("Select the card!!");
                return;
            }
            if (string.IsNullOrEmpty(Worker)) CheckWorker();
            if (!string.IsNullOrEmpty(Worker))
            {
                frm_AddRepairCardDet frm = new frm_AddRepairCardDet { FormMode = -1, Worker = Worker, HeadId = RC.Id };
                frm.SetFocus();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    DCBll.SaveRepairCardDets(0, RC.Id, frm.FormText, "", "", -99, "", "", 0, Worker, Worker);
                    SaveScannedMaterials(frm);
                    RenderCurrentPage();
                }
            }
            txt_Oper.Focus();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            if (_selectedCardId == 0)
            {
                ShowError("Card is not selected!");
                return;
            }

            frm_Print frmp = new frm_Print();
            frmp.cmb_LabPrinter1.ShowDefaults();
            if (frmp.ShowDialog() == DialogResult.OK && frmp.LabelQty > 0)
            {
                PrintLabels.PrinterIp = frmp.IP_Address;
                PrintLabels.PrinterDPI = frmp.Printer_DPI;

                var sqlParams = new List<SqlParameter>
                {
                    new SqlParameter("@id", SqlDbType.Int) { Value = _selectedCardId },
                    new SqlParameter("@labelqty", SqlDbType.Int) { Value = frmp.LabelQty }
                };

                PrintLabels.PrintLabel(PrintLabels.LabelConstructor(15, "sp_SelectRepairCardHeadPrint", sqlParams.ToArray()), 1);
            }
            txt_Oper.Focus();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            focusedtextbox = txt_Oper;
            ShowScreenNumKeyboard(txt_Oper);
        }

        private void txt_Oper_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string input = txt_Oper.Text.Trim();
                string column = System.Text.RegularExpressions.Regex.IsMatch(input, @"^RC\d{4}-\d{2}$") ? "name" : "serial";
                for (int i = 0; i < _dtCardsAll.Rows.Count; i++)
                    if (_dtCardsAll.Rows[i][column].ToString().Trim() == input)
                    {
                        _selectedCardId = Convert.ToInt32(_dtCardsAll.Rows[i]["id"]);
                        RC.Id = _selectedCardId;
                        _currentPage = i / PageSize;
                        RenderCurrentPage();
                        break;
                    }

                txt_Oper.Text = "";
                txt_Oper.Focus();
            }
        }

        private bool CheckWorker()
        {
            txtFocused frm1 = new txtFocused { HeaderText = "SCAN WORKER BADGE!", LabelText = "SCAN WORKER BADGE!" };
            if (frm1.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(frm1.FormText))
            {
                using (SqlConnection sqlConn = new SqlConnection(sConnStr))
                {
                    sqlConn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter($"execute sp_SelectWorkerSN @rfid = '{frm1.FormText}'", sqlConn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0]["isactive"]) == -1)
                    {
                        Worker = $"{dt.Rows[0]["name"]} {dt.Rows[0]["surname"]}";
                        WorkerId = Convert.ToInt32(dt.Rows[0]["id"]);
                        return true;
                    }
                }
            }
            ShowError("Worker scan failed or inactive!");
            return false;
        }

        private void SaveScannedMaterials(frm_AddRepairCardDet frm)
        {
            if (frm == null) return;
            List<int> newMats = frm.NewMaterials;
            if (newMats == null || newMats.Count == 0) return;

            int detId = _selectedSlot != null ? _selectedSlot.GetSelectedDetailId() : 0;
            foreach (int matId in newMats)
            {
                DCBll.SaveRepairCardMaterials(0, RC.Id, detId, matId, 1, "", Worker);
            }
        }

        private void btn_ChangeWorker_Click(object sender, EventArgs e)
        {
            CheckWorker();
            txt_Oper.Focus();
        }

        private void ShowError(string msg)
        {
            System.Media.SystemSounds.Exclamation.Play();
            frm_Error frm = new frm_Error { HeaderText = msg };
            frm.ShowDialog();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void btn_VisualControl_Click(object sender, EventArgs e)
        {
            if (_selectedSlot == null || _selectedCardId == 0)
            {
                ShowError("Select the card! (press on it)!");
                return;
            }

            int detId = _selectedSlot.GetSelectedDetailId();
            if (detId == 0)
            {
                ShowError("Select the defect/action!");
                return;
            }
            if (detId != 0 && CheckWorker())
            {
                int _res = DCBll.SaveRepairCardDets(detId, RC.Id, "", "", "", -1, Worker, "", 0, Worker, Worker);
                RenderCurrentPage();    
            }
            txt_Oper.Focus();

        }

        private void btn_DeleteCard_Click(object sender, EventArgs e)
        {
            if (_selectedCardId == 0 || RC.StateId == 0)
            {
                ShowError("Card is not selected or closed!");
                return;
            }

            if (GLOB.MessageConfirm("Repair card deletion!", "Are you sure you want to delete repair card?") == true)
            {
                //MessageBox.Show(_selectedCardId.ToString());
                string _res = DCBll.DeleteRepairCard(_selectedCardId);
                LoadData(-1);
            }
            txt_Oper.Focus();
        }
    }
}
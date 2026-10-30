using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Odin.DataCollection
{
    public partial class uc_RepairCardItem : UserControl
    {
        public event EventHandler<int> CardSelected;
        public event EventHandler NeedScannerFocus;

        public int CardId { get; private set; }
        public DataRow CardRow { get; private set; }

        private bool _isSelected = false;
        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                UpdateSelectionVisuals();
            }
        }

        // Инструменты для удаления и долгого нажатия
        private DC_BLL DCBll = new DC_BLL();
        private Timer _longPressTimer;
        private Point _pressLocation;
        private KryptonDataGridView _activeGrid;
        private int _activeRowIndex = -1;
        private ContextMenuStrip _touchContextMenu;

        public uc_RepairCardItem()
        {
            InitializeComponent();
            WireSelectionEvents(this);

            InitTouchContextMenu();
            InitLongPressLogic();

            // Оформление ячеек, кастомная печать и клики
            this.gv_Dets.CellFormatting += gv_Dets_CellFormatting;
            this.gv_Dets.CellPainting += gv_Dets_CellPainting;

            this.gv_Dets.CellClick += Grid_CellClick;
            this.gv_Materials.CellClick += Grid_CellClick;
        }

        #region Инициализация меню и долгого нажатия

        private void InitTouchContextMenu()
        {
            _touchContextMenu = new ContextMenuStrip();
            _touchContextMenu.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);

            ToolStripMenuItem btnDelete = new ToolStripMenuItem("🗑 Удалить запись");
            btnDelete.ForeColor = Color.Red;
            btnDelete.Image = global::Odin.Global_Resourses.delete2;
            btnDelete.Click += BtnDelete_Click;

            _touchContextMenu.Items.Add(btnDelete);
        }

        private void InitLongPressLogic()
        {
            _longPressTimer = new Timer();
            _longPressTimer.Interval = 1500; // 1.5 секунды
            _longPressTimer.Tick += LongPressTimer_Tick;

            SetupGridLongPress(gv_Dets);
            SetupGridLongPress(gv_Materials);
        }

        private void SetupGridLongPress(KryptonDataGridView grid)
        {
            grid.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    DataGridView.HitTestInfo hti = grid.HitTest(e.X, e.Y);
                    if (hti.RowIndex >= 0)
                    {
                        _activeGrid = grid;
                        _activeRowIndex = hti.RowIndex;
                        _pressLocation = e.Location;
                        _longPressTimer.Start();
                    }
                }
            };

            grid.MouseMove += (s, e) =>
            {
                if (_longPressTimer.Enabled)
                {
                    if (Math.Abs(e.X - _pressLocation.X) > 15 || Math.Abs(e.Y - _pressLocation.Y) > 15)
                    {
                        _longPressTimer.Stop();
                    }
                }
            };

            grid.MouseUp += (s, e) =>
            {
                _longPressTimer.Stop();
            };
        }

        private void LongPressTimer_Tick(object sender, EventArgs e)
        {
            _longPressTimer.Stop();

            if (_activeGrid != null && _activeRowIndex >= 0 && _activeRowIndex < _activeGrid.Rows.Count)
            {
                _activeGrid.ClearSelection();
                _activeGrid.Rows[_activeRowIndex].Selected = true;

                _touchContextMenu.Show(_activeGrid, _pressLocation);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_activeGrid == null || _activeRowIndex < 0 || _activeRowIndex >= _activeGrid.Rows.Count)
                return;

            DataGridViewRow row = _activeGrid.Rows[_activeRowIndex];
            DataRowView drv = row.DataBoundItem as DataRowView;
            if (drv == null) return;

            int recordId = Convert.ToInt32(drv["id"]);

            DialogResult res = MessageBox.Show(
                "Are you sure you want to delete selected record?",
                "Deleting confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                if (_activeGrid == gv_Dets)
                {
                    DCBll.DeleteRepairCardDets(recordId);
                    DataTable dtDets = DC_BLL.getRepairCardsDets(CardId);
                    gv_Dets.DataSource = dtDets;
                }
                else if (_activeGrid == gv_Materials)
                {
                    DCBll.DeleteRepairCardMaterial(recordId);
                    DataTable dtMats = DC_BLL.getRepairCardsMaterials(CardId);
                    gv_Materials.DataSource = dtMats;
                }
            }

            if (NeedScannerFocus != null)
                NeedScannerFocus(this, EventArgs.Empty);
        }

        #endregion

        #region Форматирование и отрисовка штампа

        private void gv_Dets_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string colName = gv_Dets.Columns[e.ColumnIndex].Name;

            // 1. Колонка Reparation (Штамп с векторным ключом)
            if (colName == "cn_reparation")
            {
                e.PaintBackground(e.CellBounds, true);

                DataGridViewRow row = gv_Dets.Rows[e.RowIndex];
                DataRowView drv = row.DataBoundItem as DataRowView;
                if (drv != null)
                {
                    string who = drv.Row.Table.Columns.Contains("repairby") && drv["repairby"] != DBNull.Value
                        ? drv["repairby"].ToString().Trim()
                        : "";

                    string when = "";
                    if (drv.Row.Table.Columns.Contains("repairat") && drv["repairat"] != DBNull.Value)
                    {
                        DateTime dt;
                        if (DateTime.TryParse(drv["repairat"].ToString(), out dt))
                            when = dt.ToString("dd.MM.yy HH:mm");
                        else
                            when = drv["repairat"].ToString().Trim();
                    }

                    if (!string.IsNullOrEmpty(who) || !string.IsNullOrEmpty(when))
                    {
                        DrawStamp(e.Graphics, e.CellBounds, who, when, "wrench",
                                  Color.FromArgb(145, 55, 15),
                                  Color.FromArgb(220, 255, 248, 242));
                    }
                }

                e.Handled = true;
            }
            // 2. Колонка Visual Control (Штамп с векторной галочкой)
            else if (colName == "cn_visualcontrol")
            {
                e.PaintBackground(e.CellBounds, true);

                DataGridViewRow row = gv_Dets.Rows[e.RowIndex];
                DataRowView drv = row.DataBoundItem as DataRowView;
                if (drv != null)
                {
                    string who = drv.Row.Table.Columns.Contains("visual_control_by") && drv["visual_control_by"] != DBNull.Value
                        ? drv["visual_control_by"].ToString().Trim()
                        : "";

                    string when = "";
                    if (drv.Row.Table.Columns.Contains("visual_control_at") && drv["visual_control_at"] != DBNull.Value)
                    {
                        DateTime dt;
                        if (DateTime.TryParse(drv["visual_control_at"].ToString(), out dt))
                            when = dt.ToString("dd.MM.yy HH:mm");
                        else
                            when = drv["visual_control_at"].ToString().Trim();
                    }

                    if (!string.IsNullOrEmpty(who) || !string.IsNullOrEmpty(when))
                    {
                        DrawStamp(e.Graphics, e.CellBounds, who, when, "check",
                                  Color.FromArgb(16, 68, 140),
                                  Color.FromArgb(220, 245, 250, 255));
                    }
                }

                e.Handled = true;
            }
        }

        private void DrawStamp(Graphics g, Rectangle bounds, string who, string when, string iconType, Color inkColor, Color bgTint)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle stampRect = new Rectangle(bounds.X + 3, bounds.Y + 2, bounds.Width - 6, bounds.Height - 5);
            if (stampRect.Width <= 10 || stampRect.Height <= 10) return;

            // 1. Полупрозрачная подложка штампа
            using (SolidBrush bgBrush = new SolidBrush(bgTint))
            {
                g.FillRectangle(bgBrush, stampRect);
            }

            // 2. Внешняя рамка
            using (Pen penOuter = new Pen(inkColor, 1.5f))
            {
                g.DrawRectangle(penOuter, stampRect);
            }

            // 3. Внутренний контур
            Rectangle innerRect = new Rectangle(stampRect.X + 2, stampRect.Y + 2, stampRect.Width - 4, stampRect.Height - 4);
            if (innerRect.Width > 4 && innerRect.Height > 4)
            {
                using (Pen penInner = new Pen(Color.FromArgb(80, inkColor), 1f))
                {
                    g.DrawRectangle(penInner, innerRect);
                }
            }

            int halfHeight = stampRect.Height / 2;
            Rectangle rTop = new Rectangle(stampRect.X, stampRect.Y + 1, stampRect.Width, halfHeight);
            Rectangle rBottom = new Rectangle(stampRect.X, stampRect.Y + halfHeight - 1, stampRect.Width, halfHeight);

            // 4. Верхняя строка: Векторная иконка + Фамилия
            using (Brush textBrush = new SolidBrush(inkColor))
            using (Font fontTop = new Font("Arial", 8F, FontStyle.Bold))
            using (Font fontBottom = new Font("Arial", 7.5F, FontStyle.Regular))
            {
                float iconSize = 12f;
                float spacing = 4f;

                SizeF textSize = g.MeasureString(who, fontTop);
                float totalWidth = iconSize + spacing + textSize.Width;

                // Центрируем блок [Иконка + Фамилия] внутри штампа
                float startX = rTop.X + (rTop.Width - totalWidth) / 2f;
                if (startX < rTop.X + 4) startX = rTop.X + 4;

                float iconY = rTop.Y + (rTop.Height - iconSize) / 2f;

                // Рисуем векторную иконку
                if (iconType == "wrench")
                {
                    DrawVectorWrench(g, startX, iconY, inkColor);
                }
                else if (iconType == "check")
                {
                    DrawVectorCheck(g, startX, iconY, inkColor);
                }

                // Рисуем имя
                RectangleF textRect = new RectangleF(startX + iconSize + spacing, rTop.Y, rTop.Right - (startX + iconSize + spacing) - 2, rTop.Height);
                using (StringFormat sfLeft = new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center, Trimming = StringTrimming.EllipsisCharacter })
                {
                    g.DrawString(who, fontTop, textBrush, textRect, sfLeft);
                }

                // 5. Нижняя строка: Дата и время
                using (StringFormat sfCenter = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center, Trimming = StringTrimming.EllipsisCharacter })
                {
                    g.DrawString(when, fontBottom, textBrush, rBottom, sfCenter);
                }
            }
        }

        // Векторный рожковый ключ под углом 45°
        private void DrawVectorWrench(Graphics g, float x, float y, Color color)
        {
            // Рукоятка ключа (снизу-слева вверх-направо)
            using (Pen penHandle = new Pen(color, 2.2f))
            {
                penHandle.StartCap = LineCap.Round;
                penHandle.EndCap = LineCap.Round;
                g.DrawLine(penHandle, x + 1.5f, y + 10.5f, x + 6.5f, y + 5.5f);
            }

            // Рожковый зев ключа (дуга с вырезом под 45°)
            using (Pen penJaw = new Pen(color, 1.8f))
            {
                penJaw.StartCap = LineCap.Round;
                penJaw.EndCap = LineCap.Round;
                g.DrawArc(penJaw, x + 4.5f, y + 0.5f, 7f, 7f, 15f, 250f);
            }
        }

        // Векторная галочка ОТК
        private void DrawVectorCheck(Graphics g, float x, float y, Color color)
        {
            using (Pen penCheck = new Pen(color, 2f))
            {
                penCheck.StartCap = LineCap.Round;
                penCheck.EndCap = LineCap.Round;
                penCheck.LineJoin = LineJoin.Round;

                PointF[] pts = new PointF[]
                {
                    new PointF(x + 1.5f, y + 6.5f),
                    new PointF(x + 4.5f, y + 10.0f),
                    new PointF(x + 11.0f, y + 2.0f)
                };
                g.DrawLines(penCheck, pts);
            }
        }

        private void gv_Dets_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= gv_Dets.Rows.Count) return;

            DataGridViewRow row = gv_Dets.Rows[e.RowIndex];
            DataRowView drv = row.DataBoundItem as DataRowView;
            if (drv == null) return;

            // 1. Форматируем склеенное поле "Created by / at"
            if (gv_Dets.Columns[e.ColumnIndex].Name == "cn_createdinfo")
            {
                string who = "";
                string when = "";

                if (drv.Row.Table.Columns.Contains("who") && drv["who"] != DBNull.Value)
                    who = drv["who"].ToString();
                else if (drv.Row.Table.Columns.Contains("createdby") && drv["createdby"] != DBNull.Value)
                    who = drv["createdby"].ToString();

                if (drv.Row.Table.Columns.Contains("when") && drv["when"] != DBNull.Value)
                    when = drv["when"].ToString();
                else if (drv.Row.Table.Columns.Contains("createdat") && drv["createdat"] != DBNull.Value)
                    when = drv["createdat"].ToString();

                e.Value = (who + " " + when).Trim();
                e.FormattingApplied = true;
            }

            // 2. Форматируем поле "Valid" (добавляем "кем валидировано")
            if (gv_Dets.Columns[e.ColumnIndex].Name == "cn_validstatestr")
            {
                string validStr = drv["validstatestr"] != DBNull.Value ? drv["validstatestr"].ToString() : "";
                string validBy = drv.Row.Table.Columns.Contains("validby") && drv["validby"] != DBNull.Value ? drv["validby"].ToString() : "";

                if (!string.IsNullOrEmpty(validBy))
                {
                    e.Value = validStr + " (" + validBy + ")";
                    e.FormattingApplied = true;
                }
            }

            // 3. Подкраска строк и ЧЕТКОЕ ВЫДЕЛЕНИЕ (Серый томат и Серый зеленый)
            if (drv.Row.Table.Columns.Contains("validstate"))
            {
                int vState = drv["validstate"] != DBNull.Value ? Convert.ToInt32(drv["validstate"]) : -99;

                if (vState == 0) // Отклонено (Томат)
                {
                    e.CellStyle.BackColor = Color.LightCoral;
                    // «Серый томат» при выделении (приглушенный красно-серый):
                    e.CellStyle.SelectionBackColor = Color.FromArgb(190, 130, 130);
                    e.CellStyle.SelectionForeColor = Color.White;
                }
                else if (vState == -1) // Одобрено (Зеленый)
                {
                    e.CellStyle.BackColor = Color.FromArgb(192, 255, 192);
                    // «Серый зеленый» при выделении (приглушенный шалфейно-зеленый):
                    e.CellStyle.SelectionBackColor = Color.FromArgb(145, 185, 150);
                    e.CellStyle.SelectionForeColor = Color.Black;
                }
            }
        }

        public void BindData(DataRow row, DataTable dtDets, DataTable dtMats)
        {
            CardRow = row;
            if (row == null)
            {
                this.Visible = false;
                CardId = 0;
                return;
            }

            this.Visible = true;
            CardId = Convert.ToInt32(row["id"]);

            headerGroupCard.ValuesPrimary.Heading = "Card: " + row["name"] + " | SN: " + row["serial"];
            headerGroupCard.ValuesSecondary.Heading = "Article: " + row["article"] + " | Created: " + row["when"] + " by " + row["who"];

            gv_Dets.AutoGenerateColumns = false;
            gv_Dets.DataSource = dtDets;

            gv_Materials.AutoGenerateColumns = false;
            gv_Materials.DataSource = dtMats;

            // Сброс выделения через очередь UI
            gv_Dets.BeginInvoke(new Action(() =>
            {
                gv_Dets.CurrentCell = null;
                gv_Dets.ClearSelection();
            }));

            gv_Materials.BeginInvoke(new Action(() =>
            {
                gv_Materials.CurrentCell = null;
                gv_Materials.ClearSelection();
            }));

            UpdateSelectionVisuals();
        }

        #endregion

        #region Вспомогательные методы кликов и фокуса

        private void WireSelectionEvents(Control parent)
        {
            parent.Click += (s, e) => SelectMe();
            foreach (Control c in parent.Controls)
            {
                if (c is DataGridView) continue;
                WireSelectionEvents(c);
            }
        }

        private void SelectMe()
        {
            if (CardSelected != null)
                CardSelected(this, CardId);
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectMe();

            if (NeedScannerFocus != null)
                NeedScannerFocus(this, EventArgs.Empty);
        }

        private void UpdateSelectionVisuals()
        {
            if (_isSelected)
            {
                headerGroupCard.StateCommon.Border.Color1 = Color.FromArgb(255, 128, 0);
                headerGroupCard.StateCommon.Border.Color2 = Color.FromArgb(255, 128, 0);
                headerGroupCard.StateCommon.Border.Width = 3;
                headerGroupCard.StateCommon.HeaderPrimary.Back.Color1 = Color.FromArgb(255, 230, 180);
            }
            else
            {
                headerGroupCard.StateCommon.Border.Color1 = Color.Silver;
                headerGroupCard.StateCommon.Border.Color2 = Color.Silver;
                headerGroupCard.StateCommon.Border.Width = 1;
                headerGroupCard.StateCommon.HeaderPrimary.Back.Color1 = Color.FromArgb(240, 240, 240);
            }
        }

        public int GetSelectedDetailId()
        {
            if (gv_Dets.CurrentRow != null)
            {
                DataRowView drv = gv_Dets.CurrentRow.DataBoundItem as DataRowView;
                if (drv != null)
                {
                    return Convert.ToInt32(drv["id"]);
                }
            }
            return 0;
        }

        #endregion
    }
}
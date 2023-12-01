using ComponentFactory.Krypton.Toolkit;
using Odin.CustomControls;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace Odin.Global_Classes
{
    public partial class frm_AddNumPDA : KryptonForm
    {
        public frm_AddNumPDA()
        {
            InitializeComponent();
            NumericCheckHandler = new KeyPressEventHandler(NumericCheck);
            PopupHelper = new PopupWindowHelper();
        }

        private static KeyPressEventHandler NumericCheckHandler;
        frm_ScreenNumKeyboard popup;
        PopupWindowHelper PopupHelper = null;
        TextBox focusedtextbox;

        public double Qty
        {
            get
            {
                try { return Convert.ToDouble(txt_Qty.Text); }
                catch { return 0; }
            }
            set { txt_Qty.Text = value.ToString(); }
        }

        private float _measCellValue;
        public float MeasCellValue
        {
            get { return _measCellValue; }
            set { _measCellValue = value; }
        }

        public void CheckEmpty()
        {
            if (Qty <= 0)
                btn_OK.Enabled = false;
            else
                btn_OK.Enabled = true;
        }

        private void txt_Qty_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
            try
            {
                popup.CellText = txt_Qty.Text.ToString();
                txt_Qty.SelectionStart = txt_Qty.Text.Length;
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
            else if (e.KeyChar == '-')
            {
                e.Handled = s.Text.Contains(e.KeyChar);
            }
            else
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
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

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

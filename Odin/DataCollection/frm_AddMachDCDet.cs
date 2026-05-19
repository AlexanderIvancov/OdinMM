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
using Odin.Purchase;
using Odin.Global_Classes;
using Odin.CustomControls;
using Owf.Controls;
using System.Data.SqlClient;
using Odin.Tools;
namespace Odin.DataCollection
{
    public partial class frm_AddMachDCDet : KryptonForm
    {
        public frm_AddMachDCDet()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        frm_ScreenNumKeyboard16 popup;
        frm_Feeders popupfed;
        PopupWindowHelper PopupHelper = null;
        KryptonTextBox focusedtextbox;

        public int HeadId
        { get; set; }

        public string Launch
        {
            get { return txt_Launch.Text; }

            set { txt_Launch.Text = value; }

        }

        public string Feeder
        {
            get { return txt_Feeder.Text; }

            set { txt_Feeder.Text = value; }

        }

        public string Serial
        {
            get { return txt_Serial.Text; }

            set { txt_Serial.Text = value; }

        }

        public int Label
        {
            get { try { return Convert.ToInt32(txt_Label.Text); }
                catch { return 0; } }

            set { txt_Label.Text = value.ToString(); }

        }

        public int OldLabel
        {
            get
            {
                try { return Convert.ToInt32(txt_OldLabel.Text); }
                catch { return 0; }
            }

            set { txt_OldLabel.Text = value.ToString(); }

        }


        public int ArtId
        {
            get
            {
                try { return Convert.ToInt32(txt_ArtId.Text); }
                catch { return 0; }
            }

            set { txt_ArtId.Text = value.ToString(); }

        }

        int _lineid = 0;
        public int LineId
        {
            get { return _lineid; }
            set { _lineid = value; }
        }

        public void CheckEmpty()
        {
            if (HeadId == 0
                || Label == 0
                || Serial == ""
                || Feeder == ""
              //  || (CheckOldLabel == true && OldLabel == 0)
                )
                btn_OK.Enabled = false;
            else
                btn_OK.Enabled = true;
        }

        bool _checkoldlabel = true;

        public bool CheckOldLabel
        {
           get { return _checkoldlabel; }
            set { _checkoldlabel = value;
                if (_checkoldlabel == true)
                {
                    btn_OldLabel.Enabled = true;
                    lbl_OldLabel.Enabled = true;
                    txt_OldLabel.Enabled = true;

                }
                else
                {
                    btn_OldLabel.Enabled = false;
                    lbl_OldLabel.Enabled = false;
                    txt_OldLabel.Enabled = false;
                    OldLabel = 0;
                }
            }
           
        }

        private void insertKeyboardSymbol(string symbol, bool symremove)
        {
            if (symremove)
            {
                focusedtextbox.Text = symbol;
            }
            else
            {
                focusedtextbox.Text += symbol;
            }
        }

        private void insertKeyboardSymbolFed(string symbol, bool symremove)
        {
            focusedtextbox.Text = symbol;
            CheckPreviousLabel(symbol, HeadId);
        }

        bool _isnewlabel = true;
        public void CheckPreviousLabel(string Feeder, int HeadId)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            sqlConn.Open();
            DataSet ds1 = new DataSet();

            SqlDataAdapter adapter1 =
                 new SqlDataAdapter(
                     "select top 1 cd.labelid,  r.artid from PROD_ControlCardDets cd " + 
                              "inner join sto_rests r on r.id = cd.labelid " + 
                               " where cd.headid = " + HeadId + 
                               " and cd.feeder = '" + Feeder + "' order by cd.id desc", sqlConn);

            adapter1.Fill(ds1);

            DataTable dt1 = ds1.Tables[0];

            if (dt1.Rows.Count > 0)
            {
                foreach (DataRow dr1 in dt1.Rows)
                {
                    ArtId = Convert.ToInt32(dr1["artid"].ToString());
                    OldLabel = Convert.ToInt32(dr1["labelid"].ToString());
                }
                btn_OldLabel.Enabled = false;
                _isnewlabel = true;
            }
            else
            {
                ArtId = 0;
                OldLabel = 0;      
                btn_OldLabel.Enabled = true;
                _isnewlabel = false;
            }
            sqlConn.Close();

        }


        private void ShowScreenNumKeyboard(KryptonTextBox _focusedtextbox)
        {
            popup = new frm_ScreenNumKeyboard16();
            popup.DisplayKeyboardSymbol += new CustomControls.DisplayKeyboardSymbolEventHandler16(insertKeyboardSymbol);
            popup.FormClosing += new FormClosingEventHandler(FocusOn);
            // popup.SendClosing += new SendClosingEventHandler16(CheckParams);
            
            Form f;
            f = this.FindForm();

            Point LocationPoint = _focusedtextbox.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X - popup.Width;//+ _focusedtextbox.Width;
            int ypos = LocationPoint.Y;
            Point _location = new Point(xpos, ypos);

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);
        }

        private void ShowScreenNumKeyboardFeeder(KryptonTextBox _focusedtextbox)
        {
           
            popupfed = new frm_Feeders();
            popupfed.DisplayKeyboardSymbol += new CustomControls.DisplayFeederSymbolEventHandler(insertKeyboardSymbolFed);
            popupfed.FormClosing += new FormClosingEventHandler(FocusOn);
            
            popupfed.LineId = LineId;

            //popupfed.ShowDialog();
            Form f;
            f = this.FindForm();

            Point LocationPoint = _focusedtextbox.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X - (popupfed.Width / 2) + _focusedtextbox.Width;//+ _focusedtextbox.Width;
            int ypos = LocationPoint.Y + _focusedtextbox.Height + 10;
            Point _location = new Point(xpos, ypos);

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popupfed, _location);
        }

        public void FocusOn(object sender, FormClosingEventArgs e)
        {
            txt_Oper.Text = string.Empty;
            txt_Oper.Focus();

            CheckEmpty();

            //if (DCBll.CheckParameters == -1
            //  && LaunchId != 0
            //  && WorkerId != 0)
            //{
            //    frm_AdditContent frm = new frm_AdditContent();
            //    frm.Instructions = DCBll.CheckInstructions;

            //    DialogResult result = frm.ShowDialog();

            //    frm.CheckEmpty();


            //    if (result == DialogResult.OK)
            //    {
            //        //DCBll.AddDataCollectionCheckParams(WorkerId, LaunchId, OperNO, frm.Parameters);

            //        txt_Oper.Text = string.Empty;
            //        txt_Oper.Focus();
            //    }
            //}

        }

        private void btn_Feeder_Click(object sender, EventArgs e)
        {
            //focusedtextbox = txt_Feeder;

            //popupfed = new frm_Feeders();
            //popupfed.DisplayKeyboardSymbol += new CustomControls.DisplayFeederSymbolEventHandler(insertKeyboardSymbolFed);
            //popupfed.FormClosing += new FormClosingEventHandler(FocusOn);
            //popupfed.LineId = LineId;

            //popupfed.ShowDialog();
            focusedtextbox = txt_Feeder;
            txt_Feeder.ThreadSafeCall(delegate { ShowScreenNumKeyboardFeeder(txt_Feeder); });
            popupfed.CellText = txt_Feeder.Text.ToString();
        }

        private void btn_SN_Click(object sender, EventArgs e)
        {
            //focusedtextbox = txt_Serial;
            //txt_Serial.ThreadSafeCall(delegate { ShowScreenNumKeyboard(txt_Serial); });
            //popup.CellText = txt_Serial.Text.ToString();

            frm_cmbTextPDA frm = new frm_cmbTextPDA();
            frm.LabelText = "PCB panel S/N: ";
            frm.HeaderText = "Enter PCB panel S/N: ";
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Serial = frm.FormText.Trim();
                //txt_Oper.Text = "";
                //txt_Oper.Focus();
            }

            else
            {
                //txt_Oper.Text = "";
                //txt_Oper.Focus();
            }
            CheckEmpty();
        }

        private void txt_Oper_TextChanged(object sender, EventArgs e)
        {
            
        }

        public bool CheckStockLabel(string Label)
        {
            bool _res = false;

            int _label = 0;
            bool success = Int32.TryParse(Label, out _label);
            if (success)
            {
                SqlConnection sqlConn = new SqlConnection(sConnStr);
                sqlConn.Open();
                DataSet ds1 = new DataSet();

                SqlDataAdapter adapter1 =
                    new SqlDataAdapter(
                        "select artid from sto_rests where id = " + Label, sqlConn);

                adapter1.Fill(ds1);

                DataTable dt1 = ds1.Tables[0];

                if (dt1.Rows.Count > 0)
                {
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        ArtId = Convert.ToInt32(dr1["artid"].ToString());
                    }
                    _res = true;
                }
                else
                {
                    //globClass.ShowMessage("Wrong launch scanning", "Please contact your master", "Your launch is not correct!");
                    System.Media.SystemSounds.Exclamation.Play();
                    frm_Error frm1 = new frm_Error();
                    frm1.HeaderText = "Wrong label scanning! Nu such label! Scan correct label!";
                    DialogResult result1 = frm1.ShowDialog();
                    ArtId = 0;
                    _res = false;
                }
                sqlConn.Close();
                txt_Oper.Text = "";
                txt_Oper.Focus();
            }
            else
            {
                System.Media.SystemSounds.Exclamation.Play();
                frm_Error frm1 = new frm_Error();
                frm1.HeaderText = "Wrong label scanning! Youre trying to scan not stock label! Scan correct label!";
                DialogResult result1 = frm1.ShowDialog();
                ArtId = 0;
                _res = false;
            }

            return _res;
        }

        public bool CheckStockLabelNew(string Label)
        {
            bool _res = false;

            int _label = 0;
            int _tempartid = 0;
            bool success = Int32.TryParse(txt_Oper.Text.Trim(), out _label);

            if (success)
            {
                SqlConnection sqlConn = new SqlConnection(sConnStr);
                sqlConn.Open();
                DataSet ds1 = new DataSet();

                SqlDataAdapter adapter1 =
                    new SqlDataAdapter(
                        "select artid from sto_rests where id = " + Label, sqlConn);

                adapter1.Fill(ds1);

                DataTable dt1 = ds1.Tables[0];

                if (dt1.Rows.Count > 0)
                {
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        _tempartid = Convert.ToInt32(dr1["artid"].ToString());
                    }

                }
                else
                {
                    //globClass.ShowMessage("Wrong launch scanning", "Please contact your master", "Your launch is not correct!");
                    //System.Media.SystemSounds.Exclamation.Play();
                    //frm_Error frm1 = new frm_Error();
                    //frm1.HeaderText = "Wrong label scanning! Scan correct label!";
                    //DialogResult result1 = frm1.ShowDialog();
                    //ArtId = 0;
                }
                sqlConn.Close();
                txt_Oper.Text = "";
                txt_Oper.Focus();

                if (CheckOldLabel == true)
                {
                    if (ArtId != _tempartid
                        || _tempartid == 0
                        || ArtId == 0)
                    {
                        ArtId = 0;
                        System.Media.SystemSounds.Exclamation.Play();
                        frm_Error frm1 = new frm_Error();
                        frm1.HeaderText = "Wrong label scanning! Articles are different! Scan correct label!";
                        DialogResult result1 = frm1.ShowDialog();
                        _res = false;
                    }
                    else
                    {
                        ArtId = _tempartid;
                        _res = true;
                    }
                }
                else
                {
                    if (_tempartid == 0)
                    {
                        System.Media.SystemSounds.Exclamation.Play();
                        frm_Error frm1 = new frm_Error();
                        frm1.HeaderText = "Wrong label scanning! Articles are different! Scan correct label!";
                        DialogResult result1 = frm1.ShowDialog();
                        _res = false;
                    }
                    else
                    {
                        ArtId = _tempartid;
                        _res = true;
                    }
                }
            }
            else
            {
                System.Media.SystemSounds.Exclamation.Play();
                frm_Error frm1 = new frm_Error();
                frm1.HeaderText = "Wrong label scanning! Scan correct label!";
                DialogResult result1 = frm1.ShowDialog();
                _tempartid = 0;
                _res = false;
            }

            

            return _res;
        }

        private void txt_Oper_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* if (e.KeyChar == (char)Keys.Enter)
            {
                //Trying to get label

                int _label = 0;
                bool success = Int32.TryParse(txt_Oper.Text.Trim(), out _label);

                if (success)
                {
                    Label = _label;
                }
                else
                {
                    Label = 0;
                }                

                SqlConnection sqlConn = new SqlConnection(sConnStr);
                sqlConn.Open();
                DataSet ds1 = new DataSet();

                SqlDataAdapter adapter1 =
                    new SqlDataAdapter(
                        "select artid from sto_rests where id = " + Label, sqlConn);

                adapter1.Fill(ds1);

                DataTable dt1 = ds1.Tables[0];

                if (dt1.Rows.Count > 0)
                {
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        ArtId = Convert.ToInt32(dr1["artid"].ToString());
                    }
                    
                }
                else
                {
                    //globClass.ShowMessage("Wrong launch scanning", "Please contact your master", "Your launch is not correct!");
                    System.Media.SystemSounds.Exclamation.Play();
                    frm_Error frm1 = new frm_Error();
                    frm1.HeaderText = "Wrong label scanning! Scan correct label!";
                    DialogResult result1 = frm1.ShowDialog();
                    ArtId = 0;
                }
                sqlConn.Close();
                txt_Oper.Text = "";
                txt_Oper.Focus();

            }
            CheckEmpty();*/
        }

        private void txt_Feeder_TextChanged(object sender, EventArgs e)
        {
            try
            {
                popupfed.CellText = txt_Feeder.Text.ToString();
                txt_Feeder.SelectionStart = txt_Feeder.Text.Length;
            }
            catch { }
        }

        private void txt_Serial_TextChanged(object sender, EventArgs e)
        {
            try
            {
                popup.CellText = txt_Serial.Text.ToString();
                txt_Serial.SelectionStart = txt_Serial.Text.Length;
            }
            catch { }
        }

        private void btn_OldLabel_Click(object sender, EventArgs e)
        {
            txtFocused frm = new txtFocused();
            frm.HeaderText = "Scan old stock label";
            frm.LabelText = "SCAN OLD LABEL!";
            

            DialogResult result = frm.ShowDialog();
            frm.txt_Text.Focus();
            if (result == DialogResult.OK
                && frm.FormText != ""
                && CheckStockLabel(frm.FormText) == true
                )
            {
                OldLabel = Convert.ToInt32(frm.FormText);
            }
            CheckEmpty();
        }

        private void btn_NewLabel_Click(object sender, EventArgs e)
        {
            txtFocused frm = new txtFocused();
            frm.HeaderText = "Scan old stock label";
            frm.LabelText = "SCAN NEW LABEL!";
           // frm.txt_Text.Focus();

            DialogResult result = frm.ShowDialog();
            frm.txt_Text.Focus();
            if (result == DialogResult.OK
                && frm.FormText != ""
                && CheckStockLabel(frm.FormText) == true
                )
            {
                Label = Convert.ToInt32(frm.FormText);
            }
            CheckEmpty();

        }
    }
}

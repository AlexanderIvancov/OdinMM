using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Odin.Global_Classes;
using System.Data.SqlClient;

namespace Odin.CustomControls
{
    public delegate void DisplayFeederSymbolEventHandler(string symbol, bool symremove);
    public delegate void SendClosingEventHandlerFed(object sender);

    public partial class frm_Feeders : Template_CMB
    {
        public event DisplayFeederSymbolEventHandler DisplayKeyboardSymbol;
        public event SendClosingEventHandlerFed SendClosing;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        PopupWindowHelper PopupHelper = null;

        Font boldFont;

        bool _showingModal = false;

        int _lineid = 0;
        public int _feedercountfront = 0;
        public int _feedercountrear = 0;
        public int _traycountfront = 0;
        public int _traycountrear = 0;
       
        public int LineId
        {
            get { return _lineid; }
            set { _lineid = value; }
        }
        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }
       
        public string CellText
        {
            get;
            set;
        }

        public frm_Feeders()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();

        }

        int _MachId = -1;
        string _Machine = "M1";

        public void GetMachineConfiguration()
        {
            SqlConnection conn = new SqlConnection(sConnStr);
            string strSQL = "set dateformat dmy SELECT DISTINCT feedercountfront, feedercountrear, traycountfront, traycountrear " +
                                "FROM PROD_Machines  " +
                                    "WHERE lineid = " +LineId + " and name = '" + _Machine + "'";

            conn.Open();
            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                    new SqlDataAdapter(strSQL, conn);

            adapter.Fill(ds);

            conn.Close();

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                   
                    _feedercountfront = Convert.ToInt32(dr["feedercountfront"]);
                    _feedercountrear = Convert.ToInt32(dr["feedercountrear"]);
                    _traycountfront = Convert.ToInt32(dr["traycountfront"]);
                    _traycountrear = Convert.ToInt32(dr["traycountrear"]);
                }
            }
            else
            {
                //ClearFields();
            }
        }


        public int MachineId
        {
            get { return _MachId; }
            set
            {
                _MachId = value;
                switch (_MachId)
                {
                    case 1:
                        chk_M1.Checked = true;
                        chk_M2.Checked = false;
                        chk_M3.Checked = false;
                        chk_M1.BackColor = Color.LightPink;
                        chk_M2.BackColor = Color.LightGreen;
                        chk_M3.BackColor = Color.LightGreen;
                        _Machine = "M1";
                        break;

                    case 2:
                        chk_M1.Checked = false;
                        chk_M2.Checked = true;
                        chk_M3.Checked = false;
                        chk_M1.BackColor = Color.LightGreen;
                        chk_M2.BackColor = Color.LightPink;
                        chk_M3.BackColor = Color.LightGreen;
                        _Machine = "M2";
                        break;

                    default:
                        chk_M1.Checked = false;
                        chk_M2.Checked = false;
                        chk_M3.Checked = true;
                        chk_M1.BackColor = Color.LightGreen;
                        chk_M2.BackColor = Color.LightGreen;
                        chk_M3.BackColor = Color.LightPink;
                        _Machine = "M3";
                        break;
                }               
            }
        }

        public void DrawKeyboard()
        {
            GetMachineConfiguration();

            pn_frontf.Controls.Clear() ;
            pn_frontt.Controls.Clear();
            pn_rearf.Controls.Clear();
            pn_reart.Controls.Clear();

            int count = 1;
            //int _front = 35;
            //int _rear = 35;

            if (_traycountfront == 0)
            {
                pn_frontt.Visible = false;
                pn_frontf.Dock = DockStyle.Fill;
            }
            else
            {
                pn_frontt.Visible = true;
                pn_frontt.Width = pn_front.Width * _traycountfront / (_feedercountfront + _traycountfront);
                pn_frontf.Dock = DockStyle.Fill;
            }

            if (_traycountrear == 0)
            {
                pn_reart.Visible = false;
                pn_rearf.Dock = DockStyle.Fill;
            }
            else
            {
                pn_reart.Visible = true;
               
                pn_reart.Width = pn_rear.Width * _traycountrear / (_feedercountrear + _traycountrear);
                pn_rearf.Dock = DockStyle.Fill;
            }

            pn_front.Refresh();
            pn_rear.Refresh();
            pn_frontf.Refresh();
            pn_rearf.Refresh();
            pn_frontt.Refresh();
            pn_reart.Refresh();

            int buttonwidthfrontfed = _feedercountfront == 0 ? 0 : (Int32)pn_frontf.Width / _feedercountfront * (_feedercountfront <= 15 ? 1 : 2);
            int buttonwidthrearfed = _feedercountrear == 0 ? 0 : (Int32)pn_rearf.Width / _feedercountrear * (_feedercountrear <= 15 ? 1 : 2);
            int buttonwidthfronttray = _traycountfront == 0 ? 0 : (Int32)pn_frontt.Width / _traycountfront * (_traycountfront <= 15 ? 1 : 2);
            int buttonwidthreartray = _traycountrear == 0 ? 0 :  (Int32)pn_reart.Width / _traycountrear * (_traycountrear <= 15 ? 1 : 2);
            
            int countrow = _feedercountfront <= 15 ? 1 : 2;

            int buttonheigh = (Int32)pn_front.Height / countrow - 2;
            int bcount = _feedercountfront / 2;
            //Front feeders
            for (int row = 0; row < countrow; row++)
            {
                for (int button_in_row = 0; button_in_row < bcount; button_in_row++)
                {
                    drawButton(row, button_in_row, "F" + count.ToString(), buttonwidthfrontfed, buttonheigh, false, false);
                    count++;
                }
            }
            //Front trays
            //bcount = _traycountfront / 2;
            count = 1;
            countrow = _traycountfront <= 15 ? 1 : 2;
            bcount = _traycountfront / countrow; // /2
            buttonheigh = (Int32)pn_front.Height / countrow - 2;

            for (int row = 0; row < countrow; row++)
            {
                for (int button_in_row = 0; button_in_row < bcount; button_in_row++)
                {
                    drawButton(row, button_in_row, "P" + count.ToString(), buttonwidthfronttray, buttonheigh, false, true);
                    count++;
                }
            }
            //Rear feeders
          
           // bcount = _feedercountrear / 2;
            count = 1;
            countrow = _feedercountrear <= 15 ? 1 : 2;
            buttonheigh = (Int32)pn_rear.Height / countrow - 2;
            bcount = _feedercountrear / countrow; // 2;

            for (int row = 0; row < countrow; row++)
            {
                for (int button_in_row = 0; button_in_row < bcount; button_in_row++)
                {
                    drawButton(row, button_in_row, "F1" + (count.ToString().Length == 1 ? "0" : "") + count.ToString(), buttonwidthrearfed, buttonheigh, true, false);
                    count++;
                }
            }

            //Rear tray

           // bcount = _traycountrear / 2;
            count = 1;
            countrow = _traycountrear <= 15 ? 1 : 2;
            bcount = _traycountrear / countrow;
            buttonheigh = (Int32)pn_rear.Height / countrow - 2;

            for (int row = 0; row < countrow; row++)
            {
                for (int button_in_row = 0; button_in_row < bcount; button_in_row++)
                {
                    drawButton(row, button_in_row, "P" + count.ToString(), buttonwidthreartray, buttonheigh, true, true);
                    count++;
                }
            }            

            //drawButton(0, 0, "1", buttonwidth, buttonheigh);
            //drawButton(0, 1, "2", buttonwidth, buttonheigh);
            //drawButton(0, 2, "3", buttonwidth, buttonheigh);
            //drawButton(0, 3, "4", buttonwidth, buttonheigh);
            //drawButton(0, 4, "-", buttonwidth, buttonheigh);
            //drawButton(1, 0, "5", buttonwidth, buttonheigh);
            //drawButton(1, 1, "6", buttonwidth, buttonheigh);
            //drawButton(1, 2, "7", buttonwidth, buttonheigh);
            //drawButton(1, 3, "8", buttonwidth, buttonheigh);
            //drawButton(1, 4, "Back", buttonwidth, buttonheigh);
            //drawButton(2, 0, "9", buttonwidth, buttonheigh);
            //drawButton(2, 1, "0", buttonwidth, buttonheigh);
            //drawButton(2, 2, "A", buttonwidth, buttonheigh);
            //drawButton(2, 3, "B", buttonwidth, buttonheigh);
            //drawButton(2, 4, "Clear", buttonwidth, buttonheigh);
            //drawButton(3, 0, "C", buttonwidth, buttonheigh);
            //drawButton(3, 1, "D", buttonwidth, buttonheigh);
            //drawButton(3, 2, "E", buttonwidth, buttonheigh);
            //drawButton(3, 3, "F", buttonwidth, buttonheigh);
            //drawButton(3, 4, "OK", buttonwidth, buttonheigh);

        }

        private void frm_ScreenNumKeyboard_Load(object sender, EventArgs e)
        {
            DrawKeyboard();
        }

        private void drawButton(int i, int j, string count, int w, int h, bool rear, bool tray)
        {
            List<Button> digitButtons = new List<Button>();
            Button newbutton = new Button();
            newbutton.Name = "Button" + count;
            newbutton.Width = w;
            newbutton.Height = h;
            newbutton.Text = count;
            
            boldFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
           
            //newbutton.Font = boldFont;
            newbutton.Left = count == "," ? newbutton.Width * (j * 2) : newbutton.Width * j;
            //newbutton.Top = newbutton.Height == 100 ? (newbutton.Height / 2) * i : newbutton.Height * i;
            newbutton.Top = newbutton.Height == (Int32)this.Height / 4 * 2 ? (newbutton.Height / 2) * i : newbutton.Height * i;

            newbutton.Click += new EventHandler(newbutton_Click);

            digitButtons.Add(new Button());
            //this.Controls.Add(newbutton);
            if (rear == false)
                if (tray == false)
                    pn_frontf.Controls.Add(newbutton);
                else
                    pn_frontt.Controls.Add(newbutton);
            else
                if (tray == false)
                    pn_rearf.Controls.Add(newbutton);
                else
                    pn_reart.Controls.Add(newbutton);
        }

        private void newbutton_Click(object sender, EventArgs e)
        {
            string cellVal = "";
          
            if (DisplayKeyboardSymbol != null)
            {
                try
                {
                    Button button = sender as Button;
                    if ((string)button.Text == "Back")
                    {
                        cellVal = CellText;
                        DisplayKeyboardSymbol(cellVal.Remove(cellVal.Length - 1), true);
                    }
                    else if ((string)button.Text == "Clear")
                    {
                        cellVal = CellText;
                        DisplayKeyboardSymbol("", true);
                    }
                    else
                    {
                        switch ((string)button.Text)
                        {
                            //case "-":
                            //    tempString = CellText != null ? CellText : string.Empty;

                            //    if (tempString.Contains("-"))
                            //    {
                            //        return;
                            //    }

                            //    else
                            //    {
                            //         DisplayKeyboardSymbol("-", false);//
                            //    }

                            //    break;

                            case "OK":
                                SendClosing(this);
                                this.Close();
                                break;

                            default:
                                DisplayKeyboardSymbol(_Machine + "-" + button.Text, false);//

                                break;
                        }
                    }


                }
                catch
                {
                    return;
                }
            }

        }

        private void chk_M1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_M1.CheckState == CheckState.Checked)
            {
                MachineId = 1;
                DrawKeyboard();

            }
        }

        private void chk_M2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_M2.CheckState == CheckState.Checked)
            {   MachineId = 2;
                DrawKeyboard();
            }
        }

        private void chk_M3_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_M3.CheckState == CheckState.Checked)
            {
                MachineId = 3;
                DrawKeyboard();
            }
        }
        private void btn_OK_Click(object sender, EventArgs e)
        {
            //SendClosing(this);
            this.Close();
        }
    }
}

using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Odin.CMB_Components.Common
{
    public delegate void CommonEventHandler(object sender);

    public partial class cmb_Common : UserControl
    {

        public cmb_Common()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;

        public event CommonEventHandler SelectedValueChanged;

        int _id = 0;

        bool _isemptycolor = false;

        public bool IsEmptyColor
        {
            get { return _isemptycolor; }
            set
            {
                _isemptycolor = value;
                if (value == true)
                    txt_Common.StateCommon.Back.Color1 = Color.LightPink;
                else
                    txt_Common.StateCommon.Back.Color1 = Color.White;
            }
        }

        public string sTitle
        {
            get;
            set;
        }

        public string sTable
        {
            get;
            set;
        }

        public string sID_Filled
        {
            get;
            set;
        }


        public string sText_Filled
        {
            get;
            set;
        }

        
        public string OrderBy
        {
            get;set;
        }

        public string sCurrentValue
        {
            get
            {
                if (String.IsNullOrEmpty(txt_Common.Text) == true)
                    return "";
                else
                    return txt_Common.Text;
            }
            set
            {
                txt_Common.Text = value;
            }
        }

        public int SelectedValue
        {
            get { return _id; }
            set
            {
                _id = value;

                switch (value)
                {
                    case 0:
                        txt_Common.Text = "";
                        break;
                    case -1:
                        txt_Common.Text = "";
                        break;
                    default:
                        {

                            var sb = new StringBuilder();
                            sb.Append("SELECT ");
                            sb.Append(sText_Filled);
                            sb.Append(" FROM ");
                            sb.Append(sTable);
                            sb.Append(" WITH (NOLOCK) WHERE ");
                            sb.Append(sID_Filled);
                            sb.Append(" = ");
                            sb.Append("@");
                            sb.Append(sID_Filled);
                            if (OrderBy != "")
                                sb.Append(" order by " + OrderBy);

                            //MessageBox.Show(sb.ToString());
                            var connection = new SqlConnection(sConnStr);
                            var cmdCommand = new SqlCommand(sb.ToString(), connection);
                            cmdCommand.Parameters.Add("@" + sID_Filled, SqlDbType.Int);
                            cmdCommand.Parameters["@" + sID_Filled].Value = _id;
                            
                            connection.Open();
                            txt_Common.Text = cmdCommand.ExecuteScalar().ToString();
                            connection.Close();

                        }
                        break;
                }
                if (SelectedValueChanged != null)
                {
                    SelectedValueChanged(this);
                }
            }
        }

        private int SelectId(string strBeg)
        {

            var sb = new StringBuilder();
            sb.Append("SELECT ");
            sb.Append(sID_Filled);
            sb.Append(" FROM ");
            sb.Append(sTable);
            sb.Append(" WITH (NOLOCK) WHERE ");
            sb.Append(sText_Filled);
            sb.Append(" = ");
            sb.Append("@");
            sb.Append(sText_Filled);
            if (OrderBy != "")
                sb.Append(" order by " + OrderBy);

            var connection = new SqlConnection(sConnStr);
            var cmdCommand = new SqlCommand(sb.ToString(), connection);
            cmdCommand.Parameters.Add("@" + sText_Filled, SqlDbType.NVarChar);
            cmdCommand.Parameters["@" + sText_Filled].Value = strBeg;
            
            connection.Open();
            try
            {
                _id = Convert.ToInt32(cmdCommand.ExecuteScalar().ToString());
            }
            catch { _id = 0; }
            connection.Close();

            return _id;
        }

        public void ControlChanged()
        {
            SelectId(txt_Common.Text);

            if (SelectedValueChanged != null)
            {
                SelectedValueChanged(this);
                
            }
    
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Common.Text = string.Empty;
            SelectId(txt_Common.Text);
            ControlChanged();
        }

        private void txt_Common_Validated(object sender, EventArgs e)
        {
            SelectId(txt_Common.Text);
            //ControlChanged();
        }

        private void txt_Common_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
        }

        private void btn_AdvView_Click(object sender, EventArgs e)
        {
            Form f;
            f = this.FindForm();

            Point LocationPoint = this.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X;
            int ypos = LocationPoint.Y + this.Height;
            Point _location = new Point(xpos, ypos);

            frm_Common popup = new frm_Common();
            popup.cmb_CommonOne = this;
            popup.HeaderText = sTitle;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillData(sCurrentValue);

            txt_Common.Focus();
        }

        private void txt_Common_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter
                || e.KeyCode == Keys.Tab)
            {
                ControlChanged();
            }
        }

        private void txt_Common_TextChanged(object sender, EventArgs e)
        {
            SelectId(txt_Common.Text);
            ControlChanged();
        }
    }
}

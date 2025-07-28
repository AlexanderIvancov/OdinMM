using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace Odin.CMB_Components.ArtCerts
{
    public delegate void ArtCertsEventHandler(object sender);
    
    public partial class cmb_ArtCerts : UserControl
    {
        public event ArtCertsEventHandler CertChanged;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;

        int _certId = 0;
        int _PrevId = 0;

        bool _EnableSearchId = false;
        string _certNum = "";

        bool _isemptycolor = false;

        public bool IsEmptyColor
        {
            get { return _isemptycolor; }
            set
            {
                _isemptycolor = value;
                txt_Cert.StateCommon.Back.Color1 = value == true ? Color.LightPink : Color.White;
            }
        }

        public cmb_ArtCerts()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();

        }

        public string Cert
        {
            get { return txt_Cert.Text; }
            set
            {

                _certNum = value;
                txt_Cert.Text = value;

                CertChanged?.Invoke(this);
            }
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Cert.Text = string.Empty;
        }

        private void btn_AdvView_Click(object sender, EventArgs e)
        {
            Form f;
            f = this.FindForm();

            Point LocationPoint = this.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X;
            int ypos = LocationPoint.Y + this.Height;
            Point _location = new Point(xpos, ypos);

            frm_ArtCerts popup = new frm_ArtCerts();
            popup.cmb_CertOne = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillData(Cert);
        }

        private void txt_Cert_TextChanged(object sender, EventArgs e)
        {
            try { Cert = txt_Cert.Text; }
            catch { }
        }
    }
}

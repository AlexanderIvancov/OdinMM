using Odin.Global_Classes;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Odin.Planning.Controls
{
    public partial class ctl_ArtTotals : UserControl
    {
        public ctl_ArtTotals()
        {
            InitializeComponent();
        }

        #region Variables

        public string HeaderText
        {
            get { return kh_Header.Values.Heading; }
            set { kh_Header.Values.Heading = value; }
        }

        ProgressForm wait;
        frm_Batches frmBatches;

        class_Global glob_Class = new class_Global();
        Plan_BLL BLL = new Plan_BLL();
        DAL_Functions DLL = new DAL_Functions();

        int _articleid = 0;
        int _prevartid = 0;

        public int ArtId
        {
            get { return cmb_Articles1.ArticleId; }
            set
            {
                _articleid = value;
                HeaderText = "Totals for:  " + cmb_Articles1.Article;
                //bwStart(bw_List);
                ShowDets();
            }
        }

        public string Unit
        {
            get { return txt_Unit.Text; }
            set { txt_Unit.Text = value; }
        }

        public double QtyStock
        {
            get {
                try { return Convert.ToDouble(txt_QtyStock1.Text); }
                catch { return 0; }
            }
            set {
                //Invoke(new Action(() =>
                //{
                    txt_QtyStock1.Text = value.ToString();
                //}));
                
            }
        }

        public double QtyReserved
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyReserved1.Text); }
                catch { return 0; }
            }
            set { txt_QtyReserved1.Text = value.ToString(); }
        }

        public double QtyAvailable
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyAvailable1.Text); }
                catch { return 0; }
            }
            set {
                //Invoke(new Action(() =>
                //{
                    txt_QtyAvailable1.Text = value.ToString();
                //}));
            }
        }

        public double QtyNeeds
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyNeeds1.Text); }
                catch { return 0; }
            }
            set {
                //Invoke(new Action(() =>
                //{
                    txt_QtyNeeds1.Text = value.ToString();
                //}));
            }
        }

        public double QtyPurchased
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyPurchased1.Text); }
                catch { return 0; }
            }
            set {
                //Invoke(new Action(() =>
                //{
                    txt_QtyPurchased1.Text = value.ToString(); }
            //)); }
        }

        public double QtyAwaiting
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyAwaiting1.Text); }
                catch { return 0; }
            }
            set {
                //Invoke(new Action(() =>
                //{ 
                txt_QtyAwaiting1.Text = value.ToString();}
            //)); }
        }

        public double QtyFreePO
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyFreePO.Text); }
                catch { return 0; }
            }
            set
            {
                txt_QtyFreePO.Text = value.ToString();
            }
           
        }

        public double QtyNeedsCO
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyNeedsCO.Text); }
                catch { return 0; }
            }
            set
            {
                //Invoke(new Action(() =>
                //{
                txt_QtyNeedsCO.Text = value.ToString();
                //}));
            }
        }
        public double QtyNotPlaced
        {
            get
            {
                try { return Convert.ToDouble(txt_NotPlacedStock.Text); }
                catch { return 0; }
            }
            set
            {
                //Invoke(new Action(() =>
                //{
                txt_NotPlacedStock.Text = value.ToString();
                //}));
            }
        }

        public double QtyInProduction
        {
            get
            {
                try { return Convert.ToDouble(txt_InProduction.Text); }
                catch { return 0; }
            }
            set
            {
                //Invoke(new Action(() =>
                //{
                txt_InProduction.Text = value.ToString();
                //}));
            }
        }

        public double QtyQuarantine
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyQuarantine1.Text); }
                catch { return 0; }
            }
            set
            {
                //Invoke(new Action(() =>
                //{
                txt_QtyQuarantine1.Text = value.ToString();
                //}));
            }
        }

        #endregion

        #region Methods

        public void bwStart(DoWorkEventHandler doWork)
        {
            wait = new ProgressForm(frmBatches);

            wait.bwStart(doWork);
        }

        public void bw_List(object sender, DoWorkEventArgs e)
        {
            if (_prevartid != _articleid)
            {
                this.ThreadSafeCall(delegate
                {
                    BLL.ArtIdTotal = ArtId;
                    Unit = cmb_Articles1.Unit;
                    QtyStock = BLL.QtyRest;
                    QtyReserved = BLL.QtyReserved;
                    QtyAvailable = BLL.QtyRest - BLL.QtyReserved;
                    QtyNeeds = BLL.QtyNeeds;
                    QtyPurchased = BLL.QtyPurchased;
                    QtyAwaiting = BLL.QtyRest + BLL.QtyPurchased - BLL.QtyNeeds;
                    QtyFreePO = BLL.QtyFreePO;
                    QtyNotPlaced = BLL.QtyNotPlaced;
                    QtyNeedsCO = BLL.QtyNeedsCO;
                    QtyInProduction = BLL.QtyInProduction;
                    QtyQuarantine = BLL.QtyQuarantine;
                });
                _prevartid = _articleid;
            }
        }

        public void ShowDets()
        {
            BLL.ArtIdTotal = ArtId;
            Unit = cmb_Articles1.Unit;
            QtyStock = BLL.QtyRest;
            QtyReserved = BLL.QtyReserved;
            QtyAvailable = BLL.QtyRest - BLL.QtyReserved;
            QtyNeeds = BLL.QtyNeeds;
            QtyPurchased = BLL.QtyPurchased;
            QtyAwaiting = BLL.QtyRest + BLL.QtyPurchased - BLL.QtyNeeds;
            QtyFreePO = BLL.QtyFreePO;
            QtyNotPlaced = BLL.QtyNotPlaced;
            QtyNeedsCO = BLL.QtyNeedsCO;
            QtyInProduction = BLL.QtyInProduction;
            QtyQuarantine = BLL.QtyQuarantine;
        }

        #endregion

        #region Controls

        private void cmb_Articles1_ArticleChanged(object sender)
        {
            ArtId = cmb_Articles1.ArticleId;
        }

        #endregion


    }
}

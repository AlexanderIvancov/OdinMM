using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odin.Workshop
{
    public partial class ctl_Workplace : UserControl
    {
        public ctl_Workplace()
        {
            InitializeComponent();
        }

        #region Variables

        Processing_BLL BLL = new Processing_BLL();
        int _id;
        public int WorkPlaceID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Workplace
        {
            get { return lbl_Workplace.Text; }
            set { lbl_Workplace.Text = value; }
        }
        public int LaunchID
        {
            get { return cmb_Launches1.LaunchId; }
            set {
                cmb_Launches1.LaunchId = value;
            }
        }

        public string ESL_Barcode
        { get; set; }
        public string COMM_Barcode
        { get; set; }    

        public string Room
        { get; set; }

        int _isvisible = 0;
        public int IsVisible
        {

            get { return _isvisible; }
            set
            {
                _isvisible = value;
                if (_isvisible == 0)
                    kryptonPanel1.Visible = false;
                else
                    kryptonPanel1.Visible = true;
            }
        }

        #endregion

        #region Methods

        public void ClearFields()
        {
            cmb_Launches1.LaunchId = 0;
            txt_CustArticle.Text = "";
            txt_Article.Text = "";
            //BLL.SaveWorkplace(WorkPlaceID, 0);
        }
        #endregion

        #region Controls
        private void cmb_Launches1_LaunchChanged(object sender)
        {
            txt_CustArticle.Text = cmb_Launches1.SecName;
            txt_Article.Text = cmb_Launches1.Article;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }


        #endregion


    }
}

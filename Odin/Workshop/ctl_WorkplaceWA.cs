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
    public partial class ctl_WorkplaceWA : UserControl
    {
        public ctl_WorkplaceWA()
        {
            InitializeComponent();
        }

        #region Variables

        Processing_BLL BLL = new Processing_BLL();
        int _workplaceid;
        int _id = 0;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public int WorkPlaceID
        {
            get { return _workplaceid; }
            set { _workplaceid = value; }
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

        public int FullTime
        {
            get { if (chk_fulltime.Checked == true)
                    return -1;
                else
                    return 0;
            }
            set
            {
                if (value == -1)
                    chk_fulltime.Checked = true;
                else
                    chk_fulltime.Checked = false;
            }
        }

        public double WorkMinutes
        {
            get { try { return Convert.ToDouble(txt_hours.Text); }
                catch { return 0; }
            }
            set { txt_hours.Text = value.ToString(); }
        }

        public string WorkDate
        {
            get { return txt_WorkDate.Value.ToShortDateString(); }
            set
            {
                try { txt_WorkDate.Value = Convert.ToDateTime(value); }
                catch { }
            }
        }

        public int WorkerId
        {
            get { return cmb_Workers.SelectedValue; }
            set { cmb_Workers.SelectedValue = value; }
        }

        #endregion

        #region Methods

        public void ClearFields()
        {
            cmb_Launches1.LaunchId = 0;
            txt_CustArticle.Text = "";
            txt_Article.Text = "";
            WorkerId = 0;
            txt_WorkDate.Value = System.DateTime.Now;
            WorkMinutes = 0;
            FullTime = -1;

            //BLL.SaveWorkplace(WorkPlaceID, 0);
        }

        public void EnableHours()
        {
            if (FullTime == -1)
                txt_hours.Enabled = false;
            else
                txt_hours.Enabled = true;
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

        private void chk_fulltime_CheckedChanged(object sender, EventArgs e)
        {
            EnableHours();
        }
    }
}

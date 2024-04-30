using ComponentFactory.Krypton.Toolkit;
using System;

namespace Odin.CMB_Components.AddSerialFreezed
{
    public partial class frm_AddSerialFreezed : KryptonForm
    {
        public frm_AddSerialFreezed()
        {
            InitializeComponent();
        }

        #region Variables
        
        public string Position
        {
            get { return txt_pos.Text; }
            set { txt_pos.Text = value; }
        }

        public int BatchId
        {
            get { return cmb_Batches1.BatchId; }
            set { cmb_Batches1.BatchId = value; }
        }

        public int LaunchId
        {
            get { return cmb_Launches1.LaunchId; }
            set { cmb_Launches1.LaunchId = value; }
        }

        public int FreezedReasonId
        {
            get { return cmb_FreezedReason1.FreezedReasonId; }
            set { cmb_FreezedReason1.FreezedReasonId = value; }
        }

        public string Serial
        {
            get { return txt_Serial1.Text; }
            set { txt_Serial1.Text = value; }
        }

        public int StageId
        {
            get { return cmb_BatchStages1.StageId; }
            set { cmb_BatchStages1.StageId = value; }
        }

        #endregion

        //private void cmb_Firms1_FirmsChanged(object sender)
        //{
        //    cmb_Address1.FirmId = cmb_Firms1.FirmId;
        //}

        //public void CheckEmpty()
        //{
        //    btn_OK.Enabled = Qty > 0
        //        && ConfDate != "";
        //}

        //private void txt_Qty_TextChanged(object sender, EventArgs e)
        //{
        //    CheckEmpty();
        //}

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            this.Text = string.Empty;
        }
    }
}

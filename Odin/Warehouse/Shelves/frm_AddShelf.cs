using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace Odin.Warehouse.Shelves
{
    public partial class frm_AddShelf : KryptonForm
    {
        public frm_AddShelf()
        {
            InitializeComponent();
        }


        #region Variables

        public string HeaderText
        { get 
                { return this.Text; }
                set{ this.Text = value; }
        }

        public int Id
        { get; set; }

        public string Place
        {
            get { return txt_Place.Text; }
            set { txt_Place.Text = value; }
        }
        public string Description
        {
            get { return txt_Description.Text; }
            set { txt_Description.Text = value; }
        }

        public int DeptId
        {
            get { return cmb_Department1.DeptId; }
            set { cmb_Department1.DeptId = value; }
        }

        public int RespPersonId
        {
            get { return cmb_Users1.UserId; }
            set { cmb_Users1.UserId = value; }
        }
        public int FirmId
        {
            get { return cmb_Firms1.FirmId; }
            set { cmb_Firms1.FirmId = value; }
        }
        public int AddressId
        {
            get { return cmb_Address1.AddressId; }
                set{ cmb_Address1.AddressId = value; }
            
        }

        public int IsProduction
        {
            get {
                return chk_IsProduction.CheckState == CheckState.Checked ? -1 : 0;
            }
            set { chk_IsProduction.CheckState = value == -1 ? CheckState.Checked : CheckState.Unchecked;
            }
        }

        public int Quarantine
        {
            get
            {
                return chk_Quarantine.CheckState == CheckState.Checked ? -1 : 0;
            }
            set
            {
                chk_Quarantine.CheckState = value == -1 ? CheckState.Checked : CheckState.Unchecked;
            }
        }

        public int OwnerId
        {
            get { return cmb_Firms2.FirmId; }
            set { cmb_Firms2.FirmId = value; }
        }

        #endregion
        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Place.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Description.Text = string.Empty;
        }

        private void cmb_Firms1_FirmsChanged(object sender)
        {
            cmb_Address1.FirmId = cmb_Firms1.FirmId;
        }
    }
}

using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace Odin.Register.Companies
{
    public partial class frm_AddAddress : KryptonForm
    {
        public frm_AddAddress()
        {
            InitializeComponent();
        }

        public int Id
        { get; set; }
        public int FirmId
        { get; set; }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }
        #region Variables

        public int CountryId
        {
            get { return cmb_Countries1.CountryId; }
            set { cmb_Countries1.CountryId = value; }
        }

        public string RegionState
        {
            get { return txt_Region.Text; }
            set { txt_Region.Text = value; }
        }

        public string City
        {
            get { return txt_City.Text; }
            set { txt_City.Text = value; }
        }

        public string ZIPcode
        {
            get { return txt_ZIP.Text; }
            set { txt_ZIP.Text = value; }
        }

        public string Street
        {
            get { return txt_Street.Text; }
            set { txt_Street.Text = value; }
        }

        public string House
        {
            get { return txt_House.Text; }
            set { txt_House.Text = value; }
        }

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }

        public int LegalAddress
        {
            get { if (chk_Legal.CheckState == CheckState.Checked)
                    return -1;
                else
                    return 0;
            }
            set { if (value == -1)
                    chk_Legal.CheckState = CheckState.Checked;
                else
                    chk_Legal.CheckState = CheckState.Unchecked;
            }
        }

        public int ActualAddress
        {
            get
            {
                if (chk_ActAddress.CheckState == CheckState.Checked)
                    return -1;
                else
                    return 0;
            }
            set
            {
                if (value == -1)
                    chk_ActAddress.CheckState = CheckState.Checked;
                else
                    chk_ActAddress.CheckState = CheckState.Unchecked;
            }
        }

        public int DefaultDelivPlace
        {
            get
            {
                if (chk_DelivPlace.CheckState == CheckState.Checked)
                    return -1;
                else
                    return 0;
            }
            set
            {
                if (value == -1)
                    chk_DelivPlace.CheckState = CheckState.Checked;
                else
                    chk_DelivPlace.CheckState = CheckState.Unchecked;
            }
        }

        public int IsActive
        {
            get
            {
                if (chk_IsActive.CheckState == CheckState.Checked)
                    return -1;
                else
                    return 0;
            }
            set
            {
                if (value == -1)
                    chk_IsActive.CheckState = CheckState.Checked;
                else
                    chk_IsActive.CheckState = CheckState.Unchecked;
            }
        }


        #endregion

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Region.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_City.Text = string.Empty;
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_ZIP.Text = string.Empty;
        }

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            txt_Street.Text = string.Empty;
        }

        private void buttonSpecAny5_Click(object sender, EventArgs e)
        {
            txt_House.Text = string.Empty;
        }

        private void buttonSpecAny6_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }
    }
}

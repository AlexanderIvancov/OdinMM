using ComponentFactory.Krypton.Toolkit;
using System;

namespace Odin.Global_Classes
{
    public partial class frm_cmbText : KryptonForm
    {
        public frm_cmbText()
        {
            InitializeComponent();
        }

        bool _showdate = false;
        public bool ShowDate
        {
            get { return _showdate; }
            set
            {
                _showdate = value;

                if (value == true)
                {
                    txt_Date.Visible = true;
                    lbl_Text2.Visible = true;
                }
                else
                {
                    txt_Date.Visible = false;
                    lbl_Text2.Visible = false;
                }
            }
        }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public string FormText
        {
            get { return txt_Text.Text ; }
            set { txt_Text.Text = value; }
        }

        public int Id
        { get; set; }

        public string LabelText
        {
            get { return lbl_Text.Text; }
            set { lbl_Text.Text = value; }
        }

        public string LabelText2
        {
            get { return lbl_Text2.Text; }
            set { lbl_Text2.Text = value; }
        }


        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Text.Text = string.Empty;
        }

        private void frm_cmbText_Load(object sender, EventArgs e)
        {
            txt_Text.Focus();
        }

        private void frm_cmbText_Activated(object sender, EventArgs e)
        {
            txt_Text.Focus();
        }

        public string FormDate
        {
            get
            {
                if (txt_Date.Value == null)
                    return "";
                else
                    return txt_Date.Value.ToString().Trim();
            }
            set
            {
                try
                {
                    txt_Date.Value = Convert.ToDateTime(value);
                }
                catch { txt_Date.Value = null; }
            }
        }



        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_Date.Value = System.DateTime.Now;
        }

        private void txt_Date_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_Date.Value = txt_Date.Value == null ? System.DateTime.Now : txt_Date.Value;
        }
    }
}

using Odin.Global_Classes;
using System;
using System.Windows.Forms;


namespace Odin.CustomControls
{
    public partial class CheckLabel : UserControl
    {
        class_Global globClass = new class_Global();
        TextBox _txt_Name;
        MaskedTextBox _txt_MaskName;

        public TextBox txt_Name
        {
            get { return _txt_Name; }
            set
            {
                _txt_Name = value;

                if (value != null)
                {
                    _txt_Name.TextChanged += delegate (object _sender, EventArgs _e)
                    {
                        lbl_Check.Text = globClass.NES(_txt_Name.Text) != "" ? "" : "*";
                    };

                }
            }
        }

        public MaskedTextBox txt_MaskName
        {
            get { return _txt_MaskName; }
            set
            {
                _txt_MaskName = value;

                if (value != null)
                {
                    _txt_MaskName.TextChanged += delegate (object _sender, EventArgs _e)
                    {
                        lbl_Check.Text = globClass.NES(_txt_MaskName.Text) != "" ? "" : "*";
                    };

                }
            }
        }

        public CheckLabel()
        {
            InitializeComponent();
        }
        private void CheckLabel_Load(object sender, EventArgs e)
        {
            if (_txt_Name != null)
            {
                lbl_Check.Text = globClass.NES(_txt_Name.Text) != "" ? "" : "*";

            }

            if (_txt_MaskName != null)
            {
                lbl_Check.Text = globClass.NES(_txt_MaskName.Text) != "" ? "" : "*";

            }
        }
    }
}

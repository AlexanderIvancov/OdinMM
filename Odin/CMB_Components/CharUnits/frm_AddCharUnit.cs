using ComponentFactory.Krypton.Toolkit;
using System;

namespace Odin.CMB_Components.CharUnits
{
    public partial class frm_AddCharUnit : KryptonForm
    {
        public frm_AddCharUnit()
        {
            InitializeComponent();
        }
        #region Variables

        public int Id
        { get; set; }
        public string Unit
        {
            get { return txt_Unit.Text; }
            set { txt_Unit.Text = value; }
        }

        public string Description
        {
            get { return txt_Description.Text; }
            set { txt_Description.Text = value; }
        }

        public int UnitDecs
        {
            get { return Convert.ToInt32(nm_Decs.Value); }
            set { nm_Decs.Value = value; }
        }

        public string UnitLat
        {
            get { return txt_UnitLat.Text; }
            set { txt_UnitLat.Text = value; }
        }

        public double CoefConv
        {
            get
            {
                try { return Convert.ToDouble(txt_Coeficient.Text); }
                catch { return 1; }
            }
            set { txt_Coeficient.Text = value.ToString(); }
        }

        public int BaseUnitid
        {
            get { return cmb_CharUnits1.UnitId; }
            set { cmb_CharUnits1.UnitId = value; }
        }
        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Description.Text = string.Empty;
        }

        #endregion

    }
}

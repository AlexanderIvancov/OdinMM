using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ComponentFactory.Krypton.Ribbon;

namespace Odin.CMB_Components.Package
{
    public partial class frm_AddPackage : KryptonForm
    {
        public frm_AddPackage()
        {
            InitializeComponent();
        }

        #region Variables

        public int Id
        { get; set; }
        public string Package
        {
            get { return txt_Package.Text; }
            set { txt_Package.Text = value; }
        }

        public double VolumeWeight
        {
            get {
                try { return Convert.ToDouble(txt_VolWeight.Text); }
                catch { return 0; }
            }
            set { txt_VolWeight.Text = value.ToString(); }
        }
        #endregion

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Package.Text = string.Empty;
        }
    }
}

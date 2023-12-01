using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace Odin.CMB_Components.Countries
{
    public partial class frm_AddCountry : KryptonForm
    {
        public frm_AddCountry()
        {
            InitializeComponent();
        }
        #region Variables

        public int Id
        { get; set; }
        public string Country
        {
            get { return txt_Country.Text; }
            set { txt_Country.Text = value; }
        }

        public string Abbrev
        {
            get { return txt_Abbrev.Text; }
            set { txt_Abbrev.Text = value; }

        }
        
        public int VAT
        {
            get { try { return Convert.ToInt32(txt_VAT.Text); }
                catch { return 0; }
            }
            set {
                txt_VAT.Text = value.ToString();
            }
        }    
            
        public int EU
        {
            get { if (chk_Eur.CheckState == CheckState.Checked)
                    return -1;
                else
                    return 0;
            }
            set { if (value == 0)
                    chk_Eur.CheckState = CheckState.Unchecked;
                else
                    chk_Eur.CheckState = CheckState.Checked;
            }    
        }

        public int CurId
        {
            get { return cmb_Currency1.CurrencyId; }
            set { cmb_Currency1.CurrencyId = value; }
        }
        #endregion

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            Country = string.Empty;
        }
    }
}

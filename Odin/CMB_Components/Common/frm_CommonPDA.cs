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
using Odin.Global_Classes;
using Odin.CMB_Components.BLL;

namespace Odin.CMB_Components.Common
{
    public partial class frm_CommonPDA : KryptonForm
    {
        public frm_CommonPDA()
        {
            InitializeComponent();
        }

        public frm_CommonPDA(cmb_Common cmb)
        {
            InitializeComponent();
            f = new cmb_Common();
            cmb = f;
        }

        public string HeaderText
        {
            get { return kryptonHeaderGroup1.ValuesPrimary.Heading; }
            set { kryptonHeaderGroup1.ValuesPrimary.Heading = value; }
        }

        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        bool _showingModal = false;
        cmb_Common f;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public void ChangeCMBElements()
        {
            try
            {
                ((cmb_CommonPDA)cmb_CommonPDAOne).sCurrentValue = gv_List.CurrentRow.Cells[1].Value.ToString();
                ((cmb_CommonPDA)cmb_CommonPDAOne).SelectedValue = Convert.ToInt32(gv_List.CurrentRow.Cells[0].Value);
            }
            catch { }
        }

        public void FillData(string strBeg)
        {
            try
            {
                var sb = new StringBuilder();
                sb.Append("SELECT ");
                sb.Append(cmb_CommonPDAOne.sID_Filled);
                sb.Append(", ");
                sb.Append(cmb_CommonPDAOne.sText_Filled);
                sb.Append(" as name FROM ");
                sb.Append(cmb_CommonPDAOne.sTable);

                sb.Append(string.Format(" WITH (NOLOCK) WHERE {0} LIKE '%{1}%' ",
                    cmb_CommonPDAOne.sText_Filled, cmb_CommonPDAOne.sCurrentValue));

                if (cmb_CommonPDAOne.OrderBy != "")
                    sb.Append(" ORDER BY " + cmb_CommonPDAOne.OrderBy);
                //else
               //     sb.Append(" ORDER BY name");
                            
                gv_List.DataSource = Helper.QueryDTstring(sb.ToString());
                
                gv_List.Columns[0].Visible = false;
                gv_List.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gv_List.Rows[0].Frozen = true;
            }
            catch { }
        }

        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            ChangeCMBElements();
        }
    }
}

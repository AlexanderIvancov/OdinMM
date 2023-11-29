using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using System;
using System.Text;
using System.Windows.Forms;

namespace Odin.CMB_Components.Common
{
    public partial class frm_Common : KryptonForm
    {
        public frm_Common()
        {
            InitializeComponent();
        }

        public frm_Common(cmb_Common cmb)
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
                ((cmb_Common)cmb_CommonOne).sCurrentValue = gv_List.CurrentRow.Cells[1].Value.ToString();
                ((cmb_Common)cmb_CommonOne).SelectedValue = Convert.ToInt32(gv_List.CurrentRow.Cells[0].Value);
            }
            catch { }
        }

        public void FillData(string strBeg)
        {
            try
            {
                var sb = new StringBuilder();
                sb.Append("SELECT ");
                sb.Append(cmb_CommonOne.sID_Filled);
                sb.Append(", ");
                sb.Append(cmb_CommonOne.sText_Filled);
                sb.Append(" as name FROM ");
                sb.Append(cmb_CommonOne.sTable);

                sb.Append(string.Format(" WITH (NOLOCK) WHERE {0} LIKE '%{1}%' ",
                    cmb_CommonOne.sText_Filled, cmb_CommonOne.sCurrentValue));

                if (cmb_CommonOne.OrderBy != "")
                    sb.Append(" ORDER BY " + cmb_CommonOne.OrderBy);
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

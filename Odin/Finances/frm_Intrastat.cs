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
using Odin.Global_Classes;
using Odin.Tools;
using System.Data.SqlClient;
using WeifenLuo.WinFormsUI.Docking;
using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Workspace;
using System.Threading;
using Odin.Register;
using Odin.CMB_Components.BLL;

namespace Odin.Finances
{
    public partial class frm_Intrastat : BaseForm
    {
        public frm_Intrastat()
        {
            InitializeComponent();
            //ED = new ExportData(this.gv_List, "Payments.xls", this.Name);
        }

        #region Variables

        ExportData ED;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        class_Global glob_Class = new class_Global();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        Helper MyHelper = new Helper();
        Finances_BLL Bll = new Finances_BLL();


        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";
        public int ControlWidth = 250;

        #endregion

        #region Methods

        public void bw_ListIncomes(object sender, DoWorkEventArgs e)
        {
                 
            var data = Finances_BLL.getIntrastatIncome(txt_DateFrom.Value == null ? "" : txt_DateFrom.Value.ToString().Trim(),
                                            txt_DateTill.Value == null ? "" : txt_DateTill.Value.ToString().Trim());

            gv_IncomeList.ThreadSafeCall(delegate
            {
                gv_IncomeList.AutoGenerateColumns = false;
                bs_IncomeList.DataSource = data;
                gv_IncomeList.DataSource = bs_IncomeList;
            });


            bn_IncomeList.ThreadSafeCall(delegate
            {
                bn_IncomeList.BindingSource = bs_IncomeList;
            });
        }

        public void bw_ListOutcomes(object sender, DoWorkEventArgs e)
        {
            var data = Finances_BLL.getIntrastatOutcome(txt_DateFrom.Value == null ? "" : txt_DateFrom.Value.ToString().Trim(),
                                         txt_DateTill.Value == null ? "" : txt_DateTill.Value.ToString().Trim());

            gv_OutcomeList.ThreadSafeCall(delegate
            {
                gv_OutcomeList.AutoGenerateColumns = false;
                bs_OutcomeList.DataSource = data;
                gv_OutcomeList.DataSource = bs_OutcomeList;

            });


            bn_OutcomeList.ThreadSafeCall(delegate
            {
                bn_OutcomeList.BindingSource = bs_OutcomeList;
            });
        }


        #endregion

        #region Controls
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            if (dn_Pages.SelectedPage == pg_Income)
            {
                DataGridViewColumn oldColumn = gv_IncomeList.SortedColumn;
                var dir = Helper.SaveDirection(gv_IncomeList);

                bwStart(bw_ListIncomes);

                Helper.RestoreDirection(gv_IncomeList, oldColumn, dir);
            }
            else
            {
                DataGridViewColumn oldColumn = gv_OutcomeList.SortedColumn;
                var dir = Helper.SaveDirection(gv_OutcomeList);

                bwStart(bw_ListOutcomes);
                Helper.RestoreDirection(gv_OutcomeList, oldColumn, dir);
            }

        }

        #endregion


    }
}

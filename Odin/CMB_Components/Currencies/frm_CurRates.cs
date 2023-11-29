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
using System.Xml.Linq;
using System.Net;

namespace Odin.CMB_Components.Currencies
{
    
    public partial class frm_CurRates : KryptonForm
    {
        public frm_CurRates()
        {
            InitializeComponent();
        }
        #region Variables

        class_Global glob_Class = new class_Global();

        public int CurID
        {
            get { return cmb_Currency1.CurrencyId; }
            set { cmb_Currency1.CurrencyId = value; }
        }

        #endregion

        #region Methods

        private void BindData()
        {

            var data = DAL_Functions.CurrencyRates(CurID, txt_DateFrom.Value.ToString(),
                                                   txt_DateTill.Value.ToString());
            gv_List.ThreadSafeCall(delegate
            {

                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;
                bn_List.BindingSource = bs_List;
            });
            //gv_List.DataSource = data;
        }
        private void ReBindData(object sender)
        {
            BindData();
        }
        #endregion

        #region Controls

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_AddCurRate frm = new frm_AddCurRate();
            frm.HeaderText = "Add new currency rate for: " + cmb_Currency1.Currency;
            frm.CurId = cmb_Currency1.CurrencyId;
            frm.CurDate = System.DateTime.Now.ToShortDateString();
            frm.CheckEmpty();

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                DAL_Functions.AddCurrencyRate(frm.CurId, frm.CurDate, frm.Rate, frm.UnitCoef);
                BindData();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_Id"].Value); }
            catch { }

            if (_id != 0)
            {
                frm_AddCurRate frm = new frm_AddCurRate();
                frm.HeaderText = "Edit rate for: " + gv_List.CurrentRow.Cells["cn_Currency"].Value.ToString() ;
                frm.Id = _id;
                frm.CurId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_CurId"].Value);
                frm.UnitCoef = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_Coef"].Value);
                frm.Rate = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_CurRate"].Value);
                frm.CurDate = gv_List.CurrentRow.Cells["cn_Date"].Value.ToString();

                var dialogResult = frm.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    DAL_Functions.EditCurrencyRate(frm.Id, frm.CurId, frm.CurDate, frm.Rate, frm.UnitCoef);
                    BindData();
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_Id"].Value); }
            catch { }

            if (_id != 0
                && glob_Class.DeleteConfirm() == true)
            {
                DAL_Functions.DeleteCurrencyRate(_id);
                BindData();
            }
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            frm_ImportCurRate frm = new frm_ImportCurRate();
            frm.RateSaving += new CurRateSavingEventHandler(ReBindData);
            frm.Show();
        }

        #endregion

    }
}

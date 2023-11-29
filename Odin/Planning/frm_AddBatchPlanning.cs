using ComponentFactory.Krypton.Toolkit;
using System;

namespace Odin.Planning
{
    public partial class frm_AddBatchPlanning : KryptonForm
    {
        public frm_AddBatchPlanning()
        {
            InitializeComponent();
        }

        #region Variables

        public string HeaderText
        {
            get
            {
                return this.Text;
            }
            set { this.Text = value; }

        }

        public int BatchId
        {
            get { return cmb_Batches1.BatchId; }
            set { cmb_Batches1.BatchId = value; }
        }

        public double Qty
        {
            get
            {
                try { return Convert.ToDouble(txt_Qty.Text); }
                catch { return 0; }
            }
            set { txt_Qty.Text = value.ToString(); }
        }

        public string PlanDate
        {
            get { return txt_PlanDate.Value.ToShortDateString(); }
            set
            {
                try { txt_PlanDate.Value = Convert.ToDateTime(value); }
                catch { }
            }
        }

        public DateTime PlanDateD
        {
            get { return Convert.ToDateTime(txt_PlanDate.Value); }
            set { txt_PlanDate.Value = value; }
        }

        public string Week
        {
            get { return cmb_Week1.Week; }
            set { cmb_Week1.Week = value; }
        }
        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }
        #endregion

        private void txt_PlanDate_ValueChanged(object sender, EventArgs e)
        {
            Week = "W" + (cmb_Week1.WeekNumber(PlanDateD).ToString().Length == 1 ? "0" + cmb_Week1.WeekNumber(PlanDateD).ToString() : cmb_Week1.WeekNumber(PlanDateD).ToString()) + "." + PlanDateD.Year.ToString();
        }
    }
}

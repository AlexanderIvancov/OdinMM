using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Workspace;
using ComponentFactory.Krypton.Toolkit;


namespace Odin.Global_Classes
{
    public partial class frm_AddPOConfWizard : KryptonForm
    {
        public frm_AddPOConfWizard()
        {
            InitializeComponent();
        }

        public string Date
        {
            get { return txt_Date.Value.ToShortDateString(); }
            set
            {
                try { txt_Date.Value = Convert.ToDateTime(value); }
                catch { }
            }
        }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public string ConfType
        {
            get { return cmb_ConfType.Text; }
            set { cmb_ConfType.Text = value; }
        }

        public void FillType()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Txt", typeof(string)));

            dt.Rows.Add(dt.NewRow());
            dt.Rows.Add(dt.NewRow());
            dt.Rows.Add(dt.NewRow());
            dt.Rows.Add(dt.NewRow());

            dt.Rows[0][0] = "";
            dt.Rows[1][0] = "Firm";
            dt.Rows[2][0] = "Estimated";
            dt.Rows[3][0] = "Not confirmed";

            cmb_ConfType.DataSource = dt;
            cmb_ConfType.DisplayMember = "Txt";
            cmb_ConfType.ValueMember = "Txt";

            ConfType = "Firm";
        }

    }
}

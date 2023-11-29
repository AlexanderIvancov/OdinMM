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
using Odin.CMB_Components.BLL;

namespace Odin.Warehouse.StockIn
{
    public delegate void LabelsMergedEventHandler(object sender);

    public partial class frm_MergeLabels : KryptonForm
    {
        public frm_MergeLabels()
        {
            InitializeComponent();
        }

        #region Variables

        public event LabelsMergedEventHandler LabelsMerged;

        #endregion


    }
}

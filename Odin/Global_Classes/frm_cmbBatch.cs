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

namespace Odin.Global_Classes
{
    public partial class frm_cmbBatch : KryptonForm
    {
        public frm_cmbBatch()
        {
            InitializeComponent();
        }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public int BatchId
        {
            get { return cmb_Batches1.BatchId; }
            set { cmb_Batches1.BatchId = value; }
        }

        public string Batch
        {
            get { return cmb_Batches1.Batch; }
            set { cmb_Batches1.Batch = value; }
        }

        public int IsActive
        {
            get { return cmb_Batches1.IsActive; }
        }

    }
}

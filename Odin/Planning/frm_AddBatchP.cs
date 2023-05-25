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
namespace Odin.Planning
{
    public delegate void BatchSavedPEventHandler(object sender);
    public partial class frm_AddBatchP : KryptonForm
    {
        public frm_AddBatchP()
        {
            InitializeComponent();
        }

        public event BatchSavedPEventHandler BatchSaved;
               
        private void ctl_CreatBatchDetsP1_SaveBatch(object sender)
        {
            if (BatchSaved != null)
            {
                BatchSaved(this);
            }
        }
    }
}

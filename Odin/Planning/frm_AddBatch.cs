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
    public delegate void BatchSavedEventHandler(object sender);
    public partial class frm_AddBatch : KryptonForm
    {
        public frm_AddBatch()
        {
            InitializeComponent();
        }

        public event BatchSavedEventHandler BatchSaved;
                
        private void ctl_CreatBatchDets1_SaveBatch(object sender)
        {
            if (BatchSaved != null)
            {
                BatchSaved(this);
            }
        }
        
    }
}

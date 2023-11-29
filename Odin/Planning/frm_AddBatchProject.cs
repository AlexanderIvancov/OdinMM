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
    public delegate void BatchProjectSavedEventHandler(object sender);

    public partial class frm_AddBatchProject : KryptonForm
    {
        public frm_AddBatchProject()
        {
            InitializeComponent();
        }

        public event BatchProjectSavedEventHandler ProjectSaved;

        private void ctl_CreatBatchDets1_SaveBatch(object sender)
        {
            if (ProjectSaved != null)
            {
                ProjectSaved(this);
            }
        }

    }
}

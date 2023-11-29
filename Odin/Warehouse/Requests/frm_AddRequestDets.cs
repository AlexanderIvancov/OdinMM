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

namespace Odin.Warehouse.Requests
{
    public delegate void RequestDetsSavedEventHandler(object sender);
    public partial class frm_AddRequestDets : KryptonForm
    {
        public frm_AddRequestDets()
        {
            InitializeComponent();
        }

        public event RequestDetsSavedEventHandler RequestDetsSaved;

        private void ctl_CreatReqDets1_SaveRequest(object sender)
        {
            if (RequestDetsSaved != null)
                RequestDetsSaved(this);
        }
    }
}

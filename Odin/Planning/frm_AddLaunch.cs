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
    public delegate void LaunchSavedEventHandler(object sender);

    public partial class frm_AddLaunch : KryptonForm
    {
        public frm_AddLaunch()
        {
            InitializeComponent();
        }

        public event LaunchSavedEventHandler LaunchSaved;

        private void ctl_CreatLaunchDets1_SaveLaunch(object sender)
        {
            if (LaunchSaved != null)
                LaunchSaved(this);
        }
    }
}

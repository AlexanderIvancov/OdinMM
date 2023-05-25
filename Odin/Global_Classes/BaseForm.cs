using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
namespace Odin.Global_Classes
{
    public partial class BaseForm : DockContent
    {
        ProgressForm wait;

        public BaseForm()
        {
            wait = new ProgressForm(this);
        }

        public void bwStart(DoWorkEventHandler doWork)
        {
            wait.bwStart(doWork);
        }
    }
}

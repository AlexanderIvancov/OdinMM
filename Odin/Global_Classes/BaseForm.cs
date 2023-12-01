using System.ComponentModel;
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

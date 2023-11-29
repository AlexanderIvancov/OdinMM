using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
namespace Odin.Global_Classes
{
    public class SyncBindingSource : BindingSource
    {
        private SynchronizationContext syncContext;
        public SyncBindingSource()
        {
            syncContext = SynchronizationContext.Current;
        }
        protected override void OnListChanged(ListChangedEventArgs e)
        {
            if (syncContext != null)
                syncContext.Send(_ => base.OnListChanged(e), null);
            else
                base.OnListChanged(e);
        }
    }
}

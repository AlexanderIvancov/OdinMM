using System;
using System.Windows.Forms;

namespace Odin.Global_Classes
{
    public static class ThreadHelper
    {
        /// <summary> 
        /// Invokes MethodInvoker for Control
        /// </summary> 
        public static void ThreadSafeCall(this Control control, Action method)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(method);
            }
            else
            {
                method();
            }
        }
    }
}

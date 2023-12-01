using System.Drawing;
using System.Windows.Forms;

namespace Odin.Global_Classes
{
    public partial class frm_Wait : Form
    { 

        public frm_Wait()
        {
            InitializeComponent();

            if (!this.IsHandleCreated)
            {
                CreateHandle();
            }

            this.TransparencyKey = Color.WhiteSmoke;
            this.BackColor = Color.WhiteSmoke;
        }

        public void Start()
        {
            circularProgressControl1.Start(); //circularProgressControl1.Invoke(new MethodInvoker(Start1));
        }
        public void Stop()
        {
            circularProgressControl1.Stop(); //circularProgressControl1.Invoke(new MethodInvoker(Stop1));
        }
    }
}

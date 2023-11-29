using System.ComponentModel;
using System.Windows.Forms;

namespace Odin.Global_Classes
{
    public class ProgressForm
    {
        private frm_Wait m_fmProgress = null;
        private const string processingCancelled = "Processing cancelled.";

        private Form frm = null;

        public ProgressForm(Form Frm)
        {
            frm = Frm;
        }

        public void bwStart(DoWorkEventHandler doWork)
        {

            // Create a background thread
            var bw = new BackgroundWorker();
            bw.DoWork += doWork;
            bw.RunWorkerCompleted += bw_RunWorkerCompleted;

            // Create a progress form on the UI thread
            m_fmProgress = new frm_Wait();
            m_fmProgress.Start();
            // Kick off the Async thread
            bw.RunWorkerAsync();

            // Lock up the UI with this modal progress form.
            m_fmProgress.ShowDialog(frm);
            m_fmProgress = null;
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Hide the Progress Form
            if (m_fmProgress != null)
            {
                m_fmProgress.Stop();
                m_fmProgress.Close();
                m_fmProgress = null;
            }

            // Check to see if an error occured in the 
            // background process.
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
                return;
            }

            // Check to see if the background process was cancelled.
            if (e.Cancelled)
            {
                MessageBox.Show(processingCancelled);
                return;
            }

        }

    }
}


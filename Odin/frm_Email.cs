using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections;
using System.Windows.Forms;

namespace Odin
{
    public partial class frm_Email : KryptonForm
    {
        public frm_Email()
        {
            InitializeComponent();
        }

        #region Variables
        ArrayList alAttachments;
        public string From
        {
            get { return txt_From.Text; }
            set { txt_From.Text = value; }
        }
        public string To
        {
            get { return txt_To.Text; }
            set { txt_To.Text = value; }
        }
        public string Message
        {
            get { return txt_Message.Text; }
            set { txt_Message.Text = value; }
        }
        public string Attachments
        {
            get { return txt_Attachments.Text; }
            set { txt_Attachments.Text = value; }
        }
        public string Subject
        {
            get { return txt_Subject.Text; }
            set { txt_Subject.Text = value; }
        }

        #endregion
        private void btn_Attach_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] arr = openFileDialog1.FileNames;
                    alAttachments = new ArrayList();
                    string _Attachments = string.Empty;
                    alAttachments.AddRange(arr);

                    foreach (string s in alAttachments)
                    {
                        _Attachments += s + "; ";
                    }

                    Attachments = Attachments + _Attachments;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }



    }
}

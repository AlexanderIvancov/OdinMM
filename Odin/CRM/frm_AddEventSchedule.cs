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

namespace Odin.CRM
{
    public delegate void EventScheduleSavingEventHandler(object sender);
    public partial class frm_AddEventSchedule : KryptonForm
    {
        public frm_AddEventSchedule()
        {
            InitializeComponent();
        }

        #region Variables

        public event EventScheduleSavingEventHandler EventScheduleSaving;
        OpenFileDialog openFileDialogPreview = new OpenFileDialog();

        public int Id
        { get; set; }
        public int EventId
        { get; set; }

        int _FirmId;
        public int FirmId
        {
            get { return _FirmId; }
            set
            {
                _FirmId = value;
            }
        }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

       
        public string Action
        {
            get { return txt_Action.Text; }
            set { txt_Action.Text = value; }

        }

       
        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }

        public string EventDate
        {
            get
            {
                if (txt_EventDate.Value == null)
                    return "";
                else
                    return txt_EventDate.Value.ToString();
            }
            set
            {
                try
                {
                    txt_EventDate.Value = Convert.ToDateTime(value);
                }
                catch { txt_EventDate.Value = null; }
            }
        }

        
        public string ExecDate
        {
            get
            {
                if (txt_ExecDate.Value == null)
                    return "";
                else
                    return txt_ExecDate.Value.ToString();
            }
            set
            {
                try
                {
                    txt_ExecDate.Value = Convert.ToDateTime(value);
                }
                catch { txt_ExecDate.Value = null; }
            }
        }

        public string RespPerson
        {
            get { return cmb_RespPerson.sCurrentValue; }
            set { cmb_RespPerson.sCurrentValue = value; }
        }
               
        public string State
        {
            get { return cmb_State.sCurrentValue; }
            set { cmb_State.sCurrentValue = value; }
        }

        public int StateId
        {
            get { return cmb_State.SelectedValue; }
            set { cmb_State.SelectedValue = value; }
        }

        public string Result
        {
            get { return txt_Result.Text; }
            set { txt_Result.Text = value; }
        }

      

        #endregion

        #region Methods

        private void InitFileDialog()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            openFileDialogPreview.InitialDirectory = path;

            openFileDialogPreview.DefaultExt = "doc";
            openFileDialogPreview.Filter = "Excel Files (*.xls;*.xlsx)|*.xls; *.xlsx|Word Files (*.doc;*.docx)|*.doc;*.docx|" +
                "RTF Files (*.rtf)|*.rtf|PDF Files (*.pdf)|*.pdf|All files (*.*)|*.*";

            openFileDialogPreview.FilterIndex = 5;
            openFileDialogPreview.RestoreDirectory = true;
        }

        public void FillDate()
        {
            txt_ExecDate.Value = null;
        }
        #endregion

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            txt_Action.Text = string.Empty;
        }

        private void buttonSpecAny6_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }

      
              
        private void buttonSpecAny5_Click(object sender, EventArgs e)
        {
            txt_Result.Text = string.Empty;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (EventScheduleSaving != null)
                EventScheduleSaving(this);
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_ExecDate_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_ExecDate.Value = txt_ExecDate.Value == null ? System.DateTime.Now : txt_ExecDate.Value;
        }
    }
}

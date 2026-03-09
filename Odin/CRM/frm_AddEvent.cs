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
    public delegate void EventSavingEventHandler(object sender); 

    public partial class frm_AddEvent : KryptonForm
    {
        public frm_AddEvent()
        {
            InitializeComponent();
        }

        #region Variables

        OpenFileDialog openFileDialogPreview = new OpenFileDialog();
        public event EventSavingEventHandler EventSaving;


        public int Id
        { get; set; }
        int _FirmId;
        public int FirmId
        {
            get { return _FirmId; }
            set
            {
                _FirmId = value;
                cmb_ContactPersons1.FirmId = _FirmId;
            }
        }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public int ContactId
        {
            get { return cmb_ContactPersons1.ContPersId; }
            set { cmb_ContactPersons1.ContPersId = value; }
        }

        public string Contact
        {
            get { return cmb_ContactPersons1.ContPers; }
            set { cmb_ContactPersons1.ContPers = value; }
        }

        public string Goal
        {
            get { return txt_Goal.Text; }
            set { txt_Goal.Text = value; }

        }

        public string Theme
        {
            get { return txt_Theme.Text; }
            set { txt_Theme.Text = value; }


        }
        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }

        public string EventDate
        {
            get { return txt_EventDate.Value.ToShortDateString(); }
            set
            {
                try { txt_EventDate.Value = Convert.ToDateTime(value); }
                catch { }
            }
        }

        public string Place
        {
            get { return txt_Place.Text; }
            set { txt_Place.Text = value; }
        }

        public string ContWay
        {
            get { return cmb_ContWay.sCurrentValue; }
            set { cmb_ContWay.sCurrentValue = value; }
        }

        public string State
        {
            get { return cmb_State.sCurrentValue; }
            set { cmb_State.sCurrentValue = value; }
        }

        public string Result
        {
            get { return txt_Result.Text; }
            set { txt_Result.Text = value; }
        }

        public string Link
        {
            get { return txt_Link.Text; }
            set { txt_Link.Text = value; }
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

        #endregion

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            txt_Goal.Text = string.Empty;
        }

        private void buttonSpecAny6_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Theme.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Place.Text = string.Empty;
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            InitFileDialog();

            if (openFileDialogPreview.ShowDialog() == DialogResult.OK)
            {

                txt_Link.Text = openFileDialogPreview.FileName;
            }
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_Link.Text = string.Empty;
        }

        private void buttonSpecAny5_Click(object sender, EventArgs e)
        {
            txt_Result.Text = string.Empty;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (EventSaving != null)
                EventSaving(this);
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

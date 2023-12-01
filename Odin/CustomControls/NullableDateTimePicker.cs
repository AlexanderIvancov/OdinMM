using ComponentFactory.Krypton.Toolkit;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
namespace Odin.CustomControls
{
    public partial class NullableDateTimePicker : KryptonDateTimePicker
    {
        public NullableDateTimePicker()
            : base()
        {
            base.Format = DateTimePickerFormat.Custom;
            NullValue = " ";
            this.Format = DateTimePickerFormat.Short;
            this.DataBindings.CollectionChanged += new CollectionChangeEventHandler(DataBindings_CollectionChanged);
        }

        // true, when no date shall be displayed (empty DateTimePicker)
        private bool _isNull;

        // If _isNull = true, this value is shown in the DTP
        private string _nullValue;

        // The format of the DateTimePicker control
        private DateTimePickerFormat _format = DateTimePickerFormat.Short;

        // The custom format of the DateTimePicker control
        private string _customFormat;

        // The format of the DateTimePicker control as string
        private string _formatAsString;

        public new String CustomFormat
        {
            get { return _customFormat; }
            set { _customFormat = value; }
        }

        public new DateTimePickerFormat Format
        {
            get { return _format; }
            set
            {
                _format = value;
                if (!_isNull)
                    SetFormat();
                OnFormatChanged(EventArgs.Empty);
            }
        }
        private void SetFormat()
        {
            CultureInfo ci = Thread.CurrentThread.CurrentCulture;
            DateTimeFormatInfo dtf = ci.DateTimeFormat;
            switch (_format)
            {
                case DateTimePickerFormat.Long:
                    FormatAsString = dtf.LongDatePattern;
                    break;
                case DateTimePickerFormat.Short:
                    FormatAsString = dtf.ShortDatePattern;
                    break;
                case DateTimePickerFormat.Time:
                    FormatAsString = dtf.ShortTimePattern;
                    break;
                case DateTimePickerFormat.Custom:
                    FormatAsString = this.CustomFormat;
                    break;
            }
        }
        private string FormatAsString
        {
            get { return _formatAsString; }
            set
            {
                _formatAsString = value;
                base.CustomFormat = value;
            }
        }
        public new DateTime? Value
        {
            get
            {
                return _isNull ? null : (DateTime?)base.Value;
            }
            set
            {
                if (value == null)
                {
                    SetToNullValue();
                }
                else
                {
                    SetToDateTimeValue();
                    base.Value = (DateTime)value;
                }
            }
        }

        private void SetToDateTimeValue()
        {
            if (_isNull)
            {
                SetFormat();
                _isNull = false;
                base.OnValueChanged(new EventArgs());
            }
        }
        private void SetToNullValue()
        {
            _isNull = true;
            base.CustomFormat = (_nullValue == null || _nullValue == String.Empty)
                                ? " " : "'" + NullValue + "'";
            base.OnValueChanged(new EventArgs()); // IPY added
        }

        public String NullValue
        {
            get { return _nullValue; }
            set { _nullValue = value; }
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x4e)                         // WM_NOTIFY
            {
                NMHDR nm = (NMHDR)m.GetLParam(typeof(NMHDR));
                if (nm.Code == -746 || nm.Code == -722)  // DTN_CLOSEUP || DTN_?
                    SetToDateTimeValue();
            }
            base.WndProc(ref m);
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct NMHDR
        {
            public IntPtr HwndFrom;
            public int IdFrom;
            public int Code;
        }
        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                //this.Value = _dateTimeNullValue;
                //SetToNullValue();
                this.SetToNullValue();
                OnValueChanged(EventArgs.Empty);
            }
            base.OnKeyUp(e);
        }

        private void DataBindings_CollectionChanged(object sender,
                                         CollectionChangeEventArgs e)
        {
            if (e.Action == CollectionChangeAction.Add)
                this.DataBindings[this.DataBindings.Count - 1].Parse +=
                       new ConvertEventHandler(NullableDateTimePicker_Parse);
        }

        private void NullableDateTimePicker_Parse(object sender, ConvertEventArgs e)
        {
            //saves null values to the object
            if (_isNull)
                e.Value = null;
        }

        // ========================================
        // This member overrides Control.OnKeyPress
        //
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (this.Value == null)
            {
                Char chr = e.KeyChar;
                if (Char.IsNumber(e.KeyChar)
                    || e.KeyChar == (char)Keys.Escape)
                {
                    // Set the Value to todays date
                    this.Value = DateTime.Now;
                    // The following two lines forces the 
                    // focus from the hidden checkbox to the month field
                    if (!this.ShowCheckBox)
                    {
                        this.ShowCheckBox = true;
                        this.ShowCheckBox = false;
                    }
                    // Resend the key pressed
                    SendKeys.Send(chr.ToString());
                }
            }
            base.OnKeyPress(e);
        } // end OnKeyPress
    }

}

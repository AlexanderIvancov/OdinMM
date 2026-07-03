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
using Odin.Purchase;
using Odin.Global_Classes;
using Odin.CustomControls;
using Owf.Controls;
using Odin.Tools;
using System.Data.SqlClient;

namespace Odin.DataCollection
{
    //public delegate void DisplayKeyboardSymbolEventHandler(string symbol, bool symremove);

    public partial class frm_AddRepairDets : KryptonForm
    {
        public frm_AddRepairDets()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        private static KeyPressEventHandler NumericCheckHandler;
        frm_ScreenNumKeyboard popup;
        PopupWindowHelper PopupHelper = null;
        TextBox focusedtextbox;
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        #region Variables

        public string Serial
        {
            get { return txt_Serial.Text; }
            set { txt_Serial.Text = value; }
        }

        public int Id
        { get; set; }

        public string TextLabel
        {
            get { return lbl_Parameters.Text; }
           
            set { lbl_Parameters.Text = value.ToString(); }
        }

        int _oldtime = 0;
        public int OldTime
        {
            get { return _oldtime; }
            set { _oldtime = value; }
        }

        public double WorkTime
        {
            get
            {
                try { return Convert.ToDouble(txt_Worktime.Text); }
                catch { return 0; }
            }
            set { txt_Worktime.Text = value.ToString(); }
        }

        public double Qty
        {
            get
            {
                try { return Convert.ToDouble(txt_Qty.Text); }
                catch { return 0; }
            }
            set { txt_Qty.Text = value.ToString(); }
        }
             
        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        int _mode = 1;
        public int Mode
        {
            //1 - serial, 2 - qty
            get { return _mode; }
            set { _mode = value;
                if (_mode == 1)
                {
                    txt_Qty.Enabled = false;
                }
                else
                {
                    Serial = "";
                    txt_Qty.Enabled = true;
                }
            }
        }      
        #endregion

        #region Controls

        public void CheckEmpty()
        {
            //if (String.IsNullOrEmpty(Parameters)
            //    || Parameters == ""
            //  )
            //    btn_OK.Enabled = false;
            //else
            //    btn_OK.Enabled = true;
        }        

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frm_FCAdditContent_Activated(object sender, EventArgs e)
        {
            // txt_Parameters.Focus();
        }


        private void btn_OK_Click(object sender, EventArgs e)
        {
            //if (FormClosed1 != null)
            //    FormClosed1(this);
        }
        
        #endregion

        #region Methods


        public void AddWorkerToList(int id, string worker)
        {
            int _count = 0;
            foreach (DataGridViewRow rowc in gv_Defects.Rows)
            {
                if (Convert.ToInt32(rowc.Cells["cn_id"].Value) == id)
                {
                    _count++;
                    break;
                }
            }

            if (_count == 0)
            {
                int rownumber = gv_Defects.Rows.Add();

                gv_Defects.Rows[rownumber].Cells[0].Value = id;
                gv_Defects.Rows[rownumber].Cells[1].Value = worker;
            }
        }

        public void FillList()
        {
            var data = DC_BLL.getDefects();


            gv_Defects.ThreadSafeCall(delegate
            {
                gv_Defects.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_Defects.DataSource = bs_List;

            });
            
        }


        #endregion
    }
}

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

    public partial class frm_FinishShift : KryptonForm
    {
        public frm_FinishShift()
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

        public int WorkTime
        {
            get
            {
                try { return Convert.ToInt32(txt_Worktime.Text); }
                catch { return 0; }
            }
            set { txt_Worktime.Text = value.ToString(); }
        }

        public string Instructions
        {
            get { return lbl_Instructions.Text; }
            set { lbl_Instructions.Text = value; }
        }
        public int WorkerId
        { get; set; }
        public int WorkerIdMain
        { get; set; }
        public string Worker
        { get; set; }
        public string WorkerMain
        { get; set; }
        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public string ProdDate
        {
            get { return txt_Date.Value.ToShortDateString(); }
            set { txt_Date.Value = Convert.ToDateTime(value); }
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

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            gv_Workers.Rows.Remove(gv_Workers.CurrentRow);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            frm_cmbTextPDA frm = new frm_cmbTextPDA();
            frm.LabelText = "Scan worker's rfid: ";
            frm.HeaderText = "Scan worker's rfid: ";
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                SqlConnection sqlConn = new SqlConnection(sConnStr);
                sqlConn.Open();
                DataSet ds1 = new DataSet();

                SqlDataAdapter adapter1 =
                    new SqlDataAdapter(
                        "execute sp_SelectWorkerSN @rfid = '" + frm.FormText + "'", sqlConn);

                adapter1.Fill(ds1);

                DataTable dt1 = ds1.Tables[0];

                if (dt1.Rows.Count > 0)
                {
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        if (Convert.ToInt32(dr1["isactive"]) == -1)
                        {
                            Worker = dr1["name"].ToString() + " " + dr1["surname"].ToString();
                            WorkerId = Convert.ToInt32(dr1["id"].ToString());
                            
                        }
                        else
                        {
                            System.Media.SystemSounds.Exclamation.Play();
                            frm_Error frm1 = new frm_Error();
                            frm1.HeaderText = "Wrong worker scanning! Your state is inactive! Please contact your master!";
                            DialogResult result1 = frm1.ShowDialog();
                            //globClass.ShowMessage("Wrong worker scanning", "Please contact your master", "Your state is inactive!");
                            Worker = "";
                            WorkerId = 0;
                        }
                    }
                }
                else
                {
                    System.Media.SystemSounds.Exclamation.Play();
                    frm_Error frm1 = new frm_Error();
                    frm1.HeaderText = "Wrong worker scanning! Your rfid is not correct! Please contact your master!";
                    DialogResult result1 = frm1.ShowDialog();
                    //globClass.ShowMessage("Wrong worker scanning", "Please contact your master", "Your rfid is not correct!");
                    Worker = "";
                    WorkerId = 0;
                }
                sqlConn.Close();

                if (WorkerId != 0)
                    AddWorkerToList(WorkerId, Worker);

            }
        }

        private void btn_AddTime_Click(object sender, EventArgs e)
        {
            frm_AddNumPDA frm = new frm_AddNumPDA();
            frm.LabelText = "Time (min):";
            frm.HeaderText = "Finish work, add time";
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                WorkTime = Convert.ToInt32(frm.Qty);
                //string _res = DCBll.AddDataCollectionQtyOper(WorkerId, LaunchId, frm.Qty, OperNO, OperNO == 0 ? -1 : IsLast, cmb_CommonPDA1.SelectedValue);
                //if (DCBll.SuccessId == -1)
                //    FillList(WorkerId, LaunchId);
                //else
                //{
                //    System.Media.SystemSounds.Exclamation.Play();
                //    frm_Error frm1 = new frm_Error();
                //    frm1.HeaderText = "Something wrong! " + _res;
                //    DialogResult result1 = frm1.ShowDialog();
                //}
                //MessageBox.Show(frm.Qty.ToString());
            }
        }

        #endregion

        #region Methods


        public void AddWorkerToList(int id, string worker)
        {
            int _count = 0;
            foreach (DataGridViewRow rowc in gv_Workers.Rows)
            {
                if (Convert.ToInt32(rowc.Cells["cn_id"].Value) == id)
                {
                    _count++;
                    break;
                }
            }

            if (_count == 0)
            {
                int rownumber = gv_Workers.Rows.Add();

                gv_Workers.Rows[rownumber].Cells[0].Value = id;
                gv_Workers.Rows[rownumber].Cells[1].Value = worker;
            }
        }

        #endregion
    }
}

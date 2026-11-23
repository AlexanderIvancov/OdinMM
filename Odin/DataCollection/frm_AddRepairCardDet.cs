using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using NPOI.Util.Collections;
using System.Collections.Generic;
using System.Data;

namespace Odin.DataCollection
{
    public partial class frm_AddRepairCardDet : KryptonForm
    {
        public frm_AddRepairCardDet()
        {
            InitializeComponent();
            this.Load += frm_AddRepairCardDet_Load;
            this.FormClosing += frm_AddRepairCardDet_FormClosing;
        }

        private readonly NPOI.Util.Collections.HashSet<Control> _lockedMatFields = new NPOI.Util.Collections.HashSet<Control>();
        private DAL_Functions DAL = new DAL_Functions();
        private DC_BLL DCBll = new DC_BLL();

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        int _id = 0;
        int _headid = 0;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int HeadId
        {
            get { return _headid; }
            set { _headid = value; }
        }
        public string FormText
        {
            get { return txt_Text.Text; }
            set { txt_Text.Text = value; }
        }
        public string FormLabel
        {
            get { return lbl_Text.Text; }
            set { lbl_Text.Text = value; }
        }
        public string Worker = "";

        public double WorkTime
        {
            get
            {
                try { return Convert.ToDouble(txt_Worktime.Text); }
                catch { return 0; }
            }
            set { txt_Worktime.Text = value.ToString(); }
        }
        int _formmode = 0;
        public int FormMode
        {
            get { return _formmode; }
            set { _formmode = value;
                if (_formmode == -1)
                {
                    //Defect
                    FormLabel = "Defect:";
                    txt_Worktime.Visible = false;
                    lbl_Worktime.Visible = false;
                }
                else if (_formmode == 0)
                {
                    //Defect
                    FormLabel = "Repair actions:";
                    txt_Worktime.Visible = false;
                    lbl_Worktime.Visible = false;
                }
                else if (_formmode == 1)
                {
                    FormLabel = "Comments:";
                    txt_Worktime.Visible = true;
                    lbl_Worktime.Visible = true;
                    //Description
                }
                else
                {
                    FormLabel = "Conclusion:";
                    txt_Worktime.Visible = false;
                    lbl_Worktime.Visible = false;
                }
            }
        }

        public List<int> NewMaterials
        {
            get
            {
                var result = new List<int>();
                int id;
                foreach (var box in MatBoxes)
                {
                    if (_lockedMatFields.Contains(box)) continue; // уже существующие — не трогаем
                    string t = box.Text.Trim();
                    if (t.Length == 0) continue;
                    if (int.TryParse(t, out id) && id > 0) result.Add(id);
                }
                return result;
            }
        }

        private Control[] MatBoxes
        {
            get { return new[] { txt_Mat1, txt_Mat2, txt_Mat3, txt_Mat4, txt_Mat5 }; }
        }

        private void frm_AddRepairCardDet_Load(object sender, EventArgs e)
        {
            LoadCardMaterials();
        }

        private void LoadCardMaterials()
        {
            if (HeadId <= 0) return;

            DataTable dt = null;
            try { dt = DC_BLL.getRepairCardsMaterials(HeadId); } 
            catch { dt = null; }
            if (dt == null || !dt.Columns.Contains("label")) return;

            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (i >= MatBoxes.Length) break; 

                Control box = MatBoxes[i];
                string label = (row["label"] ?? string.Empty).ToString().Trim();

                box.Text = label;    
                SetReadOnly(box, true);
                box.TabStop = false;     
                _lockedMatFields.Add(box); 
                i++;
            }
        }
        private static void SetReadOnly(Control box, bool value)
        {
            var p = box.GetType().GetProperty("ReadOnly");
            if (p != null && p.PropertyType == typeof(bool) && p.CanWrite)
                p.SetValue(box, value, null);
        }
        private void frm_AddRepairCardDet_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK) return;

            foreach (var box in MatBoxes)
            {
                if (_lockedMatFields.Contains(box)) continue;
                string t = box.Text.Trim();
                if (t.Length == 0) continue;
                int id;
                if (!int.TryParse(t, out id) || id <= 0 || !DAL.CheckLabel(t))
                {
                    MessageBox.Show("Material \"" + t + "\" is not valid! Clear the field or scan correct label.",
                        "Materials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;  
                    box.Focus();
                    return;
                }
            }
        }
        private void txt_Oper_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.Enter)
            //{
            //    string _serial = txt_Oper.Text.Trim();
            //    SqlConnection sqlConn = new SqlConnection(sConnStr);
            //    sqlConn.Open();
            //    DataSet ds1 = new DataSet();

            //    SqlDataAdapter adapter1 =
            //        new SqlDataAdapter(
            //            "execute sp_SelectSerialNrDetails @serial = '" + _serial + "'", sqlConn);

            //    adapter1.Fill(ds1);

            //    DataTable dt1 = ds1.Tables[0];

            //    if (dt1.Rows.Count > 0)
            //    {
            //        foreach (DataRow dr1 in dt1.Rows)
            //        {
            //            Serial = dr1["original"].ToString();
            //            Analog = dr1["analog"].ToString();
            //            BatchId = Convert.ToInt32(dr1["batchid"].ToString());
            //        }
            //    }
            //    sqlConn.Close();

            //    SetFocus();
            //}
        }

        private void txt_Mat1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_lockedMatFields.Contains(txt_Mat1)) { e.Handled = true; return; }
            if (e.KeyChar == (char)Keys.Enter)
            {
                string input = txt_Mat1.Text.Trim();

                if (e.KeyChar == (char)Keys.Enter)
                    if (!DAL.CheckLabel(input)) txt_Mat1.Text = "";
            }
        }
        private void txt_Mat2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_lockedMatFields.Contains(txt_Mat2)) { e.Handled = true; return; }
            if (e.KeyChar == (char)Keys.Enter)
            {
                string input = txt_Mat2.Text.Trim();

                if (e.KeyChar == (char)Keys.Enter)
                    if (!DAL.CheckLabel(input)) txt_Mat2.Text = "";
            }
        }
        private void txt_Mat3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_lockedMatFields.Contains(txt_Mat3)) { e.Handled = true; return; }
            if (e.KeyChar == (char)Keys.Enter)
            {
                string input = txt_Mat3.Text.Trim();

                if (e.KeyChar == (char)Keys.Enter)
                    if (!DAL.CheckLabel(input)) txt_Mat3.Text = "";
            }
        }
        private void txt_Mat4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_lockedMatFields.Contains(txt_Mat4)) { e.Handled = true; return; }
            if (e.KeyChar == (char)Keys.Enter)
            {
                string input = txt_Mat4.Text.Trim();

                if (e.KeyChar == (char)Keys.Enter)
                    if (!DAL.CheckLabel(input)) txt_Mat4.Text = "";
            }
        }
        private void txt_Mat5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_lockedMatFields.Contains(txt_Mat5)) { e.Handled = true; return; }
            if (e.KeyChar == (char)Keys.Enter)
            {
                string input = txt_Mat5.Text.Trim();

                if (e.KeyChar == (char)Keys.Enter)
                    if (!DAL.CheckLabel(input)) txt_Mat5.Text = "";
            }
        }

        public void SetFocus()
        {
            txt_Oper.Text = "";
            txt_Oper.Focus();
        }
    }
}
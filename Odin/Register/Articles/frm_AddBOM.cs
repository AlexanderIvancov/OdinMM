using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Workspace;
using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using System.Text.RegularExpressions;

namespace Odin.Register.Articles
{
    public partial class frm_AddBOM : KryptonForm
    {
        public frm_AddBOM()
        {
            InitializeComponent();
        }

        Reg_BLL BLL = new Reg_BLL();

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public int Id
        { get; set; }

        public int IdCSE
        { get; set; }

        public int IdCST
        {
            get { return cmb_Articles1.ArticleId; }
            set { cmb_Articles1.ArticleId = value; }
        }

        public string Article
        {
            get { return cmb_Articles1.Article; }
        }
        public string SecName
        {
            get { return cmb_Articles1.SecName; }
        }
        public int Number
        {
            get
            {
                try { return Convert.ToInt32(txt_Num.Text); }
                catch { return 1; }
            }
            set
            {
                try { txt_Num.Text = value.ToString(); }
                catch { txt_Num.Text = "1"; }
            }
        }
        public string Unit
        {
            get { return txt_Unit.Text; }
            set { txt_Unit.Text = value; }
        }
        public decimal Qty
        {
            get
            {
                try { return Convert.ToDecimal(txt_Qty.Text); }
                catch { return 0; }
            }
            set { txt_Qty.Text = value.ToString(); }
        }
        public int Using
        {
            get
            {
                if (chk_Use.CheckState == CheckState.Checked)
                    return -1;
                else
                    return 0;
            }
            set
            {
                if (value == -1)
                    chk_Use.CheckState = CheckState.Checked;
                else
                    chk_Use.CheckState = CheckState.Unchecked;
            }
        }
        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }

        public string Positions
        {
            get { return txt_Positions.Text; }
            set { txt_Positions.Text = value; }
        }

        public double SpoilConst
        {
            get
            {
                try { return Convert.ToDouble(txt_SpoilConst.Text); }
                catch { return 0; }
            }
            set { txt_SpoilConst.Text = value.ToString(); }
        }
        public double SpoilPerc
        {
            get
            {
                try { return Convert.ToDouble(txt_SpoilPerc.Text); }
                catch { return 0; }
            }
            set { txt_SpoilPerc.Text = value.ToString(); }
        }

        public int StageId
        {
            get { return cmb_Common1.SelectedValue; }
            set { cmb_Common1.SelectedValue = value; }
        }

        private void frm_AddNomenclature_Load(object sender, EventArgs e)
        {

        }

        private void EnableDisableButton()
        {
            if (string.IsNullOrEmpty(txt_Qty.Text) || string.IsNullOrEmpty(txt_SpoilConst.Text) ||
                string.IsNullOrEmpty(txt_SpoilPerc.Text) || cmb_Articles1.ArticleId == 0)
            {
                btn_OK.Enabled = false;
                return;
            }
            else
            {
                btn_OK.Enabled = true;
                return;
            }
        }

        private void cmb_Articles1_ArticleChanged(object sender)
        {
            EnableDisableButton();
            Unit = cmb_Articles1.Unit;
            StageId = cmb_Articles1.StageID;
            SpoilConst = cmb_Articles1.SpoilConst;
        }

        private void txt_Qty_TextChanged(object sender, EventArgs e)
        {
            EnableDisableButton();
        }

        private void txt_SpoilConst_TextChanged(object sender, EventArgs e)
        {
            EnableDisableButton();
        }

        private void txt_SpoilPerc_TextChanged(object sender, EventArgs e)
        {

            EnableDisableButton();
        }
        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_AddBOM_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Error;

            if (DialogResult == DialogResult.OK)
            {
                var dataParent = BLL.ArticleParents(IdCSE);
                var dataChild = BLL.NomenclatureChild(IdCSE);

                var errorMsg = "Selected component could not be inserted!";

                //checks for parent existence
                foreach (System.Data.DataRow dr in dataParent.AsEnumerable())
                {
                    if (cmb_Articles1.ArticleId == dr.Field<int>("artid"))
                    {
                        MessageBox.Show(errorMsg, "Error", buttons, icon);
                        e.Cancel = true;
                        break;
                    }
                }

                if (!HeaderText.Contains("Edit"))
                {
                    //checks for child existence
                    foreach (System.Data.DataRow dr in dataChild.AsEnumerable())
                    {
                        if (cmb_Articles1.ArticleId == dr.Field<int>("IdCST"))
                        {
                            MessageBox.Show(errorMsg, "Error", buttons, icon);
                            e.Cancel = true;
                            break;
                        }
                    }
                }
                
            }
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Positions.Text = string.Empty;
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            string _tmpposition = Positions;
            try
            {
                _tmpposition = Helper.GetOneRecord("select dbo.fn_FormatPositionsString('" + _tmpposition + "')").ToString();
            }
            catch { }

            Positions = _tmpposition;
        }

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            string _tmpposition = Positions;
            try
            {
                _tmpposition = formatPosition(_tmpposition);
            }
            catch { }

            Positions = _tmpposition;
        }
        private string formatPosition(string pos)
        {
            string res = "";
            try
            {
                string[] separatingStrings = { ", " };
                string[] components = pos.Split(separatingStrings, StringSplitOptions.RemoveEmptyEntries);
                foreach (string component in components)
                {
                    MatchCollection matches = new Regex(@"\D+\d+\D+\d+").Matches(component);
                    if (matches.Count > 0)
                    {
                        string[] startlet = { new Regex(@"^\D+").Matches(pos)[0].Value.ToString(), new Regex(@"\p{P}").Matches(pos)[0].Value.ToString() };
                        int left  = Int32.Parse(Regex.Replace(component.Split(startlet, StringSplitOptions.RemoveEmptyEntries)[0].ToString(), "\\p{P}", string.Empty));
                        int right = Int32.Parse(Regex.Replace(component.Split(startlet, StringSplitOptions.RemoveEmptyEntries).Last().ToString(), "\\p{P}", string.Empty));
                        int[] componentRange = Enumerable.Range(left, right-left+1).ToArray();
                        foreach (int i in componentRange) res = res + startlet[0] + i.ToString() + separatingStrings[0];
                    }
                    else res = res + component + separatingStrings[0];
                }
            }
            catch { }
            return res.Substring(0, res.Length - 2);
        }
    }
}

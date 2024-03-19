using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Odin.Register.Companies
{
    public delegate int ReceiveFirmId();

    public partial class frm_Companies : BaseForm
    {
        public frm_Companies()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "CompaniesList.xls", this.Name);
        }
        public static event ReceiveFirmId ReceiveId;
        
        #region Variables

        ExportData ED;
        class_Global glob_Class = new class_Global();
        Reg_BLL Reg = new Reg_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        class_Global globClass = new class_Global();
        Font boldFont;
        Helper MyHelper = new Helper();

        public ctl_Addresses ctlAddresses = null;
        public ctl_FirmsGeneral ctlFirmsGeneral = null;
        public ctl_Banks ctlBanks = null;
        public ctl_Contacts ctlContacts = null;
        public ctl_Documents ctlDocuments = null;
        public int ControlWidth = 250;
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        public int igvFirmId
        {
            get;
            set;
        }
        public int OldigvFirmId
        {
            get;
            set;
        }

        private KryptonPage NewPage(string name, int image, Control content, int _Width)
        {
            // Create new page with title and image
            KryptonPage p = new KryptonPage();
            p.Text = name;
            p.TextTitle = name;
            p.TextDescription = name;
            p.ImageSmall = imageListSmall.Images[image];
            p.Width = _Width;

            // Add the control for display inside the page
            content.Dock = DockStyle.Fill;
            p.Controls.Add(content);
            
            return p;
        }

        #endregion

        #region Controls

        private KryptonPage NewInputGeneral(string Firm, int FirmId)
        {
            ctlFirmsGeneral = new ctl_FirmsGeneral();
            ControlWidth = ctlFirmsGeneral.Width;

            ctlFirmsGeneral.FirmId = FirmId;
            ctlFirmsGeneral.SendFirmId += new FirmsIdSendingEventHandler(ChangeFirmsIdSelection);
            //MessageBox.Show(ctl.Width.ToString());
            return NewPage("General ", 1, ctlFirmsGeneral, ctlFirmsGeneral.Width);
        }
        

        private KryptonPage NewInputAddress(string Firm, int FirmId)
        {
            ctlAddresses = new ctl_Addresses();
            ControlWidth = ctlAddresses.Width;
            ctlAddresses.cmb_Firms1.FirmId = FirmId;
            //MessageBox.Show(ctl.Width.ToString());
            return NewPage("Addresses ", 1, ctlAddresses, ctlAddresses.Width);
        }

        private KryptonPage NewInputContacts(string Firm, int FirmId)
        {
            ctlContacts = new ctl_Contacts();
            ControlWidth = ctlContacts.Width;
            ctlContacts.cmb_Firms1.FirmId = FirmId;
            //MessageBox.Show(ctl.Width.ToString());
            return NewPage("Contacts ", 1, ctlContacts, ctlContacts.Width);
        }

        private KryptonPage NewInputBanks(string Firm, int FirmId)
        {
            ctlBanks = new ctl_Banks();
            ControlWidth = ctlBanks.Width;
            ctlBanks.cmb_Firms1.FirmId = FirmId;
            //ctlContacts.FirmId = FirmId;
            //MessageBox.Show(ctl.Width.ToString());
            return NewPage("Banks ", 1, ctlBanks, ctlBanks.Width);
        }

        private KryptonPage NewInputDocuments(string Firm, int FirmId)
        {
            ctlDocuments = new ctl_Documents();
            ControlWidth = ctlDocuments.Width;
            //ctlContacts.FirmId = FirmId;
            //MessageBox.Show(ctl.Width.ToString());
            return NewPage("Documents ", 1, ctlDocuments, ctlDocuments.Width);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DataGridViewColumn oldColumn = gv_List.SortedColumn;
            var dir = Helper.SaveDirection(gv_List);

            bwStart(bw_List);

            Helper.RestoreDirection(gv_List, oldColumn, dir);
            SetCellsColor();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFilter();
        }
        private void ChangeFirmsIdSelection(object sender)
        {
            DataGridViewColumn oldColumn = gv_List.SortedColumn;
            var dir = Helper.SaveDirection(gv_List);

            bwStart(bw_List);

            Helper.RestoreDirection(gv_List, oldColumn, dir);
        }
        #region Context menu


        private void mnu_Lines_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                Point mpoint = gv_List.PointToClient(DataGridView.MousePosition);
                DataGridView.HitTestInfo info = gv_List.HitTest(mpoint.X, mpoint.Y);

                RowIndex = info.RowIndex;
                ColumnIndex = info.ColumnIndex;
                //MessageBox.Show(RowIndex.ToString() + "MO," + ColumnIndex.ToString());

                gv_List.ClearSelection();
                gv_List.Rows[RowIndex].Cells[ColumnIndex].Selected = true;
                gv_List.CurrentCell = gv_List.Rows[RowIndex].Cells[ColumnIndex];

                CellValue = gv_List.Rows[RowIndex].Cells[ColumnIndex].Value.ToString();
                ColumnName = gv_List.Columns[ColumnIndex].DataPropertyName.ToString();
                //gv_List.SelectionChanged += new EventHandler(gv_List_SelectionChanged(this));

            }
            catch
            {
                RowIndex = 0;
                ColumnIndex = 0;
                return;
            }
        }

        private void mni_FilterFor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bs_List.Filter = ("Convert(" + ColumnName + " , 'System.String') like '%" + mni_FilterFor.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
            }
            catch
            { }
            SetCellsColor();

        }

        private void mni_Search_Click(object sender, EventArgs e)
        {
            frm_Find frm = new frm_Find();
            frm.grid = gv_List;
            frm.ColumnNumber = gv_List.CurrentCell.ColumnIndex;
            frm.ColumnText = gv_List.Columns[frm.ColumnNumber].HeaderText;
            frm.ShowDialog();
        }

        private void mni_FilterBy_Click(object sender, EventArgs e)
        {
            try
            {
                bs_List.Filter = String.IsNullOrEmpty(bs_List.Filter) == true
                    ? String.IsNullOrEmpty(CellValue) == true
                        ? "(" + ColumnName + " is null OR Convert(" + ColumnName + ", 'System.String') = '')"
                        : "Convert(" + ColumnName + " , 'System.String') = '" + glob_Class.NES(CellValue) + "'"
                    : String.IsNullOrEmpty(CellValue) == true
                        ? bs_List.Filter + "AND (" + ColumnName + " is null OR Convert(" + ColumnName + ", 'System.String') = '')"
                        : bs_List.Filter + " AND Convert(" + ColumnName + " , 'System.String') = '" + glob_Class.NES(CellValue) + "'";
                //MessageBox.Show(bs_List.Filter);

            }
            catch { }
            SetCellsColor();

        }

        private void mni_FilterExcludingSel_Click(object sender, EventArgs e)
        {
            try
            {
                bs_List.Filter = String.IsNullOrEmpty(bs_List.Filter) == true
                    ? "Convert(" + ColumnName + " , 'System.String') <> '" + CellValue + "'"
                    : bs_List.Filter + " AND " + ColumnName + " <> '" + CellValue + "'";
            }
            catch { }
            SetCellsColor();

        }

        private void mni_RemoveFilter_Click(object sender, EventArgs e)
        {
            try
            {
                bs_List.RemoveFilter();
            }
            catch { }
            SetCellsColor();

        }

        private void mni_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CellValue.ToString());
        }

        private void mni_Admin_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for articles list";
            frm.grid = this.gv_List;
            frm.formname = this.Name;
            DAL.UserLogin = System.Environment.UserName;
            frm.UserId = DAL.UserId;

            frm.FillData(frm.grid);

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                mMenu.CommitUserColumn(frm.UserId, frm.formname, frm.grid.Name, frm.gvList);
                LoadColumns(gv_List);
            }
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            ED.DgvIntoExcel();
        }

        #endregion

        #endregion

        #region Methods

        public void LoadColumns(DataGridView grid)
        {
            DAL.UserLogin = Environment.UserName;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SelectUserGridViewColumn", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.AddWithValue("@userid", DAL.UserId);
            sqlComm.Parameters.AddWithValue("@formname", this.Name);
            sqlComm.Parameters.AddWithValue("@gridname", grid.Name);

            sqlConn.Open();
            SqlDataReader reader = sqlComm.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                    foreach (DataGridViewColumn column in grid.Columns)
                        if (column.Name == reader["columnname"].ToString())
                        {
                            column.DisplayIndex = Convert.ToInt32(reader["columnorder"]);
                            column.HeaderText = reader["columntext"].ToString();
                            column.Visible = glob_Class.NumToBool(reader["columnvisibility"].ToString());
                            column.Width = Convert.ToInt32(reader["columnwidth"]);
                        }
                reader.Close();
            }
            sqlConn.Close();
        }

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
                if (Convert.ToInt32(row.Cells["cn_isactive"].Value) == 0)
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.Silver;
        }

        public void ClearFilter()
        {
            cmb_Firms1.FirmId = 0;
            txt_RegNR.Text = string.Empty;
            txt_VAT.Text = string.Empty;
            cmb_Countries1.CountryId = 0;
        }

        public void bw_List(object sender, DoWorkEventArgs e)
        {
            var data = (DataTable)Helper.getSP("sp_CompanyList", cmb_Firms1.FirmId, cmb_Firms1.Firm, txt_RegNR.Text, txt_VAT.Text,
                                            cmb_Countries1.CountryId, chk_IsActive.CheckState == CheckState.Checked ? -1 : (chk_IsActive.CheckState == CheckState.Indeterminate ? 1 : 0));

            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

                SetCellsColor();
            });

            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });
        }

        private bool CheckOldRow()
        {

            try
            {
                igvFirmId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch
            {
                igvFirmId = 0;
            }

            //if (igvFirmId != 0)
            //    cmb_Firms1.FirmId = igvFirmId;


            if (OldigvFirmId == igvFirmId)
                return true;
            else
            {
                OldigvFirmId = igvFirmId;
                return false;
            }
        }

        public void ShowDetails(int firmid)
        {
            Reg.FirmId = igvFirmId;

            //MessageBox.Show(Reg.FirmId.ToString());

            //if (ctlFirmsGeneral != null)
            //    ctlFirmsGeneral.FirmId = igvFirmId;

            //if (ctlAddresses != null)
            //    ctlAddresses.cmb_Firms1.FirmId = igvFirmId;

            FindGenPages(igvFirmId);
            FindAddressPages(igvFirmId);
            FindContactsPages(igvFirmId);
            FindAccountsPages(igvFirmId);
        }

        public void FindGenPages(int firmid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_FirmsGeneral ctlGen1 = (ctl_FirmsGeneral)page.Controls.Find("ctl_FirmsGeneral", true).FirstOrDefault();
                if (ctlGen1 != null)
                    ctlGen1.FirmId = firmid;
                //break;
            }
        }

        public void FindAddressPages(int firmid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_Addresses ctlAddr1 = (ctl_Addresses)page.Controls.Find("ctl_Addresses", true).FirstOrDefault();
                if (ctlAddr1 != null)
                    ctlAddr1.cmb_Firms1.FirmId = firmid;
                //break;
            }
        }

        public void FindContactsPages(int firmid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_Contacts ctlCont1 = (ctl_Contacts)page.Controls.Find("ctl_Contacts", true).FirstOrDefault();
                if (ctlCont1 != null)
                    ctlCont1.cmb_Firms1.FirmId = firmid;
                //break;
            }
        }

        public void FindAccountsPages(int firmid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_Banks ctlBank1 = (ctl_Banks)page.Controls.Find("ctl_Banks", true).FirstOrDefault();
                if (ctlBank1 != null)
                    ctlBank1.cmb_Firms1.FirmId = firmid;
                //break;
            }
        }

        #endregion

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_VAT.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_RegNR.Text = string.Empty;
        }

        private void frm_Companies_Load(object sender, EventArgs e)
        {
            KryptonDockingWorkspace w = kryptonDockingManager1.ManageWorkspace(kryptonDockableWorkspace1);
            kryptonDockingManager1.ManageControl(kryptonSplitContainer1.Panel2, w);
            kryptonDockingManager1.ManageFloating(this);

            LoadColumns(gv_List);
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            frm_AddCompany frm = new frm_AddCompany();
            frm.CheckEmpty();
            frm.Id = 0;

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                //Add new 
                int _res = Convert.ToInt32(Helper.getSP("sp_SaveCompany", 0, frm.FirmName, frm.RegNR, frm.VAT, frm.Phone, frm.Fax, frm.Email, frm.ParentId, frm.CountryId,
                                            frm.WebLink, frm.Comments, frm.SupMark, frm.CustMark, frm.SupPayment, frm.CustPayment,
                                            frm.SupIncoterms, frm.CustIncoterms, frm.IsActive, frm.OneC, frm.SupComments, frm.CustPayTerms,
                                            frm.TransportId, frm.BankContId));
                if (_res != 0)
                {
                    cmb_Firms1.FirmId = _res;
                    DataGridViewColumn oldColumn = gv_List.SortedColumn;
                    var dir = Helper.SaveDirection(gv_List);

                    bwStart(bw_List);

                    Helper.RestoreDirection(gv_List, oldColumn, dir);
                    SetCellsColor();
                }
            }
        }

        public void ShowEdit()
        {
            frm_AddCompany frm = new frm_AddCompany();
            frm.CheckEmpty();
            Reg.FirmId = igvFirmId;
            frm.Id = Reg.FirmId;
            //MessageBox.Show(Reg.Company);
            frm.FirmName = Reg.Company;
            frm.RegNR = Reg.RegNR;
            frm.VAT = Reg.VAT;
            frm.Phone = Reg.Phone;
            frm.Fax = Reg.Fax;
            frm.Email = Reg.Email;
            frm.ParentId = Reg.ParentId;
            frm.CountryId = Reg.CountryId;
            frm.WebLink = Reg.WebAddress;
            frm.Comments = Reg.FirmCommments;
            frm.SupMark = Reg.SupMark;
            frm.CustMark = Reg.CustMark;
            frm.SupPayment = Reg.SupPayment;
            frm.CustPayment = Reg.CustPayment;
            frm.SupIncoterms = Reg.SupIncoterms;
            frm.CustIncoterms = Reg.CustIncoterms;
            frm.IsActive = Reg.CompanyIsActive;
            frm.OneC = Reg.OneC;
            frm.SupComments = Reg.SupComments;
            frm.CustPayTerms = Reg.CustPayTerms;
            frm.TransportId = Reg.TransportId;
            frm.BankContId = Reg.BankContId;
            //frm.Sup
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                //Edit-
                int _res = Convert.ToInt32(Helper.getSP("sp_SaveCompany", frm.Id, frm.FirmName, frm.RegNR, frm.VAT, frm.Phone, frm.Fax, frm.Email, frm.ParentId, frm.CountryId,
                                            frm.WebLink, frm.Comments, frm.SupMark, frm.CustMark, frm.SupPayment, frm.CustPayment,
                                            frm.SupIncoterms, frm.CustIncoterms, frm.IsActive, frm.OneC, frm.SupComments, frm.CustPayTerms,
                                            frm.TransportId, frm.BankContId));
                if (_res != 0)
                {
                    cmb_Firms1.FirmId = _res;
                    DataGridViewColumn oldColumn = gv_List.SortedColumn;
                    var dir = Helper.SaveDirection(gv_List);

                    bwStart(bw_List);

                    Helper.RestoreDirection(gv_List, oldColumn, dir);
                    SetCellsColor();
                }
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            ShowEdit();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (globClass.DeleteConfirm() == true)
            {
                Helper.getSP("sp_DeleteCompany", igvFirmId);
                cmb_Firms1.FirmId = 0;
                bwStart(bw_List);
            }
        }

        private void btn_Active_Click(object sender, EventArgs e) {}

        private void gv_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                igvFirmId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
                if (gv_List.CurrentRow.Cells["cn_webaddress"].Selected == true)
                {
                    string Link = gv_List.CurrentRow.Cells["cn_webaddress"].Value.ToString();
                    if (glob_Class.NES(Link) != "")
                        System.Diagnostics.Process.Start(Link);
                }
            }
            catch
            { }
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            if (CheckOldRow() == false)
               ShowDetails(igvFirmId);
        }

        private void btn_General_Click(object sender, EventArgs e)
        {
            //kryptonDockingManager1.AddToWorkspace("Workspace", new KryptonPage[] { NewInputGeneral(Reg.Company, Reg.FirmId) });
            kryptonDockingManager1.AddDockspace("Control",
                                               DockingEdge.Left,
                                               new KryptonPage[] { NewInputGeneral(Reg.Company, Reg.FirmId) });
        }

        private void btn_Addresses_Click(object sender, EventArgs e)
        {
            kryptonDockingManager1.AddToWorkspace("Workspace", new KryptonPage[] { NewInputAddress(Reg.Company, Reg.FirmId) });

            //kryptonDockingManager1.AddDockspace("Control",
            //                                   DockingEdge.Left,
            //                                   new KryptonPage[] { NewInputAddress(Reg.Company, Reg.FirmId) });
        }

        private void btn_Contacts_Click(object sender, EventArgs e)
        {
            //kryptonDockingManager1.AddToWorkspace("Workspace", new KryptonPage[] { NewInputContacts(Reg.Company, Reg.FirmId) });

            kryptonDockingManager1.AddDockspace("Control",
                                               DockingEdge.Left,
                                               new KryptonPage[] { NewInputContacts(Reg.Company, Reg.FirmId) });
        }

        private void btn_Banks_Click(object sender, EventArgs e)
        {
            //kryptonDockingManager1.AddToWorkspace("Workspace", new KryptonPage[] { NewInputBanks(Reg.Company, Reg.FirmId) });
            kryptonDockingManager1.AddDockspace("Control",
                                               DockingEdge.Left,
                                               new KryptonPage[] { NewInputBanks(Reg.Company, Reg.FirmId) });
        }

        private void txt_RegNR_TextChanged(object sender, EventArgs e)
        {
            //cmb_SalesOrdersWithLines1.SalesOrderLineId = Convert.ToInt32(txt_RegNR.Text);
        }

        private void kryptonDockingManager1_DockspaceAdding(object sender, DockspaceEventArgs e)
        {
            e.DockspaceControl.Size = new Size(ControlWidth, kryptonDockableWorkspace1.Height);
        }

        private void frm_Companies_Resize(object sender, EventArgs e)
        {
            if (_Main.WindowState == FormWindowState.Maximized)
                foreach (var page in kryptonDockingManager1.PagesDocked)
                {
                    kryptonDockingManager1.RemovePage(page, false);
                    kryptonDockingManager1.AddDockspace("Control",
                                               DockingEdge.Left,
                                               new KryptonPage[] { page });

                }
        }

        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowEdit();
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }

        private void gv_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
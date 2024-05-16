using ComponentFactory.Krypton.Toolkit;
using Microsoft.Win32;
using Odin.CMB_Components.Currencies;
using Odin.DataCollection;
using Odin.Finances;
using Odin.Global_Classes;
using Odin.Personnel;
using Odin.Planning;
using Odin.Planning.Passport;
using Odin.Purchase;
using Odin.Quality;
using Odin.Register.Articles;
using Odin.Register.Catalog;
using Odin.Register.Companies;
using Odin.Sales;
using Odin.Sales.DeliveryPlanning;
using Odin.Sales.Reports;
using Odin.Tools;
using Odin.Warehouse.Corrections;
using Odin.Warehouse.Deliveries;
using Odin.Warehouse.History;
using Odin.Warehouse.Inventory;
using Odin.Warehouse.Movements;
using Odin.Warehouse.Packing;
using Odin.Warehouse.Reports;
using Odin.Warehouse.Requests;
using Odin.Warehouse.Shelves;
using Odin.Warehouse.StockIn;
using Odin.Warehouse.StockOut;
using Odin.Workshop;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Threading;
using System.Xml;
using WeifenLuo.WinFormsUI.Docking;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Odin
{
    public delegate void  InitiateMinimizeEventHandler(object sender);
    public partial class Main : KryptonForm
    {
        public Main()
        {
            InitializeComponent();
            InitTimer();
            this.IsMdiContainer = true;
            //mdiClientController1.BackColor = col.mainFormBackColor;
            //custom
            //ToolStripManager.Renderer = new Office2007Renderer();
            
        }

        DispatcherTimer timer = new DispatcherTimer();

        public void InitTimer()
        {
            timer.Interval = new TimeSpan(0, 1, 0);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        String SV = System.Diagnostics.FileVersionInfo.GetVersionInfo(path_Set() + "/Odin.exe").FileVersion;
        String CV = Assembly.GetExecutingAssembly().GetName().Version.ToString();

        static String path_Set()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("C:/PST/OdinLauncher/OdinLauncher.exe.config");
            XmlElement xRoot = xDoc.DocumentElement;
            if (xRoot != null)
                foreach (XmlElement xnode in xRoot)
                    if (xnode.Name == "applicationSettings")
                        foreach (XmlNode childnode in xnode.ChildNodes)
                            if (childnode.Name == "OdinLauncher.Properties.Settings")
                                foreach (XmlNode childnode2 in childnode.ChildNodes)
                                    if (childnode2.Name == "setting")
                                        return childnode.InnerText;
            return "/FS-Primary/ERP_InstallOdin";
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (SV != CV)
                System.Windows.MessageBox.Show("Odin's update is ready to be installed", "Odin Update", System.Windows.MessageBoxButton.OK, 
                    System.Windows.MessageBoxImage.Warning, System.Windows.MessageBoxResult.Yes);
        }

        public event InitiateMinimizeEventHandler MinimizeForm;
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        #region Variables

        DAL_Functions DAL = new DAL_Functions();
        class_Global glob_Class = new class_Global();
        frm_ArticlesManagement Articles = null;
        frm_ClientOrders ClientOrders = null;
        frm_PurchaseOrders PurchaseOrders = null;
        frm_CatalogList Catalog = null;
        frm_StockInwards StockInwards = null;
        frm_Inventory Inventory = null;
        frm_Movement StockMovement = null;
        frm_Batches Batches = null;
       
        frm_BatchesRatioPortfolio BatchesRatio = null;
        frm_Companies Companies = null;
        frm_StockOut StockOut = null;
        frm_Requests Requests = null;
        frm_TestKryptonDock KrypDock = null;
        frm_Deliveries Deliveries = null;
        frm_Processing Processing = null;
        frm_StockHistory StockHistory = null;
        frm_Quotations Quotations = null;
        frm_ExpInvoices ExpInvoices = null;
        frm_IncomesReports IncomeReports = null;
        frm_SellingReports SellingReports = null;
        frm_InventoryReport InventoryReports = null;
        frm_BOMManagement BOM = null;
        frm_DeliveryPlanning DeliveryPlanning = null;
        frm_ProfitReports ProfitRep = null;
        private const string dockContent = "DockContent";
        private const string winForm = "WindowsForm";
        private const string baseForm = "BaseForm";
        private const string waitFormName = "frm_Wait";
        frm_MovementReports MovementReport = null;
        frm_IncomeControl IncomeControlList = null;
        frm_ProductCard ProductCard = null;
        Finances_BLL FinBLL = new Finances_BLL();
        frm_SerialNumbers SerialNumbers = null;
        frm_ProductivityIndicator ProdIndicators = null;
        frm_LaunchesPlanning Launches = null;
        frm_LaunchesPlanningG LaunchesG = null;
        frm_PaymentReport Payments = null;
        frm_Intrastat Intrastat = null;
        frm_NeedsProcessing NeedsProcessing = null;
        frm_Packing Packing = null;
        frm_LaunchPassport LaunchPassport = null;
        frm_LaunchPassportComments LaunchPassportComments = null;
        frm_DataCollection DataCollection = null;
        frm_WorkerDC WorkerDC = null;
        frm_WorkerDCOper WorkerDCOper = null;
        frm_MasterApproveFin MasterApprove = null;
        frm_MasterApproveTot MasterApproveTot = null;
        frm_ProductionResult ProdResult = null;
        frm_BatchProjects BatchProjects = null;
        frm_BatchesNew BatchesNew = null;
        frm_PlanningView PlanningView = null;
        frm_TurnoverReports TurnoverReport = null;

        #endregion


        public void OpenDockContentForm(string formName)
        {
            string frmName = String.Empty;
            DockContent frm = new DockContent();
            

            //if dock tab page found show it
            foreach (var f in MdiChildren.Where(f => f.Name == formName))
            {
                f.BringToFront();
                return;
            }

            
                //finds full form name with namaspace by name and by DockType in the solution
                frmName = (from t in Assembly.GetExecutingAssembly().GetTypes()
                           where t.Name.Equals(formName) && (t.BaseType.Name == dockContent || t.BaseType.Name == baseForm)
                           select t.FullName).SingleOrDefault();


                if (frmName != null)
                {

                    //shows found form by name
                    frm = (DockContent)Activator.CreateInstance(Type.GetType(frmName));
                    if (frm != null)
                    {
                        pn_Main.Visible = true;
                        frm.Show(pn_Main);
                        frm.FormClosed += (sender, e) => SetBackPanelVisible();
                    }

                }

            /*int c = 0;
                foreach (Form form in MdiChildren)
                {
                    if (form.Name == "frm_Articles")
                        c += 1;
                }
                if (c == 1)
                {
                    Articles.Show(pn_Main);
                }
                else
                {
                    Articles = new frm_Articles();
                    Articles.Show(pn_Main);
                    Articles._frm_Main = this;
                }
                pn_Main.Visible = true;
                Articles.FormClosed += delegate(object _sender, FormClosedEventArgs _e)
                {

                    if (pn_Main.DocumentsCount == 1)
                    {
                        pn_Main.Visible = false;
                    }
                    else pn_Main.Visible = true;
                };*/

        }

        private void SetBackPanelVisible()
        {
            pn_Main.Visible = pn_Main.DocumentsCount != 1;
        }
                       
                
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Lang_Click(object sender, EventArgs e)
        {
            frm_Lang frm = new frm_Lang();
            DialogResult result = frm.ShowDialog();
        }


        #region Controls
        private void btn_BatchManagement_Click(object sender, EventArgs e)
        {
            //OpenDockContentForm("frm_Batches");
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_Batches"))
            {
                f.BringToFront();
                return;
            }
            Batches = new frm_Batches();
            Batches._Main = this;
            Batches.Show(pn_Main);
        }

        private void btn_Articles_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_ArticlesManagement"))
            {
                f.BringToFront();
                return;
            }
            Articles = new frm_ArticlesManagement();
            Articles._Main = this;
            // public Main _Main;
            //Articles.InitiateResize();
            Articles.Show(pn_Main);
           
        }

        private void btn_Contractors_Click(object sender, EventArgs e)
        {
            //OpenDockContentForm("frm_Companies");

            foreach (var f in MdiChildren.Where(f => f.Name == "frm_Companies"))
            {
                f.BringToFront();
                return;
            }
            Companies = new frm_Companies();
            Companies._Main = this;
            Companies.Show(pn_Main);
        }

        #endregion

        private void btn_StockShelves_Click(object sender, EventArgs e)
        {
            frm_StockShelves frm = new frm_StockShelves();
            frm.FillTree();
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_SalesOrders_Click(object sender, EventArgs e)
        {
            //OpenDockContentForm("frm_ClientOrders");
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_ClientOrders"))
            {
                f.BringToFront();
                return;
            }
            ClientOrders = new frm_ClientOrders();
            ClientOrders._Main = this;
            ClientOrders.Show(pn_Main);
            
        }

        private void btn_PurchaseOrders_Click(object sender, EventArgs e)
        {
            //OpenDockContentForm("frm_PurchaseOrders");
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_PurchaseOrders"))
            {
                f.BringToFront();
                return;
            }
            PurchaseOrders = new frm_PurchaseOrders();
            PurchaseOrders._Main = this;
            PurchaseOrders.Show(pn_Main);
        }

        private void btn_CatalogList_Click(object sender, EventArgs e)
        {
            //OpenDockContentForm("frm_CatalogList");
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_CatalogList"))
            {
                f.BringToFront();
                return;
            }
            Catalog = new frm_CatalogList();
            Catalog._Main = this;
            Catalog.Show(pn_Main);
        }

        private void btn_StockInwards_Click(object sender, EventArgs e)
        {
            //OpenDockContentForm("frm_StockInwards");

            foreach (var f in MdiChildren.Where(f => f.Name == "frm_StockInwards"))
            {
                f.BringToFront();
                return;
            }
            StockInwards = new frm_StockInwards();
            StockInwards._Main = this;
            // public Main _Main;
            //Articles.InitiateResize();
            StockInwards.Show(pn_Main);
        }

        private void kryptonRibbonGroupButton29_Click(object sender, EventArgs e)
        {
            frm_Test frm = new frm_Test();
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_Inventory_Click(object sender, EventArgs e)
        {
            //OpenDockContentForm("frm_Inventory");

            foreach (var f in MdiChildren.Where(f => f.Name == "frm_Inventory"))
            {
                f.BringToFront();
                return;
            }
            Inventory = new frm_Inventory();
            Inventory._Main = this;
            // public Main _Main;
            //Articles.InitiateResize();
            Inventory.Show(pn_Main);
        }

        private void btn_Placement_Click(object sender, EventArgs e)
        {
            frm_AddStockPlacement frm = new frm_AddStockPlacement();
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_Movement_Click(object sender, EventArgs e)
        {
            //OpenDockContentForm("frm_Movement");

            foreach (var f in MdiChildren.Where(f => f.Name == "frm_Movement"))
            {
                f.BringToFront();
                return;
            }
            StockMovement = new frm_Movement();
            StockMovement._Main = this;
            // public Main _Main;
            //Articles.InitiateResize();
            StockMovement.Show(pn_Main);
        }

        
        private void kryptonRibbonGroupButton8_Click(object sender, EventArgs e)
        {
            //OpenDockContentForm("frm_Test");
        }

        private void kryptonRibbonGroupButton20_Click(object sender, EventArgs e)
        {
            
        }

        private void cmb_Consumption_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_StockOut"))
            {
                f.BringToFront();
                return;
            }
            StockOut = new frm_StockOut();
            StockOut._Main = this;
            // public Main _Main;
            //Articles.InitiateResize();
            StockOut.Show(pn_Main);
        }

        private void btn_OutRequest_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_Requests"))
            {
                f.BringToFront();
                return;
            }
            Requests = new frm_Requests();
            Requests._frm_Main = this;
            Requests.EnabledButtons = true;
            // public Main _Main;
            //Articles.InitiateResize();
            Requests.Show(pn_Main);
        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
            frm_UsersList frm = new frm_UsersList();
            frm.FillList();
           
            frm.Show(); frm.GetKryptonFormFields();
            frm.gv_List.ThreadSafeCall(delegate { frm.SetCellsColor(); });
        }

        private void kryptonRibbonGroupButton37_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_TestKryptonDock"))
            {
                f.BringToFront();
                return;
            }
            KrypDock = new frm_TestKryptonDock();
            KrypDock._frm_Main = this;
            // public Main _Main;
            //Articles.InitiateResize();
            KrypDock.Show(pn_Main);
        }

        private void kryptonRibbonGroupButton38_Click(object sender, EventArgs e)
        {
            frm_TestKrypton frm = new frm_TestKrypton();
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void kryptonRibbonGroupButton39_Click(object sender, EventArgs e)
        {
            //frm_TestSimple frm = new frm_TestSimple();
            //frm.Show(); frm.GetKryptonFormFields();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //Permissions
            int _userid = Convert.ToInt32(Helper.GetOneRecord("select top 1 id from bas_users where userlogin = current_user"));
            

            var data = Tools_BLL.getMenuItems(_userid);


            foreach (ComponentFactory.Krypton.Ribbon.KryptonRibbonTab tab in kryptonRibbon1.RibbonTabs)
            {             
               
                tab.Visible = false;
                foreach (DataRow row in data.Rows)
                {                   
                    if (tab.Text == row["tabtext"].ToString()
                        && Convert.ToInt32(row["id"]) != 0)
                        tab.Visible = true;
                }
                //tab.Visible = false;

            }
            SetRegistryKeys();
            //string path = @"c:/Odin/Odin.exe";
            //string path1 = @"c:/Odin1/Odin.exe";

            //FileVersionInfo myFileVersionInfo = FileVersionInfo.GetVersionInfo(path);
            //FileVersionInfo myFileVersionInfo1 = FileVersionInfo.GetVersionInfo(path1);

            //FileInfo fileInf = new FileInfo(path);
            //if (fileInf.Exists == false
            //   || myFileVersionInfo != myFileVersionInfo1)
            //{
            //    CopyDir("c:/Odin1", "c:/Odin");
            //}
            //else
            //{

            //}
            //Process.Start("c:/Odin/Odin.exe");

            //Application.Exit();
        }

        public void SetRegistryKeys()
        {
            RegistryKey currentUserKey = Registry.CurrentUser;

            RegistryKey ControlPanel = currentUserKey.OpenSubKey("Control Panel");
            RegistryKey International = ControlPanel.OpenSubKey("International", true);
            International.SetValue("iFirstWeekOfYear", "2");
            International.SetValue("sDecimal", ".");
        }
        void CopyDir(string FromDir, string ToDir)
        {
            //Replace old exe file in desctination directory
            foreach (string s1 in Directory.GetFiles(ToDir))
            {
                //delete old exe file
                if (s1 == "Odin.old")
                {
                    File.Delete(ToDir + "\\Odin.old");
                    break;
                }
            }

            foreach (string s1 in Directory.GetFiles(ToDir))
            {
                if (s1 == "Odin.exe")
                {
                    File.Copy(ToDir + "\\Odin.exe", ToDir + "\\Odin.old", true);
                }
            }

            Directory.CreateDirectory(ToDir);
            foreach (string s1 in Directory.GetFiles(FromDir))
            {
                string s2 = ToDir + "\\" + Path.GetFileName(s1);
                File.Copy(s1, s2, true);
            }
            foreach (string s in Directory.GetDirectories(FromDir))
            {
                CopyDir(s, ToDir + "\\" + Path.GetFileName(s));
            }
        }

        private void btn_StockInFC_Click(object sender, EventArgs e)
        {
            frm_StockInwardFPCons frm = new frm_StockInwardFPCons();
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_Delivery_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_Deliveries"))
            {
                f.BringToFront();
                return;
            }
            Deliveries = new frm_Deliveries();
            Deliveries._Main = this;
            // public Main _Main;
            //Articles.InitiateResize();
            Deliveries.Show(pn_Main);
        }

        private void btn_Processing_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_Processing"))
            {
                f.BringToFront();
                return;
            }
            Processing = new frm_Processing();
            Processing._Main = this;
            // public Main _Main;
            //Articles.InitiateResize();
            Processing.Show(pn_Main);
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_StockHistory"))
            {
                f.BringToFront();
                return;
            }
            StockHistory = new frm_StockHistory();
            StockHistory._Main = this;
            StockHistory.FillOperTypes();
            StockHistory.FillLabels();
            // public Main _Main;
            //Articles.InitiateResize();
            StockHistory.Show(pn_Main);
        }

        private void btn_Quotations_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_Quotations"))
            {
                f.BringToFront();
                return;
            }
            Quotations = new frm_Quotations();
            Quotations._Main = this;
            Quotations.ClearDates();
            // public Main _Main;
            //Articles.InitiateResize();
            Quotations.Show(pn_Main);
        }

        private void btn_Notifications_Click(object sender, EventArgs e)
        {
            frm_Mailings frm = new frm_Mailings();
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_Invoices_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_ExpInvoices"))
            {
                f.BringToFront();
                return;
            }
            ExpInvoices = new frm_ExpInvoices();
            ExpInvoices._Main = this;
            ExpInvoices.ClearDates();
            // public Main _Main;
            //Articles.InitiateResize();
            ExpInvoices.Show(pn_Main);
        }

        private void btn_RepIncomes_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_IncomesReports"))
            {
                f.BringToFront();
                return;
            }
            IncomeReports = new frm_IncomesReports();
            IncomeReports._Main = this;
            IncomeReports.ClearDates();
            // public Main _Main;
            //Articles.InitiateResize();
            IncomeReports.Show(pn_Main);
        }

        private void btn_RptSelling_Click(object sender, EventArgs e)
        {
            foreach(var f in MdiChildren.Where(f => f.Name == "frm_SellingReports"))
            {
                f.BringToFront();
                return;
            }
            SellingReports = new frm_SellingReports();
            SellingReports._Main = this;
            SellingReports.ClearDates();
            // public Main _Main;
            //Articles.InitiateResize();
            SellingReports.Show(pn_Main);
        }

        private void btn_Deficite_Click(object sender, EventArgs e)
        {
            frm_ProdRMDeficite frm = new frm_ProdRMDeficite();
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_Export1c_Click(object sender, EventArgs e)
        {
            frm_Export1C frm = new frm_Export1C();
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_LabelDesigner_Click(object sender, EventArgs e)
        {
            frm_LabelDesigner frm = new frm_LabelDesigner();
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_RestCorrection_Click(object sender, EventArgs e)
        {
            if (glob_Class.IsFormAlreadyOpen("frm_RestCorrection")) return;

            frm_RestCorrection frm = new frm_RestCorrection();
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_AskRM_Click(object sender, EventArgs e)
        {
            frm_AddRequestSimple frm = new frm_AddRequestSimple();
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_RequestFromLog_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_Requests"))
            {
                f.BringToFront();
                return;
            }
            Requests = new frm_Requests();
            Requests._frm_Main = this;
            Requests.EnabledButtons = true;
            // public Main _Main;
            //Articles.InitiateResize();
            Requests.Show(pn_Main);
        }

        private void btn_RequestFromProductoin_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_Requests"))
            {
                f.BringToFront();
                return;
            }
            Requests = new frm_Requests();
            Requests._frm_Main = this;
            Requests.EnabledButtons = false;
            // public Main _Main;
            //Articles.InitiateResize();
            Requests.Show(pn_Main);
        }

        private void btn_RepInventory_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_InventoryReport"))
            {
                f.BringToFront();
                return;
            }
            InventoryReports = new frm_InventoryReport();
            InventoryReports._Main = this;
            InventoryReports.Show(pn_Main);
        }

        private void btn_BOMManagement_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_BOMManagement"))
            {
                f.BringToFront();
                return;
            }
            BOM = new frm_BOMManagement();
            BOM._Main = this;
            // public Main _Main;
            //Articles.InitiateResize();
            BOM.Show(pn_Main);
        }

        private void btn_DeliveryPlanning_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_DeliveryPlanning"))
            {
                f.BringToFront();
                return;
            }
            DeliveryPlanning = new frm_DeliveryPlanning();
            DeliveryPlanning._Main = this;
            // public Main _Main;
            //Articles.InitiateResize();
            DeliveryPlanning.Show(pn_Main);
        }

        private void btn_DeliveryPlanning1_Click(object sender, EventArgs e)
        {
            btn_DeliveryPlanning.PerformClick();
        }

        private void btn_Profitability_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_ProfitReports"))
            {
                f.BringToFront();
                return;
            }
            ProfitRep = new frm_ProfitReports();
            ProfitRep._Main = this;
            // public Main _Main;
            //Articles.InitiateResize();
            ProfitRep.Show(pn_Main);
        }

        private void btn_MovementReport_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_MovementReports"))
            {
                f.BringToFront();
                return;
            }
            MovementReport = new frm_MovementReports();
            MovementReport._Main = this;
            MovementReport.ClearDates();
            // public Main _Main;
            //Articles.InitiateResize();
            MovementReport.Show(pn_Main);
        }

        private void btn_IncomeControlList_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_IncomeControl"))
            {
                f.BringToFront();
                return;
            }
            IncomeControlList = new frm_IncomeControl();
            IncomeControlList._Main = this;
           // public Main _Main;
            //Articles.InitiateResize();
            IncomeControlList.Show(pn_Main);
        }

        private void btn_MenuPermission_Click(object sender, EventArgs e)
        {
            frm_MenuPermissions frm = new frm_MenuPermissions();
            frm.FillList();
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_RMOverview_Click(object sender, EventArgs e)
        {
            frm_RMOverview frm = new frm_RMOverview();
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_Currencies_Click(object sender, EventArgs e)
        {
            frm_CurRates frm = new frm_CurRates();
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_Capacity_Click(object sender, EventArgs e)
        {
            frm_Capacity frm = new frm_Capacity();
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_Debug_Click(object sender, EventArgs e)
        {
            var _query = "sp_Debug";

            var sqlparams = new List<SqlParameter>()
            {
           
            };

            Template_DataGridView frm = new Template_DataGridView();

            frm.Text = "Debug results: ";
            frm.Query = _query;
            frm.SqlParams = sqlparams;
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_DocRegister_Click(object sender, EventArgs e)
        {

            frm_DocumentRegister frm = new frm_DocumentRegister();
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_ProductCard_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_ProductCard"))
            {
                f.BringToFront();
                return;
            }
            ProductCard = new frm_ProductCard();
            ProductCard._Main = this;
            ProductCard.Show(pn_Main);
        }

        private void btn_LockPeriod_Click(object sender, EventArgs e)
        {
            string BlockDate = Helper.GetOneRecord("select top 1 convert(nvarchar(10), blockdate, 103) as blockdate from bas_blockdate").ToString();

            frm_cmbDate frm = new frm_cmbDate();
            try { frm.Date = BlockDate; }
            catch { frm.Date = System.DateTime.Now.ToShortDateString(); }

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                FinBLL.SetBlockDate(frm.Date);
            }

        }

        private void btn_SerialNumbers_Click(object sender, EventArgs e)
        {
            //OpenDockContentForm("frm_Batches");
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_SerialNumbers"))
            {
                f.BringToFront();
                return;
            }
            SerialNumbers = new frm_SerialNumbers();
            SerialNumbers._frm_Main = this;
            SerialNumbers.Show(pn_Main);
        }

        private void btn_ProdIndicator_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_ProductivityIndicator"))
            {
                f.BringToFront();
                return;
            }
            ProdIndicators = new frm_ProductivityIndicator();
            ProdIndicators._frm_Main = this;
            ProdIndicators.Show(pn_Main);
        }

        private void btn_TestForm_Click(object sender, EventArgs e)
        {
            frm_Test frm = new frm_Test();
            frm.Show(); frm.GetKryptonFormFields();
           
        }

        private void btn_MoveByScan_Click(object sender, EventArgs e)
        {
            if (glob_Class.IsFormAlreadyOpen("frm_MovePDA")) return;

            frm_MovePDA frm = new frm_MovePDA();
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_CheckAccounts_Click(object sender, EventArgs e)
        {
            frm_CheckAccounts frm = new frm_CheckAccounts();
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_StockOutPDA_Click(object sender, EventArgs e)
        {
            if (glob_Class.IsFormAlreadyOpen("frm_StockOutPDA")) return;


            frm_StockOutPDA frm = new frm_StockOutPDA();
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_SerialTracing_Click(object sender, EventArgs e)
        {
            if (glob_Class.IsFormAlreadyOpen("frm_SerialTracing")) return;

            frm_SerialTracing frm = new frm_SerialTracing();
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DAL.DeleteBatchLockAll();
        }

        private void btn_QCTraceView_Click(object sender, EventArgs e)
        {
            if (glob_Class.IsFormAlreadyOpen("frm_QCTracingView")) return;

            frm_QCTracingView frm = new frm_QCTracingView();
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_QCSerialFreezed_Click(object sender, EventArgs e)
        {
            if (glob_Class.IsFormAlreadyOpen("frm_QCSerialFreezed")) return;

            frm_QCSerialFreezed frm = new frm_QCSerialFreezed();
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_FCPacking_Click(object sender, EventArgs e)
        {
            if (glob_Class.IsFormAlreadyOpen("frm_FCPacking")) return;

            frm_FCPacking frm = new frm_FCPacking();
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_ROInventory_Click(object sender, EventArgs e)
        {
            //OpenDockContentForm("frm_Inventory");

            foreach (var f in MdiChildren.Where(f => f.Name == "frm_Inventory"))
            {
                f.BringToFront();
                return;
            }
            Inventory = new frm_Inventory();
            Inventory._Main = this;
            // public Main _Main;
            //Articles.InitiateResize();
            Inventory.Show(pn_Main);
        }

        private void btn_RArticles_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_ArticlesManagement"))
            {
                f.BringToFront();
                return;
            }
            Articles = new frm_ArticlesManagement();
            Articles._Main = this;
            // public Main _Main;
            //Articles.InitiateResize();
            Articles.Show(pn_Main);

        }

        private void btn_StockInwardsRO_Click(object sender, EventArgs e)
        {

            foreach (var f in MdiChildren.Where(f => f.Name == "frm_StockInwards"))
            {
                f.BringToFront();
                return;
            }
            StockInwards = new frm_StockInwards();
            StockInwards._Main = this;
            StockInwards.DisableActionButtons();
            // public Main _Main;
            //Articles.InitiateResize();
            StockInwards.Show(pn_Main);
        }

        private void btn_Launch_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_LaunchesPlanning"))
            {
                f.BringToFront();
                return;
            }
            Launches = new frm_LaunchesPlanning();
            Launches._Main = this;
            Launches.Show(pn_Main);
        }

        private void btn_Payments_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_PaymentReport"))
            {
                f.BringToFront();
                return;
            }
            Payments = new frm_PaymentReport();
            Payments._Main = this;
            Payments.Show(pn_Main);
        }

        private void btn_Intrastat_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_Intrastat"))
            {
                f.BringToFront();
                return;
            }
            Intrastat = new frm_Intrastat();
            Intrastat._Main = this;
            Intrastat.Show(pn_Main);
        }

        private void btn_ImmidiateConsumption_Click(object sender, EventArgs e)
        {
            if (glob_Class.IsFormAlreadyOpen("frm_ImmidiateConsumption")) return;

            frm_ImmidiateConsumption frm = new frm_ImmidiateConsumption();
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_BatchRatio_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_BatchesRatioPortfolio"))
            {
                f.BringToFront();
                return;
            }
            BatchesRatio = new frm_BatchesRatioPortfolio();
            BatchesRatio._Main = this;
            BatchesRatio.Show(pn_Main);
        }

        private void btn_DeadStock_Click(object sender, EventArgs e)
        {
            if (glob_Class.IsFormAlreadyOpen("frm_DeadStock")) return;

            frm_DeadStock frm = new frm_DeadStock();
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_NeedsProcessing_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_NeedsProcessing"))
            {
                f.BringToFront();
                return;
            }
            NeedsProcessing = new frm_NeedsProcessing();
            NeedsProcessing._Main = this;
            NeedsProcessing.Show(pn_Main);
        }

        private void btn_StaffPresence_Click(object sender, EventArgs e)
        {
            frm_AddDayStuff frm = new frm_AddDayStuff();
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_Package_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_Packing"))
            {
                f.BringToFront();
                return;
            }
            Packing = new frm_Packing();
            Packing._frm_Main = this;
            Packing.Show(pn_Main);
        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            
            //if (this.WindowState == FormWindowState.Normal)
            //{
            //    this.WindowState = FormWindowState.Maximized;
            //}
        }

        private void Main_ResizeBegin(object sender, EventArgs e)
        {
            
        }

        private void Main_ResizeEnd(object sender, EventArgs e)
        {
           
        }

        private void Main_MinimumSizeChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Minimized!");
        }
                
        private void Main_Resize(object sender, EventArgs e)
        {
            this.Refresh();
            //if (WindowState != LastWindowState)
            //{
            //    LastWindowState = WindowState;
                
            //    if (WindowState == FormWindowState.Maximized)
            //    {
                                       
            //        // Maximized
            //    }
            //    if (WindowState == FormWindowState.Normal)
            //    {

            //        // Normal
            //    }
            //}
        }
        FormWindowState LastWindowState = FormWindowState.Minimized;

        private void btn_LaunchPassport_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_LaunchPassport"))
            {
                f.BringToFront();
                return;
            }
            LaunchPassport = new frm_LaunchPassport();
            LaunchPassport._frm_Main = this;
            LaunchPassport.Show(pn_Main);
        }

        private void btn_LaunchCommentsReview_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_LaunchPassportComments"))
            {
                f.BringToFront();
                return;
            }
            LaunchPassportComments = new frm_LaunchPassportComments();
            LaunchPassportComments._frm_Main = this;
            LaunchPassportComments.Show(pn_Main);
        }

        private void btn_Worker_Click(object sender, EventArgs e)
        {
            if (glob_Class.IsFormAlreadyOpen("frm_Workers")) return;

            frm_Workers frm = new frm_Workers();
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_WorkersData_Click(object sender, EventArgs e)
        {
            //foreach (var f in MdiChildren.Where(f => f.Name == "frm_DataCollection"))
            //{
            //    f.BringToFront();
            //    return;
            //}
            //DataCollection = new frm_DataCollection();
            //DataCollection._frm_Main = this;
            //DataCollection.Show(pn_Main);

            foreach (var f in MdiChildren.Where(f => f.Name == "frm_WorkerDCOper"))
            {
                f.BringToFront();
                return;
            }
            WorkerDCOper = new frm_WorkerDCOper();
            WorkerDCOper._frm_Main = this;
            WorkerDCOper.Show(pn_Main);
            WorkerDCOper.FillPlace();
            //foreach (var f in MdiChildren.Where(f => f.Name == "frm_WorkerDC"))
            //{
            //    f.BringToFront();
            //    return;
            //}
            //WorkerDC = new frm_WorkerDC();
            //WorkerDC._frm_Main = this;
            //WorkerDC.Show(pn_Main);
        }

        private void btn_ControlCard_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_MasterApproveTot"))
            {
                f.BringToFront();
                return;
            }
            MasterApproveTot = new frm_MasterApproveTot();
            MasterApproveTot._frm_Main = this;
            MasterApproveTot.Show(pn_Main);
        }

        private void btn_DCApprove_Click(object sender, EventArgs e)
        {
            //foreach (var f in MdiChildren.Where(f => f.Name == "frm_DataCollection"))
            //{
            //    f.BringToFront();
            //    return;
            //}
            //DataCollection = new frm_DataCollection();
            //DataCollection._frm_Main = this;
            //DataCollection.Show(pn_Main);
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_MasterApproveFin"))
            {
                f.BringToFront();
                return;
            }
            MasterApprove = new frm_MasterApproveFin();
            MasterApprove._frm_Main = this;
            MasterApprove.Show(pn_Main);
            MasterApprove.FillPlace();
            MasterApprove.gv_List.ThreadSafeCall(delegate { MasterApprove.FillList(); });
        }

        private void btn_KillDeadlocks_Click(object sender, EventArgs e)
        {
            int _blockid = 0;
            string _userprocess = "";
            _blockid = Convert.ToInt32(Helper.GetOneRecord("use master select top 1 blocked from sysprocesses where blocked != 0"));
            if (_blockid != 0)
            {
                _userprocess = Helper.GetOneRecord("use master select top 1 loginame from sysprocesses where spid = " + _blockid).ToString();
                var query = "Kill " + _blockid;
                Helper.ExecuteQuery(query);
                MessageBox.Show("Deadlock from " + _userprocess + " was killed!");
            }
            else
                MessageBox.Show("There are no deadlocks!");
            /*select * from sysprocesses

            order by blocked desc

            --,program_name


            --kill 181*/
        }

        private void btn_prodresult_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_ProductionResult"))
            {
                f.BringToFront();
                return;
            }
            ProdResult = new frm_ProductionResult();
            ProdResult._frm_Main = this;
            ProdResult.Show(pn_Main);
        }

        private void btn_LaunchPlanningG_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_LaunchesPlanningG"))
            {
                f.BringToFront();
                return;
            }
            LaunchesG = new frm_LaunchesPlanningG();
            LaunchesG._Main = this;
            LaunchesG.Show(pn_Main);
        }

        private void btn_BatchProject_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_BatchProjects"))
            {
                f.BringToFront();
                return;
            }
            BatchProjects = new frm_BatchProjects();
            BatchProjects._Main = this;
            BatchProjects.Show(pn_Main);
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_BatchesNew"))
            {
                f.BringToFront();
                return;
            }
            BatchesNew = new frm_BatchesNew();
            BatchesNew._Main = this;
            BatchesNew.Show(pn_Main);
        }

        private void btn_BatchManagementP_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_BatchesNew"))
            {
                f.BringToFront();
                return;
            }
            BatchesNew = new frm_BatchesNew();
            BatchesNew._Main = this;
            BatchesNew.Show(pn_Main);
        }

        private void btn_InvalidBOMs_Click(object sender, EventArgs e)
        {
            var _query = "sp_SelectInvalideBOMs";

            var sqlparams = new List<SqlParameter>()
            {

            };

            Template_DataGridView frm = new Template_DataGridView();

            frm.Text = "Invalide BOM's list ";
            frm.Query = _query;
            frm.SqlParams = sqlparams;
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_LaunchGroup_Click(object sender, EventArgs e)
        {
            if (glob_Class.IsFormAlreadyOpen("frm_LaunchGrouping")) return;

            frm_LaunchGrouping frm = new frm_LaunchGrouping();
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_BatchProject1_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_BatchProjects"))
            {
                f.BringToFront();
                return;
            }
            BatchProjects = new frm_BatchProjects();
            BatchProjects._Main = this;
            BatchProjects.Show(pn_Main);
        }

        private void btn_PCBLabels_Click(object sender, EventArgs e)
        {
            if (glob_Class.IsFormAlreadyOpen("frm_WorkshopLabels")) return;

            frm_WorkshopLabels frm = new frm_WorkshopLabels();
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_ProjectPlanning_Click(object sender, EventArgs e)
        {
            if (glob_Class.IsFormAlreadyOpen("frm_ProjectPlanning")) return;


            frm_ProjectPlanning frm = new frm_ProjectPlanning();
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_PlanningView_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_ProjectPlanningV2"))
            {
                f.BringToFront();
                return;
            }
            PlanningView = new frm_PlanningView();
            PlanningView._Main = this;
            PlanningView.Show(pn_Main);
        }

        private void btn_Turnover_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren.Where(f => f.Name == "frm_TurnoverReports"))
            {
                f.BringToFront();
                return;
            }
            TurnoverReport = new frm_TurnoverReports();
            TurnoverReport._Main = this;
            TurnoverReport.ClearDates();
            // public Main _Main;
            //Articles.InitiateResize();
            TurnoverReport.Show(pn_Main);
        }
    }
}

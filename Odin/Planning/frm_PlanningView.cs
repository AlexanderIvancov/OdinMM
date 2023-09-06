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
using Odin.Global_Classes;
using Odin.Tools;
using System.Data.SqlClient;
using Braincase.GanttChart;

namespace Odin.Planning
{


    public partial class frm_PlanningView : BaseForm
    {
        OverlayPainter _mOverlay = new OverlayPainter();

        ProjectManager _mManager = null;

        public frm_PlanningView()
        {
            InitializeComponent();
            txt_DocDate.Value = System.DateTime.Now;
        }
        #region Variables
        Plan_BLL PlanBll = new Plan_BLL();
        class_Global globClass = new class_Global();
        public Braincase.GanttChart.Task PubTask;

        public double _NSMT
        {
            get; set;
        }
        public double _NTHT
        {
            get; set;
        }
        public double _NQSMT
        {
            get; set;
        }
        public double _NQTHT
        {
            get; set;
        }
        public double _NFTA
        {
            get; set;
        }
        public double _NFQC
        {
            get; set;
        }
        public double _NXRAY
        {
            get; set;
        }
        public double _NIPA
        {
            get; set;
        }
        public double _NGPA
        {
            get; set;
        }

        public double NSMT
        {
            get
            {
                try { return Convert.ToDouble(txt_NSMT.Text); }
                catch { return 0; }
            }
            set { txt_NSMT.Text = value.ToString(); }
        }
        public double NTHT
        {
            get
            {
                try { return Convert.ToDouble(txt_NTHT.Text); }
                catch { return 0; }
            }
            set { txt_NTHT.Text = value.ToString(); }
        }
        public double NQSMT
        {
            get
            {
                try { return Convert.ToDouble(txt_NQSMT.Text); }
                catch { return 0; }
            }
            set { txt_NQSMT.Text = value.ToString(); }
        }
        public double NQTHT
        {
            get
            {
                try { return Convert.ToDouble(txt_NQTHT.Text); }
                catch { return 0; }
            }
            set { txt_NQTHT.Text = value.ToString(); }
        }
        public double NFTA
        {
            get
            {
                try { return Convert.ToDouble(txt_NFTA.Text); }
                catch { return 0; }
            }
            set { txt_NFTA.Text = value.ToString(); }
        }
        public double NFQC
        {
            get
            {
                try { return Convert.ToDouble(txt_NFQC.Text); }
                catch { return 0; }
            }
            set { txt_NFQC.Text = value.ToString(); }
        }
        public double NXRAY
        {
            get
            {
                try { return Convert.ToDouble(txt_NXray.Text); }
                catch { return 0; }
            }
            set { txt_NXray.Text = value.ToString(); }
        }
        public double NIPA
        {
            get
            {
                try { return Convert.ToDouble(txt_NIPA.Text); }
                catch { return 0; }
            }
            set { txt_NIPA.Text = value.ToString(); }
        }
        public double NGPA
        {
            get
            {
                try { return Convert.ToDouble(txt_NGPA.Text); }
                catch { return 0; }
            }
            set { txt_NGPA.Text = value.ToString(); }
        }

        public double CSMT
        {
            get
            {
                try { return Convert.ToDouble(txt_CSMT.Text); }
                catch { return 0; }
            }
            set { txt_CSMT.Text = value.ToString(); }
        }
        public double CTHT
        {
            get
            {
                try { return Convert.ToDouble(txt_CTHT.Text); }
                catch { return 0; }
            }
            set { txt_CTHT.Text = value.ToString(); }
        }
        public double CQSMT
        {
            get
            {
                try { return Convert.ToDouble(txt_QCSMT.Text); }
                catch { return 0; }
            }
            set { txt_QCSMT.Text = value.ToString(); }
        }
        public double CQTHT
        {
            get
            {
                try { return Convert.ToDouble(txt_CQTHT.Text); }
                catch { return 0; }
            }
            set { txt_CQTHT.Text = value.ToString(); }
        }
        public double CFTA
        {
            get
            {
                try { return Convert.ToDouble(txt_CFTA.Text); }
                catch { return 0; }
            }
            set { txt_CFTA.Text = value.ToString(); }
        }
        public double CFQC
        {
            get
            {
                try { return Convert.ToDouble(txt_CFQC.Text); }
                catch { return 0; }
            }
            set { txt_CFQC.Text = value.ToString(); }
        }
        public double CXRAY
        {
            get
            {
                try { return Convert.ToDouble(txt_CXRay.Text); }
                catch { return 0; }
            }
            set { txt_CXRay.Text = value.ToString(); }
        }
        public double CIPA
        {
            get
            {
                try { return Convert.ToDouble(txt_CIPA.Text); }
                catch { return 0; }
            }
            set { txt_CIPA.Text = value.ToString(); }
        }
        public double CGPA
        {
            get
            {
                try { return Convert.ToDouble(txt_CGPA.Text); }
                catch { return 0; }
            }
            set { txt_CGPA.Text = value.ToString(); }
        }

        #endregion
        #region Methods

        public void ShowCapacity(int weekoper)
        {
            var data = Plan_BLL.getPlanningCapa(weekoper);

            foreach (DataRow row in data.Rows)
            {
                switch (Convert.ToInt32(row["stageid"]))
                {
                    case 1:
                        NSMT = Convert.ToDouble(row["stagetime"]);
                        _NSMT = Convert.ToDouble(row["stagetime"]);
                        break;
                    case 2:
                        NTHT = Convert.ToDouble(row["stagetime"]);
                        _NTHT = Convert.ToDouble(row["stagetime"]);
                        break;
                    case 3:
                        NFTA = Convert.ToDouble(row["stagetime"]);
                        _NFTA = Convert.ToDouble(row["stagetime"]);
                        break;
                    case 4:
                        NIPA = Convert.ToDouble(row["stagetime"]);
                        _NIPA = Convert.ToDouble(row["stagetime"]);
                        break;
                    case 5:
                        NQSMT = Convert.ToDouble(row["stagetime"]);
                        _NQSMT = Convert.ToDouble(row["stagetime"]);
                        break;
                    case 6:
                        NQTHT = Convert.ToDouble(row["stagetime"]);
                        _NQTHT = Convert.ToDouble(row["stagetime"]);
                        break;
                    case 7:
                        NFQC = Convert.ToDouble(row["stagetime"]);
                        _NFQC = Convert.ToDouble(row["stagetime"]);
                        break;
                    case 9:
                        NXRAY = Convert.ToDouble(row["stagetime"]);
                        _NXRAY = Convert.ToDouble(row["stagetime"]);
                        break;
                    default:
                        NGPA = Convert.ToDouble(row["stagetime"]);
                        _NGPA = Convert.ToDouble(row["stagetime"]);
                        break;
                }
            }
        }

        private void SetScrollDate()
        {
            chart1.ScrollTo(System.DateTime.Now);
            chart1.Invalidate();
        }

        public void RefreshGrid()
        {

            //_mManager = new ProjectManager();

            double CompletePerc = 0;
            string _tmpname = "";
            //double _Separ = 1;

            var data = Plan_BLL.getPlanningView(cmb_Firms1.FirmId, txt_DocDate.Value.ToShortDateString());

            DataRow[] datacor = data.Select("ispre = -99");

            DataTable dataco = null;
            if (datacor.Any())
            {
                dataco = datacor.CopyToDataTable();

                _mManager = new ProjectManager();
                _mManager.Start = txt_DocDate.Value;
                //var work = new MyTask(_mManager) { Name = "Prepare for Work" };
                //var wake = new MyTask(_mManager) { Name = "Wake Up" };
                //var teeth = new MyTask(_mManager) { Name = "Brush Teeth" };
                //var shower = new MyTask(_mManager) { Name = "Shower" };
                //var clothes = new MyTask(_mManager) { Name = "Change into New Clothes" };
                //var hair = new MyTask(_mManager) { Name = "Blow My Hair" };
                //var pack = new MyTask(_mManager) { Name = "Pack the Suitcase" };

                //_mManager.Add(work);
                //_mManager.Add(wake);
                //_mManager.Add(teeth);
                //_mManager.Add(shower);
                //_mManager.Add(clothes);
                //_mManager.Add(hair);
                //_mManager.Add(pack);

                // Create another 1000 tasks for stress testing
                //Random rand = new Random();
                //for (int i = 0; i < 1000; i++)
                //{
                //    var task = new MyTask(_mManager) { Name = string.Format("New Task {0}", i.ToString()) };
                //    _mManager.Add(task);
                //    _mManager.SetStart(task, TimeSpan.FromDays(rand.Next(300)));
                //    _mManager.SetDuration(task, TimeSpan.FromDays(rand.Next(50)));
                //}
                foreach (DataRow row in dataco.Rows)
                {
                    DateTime now = DateTime.Now;
                    DateTime then = Convert.ToDateTime(row["enddate"]);

                    TimeSpan ts = (now - _mManager.Start) + (then - now);

                    var task = new MyTask(_mManager) { Name = row["conforder"].ToString() + ", article: " + row["article"].ToString() + " , qty: " + row["qty"].ToString() + ",  " + row["customer"].ToString() };
                    _mManager.Add(task);
                    _mManager.SetStart(task, ts);
                    //_mManager.SetDuration(task, ts);



                    DataRow[] dataprojectr = data.Select("ispre = -1 and coid = " + Convert.ToInt32(row["coid"]));
                    foreach (DataRow row1 in dataprojectr)
                    {
                        DateTime then1 = Convert.ToDateTime(row1["startdate"]);
                        TimeSpan ts1 = (now - _mManager.Start) + (then1 - now);

                        //MessageBox.Show(ts1.TotalDays.ToString());

                        //var childtask = new MyTask(_mManager) { Name = row1["batch"].ToString() + " , qty: " + row1["qty"].ToString() };

                        //Projects
                        var childtask = new MyTask(_mManager)
                        {
                            Name = row1["batch"].ToString() + ", article: " + row1["article"].ToString() + " , qty: " + row1["qty"].ToString()
                                                                    + (Convert.ToInt32(row1["ismisc"]) == 0 && Convert.ToInt32(row1["isold"]) == 0 ? " , planned: " : " , produced: ")
                                                                    + (Convert.ToInt32(row1["isold"]) == 0 ? row1["qtyplanned"].ToString() : row1["qtyin"].ToString())
                        };
                        _mManager.Add(childtask);
                        _mManager.SetStart(childtask, /*TimeSpan.FromDays(ts1.TotalDays)*/ts1);
                        _mManager.SetDuration(childtask, TimeSpan.FromDays(7));
                        _mManager.Group(task, childtask);

                        var _resourse = new MyResource()
                        {
                            Name = row1["batch"].ToString() + ", article: " + row1["article"].ToString()
                                                                   + " , qty: " + row1["qty"].ToString()
                                                                   + " , conf.order: " + row1["conforder"].ToString()
                                                                   + " , customer: " + row1["customer"].ToString(),
                            BatchId = Convert.ToInt32(row1["batchid"]),
                            IsPlan = Convert.ToInt32(row1["isplan"]),
                            Week = row1["weekoper"].ToString(),
                            Qty = Convert.ToDouble(row1["qty"]),
                            IsPre = Convert.ToInt32(row1["ispre"]),
                            PlanId = Convert.ToInt32(row1["planid"]),
                            QtyPlanned = Convert.ToDouble(row1["qtyplanned"]),
                            QtyIn = Convert.ToDouble(row1["qtyin"]),
                            IsMisc = Convert.ToInt32(row1["ismisc"]),
                            IsOld = Convert.ToInt32(row1["isold"]),
                            Comments = row1["comments"].ToString()
                        };
                        _mManager.Assign(childtask, _resourse);

                        if (Convert.ToDouble(row1["qty"]) == 0
                            || Convert.ToDouble(row["qty"]) == 0)
                            CompletePerc = 1;
                        else
                        {
                            if (Convert.ToInt32(row1["ismisc"]) == 0 && Convert.ToInt32(row1["isold"]) == 0)
                                CompletePerc = Convert.ToDouble(row1["qty"]) / (Convert.ToDouble(row1["qty"]) + Convert.ToDouble(row1["qtyinbatch"]));
                            //CompletePerc = (Convert.ToDouble(row["qty"]) - Convert.ToDouble(row1["qty"])) / Convert.ToDouble(row["qty"]);
                            else
                            {
                                CompletePerc = 1 * Convert.ToDouble(row1["qtyin"]) / Convert.ToDouble(row1["qty"]);
                            }
                        }
                        //100 * (Convert.ToDouble(row["qty"]) - Convert.ToDouble(row1["qty"])) / (Convert.ToDouble(row1["qty"]) == 0 ? 100 : Convert.ToDouble(row2["qtyin"]) : Convert.ToDouble(row2["qty"]));

                        childtask.Complete = class_Global.ToSingle(CompletePerc);

                        //childtask.Complete = 1f;
                        // _mManager.Relate(task, childtask);

                        DataRow[] databatch = data.Select("ispre = 0 and coid = " + Convert.ToInt32(row["coid"]));
                        foreach (DataRow row2 in databatch)
                        {
                            DateTime then2 = Convert.ToDateTime(row2["startdate"]);
                            TimeSpan ts2 = (now - _mManager.Start) + (then2 - now);

                            if (Convert.ToInt32(row2["ismisc"]) == 0)
                                _tmpname = Name = row2["batch"].ToString() + " , qty: " + row2["qty"].ToString() + " , qty produced: " + row2["qtyin"].ToString();
                            else
                                _tmpname = Name = row2["batch"].ToString() + " , qty: " + row2["qty"].ToString() + " , qty produced: " + row2["qtyin"].ToString() + " , article: " + row2["article"].ToString();

                            //_tmpname = _tmpname + System.Environment.NewLine + row2["comments"].ToString();

                            var childtask1 = new MyTask(_mManager) { Name = _tmpname };

                            _mManager.Add(childtask1);
                            _mManager.SetStart(childtask1, ts2);
                            _mManager.SetDuration(childtask1, TimeSpan.FromDays(7));
                            _mManager.Group(task, childtask1);
                            _mManager.Relate(childtask, childtask1);


                            if (Convert.ToDouble(row2["qty"]) == 0
                                || Convert.ToInt32(row2["ismisc"]) == -1)
                                CompletePerc = 1;
                            else
                                CompletePerc = 1 * Convert.ToDouble(row2["qtyin"]) / Convert.ToDouble(row2["qty"]);

                            childtask1.Complete = class_Global.ToSingle(CompletePerc);


                            //if (Convert.ToInt32(row2["isplan"]) != -1)
                            //    childtask1.Complete = 1f;
                            //else
                            //    childtask1.Complete = 0f;


                            //Create and assign some resourses
                            var _resourse1 = new MyResource()
                            {
                                Name = row2["batch"].ToString()
                                                                    + " , qty: " + row2["qty"].ToString()
                                                                    + " , conf.order: " + row2["conforder"].ToString()
                                                                    + " , customer: " + row2["customer"].ToString() +
                                                                    (Convert.ToInt32(row2["ismisc"]) == 0 ? "" : " , article: " + row2["article"].ToString()),
                                BatchId = Convert.ToInt32(row2["batchid"]),
                                IsPlan = Convert.ToInt32(row2["isplan"]),
                                Week = row2["weekoper"].ToString(),
                                Qty = Convert.ToDouble(row2["qty"]),
                                IsPre = Convert.ToInt32(row2["ispre"]),
                                PlanId = Convert.ToInt32(row2["planid"]),
                                QtyPlanned = Convert.ToDouble(row2["qtyplanned"]),
                                QtyIn = Convert.ToDouble(row2["qtyin"]),
                                IsMisc = Convert.ToInt32(row2["ismisc"]),
                                IsOld = Convert.ToInt32(row2["isold"]),
                                Comments = row2["comments"].ToString()
                            };
                            _mManager.Assign(childtask1, _resourse1);
                        }
                    }
                }

                //// Set task durations, e.g. using ProjectManager methods 
                //_mManager.SetDuration(wake, TimeSpan.FromDays(3));
                //_mManager.SetDuration(teeth, TimeSpan.FromDays(5));
                //_mManager.SetDuration(shower, TimeSpan.FromDays(7));
                //_mManager.SetDuration(clothes, TimeSpan.FromDays(4));
                //_mManager.SetDuration(hair, TimeSpan.FromDays(3));
                //_mManager.SetDuration(pack, TimeSpan.FromDays(5));

                //// demostrate splitting a task
                //_mManager.Split(pack, new MyTask(_mManager), new MyTask(_mManager), TimeSpan.FromDays(2));

                //// Set task complete status, e.g. using newly created properties
                //wake.Complete = 0.9f;
                //teeth.Complete = 0.5f;
                //shower.Complete = 0.4f;

                //// Give the Tasks some organisation, setting group and precedents
                //_mManager.Group(work, wake);
                //_mManager.Group(work, teeth);
                //_mManager.Group(work, shower);
                //_mManager.Group(work, clothes);
                //_mManager.Group(work, hair);
                //_mManager.Group(work, pack);
                //_mManager.Relate(wake, teeth);
                //_mManager.Relate(wake, shower);
                //_mManager.Relate(shower, clothes);
                //_mManager.Relate(shower, hair);
                //_mManager.Relate(hair, pack);
                //_mManager.Relate(clothes, pack);

                //// Create and assign Resources.
                //// MyResource is just custom user class. The API can accept any object as resource.
                //var jake = new MyResource() { Name = "Jake" };
                //var peter = new MyResource() { Name = "Peter" };
                //var john = new MyResource() { Name = "John" };
                //var lucas = new MyResource() { Name = "Lucas" };
                //var james = new MyResource() { Name = "James" };
                //var mary = new MyResource() { Name = "Mary" };
                //// Add some resources
                //_mManager.Assign(wake, jake);
                //_mManager.Assign(wake, peter);
                //_mManager.Assign(wake, john);
                //_mManager.Assign(teeth, jake);
                //_mManager.Assign(teeth, james);
                //_mManager.Assign(pack, james);
                //_mManager.Assign(pack, lucas);
                //_mManager.Assign(shower, mary);
                //_mManager.Assign(shower, lucas);
                //_mManager.Assign(shower, john);

                //SetScrollDate();

                chart1.ThreadSafeCall(delegate
                {
                    chart1.Init(_mManager);
                    chart1.CreateTaskDelegate = delegate () { return new MyTask(_mManager); };

                    var span = DateTime.Today - _mManager.Start;
                    _mManager.Now = span; // set the "Now" marker at the correct date
                    chart1.TimeResolution = TimeResolution.Day;

                    _InitExampleUI();
                });
            }
        }

        public void AddTask(Braincase.GanttChart.Task maintask, Braincase.GanttChart.Task relatetask)
        {

        }

        public void RemoveTask(Braincase.GanttChart.Task task)
        {


            _mManager.Delete(task);

            RefreshChart();
        }

        public void bw_List(object sender, DoWorkEventArgs e)
        {
            RefreshGrid();
            ShowCapacity(Convert.ToInt32(txt_Capa.Text));
        }

        public void DeleteItem(Braincase.GanttChart.Task tsk)
        {
            int _planid = 0;
            string _week = "";
            string _name = "";
            int _isplan = 0;
            int _ispre = 0;

            try
            {
                _name = _mManager.ResourcesOf(tsk).Select(x => (x as MyResource).Name).FirstOrDefault();
                _planid = _mManager.ResourcesOf(tsk).Select(x => (x as MyResource).PlanId).FirstOrDefault();
                _week = _mManager.ResourcesOf(tsk).Select(x => (x as MyResource).Week).FirstOrDefault();
                _isplan = _mManager.ResourcesOf(tsk).Select(x => (x as MyResource).IsPlan).FirstOrDefault();
                _ispre = _mManager.ResourcesOf(tsk).Select(x => (x as MyResource).IsPre).FirstOrDefault();
            }
            catch { }

            if (_planid != 0
                && _isplan == -1
                && globClass.DeleteConfirm() == true)
            {
                PlanBll.DeleteBatchPlanning(_planid);
                RemoveTask(PubTask);
                //RefreshGrid();
                //bwStart(bw_List);
            }
        }

        public void AddItem(Braincase.GanttChart.Task tsk)
        {
            int _batchid = 0;
            string _week = "";
            double _qty = 0;
            double _qtyplanned = 0;
            string _name = "";
            int _isplan = 0;
            int _ispre = 0;
            int _ismisc = 0;

            try
            {
                _name = _mManager.ResourcesOf(tsk).Select(x => (x as MyResource).Name).FirstOrDefault();
                _batchid = _mManager.ResourcesOf(tsk).Select(x => (x as MyResource).BatchId).FirstOrDefault();
                _week = _mManager.ResourcesOf(tsk).Select(x => (x as MyResource).Week).FirstOrDefault();
                _qty = _mManager.ResourcesOf(tsk).Select(x => (x as MyResource).Qty).FirstOrDefault();
                _qtyplanned = _mManager.ResourcesOf(tsk).Select(x => (x as MyResource).QtyPlanned).FirstOrDefault();
                _isplan = _mManager.ResourcesOf(tsk).Select(x => (x as MyResource).IsPlan).FirstOrDefault();
                _ispre = _mManager.ResourcesOf(tsk).Select(x => (x as MyResource).IsPre).FirstOrDefault();
                _ismisc = _mManager.ResourcesOf(tsk).Select(x => (x as MyResource).IsMisc).FirstOrDefault();

            }
            catch { }

            if (_batchid != 0
                && _isplan == 0
                && _ispre == -1
                && _ismisc == 0)
            {
                frm_AddBatchPlanning frm = new frm_AddBatchPlanning();
                frm.BatchId = _batchid;
                frm.Week = _week;
                frm.Qty = _qty - _qtyplanned;
                frm.PlanDateD = frm.cmb_Week1.FirstDateOfWeek;

                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    PlanBll.AddBatchPlanning(frm.BatchId, frm.Qty, frm.PlanDate, frm.Comments);
                    RefreshGrid();

                    //var _resourse1 = new MyResource()
                    //{
                    //    Name = _name,
                    //    BatchId = _batchid,
                    //    IsPlan = _isplan,
                    //    Week = _week,
                    //    Qty = _qty - frm.Qty,
                    //    IsPre = _ispre,
                    //    PlanId = 0,
                    //    QtyPlanned = _qtyplanned + frm.Qty                      
                    //};

                    //_mManager.Assign(tsk, _resourse1);
                }
            }
        }

        public void EditItem(Braincase.GanttChart.Task tsk)
        {
            int _batchid = 0;
            int _planid = 0;
            string _week = "";
            double _qty = 0;
            string _name = "";
            int _isplan = 0;
            int _ispre = 0;
            int _ismisc = 0;
            string _comments = "";

            try
            {
                _name = _mManager.ResourcesOf(tsk).Select(x => (x as MyResource).Name).FirstOrDefault();
                _batchid = _mManager.ResourcesOf(tsk).Select(x => (x as MyResource).BatchId).FirstOrDefault();
                _planid = _mManager.ResourcesOf(tsk).Select(x => (x as MyResource).PlanId).FirstOrDefault();
                _week = _mManager.ResourcesOf(tsk).Select(x => (x as MyResource).Week).FirstOrDefault();
                _qty = _mManager.ResourcesOf(tsk).Select(x => (x as MyResource).Qty).FirstOrDefault();
                _isplan = _mManager.ResourcesOf(tsk).Select(x => (x as MyResource).IsPlan).FirstOrDefault();
                _ispre = _mManager.ResourcesOf(tsk).Select(x => (x as MyResource).IsPre).FirstOrDefault();
                _ismisc = _mManager.ResourcesOf(tsk).Select(x => (x as MyResource).IsMisc).FirstOrDefault();
                _comments = _mManager.ResourcesOf(tsk).Select(x => (x as MyResource).Comments).FirstOrDefault();
            }
            catch { }

            if (_planid != 0
                && _isplan == -1
                && _ispre == 0
                && _ismisc == 0)
            {
                frm_AddBatchPlanning frm = new frm_AddBatchPlanning();
                frm.HeaderText = "Edit batch planning";
                frm.BatchId = _batchid;
                frm.Week = _week;
                frm.Qty = _qty;
                frm.PlanDateD = frm.cmb_Week1.FirstDateOfWeek;
                frm.Comments = _comments;

                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    PlanBll.EditBatchPlanning(_planid, frm.Qty, frm.PlanDate, frm.Comments);
                    RefreshGrid();
                    //bwStart(bw_List);
                }
            }
        }

        private void RefreshChart()
        {
            chart1.Refresh();
            //chart1.ThreadSafeCall(delegate
            //{
            //    chart1.Init(_mManager);
            //    chart1.CreateTaskDelegate = delegate () { return new MyTask(_mManager); };

            //    var span = DateTime.Today - _mManager.Start;
            //    _mManager.Now = span; 
            //    chart1.TimeResolution = TimeResolution.Day;

            //    _InitExampleUI();
            //});
        }

        private void _InitExampleUI()
        {
            //TaskGridView.DataSource = new BindingSource(_mManager.Tasks, null);
            //mnuFilePrint200.Click += (s, e) => _PrintDocument(2.0f);
            //mnuFilePrint150.Click += (s, e) => _PrintDocument(1.5f);
            //mnuFilePrint100.Click += (s, e) => _PrintDocument(1.0f);
            //mnuFilePrint80.Click += (s, e) => _PrintDocument(0.8f);
            //mnuFilePrint50.Click += (s, e) => _PrintDocument(0.5f);
            //mnuFilePrint25.Click += (s, e) => _PrintDocument(0.25f);
            //mnuFilePrint10.Click += (s, e) => _PrintDocument(0.1f);

            //mnuFileImgPrint100.Click += (s, e) => _PrintImage(1.0f);
            //mnuFileImgPrint50.Click += (s, e) => _PrintImage(0.5f);
            //mnuFileImgPrint10.Click += (s, e) => _PrintImage(0.1f);
        }

        #endregion

        #region Controls

        private void txt_CSMT_TextChanged(object sender, EventArgs e)
        {
            NSMT = _NSMT * CSMT;
        }

        private void txt_QCSMT_TextChanged(object sender, EventArgs e)
        {
            NQSMT = _NQSMT * CQSMT;
        }

        private void txt_CXRay_TextChanged(object sender, EventArgs e)
        {
            NXRAY = _NXRAY * CXRAY;
        }

        private void txt_CTHT_TextChanged(object sender, EventArgs e)
        {
            NTHT = _NTHT * CTHT;
        }

        private void txt_CQTHT_TextChanged(object sender, EventArgs e)
        {
            NQTHT = _NQTHT * CQTHT;
        }

        private void txt_CFTA_TextChanged(object sender, EventArgs e)
        {
            NFTA = _NFTA * CFTA;
        }

        private void txt_CFQC_TextChanged(object sender, EventArgs e)
        {
            NFQC = _NFQC * CFQC;
        }

        private void txt_CIPA_TextChanged(object sender, EventArgs e)
        {
            NIPA = _NIPA * CIPA;
        }

        private void txt_CGPA_TextChanged(object sender, EventArgs e)
        {
            NGPA = _NGPA * CGPA;
        }

        private void btn_Refresh1_Click(object sender, EventArgs e)
        {
            bwStart(bw_List);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            bwStart(bw_List);
        }

        private void chart1_TaskMouseDoubleClick(object sender, TaskMouseEventArgs e)
        {
            int _batchid = 0;
            string _week = "";
            double _qty = 0;
            string _name = "";
            int _isplan = 0;
            int _ispre = 0;
            int _ismisc = 0;
            double _qtyplanned = 0;

            try
            {
                _name = _mManager.ResourcesOf(e.Task).Select(x => (x as MyResource).Name).FirstOrDefault();
                _batchid = _mManager.ResourcesOf(e.Task).Select(x => (x as MyResource).BatchId).FirstOrDefault();
                _week = _mManager.ResourcesOf(e.Task).Select(x => (x as MyResource).Week).FirstOrDefault();
                _qty = _mManager.ResourcesOf(e.Task).Select(x => (x as MyResource).Qty).FirstOrDefault();
                _qtyplanned = _mManager.ResourcesOf(e.Task).Select(x => (x as MyResource).QtyPlanned).FirstOrDefault();
                _isplan = _mManager.ResourcesOf(e.Task).Select(x => (x as MyResource).IsPlan).FirstOrDefault();
                _ispre = _mManager.ResourcesOf(e.Task).Select(x => (x as MyResource).IsPre).FirstOrDefault();
                _ismisc = _mManager.ResourcesOf(e.Task).Select(x => (x as MyResource).IsMisc).FirstOrDefault();
            }
            catch { }

            if (_batchid != 0
                && _isplan == 0
                && _ispre == -1
                && _ismisc == 0)
            {
                frm_AddBatchPlanning frm = new frm_AddBatchPlanning();
                frm.BatchId = _batchid;
                frm.Week = _week;
                frm.Qty = _qty - _qtyplanned;
                frm.PlanDateD = frm.cmb_Week1.FirstDateOfWeek;

                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    PlanBll.AddBatchPlanning(frm.BatchId, frm.Qty, frm.PlanDate, frm.Comments);
                    RefreshGrid();

                    //var _resourse1 = new MyResource()
                    //{
                    //    Name = _name,
                    //    BatchId = _batchid,
                    //    IsPlan = _isplan,
                    //    Week = _week,
                    //    Qty = _qty - frm.Qty,
                    //    IsPre = _ispre,
                    //    PlanId = 0,
                    //    QtyPlanned = _qtyplanned + frm.Qty                      
                    //};

                    //_mManager.Assign(e.Task, _resourse1);
                }
            }
        }

        private void mni_FilterFor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Braincase.GanttChart.Task tsk = _mManager.Contains(new Braincase.GanttChart.Task { Name = mni_FilterFor.Text }));
                //Braincase.GanttChart.Task tsk = _mManager.Find(x => x.Name.Contains(mni_FilterFor.Text)));
                foreach (Braincase.GanttChart.Task tsk in _mManager.Tasks)
                {
                    int k = tsk.Name.ToUpper().IndexOf(mni_FilterFor.Text.ToUpper());
                    if (k != -1)
                    {
                        chart1.ScrollTo(tsk);
                        break;
                    }
                }
                //var task = mni_FilterFor.Text as Braincase.GanttChart.Task;
                //chart1.ScrollTo(task);
            }
            catch { }
        }

        private void mni_RemoveFilter_Click(object sender, EventArgs e)
        {
            mni_FilterFor.Text = "";
            chart1.ScrollTo(System.DateTime.Now);
        }

        private void mni_FilterExcludingSel_Click(object sender, EventArgs e)
        {

        }

        private void chart1_TaskMouseClick(object sender, TaskMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                PubTask = e.Task;
                // MessageBox.Show(PubTask.Name);
                Point LocationPoint = Cursor.Position;
                int xpos = LocationPoint.X;
                int ypos = LocationPoint.Y;

                mnu_Lines.Show(xpos, ypos);
            }
            else
                PubTask = null;
        }

        private void mni_DeleteItem_Click(object sender, EventArgs e)
        {
            DeleteItem(PubTask);
        }

        private void chart1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // MessageBox.Show(PubTask.Name);
                Point LocationPoint = Cursor.Position;
                int xpos = LocationPoint.X;
                int ypos = LocationPoint.Y;

                mnu_Lines.Show(xpos, ypos);
            }

        }

        private void btn_AddPL_Click(object sender, EventArgs e)
        {
            AddItem(PubTask);
        }

        private void btn_EditPL_Click(object sender, EventArgs e)
        {
            EditItem(PubTask);
        }

        #endregion


    }
    #region overlay painter
    /// <summary>
    /// An example of how to encapsulate a helper painter for painter additional features on Chart
    /// </summary>
    public class OverlayPainter
    {
        /// <summary>
        /// Hook such a method to the chart paint event listeners
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ChartOverlayPainter(object sender, ChartPaintEventArgs e)
        {
            // Don't want to print instructions to file
            if (this.PrintMode) return;

            var g = e.Graphics;
            var chart = e.Chart;

            // Demo: Static billboards begin -----------------------------------
            // Demonstrate how to draw static billboards
            // "push matrix" -- save our transformation matrix
            e.Chart.BeginBillboardMode(e.Graphics);

            // draw mouse command instructions
            int margin = 300;
            int left = 20;
            var color = chart.HeaderFormat.Color;
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("THIS IS DRAWN BY A CUSTOM OVERLAY PAINTER TO SHOW DEFAULT MOUSE COMMANDS.");
            builder.AppendLine("*******************************************************************************************************");
            builder.AppendLine("Left Click - Select task and display properties in PropertyGrid");
            builder.AppendLine("Left Mouse Drag - Change task starting point");
            builder.AppendLine("Right Mouse Drag - Change task duration");
            builder.AppendLine("Middle Mouse Drag - Change task complete percentage");
            builder.AppendLine("Left Doubleclick - Toggle collaspe on task group");
            builder.AppendLine("Right Doubleclick - Split task into task parts");
            builder.AppendLine("Left Mouse Dragdrop onto another task - Group drag task under drop task");
            builder.AppendLine("Right Mouse Dragdrop onto another task part - Join task parts");
            builder.AppendLine("SHIFT + Left Mouse Dragdrop onto another task - Make drop task precedent of drag task");
            builder.AppendLine("ALT + Left Dragdrop onto another task - Ungroup drag task from drop task / Remove drop task from drag task precedent list");
            builder.AppendLine("SHIFT + Left Mouse Dragdrop - Order tasks");
            builder.AppendLine("SHIFT + Middle Click - Create new task");
            builder.AppendLine("ALT + Middle Click - Delete task");
            builder.AppendLine("Left Doubleclick - Toggle collaspe on task group");
            var size = g.MeasureString(builder.ToString(), e.Chart.Font);
            var background = new Rectangle(left, chart.Height - margin, (int)size.Width, (int)size.Height);
            background.Inflate(10, 10);
            g.FillRectangle(new System.Drawing.Drawing2D.LinearGradientBrush(background, Color.LightYellow, Color.Transparent, System.Drawing.Drawing2D.LinearGradientMode.Vertical), background);
            g.DrawRectangle(Pens.Brown, background);
            g.DrawString(builder.ToString(), chart.Font, color, new PointF(left, chart.Height - margin));


            // "pop matrix" -- restore the previous matrix
            e.Chart.EndBillboardMode(e.Graphics);
            // Demo: Static billboards end -----------------------------------
        }

        public bool PrintMode { get; set; }
    }
    #endregion overlay painter

    #region custom task and resource
    /// <summary>
    /// A custom resource of your own type (optional)
    /// </summary>
    [Serializable]
    public class MyResource
    {
        public string Name { get; set; }
        public int BatchId { get; set; }
        public int IsPlan { get; set; }
        public int IsPre { get; set; }
        public string Week { get; set; }
        public double Qty { get; set; }
        public int PlanId { get; set; }
        public double QtyPlanned { get; set; }
        public double QtyIn { get; set; }
        public int IsMisc { get; set; }
        public int IsOld { get; set; }
        public string Comments { get; set; }
    }
    /// <summary>
    /// A custom task of your own type deriving from the Task interface (optional)
    /// </summary>
    [Serializable]
    public class MyTask : Braincase.GanttChart.Task
    {
        public MyTask(ProjectManager manager)
            : base()
        {
            Manager = manager;
        }


        private ProjectManager Manager { get; set; }


        public new TimeSpan Start { get { return base.Start; } set { Manager.SetStart(this, value); } }
        public new TimeSpan End { get { return base.End; } set { Manager.SetEnd(this, value); } }
        public new TimeSpan Duration { get { return base.Duration; } set { Manager.SetDuration(this, value); } }
        public new float Complete { get { return base.Complete; } set { Manager.SetComplete(this, value); } }

    }
    #endregion custom task and resource
}

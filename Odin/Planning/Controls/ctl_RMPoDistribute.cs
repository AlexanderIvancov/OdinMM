using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Odin.Global_Classes;
using AdvancedDataGridView;
using Odin.Purchase;
using ComponentFactory.Krypton.Toolkit;

namespace Odin.Planning.Controls
{
    public delegate void BatchIdPOSendingEventHandler(int artid, bool general, bool batchrm, bool artrm, bool totalart, bool poreservation);

    public partial class ctl_RMPoDistribute : UserControl
    {
        public ctl_RMPoDistribute()
        {
            InitializeComponent();
        }

        #region Variables

        public event BatchIdPOSendingEventHandler SendBatchId;

        ProgressForm wait;
        //frm_Batches frmBatches;
        private frm_Wait m_fmProgress = null;
        private const string processingCancelled = "Processing cancelled.";

        class_Global glob_Class = new class_Global();
        Plan_BLL BLL = new Plan_BLL();
        DAL_Functions DLL = new DAL_Functions();
        PO_BLL POBLL = new PO_BLL();
        

        int _articleid = 0;
        
        

        public int ArtId
        {
            get { return cmb_Articles1.ArticleId; }
            set
            {
                _articleid = value;
                FillGrid(_articleid);
                //bwStart(bw_List);
                //AvailableQty = DLL.AvailQty(cmb_Articles1.ArticleId);
               
            }
        }

        #endregion

        #region Methods

        public void bw_List(object sender, DoWorkEventArgs e)
        {

            tv_POS.ThreadSafeCall(delegate
            {
                FillGrid(ArtId);
            });
        }

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.tv_POS.Rows)
            {
                if (Convert.ToDateTime(row.Cells["cn_reqdate"].Value) == Convert.ToDateTime("01.01.1900"))
                    row.Cells["cn_reqdate"].Style.ForeColor = Color.Transparent;
            }
        }

        public void ClearNodes()
        {
            tv_POS.Nodes.Clear();
        }

        public void FillGrid(int ArtId)
        {

            tv_POS.Nodes.Clear();

            Font boldFont = new Font(tv_POS.DefaultCellStyle.Font, FontStyle.Bold);
            //Orders
            var data = BLL.CurrentPOs(ArtId);

            foreach (System.Data.DataRow dr in data.AsEnumerable().OrderBy(d => d.Field<string>("name")))
            {
               AddNode(dr, boldFont, tv_POS.Nodes, true); 
            }

            //tv_POS.Focus();
            //Details
            foreach (TreeGridNode node1 in tv_POS.Nodes)
            {
                var data1 = BLL.POReservations(Convert.ToInt32(node1.Cells["cn_id"].Value));

                foreach (System.Data.DataRow dr in data1.AsEnumerable().OrderBy(d => d.Field<string>("name")))
                {
                   AddNode(dr, boldFont, node1.Nodes, true);
                       
                }
            }

            foreach (TreeGridNode node1 in tv_POS.Nodes)
            {
                ExpandNodes(node1);
            }
            
            SetCellsColor();
        }

        public void ExpandNodes(TreeGridNode node)
        {
            foreach (TreeGridNode node1 in node.Nodes)
            {
                node.Expand();
                ExpandNodes(node1);
            }
        }

        private void AddNode(DataRow dr, Font boldFont, TreeGridNodeCollection nodes, bool isAddingImage)
        {
            TreeGridNode node;

            node = nodes.Add(null, dr["name"], dr["id"], dr["article"], Convert.ToDouble(dr["qty"]), dr["unit"], 
                            Convert.ToDouble(dr["reserved"]), Convert.ToDouble(dr["qtydelivered"]),
                            Convert.ToDouble(dr["freeqty"]), Convert.ToDateTime(dr["reqdate"]), dr["confdate"], dr["supplier"]);

            if (isAddingImage)
            {
                node.ImageIndex = 1;
            }
                        
        }

        public void bwStart(DoWorkEventHandler doWork)
        {

            // Create a background thread
            var bw = new BackgroundWorker();
            bw.DoWork += doWork;
            bw.RunWorkerCompleted += bw_RunWorkerCompleted;

            // Create a progress form on the UI thread
            m_fmProgress = new frm_Wait();
            m_fmProgress.Start();
            // Kick off the Async thread
            bw.RunWorkerAsync();

            // Lock up the UI with this modal progress form.
            m_fmProgress.ShowDialog();
            m_fmProgress = null;
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Hide the Progress Form
            if (m_fmProgress != null)
            {
                m_fmProgress.Stop();
                m_fmProgress.Close();
                m_fmProgress = null;
            }

            // Check to see if an error occured in the 
            // background process.
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
                return;
            }

            // Check to see if the background process was cancelled.
            if (e.Cancelled)
            {
                MessageBox.Show(processingCancelled);
                return;
            }

        }
        
        #endregion

        #region Controls

        private void cmb_Articles1_ArticleChanged(object sender)
        {
            ArtId = cmb_Articles1.ArticleId;
            if (SendBatchId != null)
                SendBatchId(ArtId, true, false, false, true, false);
        }

        private void btn_Release_Click(object sender, EventArgs e)
        {
            TreeGridNode node;
            node = tv_POS.CurrentNode;
            if (node != null)
            {
                if (node.Level == 1)
                    BLL.ReleaseRMFromPO(Convert.ToInt32(node.Cells["cn_id"].Value), 0);
                else
                    BLL.ReleaseRMFromPO(0, Convert.ToInt32(node.Cells["cn_id"].Value));
            }

            FillGrid(ArtId);

            if (SendBatchId != null)
                SendBatchId(ArtId, true, true, true, true, false);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            double _QtyFreeInPO = 0;
            int _poid = 0;
            string _porder = "";
            TreeGridNode node;
            node = tv_POS.CurrentNode;

            if (node != null)
            {
                if (node.Level == 1)
                {
                    _QtyFreeInPO = Convert.ToDouble(node.Cells["cn_free"].Value);
                    _poid = Convert.ToInt32(node.Cells["cn_id"].Value);
                    _porder = node.Cells["cn_POrder"].Value.ToString();
                }
                else
                {
                    _QtyFreeInPO = Convert.ToDouble(node.Parent.Cells["cn_free"].Value);
                    _poid = Convert.ToInt32(node.Parent.Cells["cn_id"].Value);
                    _porder = node.Parent.Cells["cn_POrder"].Value.ToString();
                }
            }

            if (_QtyFreeInPO > 0)
            {
                frm_AddPONeeds frm = new frm_AddPONeeds();

                frm.ctl_RMNeeds1.cmb_Articles1.ArticleId = ArtId;
                frm.ctl_RMNeeds1.EnableSave(false);

                frm.HeaderText = "Add PO resevation for: " + _porder; 
                frm.ctl_RMNeeds1.Mode = 1;
                frm.ctl_RMNeeds1.QtyFreeInPO = _QtyFreeInPO;

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    foreach (DataRow row in frm.ctl_RMNeeds1.data.Rows)
                    {
                        if (Convert.ToDouble(row["topurchase"]) > 0
                            && _QtyFreeInPO > 0)
                        {
                            if (Convert.ToDouble(row["topurchase"]) > _QtyFreeInPO)
                            {
                                POBLL.MapPONeeds(_poid, Convert.ToInt32(row["id"]), Convert.ToInt32(row["typeneed"]), _QtyFreeInPO, "");
                                _QtyFreeInPO = 0;

                                break;
                            }
                            else
                            {
                                POBLL.MapPONeeds(_poid, Convert.ToInt32(row["id"]), Convert.ToInt32(row["typeneed"]), Convert.ToDouble(row["topurchase"]), "");
                                _QtyFreeInPO = _QtyFreeInPO - Convert.ToDouble(row["topurchase"]);

                            }

                        }
                    }
                    FillGrid(ArtId);

                    if (SendBatchId != null)
                        SendBatchId(ArtId, true, true, true, true, false);
                }
            }
        }

        #endregion


    }
}

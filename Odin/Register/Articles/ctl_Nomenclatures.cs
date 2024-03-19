using AdvancedDataGridView;
using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Odin.Register.Articles
{
    public delegate void ArtIdNormSendingEventHandler(object sender);
    public partial class ctl_Nomenclatures : UserControl
    {
        public ctl_Nomenclatures()
        {
            InitializeComponent();
            frm_ArticlesManagement.ReceiveNormArtId += new ReceiveNormArtId(RetArtId);
        }

        #region Variables

        public event ArtIdNormSendingEventHandler SendArtId;

        public int igvArtId
        {
            get;
            set;
        }
        public int OldigvArtId
        {
            get;
            set;
        }

        public int RetArtId()
        {
            return igvArtId;
        }

        class_Global glob_Class = new class_Global();
        private string headerText = "Add nomenclature line for {0}";
        Reg_BLL BLL = new Reg_BLL();
        Font boldFont;
        Helper MyHelper = new Helper();
        private string example = "Example";
        private int currentColumnIndex = 0;
        List<TreeGridNode> foundNodes = new List<TreeGridNode>();

        int _ArtId = 0;
        public int ArtId
        {
            get { return cmb_Articles1.ArticleId; }
            set {
                _ArtId = value;
                FillGrid(_ArtId);
            }
        }

        int _lock = 0;
        public int Lock
        {
            get {
                return _lock;
            }
            set { _lock = value; }
            //get { if (chk_Lock.CheckState == CheckState.Checked)
            //        return -1;
            //    else
            //        return 0;
            //}
            //set { if (value == -1)
            //        chk_Lock.CheckState = CheckState.Checked;
            //    else
            //        chk_Lock.CheckState = CheckState.Unchecked;
            //}
        }

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        #endregion

        #region Methods

        public void FillGrid(int artid)
        {
            tv_BOM.Nodes.Clear();
            AddNodeByValue(ArtId);

        }

        private void AddNodeByValue(int Id)
        {

            var data = (DataTable)Helper.getSP("sp_BOMDetails", Id);

            foreach (DataRow dr in data.AsEnumerable().OrderBy(d => d.Field<int>("LineNumber")))
            {
                var isFound = HelperTreeGrid.isFoundNode(tv_BOM.Nodes, dr["ID"].ToString(), "cn_id");
                if (!isFound)
                {
                    AddNode(dr, boldFont, tv_BOM.Nodes, true, false);
                }
            }
        }

        private void AddNode(DataRow dr, Font boldFont, TreeGridNodeCollection nodes,
                   bool isAddingImage, bool isExpand)
        {
            TreeGridNode node;
            node = nodes.Add(null, dr["Article"], dr["IdCst"], dr["LineNumber"], dr["SecName"], Convert.ToDouble(dr["Quantity"]), dr["Unit"],
                                             dr["SpoilNorm"], dr["SpoilConst"], dr["Comments"], dr["DateCreation"], dr["CreatedBy"], 
                                             dr["ID"], dr["Using"], dr["UniqueRow"], dr["StageID"]);


            if (isAddingImage)
            {
                node.ImageIndex = 1;
            }

            SetRowColor(dr, node);

            // Adds fake node
            if (dr["CpseMark"].ToString() == "Y")
            {
                node.DefaultCellStyle.Font = boldFont;
                node.DefaultCellStyle.ForeColor = Color.Red;

                if (isExpand)
                {
                    node.Expand();
                }
                else
                {
                    node.Nodes.Add(null, example);
                }
            }

        }

        private void SetRowColor(DataRow dr, TreeGridNode node)
        {
            if (Convert.ToInt32(dr["Using"]) == 1)
            {
                node.DefaultCellStyle.BackColor = Color.White;
            }

            if (Convert.ToInt32(dr["Using"]) == 0)
            {
                node.DefaultCellStyle.BackColor = Color.Gainsboro;
            }
        }

        private void EnableDisableButtons()
        {
            //btn_EditNom.Enabled = btn_AddNomChild.Enabled = btn_InsertNomLine.Enabled =
            //                                                btn_CopyNom.Enabled =
            //                                                btn_DeleteNomLine.Enabled =
            //                                                btn_MoveDown.Enabled =
            //                                                btn_MoveUp.Enabled = gv_Nomenclature.Rows.Count > 0;
            //bn_Nomenclatures.Enabled = gv_Articles.Rows.Count > 0 || cmb_Articles1.ArticleId != 0;

        }

        private void SetNodeByFormValues(frm_AddBOM frm, TreeGridNode newNode, int insertedId, int isUsing)
        {

            newNode.SetValues(null, frm.Article, frm.IdCST, frm.Number, frm.SecName, frm.Qty, frm.Unit, frm.SpoilPerc,
                              frm.SpoilConst, frm.Comments, DateTime.Now, Environment.UserName, insertedId, isUsing, Guid.NewGuid(), frm.StageId);
        }

        public void SetFont()
        {
            boldFont = new Font(tv_BOM.DefaultCellStyle.Font, FontStyle.Bold);
        }
        #endregion
        #region Controls

        private void cmb_Articles1_ArticleChanged(object sender)
        {
            ArtId = cmb_Articles1.ArticleId;
        }

        private void btn_AddNorm_Click(object sender, EventArgs e)
        {
            var frm = new frm_AddBOM();
            var numId = 0;
            
            try
            {
                frm.HeaderText = string.Format(headerText, Convert.ToString(cmb_Articles1.Article));
            }
            catch
            {
                frm.HeaderText = string.Empty;
            }

            numId = BLL.MaxNumber(ArtId);


            numId++;

            frm.Number = numId;
            frm.IdCSE = ArtId;
            frm.Tag = "Add";


            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                var insertedId = Convert.ToInt32(Helper.getSP("sp_AddBOMLine", frm.IdCSE, frm.IdCST, frm.Number, frm.Qty, frm.Using,
                                                    frm.Comments, frm.SpoilConst, frm.SpoilPerc, frm.StageId, frm.Positions));
                var id = BLL.IdCstById(insertedId);
                AddNodeByValue(ArtId);
                EnableDisableButtons();
            }
        }

        private void btn_AddSubProduct_Click(object sender, EventArgs e)
        {
            var frm = new frm_AddBOM();
            var numId = 0;

            frm.IdCSE = Convert.ToInt32(tv_BOM.CurrentRow.Cells["cn_artid"].Value);
            frm.HeaderText = string.Format(headerText, Convert.ToString(tv_BOM.CurrentRow.Cells["cn_article"].Value));
            numId = BLL.MaxNumber(frm.IdCSE);
            numId++;

            frm.Number = numId;
            frm.Tag = "AddChild";
            //var Id = (int)node.Cells["cn_IdCst"].Value;
            DialogResult result = frm.ShowDialog();
            int isUsing = frm.Using;// == 1 ? true : false;

            if (result == DialogResult.OK)
            {
                var insertedId = Convert.ToInt32(Helper.getSP("sp_AddBOMLine", frm.IdCSE, frm.IdCST, frm.Number, frm.Qty, frm.Using,
                                                frm.Comments, frm.SpoilConst, frm.SpoilPerc, frm.StageId, frm.Positions));
                var currentNode = tv_BOM.CurrentNode;


                if (!currentNode.HasChildren)
                {
                    //currentNode.Nodes.Add(null, example);
                    currentNode.DefaultCellStyle.Font = boldFont;
                    currentNode.DefaultCellStyle.ForeColor = Color.Red;
                }

                if (!currentNode.IsNodeExpanded)
                {
                    currentNode.Expand();
                }
                else
                {
                    HelperTreeGrid.RemoveExampleNode(currentNode);

                    var newNode = new TreeGridNode();
                    currentNode.Nodes.Add(newNode);

                    SetNodeByFormValues(frm, newNode, insertedId, isUsing);
                    
                    //if found child nodes
                    if (BLL.BOMChildCount(frm.IdCST) > 0)
                    {
                        newNode.DefaultCellStyle.Font = boldFont;
                        newNode.DefaultCellStyle.ForeColor = Color.Red;

                        newNode.Nodes.Add(null, example);
                    }
                }

                HelperTreeGrid.UpdateNodeValues(currentNode, Convert.ToString(currentNode.Cells["cn_article"].Value),
                    ref foundNodes, tv_BOM);
            }
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            var frm = new frm_AddBOM();
            var numId = 0;
            TreeGridNode ancestorNode;
            string ancestorArticle;

            var parentId = BLL.FindParent(Convert.ToInt32(tv_BOM.CurrentRow.Cells["cn_id"].Value));

            frm.IdCSE = Convert.ToInt32(parentId.Rows[0]["IdCSE"]);
            //numId = MaxNumber(Convert.ToInt32(parentId.Rows[0]["NO_IdCSE"]));
            numId = Convert.ToInt32(tv_BOM.CurrentRow.Cells["cn_num"].Value);
            numId++;

            frm.Number = numId;
            frm.Tag = "AddChild";
            frm.HeaderText = string.Format(headerText, Convert.ToString(parentId.Rows[0]["Article"]));

            DialogResult result = frm.ShowDialog();
            int isUsing = frm.Using;// == 1 ? true : false;

            if (result == DialogResult.OK)
            {
                BLL.IncreaseBOMNumbers(Convert.ToInt32(parentId.Rows[0]["IdCSE"]),
                                            Convert.ToInt32(tv_BOM.CurrentRow.Cells["cn_num"].Value));

                var insertedId = Convert.ToInt32(Helper.getSP("sp_AddBOMLine", frm.IdCSE, frm.IdCST, frm.Number, frm.Qty, frm.Using,
                                                 frm.Comments, frm.SpoilConst, frm.SpoilPerc, frm.StageId, frm.Positions));

                var currentNode = tv_BOM.CurrentNode;
                int deleteNodeLevel = currentNode.Level;
                var parentNode = tv_BOM.CurrentNode.Parent;


                var newNode = new TreeGridNode();
                newNode = HelperTreeGrid.InsertNode(deleteNodeLevel == 1 ? tv_BOM.Nodes : parentNode.Nodes, tv_BOM);

                SetNodeByFormValues(frm, newNode, insertedId, isUsing);

                HelperTreeGrid.RefreshNodesSequence(deleteNodeLevel == 1 ? tv_BOM.Nodes : parentNode.Nodes);

                //if found child nodes
                if (BLL.BOMChildCount(frm.IdCST) > 0)
                {
                    newNode.DefaultCellStyle.Font = boldFont;
                    newNode.DefaultCellStyle.ForeColor = Color.Red;
                    newNode.Nodes.Add(null, example);
                }

                if (deleteNodeLevel > 1)
                {
                    ancestorNode = newNode.Parent;
                    ancestorArticle = Convert.ToString(ancestorNode.Cells["cn_article"].Value);

                    HelperTreeGrid.UpdateNodeValues(ancestorNode, ancestorArticle, ref foundNodes,
                        tv_BOM);
                }
                
            }
        }

        private void btn_EditNorm_Click(object sender, EventArgs e)
        {
            var frm = new frm_AddBOM();
            var parentId = BLL.FindParent(Convert.ToInt32(tv_BOM.CurrentRow.Cells["cn_id"].Value));
            var spoilConst = tv_BOM.CurrentRow.Cells["cn_spoilconst"].Value as double?;

            frm.IdCSE = Convert.ToInt32(parentId.Rows[0]["IdCSE"]);
            frm.Number = Convert.ToInt32(tv_BOM.CurrentRow.Cells["cn_num"].Value);
            frm.Text = "Edit BOM line";

            frm.IdCST = Convert.ToInt32(tv_BOM.CurrentRow.Cells["cn_artid"].Value);
            frm.Qty = Convert.ToDecimal(tv_BOM.CurrentRow.Cells["cn_qty"].Value);
            frm.Comments = tv_BOM.CurrentRow.Cells["cn_comments"].Value.ToString();
            frm.SpoilConst = spoilConst ?? 0;
            frm.SpoilPerc = Convert.ToDouble(tv_BOM.CurrentRow.Cells["cn_spoilnorm"].Value ?? 0);
            frm.Using = Convert.ToInt32(tv_BOM.CurrentRow.Cells["cn_using"].Value);
            DialogResult result = frm.ShowDialog();
            int isUsing = frm.Using;// == -1 ? true : false;

            if (result == DialogResult.OK)
            {
                var _ID = Convert.ToInt32(tv_BOM.CurrentRow.Cells["cn_id"].Value);

                var currentNode = tv_BOM.CurrentNode;
                var deleteNodeLevel = currentNode.Level;
                var parentNode = tv_BOM.CurrentNode.Parent;

                Helper.getSP("sp_EditBOMLine", Convert.ToInt32(tv_BOM.CurrentRow.Cells["cn_id"].Value),
                    frm.IdCST, frm.Number, frm.Qty, frm.Using,
                    frm.Comments, frm.SpoilConst, frm.SpoilPerc, frm.StageId, frm.Positions);



                var newNode = new TreeGridNode();
                newNode = HelperTreeGrid.InsertNode(deleteNodeLevel == 1 ? tv_BOM.Nodes : parentNode.Nodes,
                    tv_BOM);

                SetNodeByFormValues(frm, newNode, _ID, isUsing);


                //if found child nodes
                if (BLL.BOMChildCount(frm.IdCST) > 0)
                {
                    newNode.DefaultCellStyle.Font = boldFont;
                    newNode.DefaultCellStyle.ForeColor = Color.Red;
                    newNode.Nodes.Add(null, example);
                }

                parentNode.Nodes.Remove(currentNode);
                //HelperTreeGrid.RefreshNodesSequence(deleteNodeLevel == 1 ? gv_Nomenclature.Nodes : parentNode.Nodes);

                if (deleteNodeLevel > 1)
                {
                    HelperTreeGrid.UpdateNodeValues(newNode.Parent, Convert.ToString(newNode.Parent.Cells["cn_article"].Value),
                        ref foundNodes, tv_BOM);
                }

                //ShowNomenclature(igvArtId);
            }
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            var frm = new frm_cmbArt();
            DialogResult result = frm.ShowDialog();
            frm.HeaderText = "Copy nomenclature from " + cmb_Articles1.Article;

            if (result == DialogResult.OK)
            {
                Helper.getSP("sp_CopyBOM", ArtId, frm.ArticleId);
                cmb_Articles1.ArticleId = frm.ArticleId;
            }
        }

        private void btn_DeleteNorm_Click(object sender, EventArgs e)
        {
            if (glob_Class.DeleteConfirm())
            {
                foundNodes = new List<TreeGridNode>();
                var node = tv_BOM.CurrentNode;
                var deleteNodeLevel = node.Level;

                var ancestorNode = tv_BOM.CurrentNode.Parent;
                var ancestorArticle = deleteNodeLevel == 1 ? string.Empty : Convert.ToString(ancestorNode.Cells["cn_article"].Value);

                int _id = 0;
                try { _id = Convert.ToInt32(tv_BOM.CurrentRow.Cells["cn_id"].Value); }
                catch { _id = 0; }
                if (_id != 0)
                {
                    var parentId = BLL.FindParent(_id);
                    //BLL.DecreaseBOMNumbers(Convert.ToInt32(parentId.Rows[0]["IdCSE"]), Convert.ToInt32(tv_BOM.CurrentRow.Cells["cn_num"].Value));
                    Helper.getSP("sp_DeleteBOMLineById", _id);
                    
                }



                HelperTreeGrid.RemoveNode(deleteNodeLevel == 1 ? tv_BOM.Nodes : ancestorNode.Nodes, node);

                if (deleteNodeLevel > 1)
                {
                    HelperTreeGrid.UpdateNodeValues(ancestorNode, ancestorArticle, ref foundNodes,
                        tv_BOM);
                }

                EnableDisableButtons();
            }
        }

        private void tv_BOM_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            currentColumnIndex = e.ColumnIndex;
        }

        private void tv_BOM_NodeExpanded(object sender, ExpandedEventArgs e)
        {
            var node = e.Node;

            if (node.Cells[1].Value != null)
            {
                HelperTreeGrid.RemoveExampleNode(node);

                var Id = (int)node.Cells["cn_artid"].Value;
                var data = (DataTable)Helper.getSP("sp_BOMDetails", Id);


                foreach (System.Data.DataRow dr in data.AsEnumerable().OrderBy(d => d.Field<int>("LineNumber")))
                {
                    // Finds the child IdBatch node
                    var isFound = HelperTreeGrid.isFoundNode(node.Nodes, dr["ID"].ToString(), "cn_id");


                    if (!isFound)
                    {
                        AddNode(dr, boldFont, e.Node.Nodes, false, false);
                    }
                }
            }
        }

        private void tv_BOM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Showing image for main form



            //try
            //{
            //    ImageId = Convert.ToInt32(gv_Nomenclature.CurrentRow.Cells["cn_IdCst"].Value);

            //}
            //catch { }
            //ShowImage(DAL.ImagePath(ImageId));
        }


        private void ctl_Nomenclatures_Load(object sender, EventArgs e)
        {
            
        }

        private void tv_BOM_SelectionChanged(object sender, EventArgs e)
        {
            if (CheckOldRow() == false)
            {
                SendArticle(igvArtId);
            }
        }

        public void SendArticle(int artid)
        {
            //Event
            SendArtId?.Invoke(this);
        }

        private bool CheckOldRow()
        {

            try
            {
                igvArtId = Convert.ToInt32(tv_BOM.CurrentRow.Cells["cn_artid"].Value);
            }
            catch
            {
                igvArtId = 0;
            }
                      


            if (OldigvArtId == igvArtId)
            {
                return true;
            }
            else
            {
                OldigvArtId = igvArtId;
                return false;
            }
        }


        #endregion

        private void chk_Lock_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void btn_Lock_Click(object sender, EventArgs e)
        {
            if (Lock == -1)
            {
                this.btn_Lock.Values.Image = global::Odin.Global_Resourses.lock_open;
                Lock = 0;
            }
            else

            {
                this.btn_Lock.Values.Image = global::Odin.Global_Resourses._lock;
                Lock = -1;
            }
        }

        private void mnu_Lines_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                Point mpoint = tv_BOM.PointToClient(DataGridView.MousePosition);
                DataGridView.HitTestInfo info = tv_BOM.HitTest(mpoint.X, mpoint.Y);

                RowIndex = info.RowIndex;
                ColumnIndex = info.ColumnIndex;
                //MessageBox.Show(RowIndex.ToString() + "MO," + ColumnIndex.ToString());

                tv_BOM.ClearSelection();
                tv_BOM.Rows[RowIndex].Cells[ColumnIndex].Selected = true;
                tv_BOM.CurrentCell = tv_BOM.Rows[RowIndex].Cells[ColumnIndex];

                CellValue = tv_BOM.Rows[RowIndex].Cells[ColumnIndex].Value.ToString();
                ColumnName = tv_BOM.Columns[ColumnIndex].DataPropertyName.ToString();
                //gv_List.SelectionChanged += new EventHandler(gv_List_SelectionChanged(this));

            }
            catch
            {
                RowIndex = 0;
                ColumnIndex = 0;
                return;
            }
        }

        private void mni_Search_Click(object sender, EventArgs e)
        {
            try
            {
                frm_Find frm = new frm_Find();
                frm.grid = tv_BOM;
                frm.ColumnNumber = tv_BOM.CurrentCell.ColumnIndex;
                frm.ColumnText = tv_BOM.Columns[frm.ColumnNumber].HeaderText;
                frm.ShowDialog();
            }
            catch { }
        }
    }
}

using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.CMB_Components.Types
{
    public delegate void TypesEventHandler(object sender);
    public delegate void TypesPathEventHandler(object sender);
    
    public partial class cmb_Types : UserControl
    {
        public event TypesEventHandler SelectedValueChanged;
        public event TypesPathEventHandler PathChanged;
        

        #region Variables

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;

        class_Global glob_Class = new class_Global();

        TypesEventArgs args = new TypesEventArgs();
        TypesPathEventArgs argsS = new TypesPathEventArgs();

        int _TypeId = 0;
        string _Path = "";
        string _Type = "";

        public string Path
        {
            get { return _Path; }
            set{ _Path = value; }
        }

        public string TypeLat
        { get; set; }

        public List<int> TypeIDs
        { get; set; }

        #endregion

        public cmb_Types()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
            TypeIDs = new List<int>();
        }

        public TreeNode SelectedNode
        {
            get;
            set;
        }

        public int TypeId
        {
            get { return _TypeId; }
            set {
                _TypeId = value;
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();

                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter("SELECT top 1 name, isnull(namelat, '') as namelat, dbo.fn_FullTypesTree(id) as FullPath FROM BAS_Type WHERE id = " + _TypeId.ToString() + " option (hash join)", conn);
                adapter.Fill(ds);

                conn.Close();

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        txt_Type.Text = dr["name"].ToString();
                        _Type = dr["name"].ToString();
                        Path = dr["FullPath"].ToString();
                        TypeLat = dr["namelat"].ToString();
                    }
                    SelectedValueChanged?.Invoke(this);
                }
                else
                {
                    Type= string.Empty;
                    Path = string.Empty;
                    TypeLat = string.Empty;
                }


            }
        }

        public string Type
        {
            get { return txt_Type.Text; }
            set
            {
                _Type = value;
                txt_Type.Text = value;
                //SqlConnection conn = new SqlConnection(sConnStr);
                //conn.Open();

                //DataSet ds = new DataSet();

                //SqlDataAdapter adapter =
                //    new SqlDataAdapter("SELECT top 1 id, isnull(namelat, '') as namelat, dbo.fn_FullTypesTree(id) as FullPath FROM BAS_Type WHERE name = '" + _Type.ToString() + "'", conn);
                //adapter.Fill(ds);

                //conn.Close();

                //DataTable dt = ds.Tables[0];

                //if (dt.Rows.Count > 0)
                //{
                //    foreach (DataRow dr in dt.Rows)
                //    {
                //        _TypeId = Convert.ToInt32(dr["id"].ToString());
                //        Path = dr["FullPath"].ToString();
                //        TypeLat = dr["namelat"].ToString();
                //    }

                //}
                //else
                //{
                //    _TypeId = 0;
                //    Path = string.Empty;
                //    TypeLat = string.Empty;
                //}

            } 
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Type.Text = string.Empty;
            TypeId = 0;
        }

        private void btn_TreeView_Click(object sender, EventArgs e)
        {
            Form f;
            f = this.FindForm();

            Point LocationPoint = this.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X;
            int ypos = LocationPoint.Y + this.Height;
            Point _location = new Point(xpos, ypos);

            frm_TypesTree popup = new frm_TypesTree();
            popup.cmb_TypeOne = this;
          

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);
            popup.Load_tree();

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };
        }

        private void btn_AdvView_Click(object sender, EventArgs e)
        {
            Form f;
            f = this.FindForm();

            Point LocationPoint = this.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X;
            int ypos = LocationPoint.Y + this.Height;
            Point _location = new Point(xpos, ypos);

            frm_Types popup = new frm_Types();
            popup.cmb_TypeOne = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);
                       
            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };
            
            popup.FillData(Type);
        }

        private void txt_Type_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Shelf = txt_Shelf.Text;
                if (glob_Class.NES(txt_Type.Text) == "")
                    TypeId = 0;
                SelectedValueChanged?.Invoke(this);
            }
            catch { return; }
        }

        public void ValueChanged(KryptonTreeView tv)
        {
            tv.ThreadSafeCall(delegate
            {
                TypeIDs.Clear();

                foreach (KryptonTreeNode node in tv.Nodes)
                {
                    if (node.Checked == true)
                    {
                        TypeIDs.Add(Convert.ToInt32(node.Tag));
                    }
                }
            });

            SelectedValueChanged?.Invoke(this);
        }

        private void txt_Type_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
        }

        private void cmb_Types_Load(object sender, EventArgs e)
        {
            LoadTypeIDS();  
        }

        public void LoadTypeIDS()
        {
            TypeIDs.Clear();
            //Add all typeid's
            SqlConnection conn = new SqlConnection(sConnStr);
            conn.Open();

            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                new SqlDataAdapter("SELECT id FROM BAS_Type", conn);
            adapter.Fill(ds);

            conn.Close();

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    TypeIDs.Add(Convert.ToInt32(dr["id"]));
                    //_TypeId = Convert.ToInt32(dr["id"].ToString());
                }
            }
        }
        private void txt_Type_MouseEnter(object sender, EventArgs e)
        {
            //KryptonTextBox TB = (KryptonTextBox)sender;
            //int VisibleTime = 1000;

            //ToolTip tt = new ToolTip();
            //tt.AutoPopDelay = 0;
            //tt.InitialDelay = 0;
            //tt.ReshowDelay = 0;
           
            //tt.Show(Path, TB, 0, TB.Location.Y + 25, VisibleTime);
            
        }
    }
    public class TypesEventArgs : EventArgs
    {

    }
    public class TypesPathEventArgs : EventArgs
    {

    }

}

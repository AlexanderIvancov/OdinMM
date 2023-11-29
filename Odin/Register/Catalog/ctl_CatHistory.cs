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

namespace Odin.Register.Catalog
{
    public partial class ctl_CatHistory : UserControl
    {
        public ctl_CatHistory()
        {
            InitializeComponent();
        }

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        Reg_BLL BLL = new Reg_BLL();

        int _ArtId = 0;

        public int ArticleId
        {
            get { return cmb_Articles1.ArticleId; }
            set
            {
                //cmb_Articles1.ArticleId = value;
                _ArtId = value;
                FillHistory(_ArtId);
                //SetCellsColor();
            }
        }

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (row.Cells["cn_typechange"].Value.ToString() == "deleted")
                {
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.LightCoral;
                }
                else if (row.Cells["cn_typechange"].Value.ToString() == "inserted")
                {
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.FromArgb(192, 255, 192);
                }
                else
                {
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.Plum;
                }

            }
        }

        public void FillHistory(int ArtId)
        {
            var data = Reg_BLL.getCatalogHistory(ArtId);

            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

                //SetCellsColor();
            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });
        }

        private void cmb_Articles1_ArticleChanged(object sender)
        {
            ArticleId = cmb_Articles1.ArticleId;
        }
    }
}

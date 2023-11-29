﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ComponentFactory.Krypton.Ribbon;
using Odin.Global_Classes;
using Odin.Tools;
using System.Data.SqlClient;
using Odin.CMB_Components.BLL;
using Odin.CMB_Components.Users;

namespace Odin.Tools
{
    public partial class frm_MenuPermissions : KryptonForm
    {
        public frm_MenuPermissions()
        {
            InitializeComponent();
        }

        #region Variables

        Tools_BLL BLL = new Tools_BLL();

        #endregion

        #region Methods

        public void FillList()
        {
            var data = Tools_BLL.getUsers();

            gv_List.ThreadSafeCall(delegate
            {

                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });

        }

        public void FillMenuItems(int _userid)
        {
            var data = Tools_BLL.getMenuItems(_userid);

            gv_MenuItems.ThreadSafeCall(delegate
            {

                gv_MenuItems.AutoGenerateColumns = false;
                bs_MenuItems.DataSource = data;
                gv_MenuItems.DataSource = bs_MenuItems;

            });


            bn_MenuItems.ThreadSafeCall(delegate
            {
                bn_MenuItems.BindingSource = bs_MenuItems;
            });

        }

        #endregion

        #region Controls



        #endregion

        private void frm_MenuPermissions_Load(object sender, EventArgs e)
        {
           // FillList();
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            int _userid = 0;

            try { _userid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_userid != 0)
                FillMenuItems(_userid);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            gv_MenuItems.EndEdit();

            int _userid = 0;
            try { _userid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_userid != 0)
            {
                DataTable datastages = new DataTable();
                datastages.Columns.Add("id", typeof(int));

                foreach (DataGridViewRow row in gv_MenuItems.Rows)
                {
                    if (Convert.ToInt32(row.Cells["chk_mchecked"].Value) != 0)
                    {
                        DataRow dr = datastages.NewRow();
                        dr["id"] = Convert.ToInt32(row.Cells["cn_mtabid"].Value);
                        datastages.Rows.Add(dr);
                    }

                }

                BLL.SaveMenuUserTabs(_userid, datastages);

                FillMenuItems(_userid);

            }
        }
    }
}

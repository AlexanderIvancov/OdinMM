using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.Planning
{
    public delegate void LaunchRMAdding(object sender);
    public partial class frm_AddLaunchRMLine : KryptonForm
    {
        public frm_AddLaunchRMLine()
        {
            InitializeComponent();
        }

        public void SetCellsColor()
        {
            int _bdtemp = 0;
            int _colorcount = 0;
            try
            {
                if (gv_List.Rows.Count > 0)
                {
                    _bdtemp = Convert.ToInt32(gv_List.Rows[0].Cells["cn_batchdetid"].Value);
                    _colorcount = 1;

                    foreach (DataGridViewRow row in this.gv_List.Rows)
                    {
                        if (_bdtemp != Convert.ToInt32(row.Cells["cn_batchdetid"].Value))
                        {
                            //Next color

                            //Switch
                            _bdtemp = Convert.ToInt32(row.Cells["cn_batchdetid"].Value);
                            _colorcount++;

                        }
                        row.DefaultCellStyle.BackColor = _colorcount % 2 == 0 ? Color.LightGray : Color.Azure;//Color.LightGreen : Color.LightPink;
                    }
                }
            }
            catch
            { }
        }

        public void ShowLaunchDets(int _launchid)
        {
            var data = (DataTable)Helper.getSP("sp_SelectLaunchAddDets", _launchid);

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

            FillBatchUnits();
        }

        public void FillBatchUnits()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Unit", typeof(string)));
            string _tmpUnit = "";
            int _k = 0;
            foreach (DataGridViewRow row in gv_List.Rows)
            {
                _k = 0;
                _tmpUnit = row.Cells["cn_unit"].Value.ToString().Trim();
                foreach (DataRow raw1 in dt.Rows)
                    if (raw1["Unit"].ToString().Trim() == _tmpUnit)
                        _k++;
                if (_k == 0)
                {
                    DataRow _addrow = dt.NewRow();
                    _addrow["Unit"] = _tmpUnit;
                    dt.Rows.Add(_addrow);
                }
            }
        }
    }
}
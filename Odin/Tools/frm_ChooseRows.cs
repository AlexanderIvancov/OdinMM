using Odin.Global_Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Odin.Tools
{
    public partial class frm_ChooseRows : frm_TemplateExportDataDGV
    {
        DAL_Functions DAL = new DAL_Functions();

        public frm_ChooseRows()
        {
            InitializeComponent();
        }
        public DataTable RowsList = new DataTable();

        public void AddCheckRows(DataTable dgv)
        {
            var xCoord = 5;
            var yCoord = 0;
            var colCount = 0;
            DAL.UserLogin = System.Environment.UserName;
            foreach (DataRow row in dgv.Rows)
            {
                var chk = new CheckBox();

                colCount++;
                if (colCount > 2)
                {
                    colCount = 1;
                    xCoord = 5;
                    yCoord += 25;
                }
                RowsList = dgv;
                chk.Location = new Point(xCoord, yCoord);
                xCoord += 150;
                chk.Text = row.Field<string>("Article");
                chk.CheckState = CheckState.Checked;

                panel1.Controls.Add(chk);
            }
        }

        private void frm_ChooseRows_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                var list = new List<string>();
                foreach (var ctrl in panel1.Controls)
                    if (ctrl is CheckBox)
                    {
                        var i = ctrl as CheckBox;
                        if (i.Checked) list.Add(i.Text);
                    }
                var str = "Article = '" + String.Join("' OR Article = '", list.ToArray()) + "'";
                RowsList = RowsList.Select(str).CopyToDataTable();
            }
        }

        private void chk_CheckAll_CheckStateChanged(object sender, EventArgs e)
        {
            foreach (var ctrl in panel1.Controls)
            {
                if (ctrl is CheckBox)
                {
                    var i = ctrl as CheckBox;
                    i.CheckState = chk_CheckAll.CheckState;
                }
            }
        }
    }
}
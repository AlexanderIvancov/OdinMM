using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Workspace;
using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;

namespace Odin.Tools
{
    public partial class frm_ChooseColumns : frm_TemplateExportDataDGV
    {
        public List<DataGridViewColumn> ColumnsList
        {
            get;
            set;
        }

        DAL_Functions DAL = new DAL_Functions();

        public frm_ChooseColumns()
        {
            InitializeComponent();
        }

        public void AddCheckBoxes(DataGridView dgv, string formname)
        {
            var xCoord = 5;
            var yCoord = 0;
            var colCount = 0;
            int visible = 0;
            int UserId = 0;
            DAL.UserLogin = System.Environment.UserName;
            UserId = DAL.UserId;


            //dgv.Columns.foreach (c => c.DisplayIndex = c.Index)
            //{

            //}
            
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                
                var chk = new CheckBox();

                colCount++;
                if (colCount > 2)
                {
                    colCount = 1;
                    xCoord = 5;
                    yCoord += 25;
                }

                chk.Location = new Point(xCoord, yCoord);
                xCoord += 150;
                chk.Text = col.HeaderText;
                chk.Tag = col.Name;

                visible = Convert.ToInt32(Helper.GetOneRecord("select isnull(columnexport, 0) as cex from mnu_colvis where formname = '" + formname
                                        + "' and gridname = '" + dgv.Name + "' and columnname = '" + col.Name + "' and userid = " + UserId + ""));

                //if (col.Visible)
                //{
                //    chk.CheckState = CheckState.Checked;
                //}

                if (visible == -1)
                {
                    chk.CheckState = CheckState.Checked;
                }

                panel1.Controls.Add(chk);
            }
        }

        private void frm_ChooseColumns_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                ColumnsList = new List<DataGridViewColumn>();
                foreach (var ctrl in panel1.Controls)
                {
                    if (ctrl is CheckBox)
                    {
                        var i = ctrl as CheckBox;
                        if (i.Checked)
                        {
                            var dgvColumn = new DataGridViewColumn();
                            dgvColumn.HeaderText = i.Text;
                            dgvColumn.Name = i.Tag.ToString();

                            ColumnsList.Add(dgvColumn);
                        }

                    }
                }
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

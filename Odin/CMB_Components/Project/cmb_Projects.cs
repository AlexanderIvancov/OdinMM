﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Odin.Global_Classes;
using System.Data.SqlClient;

namespace Odin.CMB_Components.Project
{
    public delegate void ProjectsEventHandler(object sender);
    public partial class cmb_Projects : UserControl
    {
        public cmb_Projects()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();

        }
        public event ProjectsEventHandler ProjectsChanged;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;

        int _ProjectId = 0;
        int _PrevId = 0;

        bool _EnableSearchId = false;
        string _Project = "";


        bool _isemptycolor = false;

        public bool IsEmptyColor
        {
            get { return _isemptycolor; }
            set
            {
                _isemptycolor = value;
                if (value == true)
                    txt_Project.StateCommon.Back.Color1 = Color.LightPink;
                else
                    txt_Project.StateCommon.Back.Color1 = Color.White;
            }
        }

        public string Project
        {
            get { return txt_Project.Text; }
            set
            {

                _Project = value;
                txt_Project.Text = value;
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT DISTINCT TOP 1 id FROM BAS_Projects WHERE project = '" + _Project.ToString() + "'", sConnStr);

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                try
                {
                    ProjectId = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                }
                catch
                {

                    _ProjectId = 0;
                    return;
                }

                if (ProjectsChanged != null)
                {
                    ProjectsChanged(this);
                }
            }
        }
        public int ProjectId
        {
            get
            {
                try { return _ProjectId; }
                catch { return 0; }
            }
            set
            {


                _ProjectId = value;

                if (_PrevId != ProjectId)
                {
                    SqlConnection conn = new SqlConnection(sConnStr);
                    conn.Open();

                    DataSet ds = new DataSet();

                    SqlDataAdapter adapter =
                        new SqlDataAdapter("SELECT top 1 * FROM BAS_Projects WHERE id = " + _ProjectId.ToString(), conn);
                    adapter.Fill(ds);

                    conn.Close();

                    DataTable dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_Project.Text = dr["project"].ToString();
                        }
                    }
                    else
                    {
                        txt_Project.Text = string.Empty;
                    }

                    _PrevId = _ProjectId;

                    if (ProjectsChanged != null)
                    {
                        ProjectsChanged(this);
                    }

                }
            }
        }
        public bool EnableSearchId
        {
            get
            {
                return _EnableSearchId;
            }
            set
            {
                _EnableSearchId = value;
            }
        }
        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Project.Text = string.Empty;
        }

        private void txt_Project_TextChanged(object sender, EventArgs e)
        {
            try { Project = txt_Project.Text; }
            catch { }
        }

        private void btn_AdvView_Click(object sender, EventArgs e)
        {
            Form f;
            f = this.FindForm();

            Point LocationPoint = this.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X;
            int ypos = LocationPoint.Y + this.Height;
            Point _location = new Point(xpos, ypos);

            frm_Projects popup = new frm_Projects();
            popup.cmb_ProjectOne = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillData(Project);
        }
    }
}
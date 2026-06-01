using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Odin.Global_Classes;
using Odin.Tools;
using System.Data.SqlClient;
using ComponentFactory.Krypton.Toolkit;
using ComponentFactory.Krypton.Ribbon;

namespace Odin.Workshop
{
    public partial class frm_Workplaces : BaseForm
    {
        public frm_Workplaces()
        {
            InitializeComponent();
        }

        #region Variables

        #endregion

        #region Control

        #endregion

        #region Methods

        #endregion

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

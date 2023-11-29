using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odin.CMB_Components.Articles
{
    public partial class frm_ArtSetup : Form
    {
        public frm_ArtSetup()
        {
            InitializeComponent();
        }
        bool _showingModal = false;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }
    }
}

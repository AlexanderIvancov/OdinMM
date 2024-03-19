using Odin.Global_Classes;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace Odin.Register.Companies
{
    public partial class ctl_Addresses : UserControl
    {
        public ctl_Addresses()
        {
            InitializeComponent();
        }

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        Reg_BLL BLL = new Reg_BLL();

        public int Id
        {
            get;
            set;
        }

        int _FirmId = 0;
        public int FirmId
        {
            get { return cmb_Firms1.FirmId; }
            set { _FirmId = value;
                FillAddresses(_FirmId);
            }
        }

        private void cmb_Firms1_FirmsChanged(object sender)
        {
            FirmId = cmb_Firms1.FirmId;
        }

        public void FillAddresses(int Id)
        {
            var data = (System.Data.DataTable)Helper.getSP("sp_AddressesListFull", Id);

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
        }

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
                if (Convert.ToInt32(row.Cells["cn_isactive"].Value) == 0)
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.Silver;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_AddAddress frm = new frm_AddAddress();
            frm.HeaderText = "Add address for:" + cmb_Firms1.Firm;

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                int _res = Convert.ToInt32(Helper.getSP("sp_AddAddress", FirmId, frm.CountryId, frm.RegionState, frm.City, frm.ZIPcode, frm.Street, frm.House, frm.LegalAddress,
                              frm.ActualAddress, frm.DefaultDelivPlace, frm.Comments, frm.IsActive));

                FillAddresses(FirmId);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0)
            {
                frm_AddAddress frm = new frm_AddAddress();
                frm.Id = _id;
                BLL.AddressId = _id;
                frm.Id = _id;
                frm.CountryId = BLL.AddCountryId;
                frm.FirmId = BLL.AddFirmId;
                frm.RegionState = BLL.AddRegionState;
                frm.City = BLL.AddCity;
                frm.ZIPcode = BLL.AddZIPcode;
                frm.Street = BLL.AddStreet;
                frm.House = BLL.AddHouse;
                frm.IsActive = BLL.AddIsActive;
                frm.LegalAddress = BLL.AddLegalAddress;
                frm.ActualAddress = BLL.AddActualAddress;
                frm.DefaultDelivPlace = BLL.AddDefaultDelivPlace;
                frm.Comments = BLL.AddComments;
                
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Helper.getSP("sp_EditAddress", frm.Id, FirmId, frm.CountryId, frm.RegionState, frm.City, frm.ZIPcode, frm.Street, frm.House, frm.LegalAddress,
                                  frm.ActualAddress, frm.DefaultDelivPlace, frm.Comments, frm.IsActive);

                    FillAddresses(FirmId);
                }

            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (glob_Class.DeleteConfirm() == true
                && _id != 0)
            {
                Helper.getSP("sp_DeleteAddress", _id);
                FillAddresses(FirmId);
            }
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            BLL.AddressId = _id;
        }

        private void gv_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gv_List.CurrentRow.Cells["btn_map"].Selected == true)
            {
                string Link = "https://www.google.com/maps/search/" + BLL.AddFullAddress;
                if (glob_Class.NES(Link) != "")
                    System.Diagnostics.Process.Start(Link);
            }
        }

        private void gv_List_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 9)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Global_Resourses.google_map.Width;
                var h = Global_Resourses.google_map.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Global_Resourses.google_map, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }
    }
}
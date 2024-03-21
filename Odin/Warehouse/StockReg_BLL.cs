using Odin.Global_Classes;
using System;
using System.Data;

namespace Odin.Warehouse
{
    public class StockReg_BLL
    {
        int _placeid = 0;
        public string PlaceName { get; set; }
        public string PlaceDescription { get; set; }
        public int PlaceParentId { get; set; }
        public string PlaceCreatedAt { get; set; }
        public string PlaceCreatedBy { get; set; }
        public int PlaceDeptId { get; set; }
        public int PlaceFirmId { get; set; }
        public int PlaceIsProduction { get; set; }
        public int PlaceRespPersonId { get; set; }
        public int PlaceAddressId { get; set; }
        public int PlaceQuarantine { get; set; }
        public int PlaceIsActive { get; set; }
        public int PlaceOwnerId { get; set; }
        public int PlaceId
        {
            get { return _placeid; }
            set
            {
                _placeid = value;

                var data = Helper.QueryDT("set dateformat dmy select distinct s.id, s.name, isnull(s.description, '') as description, s.parentid, convert(nvarchar(10), s.createdat, 103) as createdat, s.createdby, isnull(s.deptid, 0) as deptid, " +
                     " isnull(s.firmid, 0) as firmid, isnull(s.isproduction, 0) as isproduction, isnull(s.resppersonid, 0) as resppersonid, " +
                     "isnull(s.addressid, 0) as addressid, isnull(s.quarantine, 0) as quarantine, isnull(s.ownerid, 0) as ownerid, isnull(s.isactive, -1) as isactive  " +
                     " from sto_shelves s where s.id = " + PlaceId);
                if (data.Rows.Count > 0)
                    foreach (DataRow dr in data.Rows)
                    {
                        PlaceName = dr["name"].ToString();
                        PlaceDescription = dr["description"].ToString();
                        PlaceParentId = Convert.ToInt32(dr["parentid"]);
                        PlaceCreatedAt = dr["createdat"].ToString();
                        PlaceCreatedBy = dr["createdby"].ToString();
                        PlaceAddressId = Convert.ToInt32(dr["addressid"]);
                        PlaceDeptId = Convert.ToInt32(dr["deptid"]);
                        PlaceFirmId = Convert.ToInt32(dr["firmid"]);
                        PlaceIsProduction = Convert.ToInt32(dr["isproduction"]);
                        PlaceRespPersonId = Convert.ToInt32(dr["resppersonid"]);
                        PlaceQuarantine = Convert.ToInt32(dr["quarantine"]);
                        PlaceOwnerId = Convert.ToInt32(dr["ownerid"]);
                        PlaceIsActive = Convert.ToInt32(dr["isactive"]);
                    }
                else
                    ClearPlaceDets();
            }
        }

        public void ClearPlaceDets()
        {
            PlaceName = "";
            PlaceDescription = "";
            PlaceParentId = 0;
            PlaceCreatedAt = "";
            PlaceCreatedBy = "";
            PlaceAddressId = 0;
            PlaceDeptId = 0;
            PlaceFirmId = 0;
            PlaceIsProduction = 0;
            PlaceRespPersonId = 0;
            PlaceQuarantine = 0;
            PlaceOwnerId = 0;
            PlaceIsActive = -1;
        }
    }
}
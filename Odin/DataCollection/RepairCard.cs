using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Dapper;
using System.Data.SqlClient;
using System.Data;
namespace Odin.DataCollection
{
    /*
     public class RepairCardRepository
{
    private readonly string _connectionString = "YOUR_CONNECTION_STRING";

    public RepairCard GetRepairCardById(int id)
    {
        // Пишем один SQL-текст с тремя SELECT-запросами
        string sql = @"
            SELECT * FROM PROD_RepairCard WHERE Id = @Id;
            SELECT * FROM PROD_Dets WHERE RepairCardId = @Id; -- Предполагаем имя FK-колонки
            SELECT * FROM PROD_Materials WHERE RepairCardId = @Id;";

        using (var connection = new SqlConnection(_connectionString))
        {
            // Открываем множественный чтец (GridReader)
            using (var multi = connection.QueryMultiple(sql, new { Id = id }))
            {
                // Порядок считывания ДОЛЖЕН строго соответствовать порядку SELECT в SQL
                var card = multi.Read<RepairCard>().SingleOrDefault();
                
                if (card != null)
                {
                    // Считываем детали и материалы как массивы (или списки)
                    card.Details = multi.Read<Details>().ToArray();
                    card.Materials = multi.Read<Materials>().ToArray();
                }
                
                return card;
            }
        }
    }
}
         */
    /*JSON
    select a.*,
(select * from BAS_Nomenclatures
   where IdCse = a.ID
    FOR JSON PATH) as Nomenclature
from BAS_Articles a
where a.ID = 4
FOR JSON PATH, WITHOUT_ARRAY_WRAPPER 
    */
    public class RepairCard
    {
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        int _rid = 0;
        public int Id {
            get { return _rid; }
            set {
                _rid = value;
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                    SqlDataAdapter adapter =
                        new SqlDataAdapter(
                            "execute sp_SelectRepairCardHead @id = " + _rid, conn);

                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Name = dr["name"].ToString();
                        BatchId = Convert.ToInt32(dr["batchid"]);
                        Serial = dr["serial"].ToString();
                        Analog = dr["analog"].ToString();
                        CreatedBy = dr["who"].ToString();
                        StateId = Convert.ToInt32(dr["stateid"]);
                        ClosedBy = dr["closedby"].ToString();
                        Conclusion = dr["conclusion"].ToString();
                        Comments = dr["comments"].ToString();
                    }
                }
                else
                {
                   ClearData();
                }
            }
        }
        public string Name { get; set; }
        public int BatchId { get; set; }
        public string Serial { get; set; }
        public string Analog { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int StateId { get; set; }
        public string ClosedBy { get; set; }
        public DateTime ClosedAt { get; set; }
        public string Conclusion { get; set; }
        public string Comments { get; set; }
        public Details[] Details { get; set; }
        public Materials[] Materials { get; set; }


        public void ClearData()
        {
            Name = "";
            BatchId = 0;
            Serial = "";
            Analog = "";
            CreatedBy = "";
            StateId = 0;
            ClosedBy = "";
            Conclusion = "";
            Comments = "";

            
        }

    }
    public class Details
    {
        public string defect { get; set; }
        public string repair_description { get; set; }
    }

    public class Materials
    {
        public int label { get; set; }
        public int detid { get; set; }
        public double qty { get; set; }
    }
}

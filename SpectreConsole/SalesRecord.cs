using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectreConsole
{
    internal class SalesRecord : BaseClass <SalesRecord>
    {
        public int QtdSalesRecord { get; set; }

        public string SalesStatus { get; set; }

        public static SalesRecord FullRecord(SqlDataReader sqlSalesRecord)
        {
            SalesRecord salesRecord = new SalesRecord();

            salesRecord.QtdSalesRecord = sqlSalesRecord.GetInt32(0);
            salesRecord.SalesStatus = sqlSalesRecord.GetString(1);

            return salesRecord;
        }

    }
}

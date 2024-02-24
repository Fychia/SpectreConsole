using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectreConsole
{
    internal class PersonRecord : BaseClass <PersonRecord>
    {
        public int QtdRecord { get; set; }

        public static PersonRecord FullRecord(SqlDataReader sqlPersonRecord)
        {
            //Console.WriteLine(sqlPersonRecord[0]);
            PersonRecord personRecod = new PersonRecord();

            personRecod.QtdRecord= sqlPersonRecord.GetInt32(0);

            return personRecod;
        }
    }
}


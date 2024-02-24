using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectreConsole
{
    internal class QueryManagement
    {

        public static List <T> ExecuteQuery <T> (SqlConnection connection, string sql) where T : BaseClass <T>
        {
            List <T> list = new List <T> ();
            try
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
                            //T.FullRecord(reader);

                            list.Add(T.FullRecord(reader));
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao executar a query" + ex.Message);
            }
            return list;
        }
    }
}

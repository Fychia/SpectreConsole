using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectreConsole
{
    internal class Person : BaseClass <Person>
    {
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public static Person FullRecord(SqlDataReader sql) 
        {
            Person person = new Person();

            person.Nome = sql.GetString(0);
            person.Cpf = sql.GetString(1);

            return person;
        }
    }
}


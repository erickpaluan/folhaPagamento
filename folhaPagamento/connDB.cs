using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace folhaPagamento
{
    public class connDB
    {
        public static string GetConnection()
        {
            string server = "localhost";
            string port = "5432";
            string user = "postgres";
            string database = "DB_Justax";
            string senha = "dbadmin";

            string sconn = "Server=" + server +
                ";Port=" + port +
                ";Database=" + database +
                ";Username=" + user +
                ";Password=" + senha + ";";

            return sconn;
        }

    }
}

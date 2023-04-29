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
            string server = "folhadepagamento.cfxlb4p3yaj7.us-east-1.rds.amazonaws.com";
            string port = "5432";
            string user = "postgres";
            string database = "postgres";
            string senha = "postgres";

            string sconn = "Server=" + server +
                ";Port=" + port +
                ";Database=" + database +
                ";Username=" + user +
                ";Password=" + senha + ";";

            return sconn;
        }

    }
}

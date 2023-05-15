using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace folhaPagamento._Classes
{
    public class connDB
    {
        public static string GetConnection()
        {
            string server = "db.slyuvvpzwhypsrvpuojy.supabase.co";
            string port = "5432";
            string user = "postgres";
            string database = "postgres";
            string senha = "zjqWRmCRjc7URUZD";

            string sconn = "Server=" + server +
                ";Port=" + port +
                ";Database=" + database +
                ";Username=" + user +
                ";Password=" + senha + ";";

            return sconn;
        }

    }
}

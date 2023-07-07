using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace folhaPagamento._Classes
{
    public class ConexaoDB
    {
        private string connectionString;
        private NpgsqlConnection connection;

        public static string stringConexao()
        {
            string server = "";
            string port = "";
            string user = "";
            string database = "";
            string senha = "";

            string connectionString = "Server=" + server +
                ";Port=" + port +
                ";Database=" + database +
                ";Username=" + user +
                ";Password=" + senha + ";";

            return connectionString;
        }
        public void AbrirConexao(string connectionString)
        {
            if (connection == null)
            {
                connection = new NpgsqlConnection(connectionString);
            }

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public void FecharConexao()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public NpgsqlConnection GetConnection()
        {
            return connection;
        }


    }
}

using folhaPagamento._Classes;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace folhaPagamento._DAO
{
    internal class PontoDAO : ConexaoDB
    {
        private NpgsqlConnection conn;
        private List<Registro> registro;

        public PontoDAO()
        {
            //string sconn = GetConnection();
            //conn = new NpgsqlConnection(sconn);
            GetConnection();
            AbrirConexao(ConexaoDB.stringConexao());
            registro = new List<Registro>();
        }

        public void RegistrarPonto(string cpf_ponto, DateTime data, DateTime hora)
        {
            string sql = RegistroSQL.adicionaRegistro;
            try
            {
                using (NpgsqlCommand cmdPonto = new NpgsqlCommand(sql, conn))
                {
                    cmdPonto.Parameters.AddWithValue("@cpf_ponto", cpf_ponto);
                    cmdPonto.Parameters.AddWithValue("@data", data);
                    cmdPonto.Parameters.AddWithValue("@hora", hora);

                    cmdPonto.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na marcação ", ex.ToString());
            }
            finally
            {
                MessageBox.Show("Inserido com sucesso!!");
            }
        }
    }
}

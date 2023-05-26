using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Win32;
using System.Drawing;
using System.Security.Cryptography;
using System.Diagnostics.Eventing.Reader;
using folhaPagamento._Classes;

namespace folhaPagamento._DAO
{
    internal class PontoDAO : ConexaoDB
    {
        private List<Registro> registroPonto;

        public PontoDAO()
        {
            registroPonto = new List<Registro>();
        }

        public List<Registro> GetRegistros()
        {
            registroPonto.Clear();
            string sql = RegistroSQL.carregaRegistro;

            using (NpgsqlConnection conn = new NpgsqlConnection(ConexaoDB.stringConexao()))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    try
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Registro registro = new Registro();
                                registro.id_ponto = reader.GetInt32(reader.GetOrdinal("id_ponto"));
                                registro.cpf_ponto = reader.GetString(reader.GetOrdinal("cpf_ponto"));
                                registro.data = reader.GetDateTime(reader.GetOrdinal("data"));
                                registro.hora = reader.GetTimeSpan(reader.GetOrdinal("hora"));

                                registroPonto.Add(registro);
                            }
                        }
                    }
                    catch (NpgsqlException ex)
                    {
                        MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro: " + ex.Message);
                    }
                }
            }

            return registroPonto;
        }

        public static DataTable ExecutarConsulta(string consulta)
        {

            string connectionString = ConexaoDB.stringConexao();
            using (NpgsqlConnection conexao = new NpgsqlConnection(connectionString))
            {
                DataTable dataTable = new DataTable();
                conexao.Open();
                NpgsqlCommand comando = new NpgsqlCommand(consulta, conexao);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(comando);
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public void RegistrarPonto(string cpf_ponto, DateTime data, TimeSpan hora)
        {
            string sql = RegistroSQL.adicionaRegistro;

            using (NpgsqlConnection conn = new NpgsqlConnection(ConexaoDB.stringConexao()))
            {
                conn.Open();
                using (NpgsqlCommand cmdPonto = new NpgsqlCommand(sql, conn))
                {
                    try
                    {
                        cmdPonto.Parameters.AddWithValue("@cpf_ponto", cpf_ponto);
                        cmdPonto.Parameters.AddWithValue("@data", data);
                        cmdPonto.Parameters.AddWithValue("@hora", hora);

                        cmdPonto.ExecuteNonQuery();

                        MessageBox.Show("Marcação Feita com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (NpgsqlException ex)
                    {
                        MessageBox.Show("Erro ao acessar o banco de dados:" + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro: " + ex.Message);
                    }
                }
            }
        }
    }
}

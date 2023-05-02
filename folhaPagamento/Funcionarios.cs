using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using Microsoft.Win32;
using System.Drawing;
using System.Security.Cryptography;

namespace folhaPagamento
{
    public class Funcionarios : connDB
    {
        private NpgsqlConnection conn;
        private List<Users> users;


        public Funcionarios()
        {
            string sconn = connDB.GetConnection();
            conn = new NpgsqlConnection(sconn);
            conn.Open();
            this.users = new List<Users>();
        }

        public List<Users> GetAllFuncionarios()
        {
            this.users.Clear();
            string sql = "SELECT funcionario.id_func, funcionario.nome, funcionario.cpf, funcionario.dt_nasc, funcionario.idade, " +
                         "contato.tipo, contato.ddd, contato.num_tel, " +
                         "endereco.logradouro, endereco.num_res, endereco.cep, endereco.cidade, endereco.estado " +
                         "FROM funcionario " +
                         "INNER JOIN contato ON funcionario.id_func = contato.id_ctt " +
                         "INNER JOIN endereco ON funcionario.id_func = endereco.id_end;";

            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Users funcionario = new Users();
                        funcionario.id_func = reader.GetInt32(reader.GetOrdinal("id_func"));
                        funcionario.nome = reader.GetString(reader.GetOrdinal("nome"));
                        funcionario.cpf = reader.GetString(reader.GetOrdinal("cpf"));
                        funcionario.dt_nasc = reader.GetDateTime(reader.GetOrdinal("dt_nasc"));
                        if (!reader.IsDBNull(reader.GetOrdinal("idade")))
                        {
                            funcionario.idade = reader.GetInt32(reader.GetOrdinal("idade"));
                        }
                        else
                        {
                            funcionario.idade = 32; // ou atribua um valor padrão
                        }
                        funcionario.tipo = reader.GetString(reader.GetOrdinal("tipo"));
                        funcionario.ddd = reader.GetString(reader.GetOrdinal("ddd"));
                        funcionario.num_tel = reader.GetString(reader.GetOrdinal("num_tel"));
                        funcionario.logradouro = reader.GetString(reader.GetOrdinal("logradouro"));
                        funcionario.num_res = reader.GetInt32(reader.GetOrdinal("num_res"));
                        funcionario.cep = reader.GetString(reader.GetOrdinal("cep"));
                        funcionario.cidade = reader.GetString(reader.GetOrdinal("cidade"));
                        funcionario.estado = reader.GetString(reader.GetOrdinal("estado"));

                        users.Add(funcionario);
                    }
                }
            }
            return users;
        }

        public void AddFuncionarioContatoEndereco(
            string nome,
            string cpf,
            DateTime dt_nasc,
            int idade,
            string tipo,
            string ddd,
            string num_tel,
            string logradouro,
            int num_res,
            string cep,
            string cidade,
            string estado)
        {
            string sql = "ROLLBACK;" +
                         "BEGIN;" +
                         "INSERT INTO funcionario (nome, cpf, dt_nasc, idade) " +
                         "VALUES (@nome, @cpf, @dt_nasc, @idade) " +
                         "RETURNING id_func;" +
                         "INSERT INTO contato (id_ctt, tipo, ddd, num_tel) " +
                         "VALUES (currval('funcionario_id_func_seq'), @tipo, @ddd, @num_tel);" +
                         "INSERT INTO endereco (id_end, logradouro, num_res, cep, cidade, estado) " +
                         "VALUES (currval('funcionario_id_func_seq'), @logradouro, @num_res, @cep, @cidade, @estado);" +
                         "COMMIT;";

            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@dt_nasc", dt_nasc);
                cmd.Parameters.AddWithValue("@idade", idade);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@ddd", ddd);
                cmd.Parameters.AddWithValue("@num_tel", num_tel);
                cmd.Parameters.AddWithValue("@logradouro", logradouro);
                cmd.Parameters.AddWithValue("@num_res", num_res);
                cmd.Parameters.AddWithValue("@cep", cep);
                cmd.Parameters.AddWithValue("@cidade", cidade);
                cmd.Parameters.AddWithValue("@estado", estado);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateFuncionario(string nome, string cpf, DateTime dt_nasc, int idade, int id_func)
        {
            string sql = "UPDATE funcionario SET nome = @nome, cpf = @cpf, dt_nasc = @dt_nasc, idade = @idade WHERE id_func = @id_func";

            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id_func", id_func);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@dt_nasc", dt_nasc);
                cmd.Parameters.AddWithValue("@idade", idade);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteFuncionario(int id_func)
        {
            NpgsqlTransaction transaction = conn.BeginTransaction();

            try
            {
                NpgsqlCommand command = new NpgsqlCommand("DELETE FROM endereco WHERE id_end = @id_func", conn, transaction);
                command.Parameters.AddWithValue("@id_func", id_func);
                command.ExecuteNonQuery();

                command = new NpgsqlCommand("DELETE FROM contato WHERE id_ctt = @id_func", conn, transaction);
                command.Parameters.AddWithValue("@id_func", id_func);
                command.ExecuteNonQuery();

                command = new NpgsqlCommand("DELETE FROM funcionario WHERE id_func = @id_func", conn, transaction);
                command.Parameters.AddWithValue("@id_func", id_func);
                command.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
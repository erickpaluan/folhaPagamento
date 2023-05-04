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
using System.Diagnostics.Eventing.Reader;

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

        public List<Users> GetAllFuncionarios() // mostra dados datagridview
        {
            this.users.Clear();
            string sql = "SELECT funcionario.id_func, funcionario.ativo, funcionario.nome, funcionario.cpf, funcionario.dt_nasc, funcionario.idade, funcionario.sexo, " +
                         "funcionario.estado_civil, funcionario.dt_adm, funcionario.cargo, funcionario.matricula, funcionario.conv_med, funcionario.conv_odon, " +
                         "funcionario.login, funcionario.senha, funcionario.salario, funcionario.adm, " +
                         "contato.email, contato.tipo, contato.ddd, contato.num_tel, " +
                         "endereco.logradouro, endereco.rua, endereco.complemento, endereco.bairro, endereco.num_res, endereco.cep, endereco.cidade, endereco.estado " +
                         "FROM funcionario " +
                         "INNER JOIN contato ON funcionario.id_func = contato.id_ctt " +
                         "INNER JOIN endereco ON funcionario.id_func = endereco.id_end;";

            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Dados funcionario
                        Users funcionario = new Users();
                        funcionario.id_func = reader.GetInt32(reader.GetOrdinal("id_func"));
                        funcionario.ativo = reader.GetBoolean(reader.GetOrdinal("ativo"));
                        funcionario.nome = reader.GetString(reader.GetOrdinal("nome"));
                        funcionario.cpf = reader.GetString(reader.GetOrdinal("cpf"));
                        funcionario.dt_nasc = reader.GetDateTime(reader.GetOrdinal("dt_nasc"));
                        funcionario.idade = reader.GetInt32(reader.GetOrdinal("idade"));
                        funcionario.sexo = reader.GetString(reader.GetOrdinal("sexo"));
                        funcionario.estado_civil = reader.GetString(reader.GetOrdinal("estado_civil"));
                        funcionario.dt_adm = reader.GetDateTime(reader.GetOrdinal("dt_adm"));
                        funcionario.cargo = reader.GetString(reader.GetOrdinal("cargo"));
                        funcionario.matricula = reader.GetString(reader.GetOrdinal("matricula"));
                        funcionario.conv_med = reader.GetBoolean(reader.GetOrdinal("conv_med"));
                        funcionario.conv_odon = reader.GetBoolean(reader.GetOrdinal("conv_odon"));
                        funcionario.login = reader.GetString(reader.GetOrdinal("login"));
                        funcionario.senha = reader.GetString(reader.GetOrdinal("senha"));
                        funcionario.salario = reader.GetFloat(reader.GetOrdinal("salario"));
                        funcionario.adm = reader.GetBoolean(reader.GetOrdinal("adm"));

                        // Dados contato
                        funcionario.email = reader.GetString(reader.GetOrdinal("email"));
                        funcionario.tipo = reader.GetString(reader.GetOrdinal("tipo"));
                        funcionario.ddd = reader.GetString(reader.GetOrdinal("ddd"));
                        funcionario.num_tel = reader.GetString(reader.GetOrdinal("num_tel"));

                        // Dados endereco
                        funcionario.logradouro = reader.GetString(reader.GetOrdinal("logradouro"));
                        funcionario.rua = reader.GetString(reader.GetOrdinal("rua"));
                        funcionario.complemento = reader.IsDBNull(reader.GetOrdinal("complemento")) ? string.Empty : reader.GetString(reader.GetOrdinal("complemento"));
                        funcionario.bairro = reader.GetString(reader.GetOrdinal("bairro"));
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
            bool ativo,
            string nome, 
            string cpf, 
            DateTime dt_nasc, 
            int idade,
            string sexo,
            string estado_civil,
            DateTime dt_adm,
            string cargo,
            string matricula,
            bool conv_med,
            bool conv_odon,
            string login,
            string senha,
            float salario,
            bool adm,
            string email,
            string tipo, 
            string ddd, 
            string num_tel, 
            string logradouro,
            string rua,
            string complemento,
            string bairro,
            int num_res, 
            string cep, 
            string cidade, 
            string estado)
        {
            string sql = "ROLLBACK;" +
                         "BEGIN;" +
                         "INSERT INTO funcionario (ativo, nome, cpf, dt_nasc, idade, sexo, estado_civil, dt_adm, cargo, matricula, conv_med, conv_odon, login, senha, salario, adm) " +
                         "VALUES (@ativo, @nome, @cpf, @dt_nasc, @idade, @sexo, @estado_civil, @dt_adm, @cargo, @matricula, @conv_med, @conv_odon, @login, @senha, @salario, @adm) " +
                         "RETURNING id_func;" +
                         "INSERT INTO contato (id_ctt, email, tipo, ddd, num_tel) " +
                         "VALUES (currval('funcionario_id_func_seq'), @email, @tipo, @ddd, @num_tel);" +
                         "INSERT INTO endereco (id_end, logradouro, rua, complemento, bairro, num_res, cep, cidade, estado) " +
                         "VALUES (currval('funcionario_id_func_seq'), @logradouro, @rua, @complemento, @bairro, @num_res, @cep, @cidade, @estado);" +
                         "COMMIT;";

            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@ativo", ativo);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@dt_nasc", dt_nasc);
                cmd.Parameters.AddWithValue("@idade", idade);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@estado_civil", estado_civil);
                cmd.Parameters.AddWithValue("@dt_adm", dt_adm);
                cmd.Parameters.AddWithValue("@cargo", cargo);
                cmd.Parameters.AddWithValue("@matricula", matricula);
                cmd.Parameters.AddWithValue("@conv_med", conv_med);
                cmd.Parameters.AddWithValue("@conv_odon", conv_odon);
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@salario", salario);
                cmd.Parameters.AddWithValue("@adm", adm);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@ddd", ddd);
                cmd.Parameters.AddWithValue("@num_tel", num_tel);
                cmd.Parameters.AddWithValue("@logradouro", logradouro);
                cmd.Parameters.AddWithValue("@rua", rua);
                cmd.Parameters.AddWithValue("@complemento", complemento);
                cmd.Parameters.AddWithValue("@bairro", bairro);
                cmd.Parameters.AddWithValue("@num_res", num_res);
                cmd.Parameters.AddWithValue("@cep", cep);
                cmd.Parameters.AddWithValue("@cidade", cidade);
                cmd.Parameters.AddWithValue("@estado", estado);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateFuncionario(
            int id_func,
            bool ativo,
            string nome,
            string cpf,
            DateTime dt_nasc,
            int idade,
            string sexo,
            string estado_civil,
            DateTime dt_adm,
            string cargo,
            string matricula,
            bool conv_med,
            bool conv_odon,
            string login,
            string senha,
            float salario,
            bool adm,
            string email,
            string tipo,
            string ddd,
            string num_tel,
            string logradouro,
            string rua,
            string complemento,
            string bairro,
            int num_res,
            string cep,
            string cidade,
            string estado)
        {
            using (NpgsqlTransaction transaction = conn.BeginTransaction())
            {
                try
                {
                    // Inserindo na tabela funcionario
                    string sqlfuncionario = "UPDATE funcionario SET nome = @nome, cpf = @cpf, dt_nasc = @dt_nasc, idade = @idade, ativo = @ativo, sexo = @sexo, " +
                        "estado_civil = @estado_civil, dt_adm = @dt_adm, cargo = @cargo, matricula = @matricula, conv_med = @conv_med, conv_odon = @conv_odon, " +
                        "login = @login, senha = @senha, salario = @salario, adm = @adm " +
                        "WHERE id_func = @id_func";

                    using (NpgsqlCommand cmdFuncionario = new NpgsqlCommand(sqlfuncionario, conn))
                    {
                        cmdFuncionario.Parameters.AddWithValue("@id_func", id_func);
                        cmdFuncionario.Parameters.AddWithValue("@nome", nome);
                        cmdFuncionario.Parameters.AddWithValue("@ativo", ativo);
                        cmdFuncionario.Parameters.AddWithValue("@cpf", cpf);
                        cmdFuncionario.Parameters.AddWithValue("@dt_nasc", dt_nasc);
                        cmdFuncionario.Parameters.AddWithValue("@sexo", sexo);
                        cmdFuncionario.Parameters.AddWithValue("@estado_civil", estado_civil);
                        cmdFuncionario.Parameters.AddWithValue("@dt_adm", dt_adm);
                        cmdFuncionario.Parameters.AddWithValue("@cargo", cargo);
                        cmdFuncionario.Parameters.AddWithValue("@matricula", matricula);
                        cmdFuncionario.Parameters.AddWithValue("@conv_med", conv_med);
                        cmdFuncionario.Parameters.AddWithValue("@conv_odon", conv_odon);
                        cmdFuncionario.Parameters.AddWithValue("@login", login);
                        cmdFuncionario.Parameters.AddWithValue("@senha", senha);
                        cmdFuncionario.Parameters.AddWithValue("@salario", salario);
                        cmdFuncionario.Parameters.AddWithValue("@adm", adm);

                        cmdFuncionario.ExecuteNonQuery();
                    }

                    // Inserindo na tabela endereco
                    string sqlendereco = "UPDATE endereco SET logradouro = @logradouro, rua = @rua, complemento = @complemento, bairro = @bairro, num_res = @num_res, cep = @cep, cidade = @cidade, estado = @estado " +
                        "WHERE id_end = @id_func";

                    using (NpgsqlCommand cmdEndereco = new NpgsqlCommand(sqlendereco, conn))
                    {
                        cmdEndereco.Parameters.AddWithValue("@id_func", id_func);
                        cmdEndereco.Parameters.AddWithValue("@logradouro", logradouro);
                        cmdEndereco.Parameters.AddWithValue("@rua", rua);
                        cmdEndereco.Parameters.AddWithValue("@complemento", complemento);
                        cmdEndereco.Parameters.AddWithValue("@bairro", bairro);
                        cmdEndereco.Parameters.AddWithValue("@num_res", num_res);
                        cmdEndereco.Parameters.AddWithValue("@cep", cep);
                        cmdEndereco.Parameters.AddWithValue("@cidade", cidade);
                        cmdEndereco.Parameters.AddWithValue("@estado", estado);

                        cmdEndereco.ExecuteNonQuery();
                    }

                    // Inserindo na tabela contato
                    string sqlcontato = "UPDATE contato SET email = @email, tipo = @tipo, ddd = @ddd, num_tel = @num_tel " +
                        "WHERE id_ctt = @id_func";

                    using (NpgsqlCommand cmdContato = new NpgsqlCommand(sqlcontato, conn))
                    {
                        cmdContato.Parameters.AddWithValue("@id_func", id_func);
                        cmdContato.Parameters.AddWithValue("@email", email);
                        cmdContato.Parameters.AddWithValue("@tipo", tipo);
                        cmdContato.Parameters.AddWithValue("@ddd", ddd);
                        cmdContato.Parameters.AddWithValue("@num_tel", num_tel);

                        cmdContato.ExecuteNonQuery();
                        transaction.Commit();
                    }
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
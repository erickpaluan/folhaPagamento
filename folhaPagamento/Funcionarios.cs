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
            string sql = "SELECT funcionario.id_func, funcionario.ativo, funcionario.nome, funcionario.cpf, funcionario.dt_nasc, funcionario.idade, funcionario.sexo, funcionario.estado_civil, funcionario.dt_adm, funcionario.cargo, funcionario.matricula, funcionario.conv_med, funcionario.conv_odon, funcionario.login, funcionario.senha, " +
                         "contato.email, contato.tipo, contato.ddd, contato.num_tel, " +
                         "endereco.logradouro, endereco.bairro, endereco.num_res, endereco.cep, endereco.cidade, endereco.estado " +
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
                        if (!reader.IsDBNull(reader.GetOrdinal("ativo")))
                        {
                            funcionario.ativo = reader.GetBoolean(reader.GetOrdinal("ativo"));
                        }
                        else
                        {
                            funcionario.ativo = false; // ou atribua outro valor padrão
                        }

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
                        if (!reader.IsDBNull(reader.GetOrdinal("sexo")))
                        {
                            funcionario.sexo = reader.GetString(reader.GetOrdinal("sexo"));
                        }
                        else
                        {
                            funcionario.sexo = string.Empty; // ou atribua outro valor padrão
                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("estado_civil")))
                        {
                            funcionario.estado_civil = reader.GetString(reader.GetOrdinal("estado_civil"));
                        }
                        else
                        {
                            funcionario.estado_civil = string.Empty; // ou atribua outro valor padrão
                        }

                        if (!reader.IsDBNull(reader.GetOrdinal("dt_adm")))
                        {
                            funcionario.dt_adm = reader.GetDateTime(reader.GetOrdinal("dt_adm"));
                        }
                        else
                        {
                            funcionario.dt_adm = DateTime.MinValue; // ou atribua outro valor padrão
                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("cargo")))
                        {
                            funcionario.cargo = reader.GetString(reader.GetOrdinal("cargo"));
                        }
                        else
                        {
                            funcionario.cargo= string.Empty; // ou atribua outro valor padrão
                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("matricula")))
                        {
                            funcionario.matricula = reader.GetString(reader.GetOrdinal("matricula"));
                        }
                        else
                        {
                            funcionario.matricula = string.Empty; // ou atribua outro valor padrão
                        }

                        if (!reader.IsDBNull(reader.GetOrdinal("conv_med")))
                        {
                            funcionario.conv_med = reader.GetBoolean(reader.GetOrdinal("conv_med"));
                        }
                        else
                        {
                            funcionario.conv_med = false; // ou atribua outro valor padrão
                        }

                        if (!reader.IsDBNull(reader.GetOrdinal("conv_odon")))
                        {
                            funcionario.conv_odon = reader.GetBoolean(reader.GetOrdinal("conv_odon"));
                        }
                        else
                        {
                            funcionario.conv_odon = false; // ou atribua outro valor padrão
                        }

                        funcionario.login = reader.GetString(reader.GetOrdinal("login"));
                        funcionario.senha = reader.GetString(reader.GetOrdinal("senha"));

                        // Dados contato
                        funcionario.email = reader.GetString(reader.GetOrdinal("email"));
                        funcionario.tipo = reader.GetString(reader.GetOrdinal("tipo"));
                        funcionario.ddd = reader.GetString(reader.GetOrdinal("ddd"));
                        funcionario.num_tel = reader.GetString(reader.GetOrdinal("num_tel"));

                        // Dados endereco
                        funcionario.logradouro = reader.GetString(reader.GetOrdinal("logradouro"));
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
            string email,
            string tipo, 
            string ddd, 
            string num_tel, 
            string logradouro, 
            string bairro,
            int num_res, 
            string cep, 
            string cidade, 
            string estado)
        {
            string sql = "ROLLBACK;" +
                         "BEGIN;" +
                         "INSERT INTO funcionario (ativo, nome, cpf, dt_nasc, idade, sexo, estado_civil, dt_adm, cargo, matricula, conv_med, conv_odon, login, senha) " +
                         "VALUES (@ativo, @nome, @cpf, @dt_nasc, @idade, @sexo, @estado_civil, @dt_adm, @cargo, @matricula, @conv_med, @conv_odon, @login, @senha) " +
                         "RETURNING id_func;" +
                         "INSERT INTO contato (id_ctt, email, tipo, ddd, num_tel) " +
                         "VALUES (currval('funcionario_id_func_seq'), @email, @tipo, @ddd, @num_tel);" +
                         "INSERT INTO endereco (id_end, logradouro, bairro, num_res, cep, cidade, estado) " +
                         "VALUES (currval('funcionario_id_func_seq'), @bairro, @logradouro, @num_res, @cep, @cidade, @estado);" +
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
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@ddd", ddd);
                cmd.Parameters.AddWithValue("@num_tel", num_tel);
                cmd.Parameters.AddWithValue("@logradouro", logradouro);
                cmd.Parameters.AddWithValue("@bairro", bairro);
                cmd.Parameters.AddWithValue("@num_res", num_res);
                cmd.Parameters.AddWithValue("@cep", cep);
                cmd.Parameters.AddWithValue("@cidade", cidade);
                cmd.Parameters.AddWithValue("@estado", estado);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateFuncionario(
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
            string email,
            string tipo,
            string ddd,
            string num_tel,
            string logradouro,
            string bairro,
            int num_res,
            string cep,
            string cidade,
            string estado)
        {
            string sql = "UPDATE funcionario SET nome = @nome, cpf = @cpf, dt_nasc = @dt_nasc, idade = @idade WHERE id_func = @id_func";

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
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@ddd", ddd);
                cmd.Parameters.AddWithValue("@num_tel", num_tel);
                cmd.Parameters.AddWithValue("@logradouro", logradouro);
                cmd.Parameters.AddWithValue("@bairro", bairro);
                cmd.Parameters.AddWithValue("@num_res", num_res);
                cmd.Parameters.AddWithValue("@cep", cep);
                cmd.Parameters.AddWithValue("@cidade", cidade);
                cmd.Parameters.AddWithValue("@estado", estado);

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
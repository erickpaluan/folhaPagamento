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
    public class FuncionarioDAO
    {
        private List<Funcionario> funcionarios;

        public FuncionarioDAO()
        {
            funcionarios = new List<Funcionario>();
        }

        public List<Funcionario> GetAllFuncionarios()
        {
            funcionarios.Clear();
            string sql = FuncionarioSQL.CarregarFuncionario;

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
                                // Dados funcionario
                                Funcionario funcionario = new Funcionario();
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

                                funcionarios.Add(funcionario);
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

            return funcionarios;
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
            string sql = FuncionarioSQL.AdicionarFuncionario;

            using (NpgsqlConnection conn = new NpgsqlConnection(ConexaoDB.stringConexao()))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    try
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
            using (NpgsqlConnection conn = new NpgsqlConnection(ConexaoDB.stringConexao()))
            {
                conn.Open();

                using (NpgsqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Atualizando tabela funcionario
                        string sqlFuncionario = FuncionarioSQL.AtualizarFuncionario;

                        using (NpgsqlCommand cmdFuncionario = new NpgsqlCommand(sqlFuncionario, conn))
                        {
                            cmdFuncionario.Transaction = transaction;
                            cmdFuncionario.Parameters.AddWithValue("@id_func", id_func);
                            cmdFuncionario.Parameters.AddWithValue("@ativo", ativo);
                            cmdFuncionario.Parameters.AddWithValue("@nome", nome);
                            cmdFuncionario.Parameters.AddWithValue("@cpf", cpf);
                            cmdFuncionario.Parameters.AddWithValue("@dt_nasc", dt_nasc);
                            cmdFuncionario.Parameters.AddWithValue("sexo", sexo);
                            cmdFuncionario.Parameters.AddWithValue("@estado_civil", estado_civil);
                            cmdFuncionario.Parameters.AddWithValue("@dt_adm", dt_adm);
                            cmdFuncionario.Parameters.AddWithValue("@cargo", cargo);
                            cmdFuncionario.Parameters.AddWithValue("@matricula", matricula);
                            cmdFuncionario.Parameters.AddWithValue("@conv_med", conv_med);
                            cmdFuncionario.Parameters.AddWithValue("@conv_odon", conv_odon);
                            cmdFuncionario.Parameters.AddWithValue("@login", login);
                            cmdFuncionario.Parameters.AddWithValue("@senha", senha);
                            cmdFuncionario.Parameters.AddWithValue("salario", salario);
                            cmdFuncionario.Parameters.AddWithValue("@adm", adm);
                            // Definir outros parâmetros...

                            cmdFuncionario.ExecuteNonQuery();
                        }

                        // Atualizando tabela endereco
                        string sqlEndereco = FuncionarioSQL.AtualizarEnderecoFuncionario;

                        using (NpgsqlCommand cmdEndereco = new NpgsqlCommand(sqlEndereco, conn))
                        {
                            cmdEndereco.Transaction = transaction;
                            cmdEndereco.Parameters.AddWithValue("@id_func", id_func);
                            cmdEndereco.Parameters.AddWithValue("@logradouro", logradouro);
                            cmdEndereco.Parameters.AddWithValue("@rua", rua);
                            cmdEndereco.Parameters.AddWithValue("@num_res", num_res);
                            cmdEndereco.Parameters.AddWithValue("@complemento", complemento);
                            cmdEndereco.Parameters.AddWithValue("@bairro", bairro);
                            cmdEndereco.Parameters.AddWithValue("@cep", cep);
                            cmdEndereco.Parameters.AddWithValue("@cidade", cidade);
                            cmdEndereco.Parameters.AddWithValue("@estado", estado);
                            // Definir outros parâmetros...

                            cmdEndereco.ExecuteNonQuery();
                        }

                        // Atualizando tabela contato
                        string sqlContato = FuncionarioSQL.AtualizarContatoFuncionario;

                        using (NpgsqlCommand cmdContato = new NpgsqlCommand(sqlContato, conn))
                        {
                            cmdContato.Transaction = transaction;
                            cmdContato.Parameters.AddWithValue("@id_func", id_func);
                            cmdContato.Parameters.AddWithValue("@email", email);
                            cmdContato.Parameters.AddWithValue("@tipo", tipo);
                            cmdContato.Parameters.AddWithValue("@ddd", ddd);
                            cmdContato.Parameters.AddWithValue("@num_tel", num_tel);
                            // Definir outros parâmetros...

                            cmdContato.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (NpgsqlException ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Ocorreu um erro: " + ex.Message);
                    }
                }
            }
        }


        public void DeleteFuncionario(int id_func)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(ConexaoDB.stringConexao()))
            {
                conn.Open();

                using (NpgsqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        NpgsqlCommand command = new NpgsqlCommand(FuncionarioSQL.DeletarEnderecoFuncionario, conn, transaction);
                        command.Parameters.AddWithValue("@id_func", id_func);
                        command.ExecuteNonQuery();

                        command = new NpgsqlCommand(FuncionarioSQL.DeletarContatoFuncionario, conn, transaction);
                        command.Parameters.AddWithValue("@id_func", id_func);
                        command.ExecuteNonQuery();

                        command = new NpgsqlCommand(FuncionarioSQL.DeletarFuncionario, conn, transaction);
                        command.Parameters.AddWithValue("@id_func", id_func);
                        command.ExecuteNonQuery();

                        transaction.Commit();
                    }
                    catch (NpgsqlException ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Ocorreu um erro: " + ex.Message);
                    }
                }
            }
        }

    }
}
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace folhaPagamento
{
    public class Funcionarios :connDB
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
            string sql = "SELECT funcionario.id_func, funcionario.nome, funcionario.cpf, funcionario.dt_nasc, funcionario.idade, contato.tipo, contato.ddd, contato.num_tel " +
                         "FROM funcionario " +
                         "RIGHT JOIN contato ON funcionario.id_func = contato.id_ctt;";

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
                        funcionario.tipo = reader.GetString(reader.GetOrdinal("tipo"));
                        funcionario.ddd = reader.GetString(reader.GetOrdinal("ddd"));
                        funcionario.num_tel = reader.GetString(reader.GetOrdinal("num_tel"));
                        if (!reader.IsDBNull(reader.GetOrdinal("idade")))
                        {
                            funcionario.idade = reader.GetInt32(reader.GetOrdinal("idade"));
                        }
                        else
                        {
                            funcionario.idade = 32; // ou atribua um valor padrão
                        }



                        users.Add(funcionario);
                    }
                }
            }
            return users;
        }

        public void AddFuncionarioContato(string nome, string cpf, DateTime dt_nasc, int idade, string tipo, string ddd, string num_tel)
        {
            string sql = "ROLLBACK;" +
                         "BEGIN;" +
                         "INSERT INTO funcionario (nome, cpf, dt_nasc, idade) " +
                         "VALUES (@nome, @cpf, @dt_nasc, @idade) " +
                         "RETURNING id_func;" +
                         "INSERT INTO contato (id_ctt, tipo, ddd, num_tel) " +
                         "VALUES (currval('funcionario_id_func_seq'), @tipo, @ddd, @num_tel);" +
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
            string sql = "DELETE FROM funcionario WHERE id_func = @id_func";
            

            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id_func", id_func);

                cmd.ExecuteNonQuery();
            }
        }


    }
}

using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace folhaPagamento
{
    public class connDAO :connDB
    {
        private NpgsqlConnection conn;
        private List<Users> users;


        public connDAO()
        {
            string sconn = connDB.GetConnection();
            conn = new NpgsqlConnection(sconn);
            conn.Open();
            this.users = new List<Users>();
        }

        public List<Users> GetAllFuncionarios()
        {
            this.users.Clear();
            string sql = "SELECT * FROM funcionario";

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



                        users.Add(funcionario);
                    }
                }
            }
            return users;
        }

        public void AddFuncionario(string nome, string cpf, DateTime dt_nasc, int idade)
        {
            string sql = "INSERT INTO funcionario (nome, cpf, dt_nasc, idade) VALUES (@nome, @cpf, @dt_nasc, @idade)";

            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@dt_nasc", dt_nasc);
                cmd.Parameters.AddWithValue("@idade", idade);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateFuncionario(string nome, string cpf, string dt_nasc, int idade)
        {
            string sql = "UPDATE funcionario SET nome = @nome, cpf = @cpf, dt_nasc = @dt_nasc, idade = @idade WHERE id_func = @id";

            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
            {
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

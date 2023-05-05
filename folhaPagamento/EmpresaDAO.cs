using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace folhaPagamento
{
    internal class EmpresaDAO : connDB
    {
        private NpgsqlConnection conn;
        private List<Empresa> empresa;


        public EmpresaDAO()
        {
            string sconn = connDB.GetConnection();
            conn = new NpgsqlConnection(sconn);
            conn.Open();
            this.empresa = new List<Empresa>();
        }

        public List<Empresa> GetAll()
        {
            this.empresa.Clear();
            string sqlempresa = "";

            using (NpgsqlCommand cmdEmpresa = new NpgsqlCommand(sqlempresa, conn))
            {
                using (NpgsqlDataReader reader = cmdEmpresa.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Empresa empresa = new Empresa();
                        empresa.RazaoSocial = reader.GetString(reader.GetOrdinal("RazaoSocial"));
                        empresa.NomeFantasia = reader.GetString(reader.GetOrdinal("Nomefantasia"));
                        empresa.CNPJ = reader.GetString(reader.GetOrdinal("CNPJ"));
                        empresa.InscricaoEstadual = reader.GetString(reader.GetOrdinal("InscricaoEstadual"));
                        empresa.Endereco = reader.GetString(reader.GetOrdinal("Endereco"));
                        empresa.Numero = reader.GetString(reader.GetOrdinal("Numero"));
                        empresa.Complemento = reader.GetString(reader.GetOrdinal("Complemento"));
                        empresa.Bairro = reader.GetString(reader.GetOrdinal("Bairro"));
                        empresa.Cidade = reader.GetString(reader.GetOrdinal("Cidade"));
                        empresa.Estado = reader.GetString(reader.GetOrdinal("Estado"));
                        empresa.CEP = reader.GetString(reader.GetOrdinal("CEP"));
                        empresa.Telefone = reader.GetString(reader.GetOrdinal("Telefone"));
                        empresa.Email = reader.GetString(reader.GetOrdinal("Email"));
                    }
                }
            }
            return empresa;
        }

        public void AddEmpresa(
        string RazaoSocial,
        string NomeFantasia,
        string CNPJ,
        string InscricaoEstadual,
        string Endereco,
        string Numero,
        string Complemento,
        string Bairro,
        string Cidade,
        string Estado,
        string CEP,
        string Telefone,
        string Email)
        {
            string sqlAdd = "INSERT INTO empresa (razaosocial, nomefantasia, cnpj, inscricaoestadual, " +
                "endereco, numero, complemento, bairro, cidade, estado, cep, telefone, email) " +
                "VALUES (@RazaoSocial, @NomeFantasia, @CNPJ, @InscricaoEstadual, @Endereco, @Numero, @Complemento, @Bairro, @Cidade, @Estado, @CEP, @Telefone, @Email);";
            ;

            using (NpgsqlCommand cmd = new NpgsqlCommand(sqlAdd, conn))
            {
                cmd.Parameters.AddWithValue("@RazaoSocial", RazaoSocial);
                cmd.Parameters.AddWithValue("@NomeFantasia", NomeFantasia);
                cmd.Parameters.AddWithValue("@CNPJ", CNPJ);
                cmd.Parameters.AddWithValue("@InscricaoEstadual", InscricaoEstadual);
                cmd.Parameters.AddWithValue("@Endereco", Endereco);
                cmd.Parameters.AddWithValue("@Numero", Numero);
                cmd.Parameters.AddWithValue("@Complemento", Complemento);
                cmd.Parameters.AddWithValue("@Bairro", Bairro);
                cmd.Parameters.AddWithValue("@Cidade", Cidade);
                cmd.Parameters.AddWithValue("@Estado", Estado);
                cmd.Parameters.AddWithValue("@CEP", CEP);
                cmd.Parameters.AddWithValue("@Telefone", Telefone);
                cmd.Parameters.AddWithValue("@Email", Email);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateEmpresa(
            string RazaoSocial,
        string NomeFantasia,
        string CNPJ,
        string InscricaoEstadual,
        string Endereco,
        string Numero,
        string Complemento,
        string Bairro,
        string Cidade,
        string Estado,
        string CEP,
        string Telefone, 
        string Email)

        {
            string sqlUp = "";

            using (NpgsqlCommand cmd = new NpgsqlCommand(sqlUp, conn))
            {
                cmd.Parameters.AddWithValue("@RazaoSocial", RazaoSocial);
                cmd.Parameters.AddWithValue("@NomeFantasia", NomeFantasia);
                cmd.Parameters.AddWithValue("@CNPJ", CNPJ);
                cmd.Parameters.AddWithValue("@InscricaoEstadual", InscricaoEstadual);
                cmd.Parameters.AddWithValue("@Endereco", Endereco);
                cmd.Parameters.AddWithValue("@Numero", Numero);
                cmd.Parameters.AddWithValue("@Complemento", Complemento);
                cmd.Parameters.AddWithValue("@Bairro", Bairro);   
                cmd.Parameters.AddWithValue("@Cidade", Cidade);
                cmd.Parameters.AddWithValue("@Estado", Estado);
                cmd.Parameters.AddWithValue("@CEP", CEP);
                cmd.Parameters.AddWithValue("@Telefone", Telefone);
                cmd.Parameters.AddWithValue("@Email", Email);

                cmd.ExecuteNonQuery();
            }
        }
    }
}

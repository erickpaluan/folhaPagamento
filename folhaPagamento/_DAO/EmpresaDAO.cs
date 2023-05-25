using folhaPagamento._Classes;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace folhaPagamento._DAO
{
    internal class EmpresaDAO : ConexaoDB
    {
        private List<Empresa> empresa;


        public EmpresaDAO()
        {
            GetConnection();
            AbrirConexao(ConexaoDB.stringConexao());
            empresa = new List<Empresa>();
        }

        public List<Empresa> GetId()
        {
            List<Empresa> empresas = new List<Empresa>();
            string sql = EmpresaSQL.CarregaEmpresa;

            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, GetConnection()))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Empresa empresa = new Empresa();
                        empresa.id_empresa = reader.GetInt32(reader.GetOrdinal("id_empresa"));
                        empresas.Add(empresa);
                    }
                }
            }

            return empresas;
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
            string sqlAdd = EmpresaSQL.AdicionaEmpresa;
            ;

            using (NpgsqlCommand cmd = new NpgsqlCommand(sqlAdd, GetConnection()))
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
            int id_empresa,
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
            string sqlUp = EmpresaSQL.AtualizaEmpresa;

            using (NpgsqlCommand cmd = new NpgsqlCommand(sqlUp, GetConnection()))
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

        public void DeleteEmpresa()
        {
            string sqldelete = EmpresaSQL.DeletaEmpresa;

            using (NpgsqlCommand cmd = new NpgsqlCommand(sqldelete, GetConnection()))
            {

            }
        }
    }
}

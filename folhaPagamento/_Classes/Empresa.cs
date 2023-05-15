using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace folhaPagamento._Classes
{
    internal class Empresa
    {
        public int id_empresa { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public string InscricaoEstadual { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }

    internal static class EmpresaSQL
    {
        public const string CarregaEmpresa = "SELECT * FROM empresa;";
        public const string AdicionaEmpresa = "INSERT INTO empresa(razaosocial, nomefantasia, cnpj, inscricaoestadual, endereco, numero, complemento, bairro, cidade, estado, cep, telefone, email) VALUES(@RazaoSocial, @NomeFantasia, @CNPJ, @InscricaoEstadual, @Endereco, @Numero, @Complemento, @Bairro, @Cidade, @Estado, @CEP, @Telefone, @Email);";
        public const string AtualizaEmpresa = "UPDATE empresa SET razaosocial = @RazaoSocial, nomefantasia = @NomeFantasia, cnpj = @CNPJ, inscricaoestadual = @InscricaoEstadual, endereco = @Endereco, numero = @Numero, complemento = @Complemento, bairro = @Bairro, cidade = @Cidade, estado = @Estado, cep = @CEP, telefone = @Telefone, email = @Email WHERE id_empresa = @IdEmpresa;";
        public const string DeletaEmpresa = "DELETE FROM empresa WHERE id_empresa = @IdEmpresa;";
    }
}

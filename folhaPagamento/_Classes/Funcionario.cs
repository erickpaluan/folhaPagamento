using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace folhaPagamento._Classes
{
    public class Funcionario
    {
        public int id_func { get; set; }
        public bool ativo { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public DateTime dt_nasc { get; set; }
        public int idade { get; set; }
        public string sexo { get; set; }
        public string estado_civil { get; set; }
        public DateTime dt_adm { get; set; }
        public string cargo { get; set; }
        public string matricula { get; set; }
        public bool conv_med { get; set; }
        public bool conv_odon { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public float salario { get; set; }
        public bool adm { get; set; }

        //Variaveis Contato
        public string email { get; set; }
        public string tipo { get; set; }
        public string ddd { get; set; }
        public string num_tel { get; set; }

        //Variaveis Endereço
        public string logradouro { get; set; }
        public string rua { get; set; }
        public int num_res { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cep { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
    }

    public static class FuncionarioSQL
    {
        public const string CarregarFuncionario = "SELECT * FROM empresa;";
        public const string AdicionarFuncionario = "INSERT INTO empresa (razaosocial, nomefantasia, cnpj, inscricaoestadual, endereco, numero, complemento, bairro, cidade, estado, cep, telefone, email) VALUES (@RazaoSocial, @NomeFantasia, @CNPJ, @InscricaoEstadual, @Endereco, @Numero, @Complemento, @Bairro, @Cidade, @Estado, @CEP, @Telefone, @Email);";
        public const string AtualizarFuncionario = "UPDATE empresa SET razaosocial = @RazaoSocial, nomefantasia = @NomeFantasia, cnpj = @CNPJ, inscricaoestadual = @InscricaoEstadual, endereco = @Endereco, numero = @Numero, complemento = @Complemento, bairro = @Bairro, cidade = @Cidade, estado = @Estado, cep = @CEP, telefone = @Telefone, email = @Email WHERE id_empresa = @IdEmpresa;";
        public const string DeletarFuncionario = "DELETE FROM empresa WHERE id_empresa = @IdEmpresa;";
        public const string FazerLoginFuncionario = "SELECT id_func, nome, adm, cpf, salario, ativo, conv_med, conv_odon FROM funcionario WHERE login = @login AND senha = @senha";
    }
}

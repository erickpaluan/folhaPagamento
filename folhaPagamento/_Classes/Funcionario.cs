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
        public const string CarregarFuncionario = "SELECT funcionario.id_func, funcionario.ativo, funcionario.nome, funcionario.cpf, funcionario.dt_nasc, funcionario.idade, funcionario.sexo, funcionario.estado_civil, funcionario.dt_adm, funcionario.cargo, funcionario.matricula, funcionario.conv_med, funcionario.conv_odon, funcionario.login, funcionario.senha, funcionario.salario, funcionario.adm, contato.email, contato.tipo, contato.ddd, contato.num_tel, endereco.logradouro, endereco.rua, endereco.complemento, endereco.bairro, endereco.num_res, endereco.cep, endereco.cidade, endereco.estado FROM funcionario INNER JOIN contato ON funcionario.id_func = contato.id_ctt INNER JOIN endereco ON funcionario.id_func = endereco.id_end;";
        
        public const string AdicionarFuncionario = "ROLLBACK; BEGIN; INSERT INTO funcionario (ativo, nome, cpf, dt_nasc, idade, sexo, estado_civil, dt_adm, cargo, matricula, conv_med, conv_odon, login, senha, salario, adm) VALUES (@ativo, @nome, @cpf, @dt_nasc, @idade, @sexo, @estado_civil, @dt_adm, @cargo, @matricula, @conv_med, @conv_odon, @login, @senha, @salario, @adm) RETURNING id_func; INSERT INTO contato (id_ctt, email, tipo, ddd, num_tel) VALUES (currval('funcionario_id_func_seq'), @email, @tipo, @ddd, @num_tel); INSERT INTO endereco (id_end, logradouro, rua, complemento, bairro, num_res, cep, cidade, estado) VALUES (currval('funcionario_id_func_seq'), @logradouro, @rua, @complemento, @bairro, @num_res, @cep, @cidade, @estado); COMMIT;";
        public const string AdicionarContatoFuncionario = "";
        public const string AdicionarEnderecoFuncionario = "";

        public const string AtualizarFuncionario = "UPDATE funcionario SET ativo = @ativo, nome = @nome, cpf = @cpf, dt_nasc = @dt_nasc, sexo = @sexo, " +
                                                   "estado_civil = @estado_civil, dt_adm = @dt_adm, cargo = @cargo, matricula = @matricula, conv_med = @conv_med, " +
                                                   "conv_odon = @conv_odon, login = @login, senha = @senha, salario = @salario, adm = @adm WHERE id_func = @id_func;";
        public const string AtualizarContatoFuncionario = "UPDATE contato SET email = @email, tipo = @tipo, ddd = @ddd, num_tel = @num_tel WHERE id_ctt = @id_func";
        public const string AtualizarEnderecoFuncionario = "UPDATE endereco SET logradouro = @logradouro, rua = @rua, num_res = @num_res, complemento = @complemento, " +
                                                           "bairro = @bairro, cep = @cep, cidade = @cidade, estado = @estado;";

        public const string DeletarFuncionario = "DELETE FROM funcionario WHERE id_func = @id_func";
        public const string DeletarContatoFuncionario = "DELETE FROM contato WHERE id_ctt = @id_func";
        public const string DeletarEnderecoFuncionario = "DELETE FROM endereco WHERE id_end = @id_func";

        public const string FazerLoginFuncionario = "SELECT id_func, nome, adm, cpf, salario, ativo, conv_med, conv_odon FROM funcionario WHERE login = @login AND senha = @senha";
    }
}

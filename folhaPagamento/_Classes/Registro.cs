using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace folhaPagamento._Classes
{
    internal class Registro
    {
        public int id_ponto { get; set; }
        public string cpf_ponto { get; set; }
        public DateTime data { get; set; }
        public DateTime hora { get; set; }
    }

    internal static class RegistroSQL
    {
        public const string carregaRegistro = "SELECT nome FROM funcionario WHERE cpf = @cpf;";
        public const string adicionaRegistro = "INSERT INTO ponto (cpf_ponto, data, hora) VALUES (@cpf, @data, @hora);";
    }
}

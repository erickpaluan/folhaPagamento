using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace folhaPagamento
{
    public class Users
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
}

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
        public string nome { get; set; }
        public string cpf { get; set; }
        public DateTime dt_nasc { get; set; }
        public int idade { get; set; }
        public string tipo { get; set; }
        public string ddd { get; set; }
        public string num_tel { get; set; }   
        public string logradouro { get; set; }
        public int num_res { get; set; }
        public string cep { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
    }
}

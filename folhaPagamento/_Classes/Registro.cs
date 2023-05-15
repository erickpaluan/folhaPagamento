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
}

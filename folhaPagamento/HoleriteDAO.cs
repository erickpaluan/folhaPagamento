using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace folhaPagamento
{
    public class HoleriteDAO
    {
        public string cpf { get; set; }
        public decimal salariobruto { get; set; }
        public decimal inss { get; set; }
        public decimal irpf { get; set; }
        public decimal convmed { get; set; }
        public decimal convodonto { get; set; }
        public decimal totaldescontos { get; set; }
        public decimal salarioliquido { get; set; }
        public DateTime datapagamento { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace folhaPagamento
{
    public class HoleriteDAO
    {
        public decimal SalarioBase { get; set; }
        public decimal HorasExtras { get; set; }
        public decimal ValorHoraExtra { get; set; }
        public decimal DescontoINSS { get; set; }
        public decimal DescontoIRPF { get; set; }
    }
}

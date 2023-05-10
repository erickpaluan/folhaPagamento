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
        public decimal DescontoINSS { get; set; }
        public decimal DescontoIRPF { get; set; }
        public decimal DescontoConvMed { get; set; }
        public decimal DescontoConvOdon { get; set; }
        public decimal TotalDescontos { get; set; }
        public decimal ValorTotal { get; set; }
    }
}

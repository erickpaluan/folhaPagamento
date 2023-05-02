using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace folhaPagamento
{
    internal class Holerite : HoleriteDAO
    {
        public decimal CalcularSalarioHora()
        {
            return SalarioBase / 220.0m;
        }

        public decimal CalcularValorHoraExtra()
        {
            return HorasExtras * ValorHoraExtra;
        }

        public decimal CalcularSalarioBruto()
        {
            return SalarioBase + CalcularValorHoraExtra();
        }

        public decimal CalcularDescontoINSS()
        {
            return CalcularSalarioBruto() * DescontoINSS;
        }

        public decimal CalcularDescontoIRPF()
        {
            return CalcularSalarioBruto() * DescontoIRPF;
        }

        public decimal CalcularSalarioLiquido()
        {
            return CalcularSalarioBruto() - CalcularDescontoINSS() - CalcularDescontoIRPF();
        }


    }
}

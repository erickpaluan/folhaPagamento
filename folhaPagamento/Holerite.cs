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

        public void ImprimirHolerite()
        {
            Console.WriteLine("Salário base: R$" + SalarioBase);
            Console.WriteLine("Horas extras: " + HorasExtras);
            Console.WriteLine("Valor hora extra: R$" + ValorHoraExtra);
            Console.WriteLine("Salário bruto: R$" + CalcularSalarioBruto());
            Console.WriteLine("Desconto INSS: R$" + CalcularDescontoINSS());
            Console.WriteLine("Desconto IRPF: R$" + CalcularDescontoIRPF());
            Console.WriteLine("Salário líquido: R$" + CalcularSalarioLiquido());
        }
    }
}

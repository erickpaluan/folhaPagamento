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

        public decimal CalcularDescontoINSS(Users Usuarios)
        {
            decimal salario = Convert.ToDecimal(Usuarios.salario);

            double DescontoINSS;
            if (Usuarios.salario <= 3971)
            {
                DescontoINSS = Usuarios.salario * 0.075;
            }
            else if (Usuarios.salario <= 6618)
            {
                DescontoINSS = Usuarios.salario * 0.09;
            }
            else if (Usuarios.salario <= 11019)
            {
                DescontoINSS = Usuarios.salario * 0.12;
            }
            else
            {
                DescontoINSS = 1322.59;
            }
            return Convert.ToDecimal(DescontoINSS);
        }

        public decimal CalcularDescontoIRPF(Users Usuarios)
        {
            decimal salario = Convert.ToDecimal(Usuarios.salario);
            decimal DescontoIRPF = 0m;
            if (salario <= 1903.98m)
            {
                DescontoIRPF = 0m;
            }
            else if (salario <= 2826.65m)
            {
                DescontoIRPF = (salario * 0.075m) - 142.80m;
            }
            else if (salario <= 3751.05m)
            {
                DescontoIRPF = (salario * 0.15m) - 354.80m;
            }
            else if (salario <= 4664.68m)
            {
                DescontoIRPF = (salario * 0.225m) - 636.13m;
            }
            else
            {
                DescontoIRPF = (salario * 0.275m) - 869.36m;
            }
            return DescontoIRPF;
        }

        /*public decimal CalcularSalarioLiquido()
        { 
            return CalcularSalarioBruto() - CalcularDescontoINSS() - CalcularDescontoIRPF();
        }*/


    }
}

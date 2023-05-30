using folhaPagamento._DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace folhaPagamento._Classes
{
    public class Holerite
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

    public static class HoleriteSQL
    {
        public const string CarregaHolerite = "SELECT * FROM folha_pagto";
        public const string AdicionaHolerite = "INSERT INTO folha_pagto (cpf, salariobruto, inss, irpf, convmed, convodonto, totaldescontos, salarioliquido, datapagamento)" +
                                               "VALUES (@cpf, @salariobruto, @inss, @irpf, @convmed, @convodonto, @totaldescontos, @salarioliquido, @datapagamento);";

        public static DataTable FiltrarHolerites(string filtroHolerites)
        {
            string consultaHolerite = "SELECT * FROM folha_pagto WHERE cpf LIKE '%" + filtroHolerites + "%'";
            return HoleriteDAO.ExecutarConsulta(consultaHolerite);
        }
    }
}

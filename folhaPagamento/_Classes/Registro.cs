using folhaPagamento._DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace folhaPagamento._Classes
{
    public class Registro
    {
        public int id_ponto { get; set; }
        public string cpf_ponto { get; set; }
        public DateTime data { get; set; }
        public TimeSpan hora { get; set; }
    }

    public static class RegistroSQL
    {
        public const string carregaRegistro = "SELECT * FROM ponto;";
        public const string adicionaRegistro = "INSERT INTO ponto (cpf_ponto, data, hora) VALUES (@cpf_ponto, @data, @hora);";
        public static DataTable FiltrarRegistros(string filtroRegistro)
        {
            string consultaRegistro = "SELECT * FROM ponto WHERE cpf_ponto LIKE '%" + filtroRegistro + "%'";
            return PontoDAO.ExecutarConsulta(consultaRegistro);
        }
    }
}

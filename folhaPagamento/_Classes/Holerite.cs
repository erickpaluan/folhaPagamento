using folhaPagamento._DAO;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace folhaPagamento._Classes
{
    internal class Holerite : ConexaoDB
    {
        private List<HoleriteDAO> folhapagamento;

        public Holerite()
        {
            folhapagamento = new List<HoleriteDAO>();
        }

        public List<HoleriteDAO> CarregaHolerite()
        {
            folhapagamento.Clear();
            string sql = HoleriteSQL.CarregaHolerite;

            using (NpgsqlConnection conn = new NpgsqlConnection(ConexaoDB.stringConexao()))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Dados holerite
                            HoleriteDAO holerite = new HoleriteDAO();
                            holerite.cpf = reader.GetString(reader.GetOrdinal("cpf"));
                            holerite.salariobruto = reader.GetDecimal(reader.GetOrdinal("salariobruto"));
                            holerite.inss = reader.GetDecimal(reader.GetOrdinal("inss"));
                            holerite.irpf = reader.GetDecimal(reader.GetOrdinal("irpf"));
                            holerite.convmed = reader.GetDecimal(reader.GetOrdinal("convmed"));
                            holerite.convodonto = reader.GetDecimal(reader.GetOrdinal("convodonto"));
                            holerite.totaldescontos = reader.GetDecimal(reader.GetOrdinal("totaldescontos"));
                            holerite.salarioliquido = reader.GetDecimal(reader.GetOrdinal("salarioliquido"));
                            holerite.datapagamento = reader.GetDateTime(reader.GetOrdinal("datapagamento"));

                            folhapagamento.Add(holerite);
                        }
                    }
                }
            }

            return folhapagamento;
        }


        public static DataTable ExecutarConsulta(string consulta)
        {

            string connectionString = ConexaoDB.stringConexao();
            using (NpgsqlConnection conexao = new NpgsqlConnection(connectionString))
            {
                DataTable dataTable = new DataTable();
                conexao.Open();
                NpgsqlCommand comando = new NpgsqlCommand(consulta, conexao);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(comando);
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
        public decimal AdicionalConvMed(Funcionario Usuarios)
        {
            bool ConvMed = Usuarios.conv_med;
            decimal DescontoConvMed = 0m;
            if (ConvMed)
            {
                DescontoConvMed += 80m;
            }
            else
            {
                DescontoConvMed += 0m;
            }

            return DescontoConvMed;
        }

        public decimal AdicionalConvOdon(Funcionario Usuarios)
        {
            bool ConvOdon = Usuarios.conv_odon;
            decimal DescontoConvOdon = 0m;
            if (ConvOdon)
            {
                DescontoConvOdon += 20m;
            }
            else
            {
                DescontoConvOdon += 0m;
            }

            return DescontoConvOdon;
        }

        public void AddHolerite(
            string cpf,
            decimal salariobruto,
            decimal inss,
            decimal irpf,
            decimal convmed,
            decimal convodonto,
            decimal totaldescontos,
            decimal salarioliquido,
            DateTime datapagamento)

        {
            string sql = "INSERT INTO folha_pagto (cpf, salariobruto, inss, irpf, convmed, " +
                         "convodonto, totaldescontos, salarioliquido, datapagamento)" +
                         "VALUES (@cpf, @salariobruto, @inss, @irpf, @convmed, @convodonto, @totaldescontos, @salarioliquido, @datapagamento);";

            using (NpgsqlCommand cmdHolerite = new NpgsqlCommand(sql, GetConnection()))
            {
                cmdHolerite.Parameters.AddWithValue("@cpf", cpf);
                cmdHolerite.Parameters.AddWithValue("@salariobruto", salariobruto);
                cmdHolerite.Parameters.AddWithValue("@inss", inss);
                cmdHolerite.Parameters.AddWithValue("@irpf", irpf);
                cmdHolerite.Parameters.AddWithValue("@convmed", convmed);
                cmdHolerite.Parameters.AddWithValue("@convodonto", convodonto);
                cmdHolerite.Parameters.AddWithValue("@totaldescontos", totaldescontos);
                cmdHolerite.Parameters.AddWithValue("@salarioliquido", salarioliquido);
                cmdHolerite.Parameters.AddWithValue("@datapagamento", datapagamento);

                cmdHolerite.ExecuteNonQuery();
            }
        }

        public decimal CalcularDescontoINSS(Funcionario Usuarios)
        {
            decimal salario = Convert.ToDecimal(Usuarios.salario);

            double DescontoINSS;
            if (Usuarios.salario <= 1320)
            {
                DescontoINSS = Usuarios.salario * 0.075;
            }
            else if (Usuarios.salario <= 2571.29)
            {
                DescontoINSS = Usuarios.salario * 0.09 - 19.8;
            }
            else if (Usuarios.salario <= 3856.9)
            {
                DescontoINSS = Usuarios.salario * 0.12 - 96.94;
            }
            else if (Usuarios.salario <= 7507.49)
            {
                DescontoINSS = Usuarios.salario * 0.14 - 174.08;
            }
            else
            {
                DescontoINSS = 1043.77;
            }
            return Convert.ToDecimal(DescontoINSS);
        }

        public decimal CalcularDescontoIRPF(Funcionario Usuarios)
        {
            decimal salario = Convert.ToDecimal(Usuarios.salario);
            decimal DescontoIRPF = 0m;
            if (salario <= 1903.98m)
            {
                DescontoIRPF = 0m;
            }
            else if (salario <= 2826.65m)
            {
                DescontoIRPF = salario * 0.075m - 142.80m;
            }
            else if (salario <= 3751.05m)
            {
                DescontoIRPF = salario * 0.15m - 354.80m;
            }
            else if (salario <= 4664.68m)
            {
                DescontoIRPF = salario * 0.225m - 636.13m;
            }
            else
            {
                DescontoIRPF = salario * 0.275m - 869.36m;
            }
            return DescontoIRPF;
        }
    }
}

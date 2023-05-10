﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace folhaPagamento
{
    internal class Holerite : connDB
    {

        private NpgsqlConnection conn;

        public Holerite()
        {
            string sconn = connDB.GetConnection();
            conn = new NpgsqlConnection(sconn);
            conn.Open();
        }


        public decimal AdicionalConvMed(Users Usuarios)
        {
            bool ConvMed = Usuarios.conv_med;
            decimal DescontoConvMed = 0m;
            if (ConvMed)
            {
                DescontoConvMed += 80m;
            } else
            {
                DescontoConvMed += 0m;
            }

            return DescontoConvMed;
        }

        public decimal AdicionalConvOdon(Users Usuarios)
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
            decimal SalarioBase,
            decimal DescontoINSS,
            decimal DescontoIRPF,
            //decimal DescontoConvMed,
            //decimal DescontoConvOdon,
            //decimal TotalDescontos,
            decimal ValorTotal)
        {
            string sql = "INSERT INTO folha_pagto (sal_bruto, sal_liq, inss, ir) " +
                         "VALUES (@sal_bruto, @sal_liq, @inss, @ir);";

            using (NpgsqlCommand cmdHolerite = new NpgsqlCommand(sql, conn))
            {
                cmdHolerite.Parameters.AddWithValue("@sal_bruto", SalarioBase);
                cmdHolerite.Parameters.AddWithValue("@sal_liq", ValorTotal);
                cmdHolerite.Parameters.AddWithValue("@inss", DescontoINSS);
                cmdHolerite.Parameters.AddWithValue("@ir", DescontoIRPF);

                cmdHolerite.ExecuteNonQuery();
            }
        }

        public decimal CalcularDescontoINSS(Users Usuarios)
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
    }
}

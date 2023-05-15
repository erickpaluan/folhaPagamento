﻿using folhaPagamento._Classes;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace folhaPagamento._DAO
{
    internal class PontoDAO : connDB
    {
        private NpgsqlConnection conn;
        private List<Registro> registro;

        public PontoDAO()
        {
            string sconn = GetConnection();
            conn = new NpgsqlConnection(sconn);
            conn.Open();
            registro = new List<Registro>();
        }

        public void RegistrarPonto(string cpf_ponto, DateTime data, DateTime hora)
        {
            string sql = "INSERT INTO ponto (cpf_ponto, data, hora) " +
                         "VALUES (@cpf, @data, @hora);";
            try
            {
                using (NpgsqlCommand cmdPonto = new NpgsqlCommand(sql, conn))
                {
                    cmdPonto.Parameters.AddWithValue("@cpf", cpf_ponto);
                    cmdPonto.Parameters.AddWithValue("@data", data);
                    cmdPonto.Parameters.AddWithValue("@hora", hora);

                    cmdPonto.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na marcação ", ex.ToString());
            }
            finally
            {
                MessageBox.Show("Inserido com sucesso!!");
                conn.Close();
            }
        }
    }
}
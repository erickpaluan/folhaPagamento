using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using folhaPagamento._Classes;
using folhaPagamento._DAO;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace folhaPagamento
{
    public partial class HoleriteWF : Form
    {
        private User usuarios;
        public Funcionario Usuarios { get; set; }
        private HoleriteDAO HoleriteDAO { get; set; }

        private Holerite holerite;

        private NpgsqlConnection conn;
        public HoleriteWF(Funcionario usuarios)
        {
            InitializeComponent();
            Usuarios = usuarios;

            try
            {
                HoleriteDAO = new HoleriteDAO();
                //MessageBox.Show("Conectado ao DB!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public void ImprimirHolerite()
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            HoleriteDAO holerite = new HoleriteDAO();
            decimal descontoINSS = holerite.CalcularDescontoINSS(Usuarios);
            decimal descontoIR = holerite.CalcularDescontoIRPF(Usuarios);
            decimal ConvMed = holerite.AdicionalConvMed(Usuarios);
            decimal ConvOdon = holerite.AdicionalConvOdon(Usuarios);
            decimal TotalDescontos = descontoINSS + descontoIR + ConvMed + ConvOdon;
            decimal SalarioTotal = (decimal)Usuarios.salario - TotalDescontos;

            // Cria uma nova instância da classe HoleriteDAO
            Holerite novoHolerite = new Holerite();
            novoHolerite.cpf = Usuarios.cpf;
            novoHolerite.salariobruto = (decimal)Usuarios.salario;
            novoHolerite.inss = descontoINSS;
            novoHolerite.irpf = descontoIR;
            novoHolerite.convmed = ConvMed;
            novoHolerite.convodonto = ConvOdon;
            novoHolerite.totaldescontos = TotalDescontos;
            novoHolerite.salarioliquido = SalarioTotal;
            novoHolerite.datapagamento = DateTime.ParseExact(dtpHolerite.Value.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture);

            try
            {
                holerite.AddHolerite(
                    novoHolerite.cpf,
                    novoHolerite.salariobruto,
                    novoHolerite.inss,
                    novoHolerite.irpf,
                    novoHolerite.convmed,
                    novoHolerite.convodonto,
                    novoHolerite.totaldescontos,
                    novoHolerite.salarioliquido,
                    novoHolerite.datapagamento);

                MessageBox.Show("Holerite Adicionado!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Adicionar" + ex.Message);
            }
        }

        private void fHolerite_Load(object sender, EventArgs e)
        {
            try
            {
                dgvHolerite.DataSource = HoleriteDAO.CarregaHolerite();
                if (Usuarios.adm == false)
                {
                    FiltrarDados(Usuarios.cpf);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FiltrarDados(string filtro)
        {
            string consulta = "SELECT * FROM folha_pagto WHERE cpf LIKE '%" + filtro + "%'";
            dgvHolerite.DataSource = HoleriteDAO.ExecutarConsulta(consulta);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvHolerite_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // verifica se a linha selecionada é válida
            {
                CultureInfo cultura = new CultureInfo("pt-BR");
                DataGridViewRow row = this.dgvHolerite.Rows[e.RowIndex]; // define a linha
                // Dados funcionario
                txtSalario.Text = row.Cells["salariobruto"].Value.ToString();
                txtConvMed.Text = row.Cells["convmed"].Value.ToString();
                txtConvOdon.Text = row.Cells["convodonto"].Value.ToString();
                txtDescINSS.Text = row.Cells["inss"].Value.ToString();
                txtDescIR.Text = row.Cells["irpf"].Value.ToString();
                txtTotal.Text = row.Cells["salarioliquido"].Value.ToString();
                dtpHolerite.Text = ((DateTime)row.Cells["datapagamento"].Value).ToString("dd/MM/yyyy");
                txtCPF.Text = row.Cells["cpf"].Value.ToString();

            }
        }
    }
}

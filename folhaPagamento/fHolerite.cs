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
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;

namespace folhaPagamento
{
    public partial class fHolerite : Form
    {
        private User usuarios;
        public Users Usuarios { get; set; }
        private Holerite HoleriteDAO { get; set; }

        private NpgsqlConnection conn;
        public fHolerite(Users usuarios)
        {
            InitializeComponent();
            Usuarios = usuarios;

            // Configura as colunas do DataGridView
            //dgvHolerite.Columns.Add("SalarioBase", "Salário Base");
            //dgvHolerite.Columns.Add("HorasExtras", "Horas Extras");
            //dgvHolerite.Columns.Add("ValorHoraExtra", "Valor Hora Extra");
            //dgvHolerite.Columns.Add("SalarioBruto", "Salário Bruto");
            //dgvHolerite.Columns.Add("DescontoINSS", "Desconto INSS");
            //dgvHolerite.Columns.Add("DescontoIRPF", "Desconto IRPF");
            //dgvHolerite.Columns.Add("SalarioLiquido", "Salário Líquido");
        }

        public void ImprimirHolerite()
        {
            //txtSalario.Text = HoleriteDAO.SalarioBase.ToString();
            //txtConvMed.Text = HoleriteDAO.HorasExtras.ToString();
            //txtConvOdon.Text = HoleriteDAO.ValorHoraExtra.ToString();
            //txtSalarioBruto.Text = HoleriteDAO.CalcularSalarioBruto.ToString();
            //txtDescINSS.Text = HoleriteDAO.CalcularDescontoINSS.ToString();
            //txtDescIR.Text = HoleriteDAO.CalcularDescontoIRPF.ToString();
            //txtSalarioLiquido.Text = HoleriteDAO.CalcularSalarioLiquido.ToString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Holerite holerite = new Holerite();
            decimal descontoINSS = holerite.CalcularDescontoINSS(Usuarios);
            decimal descontoIR = holerite.CalcularDescontoIRPF(Usuarios);
            decimal ConvMed = holerite.AdicionalConvMed(Usuarios);
            decimal ConvOdon = holerite.AdicionalConvOdon(Usuarios);
            decimal TotalDescontos = descontoINSS + descontoIR + ConvMed + ConvOdon;
            decimal SalarioTotal = (decimal)Usuarios.salario - TotalDescontos;

            // Cria uma nova instância da classe HoleriteDAO
            HoleriteDAO novoHolerite = new HoleriteDAO();
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
                using (NpgsqlConnection conn = new NpgsqlConnection(connDB.GetConnection()))
                {
                    conn.Open();

                    // Criar um objeto NpgsqlDataAdapter para buscar os dados da tabela folha_pagto
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT * FROM folha_pagto", conn);

                    // Criar um objeto DataTable para armazenar os dados da tabela
                    DataTable dt = new DataTable();

                    // Preencher o DataTable com os dados da tabela folha_pagto
                    da.Fill(dt);

                    // Atribuir o DataTable ao DataSource do DataGridView
                    dgvHolerite.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }


            string nome = Usuarios.nome;
            bool isAdm = Usuarios.adm;
            string CPF = Usuarios.cpf;
            int ID_FUNC = Usuarios.id_func;

            Holerite holerite = new Holerite();
            decimal descontoINSS = holerite.CalcularDescontoINSS(Usuarios);
            decimal descontoIR = holerite.CalcularDescontoIRPF(Usuarios);
            decimal ConvMed = holerite.AdicionalConvMed(Usuarios);
            decimal ConvOdon = holerite.AdicionalConvOdon(Usuarios);
            decimal TotalDescontos = descontoINSS + descontoIR + ConvMed + ConvOdon;
            decimal SalarioTotal = (decimal)Usuarios.salario - TotalDescontos;

            decimal salario = Convert.ToDecimal(Usuarios.salario);
            txtSalario.Text = salario.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));
            txtDescINSS.Text = descontoINSS.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));
            txtDescIR.Text = descontoIR.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));
            txtConvMed.Text = ConvMed.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));
            txtConvOdon.Text = ConvOdon.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));
            txtTotal.Text = SalarioTotal.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

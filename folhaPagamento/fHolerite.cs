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
        public fHolerite(Users usuarios)
        {
            InitializeComponent();
            Usuarios = usuarios;


            // Configura as colunas do DataGridView
            dgvHolerite.Columns.Add("SalarioBase", "Salário Base");
            dgvHolerite.Columns.Add("HorasExtras", "Horas Extras");
            dgvHolerite.Columns.Add("ValorHoraExtra", "Valor Hora Extra");
            dgvHolerite.Columns.Add("SalarioBruto", "Salário Bruto");
            dgvHolerite.Columns.Add("DescontoINSS", "Desconto INSS");
            dgvHolerite.Columns.Add("DescontoIRPF", "Desconto IRPF");
            dgvHolerite.Columns.Add("SalarioLiquido", "Salário Líquido");
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
            // Cria uma nova instância da classe Funcionario
            Holerite holerite = new Holerite();

            //double pINSS = double.Parse(txtDescINSS.Text); ;
            //double pIRPF = double.Parse(txtDescINSS.Text);
            //double porcentagemINSS = pINSS / 100.0;
            //double porcentagemIRPF = pIRPF / 100.0;

            // Atribui os valores das propriedades do funcionário
            //holerite.SalarioBase = decimal.Parse(txtSalario.Text);
            //holerite.DescontoConvMed = decimal.Parse(txtConvMed.Text);
            //holerite.DescontoConvOdon = decimal.Parse(txtConvOdon.Text);
            //holerite.DescontoINSS = decimal.Parse(txtDescINSS.Text);
            //holerite.DescontoIRPF = decimal.Parse(txtDescIR.Text);

            // Adiciona uma nova linha ao DataGridView com as informações do holerite
            //dgvHolerite.Rows.Add(holerite.SalarioBase.ToString("C2"),
            //holerite.HorasExtras,
            //holerite.ValorHoraExtra.ToString("C2"));
            //holerite.CalcularSalarioBruto().ToString("C2"));
            //holerite.CalcularDescontoINSS().ToString("C2"),
            //holerite.CalcularDescontoIRPF().ToString("C2"));
            //holerite.CalcularSalarioLiquido().ToString("C2"));




        }

        private void fHolerite_Load(object sender, EventArgs e)
        {
            string nome = Usuarios.nome;
            bool isAdm = Usuarios.adm;
            string CPF = Usuarios.cpf;

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

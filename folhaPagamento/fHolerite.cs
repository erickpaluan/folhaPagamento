using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace folhaPagamento
{
    public partial class fHolerite : Form
    {
        private Holerite HoleriteDAO { get; set; }
        public fHolerite()
        {
            InitializeComponent();

            // Configura as colunas do DataGridView
            dgvHolerite.Columns.Add("SalarioBase", "sdfdvbcb");
            dgvHolerite.Columns.Add("HorasExtras", "Horas Extras");
            dgvHolerite.Columns.Add("ValorHoraExtra", "Valor Hora Extra");
            dgvHolerite.Columns.Add("SalarioBruto", "Salário Bruto");
            dgvHolerite.Columns.Add("DescontoINSS", "Desconto INSS");
            dgvHolerite.Columns.Add("DescontoIRPF", "Desconto IRPF");
            dgvHolerite.Columns.Add("SalarioLiquido", "Salário Líquido");
        }

        public void ImprimirHolerite()
        {
            txtSalario.Text = HoleriteDAO.SalarioBase.ToString();
            txtHoraExtra.Text = HoleriteDAO.HorasExtras.ToString();
            txtValorHoraExtra.Text = HoleriteDAO.ValorHoraExtra.ToString();
            //txtSalarioBruto.Text = HoleriteDAO.CalcularSalarioBruto.ToString();
            //txtDescINSS.Text = HoleriteDAO.CalcularDescontoINSS.ToString();
            //txtDescIR.Text = HoleriteDAO.CalcularDescontoIRPF.ToString();
            //txtSalarioLiquido.Text = HoleriteDAO.CalcularSalarioLiquido.ToString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância da classe Funcionario
            Holerite holerite = new Holerite();

            // Atribui os valores das propriedades do funcionário
            holerite.SalarioBase = decimal.Parse(txtSalario.Text);
            holerite.HorasExtras = decimal.Parse(txtHoraExtra.Text);
            holerite.ValorHoraExtra = decimal.Parse(txtValorHoraExtra.Text);
            holerite.DescontoINSS = decimal.Parse(txtDescINSS.Text);
            holerite.DescontoIRPF = decimal.Parse(txtDescIR.Text);

            // Adiciona uma nova linha ao DataGridView com as informações do holerite
            dgvHolerite.Rows.Add(holerite.SalarioBase.ToString("C2"),
                                  holerite.HorasExtras,
                                  holerite.ValorHoraExtra.ToString("C2"),
                                  holerite.CalcularSalarioBruto().ToString("C2"),
                                  holerite.CalcularDescontoINSS().ToString("C2"),
                                  holerite.CalcularDescontoIRPF().ToString("C2"),
                                  holerite.CalcularSalarioLiquido().ToString("C2"));

            label11.Text = holerite.SalarioBase.ToString();
            


        }
    }
}

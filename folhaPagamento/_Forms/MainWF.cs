using folhaPagamento._Classes;
using folhaPagamento._DAO;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System.Globalization;
using System.Windows.Forms;
using System;


namespace folhaPagamento
{
    public partial class MainWF : Form
    {
        private User usuarios;
        public Funcionario Usuarios { get; set; }

        private Label labelSegunda;
        private Label labelTerca;
        private Label labelQuarta;
        private Label labelQuinta;
        private Label labelSexta;
        private Label labelSabado;
        private Label labelDomingo;

        public MainWF(Funcionario usuarios)
        {
            InitializeComponent();
            Usuarios = usuarios;

            DateTime dataAtual = DateTime.Today;
            CultureInfo cultura = CultureInfo.CurrentCulture;

            int diasPassados = (int)dataAtual.DayOfWeek;
            for (int i = 0; i < 7; i++)
            {
                DateTime data = dataAtual.AddDays(i - diasPassados);
                string nomeDiaSemana = cultura.DateTimeFormat.GetDayName(data.DayOfWeek);
                string diaMes = data.ToString("dd/MM");
                string resultado = $"{nomeDiaSemana} ({diaMes})";

                // Exibir o resultado em cada label correspondente
                SetTextForLabelDayOfWeek(data.DayOfWeek, resultado);

                // Definir o estilo de borda para o painel da data de hoje
                if (data.Date == dataAtual.Date)
                {
                    Panel panel = GetPanelForDayOfWeek(data.DayOfWeek);
                    //panel.BorderStyle = BorderStyle.FixedSingle;
                    panel.BackColor = Color.FromArgb(218, 218, 218);
                }
            }

        }

        private Panel GetPanelForDayOfWeek(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                    return panelSegunda;
                case DayOfWeek.Tuesday:
                    return panelTerca;
                case DayOfWeek.Wednesday:
                    return panelQuarta;
                case DayOfWeek.Thursday:
                    return panelQuinta;
                case DayOfWeek.Friday:
                    return panelSexta;
                case DayOfWeek.Saturday:
                    return panelSabado;
                case DayOfWeek.Sunday:
                    return panelDomingo;
                default:
                    throw new ArgumentOutOfRangeException(nameof(dayOfWeek));
            }
        }

        private void SetTextForLabelDayOfWeek(DayOfWeek dayOfWeek, string text)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                    lblSegunda.Text = text;
                    break;
                case DayOfWeek.Tuesday:
                    lblTerca.Text = text;
                    break;
                case DayOfWeek.Wednesday:
                    lblQuarta.Text = text;
                    break;
                case DayOfWeek.Thursday:
                    lblQuinta.Text = text;
                    break;
                case DayOfWeek.Friday:
                    lblSexta.Text = text;
                    break;
                case DayOfWeek.Saturday:
                    lblSabado.Text = text;
                    break;
                case DayOfWeek.Sunday:
                    lblDomingo.Text = text;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(dayOfWeek));
            }
        }



        private void btnConfig_Click(object sender, EventArgs e)
        {
            contextMenuStrip2.Show(btnConfig, new Point(0, btnConfig.Height));
        }

        private void main_Load(object sender, EventArgs e)
        {
            if (!Usuarios.adm)
            {
                btnFuncionarios.Visible = false;
                btnEmpresa.Visible = false;
                btnMinhasConfig.Visible = false;
            }

            lblSaudacao.Text = Saudacao(Usuarios.nome);
        }

        string Saudacao(string nome)
        {
            DateTimeOffset now = DateTimeOffset.Now;
            if (now.Hour >= 5 && now.Hour < 12)
            {
                return $"Bom dia, {nome}.";
            }
            else if (now.Hour >= 12 && now.Hour < 18)
            {
                return $"Boa tarde, {nome}.";
            }
            else
            {
                return $"Boa noite, {nome}.";
            }
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            EmpresaWF cadEmpresa = new EmpresaWF();
            cadEmpresa.ShowDialog();
        }

        private void btnHolerite_Click_1(object sender, EventArgs e)
        {
            HoleriteWF fHolerite = new HoleriteWF(Usuarios);
            fHolerite.ShowDialog();
        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigWF config = new ConfigWF();
            config.ShowDialog();
        }

        private void fazerLogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você tem certeza que deseja" +
            "sair do sistema?", "Sair",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            FuncionarioWF form = new FuncionarioWF();
            form.ShowDialog();
        }

        private void btnEmpresa_Click_1(object sender, EventArgs e)
        {
            EmpresaWF cadEmpresa = new EmpresaWF();
            cadEmpresa.ShowDialog();
        }

        private void llblRegistros_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PontoWF form = new PontoWF(Usuarios);
            form.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnFazerMarcacao_Click(object sender, EventArgs e)
        {
            Registro novoRegistro = new Registro()
            {
                cpf_ponto = Usuarios.cpf,
                data = DateTime.Now.Date,
                hora = TimeSpan.FromSeconds(Math.Floor(DateTime.Now.TimeOfDay.TotalSeconds))
            };

            string mensagemConfirmacao = $"Efetuar marcação para:\nNome: {Usuarios.nome}\nCPF: {novoRegistro.cpf_ponto}\nData: {novoRegistro.data.ToString("dd/MM/yyyy")}\nHora: {novoRegistro.hora.ToString(@"hh\:mm\:ss")}";
            DialogResult resultado = MessageBox.Show(mensagemConfirmacao, "Revise as informações", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                PontoDAO pontoDAO = new PontoDAO();
                pontoDAO.RegistrarPonto(novoRegistro.cpf_ponto, novoRegistro.data, novoRegistro.hora);
            }

        }

        private void btnMinhasConfig_Click(object sender, EventArgs e)
        {
            ConfigWF configWF = new ConfigWF();
            configWF.ShowDialog();
        }

        private void linkFazerLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Você tem certeza que deseja sair da sua conta?", "Deslogar",
MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                LoginWF login = new LoginWF();
                login.Show();
            }
        }
    }
}
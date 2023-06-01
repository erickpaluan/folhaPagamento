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
        Principal principal = new Principal();



        public MainWF(Funcionario usuarios)
        {
            InitializeComponent();
            Usuarios = usuarios;

            principal.carregaDiasSemana();
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
            lblSaudacao.Text = principal.Saudacao(Usuarios.nome);
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


        private void btnFazerMarcacao_Click(object sender, EventArgs e)
        {
            principal.FazerMarcacao();
        }

        private void btnMinhasConfig_Click(object sender, EventArgs e)
        {
            ConfigWF configWF = new ConfigWF();
            configWF.ShowDialog();
        }

        private void linkFazerLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Você tem certeza que deseja sair da sua conta?", "Deslogar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                LoginWF login = new LoginWF();
                login.Show();
            }
        }
    }
}
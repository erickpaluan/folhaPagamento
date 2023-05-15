using folhaPagamento._Classes;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System.Windows.Forms;


namespace folhaPagamento
{
    public partial class MainWF : Form
    {
        private User usuarios;
        public Funcionario Usuarios { get; set; }

        public MainWF(Funcionario usuarios)
        {

            InitializeComponent();
            Usuarios = usuarios;


        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            contextMenuStrip2.Show(btnConfig, new Point(0, btnConfig.Height));
        }

        private void main_Load(object sender, EventArgs e)
        {

            if (Usuarios.adm == false)
            {
                btnFuncionarios.Visible = false;
                btnEmpresa.Visible = false;

            }

            DateTime now = DateTime.Now;


            if (now.Hour >= 5 && now.Hour < 12)
            {
                lblSaudacao.Text = $"Bom dia,\n{Usuarios.nome}";
            }
            else if (now.Hour >= 12 && now.Hour < 18)
            {
                lblSaudacao.Text = $"Boa tarde,\n{Usuarios.nome}";
            }
            else
            {
                lblSaudacao.Text = $"Boa noite,\n{Usuarios.nome}";
            }

        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            EmpresaWF cadEmpresa = new EmpresaWF();
            cadEmpresa.ShowDialog();
        }

        private void btnMarcarPonto_Click_1(object sender, EventArgs e)
        {
            PontoWF form = new PontoWF(Usuarios);
            form.ShowDialog();
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
            DialogResult result = MessageBox.Show("Você tem certeza que deseja sair da sua conta?", "Deslogar",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                LoginWF login = new LoginWF();
                login.Show();
            }
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
    }
}
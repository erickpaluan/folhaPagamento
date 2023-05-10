using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System.Windows.Forms;


namespace folhaPagamento
{
    public partial class main : Form
    {
        private User usuarios;
        public Users Usuarios { get; set;}

        public main(Users usuarios)
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
                lblSaudacao.Text = $"Bom dia,\n {Usuarios.nome}";
            }
            else if (now.Hour >= 12 && now.Hour < 18)
            {
                lblSaudacao.Text = $"Boa tarde,\n {Usuarios.nome}";
            }
            else
            {
                lblSaudacao.Text = $"Boa noite,\n{Usuarios.nome}";
            }

        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            cadEmpresa cadEmpresa = new cadEmpresa();
            cadEmpresa.ShowDialog();
        }

        private void btnMarcarPonto_Click_1(object sender, EventArgs e)
        {
            ponto form = new ponto(Usuarios);
            form.ShowDialog();
        }

        private void btnHolerite_Click_1(object sender, EventArgs e)
        {
            fHolerite fHolerite = new fHolerite(Usuarios);
            fHolerite.ShowDialog();
        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configuracao config = new configuracao();
            config.ShowDialog();
        }

        private void fazerLogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você tem certeza que deseja sair da sua conta?", "Deslogar",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                login login = new login();
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
            cadUsuario form = new cadUsuario();
            form.ShowDialog();
        }

        private void btnEmpresa_Click_1(object sender, EventArgs e)
        {
            cadEmpresa cadEmpresa = new cadEmpresa();
            cadEmpresa.ShowDialog();
        }
    }
}
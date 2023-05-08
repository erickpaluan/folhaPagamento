using Npgsql;
using System.Windows.Forms;


namespace folhaPagamento
{
    public partial class main : Form
    {
        private UserSession session;

        public UserSession Session { get; set; }

        public main(UserSession session)
        {

            InitializeComponent();
            Session = session;

        }

        private void btnFuncion�rios_Click(object sender, EventArgs e)
        {
            cadUsuario form = new cadUsuario();
            form.ShowDialog();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {

            string nome = Session.Username;
            bool isAdm = Session.IsAdmin;

            if (isAdm == false)
            {
                btnFuncion�rios.Visible = false;
                btnEmpresa.Visible = false;

            }

            DateTime now = DateTime.Now;


            if (now.Hour >= 5 && now.Hour < 12)
            {
                lblSaudacao.Text = "Bom dia,\n" + nome;
            }
            else if (now.Hour >= 12 && now.Hour < 18)
            {
                lblSaudacao.Text = "Boa tarde,\n" + "<b>" + nome + "</b>";
            }
            else
            {
                lblSaudacao.Text = $"Boa noite,\n{nome}";
            }

        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            cadEmpresa cadEmpresa = new cadEmpresa();
            cadEmpresa.ShowDialog();
        }

        private void btnSairdoSistema_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voc� tem certeza que deseja" +
            "sair do sistema?", "Sair",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voc� tem certeza que deseja" +
            "sair da sua conta?", "Deslogar",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                login login = new login();
                login.Show();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            cadEmpresa cadEmpresa = new cadEmpresa();
            cadEmpresa.ShowDialog();
        }

        private void btnMarcarPonto_Click_1(object sender, EventArgs e)
        {
            ponto form = new ponto(Session);
            form.ShowDialog();
        }

        private void btnHolerite_Click_1(object sender, EventArgs e)
        {
            fHolerite fHolerite = new fHolerite(Session);
            fHolerite.ShowDialog();
        }
    }
}
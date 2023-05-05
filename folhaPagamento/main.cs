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

        private void btnMarcarPonto_Click(object sender, EventArgs e)
        {
            ponto form = new ponto(Session);
            form.ShowDialog();
        }

        private void btnFuncionários_Click(object sender, EventArgs e)
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
                btnFuncionários.Visible = false;
                btnEmpresa.Visible = false;

            }

            DateTime now = DateTime.Now;


            if (now.Hour >= 5 && now.Hour < 12)
            {
                lblSaudacao.Text = "Bom dia, " + nome;
            }
            else if (now.Hour >= 12 && now.Hour < 18)
            {
                lblSaudacao.Text = "Boa tarde, " + nome;
            }
            else
            {
                lblSaudacao.Text = "Boa noite, " + nome;
            }

        }

        private void btnHolerite_Click(object sender, EventArgs e)
        {
            fHolerite fHolerite = new fHolerite(Session);
            fHolerite.ShowDialog();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            cadEmpresa cadEmpresa = new cadEmpresa();
            cadEmpresa.ShowDialog();
        }

        private void btnSairdoSistema_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            login login = new login();
            login.Show();
        }
    }
}
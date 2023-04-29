using Npgsql;

namespace folhaPagamento
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void novoFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ponto form = new ponto();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cadUsuario form = new cadUsuario();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {


        }

        private void main_Load(object sender, EventArgs e)
        {
            //login form = new login();
            //form.ShowDialog();

            DateTime now = DateTime.Now;

            if (now.Hour >= 5 && now.Hour < 12)
            {
                lblSaudacao.Text = "Bom dia";
            }
            else if (now.Hour >= 12 && now.Hour < 18)
            {
                lblSaudacao.Text = "Boa tarde";
            }
            else
            {
                lblSaudacao.Text = "Boa noite";
            }

        }
    }
}
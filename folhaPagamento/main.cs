using Npgsql;
using System.Windows.Forms;

namespace folhaPagamento
{
    public partial class main : Form
    {
        public UserSession Session { get; set; }

        public main(UserSession session)
        {

            InitializeComponent();
            Session = session;

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

            string nome = Session.Username;
            bool isAdm = Session.IsAdmin;

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

        private void button2_Click(object sender, EventArgs e)
        {
            fHolerite fHolerite = new fHolerite();
            fHolerite.ShowDialog();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                contextMenuStrip1.Show(pictureBox1, new Point(e.X, e.Y));
            }
        }
    }
}
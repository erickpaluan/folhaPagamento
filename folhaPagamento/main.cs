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
    }
}
namespace folhaPagamento
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void brnCliqueAqui_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vocë clicou no botão", "Botão clicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void novoFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadUsuario form = new cadUsuario();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ponto form = new ponto();
            form.ShowDialog();
        }
    }
}
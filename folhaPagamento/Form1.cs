namespace folhaPagamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void brnCliqueAqui_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voc� Clicou no bot�o", "Bot�o clicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
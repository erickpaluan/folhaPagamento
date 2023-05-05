using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace folhaPagamento
{
    public partial class ponto : Form
    {
        public ponto()
        {
            InitializeComponent();

        }

        private void ponto_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblData.Text = DateTime.Now.ToShortDateString();
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            // Recupera o valor do TextBox com o CPF
            string cpf = txtCPF.Text.Trim();

            // Cria a conexão com o banco de dados
            using (NpgsqlConnection connection = new NpgsqlConnection(connDB.GetConnection()))
            {
                // Abre a conexão
                connection.Open();

                // Define a consulta SQL
                string query = "SELECT nome FROM funcionario WHERE cpf = @cpf";

                // Cria um objeto NpgsqlCommand com a consulta e os parâmetros
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@cpf", cpf);
            }
        }

        public void btnSalvarPonto_Click(object sender, EventArgs e)
        {
            Registro novoRegistro = new Registro();
            novoRegistro.cpf_ponto = txtCPF.Text;
            novoRegistro.data = DateTime.Now;
            novoRegistro.hora = DateTime.Now;

            //PontoDAO.RegistrarPonto(novoRegistro.cpf_ponto, novoRegistro.data, novoRegistro.hora);

            MessageBox.Show("Marcação de ponto registrada com sucesso!");
        }
    }
}

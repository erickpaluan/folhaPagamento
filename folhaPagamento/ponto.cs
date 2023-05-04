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

                // Executa a consulta e recupera o nome do funcionário correspondente
                string nome = (string)command.ExecuteScalar();

                // Define o nome do funcionário no TextBox correspondente
                txtNome.Text = nome;
            }
        }
    }
}

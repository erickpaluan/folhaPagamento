using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace folhaPagamento
{
    public partial class login : Form
    {

        private Funcionarios connDAO { get; set; }
        public login()
        {
            InitializeComponent();
            connDAO = new Funcionarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            string login = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();

            using (NpgsqlConnection connection = new NpgsqlConnection(connDB.GetConnection()))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM funcionario WHERE login = @login AND senha = @senha";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@senha", senha);
                long count = (long)command.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Bem-vindo ao Sistema");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha Inválido.");
                }
            }
        }
    }
}

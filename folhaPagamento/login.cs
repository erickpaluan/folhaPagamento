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
using System.Windows.Input;

namespace folhaPagamento
{
    public partial class login : Form
    {

        private Funcionarios connDAO { get; set; }
        public UserSession Session { get; set; }
        private NpgsqlConnection conn;
        public login()
        {
            InitializeComponent();
            connDAO = new Funcionarios();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connDB.GetConnection()))
            {
                try
                {
                    conn.Open();

                    string login = txtUsuario.Text.Trim();
                    string senha = txtSenha.Text.Trim();

                    string query = "SELECT nome, adm FROM funcionario WHERE login = @login AND senha = @senha";
                    NpgsqlCommand command = new NpgsqlCommand(query, conn);
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@senha", senha);

                    NpgsqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows && reader.Read())
                    {
                        //Session.Username = reader.GetString(1);
                        //Session.IsAdmin = reader.GetBoolean("adm");
                        reader.Close();
                        MessageBox.Show("Bem-vindo ao Sistema");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou Senha Inválido.");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você tem certeza que deseja" +
                "sair do sistema?", "Sair",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

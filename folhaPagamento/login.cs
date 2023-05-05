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
using static System.Collections.Specialized.BitVector32;

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
            Session = new UserSession();

            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FazerLogin();
        }

        private void FazerLogin()
        {
            string login = txtUsuario.Text;
            string senha = txtSenha.Text;

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connDB.GetConnection()))
                {
                    conn.Open();

                    // Consulta para verificar se o login e a senha são válidos
                    NpgsqlCommand comando = new NpgsqlCommand("SELECT nome, adm FROM funcionario WHERE login = @login AND senha = @senha", conn);
                    comando.Parameters.AddWithValue("@Login", login);
                    comando.Parameters.AddWithValue("@Senha", senha);
                    UserSession session = new UserSession();

                    NpgsqlDataReader leitor = comando.ExecuteReader();

                    // Se houver uma linha na tabela com o login e a senha fornecidos
                    if (leitor.HasRows)
                    {
                        // Armazena o tipo de usuário e o nome do usuário em variáveis
                        leitor.Read();
                        string nomeUsuario = leitor.GetString("nome");
                        bool tipoUsuario = leitor.GetBoolean("adm");
                        if (tipoUsuario == true)
                        {
                            // Redireciona o usuário para a página de administração
                            session.Username = nomeUsuario;
                            session.IsAdmin = true;
                            main main = new main(session);
                            main.Show();
                        }
                        else
                        {
                            // Redireciona o usuário para a página principal do aplicativo
                            Session.Username = nomeUsuario;
                            Session.IsAdmin = false;
                            main_user main_user = new main_user();
                            main_user.Show();
                        }
                    }
                    else
                    {
                        // Exibe uma mensagem de erro se as credenciais forem inválidas
                        MessageBox.Show("Login ou senha incorretos!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
              //  conn.Close();
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

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FazerLogin();
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FazerLogin();
            }
        }
    }
}

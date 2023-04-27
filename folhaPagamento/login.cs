using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace folhaPagamento
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (usuario == "admin" & senha == "admin")
            {
                MessageBox.Show("Bem-vindo ao sistema!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Nome de usuário ou senha incorretos. Tente novamente.");
                // Limpar os campos de login
                txtUsuario.Text = "";
                txtSenha.Text = "";
            }
        }
    }
}

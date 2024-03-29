﻿using Npgsql;
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
using folhaPagamento._DAO;
using folhaPagamento._Classes;
using folhaPagamento.Properties;

namespace folhaPagamento
{
    public partial class LoginWF : Form
    {

        private FuncionarioDAO connDAO { get; set; }
        public Funcionario funcionario { get; set; }

        private NpgsqlConnection conn;

        private bool isPassword;
        private bool isPasswordVisible;
        public LoginWF()
        {
            InitializeComponent();
            connDAO = new FuncionarioDAO();
            funcionario = new Funcionario();
            isPassword = false;
            isPasswordVisible = false;
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
                using (NpgsqlConnection conn = new NpgsqlConnection(ConexaoDB.stringConexao()))
                {
                    conn.Open();

                    if (ValidarCredenciais(conn, login, senha, out Funcionario funcionario))
                    {
                        if (funcionario.ativo)
                        {
                            AbrirJanelaPrincipal(funcionario);
                        }
                        else
                        {
                            MostrarMensagemUsuarioNaoAtivo();
                        }
                    }
                    else
                    {
                        MostrarMensagemCredenciaisIncorretas();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MostrarMensagemErro($"Erro ao fazer login: {ex.Message}");
            }
        }

        private bool ValidarCredenciais(NpgsqlConnection conn, string login, string senha, out Funcionario funcionario)
        {
            NpgsqlCommand comando = new NpgsqlCommand(FuncionarioSQL.FazerLoginFuncionario, conn);
            comando.Parameters.AddWithValue("@Login", login);
            comando.Parameters.AddWithValue("@Senha", senha);

            using (NpgsqlDataReader leitor = comando.ExecuteReader())
            {
                if (leitor.Read())
                {
                    funcionario = new Funcionario
                    {
                        id_func = leitor.GetInt32(leitor.GetOrdinal("id_func")),
                        nome = leitor.GetString(leitor.GetOrdinal("nome")),
                        adm = leitor.GetBoolean(leitor.GetOrdinal("adm")),
                        cpf = leitor.GetString(leitor.GetOrdinal("cpf")),
                        salario = leitor.GetFloat(leitor.GetOrdinal("salario")),
                        ativo = leitor.GetBoolean(leitor.GetOrdinal("ativo")),
                        conv_med = leitor.GetBoolean(leitor.GetOrdinal("conv_med")),
                        conv_odon = leitor.GetBoolean(leitor.GetOrdinal("conv_odon")),
                    };

                    return true;
                }
                else
                {
                    funcionario = null;
                    return false;
                }
            }
        }

        private void AbrirJanelaPrincipal(Funcionario funcionario)
        {
            MainWF main = new MainWF(funcionario);
            main.Show();
            this.Hide();
        }

        private void MostrarMensagemCredenciaisIncorretas()
        {
            MessageBox.Show("Login ou senha incorretos!", "Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MostrarMensagemUsuarioNaoAtivo()
        {
            MessageBox.Show("Usuário não ativo! Contate o administrador.", "Usuário não ativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MostrarMensagemErro(string mensagem)
        {
            MessageBox.Show($"Erro: {mensagem}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FazerLogin();
            }
            if (e.KeyCode == Keys.Escape)
            {
                SairDoSistema();
            }
        }
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FazerLogin();
            }
            if (e.KeyCode == Keys.Escape)
            {
                SairDoSistema();
            }
        }
        private void SairDoSistema()
        {
            DialogResult result = MessageBox.Show("Você tem certeza que deseja" + "sair do sistema?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public bool IsPassword
        {
            get { return isPassword; }
            set
            {
                isPassword = value;
                Refresh();
            }
        }

        private void LoginWF_Load(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
            DateTime now = DateTime.Now;


            if (now.Hour >= 5 && now.Hour < 12)
            {
                lblSaudacao.Text = $"Bom dia!";
            }
            else if (now.Hour >= 12 && now.Hour < 18)
            {
                lblSaudacao.Text = $"Boa tarde!";
            }
            else
            {
                lblSaudacao.Text = $"Boa noite!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SairDoSistema();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            txtSenha.UseSystemPasswordChar = !isPasswordVisible;
        }
    }
}

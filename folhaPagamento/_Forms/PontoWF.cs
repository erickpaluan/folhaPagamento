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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.ApplicationServices;
using folhaPagamento._DAO;
using folhaPagamento._Classes;

namespace folhaPagamento
{
    public partial class PontoWF : Form
    {
        private User usuarios;
        public Funcionario Usuarios { get; set; }

        public PontoWF(Funcionario usuarios)
        {
            InitializeComponent();
            Usuarios = usuarios;
        }

        private void ponto_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            bool isAdm = Usuarios.adm;
            txtCPF.Focus();

            if (!isAdm)
            {
                string CPF = Usuarios.cpf;

                txtCPF.Text = CPF;
                txtCPF.ReadOnly = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //lblHora.Text = DateTime.Now.ToString("HH:mm");
            lblHora.Text = DateTime.Now.ToString();
            //lblData.Text = DateTime.Now.ToShortDateString();
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            // Recupera o valor do TextBox com o CPF
            string cpf = txtCPF.Text.Trim();

            // Cria a conexão com o banco de dados
            using (NpgsqlConnection connection = new NpgsqlConnection(ConexaoDB.stringConexao()))
            {
                // Abre a conexão
                connection.Open();

                // Define a consulta SQL
                string query = RegistroSQL.carregaRegistro;

                // Cria um objeto NpgsqlCommand com a consulta e os parâmetros
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@cpf", cpf);

                // Executa a consulta e recupera o nome do funcionário correspondente
                string nome = (string)command.ExecuteScalar();

                // Define o nome do funcionário no TextBox correspondente
                txtNome.Text = nome;
            }
        }

        private void btnSalvarPonto_Click(object sender, EventArgs e)
        {
            string cpf = txtCPF.Text.Trim();
            if (string.IsNullOrEmpty(cpf))
            {
                MessageBox.Show("Informe um CPF para registrar o ponto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Registro novoRegistro = new Registro()
            {
                cpf_ponto = cpf,
                data = DateTime.Parse(lblData.Text),
                hora = DateTime.Parse(lblHora.Text)
            };

            string mensagemConfirmacao = $"Deseja registrar o ponto para o CPF: {novoRegistro.cpf_ponto}?\nData: {novoRegistro.data}\nHora: {novoRegistro.hora}";
            DialogResult resultado = MessageBox.Show(mensagemConfirmacao, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                PontoDAO pontoDAO = new PontoDAO();
                pontoDAO.RegistrarPonto(novoRegistro.cpf_ponto, novoRegistro.data, novoRegistro.hora);
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCPF_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                System.Windows.Forms.ToolTip tooltip = new System.Windows.Forms.ToolTip();
                tooltip.SetToolTip(txtCPF, "Digite apenas números");
                tooltip.Show("Digite apenas números", txtCPF, 0, txtCPF.Height, 2000);
            }
        }

        private void btnEU_Click(object sender, EventArgs e)
        {
            string CPF = Usuarios.cpf;

            txtCPF.Text = CPF;
            txtCPF.ReadOnly = true;
        }
    }
}

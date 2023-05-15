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

            if (isAdm == false)
            {
                string CPF = Usuarios.cpf;

                txtCPF.Text = CPF;
                txtCPF.ReadOnly = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm");
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

        private void btnSalvarPonto_Click(object sender, EventArgs e)
        {

            if (txtCPF.Text != "")
            {
                Registro novoRegistro = new Registro();
                novoRegistro.cpf_ponto = txtCPF.Text;
                novoRegistro.data = DateTime.Parse(lblData.Text);
                novoRegistro.hora = DateTime.Parse(lblHora.Text);

                PontoDAO pontoDAO = new PontoDAO();
                pontoDAO.RegistrarPonto(
                    novoRegistro.cpf_ponto,
                    novoRegistro.data,
                    novoRegistro.hora);
            }
            else
            {
                MessageBox.Show("Informe um CPF para ragistrar o ponto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

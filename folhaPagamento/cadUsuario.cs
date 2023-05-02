using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using folhaPagamento.Properties;
using Npgsql;
using static System.Net.Mime.MediaTypeNames;

namespace folhaPagamento
{
    public partial class cadUsuario : Form
    {
        private Funcionarios connDAO { get; set; }
        public cadUsuario()
        {
            InitializeComponent();


            try
            {
                connDAO = new Funcionarios();
                MessageBox.Show("Conectado ao DB!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

        private void cadUsuario_Load(object sender, EventArgs e)
        {
            dgUsuarios.DataSource = connDAO.GetAllFuncionarios();
        }

        private void dgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e) //Joga dados textbox
        {
            if (e.RowIndex >= 0) // verifica se a linha selecionada é válida
            {
                DataGridViewRow row = this.dgUsuarios.Rows[e.RowIndex];
                int id_func = Convert.ToInt32(row.Cells["id_func"].Value);
                label10.Text = id_func.ToString();
                txtNome.Text = row.Cells["nome"].Value.ToString();
                txtCPF.Text = row.Cells["cpf"].Value.ToString();
                dtpDataNasc.Text = ((DateTime)row.Cells["dt_nasc"].Value).ToString("dd/MM/yyyy");
                //cbTipo.
                txtDDD.Text = row.Cells["DDD"].Value.ToString();
                txtTelefone.Text = row.Cells["num_tel"].Value.ToString();
                txtLogr.Text = row.Cells["Logradouro"].Value.ToString();
                txtNum.Text = row.Cells["num_res"].Value.ToString();
                txtCEP.Text = row.Cells["CEP"].Value.ToString();
                txtCidade.Text = row.Cells["Cidade"].Value.ToString();
                //cdEstado.
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e) //Excluir Funcionário
        {
            if (dgUsuarios.SelectedRows.Count > 0) // verifica se uma linha foi selecionada
            {
                DataGridViewRow row = dgUsuarios.SelectedRows[0];
                int id_func = Convert.ToInt32(row.Cells["id_func"].Value);

                DialogResult result = MessageBox.Show("Você tem certeza que deseja" +
                "excluir o funcionário selecionado?", "Confirmação de exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Users funcionarioDelete = new Users();

                    connDAO.DeleteFuncionario(id_func);

                    MessageBox.Show("Funcionário deletado com sucesso!!");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um funcionário para excluir.",
                "Exclusão de funcionário", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        private void button5_Click(object sender, EventArgs e) //Criar Funcionário + Contato + Endereço
        {
            DateTime dataNascimento = dtpDataNasc.Value;
            int idade = DateTime.Now.Year - dataNascimento.Year;

            if (DateTime.Now.DayOfYear < dataNascimento.DayOfYear)
            {
                idade--;
            }
            try
            {
                // Criar um novo objeto Users com os valores dos campos de entrada
                Users novoFuncionario = new Users();
                novoFuncionario.nome = txtNome.Text;
                novoFuncionario.cpf = txtCPF.Text;
                //novoFuncionario.dt_nasc = dtpDataNasc.Value.ToString("yyyy-MM-dd");
                novoFuncionario.dt_nasc = DateTime.ParseExact(dtpDataNasc.Value.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture);
                novoFuncionario.idade = idade;
                // Variaveis Contato
                novoFuncionario.tipo = cbTipo.SelectedItem.ToString();
                novoFuncionario.ddd = txtDDD.Text;
                novoFuncionario.num_tel = txtTelefone.Text;
                // Variaveis Endereço
                novoFuncionario.logradouro = txtLogr.Text;
                int num_res;
                if (Int32.TryParse(txtNum.Text, out num_res))
                {
                    novoFuncionario.num_res = num_res;
                }
                else
                {
                    MessageBox.Show("Impossível converter");
                }
                novoFuncionario.cep = txtCEP.Text;
                novoFuncionario.cidade = txtCidade.Text;
                novoFuncionario.estado = cbEstado.SelectedItem.ToString();


                // Adicionar o novo funcionário
                connDAO.AddFuncionarioContatoEndereco(
                    novoFuncionario.nome,
                    novoFuncionario.cpf,
                    novoFuncionario.dt_nasc,
                    novoFuncionario.idade,
                    novoFuncionario.tipo,
                    novoFuncionario.ddd,
                    novoFuncionario.num_tel,
                    novoFuncionario.logradouro,
                    novoFuncionario.num_res,
                    novoFuncionario.cep,
                    novoFuncionario.cidade,
                    novoFuncionario.estado);

                // Limpar os campos de entrada
                txtNome.Text = "";
                txtCPF.Text = "";
                dtpDataNasc.Value = DateTime.Now;

                // Atualizar o DataGridView
                dgUsuarios.Refresh();
                //AtualizaTabela();

                MessageBox.Show("Cadastrado com sucesso!");
            }
            catch(Exception ex) {
                MessageBox.Show("Erro ao cadastrar" + ex.Message);
            }
                
        }
        private void button3_Click_1(object sender, EventArgs e) //Update Funcionario
        {
            if (dgUsuarios.SelectedRows.Count > 0)
            {
                // Obtém a primeira linha selecionada
                DataGridViewRow row = dgUsuarios.SelectedRows[0];

                // Obtém o valor da coluna "id_func" da linha selecionada
                int id_func = Convert.ToInt32(row.Cells["id_func"].Value);

                DateTime dataNascimento = dtpDataNasc.Value;
                int idade = DateTime.Now.Year - dataNascimento.Year;

                if (DateTime.Now.DayOfYear < dataNascimento.DayOfYear)
                {
                    idade--;

                }

                Users funcionarioEditado = new Users();
                funcionarioEditado.nome = txtNome.Text;
                funcionarioEditado.cpf = txtCPF.Text;
                funcionarioEditado.dt_nasc = DateTime.ParseExact(dtpDataNasc.Value.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture);
                funcionarioEditado.idade = idade;

                connDAO.UpdateFuncionario(funcionarioEditado.nome, funcionarioEditado.cpf, funcionarioEditado.dt_nasc, funcionarioEditado.idade, id_func);

                txtNome.Text = "";
                txtCPF.Text = "";
                dtpDataNasc.Value = DateTime.Now;

                dgUsuarios.Refresh();

                MessageBox.Show("Cadastro editado com sucesso!!");
            }
            else
            {
                MessageBox.Show("Erro!");
            }
        }
        public void AtualizaTabela()
        {

            dgUsuarios.DataSource = connDAO.GetAllFuncionarios();
            dgUsuarios.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AtualizaTabela();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.arrow_back_ios_new_FILL0_wght0_GRAD0_opszNaN;
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.arrow_back_FILL0_wght400_GRAD0_opsz48;
        }
    }
}



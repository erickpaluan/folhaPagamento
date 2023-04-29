﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Net.Mime.MediaTypeNames;

namespace folhaPagamento
{
    public partial class cadUsuario : Form
    {
        private connDAO connDAO { get; set; }
        public cadUsuario()
        {
            InitializeComponent();


            try
            {
                connDAO = new connDAO();
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

        private void dgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // verifica se a linha selecionada é válida
            {
                DataGridViewRow row = this.dgUsuarios.Rows[e.RowIndex];
                int id_func = Convert.ToInt32(row.Cells["id_func"].Value);
                label10.Text = id_func.ToString();
                txtNome.Text = row.Cells["nome"].Value.ToString();
                txtCPF.Text = row.Cells["cpf"].Value.ToString();
                dtpDataNasc.Text = ((DateTime)row.Cells["dt_nasc"].Value).ToString("dd/MM/yyyy");

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgUsuarios.SelectedRows.Count > 0) // verifica se uma linha foi selecionada
            {
                int id_func = Convert.ToInt32(dgUsuarios.SelectedRows[0].Cells["id_func"].Value);

                DialogResult result = MessageBox.Show("Você tem certeza que deseja excluir o funcionário selecionado?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int idFunc = Convert.ToInt32(dgUsuarios.SelectedRows[0].Cells[0].Value);

                    connDAO.DeleteFuncionario(id_func);
                    MessageBox.Show("Funcionário excluído com sucesso!", "Exclusão de funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // atualiza o DataGridView
                    dgUsuarios.Refresh();
                    AtualizaTabela();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um funcionário para excluir.", "Exclusão de funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void button5_Click(object sender, EventArgs e) //Criar Funcionário
        {
            DateTime dataNascimento = dtpDataNasc.Value;
            int idade = DateTime.Now.Year - dataNascimento.Year;

            if (DateTime.Now.DayOfYear < dataNascimento.DayOfYear)
            {
                idade--;

            }

            // Criar um novo objeto Users com os valores dos campos de entrada
            Users novoFuncionario = new Users();
            novoFuncionario.nome = txtNome.Text;
            novoFuncionario.cpf = txtCPF.Text;
            //novoFuncionario.dt_nasc = dtpDataNasc.Value.ToString("yyyy-MM-dd");
            novoFuncionario.dt_nasc = DateTime.ParseExact(dtpDataNasc.Value.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture);
            novoFuncionario.idade = idade;
            ;

            // Adicionar o novo funcionário
            connDAO.AddFuncionario(novoFuncionario.nome, novoFuncionario.cpf, novoFuncionario.dt_nasc, novoFuncionario.idade);

            // Limpar os campos de entrada
            txtNome.Text = "";
            txtCPF.Text = "";
            dtpDataNasc.Value = DateTime.Now;

            // Atualizar o DataGridView
            dgUsuarios.Refresh();
            //AtualizaTabela();


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
            pictureBox2.ImageLocation = @"C:\\_dev\\pim3\\folhaPagamento\\folhaPagamento\\imgs\\icons\\arrow_back_ios_new_FILL0_wght0_GRAD0_opszNaN.png\";
        }

        private void button3_Click(object sender, EventArgs e) //Update Funcionario
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
    }
}

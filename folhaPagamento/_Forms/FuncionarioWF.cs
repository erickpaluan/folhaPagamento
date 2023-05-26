using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using folhaPagamento._Classes;
using folhaPagamento._DAO;
using folhaPagamento.Properties;
using Microsoft.VisualBasic.Logging;
using Npgsql;
using static System.Net.Mime.MediaTypeNames;

namespace folhaPagamento
{
    public partial class FuncionarioWF : Form
    {
        private FuncionarioDAO connDAO { get; set; }
        CultureInfo cultura = new CultureInfo("pt-BR");
        public FuncionarioWF()
        {
            InitializeComponent();


            try
            {
                connDAO = new FuncionarioDAO();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

        private void cadUsuario_Load(object sender, EventArgs e)
        {
            PopularDataGrid();
            btnExcluirFuncionario.Visible = false;
            btnAlterarFuncionario.Visible = false;
            txtMatricula.Visible = false;
            gbinfoFuncionarios.Enabled = false;
        }

        private void PopularDataGrid()
        {
            dgUsuarios.DataSource = connDAO.GetAllFuncionarios();

            dgUsuarios.Columns["id_func"].HeaderText = "ID";
            dgUsuarios.Columns["ativo"].HeaderText = "Ativo";
            dgUsuarios.Columns["nome"].HeaderText = "Nome do Funcionário";
            dgUsuarios.Columns["cpf"].HeaderText = "CPF";
            dgUsuarios.Columns["dt_nasc"].HeaderText = "Data de Nascimento";
            dgUsuarios.Columns["tipo"].HeaderText = "Tipo telefone";
            dgUsuarios.Columns["ddd"].HeaderText = "DDD";
            dgUsuarios.Columns["num_tel"].HeaderText = "Número do Telefone";

            //Esconder Colunas da Tabela
            dgUsuarios.Columns[0].Visible = false;
            dgUsuarios.Columns[1].Visible = true;
            dgUsuarios.Columns[2].Visible = true;
            dgUsuarios.Columns[3].Visible = false;
            dgUsuarios.Columns[4].Visible = false;
            dgUsuarios.Columns[5].Visible = false;
            dgUsuarios.Columns[6].Visible = false;
            dgUsuarios.Columns[7].Visible = false;
            dgUsuarios.Columns[8].Visible = false;
            dgUsuarios.Columns[9].Visible = false;
            dgUsuarios.Columns[10].Visible = false;
            dgUsuarios.Columns[11].Visible = false;
            dgUsuarios.Columns[12].Visible = false;
            dgUsuarios.Columns[13].Visible = false;
            dgUsuarios.Columns[14].Visible = false;
            dgUsuarios.Columns[15].Visible = false;
            dgUsuarios.Columns[16].Visible = false;
            dgUsuarios.Columns[17].Visible = false;
            dgUsuarios.Columns[18].Visible = false;
            dgUsuarios.Columns[19].Visible = false;
            dgUsuarios.Columns[20].Visible = false;
            dgUsuarios.Columns[21].Visible = false;
            dgUsuarios.Columns[22].Visible = false;
            dgUsuarios.Columns[23].Visible = false;
            dgUsuarios.Columns[24].Visible = false;
            dgUsuarios.Columns[25].Visible = false;
            dgUsuarios.Columns[26].Visible = false;
            dgUsuarios.Columns[27].Visible = false;
            dgUsuarios.Columns[28].Visible = false;

            dgUsuarios.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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
                Funcionario novoFuncionario = new Funcionario();
                novoFuncionario.nome = txtNome.Text;
                novoFuncionario.ativo = chbAtivo.Checked;
                novoFuncionario.cpf = txtCPF.Text;
                novoFuncionario.dt_nasc = DateTime.ParseExact(dtpDataNasc.Value.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture);
                novoFuncionario.idade = idade;
                novoFuncionario.sexo = cbSexo.SelectedItem.ToString();
                novoFuncionario.estado_civil = cbEstado_civil.SelectedItem.ToString();
                novoFuncionario.dt_adm = DateTime.ParseExact(dtpDtAdm.Value.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture);
                novoFuncionario.cargo = txtCargo.Text;
                novoFuncionario.matricula = txtMatricula.Text;
                novoFuncionario.conv_med = chbConv_med.Checked;
                novoFuncionario.conv_odon = chbConv_odon.Checked;
                novoFuncionario.login = txtLogin.Text;
                novoFuncionario.senha = txtSenha.Text;
                float salario;
                if (float.TryParse(txtSalario.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR"), out salario))
                {
                    novoFuncionario.salario = salario;
                }
                else
                {
                    MessageBox.Show("Valor de salário inválido.");
                }
                novoFuncionario.adm = chbAdm.Checked;

                // Variaveis Contato
                novoFuncionario.email = txtEmail.Text;
                novoFuncionario.tipo = cbTipo.SelectedItem.ToString();
                novoFuncionario.ddd = txtDDD.Text;
                novoFuncionario.num_tel = txtTelefone.Text;

                // Variaveis Endereço
                novoFuncionario.logradouro = cbLogr.SelectedItem.ToString();
                novoFuncionario.rua = txtRua.Text;
                novoFuncionario.complemento = txtComplemento.Text;
                int num_res;
                if (Int32.TryParse(txtNum.Text, out num_res))
                {
                    novoFuncionario.num_res = num_res;
                }
                else
                {
                    MessageBox.Show("Impossível converter");
                }
                novoFuncionario.bairro = txtBairro.Text;
                novoFuncionario.cep = txtCEP.Text;
                novoFuncionario.cidade = txtCidade.Text;
                novoFuncionario.estado = cbEstado.SelectedItem.ToString();


                // Adicionar o novo funcionário
                connDAO.AddFuncionarioContatoEndereco(
                    novoFuncionario.ativo,
                    novoFuncionario.nome,
                    novoFuncionario.cpf,
                    novoFuncionario.dt_nasc,
                    novoFuncionario.idade,
                    novoFuncionario.sexo,
                    novoFuncionario.estado_civil,
                    novoFuncionario.dt_adm,
                    novoFuncionario.cargo,
                    novoFuncionario.matricula,
                    novoFuncionario.conv_med,
                    novoFuncionario.conv_odon,
                    novoFuncionario.login,
                    novoFuncionario.senha,
                    novoFuncionario.salario,
                    novoFuncionario.adm,
                    novoFuncionario.email,
                    novoFuncionario.tipo,
                    novoFuncionario.ddd,
                    novoFuncionario.num_tel,
                    novoFuncionario.logradouro,
                    novoFuncionario.rua,
                    novoFuncionario.complemento,
                    novoFuncionario.bairro,
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
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar" + ex.Message);
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

        private void lblImagemFuncionario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos de Imagem (*.jpg, *.png)|*.jpg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    pbImagemFuncionario.Image = System.Drawing.Image.FromFile(imagePath);
                    pbImagemFuncionario.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }

        private void dgUsuarios_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // verifica se a linha selecionada é válida
            {
                CultureInfo cultura = new CultureInfo("pt-BR");
                DataGridViewRow row = this.dgUsuarios.Rows[e.RowIndex]; // define a linha
                // Dados funcionario
                int id_func = Convert.ToInt32(row.Cells["id_func"].Value);
                bool ativo = row.Cells["ativo"].Value != DBNull.Value ? Convert.ToBoolean(row.Cells["ativo"].Value) : false;
                chbAtivo.Checked = ativo;
                txtNome.Text = row.Cells["nome"].Value.ToString();
                txtCPF.Text = row.Cells["cpf"].Value.ToString();
                dtpDataNasc.Text = ((DateTime)row.Cells["dt_nasc"].Value).ToString("dd/MM/yyyy");
                cbSexo.SelectedItem = row.Cells["Sexo"].Value.ToString();
                cbEstado_civil.SelectedItem = row.Cells["estado_civil"].Value.ToString();
                dtpDtAdm.Text = ((DateTime)row.Cells["dt_adm"].Value).ToString();
                txtCargo.Text = row.Cells["cargo"].Value.ToString();
                txtMatricula.Text = row.Cells["matricula"].Value.ToString();
                bool conv_med = row.Cells["conv_med"].Value != DBNull.Value ? Convert.ToBoolean(row.Cells["conv_med"].Value) : false;
                chbConv_med.Checked = conv_med;
                bool conv_odon = row.Cells["conv_odon"].Value != DBNull.Value ? Convert.ToBoolean(row.Cells["conv_odon"].Value) : false;
                chbConv_odon.Checked = conv_odon;
                txtLogin.Text = row.Cells["Login"].Value.ToString();
                txtSenha.Text = row.Cells["Senha"].Value.ToString();

                decimal salario = Convert.ToDecimal(row.Cells["salario"].Value);
                txtSalario.Text = salario.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));

                bool adm = row.Cells["adm"].Value != DBNull.Value ? Convert.ToBoolean(row.Cells["adm"].Value) : false;
                chbAdm.Checked = adm;



                // Dados Contato
                cbTipo.SelectedItem = row.Cells["tipo"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtDDD.Text = row.Cells["DDD"].Value.ToString();
                txtTelefone.Text = row.Cells["num_tel"].Value.ToString();

                // Dados endereço
                cbLogr.Text = row.Cells["Logradouro"].Value.ToString();
                txtRua.Text = row.Cells["rua"].Value.ToString();
                txtComplemento.Text = row.Cells["complemento"].Value.ToString();
                cbEstado.Text = row.Cells["estado"].Value.ToString();
                txtNum.Text = row.Cells["num_res"].Value.ToString();
                txtBairro.Text = row.Cells["bairro"].Value.ToString();
                txtCEP.Text = row.Cells["CEP"].Value.ToString();
                txtCidade.Text = row.Cells["Cidade"].Value.ToString();

                btnExcluirFuncionario.Visible = true;
                btnAlterarFuncionario.Visible = true;
            }
        }

        private void btnNovoFuncionario_Click(object sender, EventArgs e)
        {
            gbinfoFuncionarios.Enabled = true;
        }

        private void btnExcluirFuncionario_Click(object sender, EventArgs e)
        {
            if (dgUsuarios.SelectedRows.Count > 0) // verifica se uma linha foi selecionada
            {
                DataGridViewRow row = dgUsuarios.SelectedRows[0];
                int id_func = Convert.ToInt32(row.Cells["id_func"].Value);
                string cpf = txtCPF.Text;

                DialogResult result = MessageBox.Show("Você tem certeza que deseja" +
                "excluir o funcionário selecionado?", "Confirmação de exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Funcionario funcionarioDelete = new Funcionario();

                    connDAO.DeleteFuncionario(id_func, cpf);

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

        private void btnAlterarFuncionario_Click(object sender, EventArgs e)
        {
            try
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
                    // Criar um novo objeto Users com os valores dos campos de entrada
                    Funcionario funcionarioEditado = new Funcionario();
                    funcionarioEditado.id_func = id_func;
                    funcionarioEditado.nome = txtNome.Text;
                    funcionarioEditado.ativo = chbAtivo.Checked;
                    funcionarioEditado.cpf = txtCPF.Text;
                    funcionarioEditado.dt_nasc = DateTime.ParseExact(dtpDataNasc.Value.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    funcionarioEditado.idade = idade;
                    funcionarioEditado.sexo = cbSexo.SelectedItem.ToString();
                    funcionarioEditado.estado_civil = cbEstado_civil.SelectedItem.ToString();
                    funcionarioEditado.dt_adm = DateTime.ParseExact(dtpDtAdm.Value.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    funcionarioEditado.cargo = txtCargo.Text;
                    funcionarioEditado.matricula = txtMatricula.Text;
                    funcionarioEditado.conv_med = chbConv_med.Checked;
                    funcionarioEditado.conv_odon = chbConv_odon.Checked;
                    funcionarioEditado.login = txtLogin.Text;
                    funcionarioEditado.senha = txtSenha.Text;
                    float salario;
                    if (float.TryParse(txtSalario.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR"), out salario))
                    {
                        funcionarioEditado.salario = salario;
                    }
                    else
                    {
                        MessageBox.Show("Impossível converter", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    funcionarioEditado.adm = chbAdm.Checked;

                    // Variaveis Contato
                    funcionarioEditado.email = txtEmail.Text;
                    funcionarioEditado.tipo = cbTipo.SelectedItem.ToString();
                    funcionarioEditado.ddd = txtDDD.Text;
                    funcionarioEditado.num_tel = txtTelefone.Text;

                    // Variaveis Endereço
                    funcionarioEditado.logradouro = cbLogr.SelectedItem.ToString();
                    funcionarioEditado.rua = txtRua.Text;
                    funcionarioEditado.complemento = txtComplemento.Text;
                    int num_res;
                    if (Int32.TryParse(txtNum.Text, out num_res))
                    {
                        funcionarioEditado.num_res = num_res;
                    }
                    else
                    {
                        MessageBox.Show("Impossível converter", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    funcionarioEditado.bairro = txtBairro.Text;
                    funcionarioEditado.cep = txtCEP.Text;
                    funcionarioEditado.cidade = txtCidade.Text;
                    funcionarioEditado.estado = cbEstado.SelectedItem.ToString();

                    connDAO.UpdateFuncionario(
                    funcionarioEditado.id_func,
                    funcionarioEditado.ativo,
                    funcionarioEditado.nome,
                    funcionarioEditado.cpf,
                    funcionarioEditado.dt_nasc,
                    funcionarioEditado.idade,
                    funcionarioEditado.sexo,
                    funcionarioEditado.estado_civil,
                    funcionarioEditado.dt_adm,
                    funcionarioEditado.cargo,
                    funcionarioEditado.matricula,
                    funcionarioEditado.conv_med,
                    funcionarioEditado.conv_odon,
                    funcionarioEditado.login,
                    funcionarioEditado.senha,
                    funcionarioEditado.salario,
                    funcionarioEditado.adm,
                    funcionarioEditado.email,
                    funcionarioEditado.tipo,
                    funcionarioEditado.ddd,
                    funcionarioEditado.num_tel,
                    funcionarioEditado.logradouro,
                    funcionarioEditado.rua,
                    funcionarioEditado.complemento,
                    funcionarioEditado.bairro,
                    funcionarioEditado.num_res,
                    funcionarioEditado.cep,
                    funcionarioEditado.cidade,
                    funcionarioEditado.estado);

                    txtNome.Text = "";
                    txtCPF.Text = "";
                    dtpDataNasc.Value = DateTime.Now;

                    dgUsuarios.Refresh();

                    MessageBox.Show("Cadastro editado com sucesso!!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Erro");
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}



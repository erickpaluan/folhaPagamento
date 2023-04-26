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
                int id_func = Convert.ToInt32(row.Cells["id_func"].Value); // lê o valor da coluna "id_func"
                label10.Text = id_func.ToString();
                txtNome.Text = row.Cells["nome"].Value.ToString();
                txtCPF.Text = row.Cells["cpf"].Value.ToString();
                //dtpDataNasc.Text = ((DateTime)row.Cells["dt_nasc"].Value).ToString("dd/MM/yyyy");// atribui o valor ao Label
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
                    //connDAO.DeleteFuncionario();
                    MessageBox.Show("Funcionário excluído com sucesso!", "Exclusão de funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // atualiza o DataGridView
                    //RefreshDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um funcionário para excluir.", "Exclusão de funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

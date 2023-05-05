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
    public partial class cadEmpresa : Form
    {
        private Empresa connDAO { get; set; }
        public cadEmpresa()
        {
            InitializeComponent();


            try
            {
                connDAO = new Empresa();
                MessageBox.Show("Conectado ao DB!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void dgEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddEmpresa_Click(object sender, EventArgs e)
        {
            try
            {
                Empresa novaEmpresa = new Empresa();
                novaEmpresa.RazaoSocial = txtRazaoSocial.Text;
                novaEmpresa.NomeFantasia = txtNomeFantasia.Text;
                novaEmpresa.CNPJ = txtCNPJ.Text;
                novaEmpresa.InscricaoEstadual = txtIncricaoEstadual.Text;
                novaEmpresa.Endereco = txtEndereco.Text;
                novaEmpresa.Numero = txtNumero.Text;
                novaEmpresa.Complemento = txtComplemento.Text;
                novaEmpresa.Bairro = txtBairro.Text;
                novaEmpresa.Cidade = txtCidade.Text;
                novaEmpresa.Estado = txtEstado.Text;
                novaEmpresa.CEP = txtCEP.Text;
                novaEmpresa.Telefone = txtTel.Text;
                novaEmpresa.Email = txtEmail.Text;

                EmpresaDAO empresaDAO = new EmpresaDAO();
                empresaDAO.AddEmpresa(
                    novaEmpresa.RazaoSocial,
                    novaEmpresa.NomeFantasia,
                    novaEmpresa.CNPJ,
                    novaEmpresa.InscricaoEstadual,
                    novaEmpresa.Endereco,
                    novaEmpresa.Numero,
                    novaEmpresa.Complemento,
                    novaEmpresa.Bairro,
                    novaEmpresa.Cidade,
                    novaEmpresa.Estado,
                    novaEmpresa.CEP,
                    novaEmpresa.Telefone,
                    novaEmpresa.Email);

                MessageBox.Show("Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar" + ex.Message);
            }
        }
    }
}

using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
                //MessageBox.Show("Conectado ao DB!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnUpdateEmpresa_Click(object sender, EventArgs e)
        {
            try
            {
                Empresa editarEmpresa = new Empresa();
                editarEmpresa.RazaoSocial = txtRazaoSocial.Text;
                editarEmpresa.NomeFantasia = txtNomeFantasia.Text;
                editarEmpresa.CNPJ = txtCNPJ.Text;
                editarEmpresa.InscricaoEstadual = txtIncricaoEstadual.Text;
                editarEmpresa.Endereco = txtEndereco.Text;
                editarEmpresa.Numero = txtNumero.Text;
                editarEmpresa.Complemento = txtComplemento.Text;
                editarEmpresa.Bairro = txtBairro.Text;
                editarEmpresa.Cidade = txtCidade.Text;
                editarEmpresa.Estado = txtEstado.Text;
                editarEmpresa.CEP = txtCEP.Text;
                editarEmpresa.Telefone = txtTel.Text;
                editarEmpresa.Email = txtEmail.Text;

                EmpresaDAO empresadao = new EmpresaDAO();
                empresadao.UpdateEmpresa(
                    editarEmpresa.id_empresa,
                    editarEmpresa.RazaoSocial,
                    editarEmpresa.NomeFantasia,
                    editarEmpresa.CNPJ,
                    editarEmpresa.InscricaoEstadual,
                    editarEmpresa.Endereco,
                    editarEmpresa.Numero,
                    editarEmpresa.Complemento,
                    editarEmpresa.Bairro,
                    editarEmpresa.Cidade,
                    editarEmpresa.Estado,
                    editarEmpresa.CEP,
                    editarEmpresa.Telefone,
                    editarEmpresa.Email
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

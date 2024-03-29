﻿using Npgsql;
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
using Microsoft.VisualBasic.ApplicationServices;
using folhaPagamento._DAO;
using folhaPagamento._Classes;

namespace folhaPagamento
{
    public partial class PontoWF : Form
    {
        public Funcionario Usuarios { get; set; }
        private FuncionarioDAO funcionarioDAO { get; set; }

        public PontoWF(Funcionario usuarios)
        {
            InitializeComponent();
            Usuarios = usuarios;
            funcionarioDAO = new FuncionarioDAO();

        }

        private void ponto_Load(object sender, EventArgs e)
        {
            if (!Usuarios.adm)
            {
                string CPF = Usuarios.cpf;

                txtCPF.Text = CPF;
                txtCPF.ReadOnly = true;
            }
        }



        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            string cpf = txtCPF.Text.Trim();
            FiltrarRegistros(txtCPF.Text.Trim());
            PopularDataGrid();

            string acaoDoUsuario = "UsuarioUnico";
            List<dynamic> funcionarios = funcionarioDAO.GetAllFuncionarios(acaoDoUsuario, cpf);

            if (funcionarios.Count > 0)
            {
                dynamic primeiroFuncionario = funcionarios[0];

                if (primeiroFuncionario is Funcionario)
                {
                    txtNome.Text = primeiroFuncionario.nome.ToString();
                }
                else if (primeiroFuncionario is string)
                {
                    txtNome.Text = primeiroFuncionario.ToString();
                }
                else
                {
                    txtNome.Text = string.Empty;
                }
            }
        }


        private void FiltrarRegistros(string filtroRegistro)
        {
            DataTable resultado = RegistroSQL.FiltrarRegistros(filtroRegistro);
            dgRegistro.DataSource = resultado;
        }

        private void PopularDataGrid()
        {
            dgRegistro.Columns["id_ponto"].HeaderText = "ID";
            dgRegistro.Columns["cpf_ponto"].HeaderText = "CPF";
            dgRegistro.Columns["data"].HeaderText = "Data";
            dgRegistro.Columns["hora"].HeaderText = "Hora";

            dgRegistro.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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

        private void btnCarregarInfos_Click(object sender, EventArgs e)
        {
            string CPF = Usuarios.cpf;

            txtCPF.Text = CPF;
            txtCPF.ReadOnly = true;
        }
    }
}

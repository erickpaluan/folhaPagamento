namespace folhaPagamento
{
    partial class cadEmpresa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtRazaoSocial = new TextBox();
            txtNomeFantasia = new TextBox();
            txtCNPJ = new TextBox();
            txtIncricaoEstadual = new TextBox();
            txtEndereco = new TextBox();
            txtNumero = new TextBox();
            txtComplemento = new TextBox();
            txtBairro = new TextBox();
            txtCidade = new TextBox();
            txtEstado = new TextBox();
            txtCEP = new TextBox();
            txtTel = new TextBox();
            txtEmail = new TextBox();
            btnUpdateEmpresa = new Button();
            btnAddEmpresa = new Button();
            btnDeleteEmpresa = new Button();
            dataGridView1 = new DataGridView();
            connDBBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)connDBBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.Location = new Point(12, 12);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.PlaceholderText = "RAZÃO SOCIAL";
            txtRazaoSocial.Size = new Size(100, 23);
            txtRazaoSocial.TabIndex = 0;
            // 
            // txtNomeFantasia
            // 
            txtNomeFantasia.Location = new Point(12, 41);
            txtNomeFantasia.Name = "txtNomeFantasia";
            txtNomeFantasia.PlaceholderText = "NOME FANTASIA";
            txtNomeFantasia.Size = new Size(100, 23);
            txtNomeFantasia.TabIndex = 1;
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(12, 70);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.PlaceholderText = "CNPJ";
            txtCNPJ.Size = new Size(100, 23);
            txtCNPJ.TabIndex = 2;
            // 
            // txtIncricaoEstadual
            // 
            txtIncricaoEstadual.Location = new Point(12, 99);
            txtIncricaoEstadual.Name = "txtIncricaoEstadual";
            txtIncricaoEstadual.PlaceholderText = "INSCRIÇÃO ESTADUAL";
            txtIncricaoEstadual.Size = new Size(100, 23);
            txtIncricaoEstadual.TabIndex = 3;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(12, 128);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PlaceholderText = "ENDERECO";
            txtEndereco.Size = new Size(100, 23);
            txtEndereco.TabIndex = 4;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(12, 157);
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "NUMERO";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 5;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(12, 186);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.PlaceholderText = "COMPLEMENTO";
            txtComplemento.Size = new Size(100, 23);
            txtComplemento.TabIndex = 6;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(12, 215);
            txtBairro.Name = "txtBairro";
            txtBairro.PlaceholderText = "BAIRRO";
            txtBairro.Size = new Size(100, 23);
            txtBairro.TabIndex = 7;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(12, 244);
            txtCidade.Name = "txtCidade";
            txtCidade.PlaceholderText = "CIDADE";
            txtCidade.Size = new Size(100, 23);
            txtCidade.TabIndex = 8;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(12, 270);
            txtEstado.Name = "txtEstado";
            txtEstado.PlaceholderText = "ESTADO";
            txtEstado.Size = new Size(100, 23);
            txtEstado.TabIndex = 9;
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(12, 299);
            txtCEP.Name = "txtCEP";
            txtCEP.PlaceholderText = "CEP";
            txtCEP.Size = new Size(100, 23);
            txtCEP.TabIndex = 10;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(12, 328);
            txtTel.Name = "txtTel";
            txtTel.PlaceholderText = "TELEFONE";
            txtTel.Size = new Size(100, 23);
            txtTel.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 357);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "EMAIL";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 12;
            // 
            // btnUpdateEmpresa
            // 
            btnUpdateEmpresa.Location = new Point(102, 398);
            btnUpdateEmpresa.Name = "btnUpdateEmpresa";
            btnUpdateEmpresa.Size = new Size(75, 23);
            btnUpdateEmpresa.TabIndex = 13;
            btnUpdateEmpresa.Text = "EDITAR";
            btnUpdateEmpresa.UseVisualStyleBackColor = true;
            // 
            // btnAddEmpresa
            // 
            btnAddEmpresa.Location = new Point(12, 398);
            btnAddEmpresa.Name = "btnAddEmpresa";
            btnAddEmpresa.Size = new Size(84, 23);
            btnAddEmpresa.TabIndex = 14;
            btnAddEmpresa.Text = "ADICIONAR";
            btnAddEmpresa.UseVisualStyleBackColor = true;
            btnAddEmpresa.Click += btnAddEmpresa_Click;
            // 
            // btnDeleteEmpresa
            // 
            btnDeleteEmpresa.Location = new Point(183, 398);
            btnDeleteEmpresa.Name = "btnDeleteEmpresa";
            btnDeleteEmpresa.Size = new Size(75, 23);
            btnDeleteEmpresa.TabIndex = 15;
            btnDeleteEmpresa.Text = "EXCLUIR";
            btnDeleteEmpresa.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.DataSource = connDBBindingSource;
            dataGridView1.Location = new Point(310, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(478, 426);
            dataGridView1.TabIndex = 16;
            // 
            // connDBBindingSource
            // 
            connDBBindingSource.DataSource = typeof(connDB);
            // 
            // cadEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnDeleteEmpresa);
            Controls.Add(btnAddEmpresa);
            Controls.Add(btnUpdateEmpresa);
            Controls.Add(txtEmail);
            Controls.Add(txtTel);
            Controls.Add(txtCEP);
            Controls.Add(txtEstado);
            Controls.Add(txtCidade);
            Controls.Add(txtBairro);
            Controls.Add(txtComplemento);
            Controls.Add(txtNumero);
            Controls.Add(txtEndereco);
            Controls.Add(txtIncricaoEstadual);
            Controls.Add(txtCNPJ);
            Controls.Add(txtNomeFantasia);
            Controls.Add(txtRazaoSocial);
            Name = "cadEmpresa";
            Text = "cadEmpresa";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)connDBBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRazaoSocial;
        private TextBox txtNomeFantasia;
        private TextBox txtCNPJ;
        private TextBox txtIncricaoEstadual;
        private TextBox txtEndereco;
        private TextBox txtNumero;
        private TextBox txtComplemento;
        private TextBox txtBairro;
        private TextBox txtCidade;
        private TextBox txtEstado;
        private TextBox txtCEP;
        private TextBox txtTel;
        private TextBox txtEmail;
        private Button btnUpdateEmpresa;
        private Button btnAddEmpresa;
        private Button btnDeleteEmpresa;
        private DataGridView dataGridView1;
        private BindingSource connDBBindingSource;
    }
}
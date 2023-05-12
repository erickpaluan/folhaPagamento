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
            connDBBindingSource = new BindingSource(components);
            pictureBox2 = new PictureBox();
            lblSaudacao = new Label();
            ((System.ComponentModel.ISupportInitialize)connDBBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.Location = new Point(12, 196);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.PlaceholderText = "RAZÃO SOCIAL";
            txtRazaoSocial.Size = new Size(100, 23);
            txtRazaoSocial.TabIndex = 0;
            // 
            // txtNomeFantasia
            // 
            txtNomeFantasia.Location = new Point(12, 225);
            txtNomeFantasia.Name = "txtNomeFantasia";
            txtNomeFantasia.PlaceholderText = "NOME FANTASIA";
            txtNomeFantasia.Size = new Size(100, 23);
            txtNomeFantasia.TabIndex = 1;
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(12, 254);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.PlaceholderText = "CNPJ";
            txtCNPJ.Size = new Size(100, 23);
            txtCNPJ.TabIndex = 2;
            // 
            // txtIncricaoEstadual
            // 
            txtIncricaoEstadual.Location = new Point(12, 283);
            txtIncricaoEstadual.Name = "txtIncricaoEstadual";
            txtIncricaoEstadual.PlaceholderText = "INSCRIÇÃO ESTADUAL";
            txtIncricaoEstadual.Size = new Size(100, 23);
            txtIncricaoEstadual.TabIndex = 3;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(12, 312);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PlaceholderText = "ENDERECO";
            txtEndereco.Size = new Size(100, 23);
            txtEndereco.TabIndex = 4;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(12, 341);
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "NUMERO";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 5;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(12, 370);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.PlaceholderText = "COMPLEMENTO";
            txtComplemento.Size = new Size(100, 23);
            txtComplemento.TabIndex = 6;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(12, 399);
            txtBairro.Name = "txtBairro";
            txtBairro.PlaceholderText = "BAIRRO";
            txtBairro.Size = new Size(100, 23);
            txtBairro.TabIndex = 7;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(12, 428);
            txtCidade.Name = "txtCidade";
            txtCidade.PlaceholderText = "CIDADE";
            txtCidade.Size = new Size(100, 23);
            txtCidade.TabIndex = 8;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(12, 454);
            txtEstado.Name = "txtEstado";
            txtEstado.PlaceholderText = "ESTADO";
            txtEstado.Size = new Size(100, 23);
            txtEstado.TabIndex = 9;
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(12, 483);
            txtCEP.Name = "txtCEP";
            txtCEP.PlaceholderText = "CEP";
            txtCEP.Size = new Size(100, 23);
            txtCEP.TabIndex = 10;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(12, 512);
            txtTel.Name = "txtTel";
            txtTel.PlaceholderText = "TELEFONE";
            txtTel.Size = new Size(100, 23);
            txtTel.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 541);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "EMAIL";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 12;
            // 
            // btnUpdateEmpresa
            // 
            btnUpdateEmpresa.Location = new Point(102, 582);
            btnUpdateEmpresa.Name = "btnUpdateEmpresa";
            btnUpdateEmpresa.Size = new Size(75, 23);
            btnUpdateEmpresa.TabIndex = 13;
            btnUpdateEmpresa.Text = "EDITAR";
            btnUpdateEmpresa.UseVisualStyleBackColor = true;
            btnUpdateEmpresa.Click += btnUpdateEmpresa_Click;
            // 
            // btnAddEmpresa
            // 
            btnAddEmpresa.Location = new Point(12, 582);
            btnAddEmpresa.Name = "btnAddEmpresa";
            btnAddEmpresa.Size = new Size(84, 23);
            btnAddEmpresa.TabIndex = 14;
            btnAddEmpresa.Text = "ADICIONAR";
            btnAddEmpresa.UseVisualStyleBackColor = true;
            btnAddEmpresa.Click += btnAddEmpresa_Click;
            // 
            // btnDeleteEmpresa
            // 
            btnDeleteEmpresa.Location = new Point(183, 582);
            btnDeleteEmpresa.Name = "btnDeleteEmpresa";
            btnDeleteEmpresa.Size = new Size(75, 23);
            btnDeleteEmpresa.TabIndex = 15;
            btnDeleteEmpresa.Text = "EXCLUIR";
            btnDeleteEmpresa.UseVisualStyleBackColor = true;
            btnDeleteEmpresa.Click += btnDeleteEmpresa_Click;
            // 
            // connDBBindingSource
            // 
            connDBBindingSource.DataSource = typeof(connDB);
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.arrow_back_FILL0_wght400_GRAD0_opsz48;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 41;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // lblSaudacao
            // 
            lblSaudacao.AutoSize = true;
            lblSaudacao.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaudacao.Location = new Point(66, 13);
            lblSaudacao.Name = "lblSaudacao";
            lblSaudacao.Size = new Size(141, 45);
            lblSaudacao.TabIndex = 40;
            lblSaudacao.Text = "Empresa";
            // 
            // cadEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(376, 680);
            Controls.Add(pictureBox2);
            Controls.Add(lblSaudacao);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "cadEmpresa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "cadEmpresa";
            Load += cadEmpresa_Load;
            ((System.ComponentModel.ISupportInitialize)connDBBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private BindingSource connDBBindingSource;
        private PictureBox pictureBox2;
        private Label lblSaudacao;
    }
}
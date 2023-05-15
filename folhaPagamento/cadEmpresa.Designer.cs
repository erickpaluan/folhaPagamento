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
            txtRazaoSocial.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtRazaoSocial.Location = new Point(12, 90);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.PlaceholderText = "RAZÃO SOCIAL";
            txtRazaoSocial.Size = new Size(696, 35);
            txtRazaoSocial.TabIndex = 0;
            // 
            // txtNomeFantasia
            // 
            txtNomeFantasia.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeFantasia.Location = new Point(12, 131);
            txtNomeFantasia.Name = "txtNomeFantasia";
            txtNomeFantasia.PlaceholderText = "NOME FANTASIA";
            txtNomeFantasia.Size = new Size(696, 35);
            txtNomeFantasia.TabIndex = 1;
            // 
            // txtCNPJ
            // 
            txtCNPJ.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCNPJ.Location = new Point(12, 172);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.PlaceholderText = "CNPJ";
            txtCNPJ.Size = new Size(274, 35);
            txtCNPJ.TabIndex = 2;
            // 
            // txtIncricaoEstadual
            // 
            txtIncricaoEstadual.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtIncricaoEstadual.Location = new Point(292, 172);
            txtIncricaoEstadual.Name = "txtIncricaoEstadual";
            txtIncricaoEstadual.PlaceholderText = "INSCRIÇÃO ESTADUAL";
            txtIncricaoEstadual.Size = new Size(274, 35);
            txtIncricaoEstadual.TabIndex = 3;
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndereco.Location = new Point(12, 276);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PlaceholderText = "ENDERECO";
            txtEndereco.Size = new Size(499, 35);
            txtEndereco.TabIndex = 4;
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumero.Location = new Point(517, 276);
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "NUMERO";
            txtNumero.Size = new Size(191, 35);
            txtNumero.TabIndex = 5;
            // 
            // txtComplemento
            // 
            txtComplemento.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtComplemento.Location = new Point(12, 317);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.PlaceholderText = "COMPLEMENTO";
            txtComplemento.Size = new Size(195, 35);
            txtComplemento.TabIndex = 6;
            // 
            // txtBairro
            // 
            txtBairro.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBairro.Location = new Point(213, 317);
            txtBairro.Name = "txtBairro";
            txtBairro.PlaceholderText = "BAIRRO";
            txtBairro.Size = new Size(495, 35);
            txtBairro.TabIndex = 7;
            // 
            // txtCidade
            // 
            txtCidade.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCidade.Location = new Point(12, 358);
            txtCidade.Name = "txtCidade";
            txtCidade.PlaceholderText = "CIDADE";
            txtCidade.Size = new Size(499, 35);
            txtCidade.TabIndex = 8;
            // 
            // txtEstado
            // 
            txtEstado.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEstado.Location = new Point(517, 358);
            txtEstado.Name = "txtEstado";
            txtEstado.PlaceholderText = "ESTADO";
            txtEstado.Size = new Size(191, 35);
            txtEstado.TabIndex = 9;
            // 
            // txtCEP
            // 
            txtCEP.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCEP.Location = new Point(12, 399);
            txtCEP.Name = "txtCEP";
            txtCEP.PlaceholderText = "CEP";
            txtCEP.Size = new Size(499, 35);
            txtCEP.TabIndex = 10;
            // 
            // txtTel
            // 
            txtTel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTel.Location = new Point(12, 473);
            txtTel.Name = "txtTel";
            txtTel.PlaceholderText = "TELEFONE";
            txtTel.Size = new Size(289, 35);
            txtTel.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(307, 473);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "EMAIL";
            txtEmail.Size = new Size(401, 35);
            txtEmail.TabIndex = 12;
            // 
            // btnUpdateEmpresa
            // 
            btnUpdateEmpresa.Location = new Point(531, 23);
            btnUpdateEmpresa.Name = "btnUpdateEmpresa";
            btnUpdateEmpresa.Size = new Size(75, 23);
            btnUpdateEmpresa.TabIndex = 13;
            btnUpdateEmpresa.Text = "EDITAR";
            btnUpdateEmpresa.UseVisualStyleBackColor = true;
            btnUpdateEmpresa.Visible = false;
            btnUpdateEmpresa.Click += btnUpdateEmpresa_Click;
            // 
            // btnAddEmpresa
            // 
            btnAddEmpresa.Location = new Point(441, 23);
            btnAddEmpresa.Name = "btnAddEmpresa";
            btnAddEmpresa.Size = new Size(84, 23);
            btnAddEmpresa.TabIndex = 14;
            btnAddEmpresa.Text = "ADICIONAR";
            btnAddEmpresa.UseVisualStyleBackColor = true;
            btnAddEmpresa.Visible = false;
            btnAddEmpresa.Click += btnAddEmpresa_Click;
            // 
            // btnDeleteEmpresa
            // 
            btnDeleteEmpresa.Location = new Point(612, 23);
            btnDeleteEmpresa.Name = "btnDeleteEmpresa";
            btnDeleteEmpresa.Size = new Size(75, 23);
            btnDeleteEmpresa.TabIndex = 15;
            btnDeleteEmpresa.Text = "EXCLUIR";
            btnDeleteEmpresa.UseVisualStyleBackColor = true;
            btnDeleteEmpresa.Visible = false;
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
            ClientSize = new Size(720, 539);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
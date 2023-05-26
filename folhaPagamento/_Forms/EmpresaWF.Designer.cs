using folhaPagamento._Classes;

namespace folhaPagamento
{
    partial class EmpresaWF
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
            panel1 = new Panel();
            btnCarregarInfos = new Button();
            btnMinhasConfig = new Button();
            btnMeuPerfil = new Button();
            lblSaudacao = new Label();
            ((System.ComponentModel.ISupportInitialize)connDBBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtRazaoSocial.Location = new Point(12, 57);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.PlaceholderText = "RAZÃO SOCIAL";
            txtRazaoSocial.Size = new Size(696, 23);
            txtRazaoSocial.TabIndex = 0;
            // 
            // txtNomeFantasia
            // 
            txtNomeFantasia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeFantasia.Location = new Point(12, 86);
            txtNomeFantasia.Name = "txtNomeFantasia";
            txtNomeFantasia.PlaceholderText = "NOME FANTASIA";
            txtNomeFantasia.Size = new Size(696, 23);
            txtNomeFantasia.TabIndex = 1;
            // 
            // txtCNPJ
            // 
            txtCNPJ.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCNPJ.Location = new Point(12, 115);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.PlaceholderText = "CNPJ";
            txtCNPJ.Size = new Size(274, 23);
            txtCNPJ.TabIndex = 2;
            // 
            // txtIncricaoEstadual
            // 
            txtIncricaoEstadual.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtIncricaoEstadual.Location = new Point(292, 115);
            txtIncricaoEstadual.Name = "txtIncricaoEstadual";
            txtIncricaoEstadual.PlaceholderText = "INSCRIÇÃO ESTADUAL";
            txtIncricaoEstadual.Size = new Size(274, 23);
            txtIncricaoEstadual.TabIndex = 3;
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndereco.Location = new Point(12, 165);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PlaceholderText = "ENDERECO";
            txtEndereco.Size = new Size(499, 23);
            txtEndereco.TabIndex = 4;
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumero.Location = new Point(517, 165);
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "NUMERO";
            txtNumero.Size = new Size(191, 23);
            txtNumero.TabIndex = 5;
            // 
            // txtComplemento
            // 
            txtComplemento.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtComplemento.Location = new Point(12, 194);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.PlaceholderText = "COMPLEMENTO";
            txtComplemento.Size = new Size(195, 23);
            txtComplemento.TabIndex = 6;
            // 
            // txtBairro
            // 
            txtBairro.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBairro.Location = new Point(213, 194);
            txtBairro.Name = "txtBairro";
            txtBairro.PlaceholderText = "BAIRRO";
            txtBairro.Size = new Size(495, 23);
            txtBairro.TabIndex = 7;
            // 
            // txtCidade
            // 
            txtCidade.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCidade.Location = new Point(12, 223);
            txtCidade.Name = "txtCidade";
            txtCidade.PlaceholderText = "CIDADE";
            txtCidade.Size = new Size(499, 23);
            txtCidade.TabIndex = 8;
            // 
            // txtEstado
            // 
            txtEstado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEstado.Location = new Point(517, 223);
            txtEstado.Name = "txtEstado";
            txtEstado.PlaceholderText = "ESTADO";
            txtEstado.Size = new Size(191, 23);
            txtEstado.TabIndex = 9;
            // 
            // txtCEP
            // 
            txtCEP.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCEP.Location = new Point(12, 252);
            txtCEP.Name = "txtCEP";
            txtCEP.PlaceholderText = "CEP";
            txtCEP.Size = new Size(499, 23);
            txtCEP.TabIndex = 10;
            // 
            // txtTel
            // 
            txtTel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTel.Location = new Point(12, 305);
            txtTel.Name = "txtTel";
            txtTel.PlaceholderText = "TELEFONE";
            txtTel.Size = new Size(289, 23);
            txtTel.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(307, 305);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "EMAIL";
            txtEmail.Size = new Size(401, 23);
            txtEmail.TabIndex = 12;
            // 
            // btnUpdateEmpresa
            // 
            btnUpdateEmpresa.Location = new Point(397, 13);
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
            btnAddEmpresa.Location = new Point(307, 13);
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
            btnDeleteEmpresa.Location = new Point(478, 13);
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
            connDBBindingSource.DataSource = typeof(ConexaoDB);
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.arrow_back_FILL0_wght400_GRAD0_opsz48;
            pictureBox2.Location = new Point(12, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 41;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(196, 196, 196);
            panel1.Controls.Add(btnCarregarInfos);
            panel1.Controls.Add(btnDeleteEmpresa);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnAddEmpresa);
            panel1.Controls.Add(btnUpdateEmpresa);
            panel1.Controls.Add(btnMinhasConfig);
            panel1.Controls.Add(btnMeuPerfil);
            panel1.Controls.Add(lblSaudacao);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(721, 51);
            panel1.TabIndex = 42;
            // 
            // btnCarregarInfos
            // 
            btnCarregarInfos.Anchor = AnchorStyles.Right;
            btnCarregarInfos.BackColor = Color.White;
            btnCarregarInfos.FlatStyle = FlatStyle.Flat;
            btnCarregarInfos.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCarregarInfos.ForeColor = Color.FromArgb(62, 122, 232);
            btnCarregarInfos.ImageAlign = ContentAlignment.MiddleLeft;
            btnCarregarInfos.Location = new Point(569, 9);
            btnCarregarInfos.Name = "btnCarregarInfos";
            btnCarregarInfos.Size = new Size(139, 29);
            btnCarregarInfos.TabIndex = 42;
            btnCarregarInfos.Text = "Carregar informações";
            btnCarregarInfos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCarregarInfos.UseVisualStyleBackColor = false;
            // 
            // btnMinhasConfig
            // 
            btnMinhasConfig.Anchor = AnchorStyles.Right;
            btnMinhasConfig.BackColor = Color.White;
            btnMinhasConfig.FlatStyle = FlatStyle.Flat;
            btnMinhasConfig.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinhasConfig.ForeColor = Color.FromArgb(62, 122, 232);
            btnMinhasConfig.ImageAlign = ContentAlignment.MiddleLeft;
            btnMinhasConfig.Location = new Point(1653, -24);
            btnMinhasConfig.Name = "btnMinhasConfig";
            btnMinhasConfig.Size = new Size(139, 29);
            btnMinhasConfig.TabIndex = 19;
            btnMinhasConfig.Text = "Minhas configurações";
            btnMinhasConfig.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMinhasConfig.UseVisualStyleBackColor = false;
            // 
            // btnMeuPerfil
            // 
            btnMeuPerfil.Anchor = AnchorStyles.Right;
            btnMeuPerfil.BackColor = Color.FromArgb(62, 122, 232);
            btnMeuPerfil.FlatStyle = FlatStyle.Flat;
            btnMeuPerfil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMeuPerfil.ForeColor = Color.White;
            btnMeuPerfil.ImageAlign = ContentAlignment.MiddleLeft;
            btnMeuPerfil.Location = new Point(1521, -24);
            btnMeuPerfil.Name = "btnMeuPerfil";
            btnMeuPerfil.Size = new Size(126, 29);
            btnMeuPerfil.TabIndex = 18;
            btnMeuPerfil.Text = "Meu perfil";
            btnMeuPerfil.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMeuPerfil.UseVisualStyleBackColor = false;
            // 
            // lblSaudacao
            // 
            lblSaudacao.AutoSize = true;
            lblSaudacao.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaudacao.Location = new Point(45, 13);
            lblSaudacao.Name = "lblSaudacao";
            lblSaudacao.Size = new Size(84, 25);
            lblSaudacao.TabIndex = 36;
            lblSaudacao.Text = "Empresa";
            // 
            // EmpresaWF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(720, 340);
            ControlBox = false;
            Controls.Add(panel1);
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
            Name = "EmpresaWF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Empresa";
            Load += cadEmpresa_Load;
            ((System.ComponentModel.ISupportInitialize)connDBBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Button btnCarregarInfos;
        private Button btnMinhasConfig;
        private Button btnMeuPerfil;
        private Label lblSaudacao;
    }
}
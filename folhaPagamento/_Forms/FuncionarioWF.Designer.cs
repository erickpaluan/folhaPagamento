namespace folhaPagamento
{
    partial class FuncionarioWF
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
            chbAdm = new CheckBox();
            chbAtivo = new CheckBox();
            label9 = new Label();
            dtpDtAdm = new DateTimePicker();
            label8 = new Label();
            txtSalario = new TextBox();
            label7 = new Label();
            txtCargo = new TextBox();
            cbEstado_civil = new ComboBox();
            label5 = new Label();
            label13 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            txtDDD = new TextBox();
            cbTipo = new ComboBox();
            label3 = new Label();
            txtTelefone = new TextBox();
            dtpDataNasc = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            btnAdicionar = new Button();
            pictureBox2 = new PictureBox();
            label11 = new Label();
            cbSexo = new ComboBox();
            groupBox2 = new GroupBox();
            txtCEP = new TextBox();
            label12 = new Label();
            txtRua = new TextBox();
            label20 = new Label();
            txtCidade = new TextBox();
            label19 = new Label();
            label18 = new Label();
            txtNum = new TextBox();
            label17 = new Label();
            cbEstado = new ComboBox();
            label16 = new Label();
            txtBairro = new TextBox();
            label15 = new Label();
            cbLogr = new ComboBox();
            label14 = new Label();
            txtComplemento = new TextBox();
            groupBox1 = new GroupBox();
            groupBox8 = new GroupBox();
            groupBox7 = new GroupBox();
            chbConv_odon = new CheckBox();
            chbConv_med = new CheckBox();
            groupBox6 = new GroupBox();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            txtMatricula = new TextBox();
            txtCPF = new TextBox();
            groupBox9 = new GroupBox();
            dgUsuarios = new DataGridView();
            pbImagemFuncionario = new PictureBox();
            lblImagemFuncionario = new LinkLabel();
            openFileDialog1 = new OpenFileDialog();
            panel1 = new Panel();
            btnExcluirFuncionario = new Button();
            btnAlterarFuncionario = new Button();
            btnNovoFuncionario = new Button();
            btnMinhasConfig = new Button();
            btnMeuPerfil = new Button();
            label10 = new Label();
            gbinfoFuncionarios = new GroupBox();
            label21 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImagemFuncionario).BeginInit();
            panel1.SuspendLayout();
            gbinfoFuncionarios.SuspendLayout();
            SuspendLayout();
            // 
            // chbAdm
            // 
            chbAdm.AutoSize = true;
            chbAdm.Location = new Point(162, 51);
            chbAdm.Name = "chbAdm";
            chbAdm.Size = new Size(102, 19);
            chbAdm.TabIndex = 27;
            chbAdm.Text = "Administrador";
            chbAdm.UseVisualStyleBackColor = true;
            // 
            // chbAtivo
            // 
            chbAtivo.AutoSize = true;
            chbAtivo.Location = new Point(377, 66);
            chbAtivo.Name = "chbAtivo";
            chbAtivo.Size = new Size(54, 19);
            chbAtivo.TabIndex = 25;
            chbAtivo.Text = "Ativo";
            chbAtivo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(301, 16);
            label9.Name = "label9";
            label9.Size = new Size(86, 15);
            label9.TabIndex = 26;
            label9.Text = "Data Admissão";
            // 
            // dtpDtAdm
            // 
            dtpDtAdm.Format = DateTimePickerFormat.Short;
            dtpDtAdm.Location = new Point(301, 34);
            dtpDtAdm.Name = "dtpDtAdm";
            dtpDtAdm.Size = new Size(130, 23);
            dtpDtAdm.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(143, 19);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 15;
            label8.Text = "Salário Base";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(143, 37);
            txtSalario.Name = "txtSalario";
            txtSalario.PlaceholderText = "R$";
            txtSalario.Size = new Size(152, 23);
            txtSalario.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 19);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 13;
            label7.Text = "Cargo";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(6, 37);
            txtCargo.Name = "txtCargo";
            txtCargo.PlaceholderText = "CARGO";
            txtCargo.Size = new Size(131, 23);
            txtCargo.TabIndex = 12;
            // 
            // cbEstado_civil
            // 
            cbEstado_civil.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado_civil.FormattingEnabled = true;
            cbEstado_civil.Items.AddRange(new object[] { "Solteiro", "Casado", "Viúvo", "Divorciado" });
            cbEstado_civil.Location = new Point(309, 81);
            cbEstado_civil.Name = "cbEstado_civil";
            cbEstado_civil.Size = new Size(131, 23);
            cbEstado_civil.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(309, 63);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 20;
            label5.Text = "Estado Civil";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(197, 19);
            label13.Name = "label13";
            label13.Size = new Size(30, 15);
            label13.TabIndex = 35;
            label13.Text = "Tipo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 63);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 11;
            label4.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(6, 81);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "E-MAIL";
            txtEmail.Size = new Size(258, 23);
            txtEmail.TabIndex = 10;
            // 
            // txtDDD
            // 
            txtDDD.Location = new Point(6, 37);
            txtDDD.Name = "txtDDD";
            txtDDD.PlaceholderText = "DDD";
            txtDDD.Size = new Size(33, 23);
            txtDDD.TabIndex = 12;
            // 
            // cbTipo
            // 
            cbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Cel", "Fixo", "Outro" });
            cbTipo.Location = new Point(197, 37);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(67, 23);
            cbTipo.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 9;
            label3.Text = "Telefone";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(45, 37);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "TELEFONE";
            txtTelefone.Size = new Size(146, 23);
            txtTelefone.TabIndex = 8;
            // 
            // dtpDataNasc
            // 
            dtpDataNasc.Format = DateTimePickerFormat.Short;
            dtpDataNasc.Location = new Point(6, 81);
            dtpDataNasc.Name = "dtpDataNasc";
            dtpDataNasc.Size = new Size(131, 23);
            dtpDataNasc.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 63);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 18;
            label2.Text = "Data nascimento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(309, 19);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 17;
            label1.Text = "CPF";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(6, 19);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 14;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(6, 37);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "NOME";
            txtNome.Size = new Size(297, 23);
            txtNome.TabIndex = 13;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(492, 496);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(74, 35);
            btnAdicionar.TabIndex = 31;
            btnAdicionar.Text = "Salvar";
            btnAdicionar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += button5_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.arrow_back_FILL0_wght400_GRAD0_opsz48;
            pictureBox2.Location = new Point(9, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            pictureBox2.MouseLeave += pictureBox2_MouseLeave;
            pictureBox2.MouseHover += pictureBox2_MouseHover;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(143, 63);
            label11.Name = "label11";
            label11.Size = new Size(32, 15);
            label11.TabIndex = 36;
            label11.Text = "Sexo";
            // 
            // cbSexo
            // 
            cbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSexo.FormattingEnabled = true;
            cbSexo.Items.AddRange(new object[] { "Masculino", "Feminino", "Outros" });
            cbSexo.Location = new Point(143, 81);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(160, 23);
            cbSexo.TabIndex = 35;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtCEP);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtRua);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(txtCidade);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(txtNum);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(cbEstado);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(txtBairro);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(cbLogr);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(txtComplemento);
            groupBox2.Location = new Point(6, 138);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(560, 122);
            groupBox2.TabIndex = 47;
            groupBox2.TabStop = false;
            groupBox2.Text = "Endereço";
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(356, 81);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(192, 23);
            txtCEP.TabIndex = 49;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 19);
            label12.Name = "label12";
            label12.Size = new Size(69, 15);
            label12.TabIndex = 37;
            label12.Text = "Logradouro";
            // 
            // txtRua
            // 
            txtRua.Location = new Point(81, 37);
            txtRua.Name = "txtRua";
            txtRua.PlaceholderText = "Endereço";
            txtRua.Size = new Size(269, 23);
            txtRua.TabIndex = 0;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(356, 63);
            label20.Name = "label20";
            label20.Size = new Size(28, 15);
            label20.TabIndex = 45;
            label20.Text = "CEP";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(134, 81);
            txtCidade.Name = "txtCidade";
            txtCidade.PlaceholderText = "Cidade";
            txtCidade.Size = new Size(154, 23);
            txtCidade.TabIndex = 1;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(294, 63);
            label19.Name = "label19";
            label19.Size = new Size(21, 15);
            label19.TabIndex = 44;
            label19.Text = "UF";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(134, 63);
            label18.Name = "label18";
            label18.Size = new Size(44, 15);
            label18.TabIndex = 43;
            label18.Text = "Cidade";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(356, 37);
            txtNum.Name = "txtNum";
            txtNum.PlaceholderText = "Nº";
            txtNum.Size = new Size(56, 23);
            txtNum.TabIndex = 3;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(418, 19);
            label17.Name = "label17";
            label17.Size = new Size(84, 15);
            label17.TabIndex = 42;
            label17.Text = "Complemento";
            // 
            // cbEstado
            // 
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.FormattingEnabled = true;
            cbEstado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbEstado.Location = new Point(294, 81);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(56, 23);
            cbEstado.TabIndex = 4;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 63);
            label16.Name = "label16";
            label16.Size = new Size(38, 15);
            label16.TabIndex = 41;
            label16.Text = "Bairro";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(6, 81);
            txtBairro.Name = "txtBairro";
            txtBairro.PlaceholderText = "Bairro";
            txtBairro.Size = new Size(122, 23);
            txtBairro.TabIndex = 5;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(356, 19);
            label15.Name = "label15";
            label15.Size = new Size(21, 15);
            label15.TabIndex = 40;
            label15.Text = "Nº";
            // 
            // cbLogr
            // 
            cbLogr.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLogr.FormattingEnabled = true;
            cbLogr.Items.AddRange(new object[] { "Rua", "Avenida", "Travessa" });
            cbLogr.Location = new Point(6, 37);
            cbLogr.Name = "cbLogr";
            cbLogr.Size = new Size(69, 23);
            cbLogr.TabIndex = 22;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(81, 19);
            label14.Name = "label14";
            label14.Size = new Size(56, 15);
            label14.TabIndex = 39;
            label14.Text = "Endereço";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(418, 37);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.PlaceholderText = "Complemento";
            txtComplemento.Size = new Size(130, 23);
            txtComplemento.TabIndex = 38;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(cbTipo);
            groupBox1.Controls.Add(txtDDD);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Location = new Point(6, 266);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(270, 117);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            groupBox1.Text = "Contato";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(label7);
            groupBox8.Controls.Add(label8);
            groupBox8.Controls.Add(chbAtivo);
            groupBox8.Controls.Add(dtpDtAdm);
            groupBox8.Controls.Add(groupBox7);
            groupBox8.Controls.Add(txtSalario);
            groupBox8.Controls.Add(txtCargo);
            groupBox8.Controls.Add(label9);
            groupBox8.Location = new Point(6, 389);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(560, 101);
            groupBox8.TabIndex = 35;
            groupBox8.TabStop = false;
            groupBox8.Text = "Empresarial";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(chbConv_odon);
            groupBox7.Controls.Add(chbConv_med);
            groupBox7.Location = new Point(437, 19);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(111, 72);
            groupBox7.TabIndex = 34;
            groupBox7.TabStop = false;
            groupBox7.Text = "Convênios";
            // 
            // chbConv_odon
            // 
            chbConv_odon.AutoSize = true;
            chbConv_odon.Location = new Point(6, 22);
            chbConv_odon.Name = "chbConv_odon";
            chbConv_odon.Size = new Size(100, 19);
            chbConv_odon.TabIndex = 32;
            chbConv_odon.Text = "Odontológico";
            chbConv_odon.UseVisualStyleBackColor = true;
            // 
            // chbConv_med
            // 
            chbConv_med.AutoSize = true;
            chbConv_med.Location = new Point(6, 47);
            chbConv_med.Name = "chbConv_med";
            chbConv_med.Size = new Size(66, 19);
            chbConv_med.TabIndex = 31;
            chbConv_med.Text = "Médico";
            chbConv_med.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(txtLogin);
            groupBox6.Controls.Add(txtSenha);
            groupBox6.Controls.Add(chbAdm);
            groupBox6.Location = new Point(290, 266);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(276, 117);
            groupBox6.TabIndex = 33;
            groupBox6.TabStop = false;
            groupBox6.Text = "Informações Entrada";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(6, 22);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "LOGIN";
            txtLogin.Size = new Size(120, 23);
            txtLogin.TabIndex = 30;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(132, 22);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '•';
            txtSenha.PlaceholderText = "SENHA";
            txtSenha.Size = new Size(132, 23);
            txtSenha.TabIndex = 29;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(280, 15);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PlaceholderText = "MATRICULA";
            txtMatricula.Size = new Size(83, 23);
            txtMatricula.TabIndex = 28;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(309, 37);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(131, 23);
            txtCPF.TabIndex = 48;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(txtCPF);
            groupBox9.Controls.Add(lblNome);
            groupBox9.Controls.Add(cbEstado_civil);
            groupBox9.Controls.Add(dtpDataNasc);
            groupBox9.Controls.Add(label2);
            groupBox9.Controls.Add(txtNome);
            groupBox9.Controls.Add(label1);
            groupBox9.Controls.Add(cbSexo);
            groupBox9.Controls.Add(label5);
            groupBox9.Controls.Add(label11);
            groupBox9.Location = new Point(114, 12);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(452, 120);
            groupBox9.TabIndex = 38;
            groupBox9.TabStop = false;
            groupBox9.Text = "Informações Pessoais";
            // 
            // dgUsuarios
            // 
            dgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUsuarios.Location = new Point(9, 57);
            dgUsuarios.Name = "dgUsuarios";
            dgUsuarios.ReadOnly = true;
            dgUsuarios.RowTemplate.Height = 25;
            dgUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgUsuarios.Size = new Size(372, 537);
            dgUsuarios.TabIndex = 48;
            dgUsuarios.CellClick += dgUsuarios_CellClick_1;
            // 
            // pbImagemFuncionario
            // 
            pbImagemFuncionario.Image = Properties.Resources.groups_FILL0_wght400_GRAD0_opsz48;
            pbImagemFuncionario.Location = new Point(6, 12);
            pbImagemFuncionario.Name = "pbImagemFuncionario";
            pbImagemFuncionario.Size = new Size(102, 102);
            pbImagemFuncionario.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagemFuncionario.TabIndex = 49;
            pbImagemFuncionario.TabStop = false;
            // 
            // lblImagemFuncionario
            // 
            lblImagemFuncionario.AutoSize = true;
            lblImagemFuncionario.Location = new Point(22, 117);
            lblImagemFuncionario.Name = "lblImagemFuncionario";
            lblImagemFuncionario.Size = new Size(86, 15);
            lblImagemFuncionario.TabIndex = 50;
            lblImagemFuncionario.TabStop = true;
            lblImagemFuncionario.Text = "Selecionar foto";
            lblImagemFuncionario.LinkClicked += lblImagemFuncionario_LinkClicked;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(196, 196, 196);
            panel1.Controls.Add(btnExcluirFuncionario);
            panel1.Controls.Add(btnAlterarFuncionario);
            panel1.Controls.Add(btnNovoFuncionario);
            panel1.Controls.Add(btnMinhasConfig);
            panel1.Controls.Add(btnMeuPerfil);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(txtMatricula);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(979, 51);
            panel1.TabIndex = 51;
            // 
            // btnExcluirFuncionario
            // 
            btnExcluirFuncionario.Anchor = AnchorStyles.Right;
            btnExcluirFuncionario.BackColor = Color.White;
            btnExcluirFuncionario.FlatStyle = FlatStyle.Flat;
            btnExcluirFuncionario.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluirFuncionario.ForeColor = Color.FromArgb(229, 60, 60);
            btnExcluirFuncionario.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluirFuncionario.Location = new Point(530, 9);
            btnExcluirFuncionario.Name = "btnExcluirFuncionario";
            btnExcluirFuncionario.Size = new Size(139, 29);
            btnExcluirFuncionario.TabIndex = 44;
            btnExcluirFuncionario.Text = "Excluir";
            btnExcluirFuncionario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExcluirFuncionario.UseVisualStyleBackColor = false;
            btnExcluirFuncionario.Click += btnExcluirFuncionario_Click;
            // 
            // btnAlterarFuncionario
            // 
            btnAlterarFuncionario.Anchor = AnchorStyles.Right;
            btnAlterarFuncionario.BackColor = Color.White;
            btnAlterarFuncionario.FlatStyle = FlatStyle.Flat;
            btnAlterarFuncionario.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlterarFuncionario.ForeColor = Color.FromArgb(250, 134, 72);
            btnAlterarFuncionario.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlterarFuncionario.Location = new Point(675, 9);
            btnAlterarFuncionario.Name = "btnAlterarFuncionario";
            btnAlterarFuncionario.Size = new Size(139, 29);
            btnAlterarFuncionario.TabIndex = 43;
            btnAlterarFuncionario.Text = "Alterar";
            btnAlterarFuncionario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAlterarFuncionario.UseVisualStyleBackColor = false;
            btnAlterarFuncionario.Click += btnAlterarFuncionario_Click;
            // 
            // btnNovoFuncionario
            // 
            btnNovoFuncionario.Anchor = AnchorStyles.Right;
            btnNovoFuncionario.BackColor = Color.White;
            btnNovoFuncionario.FlatStyle = FlatStyle.Flat;
            btnNovoFuncionario.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNovoFuncionario.ForeColor = Color.FromArgb(62, 122, 232);
            btnNovoFuncionario.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovoFuncionario.Location = new Point(820, 9);
            btnNovoFuncionario.Name = "btnNovoFuncionario";
            btnNovoFuncionario.Size = new Size(139, 29);
            btnNovoFuncionario.TabIndex = 42;
            btnNovoFuncionario.Text = "Novo funcionário";
            btnNovoFuncionario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNovoFuncionario.UseVisualStyleBackColor = false;
            btnNovoFuncionario.Click += btnNovoFuncionario_Click;
            // 
            // btnMinhasConfig
            // 
            btnMinhasConfig.Anchor = AnchorStyles.Right;
            btnMinhasConfig.BackColor = Color.White;
            btnMinhasConfig.FlatStyle = FlatStyle.Flat;
            btnMinhasConfig.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinhasConfig.ForeColor = Color.FromArgb(62, 122, 232);
            btnMinhasConfig.ImageAlign = ContentAlignment.MiddleLeft;
            btnMinhasConfig.Location = new Point(1911, -24);
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
            btnMeuPerfil.Location = new Point(1779, -24);
            btnMeuPerfil.Name = "btnMeuPerfil";
            btnMeuPerfil.Size = new Size(126, 29);
            btnMeuPerfil.TabIndex = 18;
            btnMeuPerfil.Text = "Meu perfil";
            btnMeuPerfil.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMeuPerfil.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(45, 13);
            label10.Name = "label10";
            label10.Size = new Size(120, 25);
            label10.TabIndex = 36;
            label10.Text = "Funcionários";
            // 
            // gbinfoFuncionarios
            // 
            gbinfoFuncionarios.Controls.Add(label21);
            gbinfoFuncionarios.Controls.Add(pbImagemFuncionario);
            gbinfoFuncionarios.Controls.Add(lblImagemFuncionario);
            gbinfoFuncionarios.Controls.Add(btnAdicionar);
            gbinfoFuncionarios.Controls.Add(groupBox2);
            gbinfoFuncionarios.Controls.Add(groupBox8);
            gbinfoFuncionarios.Controls.Add(groupBox1);
            gbinfoFuncionarios.Controls.Add(groupBox6);
            gbinfoFuncionarios.Controls.Add(groupBox9);
            gbinfoFuncionarios.Location = new Point(387, 57);
            gbinfoFuncionarios.Name = "gbinfoFuncionarios";
            gbinfoFuncionarios.Size = new Size(572, 537);
            gbinfoFuncionarios.TabIndex = 52;
            gbinfoFuncionarios.TabStop = false;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(74, 502);
            label21.Name = "label21";
            label21.Size = new Size(44, 15);
            label21.TabIndex = 51;
            label21.Text = "label21";
            // 
            // FuncionarioWF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(971, 606);
            ControlBox = false;
            Controls.Add(gbinfoFuncionarios);
            Controls.Add(panel1);
            Controls.Add(dgUsuarios);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FuncionarioWF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Funcionários";
            Load += cadUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImagemFuncionario).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            gbinfoFuncionarios.ResumeLayout(false);
            gbinfoFuncionarios.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private ComboBox cbEstado_civil;
        private Label label5;
        private Label label4;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtTelefone;
        private DateTimePicker dtpDataNasc;
        private Label label2;
        private Label label1;
        private Label lblNome;
        private TextBox txtNome;
        private GroupBox groupBox3;
        private CheckBox checkBox1;
        private GroupBox groupBox4;
        private Label label6;
        private NumericUpDown numericUpDown1;
        private CheckBox chbAdm;
        private CheckBox chbAtivo;
        private Label label9;
        private DateTimePicker dtpDtAdm;
        private Label label8;
        private TextBox txtSalario;
        private Label label7;
        private TextBox txtCargo;
        private Button btnAdicionar;
        private PictureBox pictureBox2;
        private ComboBox cbTipo;
        private TextBox txtDDD;
        private ComboBox cbEstado;
        private TextBox txtNum;
        private TextBox txtCidade;
        private TextBox txtRua;
        private TextBox txtBairro;
        private TextBox txtMatricula;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private CheckBox chbConv_odon;
        private CheckBox chbConv_med;
        private Label label11;
        private ComboBox cbSexo;
        private ComboBox cbLogr;
        private Label label12;
        private TextBox txtComplemento;
        private Label label13;
        private GroupBox groupBox1;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private GroupBox groupBox7;
        private GroupBox groupBox6;
        private GroupBox groupBox8;
        private TextBox txtCEP;
        private TextBox txtCPF;
        private GroupBox groupBox9;
        private DataGridView dgUsuarios;
        private PictureBox pbImagemFuncionario;
        private LinkLabel lblImagemFuncionario;
        private OpenFileDialog openFileDialog1;
        private Panel panel1;
        private Button btnNovoFuncionario;
        private Button btnMinhasConfig;
        private Button btnMeuPerfil;
        private Label label10;
        private GroupBox gbinfoFuncionarios;
        private Button btnExcluirFuncionario;
        private Button btnAlterarFuncionario;
        private Label label21;
    }
}
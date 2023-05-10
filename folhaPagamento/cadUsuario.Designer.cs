namespace folhaPagamento
{
    partial class cadUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadUsuario));
            dgUsuarios=new DataGridView();
            chbAdm=new CheckBox();
            chbAtivo=new CheckBox();
            label9=new Label();
            dtpDtAdm=new DateTimePicker();
            label8=new Label();
            txtSalario=new TextBox();
            label7=new Label();
            txtCargo=new TextBox();
            cbEstado_civil=new ComboBox();
            label5=new Label();
            groupBox1=new GroupBox();
            label4=new Label();
            txtEmail=new TextBox();
            txtDDD=new TextBox();
            cbTipo=new ComboBox();
            label3=new Label();
            txtTelefone=new TextBox();
            dtpDataNasc=new DateTimePicker();
            label2=new Label();
            label1=new Label();
            txtCPF=new TextBox();
            lblNome=new Label();
            txtNome=new TextBox();
            textBox4=new TextBox();
            button3=new Button();
            btnExcluir=new Button();
            btnAdicionar=new Button();
            label10=new Label();
            pictureBox2=new PictureBox();
            lblSaudacao=new Label();
            tabControl1=new TabControl();
            tbInfos=new TabPage();
            label11=new Label();
            cbSexo=new ComboBox();
            tabPage1=new TabPage();
            txtComplemento=new TextBox();
            label12=new Label();
            cbLogr=new ComboBox();
            txtBairro=new TextBox();
            cbEstado=new ComboBox();
            txtNum=new TextBox();
            txtCEP=new TextBox();
            txtCidade=new TextBox();
            txtRua=new TextBox();
            tabPage2=new TabPage();
            chbConv_odon=new CheckBox();
            chbConv_med=new CheckBox();
            txtLogin=new TextBox();
            txtSenha=new TextBox();
            txtMatricula=new TextBox();
            label13=new Label();
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabControl1.SuspendLayout();
            tbInfos.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // dgUsuarios
            // 
            dgUsuarios.AllowUserToAddRows=false;
            dgUsuarios.AllowUserToDeleteRows=false;
            dgUsuarios.AllowUserToResizeColumns=false;
            dgUsuarios.AllowUserToResizeRows=false;
            dgUsuarios.AutoSizeRowsMode=DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgUsuarios.BackgroundColor=Color.White;
            dgUsuarios.CellBorderStyle=DataGridViewCellBorderStyle.None;
            dgUsuarios.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUsuarios.Location=new Point(12, 107);
            dgUsuarios.MultiSelect=false;
            dgUsuarios.Name="dgUsuarios";
            dgUsuarios.ReadOnly=true;
            dgUsuarios.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgUsuarios.RowTemplate.Height=25;
            dgUsuarios.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            dgUsuarios.Size=new Size(354, 134);
            dgUsuarios.TabIndex=6;
            dgUsuarios.CellClick+=dgUsuarios_CellClick;
            // 
            // chbAdm
            // 
            chbAdm.AutoSize=true;
            chbAdm.Location=new Point(186, 274);
            chbAdm.Name="chbAdm";
            chbAdm.Size=new Size(102, 19);
            chbAdm.TabIndex=27;
            chbAdm.Text="Administrador";
            chbAdm.UseVisualStyleBackColor=true;
            // 
            // chbAtivo
            // 
            chbAtivo.AutoSize=true;
            chbAtivo.Location=new Point(186, 249);
            chbAtivo.Name="chbAtivo";
            chbAtivo.Size=new Size(54, 19);
            chbAtivo.TabIndex=25;
            chbAtivo.Text="Ativo";
            chbAtivo.UseVisualStyleBackColor=true;
            // 
            // label9
            // 
            label9.AutoSize=true;
            label9.Location=new Point(18, 57);
            label9.Name="label9";
            label9.Size=new Size(86, 15);
            label9.TabIndex=26;
            label9.Text="Data Admissão";
            // 
            // dtpDtAdm
            // 
            dtpDtAdm.Format=DateTimePickerFormat.Short;
            dtpDtAdm.Location=new Point(18, 75);
            dtpDtAdm.Name="dtpDtAdm";
            dtpDtAdm.Size=new Size(131, 23);
            dtpDtAdm.TabIndex=25;
            // 
            // label8
            // 
            label8.AutoSize=true;
            label8.Location=new Point(215, 13);
            label8.Name="label8";
            label8.Size=new Size(69, 15);
            label8.TabIndex=15;
            label8.Text="Salário Base";
            // 
            // txtSalario
            // 
            txtSalario.Location=new Point(215, 31);
            txtSalario.Name="txtSalario";
            txtSalario.PlaceholderText="R$";
            txtSalario.Size=new Size(114, 23);
            txtSalario.TabIndex=14;
            // 
            // label7
            // 
            label7.AutoSize=true;
            label7.Location=new Point(18, 13);
            label7.Name="label7";
            label7.Size=new Size(39, 15);
            label7.TabIndex=13;
            label7.Text="Cargo";
            // 
            // txtCargo
            // 
            txtCargo.Location=new Point(18, 31);
            txtCargo.Name="txtCargo";
            txtCargo.PlaceholderText="CARGO";
            txtCargo.Size=new Size(191, 23);
            txtCargo.TabIndex=12;
            // 
            // cbEstado_civil
            // 
            cbEstado_civil.DropDownStyle=ComboBoxStyle.DropDownList;
            cbEstado_civil.FormattingEnabled=true;
            cbEstado_civil.Items.AddRange(new object[] { "Solteiro", "Casado", "Viúvo", "Divorciado" });
            cbEstado_civil.Location=new Point(143, 107);
            cbEstado_civil.Name="cbEstado_civil";
            cbEstado_civil.Size=new Size(100, 23);
            cbEstado_civil.TabIndex=21;
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new Point(143, 91);
            label5.Name="label5";
            label5.Size=new Size(68, 15);
            label5.TabIndex=20;
            label5.Text="Estado Civil";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtDDD);
            groupBox1.Controls.Add(cbTipo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Location=new Point(6, 182);
            groupBox1.Name="groupBox1";
            groupBox1.Size=new Size(334, 161);
            groupBox1.TabIndex=19;
            groupBox1.TabStop=false;
            groupBox1.Text="Contato e Endereço";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(6, 63);
            label4.Name="label4";
            label4.Size=new Size(41, 15);
            label4.TabIndex=11;
            label4.Text="E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Location=new Point(6, 81);
            txtEmail.Name="txtEmail";
            txtEmail.PlaceholderText="E-MAIL";
            txtEmail.Size=new Size(231, 23);
            txtEmail.TabIndex=10;
            // 
            // txtDDD
            // 
            txtDDD.Location=new Point(6, 37);
            txtDDD.Name="txtDDD";
            txtDDD.PlaceholderText="DDD";
            txtDDD.Size=new Size(33, 23);
            txtDDD.TabIndex=12;
            // 
            // cbTipo
            // 
            cbTipo.DropDownStyle=ComboBoxStyle.DropDownList;
            cbTipo.FormattingEnabled=true;
            cbTipo.Items.AddRange(new object[] { "Cel", "Fixo", "Outro" });
            cbTipo.Location=new Point(170, 37);
            cbTipo.Name="cbTipo";
            cbTipo.Size=new Size(67, 23);
            cbTipo.TabIndex=34;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(6, 19);
            label3.Name="label3";
            label3.Size=new Size(51, 15);
            label3.TabIndex=9;
            label3.Text="Telefone";
            // 
            // txtTelefone
            // 
            txtTelefone.Location=new Point(45, 37);
            txtTelefone.Name="txtTelefone";
            txtTelefone.PlaceholderText="TELEFONE";
            txtTelefone.Size=new Size(119, 23);
            txtTelefone.TabIndex=8;
            // 
            // dtpDataNasc
            // 
            dtpDataNasc.Format=DateTimePickerFormat.Short;
            dtpDataNasc.Location=new Point(6, 109);
            dtpDataNasc.Name="dtpDataNasc";
            dtpDataNasc.Size=new Size(131, 23);
            dtpDataNasc.TabIndex=16;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(6, 91);
            label2.Name="label2";
            label2.Size=new Size(96, 15);
            label2.TabIndex=18;
            label2.Text="Data nascimento";
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(3, 47);
            label1.Name="label1";
            label1.Size=new Size(28, 15);
            label1.TabIndex=17;
            label1.Text="CPF";
            // 
            // txtCPF
            // 
            txtCPF.Location=new Point(6, 65);
            txtCPF.Name="txtCPF";
            txtCPF.PlaceholderText="CPF";
            txtCPF.Size=new Size(237, 23);
            txtCPF.TabIndex=15;
            // 
            // lblNome
            // 
            lblNome.AutoSize=true;
            lblNome.Location=new Point(6, 3);
            lblNome.Name="lblNome";
            lblNome.Size=new Size(40, 15);
            lblNome.TabIndex=14;
            lblNome.Text="Nome";
            // 
            // txtNome
            // 
            txtNome.Location=new Point(6, 21);
            txtNome.Name="txtNome";
            txtNome.PlaceholderText="NOME";
            txtNome.Size=new Size(237, 23);
            txtNome.TabIndex=13;
            // 
            // textBox4
            // 
            textBox4.Font=new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location=new Point(12, 66);
            textBox4.Name="textBox4";
            textBox4.PlaceholderText="Pesquisar";
            textBox4.Size=new Size(354, 35);
            textBox4.TabIndex=24;
            // 
            // button3
            // 
            button3.Image=(Image)resources.GetObject("button3.Image");
            button3.Location=new Point(208, 630);
            button3.Name="button3";
            button3.Size=new Size(74, 38);
            button3.TabIndex=27;
            button3.Text="Alterar";
            button3.TextImageRelation=TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor=true;
            button3.Click+=button3_Click_1;
            // 
            // btnExcluir
            // 
            btnExcluir.Image=(Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.Location=new Point(128, 630);
            btnExcluir.Name="btnExcluir";
            btnExcluir.Size=new Size(74, 38);
            btnExcluir.TabIndex=30;
            btnExcluir.Text="Excluir";
            btnExcluir.TextImageRelation=TextImageRelation.ImageAboveText;
            btnExcluir.UseVisualStyleBackColor=true;
            btnExcluir.Click+=btnExcluir_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Image=(Image)resources.GetObject("btnAdicionar.Image");
            btnAdicionar.Location=new Point(288, 630);
            btnAdicionar.Name="btnAdicionar";
            btnAdicionar.Size=new Size(74, 38);
            btnAdicionar.TabIndex=31;
            btnAdicionar.Text="Salvar";
            btnAdicionar.TextImageRelation=TextImageRelation.ImageAboveText;
            btnAdicionar.UseVisualStyleBackColor=true;
            btnAdicionar.Click+=button5_Click;
            // 
            // label10
            // 
            label10.AutoSize=true;
            label10.Location=new Point(382, 37);
            label10.Name="label10";
            label10.Size=new Size(44, 15);
            label10.TabIndex=32;
            label10.Text="label10";
            // 
            // pictureBox2
            // 
            pictureBox2.Image=Properties.Resources.arrow_back_FILL0_wght400_GRAD0_opsz48;
            pictureBox2.Location=new Point(12, 12);
            pictureBox2.Name="pictureBox2";
            pictureBox2.Size=new Size(48, 48);
            pictureBox2.SizeMode=PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex=35;
            pictureBox2.TabStop=false;
            pictureBox2.Click+=pictureBox2_Click;
            pictureBox2.MouseLeave+=pictureBox2_MouseLeave;
            pictureBox2.MouseHover+=pictureBox2_MouseHover;
            // 
            // lblSaudacao
            // 
            lblSaudacao.AutoSize=true;
            lblSaudacao.Font=new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaudacao.Location=new Point(66, 13);
            lblSaudacao.Name="lblSaudacao";
            lblSaudacao.Size=new Size(200, 45);
            lblSaudacao.TabIndex=34;
            lblSaudacao.Text="Funcionários";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbInfos);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location=new Point(12, 247);
            tabControl1.Name="tabControl1";
            tabControl1.SelectedIndex=0;
            tabControl1.Size=new Size(354, 377);
            tabControl1.TabIndex=36;
            tabControl1.SelectedIndexChanged+=tabControl1_SelectedIndexChanged;
            // 
            // tbInfos
            // 
            tbInfos.Controls.Add(label11);
            tbInfos.Controls.Add(cbSexo);
            tbInfos.Controls.Add(txtNome);
            tbInfos.Controls.Add(dtpDataNasc);
            tbInfos.Controls.Add(cbEstado_civil);
            tbInfos.Controls.Add(label2);
            tbInfos.Controls.Add(lblNome);
            tbInfos.Controls.Add(label1);
            tbInfos.Controls.Add(txtCPF);
            tbInfos.Controls.Add(label5);
            tbInfos.Controls.Add(groupBox1);
            tbInfos.Location=new Point(4, 24);
            tbInfos.Name="tbInfos";
            tbInfos.Padding=new Padding(3);
            tbInfos.Size=new Size(346, 349);
            tbInfos.TabIndex=0;
            tbInfos.Text="Dados Pessoais";
            tbInfos.UseVisualStyleBackColor=true;
            // 
            // label11
            // 
            label11.AutoSize=true;
            label11.Location=new Point(6, 135);
            label11.Name="label11";
            label11.Size=new Size(32, 15);
            label11.TabIndex=36;
            label11.Text="Sexo";
            // 
            // cbSexo
            // 
            cbSexo.DropDownStyle=ComboBoxStyle.DropDownList;
            cbSexo.FormattingEnabled=true;
            cbSexo.Items.AddRange(new object[] { "M", "F", "O" });
            cbSexo.Location=new Point(6, 153);
            cbSexo.Name="cbSexo";
            cbSexo.Size=new Size(131, 23);
            cbSexo.TabIndex=35;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtComplemento);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(cbLogr);
            tabPage1.Controls.Add(txtBairro);
            tabPage1.Controls.Add(cbEstado);
            tabPage1.Controls.Add(txtNum);
            tabPage1.Controls.Add(txtCEP);
            tabPage1.Controls.Add(txtCidade);
            tabPage1.Controls.Add(txtRua);
            tabPage1.Location=new Point(4, 24);
            tabPage1.Name="tabPage1";
            tabPage1.Padding=new Padding(3);
            tabPage1.Size=new Size(346, 349);
            tabPage1.TabIndex=2;
            tabPage1.Text="Informações de Contato";
            tabPage1.UseVisualStyleBackColor=true;
            tabPage1.Click+=tabPage1_Click;
            // 
            // txtComplemento
            // 
            txtComplemento.Location=new Point(6, 35);
            txtComplemento.Name="txtComplemento";
            txtComplemento.PlaceholderText="COMPLEMENTO";
            txtComplemento.Size=new Size(135, 23);
            txtComplemento.TabIndex=38;
            // 
            // label12
            // 
            label12.AutoSize=true;
            label12.Location=new Point(6, 9);
            label12.Name="label12";
            label12.Size=new Size(69, 15);
            label12.TabIndex=37;
            label12.Text="Logradouro";
            // 
            // cbLogr
            // 
            cbLogr.DropDownStyle=ComboBoxStyle.DropDownList;
            cbLogr.FormattingEnabled=true;
            cbLogr.Items.AddRange(new object[] { "Rua", "Avenida", "Travessa" });
            cbLogr.Location=new Point(80, 6);
            cbLogr.Name="cbLogr";
            cbLogr.Size=new Size(61, 23);
            cbLogr.TabIndex=22;
            // 
            // txtBairro
            // 
            txtBairro.Location=new Point(147, 35);
            txtBairro.Name="txtBairro";
            txtBairro.PlaceholderText="BAIRRO";
            txtBairro.Size=new Size(100, 23);
            txtBairro.TabIndex=5;
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled=true;
            cbEstado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbEstado.Location=new Point(112, 64);
            cbEstado.Name="cbEstado";
            cbEstado.Size=new Size(46, 23);
            cbEstado.TabIndex=4;
            // 
            // txtNum
            // 
            txtNum.Location=new Point(150, 93);
            txtNum.Name="txtNum";
            txtNum.PlaceholderText="NÚMERO";
            txtNum.Size=new Size(100, 23);
            txtNum.TabIndex=3;
            // 
            // txtCEP
            // 
            txtCEP.Location=new Point(150, 122);
            txtCEP.Name="txtCEP";
            txtCEP.PlaceholderText="CEP";
            txtCEP.Size=new Size(100, 23);
            txtCEP.TabIndex=2;
            txtCEP.TextChanged+=txtCEP_TextChanged;
            // 
            // txtCidade
            // 
            txtCidade.Location=new Point(6, 64);
            txtCidade.Name="txtCidade";
            txtCidade.PlaceholderText="CIDADE";
            txtCidade.Size=new Size(100, 23);
            txtCidade.TabIndex=1;
            // 
            // txtRua
            // 
            txtRua.Location=new Point(147, 6);
            txtRua.Name="txtRua";
            txtRua.PlaceholderText="NOME";
            txtRua.Size=new Size(100, 23);
            txtRua.TabIndex=0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(chbConv_odon);
            tabPage2.Controls.Add(chbConv_med);
            tabPage2.Controls.Add(txtLogin);
            tabPage2.Controls.Add(txtSenha);
            tabPage2.Controls.Add(txtMatricula);
            tabPage2.Controls.Add(chbAdm);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(chbAtivo);
            tabPage2.Controls.Add(txtCargo);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(txtSalario);
            tabPage2.Controls.Add(dtpDtAdm);
            tabPage2.Controls.Add(label8);
            tabPage2.Location=new Point(4, 24);
            tabPage2.Name="tabPage2";
            tabPage2.Padding=new Padding(3);
            tabPage2.Size=new Size(346, 349);
            tabPage2.TabIndex=1;
            tabPage2.Text="Dados Profissionais";
            tabPage2.UseVisualStyleBackColor=true;
            // 
            // chbConv_odon
            // 
            chbConv_odon.AutoSize=true;
            chbConv_odon.Location=new Point(186, 324);
            chbConv_odon.Name="chbConv_odon";
            chbConv_odon.Size=new Size(154, 19);
            chbConv_odon.TabIndex=32;
            chbConv_odon.Text="Convênio Odontológico";
            chbConv_odon.UseVisualStyleBackColor=true;
            // 
            // chbConv_med
            // 
            chbConv_med.AutoSize=true;
            chbConv_med.Location=new Point(186, 299);
            chbConv_med.Name="chbConv_med";
            chbConv_med.Size=new Size(120, 19);
            chbConv_med.TabIndex=31;
            chbConv_med.Text="Convênio Médico";
            chbConv_med.UseVisualStyleBackColor=true;
            // 
            // txtLogin
            // 
            txtLogin.Location=new Point(18, 134);
            txtLogin.Name="txtLogin";
            txtLogin.PlaceholderText="LOGIN";
            txtLogin.Size=new Size(131, 23);
            txtLogin.TabIndex=30;
            // 
            // txtSenha
            // 
            txtSenha.Location=new Point(155, 134);
            txtSenha.Name="txtSenha";
            txtSenha.PasswordChar='•';
            txtSenha.PlaceholderText="SENHA";
            txtSenha.Size=new Size(149, 23);
            txtSenha.TabIndex=29;
            // 
            // txtMatricula
            // 
            txtMatricula.Location=new Point(18, 105);
            txtMatricula.Name="txtMatricula";
            txtMatricula.PlaceholderText="MATRICULA";
            txtMatricula.Size=new Size(191, 23);
            txtMatricula.TabIndex=28;
            // 
            // label13
            // 
            label13.AutoSize=true;
            label13.Location=new Point(170, 19);
            label13.Name="label13";
            label13.Size=new Size(30, 15);
            label13.TabIndex=35;
            label13.Text="Tipo";
            // 
            // cadUsuario
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.White;
            ClientSize=new Size(376, 680);
            Controls.Add(tabControl1);
            Controls.Add(pictureBox2);
            Controls.Add(lblSaudacao);
            Controls.Add(label10);
            Controls.Add(btnAdicionar);
            Controls.Add(btnExcluir);
            Controls.Add(button3);
            Controls.Add(textBox4);
            Controls.Add(dgUsuarios);
            FormBorderStyle=FormBorderStyle.None;
            MaximizeBox=false;
            MinimizeBox=false;
            Name="cadUsuario";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Cadastrar Funcionários";
            Load+=cadUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabControl1.ResumeLayout(false);
            tbInfos.ResumeLayout(false);
            tbInfos.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgUsuarios;
        private GroupBox groupBox2;
        private ComboBox cbEstado_civil;
        private Label label5;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtTelefone;
        private DateTimePicker dtpDataNasc;
        private Label label2;
        private Label label1;
        private TextBox txtCPF;
        private Label lblNome;
        private TextBox txtNome;
        private GroupBox groupBox3;
        private CheckBox checkBox1;
        private GroupBox groupBox4;
        private Label label6;
        private NumericUpDown numericUpDown1;
        private TextBox textBox4;
        private CheckBox chbAdm;
        private CheckBox chbAtivo;
        private Label label9;
        private DateTimePicker dtpDtAdm;
        private Label label8;
        private TextBox txtSalario;
        private Label label7;
        private TextBox txtCargo;
        private Button button3;
        private Button btnExcluir;
        private Button btnAdicionar;
        private Label label10;
        private PictureBox pictureBox2;
        private Label lblSaudacao;
        private TabControl tabControl1;
        private TabPage tbInfos;
        private TabPage tabPage2;
        private ComboBox cbTipo;
        private TextBox txtDDD;
        private TabPage tabPage1;
        private ComboBox cbEstado;
        private TextBox txtNum;
        private TextBox txtCEP;
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
    }
}
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
            dgUsuarios = new DataGridView();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            label9 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label8 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            dtpDataNasc = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            txtCPF = new TextBox();
            lblNome = new Label();
            txtNome = new TextBox();
            textBox4 = new TextBox();
            button3 = new Button();
            btnExcluir = new Button();
            btnAdicionar = new Button();
            label10 = new Label();
            btnDependentes = new Button();
            pictureBox2 = new PictureBox();
            lblSaudacao = new Label();
            tabControl1 = new TabControl();
            tbInfos = new TabPage();
            tabPage2 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabControl1.SuspendLayout();
            tbInfos.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // dgUsuarios
            // 
            dgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUsuarios.Location = new Point(12, 107);
            dgUsuarios.MultiSelect = false;
            dgUsuarios.Name = "dgUsuarios";
            dgUsuarios.ReadOnly = true;
            dgUsuarios.RowTemplate.Height = 25;
            dgUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgUsuarios.Size = new Size(368, 112);
            dgUsuarios.TabIndex = 6;
            dgUsuarios.CellClick += dgUsuarios_CellClick;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(215, 80);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(102, 19);
            checkBox3.TabIndex = 27;
            checkBox3.Text = "Administrador";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(155, 80);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(54, 19);
            checkBox2.TabIndex = 25;
            checkBox2.Text = "Ativo";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 57);
            label9.Name = "label9";
            label9.Size = new Size(86, 15);
            label9.TabIndex = 26;
            label9.Text = "Data Admissão";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(18, 75);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(131, 23);
            dateTimePicker2.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(215, 13);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 15;
            label8.Text = "Salário Base";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(215, 31);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "R$";
            textBox6.Size = new Size(131, 23);
            textBox6.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 13);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 13;
            label7.Text = "Cargo";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(18, 31);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "CARGO";
            textBox5.Size = new Size(191, 23);
            textBox5.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Solteiro (a)", "Casado (a)", "Viúvo (a)", "Divorciado (a)" });
            comboBox1.Location = new Point(159, 129);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(191, 23);
            comboBox1.TabIndex = 21;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(159, 111);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 20;
            label5.Text = "Estado Civil";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(22, 166);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(328, 77);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Contato e Endereço";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(131, 19);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 11;
            label4.Text = "E-mail";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(131, 37);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "E-MAIL";
            textBox3.Size = new Size(151, 23);
            textBox3.TabIndex = 10;
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
            // textBox2
            // 
            textBox2.Location = new Point(6, 37);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "TELEFONE";
            textBox2.Size = new Size(119, 23);
            textBox2.TabIndex = 8;
            // 
            // dtpDataNasc
            // 
            dtpDataNasc.Format = DateTimePickerFormat.Short;
            dtpDataNasc.Location = new Point(22, 129);
            dtpDataNasc.Name = "dtpDataNasc";
            dtpDataNasc.Size = new Size(131, 23);
            dtpDataNasc.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 111);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 18;
            label2.Text = "Data nascimento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 64);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 17;
            label1.Text = "CPF";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(113, 82);
            txtCPF.Name = "txtCPF";
            txtCPF.PlaceholderText = "CPF";
            txtCPF.Size = new Size(237, 23);
            txtCPF.TabIndex = 15;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(113, 20);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 14;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(113, 38);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "NOME";
            txtNome.Size = new Size(237, 23);
            txtNome.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(12, 66);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Pesquisar";
            textBox4.Size = new Size(368, 35);
            textBox4.TabIndex = 24;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(398, 249);
            button3.Name = "button3";
            button3.Size = new Size(74, 74);
            button3.TabIndex = 27;
            button3.Text = "Alterar";
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.Location = new Point(398, 331);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(74, 74);
            btnExcluir.TabIndex = 30;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Image = (Image)resources.GetObject("btnAdicionar.Image");
            btnAdicionar.Location = new Point(398, 411);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(74, 74);
            btnAdicionar.TabIndex = 31;
            btnAdicionar.Text = "Salvar";
            btnAdicionar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += button5_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(322, 48);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 32;
            label10.Text = "label10";
            // 
            // btnDependentes
            // 
            btnDependentes.Location = new Point(254, 249);
            btnDependentes.Name = "btnDependentes";
            btnDependentes.Size = new Size(96, 23);
            btnDependentes.TabIndex = 33;
            btnDependentes.Text = "Dependentes";
            btnDependentes.UseVisualStyleBackColor = true;
            btnDependentes.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            pictureBox2.MouseHover += pictureBox2_MouseHover;
            // 
            // lblSaudacao
            // 
            lblSaudacao.AutoSize = true;
            lblSaudacao.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaudacao.Location = new Point(66, 13);
            lblSaudacao.Name = "lblSaudacao";
            lblSaudacao.Size = new Size(200, 45);
            lblSaudacao.TabIndex = 34;
            lblSaudacao.Text = "Funcionários";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbInfos);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 225);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(384, 313);
            tabControl1.TabIndex = 36;
            // 
            // tbInfos
            // 
            tbInfos.Controls.Add(pictureBox1);
            tbInfos.Controls.Add(txtNome);
            tbInfos.Controls.Add(dtpDataNasc);
            tbInfos.Controls.Add(btnDependentes);
            tbInfos.Controls.Add(comboBox1);
            tbInfos.Controls.Add(label2);
            tbInfos.Controls.Add(lblNome);
            tbInfos.Controls.Add(label1);
            tbInfos.Controls.Add(txtCPF);
            tbInfos.Controls.Add(label5);
            tbInfos.Controls.Add(groupBox1);
            tbInfos.Location = new Point(4, 24);
            tbInfos.Name = "tbInfos";
            tbInfos.Padding = new Padding(3);
            tbInfos.Size = new Size(376, 285);
            tbInfos.TabIndex = 0;
            tbInfos.Text = "Dados Pessoais";
            tbInfos.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(checkBox3);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(checkBox2);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(dateTimePicker2);
            tabPage2.Controls.Add(label8);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(613, 360);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Dados Profissionais";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cadUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(524, 574);
            Controls.Add(tabControl1);
            Controls.Add(pictureBox2);
            Controls.Add(lblSaudacao);
            Controls.Add(label10);
            Controls.Add(btnAdicionar);
            Controls.Add(btnExcluir);
            Controls.Add(button3);
            Controls.Add(textBox4);
            Controls.Add(dgUsuarios);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "cadUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Usuário";
            Load += cadUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabControl1.ResumeLayout(false);
            tbInfos.ResumeLayout(false);
            tbInfos.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgUsuarios;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private Label label5;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
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
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private Label label9;
        private DateTimePicker dateTimePicker2;
        private Label label8;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox5;
        private Button button3;
        private Button btnExcluir;
        private Button btnAdicionar;
        private Label label10;
        private Button btnDependentes;
        private PictureBox pictureBox2;
        private Label lblSaudacao;
        private TabControl tabControl1;
        private TabPage tbInfos;
        private TabPage tabPage2;
    }
}
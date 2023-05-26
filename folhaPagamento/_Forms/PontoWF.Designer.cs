namespace folhaPagamento
{
    partial class PontoWF
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
            txtCPF = new TextBox();
            txtNome = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox2 = new PictureBox();
            lblSaudacao = new Label();
            dgRegistro = new DataGridView();
            panel1 = new Panel();
            btnCarregarInfos = new Button();
            btnMinhasConfig = new Button();
            btnMeuPerfil = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgRegistro).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtCPF
            // 
            txtCPF.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCPF.Location = new Point(6, 26);
            txtCPF.Name = "txtCPF";
            txtCPF.PlaceholderText = "CPF Funcionário";
            txtCPF.Size = new Size(233, 23);
            txtCPF.TabIndex = 1;
            txtCPF.TextAlign = HorizontalAlignment.Center;
            txtCPF.TextChanged += txtCPF_TextChanged;
            txtCPF.KeyPress += txtCPF_KeyPress_1;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(248, 26);
            txtNome.Name = "txtNome";
            txtNome.ReadOnly = true;
            txtNome.Size = new Size(240, 23);
            txtNome.TabIndex = 1;
            txtNome.Text = "Nome Funcionário";
            txtNome.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.arrow_back_FILL0_wght400_GRAD0_opsz48;
            pictureBox2.Location = new Point(12, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 37;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // lblSaudacao
            // 
            lblSaudacao.AutoSize = true;
            lblSaudacao.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaudacao.Location = new Point(45, 13);
            lblSaudacao.Name = "lblSaudacao";
            lblSaudacao.Size = new Size(168, 25);
            lblSaudacao.TabIndex = 36;
            lblSaudacao.Text = "Histórico de ponto";
            // 
            // dgRegistro
            // 
            dgRegistro.AllowUserToAddRows = false;
            dgRegistro.AllowUserToDeleteRows = false;
            dgRegistro.AllowUserToResizeColumns = false;
            dgRegistro.AllowUserToResizeRows = false;
            dgRegistro.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgRegistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgRegistro.Location = new Point(18, 132);
            dgRegistro.MultiSelect = false;
            dgRegistro.Name = "dgRegistro";
            dgRegistro.ReadOnly = true;
            dgRegistro.RowTemplate.Height = 25;
            dgRegistro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgRegistro.Size = new Size(482, 204);
            dgRegistro.TabIndex = 39;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(196, 196, 196);
            panel1.Controls.Add(btnCarregarInfos);
            panel1.Controls.Add(btnMinhasConfig);
            panel1.Controls.Add(btnMeuPerfil);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(lblSaudacao);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(518, 51);
            panel1.TabIndex = 40;
            // 
            // btnCarregarInfos
            // 
            btnCarregarInfos.Anchor = AnchorStyles.Right;
            btnCarregarInfos.BackColor = Color.White;
            btnCarregarInfos.FlatStyle = FlatStyle.Flat;
            btnCarregarInfos.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCarregarInfos.ForeColor = Color.FromArgb(62, 122, 232);
            btnCarregarInfos.ImageAlign = ContentAlignment.MiddleLeft;
            btnCarregarInfos.Location = new Point(365, 9);
            btnCarregarInfos.Name = "btnCarregarInfos";
            btnCarregarInfos.Size = new Size(139, 29);
            btnCarregarInfos.TabIndex = 42;
            btnCarregarInfos.Text = "Carregar informações";
            btnCarregarInfos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCarregarInfos.UseVisualStyleBackColor = false;
            btnCarregarInfos.Click += btnCarregarInfos_Click;
            // 
            // btnMinhasConfig
            // 
            btnMinhasConfig.Anchor = AnchorStyles.Right;
            btnMinhasConfig.BackColor = Color.White;
            btnMinhasConfig.FlatStyle = FlatStyle.Flat;
            btnMinhasConfig.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinhasConfig.ForeColor = Color.FromArgb(62, 122, 232);
            btnMinhasConfig.ImageAlign = ContentAlignment.MiddleLeft;
            btnMinhasConfig.Location = new Point(1132, 1);
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
            btnMeuPerfil.Location = new Point(1000, 1);
            btnMeuPerfil.Name = "btnMeuPerfil";
            btnMeuPerfil.Size = new Size(126, 29);
            btnMeuPerfil.TabIndex = 18;
            btnMeuPerfil.Text = "Meu perfil";
            btnMeuPerfil.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMeuPerfil.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCPF);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Location = new Point(12, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(494, 55);
            groupBox1.TabIndex = 41;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pesquisar funcionário";
            // 
            // PontoWF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 246, 246);
            ClientSize = new Size(518, 426);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(dgRegistro);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PontoWF";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Histórico de ponto";
            Load += ponto_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgRegistro).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtCPF;
        private TextBox txtNome;
        private System.Windows.Forms.Timer timer1;
        private ToolTip ttTxtCPF;
        private PictureBox pictureBox2;
        private Label lblSaudacao;
        private DataGridView dgRegistro;
        private Panel panel1;
        private Button btnMinhasConfig;
        private Button btnMeuPerfil;
        private Button btnCarregarInfos;
        private GroupBox groupBox1;
    }
}
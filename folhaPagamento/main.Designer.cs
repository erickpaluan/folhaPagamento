namespace folhaPagamento
{
    partial class main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            btnMarcarPonto = new Button();
            btnHolerite = new Button();
            btnFuncionários = new Button();
            btnConfig = new Button();
            lblSaudacao = new Label();
            pictureBox1 = new PictureBox();
            btnSairdoSistema = new Button();
            btnEmpresa = new Button();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnMarcarPonto
            // 
            btnMarcarPonto.Image = (Image)resources.GetObject("btnMarcarPonto.Image");
            btnMarcarPonto.Location = new Point(12, 98);
            btnMarcarPonto.Name = "btnMarcarPonto";
            btnMarcarPonto.Size = new Size(96, 96);
            btnMarcarPonto.TabIndex = 2;
            btnMarcarPonto.Text = "Marcar Ponto";
            btnMarcarPonto.TextAlign = ContentAlignment.BottomCenter;
            btnMarcarPonto.UseVisualStyleBackColor = true;
            btnMarcarPonto.Click += btnMarcarPonto_Click;
            // 
            // btnHolerite
            // 
            btnHolerite.Image = (Image)resources.GetObject("btnHolerite.Image");
            btnHolerite.Location = new Point(114, 98);
            btnHolerite.Name = "btnHolerite";
            btnHolerite.Size = new Size(96, 96);
            btnHolerite.TabIndex = 3;
            btnHolerite.Text = "Holerite";
            btnHolerite.TextAlign = ContentAlignment.BottomCenter;
            btnHolerite.UseVisualStyleBackColor = true;
            btnHolerite.Click += btnHolerite_Click;
            // 
            // btnFuncionários
            // 
            btnFuncionários.Image = (Image)resources.GetObject("btnFuncionários.Image");
            btnFuncionários.Location = new Point(216, 98);
            btnFuncionários.Name = "btnFuncionários";
            btnFuncionários.Size = new Size(96, 96);
            btnFuncionários.TabIndex = 4;
            btnFuncionários.Text = "Funcionários";
            btnFuncionários.TextAlign = ContentAlignment.BottomCenter;
            btnFuncionários.UseVisualStyleBackColor = true;
            btnFuncionários.Click += btnFuncionários_Click;
            // 
            // btnConfig
            // 
            btnConfig.Image = (Image)resources.GetObject("btnConfig.Image");
            btnConfig.Location = new Point(420, 98);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(96, 96);
            btnConfig.TabIndex = 5;
            btnConfig.Text = "Configurações";
            btnConfig.TextAlign = ContentAlignment.BottomCenter;
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += btnConfig_Click;
            // 
            // lblSaudacao
            // 
            lblSaudacao.AutoSize = true;
            lblSaudacao.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaudacao.Location = new Point(66, 25);
            lblSaudacao.Name = "lblSaudacao";
            lblSaudacao.Size = new Size(226, 45);
            lblSaudacao.TabIndex = 6;
            lblSaudacao.Text = "Bom dia, Erick.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnSairdoSistema
            // 
            btnSairdoSistema.Image = Properties.Resources.arrow_back_FILL0_wght400_GRAD0_opsz48;
            btnSairdoSistema.ImageAlign = ContentAlignment.MiddleLeft;
            btnSairdoSistema.Location = new Point(12, 296);
            btnSairdoSistema.Name = "btnSairdoSistema";
            btnSairdoSistema.Size = new Size(141, 52);
            btnSairdoSistema.TabIndex = 9;
            btnSairdoSistema.Text = "Sair do Sistema";
            btnSairdoSistema.TextAlign = ContentAlignment.MiddleRight;
            btnSairdoSistema.UseVisualStyleBackColor = true;
            btnSairdoSistema.Click += btnSairdoSistema_Click;
            // 
            // btnEmpresa
            // 
            btnEmpresa.Image = Properties.Resources.store_FILL0_wght400_GRAD0_opsz48;
            btnEmpresa.Location = new Point(318, 98);
            btnEmpresa.Name = "btnEmpresa";
            btnEmpresa.Size = new Size(96, 96);
            btnEmpresa.TabIndex = 11;
            btnEmpresa.Text = "Empresa";
            btnEmpresa.TextAlign = ContentAlignment.BottomCenter;
            btnEmpresa.UseVisualStyleBackColor = true;
            btnEmpresa.Click += btnEmpresa_Click;
            // 
            // btnLogout
            // 
            btnLogout.Image = Properties.Resources.logout_FILL0_wght400_GRAD0_opsz48;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(451, 296);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(136, 52);
            btnLogout.TabIndex = 12;
            btnLogout.Text = "Fazer Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleRight;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(599, 360);
            Controls.Add(btnLogout);
            Controls.Add(btnEmpresa);
            Controls.Add(btnSairdoSistema);
            Controls.Add(pictureBox1);
            Controls.Add(lblSaudacao);
            Controls.Add(btnConfig);
            Controls.Add(btnFuncionários);
            Controls.Add(btnHolerite);
            Controls.Add(btnMarcarPonto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Folha Pagamento";
            Load += main_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnMarcarPonto;
        private Button btnHolerite;
        private Button btnFuncionários;
        private Button btnConfig;
        private Label lblSaudacao;
        private PictureBox pictureBox1;
        private Button button5;
        private Button btnSairdoSistema;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem testeToolStripMenuItem;
        private ToolStripMenuItem sairDoSistemaToolStripMenuItem;
        private Button btnEmpresa;
        private Button btnLogout;
    }
}
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
            btnFuncionários = new Button();
            btnConfig = new Button();
            lblSaudacao = new Label();
            pictureBox1 = new PictureBox();
            btnSairdoSistema = new Button();
            btnEmpresa = new Button();
            btnLogout = new Button();
            btnMarcarPonto = new PictureBox();
            this.btnHolerite = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMarcarPonto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.btnHolerite).BeginInit();
            SuspendLayout();
            // 
            // btnFuncionários
            // 
            btnFuncionários.Image = (Image)resources.GetObject("btnFuncionários.Image");
            btnFuncionários.Location = new Point(94, 399);
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
            btnConfig.Location = new Point(196, 501);
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
            lblSaudacao.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaudacao.Location = new Point(12, 63);
            lblSaudacao.Name = "lblSaudacao";
            lblSaudacao.Size = new Size(168, 32);
            lblSaudacao.TabIndex = 6;
            lblSaudacao.Text = "Bom dia, Erick.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
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
            btnSairdoSistema.Location = new Point(12, 616);
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
            btnEmpresa.Location = new Point(196, 399);
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
            btnLogout.Location = new Point(228, 616);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(136, 52);
            btnLogout.TabIndex = 12;
            btnLogout.Text = "Fazer Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleRight;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnMarcarPonto
            // 
            btnMarcarPonto.Image = Properties.Resources.ponto;
            btnMarcarPonto.Location = new Point(12, 171);
            btnMarcarPonto.Name = "btnMarcarPonto";
            btnMarcarPonto.Size = new Size(170, 120);
            btnMarcarPonto.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMarcarPonto.TabIndex = 13;
            btnMarcarPonto.TabStop = false;
            btnMarcarPonto.Click += btnMarcarPonto_Click_1;
            // 
            // btnHolerite
            // 
            this.btnHolerite.Image = Properties.Resources.holerite1;
            this.btnHolerite.Location = new Point(194, 171);
            this.btnHolerite.Name = "btnHolerite";
            this.btnHolerite.Size = new Size(170, 120);
            this.btnHolerite.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnHolerite.TabIndex = 14;
            this.btnHolerite.TabStop = false;
            this.btnHolerite.Click += this.btnHolerite_Click_1;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(376, 680);
            Controls.Add(this.btnHolerite);
            Controls.Add(btnMarcarPonto);
            Controls.Add(btnLogout);
            Controls.Add(btnEmpresa);
            Controls.Add(btnSairdoSistema);
            Controls.Add(pictureBox1);
            Controls.Add(lblSaudacao);
            Controls.Add(btnConfig);
            Controls.Add(btnFuncionários);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Folha Pagamento";
            Load += main_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMarcarPonto).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.btnHolerite).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private PictureBox btnMarcarPonto;
        private PictureBox btnHolerite;
    }
}
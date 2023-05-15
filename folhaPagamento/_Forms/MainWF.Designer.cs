namespace folhaPagamento
{
    partial class MainWF
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWF));
            btnConfig = new Button();
            lblSaudacao = new Label();
            pictureBox1 = new PictureBox();
            btnMarcarPonto = new PictureBox();
            btnHolerite = new PictureBox();
            contextMenuStrip2 = new ContextMenuStrip(components);
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            fazerLogoutToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripMenuItem2 = new ToolStripMenuItem();
            btnFuncionarios = new PictureBox();
            btnEmpresa = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMarcarPonto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHolerite).BeginInit();
            contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnFuncionarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEmpresa).BeginInit();
            SuspendLayout();
            // 
            // btnConfig
            // 
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.Image = Properties.Resources.menu_2_fill;
            btnConfig.Location = new Point(351, 393);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(48, 48);
            btnConfig.TabIndex = 5;
            btnConfig.TextAlign = ContentAlignment.BottomCenter;
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += btnConfig_Click;
            // 
            // lblSaudacao
            // 
            lblSaudacao.AutoSize = true;
            lblSaudacao.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaudacao.Location = new Point(66, 21);
            lblSaudacao.Name = "lblSaudacao";
            lblSaudacao.Size = new Size(148, 30);
            lblSaudacao.TabIndex = 6;
            lblSaudacao.Text = "Bom dia, Erick.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fp;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnMarcarPonto
            // 
            btnMarcarPonto.Image = Properties.Resources.ponto;
            btnMarcarPonto.Location = new Point(12, 100);
            btnMarcarPonto.Name = "btnMarcarPonto";
            btnMarcarPonto.Size = new Size(188, 128);
            btnMarcarPonto.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMarcarPonto.TabIndex = 13;
            btnMarcarPonto.TabStop = false;
            btnMarcarPonto.Click += btnMarcarPonto_Click_1;
            // 
            // btnHolerite
            // 
            btnHolerite.Image = Properties.Resources.holerite1;
            btnHolerite.Location = new Point(211, 100);
            btnHolerite.Name = "btnHolerite";
            btnHolerite.Size = new Size(188, 128);
            btnHolerite.SizeMode = PictureBoxSizeMode.StretchImage;
            btnHolerite.TabIndex = 14;
            btnHolerite.TabStop = false;
            btnHolerite.Click += btnHolerite_Click_1;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { configuraçõesToolStripMenuItem, toolStripSeparator1, fazerLogoutToolStripMenuItem, toolStripSeparator2, toolStripMenuItem2 });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(155, 82);
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.Enabled = false;
            configuraçõesToolStripMenuItem.Image = Properties.Resources.settings_FILL0_wght400_GRAD0_opsz48;
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(154, 22);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            configuraçõesToolStripMenuItem.Click += configuraçõesToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(151, 6);
            // 
            // fazerLogoutToolStripMenuItem
            // 
            fazerLogoutToolStripMenuItem.Image = Properties.Resources.logout_FILL0_wght400_GRAD0_opsz48;
            fazerLogoutToolStripMenuItem.Name = "fazerLogoutToolStripMenuItem";
            fazerLogoutToolStripMenuItem.Size = new Size(154, 22);
            fazerLogoutToolStripMenuItem.Text = "Fazer Logout";
            fazerLogoutToolStripMenuItem.Click += fazerLogoutToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(151, 6);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(154, 22);
            toolStripMenuItem2.Text = "Sair do Sistema";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // btnFuncionarios
            // 
            btnFuncionarios.Image = Properties.Resources.funcionarios;
            btnFuncionarios.Location = new Point(12, 234);
            btnFuncionarios.Name = "btnFuncionarios";
            btnFuncionarios.Size = new Size(188, 128);
            btnFuncionarios.SizeMode = PictureBoxSizeMode.StretchImage;
            btnFuncionarios.TabIndex = 15;
            btnFuncionarios.TabStop = false;
            btnFuncionarios.Click += btnFuncionarios_Click;
            // 
            // btnEmpresa
            // 
            btnEmpresa.Image = Properties.Resources.empresa;
            btnEmpresa.Location = new Point(211, 234);
            btnEmpresa.Name = "btnEmpresa";
            btnEmpresa.Size = new Size(188, 128);
            btnEmpresa.SizeMode = PictureBoxSizeMode.StretchImage;
            btnEmpresa.TabIndex = 16;
            btnEmpresa.TabStop = false;
            btnEmpresa.Click += btnEmpresa_Click_1;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(411, 453);
            ControlBox = false;
            Controls.Add(btnEmpresa);
            Controls.Add(btnFuncionarios);
            Controls.Add(btnHolerite);
            Controls.Add(btnMarcarPonto);
            Controls.Add(pictureBox1);
            Controls.Add(lblSaudacao);
            Controls.Add(btnConfig);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Folha Pagamento";
            Load += main_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMarcarPonto).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHolerite).EndInit();
            contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnFuncionarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEmpresa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnConfig;
        private Label lblSaudacao;
        private PictureBox pictureBox1;
        private Button button5;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem testeToolStripMenuItem;
        private ToolStripMenuItem sairDoSistemaToolStripMenuItem;
        private PictureBox btnMarcarPonto;
        private PictureBox btnHolerite;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem fazerLogoutToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem toolStripMenuItem2;
        private PictureBox btnFuncionarios;
        private PictureBox btnEmpresa;
    }
}
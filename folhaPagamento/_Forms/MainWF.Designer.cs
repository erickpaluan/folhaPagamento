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
            btnHolerite = new PictureBox();
            contextMenuStrip2 = new ContextMenuStrip(components);
            toolStripMenuItem2 = new ToolStripMenuItem();
            btnFuncionarios = new PictureBox();
            btnEmpresa = new PictureBox();
            panel1 = new Panel();
            linkFazerLogout = new LinkLabel();
            btnMinhasConfig = new Button();
            btnMeuPerfil = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            btnFazerMarcacao = new Button();
            panel4 = new Panel();
            label4 = new Label();
            panel5 = new Panel();
            label5 = new Label();
            panel6 = new Panel();
            label6 = new Label();
            panel7 = new Panel();
            label7 = new Label();
            panel8 = new Panel();
            label8 = new Label();
            panel9 = new Panel();
            label9 = new Label();
            panel3 = new Panel();
            label10 = new Label();
            label3 = new Label();
            label2 = new Label();
            llblRegistros = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHolerite).BeginInit();
            contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnFuncionarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEmpresa).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnConfig
            // 
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.Image = Properties.Resources.menu_2_fill;
            btnConfig.Location = new Point(931, 26);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(29, 29);
            btnConfig.TabIndex = 5;
            btnConfig.TextAlign = ContentAlignment.BottomCenter;
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += btnConfig_Click;
            // 
            // lblSaudacao
            // 
            lblSaudacao.AutoSize = true;
            lblSaudacao.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaudacao.Location = new Point(69, 16);
            lblSaudacao.Name = "lblSaudacao";
            lblSaudacao.Size = new Size(134, 25);
            lblSaudacao.TabIndex = 6;
            lblSaudacao.Text = "Bom dia, Erick.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.person_FILL0_wght400_GRAD0_opsz48;
            pictureBox1.Location = new Point(15, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnHolerite
            // 
            btnHolerite.Image = Properties.Resources.holerite1;
            btnHolerite.Location = new Point(12, 460);
            btnHolerite.Name = "btnHolerite";
            btnHolerite.Size = new Size(219, 161);
            btnHolerite.SizeMode = PictureBoxSizeMode.StretchImage;
            btnHolerite.TabIndex = 14;
            btnHolerite.TabStop = false;
            btnHolerite.Click += btnHolerite_Click_1;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem2 });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(155, 26);
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
            btnFuncionarios.Location = new Point(462, 460);
            btnFuncionarios.Name = "btnFuncionarios";
            btnFuncionarios.Size = new Size(219, 161);
            btnFuncionarios.SizeMode = PictureBoxSizeMode.StretchImage;
            btnFuncionarios.TabIndex = 15;
            btnFuncionarios.TabStop = false;
            btnFuncionarios.Click += btnFuncionarios_Click;
            // 
            // btnEmpresa
            // 
            btnEmpresa.Image = Properties.Resources.empresa;
            btnEmpresa.Location = new Point(237, 460);
            btnEmpresa.Name = "btnEmpresa";
            btnEmpresa.Size = new Size(219, 161);
            btnEmpresa.SizeMode = PictureBoxSizeMode.StretchImage;
            btnEmpresa.TabIndex = 16;
            btnEmpresa.TabStop = false;
            btnEmpresa.Click += btnEmpresa_Click_1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(213, 228, 254);
            panel1.Controls.Add(linkFazerLogout);
            panel1.Controls.Add(btnMinhasConfig);
            panel1.Controls.Add(lblSaudacao);
            panel1.Controls.Add(btnMeuPerfil);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnConfig);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(968, 80);
            panel1.TabIndex = 17;
            // 
            // linkFazerLogout
            // 
            linkFazerLogout.ActiveLinkColor = Color.FromArgb(229, 60, 60);
            linkFazerLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            linkFazerLogout.AutoSize = true;
            linkFazerLogout.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            linkFazerLogout.LinkBehavior = LinkBehavior.HoverUnderline;
            linkFazerLogout.LinkColor = Color.FromArgb(234, 70, 126);
            linkFazerLogout.Location = new Point(69, 49);
            linkFazerLogout.Name = "linkFazerLogout";
            linkFazerLogout.Size = new Size(73, 15);
            linkFazerLogout.TabIndex = 23;
            linkFazerLogout.TabStop = true;
            linkFazerLogout.Text = "Fazer logout";
            linkFazerLogout.LinkClicked += linkFazerLogout_LinkClicked;
            // 
            // btnMinhasConfig
            // 
            btnMinhasConfig.Anchor = AnchorStyles.Right;
            btnMinhasConfig.BackColor = Color.White;
            btnMinhasConfig.FlatStyle = FlatStyle.Flat;
            btnMinhasConfig.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinhasConfig.ForeColor = Color.FromArgb(62, 122, 232);
            btnMinhasConfig.ImageAlign = ContentAlignment.MiddleLeft;
            btnMinhasConfig.Location = new Point(654, 26);
            btnMinhasConfig.Name = "btnMinhasConfig";
            btnMinhasConfig.Size = new Size(139, 29);
            btnMinhasConfig.TabIndex = 19;
            btnMinhasConfig.Text = "Configurações";
            btnMinhasConfig.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMinhasConfig.UseVisualStyleBackColor = false;
            btnMinhasConfig.Click += btnMinhasConfig_Click;
            // 
            // btnMeuPerfil
            // 
            btnMeuPerfil.Anchor = AnchorStyles.Right;
            btnMeuPerfil.BackColor = Color.FromArgb(62, 122, 232);
            btnMeuPerfil.FlatStyle = FlatStyle.Flat;
            btnMeuPerfil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMeuPerfil.ForeColor = Color.White;
            btnMeuPerfil.ImageAlign = ContentAlignment.MiddleLeft;
            btnMeuPerfil.Location = new Point(799, 26);
            btnMeuPerfil.Name = "btnMeuPerfil";
            btnMeuPerfil.Size = new Size(126, 29);
            btnMeuPerfil.TabIndex = 18;
            btnMeuPerfil.Text = "Meu perfil";
            btnMeuPerfil.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMeuPerfil.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(50, 104);
            label1.Name = "label1";
            label1.Size = new Size(119, 21);
            label1.TabIndex = 18;
            label1.Text = "Meus registros";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.badge_FILL0_wght400_GRAD0_opsz48;
            pictureBox2.Location = new Point(12, 98);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnFazerMarcacao);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(968, 261);
            panel2.TabIndex = 21;
            // 
            // btnFazerMarcacao
            // 
            btnFazerMarcacao.BackColor = Color.FromArgb(62, 122, 232);
            btnFazerMarcacao.FlatStyle = FlatStyle.Flat;
            btnFazerMarcacao.ForeColor = Color.White;
            btnFazerMarcacao.Location = new Point(786, 211);
            btnFazerMarcacao.Name = "btnFazerMarcacao";
            btnFazerMarcacao.Size = new Size(174, 47);
            btnFazerMarcacao.TabIndex = 26;
            btnFazerMarcacao.Text = "Fazer marcação";
            btnFazerMarcacao.UseVisualStyleBackColor = false;
            btnFazerMarcacao.Click += btnFazerMarcacao_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(label4);
            panel4.Location = new Point(144, 46);
            panel4.Name = "panel4";
            panel4.Size = new Size(131, 159);
            panel4.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 5);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 27;
            label4.Text = "Segunda-feira";
            // 
            // panel5
            // 
            panel5.Controls.Add(label5);
            panel5.Location = new Point(281, 46);
            panel5.Name = "panel5";
            panel5.Size = new Size(131, 159);
            panel5.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 5);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 28;
            label5.Text = "Terça-feira";
            // 
            // panel6
            // 
            panel6.Controls.Add(label6);
            panel6.Location = new Point(418, 46);
            panel6.Name = "panel6";
            panel6.Size = new Size(131, 159);
            panel6.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 5);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 29;
            label6.Text = "Quarta-feira";
            // 
            // panel7
            // 
            panel7.Controls.Add(label7);
            panel7.Location = new Point(555, 46);
            panel7.Name = "panel7";
            panel7.Size = new Size(131, 159);
            panel7.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(3, 5);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 30;
            label7.Text = "Quinta-feira";
            // 
            // panel8
            // 
            panel8.Controls.Add(label8);
            panel8.Location = new Point(692, 46);
            panel8.Name = "panel8";
            panel8.Size = new Size(131, 159);
            panel8.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(3, 5);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 31;
            label8.Text = "Sexta-feira";
            // 
            // panel9
            // 
            panel9.Controls.Add(label9);
            panel9.Location = new Point(829, 46);
            panel9.Name = "panel9";
            panel9.Size = new Size(131, 159);
            panel9.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(3, 5);
            label9.Name = "label9";
            label9.Size = new Size(47, 15);
            label9.TabIndex = 32;
            label9.Text = "Sábado";
            // 
            // panel3
            // 
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(7, 46);
            panel3.Name = "panel3";
            panel3.Size = new Size(131, 159);
            panel3.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 20);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 27;
            label10.Text = "label10";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 5);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 26;
            label3.Text = "Domingo";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(7, 6);
            label2.Name = "label2";
            label2.Size = new Size(158, 21);
            label2.TabIndex = 23;
            label2.Text = "Meu horário semanal";
            // 
            // llblRegistros
            // 
            llblRegistros.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            llblRegistros.AutoSize = true;
            llblRegistros.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            llblRegistros.LinkBehavior = LinkBehavior.HoverUnderline;
            llblRegistros.LinkColor = Color.FromArgb(62, 122, 232);
            llblRegistros.Location = new Point(854, 107);
            llblRegistros.Name = "llblRegistros";
            llblRegistros.Size = new Size(126, 19);
            llblRegistros.TabIndex = 22;
            llblRegistros.TabStop = true;
            llblRegistros.Text = "Histórico de ponto";
            llblRegistros.LinkClicked += llblRegistros_LinkClicked;
            // 
            // MainWF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 245, 247);
            ClientSize = new Size(992, 633);
            ControlBox = false;
            Controls.Add(llblRegistros);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnEmpresa);
            Controls.Add(btnFuncionarios);
            Controls.Add(btnHolerite);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainWF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Folha Pagamento";
            Load += main_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHolerite).EndInit();
            contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnFuncionarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEmpresa).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private PictureBox btnHolerite;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem toolStripMenuItem2;
        private PictureBox btnFuncionarios;
        private PictureBox btnEmpresa;
        private Panel panel1;
        private Button btnMeuPerfil;
        private Button btnMinhasConfig;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private LinkLabel llblRegistros;
        private Label label2;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel3;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnFazerMarcacao;
        private Label label10;
        private LinkLabel linkFazerLogout;
    }
}
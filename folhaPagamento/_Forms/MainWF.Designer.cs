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
            components=new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWF));
            btnConfig=new Button();
            lblSaudacao=new Label();
            pictureBox1=new PictureBox();
            btnHolerite=new PictureBox();
            contextMenuStrip2=new ContextMenuStrip(components);
            configuraçõesToolStripMenuItem=new ToolStripMenuItem();
            toolStripSeparator1=new ToolStripSeparator();
            fazerLogoutToolStripMenuItem=new ToolStripMenuItem();
            toolStripSeparator2=new ToolStripSeparator();
            toolStripMenuItem2=new ToolStripMenuItem();
            btnFuncionarios=new PictureBox();
            btnEmpresa=new PictureBox();
            panel1=new Panel();
            btnMinhasConfig=new Button();
            btnMeuPerfil=new Button();
            label1=new Label();
            pictureBox2=new PictureBox();
            panel2=new Panel();
            label2=new Label();
            llblRegistros=new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHolerite).BeginInit();
            contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnFuncionarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEmpresa).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnConfig
            // 
            btnConfig.FlatAppearance.BorderSize=0;
            btnConfig.FlatStyle=FlatStyle.Flat;
            btnConfig.Image=Properties.Resources.menu_2_fill;
            btnConfig.Location=new Point(819, 304);
            btnConfig.Name="btnConfig";
            btnConfig.Size=new Size(48, 48);
            btnConfig.TabIndex=5;
            btnConfig.TextAlign=ContentAlignment.BottomCenter;
            btnConfig.UseVisualStyleBackColor=true;
            btnConfig.Click+=btnConfig_Click;
            // 
            // lblSaudacao
            // 
            lblSaudacao.AutoSize=true;
            lblSaudacao.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaudacao.Location=new Point(69, 16);
            lblSaudacao.Name="lblSaudacao";
            lblSaudacao.Size=new Size(134, 25);
            lblSaudacao.TabIndex=6;
            lblSaudacao.Text="Bom dia, Erick.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image=Properties.Resources.person_FILL0_wght400_GRAD0_opsz48;
            pictureBox1.Location=new Point(15, 16);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(48, 48);
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex=7;
            pictureBox1.TabStop=false;
            // 
            // btnHolerite
            // 
            btnHolerite.Image=Properties.Resources.holerite1;
            btnHolerite.Location=new Point(12, 304);
            btnHolerite.Name="btnHolerite";
            btnHolerite.Size=new Size(219, 132);
            btnHolerite.SizeMode=PictureBoxSizeMode.StretchImage;
            btnHolerite.TabIndex=14;
            btnHolerite.TabStop=false;
            btnHolerite.Click+=btnHolerite_Click_1;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { configuraçõesToolStripMenuItem, toolStripSeparator1, fazerLogoutToolStripMenuItem, toolStripSeparator2, toolStripMenuItem2 });
            contextMenuStrip2.Name="contextMenuStrip2";
            contextMenuStrip2.Size=new Size(155, 82);
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.Image=Properties.Resources.settings_FILL0_wght400_GRAD0_opsz48;
            configuraçõesToolStripMenuItem.Name="configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size=new Size(154, 22);
            configuraçõesToolStripMenuItem.Text="Configurações";
            configuraçõesToolStripMenuItem.Click+=configuraçõesToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name="toolStripSeparator1";
            toolStripSeparator1.Size=new Size(151, 6);
            // 
            // fazerLogoutToolStripMenuItem
            // 
            fazerLogoutToolStripMenuItem.Image=Properties.Resources.logout_FILL0_wght400_GRAD0_opsz48;
            fazerLogoutToolStripMenuItem.Name="fazerLogoutToolStripMenuItem";
            fazerLogoutToolStripMenuItem.Size=new Size(154, 22);
            fazerLogoutToolStripMenuItem.Text="Fazer Logout";
            fazerLogoutToolStripMenuItem.Click+=fazerLogoutToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name="toolStripSeparator2";
            toolStripSeparator2.Size=new Size(151, 6);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name="toolStripMenuItem2";
            toolStripMenuItem2.Size=new Size(154, 22);
            toolStripMenuItem2.Text="Sair do Sistema";
            toolStripMenuItem2.Click+=toolStripMenuItem2_Click;
            // 
            // btnFuncionarios
            // 
            btnFuncionarios.Image=Properties.Resources.funcionarios;
            btnFuncionarios.Location=new Point(462, 304);
            btnFuncionarios.Name="btnFuncionarios";
            btnFuncionarios.Size=new Size(219, 132);
            btnFuncionarios.SizeMode=PictureBoxSizeMode.StretchImage;
            btnFuncionarios.TabIndex=15;
            btnFuncionarios.TabStop=false;
            btnFuncionarios.Click+=btnFuncionarios_Click;
            // 
            // btnEmpresa
            // 
            btnEmpresa.Image=Properties.Resources.empresa;
            btnEmpresa.Location=new Point(237, 304);
            btnEmpresa.Name="btnEmpresa";
            btnEmpresa.Size=new Size(219, 132);
            btnEmpresa.SizeMode=PictureBoxSizeMode.StretchImage;
            btnEmpresa.TabIndex=16;
            btnEmpresa.TabStop=false;
            btnEmpresa.Click+=btnEmpresa_Click_1;
            // 
            // panel1
            // 
            panel1.Anchor=AnchorStyles.Top|AnchorStyles.Left|AnchorStyles.Right;
            panel1.BackColor=Color.FromArgb(213, 228, 254);
            panel1.Controls.Add(btnMinhasConfig);
            panel1.Controls.Add(lblSaudacao);
            panel1.Controls.Add(btnMeuPerfil);
            panel1.Controls.Add(pictureBox1);
            panel1.Location=new Point(12, 12);
            panel1.Name="panel1";
            panel1.Size=new Size(858, 80);
            panel1.TabIndex=17;
            // 
            // btnMinhasConfig
            // 
            btnMinhasConfig.Anchor=AnchorStyles.Right;
            btnMinhasConfig.BackColor=Color.White;
            btnMinhasConfig.FlatStyle=FlatStyle.Flat;
            btnMinhasConfig.Font=new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinhasConfig.ForeColor=Color.FromArgb(62, 122, 232);
            btnMinhasConfig.ImageAlign=ContentAlignment.MiddleLeft;
            btnMinhasConfig.Location=new Point(704, 26);
            btnMinhasConfig.Name="btnMinhasConfig";
            btnMinhasConfig.Size=new Size(139, 29);
            btnMinhasConfig.TabIndex=19;
            btnMinhasConfig.Text="Minhas configurações";
            btnMinhasConfig.TextImageRelation=TextImageRelation.ImageBeforeText;
            btnMinhasConfig.UseVisualStyleBackColor=false;
            // 
            // btnMeuPerfil
            // 
            btnMeuPerfil.Anchor=AnchorStyles.Right;
            btnMeuPerfil.BackColor=Color.FromArgb(62, 122, 232);
            btnMeuPerfil.FlatStyle=FlatStyle.Flat;
            btnMeuPerfil.Font=new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMeuPerfil.ForeColor=Color.White;
            btnMeuPerfil.ImageAlign=ContentAlignment.MiddleLeft;
            btnMeuPerfil.Location=new Point(572, 26);
            btnMeuPerfil.Name="btnMeuPerfil";
            btnMeuPerfil.Size=new Size(126, 29);
            btnMeuPerfil.TabIndex=18;
            btnMeuPerfil.Text="Meu perfil";
            btnMeuPerfil.TextImageRelation=TextImageRelation.ImageBeforeText;
            btnMeuPerfil.UseVisualStyleBackColor=false;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(50, 104);
            label1.Name="label1";
            label1.Size=new Size(119, 21);
            label1.TabIndex=18;
            label1.Text="Meus registros";
            // 
            // pictureBox2
            // 
            pictureBox2.Image=Properties.Resources.badge_FILL0_wght400_GRAD0_opsz48;
            pictureBox2.Location=new Point(12, 98);
            pictureBox2.Name="pictureBox2";
            pictureBox2.Size=new Size(32, 32);
            pictureBox2.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex=20;
            pictureBox2.TabStop=false;
            // 
            // panel2
            // 
            panel2.Anchor=AnchorStyles.Top|AnchorStyles.Left|AnchorStyles.Right;
            panel2.BackColor=Color.White;
            panel2.Controls.Add(label2);
            panel2.Location=new Point(12, 136);
            panel2.Name="panel2";
            panel2.Size=new Size(858, 162);
            panel2.TabIndex=21;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location=new Point(7, 6);
            label2.Name="label2";
            label2.Size=new Size(158, 21);
            label2.TabIndex=23;
            label2.Text="Meu horário semanal";
            // 
            // llblRegistros
            // 
            llblRegistros.Anchor=AnchorStyles.Top|AnchorStyles.Right;
            llblRegistros.AutoSize=true;
            llblRegistros.Font=new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            llblRegistros.LinkBehavior=LinkBehavior.HoverUnderline;
            llblRegistros.LinkColor=Color.FromArgb(62, 122, 232);
            llblRegistros.Location=new Point(754, 107);
            llblRegistros.Name="llblRegistros";
            llblRegistros.Size=new Size(116, 19);
            llblRegistros.TabIndex=22;
            llblRegistros.TabStop=true;
            llblRegistros.Text="Mostrar registros";
            llblRegistros.LinkClicked+=llblRegistros_LinkClicked;
            // 
            // MainWF
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.FromArgb(243, 245, 247);
            ClientSize=new Size(882, 474);
            Controls.Add(llblRegistros);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnEmpresa);
            Controls.Add(btnFuncionarios);
            Controls.Add(btnHolerite);
            Controls.Add(btnConfig);
            Icon=(Icon)resources.GetObject("$this.Icon");
            MaximizeBox=false;
            Name="MainWF";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Folha Pagamento";
            Load+=main_Load;
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
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem fazerLogoutToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
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
    }
}
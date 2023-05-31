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
            toolStripMenuItem2=new ToolStripMenuItem();
            btnFuncionarios=new PictureBox();
            btnEmpresa=new PictureBox();
            panel1=new Panel();
            linkFazerLogout=new LinkLabel();
            btnMinhasConfig=new Button();
            btnMeuPerfil=new Button();
            label1=new Label();
            pictureBox2=new PictureBox();
            panel2=new Panel();
            panelSegunda=new Panel();
            lblSegunda=new Label();
            panelTerca=new Panel();
            lblTerca=new Label();
            panelQuarta=new Panel();
            lblQuarta=new Label();
            panelQuinta=new Panel();
            lblQuinta=new Label();
            panelSexta=new Panel();
            lblSexta=new Label();
            panelSabado=new Panel();
            lblSabado=new Label();
            btnFazerMarcacao=new Button();
            panelDomingo=new Panel();
            lblDomingo=new Label();
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
            panelSegunda.SuspendLayout();
            panelTerca.SuspendLayout();
            panelQuarta.SuspendLayout();
            panelQuinta.SuspendLayout();
            panelSexta.SuspendLayout();
            panelSabado.SuspendLayout();
            panelDomingo.SuspendLayout();
            SuspendLayout();
            // 
            // btnConfig
            // 
            btnConfig.FlatAppearance.BorderSize=0;
            btnConfig.FlatStyle=FlatStyle.Flat;
            btnConfig.Image=Properties.Resources.menu_2_fill;
            btnConfig.Location=new Point(931, 26);
            btnConfig.Name="btnConfig";
            btnConfig.Size=new Size(29, 29);
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
            btnHolerite.Location=new Point(12, 460);
            btnHolerite.Name="btnHolerite";
            btnHolerite.Size=new Size(219, 161);
            btnHolerite.SizeMode=PictureBoxSizeMode.StretchImage;
            btnHolerite.TabIndex=14;
            btnHolerite.TabStop=false;
            btnHolerite.Click+=btnHolerite_Click_1;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem2 });
            contextMenuStrip2.Name="contextMenuStrip2";
            contextMenuStrip2.Size=new Size(155, 26);
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
            btnFuncionarios.Location=new Point(462, 460);
            btnFuncionarios.Name="btnFuncionarios";
            btnFuncionarios.Size=new Size(219, 161);
            btnFuncionarios.SizeMode=PictureBoxSizeMode.StretchImage;
            btnFuncionarios.TabIndex=15;
            btnFuncionarios.TabStop=false;
            btnFuncionarios.Click+=btnFuncionarios_Click;
            // 
            // btnEmpresa
            // 
            btnEmpresa.Image=Properties.Resources.empresa;
            btnEmpresa.Location=new Point(237, 460);
            btnEmpresa.Name="btnEmpresa";
            btnEmpresa.Size=new Size(219, 161);
            btnEmpresa.SizeMode=PictureBoxSizeMode.StretchImage;
            btnEmpresa.TabIndex=16;
            btnEmpresa.TabStop=false;
            btnEmpresa.Click+=btnEmpresa_Click_1;
            // 
            // panel1
            // 
            panel1.Anchor=AnchorStyles.Top|AnchorStyles.Left|AnchorStyles.Right;
            panel1.BackColor=Color.FromArgb(213, 228, 254);
            panel1.Controls.Add(linkFazerLogout);
            panel1.Controls.Add(btnMinhasConfig);
            panel1.Controls.Add(lblSaudacao);
            panel1.Controls.Add(btnMeuPerfil);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnConfig);
            panel1.Location=new Point(12, 12);
            panel1.Name="panel1";
            panel1.Size=new Size(968, 80);
            panel1.TabIndex=17;
            // 
            // linkFazerLogout
            // 
            linkFazerLogout.ActiveLinkColor=Color.FromArgb(229, 60, 60);
            linkFazerLogout.Anchor=AnchorStyles.Top|AnchorStyles.Right;
            linkFazerLogout.AutoSize=true;
            linkFazerLogout.Font=new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            linkFazerLogout.LinkBehavior=LinkBehavior.HoverUnderline;
            linkFazerLogout.LinkColor=Color.FromArgb(234, 70, 126);
            linkFazerLogout.Location=new Point(69, 49);
            linkFazerLogout.Name="linkFazerLogout";
            linkFazerLogout.Size=new Size(73, 15);
            linkFazerLogout.TabIndex=23;
            linkFazerLogout.TabStop=true;
            linkFazerLogout.Text="Fazer logout";
            linkFazerLogout.LinkClicked+=linkFazerLogout_LinkClicked;
            // 
            // btnMinhasConfig
            // 
            btnMinhasConfig.Anchor=AnchorStyles.Right;
            btnMinhasConfig.BackColor=Color.White;
            btnMinhasConfig.FlatStyle=FlatStyle.Flat;
            btnMinhasConfig.Font=new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinhasConfig.ForeColor=Color.FromArgb(62, 122, 232);
            btnMinhasConfig.ImageAlign=ContentAlignment.MiddleLeft;
            btnMinhasConfig.Location=new Point(654, 26);
            btnMinhasConfig.Name="btnMinhasConfig";
            btnMinhasConfig.Size=new Size(139, 29);
            btnMinhasConfig.TabIndex=19;
            btnMinhasConfig.Text="Configurações";
            btnMinhasConfig.TextImageRelation=TextImageRelation.ImageBeforeText;
            btnMinhasConfig.UseVisualStyleBackColor=false;
            btnMinhasConfig.Click+=btnMinhasConfig_Click;
            // 
            // btnMeuPerfil
            // 
            btnMeuPerfil.Anchor=AnchorStyles.Right;
            btnMeuPerfil.BackColor=Color.FromArgb(62, 122, 232);
            btnMeuPerfil.FlatStyle=FlatStyle.Flat;
            btnMeuPerfil.Font=new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMeuPerfil.ForeColor=Color.White;
            btnMeuPerfil.ImageAlign=ContentAlignment.MiddleLeft;
            btnMeuPerfil.Location=new Point(799, 26);
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
            panel2.Controls.Add(panelSegunda);
            panel2.Controls.Add(panelTerca);
            panel2.Controls.Add(panelQuarta);
            panel2.Controls.Add(panelQuinta);
            panel2.Controls.Add(panelSexta);
            panel2.Controls.Add(panelSabado);
            panel2.Controls.Add(btnFazerMarcacao);
            panel2.Controls.Add(panelDomingo);
            panel2.Controls.Add(label2);
            panel2.Location=new Point(12, 136);
            panel2.Name="panel2";
            panel2.Size=new Size(968, 261);
            panel2.TabIndex=21;
            // 
            // panelSegunda
            // 
            panelSegunda.Controls.Add(lblSegunda);
            panelSegunda.Location=new Point(144, 30);
            panelSegunda.Name="panelSegunda";
            panelSegunda.Size=new Size(131, 159);
            panelSegunda.TabIndex=26;
            // 
            // lblSegunda
            // 
            lblSegunda.AutoSize=true;
            lblSegunda.Location=new Point(3, 10);
            lblSegunda.Name="lblSegunda";
            lblSegunda.Size=new Size(38, 15);
            lblSegunda.TabIndex=28;
            lblSegunda.Text="label3";
            // 
            // panelTerca
            // 
            panelTerca.Controls.Add(lblTerca);
            panelTerca.Location=new Point(281, 30);
            panelTerca.Name="panelTerca";
            panelTerca.Size=new Size(131, 159);
            panelTerca.TabIndex=26;
            // 
            // lblTerca
            // 
            lblTerca.AutoSize=true;
            lblTerca.Location=new Point(3, 10);
            lblTerca.Name="lblTerca";
            lblTerca.Size=new Size(38, 15);
            lblTerca.TabIndex=29;
            lblTerca.Text="label3";
            // 
            // panelQuarta
            // 
            panelQuarta.Controls.Add(lblQuarta);
            panelQuarta.Location=new Point(418, 30);
            panelQuarta.Name="panelQuarta";
            panelQuarta.Size=new Size(131, 159);
            panelQuarta.TabIndex=26;
            // 
            // lblQuarta
            // 
            lblQuarta.AutoSize=true;
            lblQuarta.Location=new Point(3, 10);
            lblQuarta.Name="lblQuarta";
            lblQuarta.Size=new Size(38, 15);
            lblQuarta.TabIndex=30;
            lblQuarta.Text="label3";
            // 
            // panelQuinta
            // 
            panelQuinta.Controls.Add(lblQuinta);
            panelQuinta.Location=new Point(555, 30);
            panelQuinta.Name="panelQuinta";
            panelQuinta.Size=new Size(131, 159);
            panelQuinta.TabIndex=26;
            // 
            // lblQuinta
            // 
            lblQuinta.AutoSize=true;
            lblQuinta.Location=new Point(3, 10);
            lblQuinta.Name="lblQuinta";
            lblQuinta.Size=new Size(38, 15);
            lblQuinta.TabIndex=31;
            lblQuinta.Text="label3";
            // 
            // panelSexta
            // 
            panelSexta.Controls.Add(lblSexta);
            panelSexta.Location=new Point(692, 30);
            panelSexta.Name="panelSexta";
            panelSexta.Size=new Size(131, 159);
            panelSexta.TabIndex=26;
            // 
            // lblSexta
            // 
            lblSexta.AutoSize=true;
            lblSexta.Location=new Point(3, 10);
            lblSexta.Name="lblSexta";
            lblSexta.Size=new Size(38, 15);
            lblSexta.TabIndex=32;
            lblSexta.Text="label3";
            // 
            // panelSabado
            // 
            panelSabado.Controls.Add(lblSabado);
            panelSabado.Location=new Point(829, 30);
            panelSabado.Name="panelSabado";
            panelSabado.Size=new Size(131, 159);
            panelSabado.TabIndex=26;
            // 
            // lblSabado
            // 
            lblSabado.AutoSize=true;
            lblSabado.Location=new Point(3, 10);
            lblSabado.Name="lblSabado";
            lblSabado.Size=new Size(38, 15);
            lblSabado.TabIndex=33;
            lblSabado.Text="label3";
            // 
            // btnFazerMarcacao
            // 
            btnFazerMarcacao.BackColor=Color.FromArgb(62, 122, 232);
            btnFazerMarcacao.FlatStyle=FlatStyle.Flat;
            btnFazerMarcacao.ForeColor=Color.White;
            btnFazerMarcacao.Location=new Point(786, 211);
            btnFazerMarcacao.Name="btnFazerMarcacao";
            btnFazerMarcacao.Size=new Size(174, 47);
            btnFazerMarcacao.TabIndex=26;
            btnFazerMarcacao.Text="Fazer marcação";
            btnFazerMarcacao.UseVisualStyleBackColor=false;
            btnFazerMarcacao.Click+=btnFazerMarcacao_Click;
            // 
            // panelDomingo
            // 
            panelDomingo.Controls.Add(lblDomingo);
            panelDomingo.Location=new Point(7, 30);
            panelDomingo.Name="panelDomingo";
            panelDomingo.Size=new Size(131, 159);
            panelDomingo.TabIndex=25;
            // 
            // lblDomingo
            // 
            lblDomingo.AutoSize=true;
            lblDomingo.Location=new Point(3, 10);
            lblDomingo.Name="lblDomingo";
            lblDomingo.Size=new Size(38, 15);
            lblDomingo.TabIndex=27;
            lblDomingo.Text="label3";
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
            llblRegistros.Location=new Point(854, 107);
            llblRegistros.Name="llblRegistros";
            llblRegistros.Size=new Size(126, 19);
            llblRegistros.TabIndex=22;
            llblRegistros.TabStop=true;
            llblRegistros.Text="Histórico de ponto";
            llblRegistros.LinkClicked+=llblRegistros_LinkClicked;
            // 
            // MainWF
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.FromArgb(243, 245, 247);
            ClientSize=new Size(992, 633);
            ControlBox=false;
            Controls.Add(llblRegistros);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnEmpresa);
            Controls.Add(btnFuncionarios);
            Controls.Add(btnHolerite);
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
            panelSegunda.ResumeLayout(false);
            panelSegunda.PerformLayout();
            panelTerca.ResumeLayout(false);
            panelTerca.PerformLayout();
            panelQuarta.ResumeLayout(false);
            panelQuarta.PerformLayout();
            panelQuinta.ResumeLayout(false);
            panelQuinta.PerformLayout();
            panelSexta.ResumeLayout(false);
            panelSexta.PerformLayout();
            panelSabado.ResumeLayout(false);
            panelSabado.PerformLayout();
            panelDomingo.ResumeLayout(false);
            panelDomingo.PerformLayout();
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
        private Panel panelDomingo;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel3;

        private Button btnFazerMarcacao;
        private Label label10;
        private LinkLabel linkFazerLogout;
        private Panel panelSegunda;
        private Label lblSegunda;
        private Panel panelTerca;
        private Label lblTerca;
        private Panel panelQuarta;
        private Label lblQuarta;
        private Panel panelQuinta;
        private Label lblQuinta;
        private Panel panelSexta;
        private Label lblSexta;
        private Panel panelSabado;
        private Label lblSabado;
        private Label lblDomingo;
    }
}
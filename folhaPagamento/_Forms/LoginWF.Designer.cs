namespace folhaPagamento
{
    partial class LoginWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWF));
            txtUsuario=new TextBox();
            txtSenha=new TextBox();
            btnLogin=new Button();
            lblSaudacao=new Label();
            pictureBox1=new PictureBox();
            checkBox1=new CheckBox();
            linkLabel1=new LinkLabel();
            label1=new Label();
            label2=new Label();
            panel1=new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Font=new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location=new Point(62, 107);
            txtUsuario.Name="txtUsuario";
            txtUsuario.PlaceholderText="Digite seu usuário";
            txtUsuario.Size=new Size(218, 21);
            txtUsuario.TabIndex=1;
            txtUsuario.KeyDown+=txtUsuario_KeyDown;
            // 
            // txtSenha
            // 
            txtSenha.Font=new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location=new Point(62, 168);
            txtSenha.Name="txtSenha";
            txtSenha.PlaceholderText="Digite sua senha";
            txtSenha.Size=new Size(218, 21);
            txtSenha.TabIndex=3;
            txtSenha.KeyDown+=txtSenha_KeyDown;
            // 
            // btnLogin
            // 
            btnLogin.BackColor=Color.FromArgb(11, 115, 183);
            btnLogin.FlatStyle=FlatStyle.Flat;
            btnLogin.Font=new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor=Color.White;
            btnLogin.Location=new Point(58, 237);
            btnLogin.Name="btnLogin";
            btnLogin.Size=new Size(227, 31);
            btnLogin.TabIndex=4;
            btnLogin.Text="Entrar no sistema";
            btnLogin.UseVisualStyleBackColor=false;
            btnLogin.Click+=btnLogin_Click;
            // 
            // lblSaudacao
            // 
            lblSaudacao.AutoSize=true;
            lblSaudacao.Font=new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSaudacao.Location=new Point(121, 21);
            lblSaudacao.Name="lblSaudacao";
            lblSaudacao.Size=new Size(101, 30);
            lblSaudacao.TabIndex=6;
            lblSaudacao.Text="Bom dia!";
            lblSaudacao.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor=Color.FromArgb(238, 242, 237);
            pictureBox1.Image=Properties.Resources._3d_construction_abstract_composition_with_lego_bricks;
            pictureBox1.Location=new Point(0, 0);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(350, 350);
            pictureBox1.SizeMode=PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex=7;
            pictureBox1.TabStop=false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize=true;
            checkBox1.BackgroundImageLayout=ImageLayout.Center;
            checkBox1.FlatStyle=FlatStyle.Flat;
            checkBox1.Location=new Point(62, 195);
            checkBox1.Name="checkBox1";
            checkBox1.Size=new Size(98, 19);
            checkBox1.TabIndex=9;
            checkBox1.Text="mostrar senha";
            checkBox1.UseVisualStyleBackColor=true;
            checkBox1.CheckedChanged+=checkBox1_CheckedChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize=true;
            linkLabel1.LinkColor=Color.Black;
            linkLabel1.Location=new Point(128, 304);
            linkLabel1.Name="linkLabel1";
            linkLabel1.Size=new Size(86, 15);
            linkLabel1.TabIndex=10;
            linkLabel1.TabStop=true;
            linkLabel1.Text="Sair do sistema";
            linkLabel1.LinkClicked+=linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(62, 84);
            label1.Name="label1";
            label1.Size=new Size(47, 15);
            label1.TabIndex=11;
            label1.Text="Usuário";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(62, 145);
            label2.Name="label2";
            label2.Size=new Size(39, 15);
            label2.TabIndex=12;
            label2.Text="Senha";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblSaudacao);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(checkBox1);
            panel1.Location=new Point(350, 0);
            panel1.Name="panel1";
            panel1.Size=new Size(350, 350);
            panel1.TabIndex=13;
            // 
            // LoginWF
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.White;
            BackgroundImageLayout=ImageLayout.Zoom;
            ClientSize=new Size(700, 350);
            ControlBox=false;
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            DoubleBuffered=true;
            FormBorderStyle=FormBorderStyle.None;
            Icon=(Icon)resources.GetObject("$this.Icon");
            Name="LoginWF";
            StartPosition=FormStartPosition.CenterScreen;
            Text="login";
            Load+=LoginWF_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btnLogin;
        private Label lblSaudacao;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
        private Label label1;
        private Label label2;
        private Panel panel1;
    }
}
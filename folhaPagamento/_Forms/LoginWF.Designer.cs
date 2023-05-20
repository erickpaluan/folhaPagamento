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
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            btnLogin = new Button();
            btnSair = new Button();
            lblSaudacao = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(398, 128);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Digite seu usuário";
            txtUsuario.Size = new Size(317, 21);
            txtUsuario.TabIndex = 1;
            txtUsuario.KeyDown += txtUsuario_KeyDown;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(398, 182);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '•';
            txtSenha.PlaceholderText = "Digite sua senha";
            txtSenha.Size = new Size(317, 21);
            txtSenha.TabIndex = 3;
            txtSenha.KeyDown += txtSenha_KeyDown;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(11, 116, 184);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(565, 322);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 36);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Fazer login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSair
            // 
            btnSair.FlatStyle = FlatStyle.System;
            btnSair.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSair.ForeColor = Color.IndianRed;
            btnSair.Location = new Point(398, 322);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(100, 36);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // lblSaudacao
            // 
            lblSaudacao.AutoSize = true;
            lblSaudacao.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSaudacao.Location = new Point(398, 43);
            lblSaudacao.Name = "lblSaudacao";
            lblSaudacao.Size = new Size(101, 30);
            lblSaudacao.TabIndex = 6;
            lblSaudacao.Text = "Bom dia!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.meditating;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(370, 370);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // LoginWF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(727, 370);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(lblSaudacao);
            Controls.Add(btnSair);
            Controls.Add(btnLogin);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginWF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            Load += LoginWF_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btnLogin;
        private Button btnSair;
        private Label lblSaudacao;
        private PictureBox pictureBox1;
    }
}
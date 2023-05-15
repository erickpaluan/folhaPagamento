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
            btnSair=new Button();
            pictureBox1=new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Font=new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location=new Point(31, 161);
            txtUsuario.Name="txtUsuario";
            txtUsuario.PlaceholderText="Usuário";
            txtUsuario.Size=new Size(317, 35);
            txtUsuario.TabIndex=1;
            txtUsuario.KeyDown+=txtUsuario_KeyDown;
            // 
            // txtSenha
            // 
            txtSenha.Font=new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location=new Point(31, 225);
            txtSenha.Name="txtSenha";
            txtSenha.PasswordChar='•';
            txtSenha.PlaceholderText="Senha";
            txtSenha.Size=new Size(317, 35);
            txtSenha.TabIndex=3;
            txtSenha.KeyDown+=txtSenha_KeyDown;
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle=FlatStyle.Flat;
            btnLogin.Font=new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor=SystemColors.MenuHighlight;
            btnLogin.Location=new Point(31, 313);
            btnLogin.Name="btnLogin";
            btnLogin.Size=new Size(317, 80);
            btnLogin.TabIndex=4;
            btnLogin.Text="Entrar no sistema";
            btnLogin.UseVisualStyleBackColor=true;
            btnLogin.Click+=btnLogin_Click;
            // 
            // btnSair
            // 
            btnSair.FlatStyle=FlatStyle.Flat;
            btnSair.Font=new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.ForeColor=Color.IndianRed;
            btnSair.Location=new Point(65, 402);
            btnSair.Name="btnSair";
            btnSair.Size=new Size(248, 57);
            btnSair.TabIndex=5;
            btnSair.Text="Sair";
            btnSair.UseVisualStyleBackColor=true;
            btnSair.Click+=btnSair_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image=Properties.Resources.logo_justax;
            pictureBox1.Location=new Point(45, 30);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(288, 82);
            pictureBox1.SizeMode=PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex=6;
            pictureBox1.TabStop=false;
            // 
            // LoginWF
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.White;
            ClientSize=new Size(378, 471);
            ControlBox=false;
            Controls.Add(pictureBox1);
            Controls.Add(btnSair);
            Controls.Add(btnLogin);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            Icon=(Icon)resources.GetObject("$this.Icon");
            Name="LoginWF";
            StartPosition=FormStartPosition.CenterScreen;
            Text="login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btnLogin;
        private Button btnSair;
        private PictureBox pictureBox1;
    }
}
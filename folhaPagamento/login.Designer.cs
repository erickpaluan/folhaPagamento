namespace folhaPagamento
{
    partial class login
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
            label1=new Label();
            txtUsuario=new TextBox();
            txtSenha=new TextBox();
            label2=new Label();
            btnLogin=new Button();
            btnSair=new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(50, 48);
            label1.Name="label1";
            label1.Size=new Size(47, 15);
            label1.TabIndex=0;
            label1.Text="Usuário";
            // 
            // txtUsuario
            // 
            txtUsuario.Location=new Point(50, 66);
            txtUsuario.Name="txtUsuario";
            txtUsuario.Size=new Size(209, 23);
            txtUsuario.TabIndex=1;
            // 
            // txtSenha
            // 
            txtSenha.Location=new Point(50, 110);
            txtSenha.Name="txtSenha";
            txtSenha.PasswordChar='*';
            txtSenha.Size=new Size(209, 23);
            txtSenha.TabIndex=3;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(50, 92);
            label2.Name="label2";
            label2.Size=new Size(39, 15);
            label2.TabIndex=2;
            label2.Text="Senha";
            // 
            // btnLogin
            // 
            btnLogin.Location=new Point(184, 139);
            btnLogin.Name="btnLogin";
            btnLogin.Size=new Size(75, 23);
            btnLogin.TabIndex=4;
            btnLogin.Text="login";
            btnLogin.UseVisualStyleBackColor=true;
            btnLogin.Click+=btnLogin_Click;
            // 
            // btnSair
            // 
            btnSair.Location=new Point(50, 139);
            btnSair.Name="btnSair";
            btnSair.Size=new Size(75, 23);
            btnSair.TabIndex=5;
            btnSair.Text="Sair";
            btnSair.UseVisualStyleBackColor=true;
            btnSair.Click+=btnSair_Click;
            // 
            // login
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(332, 222);
            ControlBox=false;
            Controls.Add(btnSair);
            Controls.Add(btnLogin);
            Controls.Add(txtSenha);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Name="login";
            StartPosition=FormStartPosition.CenterScreen;
            Text="login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Label label2;
        private Button btnLogin;
        private Button btnSair;
    }
}
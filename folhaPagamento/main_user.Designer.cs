namespace folhaPagamento
{
    partial class main_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_user));
            pictureBox1=new PictureBox();
            lblSaudacao=new Label();
            btnHolerite=new Button();
            btnPonto=new Button();
            btnConfig=new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image=(Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location=new Point(12, 12);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(48, 48);
            pictureBox1.SizeMode=PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex=9;
            pictureBox1.TabStop=false;
            // 
            // lblSaudacao
            // 
            lblSaudacao.AutoSize=true;
            lblSaudacao.Font=new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaudacao.Location=new Point(66, 15);
            lblSaudacao.Name="lblSaudacao";
            lblSaudacao.Size=new Size(226, 45);
            lblSaudacao.TabIndex=8;
            lblSaudacao.Text="Bom dia, Erick.";
            // 
            // btnHolerite
            // 
            btnHolerite.Image=(Image)resources.GetObject("btnHolerite.Image");
            btnHolerite.Location=new Point(114, 96);
            btnHolerite.Name="btnHolerite";
            btnHolerite.Size=new Size(96, 96);
            btnHolerite.TabIndex=11;
            btnHolerite.Text="Holerite";
            btnHolerite.TextAlign=ContentAlignment.BottomCenter;
            btnHolerite.UseVisualStyleBackColor=true;
            // 
            // btnPonto
            // 
            btnPonto.Image=(Image)resources.GetObject("btnPonto.Image");
            btnPonto.Location=new Point(12, 96);
            btnPonto.Name="btnPonto";
            btnPonto.Size=new Size(96, 96);
            btnPonto.TabIndex=10;
            btnPonto.Text="Marcar Ponto";
            btnPonto.TextAlign=ContentAlignment.BottomCenter;
            btnPonto.UseVisualStyleBackColor=true;
            // 
            // btnConfig
            // 
            btnConfig.Image=Properties.Resources.settings_FILL0_wght400_GRAD0_opsz48;
            btnConfig.ImageAlign=ContentAlignment.MiddleLeft;
            btnConfig.Location=new Point(12, 198);
            btnConfig.Name="btnConfig";
            btnConfig.Size=new Size(198, 57);
            btnConfig.TabIndex=12;
            btnConfig.Text="Configuraçoes";
            btnConfig.UseVisualStyleBackColor=true;
            // 
            // main_user
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(693, 413);
            Controls.Add(btnConfig);
            Controls.Add(btnHolerite);
            Controls.Add(btnPonto);
            Controls.Add(pictureBox1);
            Controls.Add(lblSaudacao);
            Name="main_user";
            Text="Folha Pagamento";
            Load+=main_user_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblSaudacao;
        private Button btnHolerite;
        private Button btnPonto;
        private Button btnConfig;
    }
}
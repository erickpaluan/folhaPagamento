namespace folhaPagamento
{
    partial class ponto
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ponto));
            txtCPF = new TextBox();
            lblData = new Label();
            label5 = new Label();
            lblHora = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            btnSalvarPonto = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox2 = new PictureBox();
            lblSaudacao = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtCPF
            // 
            txtCPF.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCPF.Location = new Point(12, 108);
            txtCPF.Name = "txtCPF";
            txtCPF.PlaceholderText = "CPF Funcionário";
            txtCPF.Size = new Size(352, 57);
            txtCPF.TabIndex = 1;
            txtCPF.TextChanged += txtCPF_TextChanged;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblData.Location = new Point(83, 475);
            lblData.Name = "lblData";
            lblData.Size = new Size(210, 50);
            lblData.TabIndex = 6;
            lblData.Text = "31/12/2023";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(168, 460);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 5;
            label5.Text = "Data";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblHora.Location = new Point(133, 364);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(110, 50);
            lblHora.TabIndex = 4;
            lblHora.Text = "00:00";
            lblHora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 349);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 3;
            label2.Text = "Hora";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(12, 241);
            txtNome.Name = "txtNome";
            txtNome.ReadOnly = true;
            txtNome.Size = new Size(352, 57);
            txtNome.TabIndex = 1;
            txtNome.Text = "Nome Funcionário";
            // 
            // btnSalvarPonto
            // 
            btnSalvarPonto.Image = (Image)resources.GetObject("btnSalvarPonto.Image");
            btnSalvarPonto.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvarPonto.Location = new Point(64, 588);
            btnSalvarPonto.Name = "btnSalvarPonto";
            btnSalvarPonto.Size = new Size(248, 80);
            btnSalvarPonto.TabIndex = 3;
            btnSalvarPonto.Text = "Salvar ponto";
            btnSalvarPonto.UseVisualStyleBackColor = true;
            btnSalvarPonto.Click += btnSalvarPonto_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.arrow_back_FILL0_wght400_GRAD0_opsz48;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 37;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // lblSaudacao
            // 
            lblSaudacao.AutoSize = true;
            lblSaudacao.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaudacao.Location = new Point(66, 13);
            lblSaudacao.Name = "lblSaudacao";
            lblSaudacao.Size = new Size(211, 45);
            lblSaudacao.TabIndex = 36;
            lblSaudacao.Text = "Marcar Ponto";
            // 
            // ponto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(376, 680);
            Controls.Add(txtNome);
            Controls.Add(lblData);
            Controls.Add(txtCPF);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(lblHora);
            Controls.Add(label2);
            Controls.Add(lblSaudacao);
            Controls.Add(btnSalvarPonto);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ponto";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ponto";
            Load += ponto_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCPF;
        private Label lblData;
        private Label label5;
        private Label lblHora;
        private Label label2;
        private TextBox txtNome;
        private Button btnSalvarPonto;
        private System.Windows.Forms.Timer timer1;
        private ToolTip ttTxtCPF;
        private PictureBox pictureBox2;
        private Label lblSaudacao;
    }
}
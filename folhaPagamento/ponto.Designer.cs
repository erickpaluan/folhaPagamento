﻿namespace folhaPagamento
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
            components=new System.ComponentModel.Container();
            txtCPF=new TextBox();
            lblData=new Label();
            lblHora=new Label();
            txtNome=new TextBox();
            btnSalvarPonto=new Button();
            timer1=new System.Windows.Forms.Timer(components);
            pictureBox2=new PictureBox();
            lblSaudacao=new Label();
            btnEU=new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtCPF
            // 
            txtCPF.Anchor=AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Right;
            txtCPF.Font=new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCPF.Location=new Point(66, 183);
            txtCPF.Name="txtCPF";
            txtCPF.PlaceholderText="CPF Funcionário";
            txtCPF.Size=new Size(526, 57);
            txtCPF.TabIndex=1;
            txtCPF.TextAlign=HorizontalAlignment.Center;
            txtCPF.TextChanged+=txtCPF_TextChanged;
            txtCPF.KeyPress+=txtCPF_KeyPress_1;
            // 
            // lblData
            // 
            lblData.Anchor=AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Right;
            lblData.AutoSize=true;
            lblData.Font=new Font("Segoe UI", 48.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblData.Location=new Point(177, 632);
            lblData.Name="lblData";
            lblData.Size=new Size(367, 87);
            lblData.TabIndex=6;
            lblData.Text="31/12/2023";
            // 
            // lblHora
            // 
            lblHora.Anchor=AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Right;
            lblHora.AutoSize=true;
            lblHora.Font=new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lblHora.Location=new Point(272, 481);
            lblHora.Name="lblHora";
            lblHora.Size=new Size(191, 86);
            lblHora.TabIndex=4;
            lblHora.Text="00:00";
            lblHora.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // txtNome
            // 
            txtNome.Anchor=AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Right;
            txtNome.Font=new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location=new Point(66, 316);
            txtNome.Name="txtNome";
            txtNome.ReadOnly=true;
            txtNome.Size=new Size(589, 57);
            txtNome.TabIndex=1;
            txtNome.Text="Nome Funcionário";
            txtNome.TextAlign=HorizontalAlignment.Center;
            // 
            // btnSalvarPonto
            // 
            btnSalvarPonto.Anchor=AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Right;
            btnSalvarPonto.AutoSize=true;
            btnSalvarPonto.FlatStyle=FlatStyle.Flat;
            btnSalvarPonto.Font=new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvarPonto.ForeColor=Color.ForestGreen;
            btnSalvarPonto.ImageAlign=ContentAlignment.MiddleLeft;
            btnSalvarPonto.Location=new Point(160, 826);
            btnSalvarPonto.Name="btnSalvarPonto";
            btnSalvarPonto.Size=new Size(400, 128);
            btnSalvarPonto.TabIndex=3;
            btnSalvarPonto.Text="Registrar ponto";
            btnSalvarPonto.UseVisualStyleBackColor=true;
            btnSalvarPonto.Click+=btnSalvarPonto_Click;
            // 
            // timer1
            // 
            timer1.Enabled=true;
            timer1.Interval=1000;
            timer1.Tick+=timer1_Tick;
            // 
            // pictureBox2
            // 
            pictureBox2.Image=Properties.Resources.arrow_back_FILL0_wght400_GRAD0_opsz48;
            pictureBox2.Location=new Point(12, 12);
            pictureBox2.Name="pictureBox2";
            pictureBox2.Size=new Size(48, 48);
            pictureBox2.SizeMode=PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex=37;
            pictureBox2.TabStop=false;
            pictureBox2.Click+=pictureBox2_Click;
            // 
            // lblSaudacao
            // 
            lblSaudacao.AutoSize=true;
            lblSaudacao.Font=new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaudacao.Location=new Point(66, 13);
            lblSaudacao.Name="lblSaudacao";
            lblSaudacao.Size=new Size(211, 45);
            lblSaudacao.TabIndex=36;
            lblSaudacao.Text="Marcar Ponto";
            // 
            // btnEU
            // 
            btnEU.FlatStyle=FlatStyle.Flat;
            btnEU.Image=Properties.Resources.sync_FILL0_wght400_GRAD0_opsz48;
            btnEU.Location=new Point(598, 183);
            btnEU.Name="btnEU";
            btnEU.Size=new Size(57, 57);
            btnEU.TabIndex=38;
            btnEU.UseVisualStyleBackColor=true;
            btnEU.Click+=btnEU_Click;
            // 
            // ponto
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.White;
            ClientSize=new Size(720, 1080);
            Controls.Add(btnEU);
            Controls.Add(txtNome);
            Controls.Add(lblData);
            Controls.Add(txtCPF);
            Controls.Add(pictureBox2);
            Controls.Add(lblHora);
            Controls.Add(lblSaudacao);
            Controls.Add(btnSalvarPonto);
            FormBorderStyle=FormBorderStyle.None;
            MaximizeBox=false;
            MinimizeBox=false;
            Name="ponto";
            ShowInTaskbar=false;
            StartPosition=FormStartPosition.CenterScreen;
            Text="ponto";
            Load+=ponto_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCPF;
        private Label lblData;
        private Label lblHora;
        private TextBox txtNome;
        private Button btnSalvarPonto;
        private System.Windows.Forms.Timer timer1;
        private ToolTip ttTxtCPF;
        private PictureBox pictureBox2;
        private Label lblSaudacao;
        private Button btnEU;
    }
}
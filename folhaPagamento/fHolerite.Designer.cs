﻿namespace folhaPagamento
{
    partial class fHolerite
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtSalario = new TextBox();
            txtHoraExtra = new TextBox();
            txtValorHoraExtra = new TextBox();
            txtDescINSS = new TextBox();
            txtDescIR = new TextBox();
            dgvHolerite = new DataGridView();
            btnCalcular = new Button();
            pictureBox2 = new PictureBox();
            lblSaudacao = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHolerite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 384);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Salário base: R$";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 413);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 1;
            label2.Text = "Horas extras:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 445);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 2;
            label3.Text = "Valor hora extra: R$";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 479);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 4;
            label5.Text = "Desconto INSS: R$";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 508);
            label6.Name = "label6";
            label6.Size = new Size(102, 15);
            label6.TabIndex = 5;
            label6.Text = "Desconto IRPF: R$";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(145, 381);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(100, 23);
            txtSalario.TabIndex = 7;
            // 
            // txtHoraExtra
            // 
            txtHoraExtra.Location = new Point(145, 410);
            txtHoraExtra.Name = "txtHoraExtra";
            txtHoraExtra.Size = new Size(100, 23);
            txtHoraExtra.TabIndex = 8;
            // 
            // txtValorHoraExtra
            // 
            txtValorHoraExtra.Location = new Point(145, 442);
            txtValorHoraExtra.Name = "txtValorHoraExtra";
            txtValorHoraExtra.Size = new Size(100, 23);
            txtValorHoraExtra.TabIndex = 9;
            // 
            // txtDescINSS
            // 
            txtDescINSS.Location = new Point(145, 471);
            txtDescINSS.Name = "txtDescINSS";
            txtDescINSS.Size = new Size(100, 23);
            txtDescINSS.TabIndex = 11;
            // 
            // txtDescIR
            // 
            txtDescIR.Location = new Point(145, 500);
            txtDescIR.Name = "txtDescIR";
            txtDescIR.Size = new Size(100, 23);
            txtDescIR.TabIndex = 12;
            // 
            // dgvHolerite
            // 
            dgvHolerite.AllowUserToAddRows = false;
            dgvHolerite.AllowUserToDeleteRows = false;
            dgvHolerite.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvHolerite.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHolerite.Location = new Point(12, 66);
            dgvHolerite.Name = "dgvHolerite";
            dgvHolerite.ReadOnly = true;
            dgvHolerite.RowTemplate.Height = 25;
            dgvHolerite.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHolerite.Size = new Size(352, 234);
            dgvHolerite.TabIndex = 14;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(94, 537);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(151, 23);
            btnCalcular.TabIndex = 15;
            btnCalcular.Text = "Calcular Holerite";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.arrow_back_FILL0_wght400_GRAD0_opsz48;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 39;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // lblSaudacao
            // 
            lblSaudacao.AutoSize = true;
            lblSaudacao.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaudacao.Location = new Point(66, 13);
            lblSaudacao.Name = "lblSaudacao";
            lblSaudacao.Size = new Size(134, 45);
            lblSaudacao.TabIndex = 38;
            lblSaudacao.Text = "Holerite";
            // 
            // fHolerite
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(376, 680);
            Controls.Add(pictureBox2);
            Controls.Add(lblSaudacao);
            Controls.Add(btnCalcular);
            Controls.Add(dgvHolerite);
            Controls.Add(txtDescIR);
            Controls.Add(txtDescINSS);
            Controls.Add(txtValorHoraExtra);
            Controls.Add(txtHoraExtra);
            Controls.Add(txtSalario);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fHolerite";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fHolerite";
            Load += fHolerite_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHolerite).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox txtSalario;
        private TextBox txtHoraExtra;
        private TextBox txtValorHoraExtra;
        private TextBox txtSalarioBruto;
        private TextBox txtDescINSS;
        private TextBox txtDescIR;
        private TextBox txtSalarioLiquido;
        private DataGridView dgvHolerite;
        private Button btnCalcular;
        private PictureBox pictureBox2;
        private Label lblSaudacao;
    }
}
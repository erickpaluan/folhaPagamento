namespace folhaPagamento
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
            lblusuario = new Label();
            lblIsAdm = new Label();
            lblNomeUsuario = new Label();
            lblAdm = new Label();
            label4 = new Label();
            lblCPF = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHolerite).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 266);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Salário base: R$";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 295);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 1;
            label2.Text = "Horas extras:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 327);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 2;
            label3.Text = "Valor hora extra: R$";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(232, 266);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 4;
            label5.Text = "Desconto INSS: R$";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(233, 295);
            label6.Name = "label6";
            label6.Size = new Size(102, 15);
            label6.TabIndex = 5;
            label6.Text = "Desconto IRPF: R$";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(126, 263);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(100, 23);
            txtSalario.TabIndex = 7;
            // 
            // txtHoraExtra
            // 
            txtHoraExtra.Location = new Point(126, 292);
            txtHoraExtra.Name = "txtHoraExtra";
            txtHoraExtra.Size = new Size(100, 23);
            txtHoraExtra.TabIndex = 8;
            // 
            // txtValorHoraExtra
            // 
            txtValorHoraExtra.Location = new Point(126, 324);
            txtValorHoraExtra.Name = "txtValorHoraExtra";
            txtValorHoraExtra.Size = new Size(100, 23);
            txtValorHoraExtra.TabIndex = 9;
            // 
            // txtDescINSS
            // 
            txtDescINSS.Location = new Point(341, 258);
            txtDescINSS.Name = "txtDescINSS";
            txtDescINSS.Size = new Size(100, 23);
            txtDescINSS.TabIndex = 11;
            // 
            // txtDescIR
            // 
            txtDescIR.Location = new Point(341, 287);
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
            dgvHolerite.Location = new Point(12, 12);
            dgvHolerite.Name = "dgvHolerite";
            dgvHolerite.ReadOnly = true;
            dgvHolerite.RowTemplate.Height = 25;
            dgvHolerite.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHolerite.Size = new Size(776, 234);
            dgvHolerite.TabIndex = 14;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(290, 324);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(151, 23);
            btnCalcular.TabIndex = 15;
            btnCalcular.Text = "Calcular Holerite";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Location = new Point(486, 266);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(59, 15);
            lblusuario.TabIndex = 17;
            lblusuario.Text = "USUARIO:";
            // 
            // lblIsAdm
            // 
            lblIsAdm.AutoSize = true;
            lblIsAdm.Location = new Point(506, 295);
            lblIsAdm.Name = "lblIsAdm";
            lblIsAdm.Size = new Size(39, 15);
            lblIsAdm.TabIndex = 28;
            lblIsAdm.Text = "ADM?";
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.AutoSize = true;
            lblNomeUsuario.Location = new Point(567, 266);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(38, 15);
            lblNomeUsuario.TabIndex = 29;
            lblNomeUsuario.Text = "label4";
            // 
            // lblAdm
            // 
            lblAdm.AutoSize = true;
            lblAdm.Location = new Point(567, 295);
            lblAdm.Name = "lblAdm";
            lblAdm.Size = new Size(38, 15);
            lblAdm.TabIndex = 30;
            lblAdm.Text = "label7";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(506, 327);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 31;
            label4.Text = "CPF";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(567, 327);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(38, 15);
            lblCPF.TabIndex = 32;
            lblCPF.Text = "label7";
            // 
            // fHolerite
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCPF);
            Controls.Add(label4);
            Controls.Add(lblAdm);
            Controls.Add(lblNomeUsuario);
            Controls.Add(lblIsAdm);
            Controls.Add(lblusuario);
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
            Name = "fHolerite";
            Text = "fHolerite";
            Load += fHolerite_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHolerite).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblIsAdm;
        private Label label5;
        private Label label6;
        private Label lblAdm;
        private TextBox txtSalario;
        private TextBox txtHoraExtra;
        private TextBox txtValorHoraExtra;
        private TextBox txtSalarioBruto;
        private TextBox txtDescINSS;
        private TextBox txtDescIR;
        private TextBox txtSalarioLiquido;
        private DataGridView dgvHolerite;
        private Button btnCalcular;
        private Label lblusuario;
        private Label lblNomeUsuario;
        private Label label4;
        private Label lblCPF;
    }
}
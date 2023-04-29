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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtSalario = new TextBox();
            txtHoraExtra = new TextBox();
            txtValorHoraExtra = new TextBox();
            txtSalarioBruto = new TextBox();
            txtDescINSS = new TextBox();
            txtDescIR = new TextBox();
            txtSalarioLiquido = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 62);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Salário base: R$";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 91);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 1;
            label2.Text = "Horas extras:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 123);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 2;
            label3.Text = "Valor hora extra: R$";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 152);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 3;
            label4.Text = "Salário bruto: R$";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(90, 186);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 4;
            label5.Text = "Desconto INSS: R$";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(91, 215);
            label6.Name = "label6";
            label6.Size = new Size(102, 15);
            label6.TabIndex = 5;
            label6.Text = "Desconto IRPF: R$";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(92, 239);
            label7.Name = "label7";
            label7.Size = new Size(101, 15);
            label7.TabIndex = 6;
            label7.Text = "Salário líquido: R$";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(199, 59);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(100, 23);
            txtSalario.TabIndex = 7;
            // 
            // txtHoraExtra
            // 
            txtHoraExtra.Location = new Point(199, 88);
            txtHoraExtra.Name = "txtHoraExtra";
            txtHoraExtra.Size = new Size(100, 23);
            txtHoraExtra.TabIndex = 8;
            // 
            // txtValorHoraExtra
            // 
            txtValorHoraExtra.Location = new Point(199, 120);
            txtValorHoraExtra.Name = "txtValorHoraExtra";
            txtValorHoraExtra.Size = new Size(100, 23);
            txtValorHoraExtra.TabIndex = 9;
            // 
            // txtSalarioBruto
            // 
            txtSalarioBruto.Location = new Point(199, 149);
            txtSalarioBruto.Name = "txtSalarioBruto";
            txtSalarioBruto.Size = new Size(100, 23);
            txtSalarioBruto.TabIndex = 10;
            // 
            // txtDescINSS
            // 
            txtDescINSS.Location = new Point(199, 178);
            txtDescINSS.Name = "txtDescINSS";
            txtDescINSS.Size = new Size(100, 23);
            txtDescINSS.TabIndex = 11;
            // 
            // txtDescIR
            // 
            txtDescIR.Location = new Point(199, 207);
            txtDescIR.Name = "txtDescIR";
            txtDescIR.Size = new Size(100, 23);
            txtDescIR.TabIndex = 12;
            // 
            // txtSalarioLiquido
            // 
            txtSalarioLiquido.Location = new Point(199, 236);
            txtSalarioLiquido.Name = "txtSalarioLiquido";
            txtSalarioLiquido.Size = new Size(100, 23);
            txtSalarioLiquido.TabIndex = 13;
            // 
            // fHolerite
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSalarioLiquido);
            Controls.Add(txtDescIR);
            Controls.Add(txtDescINSS);
            Controls.Add(txtSalarioBruto);
            Controls.Add(txtValorHoraExtra);
            Controls.Add(txtHoraExtra);
            Controls.Add(txtSalario);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fHolerite";
            Text = "fHolerite";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtSalario;
        private TextBox txtHoraExtra;
        private TextBox txtValorHoraExtra;
        private TextBox txtSalarioBruto;
        private TextBox txtDescINSS;
        private TextBox txtDescIR;
        private TextBox txtSalarioLiquido;
    }
}
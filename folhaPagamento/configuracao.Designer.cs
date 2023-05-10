namespace folhaPagamento
{
    partial class configuracao
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
            pictureBox2=new PictureBox();
            lblSaudacao=new Label();
            groupBox1=new GroupBox();
            label1=new Label();
            txtDescINSS=new TextBox();
            txtDescIRPF=new TextBox();
            label2=new Label();
            label3=new Label();
            label4=new Label();
            label5=new Label();
            label6=new Label();
            txtConvMedico=new TextBox();
            label7=new Label();
            txtConvOdonto=new TextBox();
            label8=new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image=Properties.Resources.arrow_back_FILL0_wght400_GRAD0_opsz48;
            pictureBox2.Location=new Point(12, 12);
            pictureBox2.Name="pictureBox2";
            pictureBox2.Size=new Size(48, 48);
            pictureBox2.SizeMode=PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex=43;
            pictureBox2.TabStop=false;
            pictureBox2.Click+=pictureBox2_Click;
            // 
            // lblSaudacao
            // 
            lblSaudacao.AutoSize=true;
            lblSaudacao.Font=new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaudacao.Location=new Point(66, 13);
            lblSaudacao.Name="lblSaudacao";
            lblSaudacao.Size=new Size(224, 45);
            lblSaudacao.TabIndex=42;
            lblSaudacao.Text="Configurações";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtConvMedico);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtConvOdonto);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDescIRPF);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDescINSS);
            groupBox1.Controls.Add(label1);
            groupBox1.Location=new Point(12, 66);
            groupBox1.Name="groupBox1";
            groupBox1.Size=new Size(352, 168);
            groupBox1.TabIndex=44;
            groupBox1.TabStop=false;
            groupBox1.Text="Descontos";
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(6, 45);
            label1.Name="label1";
            label1.Size=new Size(31, 15);
            label1.TabIndex=45;
            label1.Text="INSS";
            // 
            // txtDescINSS
            // 
            txtDescINSS.Location=new Point(6, 63);
            txtDescINSS.Name="txtDescINSS";
            txtDescINSS.Size=new Size(93, 23);
            txtDescINSS.TabIndex=45;
            // 
            // txtDescIRPF
            // 
            txtDescIRPF.Location=new Point(146, 63);
            txtDescIRPF.Name="txtDescIRPF";
            txtDescIRPF.Size=new Size(93, 23);
            txtDescIRPF.TabIndex=46;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(146, 45);
            label2.Name="label2";
            label2.Size=new Size(30, 15);
            label2.TabIndex=47;
            label2.Text="IRPF";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(105, 66);
            label3.Name="label3";
            label3.Size=new Size(17, 15);
            label3.TabIndex=48;
            label3.Text="%";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(245, 66);
            label4.Name="label4";
            label4.Size=new Size(17, 15);
            label4.TabIndex=49;
            label4.Text="%";
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new Point(245, 110);
            label5.Name="label5";
            label5.Size=new Size(17, 15);
            label5.TabIndex=55;
            label5.Text="%";
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Location=new Point(105, 110);
            label6.Name="label6";
            label6.Size=new Size(17, 15);
            label6.TabIndex=54;
            label6.Text="%";
            // 
            // txtConvMedico
            // 
            txtConvMedico.Location=new Point(146, 107);
            txtConvMedico.Name="txtConvMedico";
            txtConvMedico.Size=new Size(93, 23);
            txtConvMedico.TabIndex=52;
            // 
            // label7
            // 
            label7.AutoSize=true;
            label7.Location=new Point(146, 89);
            label7.Name="label7";
            label7.Size=new Size(81, 15);
            label7.TabIndex=53;
            label7.Text="Conv. Médico";
            // 
            // txtConvOdonto
            // 
            txtConvOdonto.Location=new Point(6, 107);
            txtConvOdonto.Name="txtConvOdonto";
            txtConvOdonto.Size=new Size(93, 23);
            txtConvOdonto.TabIndex=50;
            // 
            // label8
            // 
            label8.AutoSize=true;
            label8.Location=new Point(6, 89);
            label8.Name="label8";
            label8.Size=new Size(115, 15);
            label8.TabIndex=51;
            label8.Text="Conv. Odontológico";
            // 
            // configuracao
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.White;
            ClientSize=new Size(376, 680);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox2);
            Controls.Add(lblSaudacao);
            FormBorderStyle=FormBorderStyle.None;
            Name="configuracao";
            StartPosition=FormStartPosition.CenterScreen;
            Text="configuracao";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label lblSaudacao;
        private GroupBox groupBox1;
        private TextBox txtDescIRPF;
        private Label label2;
        private TextBox txtDescINSS;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox txtConvMedico;
        private Label label7;
        private TextBox txtConvOdonto;
        private Label label8;
    }
}
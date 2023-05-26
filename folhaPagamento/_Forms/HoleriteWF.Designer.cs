namespace folhaPagamento
{
    partial class HoleriteWF
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
            label5 = new Label();
            txtSalario = new TextBox();
            txtConvMed = new TextBox();
            txtConvOdon = new TextBox();
            txtDescINSS = new TextBox();
            txtDescIR = new TextBox();
            dgvHolerite = new DataGridView();
            btnCalcular = new Button();
            pictureBox2 = new PictureBox();
            txtTotal = new TextBox();
            dtpHolerite = new DateTimePicker();
            txtCPFUser = new TextBox();
            txtCPF = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label7 = new Label();
            groupBox3 = new GroupBox();
            label6 = new Label();
            groupBox4 = new GroupBox();
            panel1 = new Panel();
            btnMinhasConfig = new Button();
            btnMeuPerfil = new Button();
            lblSaudacao = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHolerite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(347, 315);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 4;
            label5.Text = "Salário Base";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSalario
            // 
            txtSalario.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSalario.Location = new Point(347, 333);
            txtSalario.Name = "txtSalario";
            txtSalario.PlaceholderText = "Salário Base";
            txtSalario.Size = new Size(294, 21);
            txtSalario.TabIndex = 7;
            // 
            // txtConvMed
            // 
            txtConvMed.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtConvMed.Location = new Point(6, 37);
            txtConvMed.Name = "txtConvMed";
            txtConvMed.PlaceholderText = "Médico";
            txtConvMed.Size = new Size(109, 21);
            txtConvMed.TabIndex = 8;
            // 
            // txtConvOdon
            // 
            txtConvOdon.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtConvOdon.Location = new Point(121, 37);
            txtConvOdon.Name = "txtConvOdon";
            txtConvOdon.PlaceholderText = "Odontologico";
            txtConvOdon.Size = new Size(180, 21);
            txtConvOdon.TabIndex = 9;
            // 
            // txtDescINSS
            // 
            txtDescINSS.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescINSS.Location = new Point(144, 37);
            txtDescINSS.Name = "txtDescINSS";
            txtDescINSS.PlaceholderText = "Desconto INSS";
            txtDescINSS.Size = new Size(211, 21);
            txtDescINSS.TabIndex = 11;
            // 
            // txtDescIR
            // 
            txtDescIR.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescIR.Location = new Point(6, 37);
            txtDescIR.Name = "txtDescIR";
            txtDescIR.PlaceholderText = "IRPF";
            txtDescIR.Size = new Size(132, 21);
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
            dgvHolerite.Size = new Size(696, 234);
            dgvHolerite.TabIndex = 14;
            dgvHolerite.CellClick += dgvHolerite_CellClick;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.White;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.ForeColor = Color.FromArgb(62, 122, 232);
            btnCalcular.Location = new Point(569, 8);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(139, 29);
            btnCalcular.TabIndex = 15;
            btnCalcular.Text = "Calcular Holerite";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Visible = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.arrow_back_FILL0_wght400_GRAD0_opsz48;
            pictureBox2.Location = new Point(12, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 39;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.Location = new Point(13, 37);
            txtTotal.Name = "txtTotal";
            txtTotal.PlaceholderText = "Total";
            txtTotal.Size = new Size(342, 21);
            txtTotal.TabIndex = 40;
            // 
            // dtpHolerite
            // 
            dtpHolerite.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpHolerite.Format = DateTimePickerFormat.Short;
            dtpHolerite.Location = new Point(6, 37);
            dtpHolerite.Name = "dtpHolerite";
            dtpHolerite.Size = new Size(295, 21);
            dtpHolerite.TabIndex = 42;
            // 
            // txtCPFUser
            // 
            txtCPFUser.Location = new Point(201, 64);
            txtCPFUser.Name = "txtCPFUser";
            txtCPFUser.Size = new Size(100, 23);
            txtCPFUser.TabIndex = 43;
            txtCPFUser.Visible = false;
            // 
            // txtCPF
            // 
            txtCPF.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCPF.Location = new Point(18, 333);
            txtCPF.Name = "txtCPF";
            txtCPF.PlaceholderText = "CPF Funcionário";
            txtCPF.Size = new Size(301, 21);
            txtCPF.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 315);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 46;
            label1.Text = "CPF Funcionário";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtConvMed);
            groupBox1.Controls.Add(txtConvOdon);
            groupBox1.Location = new Point(12, 360);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(307, 73);
            groupBox1.TabIndex = 47;
            groupBox1.TabStop = false;
            groupBox1.Text = "Convênios";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(121, 19);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 49;
            label3.Text = "Odontológico";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 48;
            label2.Text = "Médico";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtDescIR);
            groupBox2.Controls.Add(txtDescINSS);
            groupBox2.Location = new Point(347, 360);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(365, 73);
            groupBox2.TabIndex = 48;
            groupBox2.TabStop = false;
            groupBox2.Text = "Descontos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(144, 19);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 51;
            label4.Text = "INSS";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(6, 19);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 50;
            label7.Text = "IRPF";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtTotal);
            groupBox3.Location = new Point(347, 439);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(365, 99);
            groupBox3.TabIndex = 49;
            groupBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(13, 19);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 52;
            label6.Text = "Salário Líquido";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dtpHolerite);
            groupBox4.Controls.Add(txtCPFUser);
            groupBox4.Location = new Point(12, 439);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(307, 99);
            groupBox4.TabIndex = 50;
            groupBox4.TabStop = false;
            groupBox4.Text = "Data Emissão";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(196, 196, 196);
            panel1.Controls.Add(btnMinhasConfig);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnMeuPerfil);
            panel1.Controls.Add(lblSaudacao);
            panel1.Controls.Add(btnCalcular);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(731, 51);
            panel1.TabIndex = 51;
            // 
            // btnMinhasConfig
            // 
            btnMinhasConfig.Anchor = AnchorStyles.Right;
            btnMinhasConfig.BackColor = Color.White;
            btnMinhasConfig.FlatStyle = FlatStyle.Flat;
            btnMinhasConfig.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinhasConfig.ForeColor = Color.FromArgb(62, 122, 232);
            btnMinhasConfig.ImageAlign = ContentAlignment.MiddleLeft;
            btnMinhasConfig.Location = new Point(1663, -24);
            btnMinhasConfig.Name = "btnMinhasConfig";
            btnMinhasConfig.Size = new Size(139, 29);
            btnMinhasConfig.TabIndex = 19;
            btnMinhasConfig.Text = "Minhas configurações";
            btnMinhasConfig.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMinhasConfig.UseVisualStyleBackColor = false;
            // 
            // btnMeuPerfil
            // 
            btnMeuPerfil.Anchor = AnchorStyles.Right;
            btnMeuPerfil.BackColor = Color.FromArgb(62, 122, 232);
            btnMeuPerfil.FlatStyle = FlatStyle.Flat;
            btnMeuPerfil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMeuPerfil.ForeColor = Color.White;
            btnMeuPerfil.ImageAlign = ContentAlignment.MiddleLeft;
            btnMeuPerfil.Location = new Point(1531, -24);
            btnMeuPerfil.Name = "btnMeuPerfil";
            btnMeuPerfil.Size = new Size(126, 29);
            btnMeuPerfil.TabIndex = 18;
            btnMeuPerfil.Text = "Meu perfil";
            btnMeuPerfil.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMeuPerfil.UseVisualStyleBackColor = false;
            // 
            // lblSaudacao
            // 
            lblSaudacao.AutoSize = true;
            lblSaudacao.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaudacao.Location = new Point(48, 13);
            lblSaudacao.Name = "lblSaudacao";
            lblSaudacao.Size = new Size(79, 25);
            lblSaudacao.TabIndex = 36;
            lblSaudacao.Text = "Holerite";
            // 
            // HoleriteWF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(724, 562);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(txtCPF);
            Controls.Add(dgvHolerite);
            Controls.Add(txtSalario);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "HoleriteWF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fHolerite";
            Load += fHolerite_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHolerite).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private TextBox txtSalario;
        private TextBox txtConvMed;
        private TextBox txtConvOdon;
        private TextBox txtSalarioBruto;
        private TextBox txtDescINSS;
        private TextBox txtDescIR;
        private TextBox txtSalarioLiquido;
        private DataGridView dgvHolerite;
        private Button btnCalcular;
        private PictureBox pictureBox2;
        private TextBox txtTotal;
        private DateTimePicker dtpHolerite;
        private TextBox txtCPFUser;
        private TextBox txtCPF;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private Label label4;
        private Label label7;
        private GroupBox groupBox3;
        private Label label6;
        private GroupBox groupBox4;
        private Panel panel1;
        private Button btnMinhasConfig;
        private Button btnMeuPerfil;
        private Label lblSaudacao;
    }
}
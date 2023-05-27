namespace folhaPagamento._Forms
{
    partial class VisualizarHolereiteWF
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
            groupBox5 = new GroupBox();
            comboBox1 = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            btnMinhasConfig = new Button();
            pictureBox2 = new PictureBox();
            btnMeuPerfil = new Button();
            lblSaudacao = new Label();
            btnCalcular = new Button();
            groupBox5.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(comboBox1);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(textBox2);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(textBox1);
            groupBox5.Location = new Point(12, 57);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(618, 81);
            groupBox5.TabIndex = 54;
            groupBox5.TabStop = false;
            groupBox5.Text = "Dados";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" });
            comboBox1.Location = new Point(459, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(153, 23);
            comboBox1.TabIndex = 53;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(459, 19);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 54;
            label10.Text = "Mês";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(226, 19);
            label9.Name = "label9";
            label9.Size = new Size(72, 15);
            label9.TabIndex = 53;
            label9.Text = "Funcionário";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(226, 37);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Nome do funcionário";
            textBox2.Size = new Size(227, 21);
            textBox2.TabIndex = 52;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 19);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 51;
            label8.Text = "Empresa";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(6, 37);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Empresa";
            textBox1.Size = new Size(214, 21);
            textBox1.TabIndex = 50;
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
            panel1.Size = new Size(648, 51);
            panel1.TabIndex = 53;
            // 
            // btnMinhasConfig
            // 
            btnMinhasConfig.Anchor = AnchorStyles.Right;
            btnMinhasConfig.BackColor = Color.White;
            btnMinhasConfig.FlatStyle = FlatStyle.Flat;
            btnMinhasConfig.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinhasConfig.ForeColor = Color.FromArgb(62, 122, 232);
            btnMinhasConfig.ImageAlign = ContentAlignment.MiddleLeft;
            btnMinhasConfig.Location = new Point(2111, -49);
            btnMinhasConfig.Name = "btnMinhasConfig";
            btnMinhasConfig.Size = new Size(139, 29);
            btnMinhasConfig.TabIndex = 19;
            btnMinhasConfig.Text = "Minhas configurações";
            btnMinhasConfig.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMinhasConfig.UseVisualStyleBackColor = false;
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
            // 
            // btnMeuPerfil
            // 
            btnMeuPerfil.Anchor = AnchorStyles.Right;
            btnMeuPerfil.BackColor = Color.FromArgb(62, 122, 232);
            btnMeuPerfil.FlatStyle = FlatStyle.Flat;
            btnMeuPerfil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMeuPerfil.ForeColor = Color.White;
            btnMeuPerfil.ImageAlign = ContentAlignment.MiddleLeft;
            btnMeuPerfil.Location = new Point(1979, -49);
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
            lblSaudacao.Size = new Size(136, 25);
            lblSaudacao.TabIndex = 36;
            lblSaudacao.Text = "Meus holerites";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.White;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.ForeColor = Color.FromArgb(62, 122, 232);
            btnCalcular.Location = new Point(493, 9);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(139, 29);
            btnCalcular.TabIndex = 15;
            btnCalcular.Text = "Calcular Holerite";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Visible = false;
            // 
            // VisualizarHolereiteWF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 450);
            Controls.Add(groupBox5);
            Controls.Add(panel1);
            Name = "VisualizarHolereiteWF";
            Text = "VisualizarHolereiteWF";
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox5;
        private ComboBox comboBox1;
        private Label label10;
        private Label label9;
        private TextBox textBox2;
        private Label label8;
        private TextBox textBox1;
        private Panel panel1;
        private Button btnMinhasConfig;
        private PictureBox pictureBox2;
        private Button btnMeuPerfil;
        private Label lblSaudacao;
        private Button btnCalcular;
    }
}
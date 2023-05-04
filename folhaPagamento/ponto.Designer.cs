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
            components=new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ponto));
            groupBox1=new GroupBox();
            txtCPF=new TextBox();
            groupBox2=new GroupBox();
            lblData=new Label();
            label5=new Label();
            lblHora=new Label();
            label2=new Label();
            label1=new Label();
            txtNome=new TextBox();
            btnSalvarPonto=new Button();
            timer1=new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCPF);
            groupBox1.Location=new Point(12, 12);
            groupBox1.Name="groupBox1";
            groupBox1.Size=new Size(336, 73);
            groupBox1.TabIndex=0;
            groupBox1.TabStop=false;
            groupBox1.Text="ID FUNCIONARIO";
            // 
            // txtCPF
            // 
            txtCPF.Font=new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCPF.Location=new Point(6, 22);
            txtCPF.Name="txtCPF";
            txtCPF.Size=new Size(324, 33);
            txtCPF.TabIndex=1;
            txtCPF.TextChanged+=txtCPF_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblData);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(lblHora);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtNome);
            groupBox2.Location=new Point(12, 91);
            groupBox2.Name="groupBox2";
            groupBox2.Size=new Size(336, 208);
            groupBox2.TabIndex=2;
            groupBox2.TabStop=false;
            groupBox2.Text="INFORMAÇÕES";
            // 
            // lblData
            // 
            lblData.AutoSize=true;
            lblData.Font=new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblData.Location=new Point(150, 133);
            lblData.Name="lblData";
            lblData.Size=new Size(167, 40);
            lblData.TabIndex=6;
            lblData.Text="31/12/2023";
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new Point(150, 118);
            label5.Name="label5";
            label5.Size=new Size(31, 15);
            label5.TabIndex=5;
            label5.Text="Data";
            // 
            // lblHora
            // 
            lblHora.AutoSize=true;
            lblHora.Font=new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblHora.Location=new Point(6, 133);
            lblHora.Name="lblHora";
            lblHora.Size=new Size(87, 40);
            lblHora.TabIndex=4;
            lblHora.Text="00:00";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(6, 118);
            label2.Name="label2";
            label2.Size=new Size(33, 15);
            label2.TabIndex=3;
            label2.Text="Hora";
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(6, 37);
            label1.Name="label1";
            label1.Size=new Size(40, 15);
            label1.TabIndex=2;
            label1.Text="Nome";
            // 
            // txtNome
            // 
            txtNome.Font=new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location=new Point(6, 55);
            txtNome.Name="txtNome";
            txtNome.ReadOnly=true;
            txtNome.Size=new Size(324, 33);
            txtNome.TabIndex=1;
            // 
            // btnSalvarPonto
            // 
            btnSalvarPonto.Image=(Image)resources.GetObject("btnSalvarPonto.Image");
            btnSalvarPonto.ImageAlign=ContentAlignment.MiddleLeft;
            btnSalvarPonto.Location=new Point(211, 305);
            btnSalvarPonto.Name="btnSalvarPonto";
            btnSalvarPonto.Size=new Size(137, 71);
            btnSalvarPonto.TabIndex=3;
            btnSalvarPonto.Text="Salvar ponto";
            btnSalvarPonto.TextAlign=ContentAlignment.MiddleRight;
            btnSalvarPonto.UseVisualStyleBackColor=true;
            // 
            // timer1
            // 
            timer1.Enabled=true;
            timer1.Interval=1000;
            timer1.Tick+=timer1_Tick;
            // 
            // ponto
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(360, 388);
            Controls.Add(btnSalvarPonto);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox=false;
            MinimizeBox=false;
            Name="ponto";
            ShowInTaskbar=false;
            StartPosition=FormStartPosition.CenterScreen;
            Text="ponto";
            Load+=ponto_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtCPF;
        private GroupBox groupBox2;
        private Label lblData;
        private Label label5;
        private Label lblHora;
        private Label label2;
        private Label label1;
        private TextBox txtNome;
        private Button btnSalvarPonto;
        private System.Windows.Forms.Timer timer1;
    }
}
namespace folhaPagamento
{
    partial class main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            button1=new Button();
            button2=new Button();
            button3=new Button();
            button4=new Button();
            lblSaudacao=new Label();
            pictureBox1=new PictureBox();
            button5=new Button();
            button6=new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Image=(Image)resources.GetObject("button1.Image");
            button1.Location=new Point(12, 98);
            button1.Name="button1";
            button1.Size=new Size(96, 96);
            button1.TabIndex=2;
            button1.Text="Marcar Ponto";
            button1.TextAlign=ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // button2
            // 
            button2.Image=(Image)resources.GetObject("button2.Image");
            button2.Location=new Point(114, 98);
            button2.Name="button2";
            button2.Size=new Size(96, 96);
            button2.TabIndex=3;
            button2.Text="Holerite";
            button2.TextAlign=ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // button3
            // 
            button3.Image=(Image)resources.GetObject("button3.Image");
            button3.Location=new Point(216, 98);
            button3.Name="button3";
            button3.Size=new Size(96, 96);
            button3.TabIndex=4;
            button3.Text="Funcionários";
            button3.TextAlign=ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor=true;
            button3.Click+=button3_Click;
            // 
            // button4
            // 
            button4.Image=(Image)resources.GetObject("button4.Image");
            button4.Location=new Point(318, 200);
            button4.Name="button4";
            button4.Size=new Size(96, 96);
            button4.TabIndex=5;
            button4.Text="Configurações";
            button4.TextAlign=ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor=true;
            button4.Click+=button4_Click;
            // 
            // lblSaudacao
            // 
            lblSaudacao.AutoSize=true;
            lblSaudacao.Font=new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaudacao.Location=new Point(66, 25);
            lblSaudacao.Name="lblSaudacao";
            lblSaudacao.Size=new Size(226, 45);
            lblSaudacao.TabIndex=6;
            lblSaudacao.Text="Bom dia, Erick.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image=(Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location=new Point(12, 22);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(48, 48);
            pictureBox1.SizeMode=PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex=7;
            pictureBox1.TabStop=false;
            // 
            // button5
            // 
            button5.Location=new Point(318, 98);
            button5.Name="button5";
            button5.Size=new Size(96, 96);
            button5.TabIndex=8;
            button5.Text="Empresa";
            button5.UseVisualStyleBackColor=true;
            // 
            // button6
            // 
            button6.Location=new Point(12, 200);
            button6.Name="button6";
            button6.Size=new Size(198, 32);
            button6.TabIndex=9;
            button6.Text="Importar / exportar";
            button6.UseVisualStyleBackColor=true;
            // 
            // main
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.White;
            ClientSize=new Size(472, 360);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(pictureBox1);
            Controls.Add(lblSaudacao);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="main";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Folha Pagamento";
            Load+=main_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label lblSaudacao;
        private PictureBox pictureBox1;
        private Button button5;
        private Button button6;
    }
}
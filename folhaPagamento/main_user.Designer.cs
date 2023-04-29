namespace folhaPagamento
{
    partial class main_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_user));
            pictureBox1 = new PictureBox();
            lblSaudacao = new Label();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // lblSaudacao
            // 
            lblSaudacao.AutoSize = true;
            lblSaudacao.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaudacao.Location = new Point(66, 15);
            lblSaudacao.Name = "lblSaudacao";
            lblSaudacao.Size = new Size(226, 45);
            lblSaudacao.TabIndex = 8;
            lblSaudacao.Text = "Bom dia, Erick.";
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(114, 96);
            button2.Name = "button2";
            button2.Size = new Size(96, 96);
            button2.TabIndex = 11;
            button2.Text = "Holerite";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(12, 96);
            button1.Name = "button1";
            button1.Size = new Size(96, 96);
            button1.TabIndex = 10;
            button1.Text = "Marcar Ponto";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.settings_FILL0_wght400_GRAD0_opsz48;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(12, 198);
            button3.Name = "button3";
            button3.Size = new Size(198, 57);
            button3.TabIndex = 12;
            button3.Text = "Configuraçoes";
            button3.UseVisualStyleBackColor = true;
            // 
            // main_user
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 413);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(lblSaudacao);
            Name = "main_user";
            Text = "Folha Pagamento";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblSaudacao;
        private Button button2;
        private Button button1;
        private Button button3;
    }
}
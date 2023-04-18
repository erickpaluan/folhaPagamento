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
            brnCliqueAqui = new Button();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            novoFuncionárioToolStripMenuItem = new ToolStripMenuItem();
            folhaDePontoToolStripMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // brnCliqueAqui
            // 
            brnCliqueAqui.Location = new Point(428, 349);
            brnCliqueAqui.Name = "brnCliqueAqui";
            brnCliqueAqui.Size = new Size(75, 23);
            brnCliqueAqui.TabIndex = 0;
            brnCliqueAqui.Text = "Botão Teste";
            brnCliqueAqui.UseVisualStyleBackColor = true;
            brnCliqueAqui.Click += brnCliqueAqui_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, cadastrosToolStripMenuItem, folhaDePontoToolStripMenuItem, relatóriosToolStripMenuItem, ajudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1196, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoFuncionárioToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // novoFuncionárioToolStripMenuItem
            // 
            novoFuncionárioToolStripMenuItem.Name = "novoFuncionárioToolStripMenuItem";
            novoFuncionárioToolStripMenuItem.Size = new Size(145, 22);
            novoFuncionárioToolStripMenuItem.Text = "Novo usuário";
            novoFuncionárioToolStripMenuItem.Click += novoFuncionárioToolStripMenuItem_Click;
            // 
            // folhaDePontoToolStripMenuItem
            // 
            folhaDePontoToolStripMenuItem.Name = "folhaDePontoToolStripMenuItem";
            folhaDePontoToolStripMenuItem.Size = new Size(99, 20);
            folhaDePontoToolStripMenuItem.Text = "Folha de Ponto";
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(71, 20);
            relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(50, 20);
            ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(12, 65);
            button1.Name = "button1";
            button1.Size = new Size(159, 162);
            button1.TabIndex = 2;
            button1.Text = "Marcar Ponto";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(178, 65);
            button2.Name = "button2";
            button2.Size = new Size(159, 162);
            button2.TabIndex = 3;
            button2.Text = "Holerite";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(344, 65);
            button3.Name = "button3";
            button3.Size = new Size(159, 162);
            button3.TabIndex = 4;
            button3.Text = "Usuários";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 718);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(brnCliqueAqui);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Folha Pagamento";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button brnCliqueAqui;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem novoFuncionárioToolStripMenuItem;
        private ToolStripMenuItem folhaDePontoToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
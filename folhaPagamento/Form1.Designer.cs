﻿namespace folhaPagamento
{
    partial class Form1
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
            this.brnCliqueAqui = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // brnCliqueAqui
            // 
            this.brnCliqueAqui.Location = new System.Drawing.Point(371, 232);
            this.brnCliqueAqui.Name = "brnCliqueAqui";
            this.brnCliqueAqui.Size = new System.Drawing.Size(75, 23);
            this.brnCliqueAqui.TabIndex = 0;
            this.brnCliqueAqui.Text = "Clique aqui";
            this.brnCliqueAqui.UseVisualStyleBackColor = true;
            this.brnCliqueAqui.Click += new System.EventHandler(this.brnCliqueAqui_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.brnCliqueAqui);
            this.Name = "Form1";
            this.Text = "Folha Pagamento";
            this.ResumeLayout(false);

        }

        #endregion

        private Button brnCliqueAqui;
    }
}
namespace Bingo_OO
{
    partial class Bingo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novoJogoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.novaCartela = new System.Windows.Forms.ToolStripMenuItem();
            this.terminarJogo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoJogoMenu,
            this.novaCartela,
            this.terminarJogo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(427, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novoJogoMenu
            // 
            this.novoJogoMenu.Name = "novoJogoMenu";
            this.novoJogoMenu.Size = new System.Drawing.Size(76, 20);
            this.novoJogoMenu.Text = "Novo Jogo";
            this.novoJogoMenu.Click += new System.EventHandler(this.novoJogoMenu_Click);
            // 
            // novaCartela
            // 
            this.novaCartela.Name = "novaCartela";
            this.novaCartela.Size = new System.Drawing.Size(87, 20);
            this.novaCartela.Text = "Nova Cartela";
            this.novaCartela.Click += new System.EventHandler(this.novaCartela_Click);
            // 
            // terminarJogo
            // 
            this.terminarJogo.Name = "terminarJogo";
            this.terminarJogo.Size = new System.Drawing.Size(95, 20);
            this.terminarJogo.Text = "Terminar Jogo";
            this.terminarJogo.Click += new System.EventHandler(this.terminarJogo_Click);
            // 
            // Bingo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Bingo_OO.Properties.Resources.FinalFrame_01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(427, 280);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(443, 318);
            this.MinimumSize = new System.Drawing.Size(443, 318);
            this.Name = "Bingo";
            this.Text = "Bingo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novoJogoMenu;
        private System.Windows.Forms.ToolStripMenuItem novaCartela;
        private System.Windows.Forms.ToolStripMenuItem terminarJogo;
    }
}


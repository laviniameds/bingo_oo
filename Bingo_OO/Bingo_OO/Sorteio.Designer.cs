namespace Bingo_OO
{
    partial class Sorteio
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
            this.btnSortear = new System.Windows.Forms.Button();
            this.lblSorteado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSortear
            // 
            this.btnSortear.Location = new System.Drawing.Point(193, 161);
            this.btnSortear.Name = "btnSortear";
            this.btnSortear.Size = new System.Drawing.Size(75, 23);
            this.btnSortear.TabIndex = 1;
            this.btnSortear.Text = "Sortear";
            this.btnSortear.UseVisualStyleBackColor = true;
            this.btnSortear.Click += new System.EventHandler(this.btnSortear_Click);
            // 
            // lblSorteado
            // 
            this.lblSorteado.AutoSize = true;
            this.lblSorteado.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSorteado.Location = new System.Drawing.Point(78, 28);
            this.lblSorteado.Name = "lblSorteado";
            this.lblSorteado.Size = new System.Drawing.Size(0, 108);
            this.lblSorteado.TabIndex = 2;
            this.lblSorteado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sorteados:";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(16, 218);
            this.listBox1.Margin = new System.Windows.Forms.Padding(0);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(252, 220);
            this.listBox1.TabIndex = 4;
            // 
            // Sorteio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 475);
            this.ControlBox = false;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSorteado);
            this.Controls.Add(this.btnSortear);
            this.MaximumSize = new System.Drawing.Size(296, 513);
            this.Name = "Sorteio";
            this.Text = "Sorteio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSortear;
        private System.Windows.Forms.Label lblSorteado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}
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
            // Sorteio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 195);
            this.Controls.Add(this.lblSorteado);
            this.Controls.Add(this.btnSortear);
            this.MaximumSize = new System.Drawing.Size(296, 233);
            this.Name = "Sorteio";
            this.Text = "Sorteio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSortear;
        private System.Windows.Forms.Label lblSorteado;
    }
}
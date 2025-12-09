namespace QuizProvãoPaulista
{
    partial class Parabens
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
            this.LblPontuacao = new System.Windows.Forms.Label();
            this.BtnVoltarPagInicial = new System.Windows.Forms.Button();
            this.Lblpontos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblPontuacao
            // 
            this.LblPontuacao.AutoSize = true;
            this.LblPontuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPontuacao.Location = new System.Drawing.Point(241, 121);
            this.LblPontuacao.Name = "LblPontuacao";
            this.LblPontuacao.Size = new System.Drawing.Size(0, 38);
            this.LblPontuacao.TabIndex = 24;
            // 
            // BtnVoltarPagInicial
            // 
            this.BtnVoltarPagInicial.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnVoltarPagInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltarPagInicial.Location = new System.Drawing.Point(359, 217);
            this.BtnVoltarPagInicial.Name = "BtnVoltarPagInicial";
            this.BtnVoltarPagInicial.Size = new System.Drawing.Size(248, 107);
            this.BtnVoltarPagInicial.TabIndex = 25;
            this.BtnVoltarPagInicial.Text = "Voltar";
            this.BtnVoltarPagInicial.UseVisualStyleBackColor = false;
            this.BtnVoltarPagInicial.Click += new System.EventHandler(this.BtnVoltarPagInicial_Click_1);
            // 
            // Lblpontos
            // 
            this.Lblpontos.AutoSize = true;
            this.Lblpontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblpontos.Location = new System.Drawing.Point(165, 89);
            this.Lblpontos.Name = "Lblpontos";
            this.Lblpontos.Size = new System.Drawing.Size(650, 54);
            this.Lblpontos.TabIndex = 26;
            this.Lblpontos.Text = "Você teve: 9 acertos e 1 erro";
            // 
            // Parabens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 395);
            this.Controls.Add(this.Lblpontos);
            this.Controls.Add(this.BtnVoltarPagInicial);
            this.Controls.Add(this.LblPontuacao);
            this.Location = new System.Drawing.Point(1008, 442);
            this.MaximumSize = new System.Drawing.Size(1008, 442);
            this.Name = "Parabens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parabens";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblPontuacao;
        private System.Windows.Forms.Button BtnVoltarPagInicial;
        private System.Windows.Forms.Label Lblpontos;
    }
}
/*
 * Created by SharpDevelop.
 * User: Aluno
 * Date: 13/10/2025
 * Time: 14:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace QuizProvãoPaulista
{
	partial class Configurações
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configurações));
            this.LblProQuiz = new System.Windows.Forms.Label();
            this.LblProvao = new System.Windows.Forms.Label();
            this.TxtMudarNome = new System.Windows.Forms.TextBox();
            this.LblMudarNome = new System.Windows.Forms.Label();
            this.BtnMudar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.lblVoltar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblProQuiz
            // 
            this.LblProQuiz.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProQuiz.ForeColor = System.Drawing.SystemColors.InfoText;
            this.LblProQuiz.Location = new System.Drawing.Point(15, 62);
            this.LblProQuiz.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblProQuiz.Name = "LblProQuiz";
            this.LblProQuiz.Size = new System.Drawing.Size(138, 29);
            this.LblProQuiz.TabIndex = 15;
            this.LblProQuiz.Text = "Pro-Quiz";
            // 
            // LblProvao
            // 
            this.LblProvao.Font = new System.Drawing.Font("Arial Black", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProvao.ForeColor = System.Drawing.Color.DarkOrange;
            this.LblProvao.Location = new System.Drawing.Point(8, 6);
            this.LblProvao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblProvao.Name = "LblProvao";
            this.LblProvao.Size = new System.Drawing.Size(349, 64);
            this.LblProvao.TabIndex = 14;
            this.LblProvao.Text = "Provão Paulista";
            // 
            // TxtMudarNome
            // 
            this.TxtMudarNome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TxtMudarNome.Location = new System.Drawing.Point(15, 141);
            this.TxtMudarNome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtMudarNome.Multiline = true;
            this.TxtMudarNome.Name = "TxtMudarNome";
            this.TxtMudarNome.Size = new System.Drawing.Size(234, 47);
            this.TxtMudarNome.TabIndex = 16;
            // 
            // LblMudarNome
            // 
            this.LblMudarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMudarNome.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LblMudarNome.Location = new System.Drawing.Point(15, 116);
            this.LblMudarNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMudarNome.Name = "LblMudarNome";
            this.LblMudarNome.Size = new System.Drawing.Size(223, 22);
            this.LblMudarNome.TabIndex = 19;
            this.LblMudarNome.Text = "Mudar o Nome de Usuário";
            // 
            // BtnMudar
            // 
            this.BtnMudar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnMudar.Location = new System.Drawing.Point(273, 148);
            this.BtnMudar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnMudar.Name = "BtnMudar";
            this.BtnMudar.Size = new System.Drawing.Size(78, 32);
            this.BtnMudar.TabIndex = 20;
            this.BtnMudar.Text = "mudar";
            this.BtnMudar.UseVisualStyleBackColor = false;
            this.BtnMudar.Click += new System.EventHandler(this.BtnMudarClick);
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnSair.Location = new System.Drawing.Point(15, 216);
            this.BtnSair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(78, 32);
            this.BtnSair.TabIndex = 21;
            this.BtnSair.Text = "Sair da conta";
            this.BtnSair.UseVisualStyleBackColor = false;
            // 
            // lblVoltar
            // 
            this.lblVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoltar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblVoltar.Location = new System.Drawing.Point(15, 289);
            this.lblVoltar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVoltar.Name = "lblVoltar";
            this.lblVoltar.Size = new System.Drawing.Size(57, 22);
            this.lblVoltar.TabIndex = 22;
            this.lblVoltar.Text = "Voltar";
            this.lblVoltar.Click += new System.EventHandler(this.LblVoltarClick);
            // 
            // Configurações
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(648, 328);
            this.Controls.Add(this.lblVoltar);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnMudar);
            this.Controls.Add(this.LblMudarNome);
            this.Controls.Add(this.TxtMudarNome);
            this.Controls.Add(this.LblProQuiz);
            this.Controls.Add(this.LblProvao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Configurações";
            this.Text = "Configurações";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Label lblVoltar;
		private System.Windows.Forms.Button BtnSair;
		private System.Windows.Forms.Button BtnMudar;
		private System.Windows.Forms.Label LblMudarNome;
		private System.Windows.Forms.TextBox TxtMudarNome;
		private System.Windows.Forms.Label LblProvao;
		private System.Windows.Forms.Label LblProQuiz;
	}
}

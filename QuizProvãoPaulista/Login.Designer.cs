/*
 * Created by SharpDevelop.
 * User: willi
 * Date: 05/10/2025
 * Time: 18:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace QuizProvãoPaulista
{
	partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LblPossuiCont = new System.Windows.Forms.Label();
            this.LblSenha = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.BtnAcessar = new System.Windows.Forms.Button();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblProQuiz = new System.Windows.Forms.Label();
            this.LblProvao = new System.Windows.Forms.Label();
            this.LklCadastrar = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LblPossuiCont
            // 
            this.LblPossuiCont.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPossuiCont.ForeColor = System.Drawing.Color.Black;
            this.LblPossuiCont.Location = new System.Drawing.Point(196, 338);
            this.LblPossuiCont.Name = "LblPossuiCont";
            this.LblPossuiCont.Size = new System.Drawing.Size(320, 38);
            this.LblPossuiCont.TabIndex = 21;
            this.LblPossuiCont.Text = "Não possui uma conta?";
            // 
            // LblSenha
            // 
            this.LblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSenha.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LblSenha.Location = new System.Drawing.Point(203, 203);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(100, 27);
            this.LblSenha.TabIndex = 20;
            this.LblSenha.Text = "Senha";
            // 
            // LblEmail
            // 
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LblEmail.Location = new System.Drawing.Point(203, 135);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(233, 27);
            this.LblEmail.TabIndex = 18;
            this.LblEmail.Text = "Email ou Nome de Usuário";
            // 
            // BtnAcessar
            // 
            this.BtnAcessar.BackColor = System.Drawing.Color.Orange;
            this.BtnAcessar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAcessar.Location = new System.Drawing.Point(203, 274);
            this.BtnAcessar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAcessar.Name = "BtnAcessar";
            this.BtnAcessar.Size = new System.Drawing.Size(283, 50);
            this.BtnAcessar.TabIndex = 17;
            this.BtnAcessar.Text = "Acessar";
            this.BtnAcessar.UseVisualStyleBackColor = false;
            this.BtnAcessar.Click += new System.EventHandler(this.BtnAcessarClick);
            // 
            // TxtSenha
            // 
            this.TxtSenha.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TxtSenha.Location = new System.Drawing.Point(203, 233);
            this.TxtSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(287, 22);
            this.TxtSenha.TabIndex = 16;
            this.TxtSenha.UseSystemPasswordChar = true;
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TxtEmail.Location = new System.Drawing.Point(203, 166);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(287, 22);
            this.TxtEmail.TabIndex = 14;
            // 
            // LblProQuiz
            // 
            this.LblProQuiz.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProQuiz.ForeColor = System.Drawing.SystemColors.InfoText;
            this.LblProQuiz.Location = new System.Drawing.Point(23, 62);
            this.LblProQuiz.Name = "LblProQuiz";
            this.LblProQuiz.Size = new System.Drawing.Size(184, 36);
            this.LblProQuiz.TabIndex = 13;
            this.LblProQuiz.Text = "Pro-Quiz";
            // 
            // LblProvao
            // 
            this.LblProvao.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProvao.ForeColor = System.Drawing.Color.DarkOrange;
            this.LblProvao.Location = new System.Drawing.Point(12, 15);
            this.LblProvao.Name = "LblProvao";
            this.LblProvao.Size = new System.Drawing.Size(360, 42);
            this.LblProvao.TabIndex = 12;
            this.LblProvao.Text = "Provão Paulista";
            // 
            // LklCadastrar
            // 
            this.LklCadastrar.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LklCadastrar.LinkColor = System.Drawing.Color.Orange;
            this.LklCadastrar.Location = new System.Drawing.Point(267, 377);
            this.LklCadastrar.Name = "LklCadastrar";
            this.LklCadastrar.Size = new System.Drawing.Size(169, 38);
            this.LklCadastrar.TabIndex = 23;
            this.LklCadastrar.TabStop = true;
            this.LklCadastrar.Text = "Cadastrar";
            this.LklCadastrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LklCadastrarLinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(679, 498);
            this.Controls.Add(this.LklCadastrar);
            this.Controls.Add(this.LblPossuiCont);
            this.Controls.Add(this.LblSenha);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.BtnAcessar);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LblProQuiz);
            this.Controls.Add(this.LblProvao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuizProvãoPaulista";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.LinkLabel LklCadastrar;
		private System.Windows.Forms.Label LblProvao;
		private System.Windows.Forms.Label LblProQuiz;
		private System.Windows.Forms.TextBox TxtEmail;
		private System.Windows.Forms.TextBox TxtSenha;
		private System.Windows.Forms.Button BtnAcessar;
		private System.Windows.Forms.Label LblEmail;
		private System.Windows.Forms.Label LblSenha;
		private System.Windows.Forms.Label LblPossuiCont;
	}
}

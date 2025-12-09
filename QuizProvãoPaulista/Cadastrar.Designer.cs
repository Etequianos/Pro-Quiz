/*
 * Created by SharpDevelop.
 * User: willi
 * Date: 05/10/2025
 * Time: 17:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace QuizProvãoPaulista
{
	partial class Cadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastrar));
            this.LblProvao = new System.Windows.Forms.Label();
            this.LblProQuiz = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtConfirmEmail = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.BtnContinuar = new System.Windows.Forms.Button();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblConfirmEmal = new System.Windows.Forms.Label();
            this.LblSenha = new System.Windows.Forms.Label();
            this.LblPossuiCont = new System.Windows.Forms.Label();
            this.LklLogin = new System.Windows.Forms.LinkLabel();
            this.PnlCadastrar1 = new System.Windows.Forms.Panel();
            this.Email_Invalido = new System.Windows.Forms.Label();
            this.Diferente = new System.Windows.Forms.Label();
            this.PnlCadastrar2 = new System.Windows.Forms.Panel();
            this.CmbPais = new System.Windows.Forms.ComboBox();
            this.LklVoltar = new System.Windows.Forms.LinkLabel();
            this.LblNomeUsuario = new System.Windows.Forms.Label();
            this.LblPais = new System.Windows.Forms.Label();
            this.BtnCriarConta = new System.Windows.Forms.Button();
            this.TxtNomeUsuario = new System.Windows.Forms.TextBox();
            this.PnlCadastrar1.SuspendLayout();
            this.PnlCadastrar2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblProvao
            // 
            this.LblProvao.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProvao.ForeColor = System.Drawing.Color.DarkOrange;
            this.LblProvao.Location = new System.Drawing.Point(3, 6);
            this.LblProvao.Name = "LblProvao";
            this.LblProvao.Size = new System.Drawing.Size(467, 53);
            this.LblProvao.TabIndex = 0;
            this.LblProvao.Text = "Provão Paulista";
            this.LblProvao.Click += new System.EventHandler(this.LblProvao_Click);
            // 
            // LblProQuiz
            // 
            this.LblProQuiz.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProQuiz.ForeColor = System.Drawing.SystemColors.InfoText;
            this.LblProQuiz.Location = new System.Drawing.Point(12, 50);
            this.LblProQuiz.Name = "LblProQuiz";
            this.LblProQuiz.Size = new System.Drawing.Size(200, 36);
            this.LblProQuiz.TabIndex = 2;
            this.LblProQuiz.Text = "Pro-Quiz";
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TxtEmail.Location = new System.Drawing.Point(67, 46);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(287, 22);
            this.TxtEmail.TabIndex = 3;
            // 
            // TxtConfirmEmail
            // 
            this.TxtConfirmEmail.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TxtConfirmEmail.Location = new System.Drawing.Point(66, 134);
            this.TxtConfirmEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtConfirmEmail.Name = "TxtConfirmEmail";
            this.TxtConfirmEmail.Size = new System.Drawing.Size(287, 22);
            this.TxtConfirmEmail.TabIndex = 4;
            // 
            // TxtSenha
            // 
            this.TxtSenha.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TxtSenha.Location = new System.Drawing.Point(67, 212);
            this.TxtSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(287, 22);
            this.TxtSenha.TabIndex = 5;
            // 
            // BtnContinuar
            // 
            this.BtnContinuar.BackColor = System.Drawing.Color.Orange;
            this.BtnContinuar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContinuar.Location = new System.Drawing.Point(67, 260);
            this.BtnContinuar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnContinuar.Name = "BtnContinuar";
            this.BtnContinuar.Size = new System.Drawing.Size(283, 46);
            this.BtnContinuar.TabIndex = 6;
            this.BtnContinuar.Text = "Continuar";
            this.BtnContinuar.UseVisualStyleBackColor = false;
            this.BtnContinuar.Click += new System.EventHandler(this.BtnContinuarClick);
            // 
            // LblEmail
            // 
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LblEmail.Location = new System.Drawing.Point(67, 14);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(100, 22);
            this.LblEmail.TabIndex = 7;
            this.LblEmail.Text = "Email";
            // 
            // LblConfirmEmal
            // 
            this.LblConfirmEmal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConfirmEmal.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LblConfirmEmal.Location = new System.Drawing.Point(66, 94);
            this.LblConfirmEmal.Name = "LblConfirmEmal";
            this.LblConfirmEmal.Size = new System.Drawing.Size(179, 22);
            this.LblConfirmEmal.TabIndex = 8;
            this.LblConfirmEmal.Text = "Confirme Email";
            // 
            // LblSenha
            // 
            this.LblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSenha.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LblSenha.Location = new System.Drawing.Point(67, 182);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(100, 22);
            this.LblSenha.TabIndex = 9;
            this.LblSenha.Text = "Senha";
            // 
            // LblPossuiCont
            // 
            this.LblPossuiCont.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPossuiCont.ForeColor = System.Drawing.Color.Black;
            this.LblPossuiCont.Location = new System.Drawing.Point(68, 315);
            this.LblPossuiCont.Name = "LblPossuiCont";
            this.LblPossuiCont.Size = new System.Drawing.Size(311, 38);
            this.LblPossuiCont.TabIndex = 10;
            this.LblPossuiCont.Text = "Já possui uma conta?";
            // 
            // LklLogin
            // 
            this.LklLogin.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LklLogin.LinkColor = System.Drawing.Color.Orange;
            this.LklLogin.Location = new System.Drawing.Point(153, 354);
            this.LklLogin.Name = "LklLogin";
            this.LklLogin.Size = new System.Drawing.Size(141, 37);
            this.LklLogin.TabIndex = 24;
            this.LklLogin.TabStop = true;
            this.LklLogin.Text = "Login";
            this.LklLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LklLoginLinkClicked);
            // 
            // PnlCadastrar1
            // 
            this.PnlCadastrar1.Controls.Add(this.Email_Invalido);
            this.PnlCadastrar1.Controls.Add(this.Diferente);
            this.PnlCadastrar1.Controls.Add(this.LblSenha);
            this.PnlCadastrar1.Controls.Add(this.LblPossuiCont);
            this.PnlCadastrar1.Controls.Add(this.LklLogin);
            this.PnlCadastrar1.Controls.Add(this.LblConfirmEmal);
            this.PnlCadastrar1.Controls.Add(this.LblEmail);
            this.PnlCadastrar1.Controls.Add(this.BtnContinuar);
            this.PnlCadastrar1.Controls.Add(this.TxtSenha);
            this.PnlCadastrar1.Controls.Add(this.TxtConfirmEmail);
            this.PnlCadastrar1.Controls.Add(this.TxtEmail);
            this.PnlCadastrar1.Location = new System.Drawing.Point(148, 89);
            this.PnlCadastrar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlCadastrar1.Name = "PnlCadastrar1";
            this.PnlCadastrar1.Size = new System.Drawing.Size(398, 393);
            this.PnlCadastrar1.TabIndex = 25;
            // 
            // Email_Invalido
            // 
            this.Email_Invalido.ForeColor = System.Drawing.Color.Red;
            this.Email_Invalido.Location = new System.Drawing.Point(66, 70);
            this.Email_Invalido.Name = "Email_Invalido";
            this.Email_Invalido.Size = new System.Drawing.Size(117, 23);
            this.Email_Invalido.TabIndex = 26;
            this.Email_Invalido.Text = "Email inválido";
            this.Email_Invalido.Visible = false;
            // 
            // Diferente
            // 
            this.Diferente.ForeColor = System.Drawing.Color.Red;
            this.Diferente.Location = new System.Drawing.Point(64, 158);
            this.Diferente.Name = "Diferente";
            this.Diferente.Size = new System.Drawing.Size(331, 23);
            this.Diferente.TabIndex = 25;
            this.Diferente.Text = "O email digitado não é o mesmo do campo  anterior!";
            this.Diferente.Visible = false;
            // 
            // PnlCadastrar2
            // 
            this.PnlCadastrar2.Controls.Add(this.CmbPais);
            this.PnlCadastrar2.Controls.Add(this.LklVoltar);
            this.PnlCadastrar2.Controls.Add(this.LblNomeUsuario);
            this.PnlCadastrar2.Controls.Add(this.LblPais);
            this.PnlCadastrar2.Controls.Add(this.BtnCriarConta);
            this.PnlCadastrar2.Controls.Add(this.TxtNomeUsuario);
            this.PnlCadastrar2.Enabled = false;
            this.PnlCadastrar2.Location = new System.Drawing.Point(148, 88);
            this.PnlCadastrar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlCadastrar2.Name = "PnlCadastrar2";
            this.PnlCadastrar2.Size = new System.Drawing.Size(405, 402);
            this.PnlCadastrar2.TabIndex = 26;
            this.PnlCadastrar2.Visible = false;
            // 
            // CmbPais
            // 
            this.CmbPais.FormattingEnabled = true;
            this.CmbPais.Items.AddRange(new object[] {
            "Afeganistão",
            "Brasil",
            "Canadá",
            "China",
            "Estados Unidos",
            "França",
            "Índia ",
            "Japão"});
            this.CmbPais.Location = new System.Drawing.Point(68, 92);
            this.CmbPais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbPais.Name = "CmbPais";
            this.CmbPais.Size = new System.Drawing.Size(219, 24);
            this.CmbPais.Sorted = true;
            this.CmbPais.TabIndex = 27;
            this.CmbPais.Text = "Brasil";
            // 
            // LklVoltar
            // 
            this.LklVoltar.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LklVoltar.LinkColor = System.Drawing.Color.Orange;
            this.LklVoltar.Location = new System.Drawing.Point(156, 286);
            this.LklVoltar.Name = "LklVoltar";
            this.LklVoltar.Size = new System.Drawing.Size(98, 37);
            this.LklVoltar.TabIndex = 24;
            this.LklVoltar.TabStop = true;
            this.LklVoltar.Text = "Voltar";
            this.LklVoltar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LklVoltarLinkClicked);
            // 
            // LblNomeUsuario
            // 
            this.LblNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomeUsuario.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LblNomeUsuario.Location = new System.Drawing.Point(68, 135);
            this.LblNomeUsuario.Name = "LblNomeUsuario";
            this.LblNomeUsuario.Size = new System.Drawing.Size(164, 27);
            this.LblNomeUsuario.TabIndex = 8;
            this.LblNomeUsuario.Text = "Nome de Usuário";
            // 
            // LblPais
            // 
            this.LblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPais.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LblPais.Location = new System.Drawing.Point(68, 50);
            this.LblPais.Name = "LblPais";
            this.LblPais.Size = new System.Drawing.Size(164, 27);
            this.LblPais.TabIndex = 7;
            this.LblPais.Text = "País de Residência";
            // 
            // BtnCriarConta
            // 
            this.BtnCriarConta.BackColor = System.Drawing.Color.Orange;
            this.BtnCriarConta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCriarConta.Location = new System.Drawing.Point(68, 217);
            this.BtnCriarConta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCriarConta.Name = "BtnCriarConta";
            this.BtnCriarConta.Size = new System.Drawing.Size(283, 50);
            this.BtnCriarConta.TabIndex = 6;
            this.BtnCriarConta.Text = "CriarConta";
            this.BtnCriarConta.UseVisualStyleBackColor = false;
            this.BtnCriarConta.Click += new System.EventHandler(this.BtnCriarContaClick);
            // 
            // TxtNomeUsuario
            // 
            this.TxtNomeUsuario.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TxtNomeUsuario.Location = new System.Drawing.Point(68, 170);
            this.TxtNomeUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNomeUsuario.Name = "TxtNomeUsuario";
            this.TxtNomeUsuario.Size = new System.Drawing.Size(287, 22);
            this.TxtNomeUsuario.TabIndex = 4;
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(679, 523);
            this.Controls.Add(this.PnlCadastrar2);
            this.Controls.Add(this.PnlCadastrar1);
            this.Controls.Add(this.LblProQuiz);
            this.Controls.Add(this.LblProvao);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Cadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuizProvãoPaulista";
            this.Load += new System.EventHandler(this.Cadastrar_Load);
            this.PnlCadastrar1.ResumeLayout(false);
            this.PnlCadastrar1.PerformLayout();
            this.PnlCadastrar2.ResumeLayout(false);
            this.PnlCadastrar2.PerformLayout();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label Email_Invalido;
		private System.Windows.Forms.Label Diferente;
		private System.Windows.Forms.ComboBox CmbPais;
		private System.Windows.Forms.TextBox TxtNomeUsuario;
		private System.Windows.Forms.Button BtnCriarConta;
		private System.Windows.Forms.Label LblPais;
		private System.Windows.Forms.Label LblNomeUsuario;
		private System.Windows.Forms.LinkLabel LklVoltar;
		private System.Windows.Forms.Panel PnlCadastrar2;
		private System.Windows.Forms.Panel PnlCadastrar1;
		private System.Windows.Forms.LinkLabel LklLogin;
		private System.Windows.Forms.Label LblPossuiCont;
		private System.Windows.Forms.Label LblSenha;
		private System.Windows.Forms.Label LblConfirmEmal;
		private System.Windows.Forms.Label LblEmail;
		private System.Windows.Forms.Button BtnContinuar;
		private System.Windows.Forms.TextBox TxtSenha;
		private System.Windows.Forms.TextBox TxtConfirmEmail;
		private System.Windows.Forms.TextBox TxtEmail;
		private System.Windows.Forms.Label LblProQuiz;
		private System.Windows.Forms.Label LblProvao;

	}
}

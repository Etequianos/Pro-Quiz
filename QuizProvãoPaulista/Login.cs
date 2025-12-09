/*
 * Created by SharpDevelop.
 * User: willi
 * Date: 05/10/2025
 * Time: 18:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace QuizProvãoPaulista
{
	/// <summary>
	/// Description of Cadastro_Secundaparte.
	/// </summary>
	public partial class Login : Form
	{
		public Login()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}


		void LklCadastrarLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Cadastrar Cadastrar = new Cadastrar();
			Cadastrar.Show();
			this.Close();
		}
		
		string arquivo = "usuarios.txt";
		
		void BtnAcessarClick(object sender, EventArgs e)
		{	
			string usuario = TxtEmail.Text.Trim();
			string nome_usuario = TxtEmail.Text.Trim();;
			string senha = TxtSenha.Text.Trim();
			
			if(!File.Exists(arquivo)){
				MessageBox.Show("Nenhum usuário cadastrado");
				return;
			}
			
			bool encontrado = false;
			foreach (string linha in File.ReadAllLines(arquivo)){
				string [] dados = linha.Split(';');
				if( dados.Length > 3 && (dados[0] == usuario || dados[3] == nome_usuario) && dados[1] == senha){
						MessageBox.Show("Seu login foi realizado com sucesso!");
						MessageBox.Show("bem vindo(a) " + nome_usuario);
						encontrado = true;					
						MainForm MainForm = new MainForm(usuario, 0);
						MainForm.Show();
						this.Close();
					}
				}
			
			if(encontrado == false){
				MessageBox.Show("Usuario ou senha incoretos!");
			}
		}
		
		
	}
}

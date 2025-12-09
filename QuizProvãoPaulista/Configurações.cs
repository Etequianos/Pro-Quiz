/*
 * Created by SharpDevelop.
 * User: Aluno
 * Date: 13/10/2025
 * Time: 14:52
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
	/// Description of Configurações.
	/// </summary>
	public partial class Configurações : Form
	{

		public string name;
		
		public Configurações(string username)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			name = username;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		string arquivo = "usuarios.txt";
		
		void LblVoltarClick(object sender, EventArgs e)
		{
			MainForm MainForm = new MainForm(name, 0);
			MainForm.Show();
		}
		
		void BtnMudarClick(object sender, EventArgs e)
		{
			string[] linhas = File.ReadAllLines(arquivo);
			string novonome = TxtMudarNome.Text.Trim();
			
			for(int i = 0;i< linhas.Length; i++){
				string[] parts = linhas[i].Split(';');
				
				if(name == parts[0]){
					parts[3] = novonome;
					linhas[i]= string.Join(";",parts);
				}
			}
			File.WriteAllLines(arquivo,linhas);
		
		}
	}
}


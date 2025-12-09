/*
 * Created by SharpDevelop.
 * User: willi
 * Date: 05/10/2025
 * Time: 17:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace QuizProvãoPaulista
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }


        void BtnContinuarClick(object sender, EventArgs e)
        {
            string usuario = TxtEmail.Text.Trim();
            string confirm_usuario = TxtConfirmEmail.Text.Trim();
            string senha = TxtSenha.Text.Trim();
            string pais = CmbPais.Text.Trim().ToString();
            string nome_usuario = TxtNomeUsuario.Text.Trim();
            bool emailValido = false;
            bool confirmEmailValido = false;


            if (!usuario.Contains("@gmail") && !usuario.Contains("@Gmail"))
            {
                Email_Invalido.Visible = true;
                emailValido = false;
            }

            else if (!usuario.Contains(".com"))
            {
                Email_Invalido.Visible = true;
                emailValido = false;
            }

            else
            {
                Email_Invalido.Visible = false;
                emailValido = true;
            }

            if(!confirm_usuario.Contains("@gmail") && !confirm_usuario.Contains("@Gmail")) {
                Diferente.Text = "Email  Inválido";
                Diferente.Visible = true;
                confirmEmailValido = false;
            }
            
            
            
            else if (confirm_usuario != usuario)
            {
                Diferente.Visible = true;
                confirmEmailValido = false;
            }

            else
            {
                Diferente.Visible = false;
                confirmEmailValido = true;
            }

            if (emailValido == true && confirmEmailValido == true)
            {
                Diferente.Visible = false;
                PnlCadastrar2.Enabled = true;
                PnlCadastrar2.Visible = true;
            }


        }


        string arquivo = "usuarios.txt";
        void BtnCriarContaClick(object sender, EventArgs e)
        {
            string usuario = TxtEmail.Text.Trim();
            string confirm_usuario = TxtConfirmEmail.Text.Trim();
            string senha = TxtSenha.Text.Trim();
            string pais = CmbPais.Text.Trim().ToString();
            string nome_usuario = TxtNomeUsuario.Text.Trim();

            if (usuario == "" || confirm_usuario == "" || senha == "" || pais == "" || nome_usuario == "")
            {
                MessageBox.Show("Algum campo não foi preenchido!");
                MessageBox.Show("Volte para primeira parte e preencha todos os campos!");
            }

            else
            {
                bool cadastrado = false;
                if (File.Exists(arquivo))
                {
                    foreach (string linha in File.ReadAllLines(arquivo))
                    {
                        string[] dados = linha.Split(';');
                        if (dados[0] == usuario)
                        {
                            MessageBox.Show("Usuário já cadastrado.");
                            cadastrado = true;
                        }
                    }
                }
                if (cadastrado == false)
                {
                    using (StreamWriter sw = File.AppendText(arquivo))
                    {
                        sw.WriteLine(usuario + ";" + senha + ";" + pais + ";" + nome_usuario);
                    }

                    TxtEmail.Clear();
                    TxtConfirmEmail.Clear();
                    TxtSenha.Clear();
                    TxtNomeUsuario.Clear();
                    MessageBox.Show("Usuário cadastrado com sucesso.");
                    MessageBox.Show("Bem-vindo(a) " + nome_usuario);
                    MainForm MainForm = new MainForm(nome_usuario, 0);
                    MainForm.Show();
                    this.Close();
                }

                else
                {
                    TxtEmail.Clear();
                    TxtConfirmEmail.Clear();
                    TxtSenha.Clear();
                    TxtNomeUsuario.Clear();

                    MessageBox.Show("Algum campo não foi preenchido");
                    MessageBox.Show("Volte para página anterior e preencha todos os campos!");

                }

            }
        }

        void LklLoginLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Login Login = new Login();
            Login.Show();
            this.Close();
        }


        void LklVoltarLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PnlCadastrar2.Enabled = false;
            PnlCadastrar2.Visible = false;
        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void LblProvao_Click(object sender, EventArgs e)
        {

        }
    }
}

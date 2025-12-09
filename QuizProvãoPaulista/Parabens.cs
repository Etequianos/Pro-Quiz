using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuizProvãoPaulista
{
    public partial class Parabens : Form
    {

        string username;
        int wrongs;
        int corrects;
        public int ofensiva;
        public Parabens(string usuario, int erros, int acertos, int sequencia)
        {
            InitializeComponent();
            username = usuario;
            wrongs = erros;
            corrects = acertos;
            ofensiva = sequencia + 1;
            Lblpontos.Text = "Você teve: " + corrects + " acertos " + "e " + wrongs + " erros";

        }
        
        string caminhoArquivo = "pontuacoes.txt";
        string arquivo = "usuarios.txt";

        private void BtnVoltarPagInicial_Click_1(object sender, EventArgs e)
        {
            using (StreamWriter sw = File.AppendText(caminhoArquivo))
            {
                sw.WriteLine(username + ";" + corrects + "; " + ofensiva);
            }

                MainForm telaprincipal = new MainForm(username, ofensiva);
                telaprincipal.Show();
                this.Close();

            }
        }
            }

            

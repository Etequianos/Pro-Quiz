/*
 * Created by SharpDevelop.
 * User: willi
 * Date: 05/10/2025
 * Time: 19:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace QuizProvãoPaulista
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {

        string name;
        int ofensiva;

        string arquivo = "usuarios.txt";
        string caminhoArquivo = "pontuacoes.txt";

        public MainForm(string usuario, int sequencia)
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            name = usuario;

            string[] linhas = File.ReadAllLines(caminhoArquivo);

            for (int i = 0; i < linhas.Length; i++)
            {
                string[] parts = linhas[i].Split(';');

                // Linha incompleta → ignora
                if (parts.Length < 3)
                    continue;

                if (name == parts[0])
                {
                    ofensiva = int.Parse(parts[2]);
                    LblSequencia.Text = ofensiva.ToString();
                    break; // Achou o usuário, parar o loop
                }
            }

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        void BtnVisualizar1Click(object sender, EventArgs e)
        {
            Quiz viewQuiz = new Quiz(name);
            viewQuiz.Show();
            this.Hide();
        }

        void LblRecentesClick(object sender, EventArgs e)
        {
            LblRecentes.ForeColor = Color.FromName("Orange");
            LblSimulados.ForeColor = Color.FromName("WindowFrame");
            lblRanking.ForeColor = Color.FromName("WindowFrame");
            LblQuiz.ForeColor = Color.FromName("WindowFrame");

            PnlRescentes.Enabled = true;
            PnlRescentes.Visible = true;

            PnlSimulados.Enabled = false;
            PnlSimulados.Visible = false;
            PnlQuizGeral.Enabled = false;
            PnlQuizGeral.Visible = false;
            PnlRanking.Enabled = false;
            PnlRanking.Visible = false;
        }

        void LblSimuladosClick(object sender, EventArgs e)
        {
            LblRecentes.ForeColor = Color.FromName("WindowFrame");
            LblSimulados.ForeColor = Color.FromName("Orange");
            lblRanking.ForeColor = Color.FromName("WindowFrame");
            LblQuiz.ForeColor = Color.FromName("WindowFrame");

            PnlSimulados.Enabled = true;
            PnlSimulados.Visible = true;

            PnlRescentes.Enabled = false;
            PnlRescentes.Visible = false;
            PnlQuizGeral.Enabled = false;
            PnlQuizGeral.Visible = false;
            PnlRanking.Enabled = false;
            PnlRanking.Visible = false;
        }

        void LblQuizClick(object sender, EventArgs e)
        {
            LblRecentes.ForeColor = Color.FromName("WindowFrame");
            LblSimulados.ForeColor = Color.FromName("WindowFrame");
            lblRanking.ForeColor = Color.FromName("WindowFrame");
            LblQuiz.ForeColor = Color.FromName("Orange");

            PnlQuizGeral.Enabled = true;
            PnlQuizGeral.Visible = true;

            PnlRescentes.Enabled = false;
            PnlRescentes.Visible = false;
            PnlSimulados.Enabled = false;
            PnlSimulados.Visible = false;
            PnlRanking.Enabled = false;
            PnlRanking.Visible = false;
        }

        void LblRankingClick(object sender, EventArgs e)
        {
            LblRecentes.ForeColor = Color.FromName("WindowFrame");
            LblSimulados.ForeColor = Color.FromName("WindowFrame");
            lblRanking.ForeColor = Color.FromName("Orange");
            LblQuiz.ForeColor = Color.FromName("WindowFrame");

            PnlRanking.Enabled = true;
            PnlRanking.Visible = true;

            PnlQuizGeral.Visible = true;
            PnlQuizGeral.Enabled = true;
            PnlRescentes.Enabled = false;
            PnlRescentes.Visible = false;
            PnlRanking.BringToFront();

            try
            {
                string caminhoArquivo = "pontuacoes.txt";
                if (!File.Exists(caminhoArquivo))
                {
                    return;
                }

                string[] linhas = File.ReadAllLines(caminhoArquivo);
                int qtd = linhas.Length;

                string[] nomes = new string[qtd];
                int[] pontos = new int[qtd];
                int contador = 0;

                foreach (string linha in linhas)
                {
                    string[] partes = linha.Split(';');

                    if (partes.Length == 3)
                    {
                        string nome = partes[0].Trim();
                        int valor;

                        if (int.TryParse(partes[1].Trim(), out valor))
                        {
                            nomes[contador] = nome;
                            pontos[contador] = valor;
                            contador++;
                        }
                    }
                }

                for (int i = 0; i < contador - 1; i++)
                {
                    for (int j = i + 1; j < contador; j++)
                    {
                        if (pontos[j] > pontos[i])
                        {
                            int tempPontos = pontos[i];
                            pontos[i] = pontos[j];
                            pontos[j] = tempPontos;

                            string tempNome = nomes[i];
                            nomes[i] = nomes[j];
                            nomes[j] = tempNome;
                        }
                    }
                }

                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridView1.Columns.Add("Posicao", "Posição");
                dataGridView1.Columns.Add("Nome", "Nome");
                dataGridView1.Columns.Add("Pontos", "Pontos");

                for (int i = 0; i < contador; i++)
                {
                    dataGridView1.Rows.Add((i + 1).ToString() + "º", nomes[i], pontos[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar o arquivo: " + ex.Message);
            }
        }

        void PictureBox2Click(object sender, EventArgs e)
        {
            Configurações tela_configuracoes = new Configurações(name);
            tela_configuracoes.Show();
        }
    }
}

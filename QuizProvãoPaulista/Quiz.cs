using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace QuizProvãoPaulista
{
    public partial class Quiz : Form
    {
       public int sequencia;

        public string username;
        public int wrongs;
        public int corrects;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
             int nLeftRect,
             int nTopRect,
             int nRightRect,
             int nBottomRect,
             int nWidthEllipse,
             int nHeightEllipse
         );
        private PrivateFontCollection font = new PrivateFontCollection();

        private int current_aswer = 0;
        private string[,] aswers = {
            {
                "Questão 01",
                "Um fazendeiro tem uma grande área ao lado de um rio, que será cercada para acomodar\r\nno novo rebanho de gado. Por conta das condições do terreno, a região a ser cercada\r\napresenta o formato de um trapézio retângulo, com um par de lados paralelos, sendo que\r\nnum deles tem o dobro do tamanho do outro, como mostra a figura.",
                "./Questions/01.png",
                "Considerando que a cerca terá 4 km de extensão e que ao longo da margem do rio não\r\nhaverá cerca, a maior área que o fazendeiro conseguirá cercar é igual a"
            },
            {
                "Questão 02",
                "Considere que, no esquema simplificado da figura a seguir, a face mostrada da Terra é referente a seu Polo Norte geográfico.",
                "./Questions/02.png",
                "Sabendo que o Sol nasce no mesmo sentido em que flui o rio Amazonas e se põe na direção contrária, tem-se que o Sol nasce no ___________ e que a rotação da Terra\r\nem torno de seu próprio eixo, em relação à figura, deve ser no sentido ___________.\r\nAs lacunas do texto são preenchidas, respectivamente, por:  "
            },
            {
                "Questão 03",
                "O sashimi (filé de peixe cru) de baiacu é uma iguaria muito apreciada no Japão. Entretanto, sua ingestão pode causar a morte por parada respiratória, pois esse peixe contém uma\r\npotente neurotoxina termoestável, a tetrodotoxina, que é\r\nproduzida e armazenada nas gônadas e vísceras.",
                "./Questions/03.png",
                "Que ação poderia evitar essa intoxicação?"
            },
            {
                "Questão 04",
                "A produção de vacinas exige uma sequência de procedimentos, além do cumprimento estrito de verificações de segurança. No esquema, estão demonstradas as etapas básicas realizadas\r\npara a fabricação de uma vacina utilizando a tecnologia tradicional\r\ne o efeito dela no organismo.",
                "./Questions/04.png",
                "O antígeno utilizado na vacina causa um efeito protetor contra\r\no vírus porque"
            },
            {
                "Questão 05",
                "Na cantina de uma escola, há cinco alimentos vendidos em pacotes com diferentes quantidades de porções. As informações nutricionais contidas nos rótulos desses\r\nprodutos estão indicadas nas imagens.",
                "./Questions/05.png",
                "Uma estudante opta sempre pelo alimento com a menor quantidade total de sódio por pacote.\r\nQual desses produtos deve ser o escolhido pela estudante?"
            },
            {
                "Questão 06",
                "A artista Marija Tiurina criou uma série chamada Palavras intraduzíveis, com diversas ilustrações detalhadas que transmitem o sentido desses vocábulos, que nenhuma palavra\r\núnica em outras línguas pode descrever.",
                "./Questions/06.png",
                "O uso do texto verbal nesse desenho assume a função de"
            },
            {
                "Questão 07",
                "Carro elétrico, uma miragem ecológica. A mudança para a eletromobilidade de fato promove umanalteração no consumo de recursos naturais. Hoje, amplamente\r\ndependentes do petróleo, nossos modais de transporte poderiam\r\nse tornar cada vez mais dependentes de trinta metais raros. Gálio,\r\ntântalo, cobalto, platinoides, tungstênio, metais de terras-raras: uma\r\nmina contém apenas ínfimas quantidades desses metais dotados\r\nde fabulosas propriedades eletrônicas, ópticas e magnéticas.",
                "./Questions/07.png",
                "No que se refere ao desenvolvimento sustentável, a charge e o\r\ntexto indicam uma contradição no uso da tecnologia alternativa\r\nderivada do seguinte aspecto:"
            },
            {
                "Questão 08",
                "O retrato como gênero da pintura ocidental ficou vinculado às elites, tornando invisíveis as populações que não faziam parte do círculo dominante. Num país de tradição escravocrata e\r\ncolonizado por europeus como o Brasil, pouquíssimas pessoas negras e indígenas foram retratadas em pintura, e menos ainda\r\nidentificadas com seus nomes nos retratos. Daí a importância, para a história da arte e para a história brasileira, dos retratos\r\nde Dalton Paula.",
                "./Questions/08.png",
                "Ao dar protagonismo a Zeferina e a João de Deus Nascimento,\r\no artista Dalton Paula evidencia que a(s)"
            },
            {
                "Questão 09",
                "A seguir um personagem icônico no universo dos animes:",
                "./Questions/09.png",
                "Quem é o pai de Naruto Uzumaki?"
            },
            {
                "Questão 10",
                "A seguir um personagem icônico do anime mais popular:",
                "./Questions/10.png",
                "Qual o nome desse anime?"
            }
        };
        private string[,] options =
        {
            {
                "0,6m2",
                "0,2m3",
                "0,6km2",
                "0.4hm2",
                "0,9mm2"
            },
            {
                "Oeste – anti-horário.",
                "Leste – anti-horário.",
                "Leste – horário.",
                "Sul – anti-horário.",
                "Oeste – horário."
            },
            {
                "Criar os peixes em cativeiro",
                "Realizar a pesca com redes.",
                "Consumir peixes cozidos ou fritos",
                "Preparar o peixe em condições adequadas de higiene.",
                "Manusear o peixe sem provocar o rompimento dos órgãos\r\ninternos."
            },
            {
                "mata o vírus pela ligação.",
                "aglutina o vírus por associação.",
                "contém imunoglobulinas de defesa.",
                "induz a produção de proteínas neutralizadoras.",
                "mantém a quantidade de anticorpos preexistentes"
            },
            {
                "Batata chips.",
                "Palitos salgados",
                "Biscoito multigrãos.",
                "Biscoito de polvilho",
                "Biscoito de água e sal"
            },
            {
                "descrever de forma técnica a ilustração.",
                "destacar os múltiplos sentidos do verbete.",
                "explicar o significado da expressão ilustrada.",
                "apresentar termos equivalentes em outras línguas.",
                "apontar para a dificuldade de compreensão do termo."
            },
            {
                "Necessidade de fontes não renováveis.",
                "Padronização dos modelos produtivos.",
                "Demanda de mão de obra qualificada.",
                "Precariedade da legislação industrial.",
                "Utilização de materiais recicláveis."
            },
            {
                "arte pode promover formas de afirmação de identidade social.",
                "comunidades periféricas passam a adquirir o gênero retrato.",
                "personagens retratadas simbolizam a sociedade brasileira.",
                "pintura funciona como instrumento de ascensão social",
                "imagens tradicionais preservam memórias afetivas."
            },
            {
                "Susuke",
                "Madara",
                "Himawari",
                "Minato Uzumaki",
                "Sakura"
            },
            {
                "Naruto",
                "Solo Leving",
                "Jujustu Kaisen",
                "Darling in the Franxx",
                "Let's Play"
            }
        };
        private string[] corrent_options =
        {
           "0,6km2",
           "Leste – anti-horário.",
           "Manusear o peixe sem provocar o rompimento dos órgãos\r\ninternos.",
           "induz a produção de proteínas neutralizadoras.",
           "Batata chips.",
           "explicar o significado da expressão ilustrada.",
           "Necessidade de fontes não renováveis.",
           "arte pode promover formas de afirmação de identidade social.",
           "Minato Uzumaki",
           "Jujustu Kaisen"
        };

        public Quiz(string user)
        {
            username = user;

            InitializeComponent();

            btnClose.BackgroundImage = Properties.Resources.Close;

            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            btnFinalQuiz.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnFinalQuiz.Width, btnFinalQuiz.Height, 7, 7));
            btnNextQuestion.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnNextQuestion.Width, btnNextQuestion.Height, 7, 7));

            loadQuestion();
        }

        void loadQuestion()
        {
            lblQuestionNumber.Text = aswers[current_aswer, 0];
            lblQuestionStory.Text = aswers[current_aswer, 1];
            picQuestionQuiz.ImageLocation = aswers[current_aswer, 2];
            lblCommandOfQuestion.Text = aswers[current_aswer, 3];

            Label[] lblOptions = { lblA, lblB, lblC, lblD, lblE };


            for (int i = 0; i < lblOptions.Length; i++)
            {
                lblOptions[i].Text = options[current_aswer, i].ToString();
            }
        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            font.AddFontFile("./Fonts/Inter_18pt-Bold.ttf");
            lblQuestionNumber.Font = new Font(font.Families[0], 27.0f, FontStyle.Bold);
            lblQuestionStory.Font = new Font(font.Families[0], 13.0f, FontStyle.Regular);
            lblCommandOfQuestion.Font = new Font(font.Families[0], 13.0f, FontStyle.Regular);
            lblExitQuiz.Font = new Font(font.Families[0], 10.0f, FontStyle.Bold);
            lblAlternativeA.Font = new Font(font.Families[0], 11.0f, FontStyle.Regular);
            lblA.Font = new Font(font.Families[0], 10.0f, FontStyle.Regular);
            btnFinalQuiz.Font = new Font(font.Families[0], 9.0f, FontStyle.Bold);
            btnNextQuestion.Font = new Font(font.Families[0], 9.0f, FontStyle.Bold);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblExitQuiz_Click(object sender, EventArgs e)
        {
            
            MainForm home = new MainForm(username, sequencia);
            home.Show();
            this.Hide();
        }

        private void btnLogin_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;

            Color borderColor = Color.FromArgb(238, 167, 32);

            int thickness = 5;

            using (Pen p = new Pen(borderColor, thickness))
            {
                p.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                e.Graphics.DrawLine(
                    p,
                    0,                    
                    btn.Height - 1,       
                    btn.Width - 1,         
                    btn.Height - 1
                );
            }
        }

        private void A_Click(object sender, EventArgs e)
        {
            A.BackColor = Color.FromArgb(255, 181, 42);
            A.BackgroundImage = Properties.Resources.x;
            Button[] btnOptions = { A, B, C, D, E };
            foreach (Button option in btnOptions)
            {
                option.Enabled = false;
            }


            if (current_aswer + 1 >= aswers.GetLength(0))
            {
                btnFinalQuiz.Visible = true;
                return;
            }
            else
            {
                btnNextQuestion.Visible = true;
            }

            if (options[current_aswer, 0] == corrent_options[current_aswer])
            {
                corrects++;
                return;
            }
            wrongs++;
        }
        void B_Click(object sender, EventArgs e)
        {
            B.BackColor = Color.FromArgb(255, 181, 42);
            B.BackgroundImage = Properties.Resources.x;
            Button[] btnOptions = { A, B, C, D, E };
            foreach (Button option in btnOptions)
            {
                option.Enabled = false;
            }


            if (current_aswer + 1 >= aswers.GetLength(0))
            {
                btnFinalQuiz.Visible = true;
                return;
            }
            else
            {
                btnNextQuestion.Visible = true;
            }

            if (options[current_aswer, 1] == corrent_options[current_aswer])
            {
                corrects++;
                return;
            }
            wrongs++;
        }

        void C_Click(object sender, EventArgs e)
        {
            C.BackColor = Color.FromArgb(255, 181, 42);
            C.BackgroundImage = Properties.Resources.x;
            Button[] btnOptions = { A, B, C, D, E };
            foreach (Button option in btnOptions)
            {
                option.Enabled = false;
            }

            if (current_aswer + 1 >= aswers.GetLength(0))
            {
                btnFinalQuiz.Visible = true;
                return;
            }
            else
            {
                btnNextQuestion.Visible = true;
            }

            if (options[current_aswer, 2] == corrent_options[current_aswer])
            {
                corrects++;
                return;
            }
            wrongs++;
        }

        void D_Click(object sender, EventArgs e)
        {
            D.BackColor = Color.FromArgb(255, 181, 42);
            D.BackgroundImage = Properties.Resources.x;
            Button[] btnOptions = { A, B, C, D, E };
            foreach (Button option in btnOptions)
            {
                option.Enabled = false;
            }

            if (current_aswer + 1 >= aswers.GetLength(0))
            {
                btnFinalQuiz.Visible = true;
                return;
            }
            else
            {
                btnNextQuestion.Visible = true;
            }


            if (options[current_aswer, 3] == corrent_options[current_aswer])
            {
                corrects++;
                return;
            }
            wrongs++;
        }
        void E_Click(object sender, EventArgs e)
        {
            E.BackColor = Color.FromArgb(255, 181, 42);
            E.BackgroundImage = Properties.Resources.x;
            Button[] btnOptions = { A, B, C, D, E };
            foreach (Button option in btnOptions)
            {
                option.Enabled = false;
            }


            if (current_aswer + 1 >= aswers.GetLength(0))
            {
                btnFinalQuiz.Visible = true;
                return;
            }
            else
            {
                btnNextQuestion.Visible = true;
            }

            if (options[current_aswer, 4] == corrent_options[current_aswer])
            {
                corrects++;
                return;
            }
            wrongs++;
        }


        void btnNextQuestion_Click(object sender, EventArgs e)
        {
            if (current_aswer + 1 >= aswers.Length) return;
            current_aswer++;
            loadQuestion();

            Button[] btnOptions = { A, B, C, D, E };
            foreach (Button option in btnOptions)
            {
                option.BackColor = Color.FromArgb(230, 230, 230);
                option.BackgroundImage = null;
                option.Enabled = true;
            }
            btnNextQuestion.Visible = false;
        }

        private void btnFinalQuiz_Click(object sender, EventArgs e)
        {
            Parabens telaparabens = new Parabens(username, wrongs, corrects, sequencia);
            telaparabens.Show();
            this.Close();
        }

        private void lblA_Click(object sender, EventArgs e)
        {

        }

        private void lblB_Click(object sender, EventArgs e)
        {

        }

        private void lblC_Click(object sender, EventArgs e)
        {

        }

        private void lblD_Click(object sender, EventArgs e)
        {

        }

        private void lblE_Click(object sender, EventArgs e)
        {

        }

        private void lblAlternativeA_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

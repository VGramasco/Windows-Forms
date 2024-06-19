using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;
using System.Reflection.Emit;
using static System.Windows.Forms.DataFormats;
using System.Diagnostics.Contracts;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Security.Claims;

namespace Suits
{
    public partial class Form1 : Form
    {
        public Form1()
        {


            InitializeComponent();

            // Adicionando itens à ListBox
            listBox1.Items.Add("• A série é baseada na vida de Aaron Korsh");
            listBox1.Items.Add("• Aaron Korsh previu a saída de Meghan Markle");
            listBox1.Items.Add("• Meghan Markle precisou mudar o figurino de última hora para o teste");
            listBox1.Items.Add("• O personagem Harvey teve influência da família verdadeira de Gabriel Macht");
            listBox1.Items.Add("• Patrick J. Adams acredita que Suits faz as pessoas “se sentirem bem”");
            listBox1.Items.Add("• Jessica poderia ter sido assassinada");
            // A linha abaixo associa o evento.
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;

            label1.AutoSize = true;
            label1.MaximumSize = new Size(200, 0); 
            label1.TextAlign = ContentAlignment.TopLeft;

            comboBox1.Items.Add("• Gabriel Macht");
            comboBox1.Items.Add("• Patrick Adams");
            comboBox1.Items.Add("• Sarah Rafferty");
            comboBox1.Items.Add("• Rick Hoofman");
            comboBox1.Items.Add("• Megan Markle");
            comboBox1.Items.Add("• Gina Torres");

            comboBox2.Items.Add("• Temporada 1");
            comboBox2.Items.Add("• Temporada 2");
            comboBox2.Items.Add("• Temporada 3");
            comboBox2.Items.Add("• Temporada 4");
            comboBox2.Items.Add("• Temporada 5");
            comboBox2.Items.Add("• Temporada 6");
            comboBox2.Items.Add("• Temporada 7");
            comboBox2.Items.Add("• Temporada 8");
            comboBox2.Items.Add("• Temporada 9");

            label4.Text = "Mike Ross(Patrick J.Adams) é um garoto que abandonou a faculdade de direito mas, brilhante como é, consegue uma entrevista com o respeitado Harvey Specter(Gabriel Macht), um dos melhores advogados de Manhattan. Quando percebe o talento nato e a memória fotográfica do garoto, Harvey o contrata e, juntos, eles formam uma dupla imbatível. Mesmo sendo um gênio, Mike ainda tem muito a aprender sobre o Direito. E mesmo sendo um advogado tão competente, Harvey irá aprender com sua nova dupla a ver seus clientes de outra maneira. A princípio, ambos mentem para que Mike possa trabalhar na firma Pearson Hardman, um escritório de advocacia com uma política de aceitar apenas ex-alunos da Escola de Direito de Harvard. Além da parceria no âmbito profissional, Harvey e Mike criam um forte laço de amizade um com o outro à medida em que resolvem novos casos todos os dias. Rachel Zane(Meghan Markle) é filha de um dos advogados mais influentes da cidade e, apesar de ter uma vaga garantida na empresa do pai, resolve trabalhar na Pearson Hardman, onde se aproxima de Mike e Harvey.";
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0: // Opção 1 selecionada
                    label1.Text = "O criador da série trabalhou em Wall Street antes de se tornar showrunner e roteirista de séries de televisão. " +
                    "Em sua primeira experiência nessa posição, Korsh se sentiu inexperiente, e isso ajudou a desenvolver os personagens de Suits.";
                    break;
                case 1: // Opção 2 selecionada
                    label1.Text = "Meses antes do noivado com o Príncipe Harry, Korsh percebeu que o relacionamento estava sério e " +
                    "começou a diminuir o papel da atriz. “Com a progressão da temporada, eu disse que preferia que coisas boas acontecessem na vida de Meghan, " +
                    "o que poderia significar que ela sairia da série, então fiz os planos a partir disso”, Korsh declarou para oTelegraph. A atriz ficou noiva em novembro de 2017 e, em 2018, anunciou que sairia da série e não atuaria mais, para poder viver com o príncipe.";
                    break;
                case 2: // Opção 3 selecionada
                    label1.Text = "A futura princesa, que hoje é vista em trajes luxuosos, nem sempre teve essa realidade." +
                    " A atriz chegou para fazer o teste para o papel de Rachel em roupas casuais, mas percebeu que precisava parecer uma advogada profissional e," +
                    " de acordo com a Vanity Fair, correu para uma H&M e comprou um vestido preto de US$ 35.";
                    break;
                case 3: // Opção 4 selecionada
                    label1.Text = "O ator contou para o The TV Addict que vem de uma família de advogados e que isso o ajudou a desenvolver o personagem. " +
                    "“Eu estive cercado disso a minha vida inteira, então observei muitas coisas ao longo do tempo. " +
                    "Eu sinto que, quando pego os roteiros todas as semanas, não preciso ir até a Wikipedia para tentar entender o que todos aqueles termos significam. Tudo o que eu tenho que fazer é fingir muito bem”, afirmou.";
                    break;
                case 4: // Opção 5 selecionada
                    label1.Text = "Em entrevista para a Esquire, o ator reconheceu que a série não é inovadora, mas uma daquelas a que as pessoas gostam de assistir" +
                    " “porque amam os personagens e porque isso faz com que se sintam bem”. " +
                    "Adams também afirmou que a série é um “guilty pleasure” e que não mudaram muitas coisas ao longo das temporadas.";
                    break;
                case 5: // Opção 6 selecionada
                    label1.Text = "Jessica Pearson, interpretada por Gina Torres, contou ao The New York Times que saiu de Suits porque seu contrato tinha terminado e precisava cuidar de problemas pessoais. " +
                    "Aaron Korsh teve a ideia de fazer com que a personagem se mudasse para Chicago com o namorado Jeff Malone (D. B. Woodside) e que depois fosse assassinada por Larry Marsden (Colin Glazer). " +
                    "A emissora foi contra, e a personagem, que ainda aparece de vez em quando na série, vai ganhar um spin-off no futuro.";
                    break;
                default:
                    label1.Text = "Selecione uma opção";
                    break;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Defina o caminho do arquivo de vídeo 
            string caminhoDoVideo = @"C:\Users\vgram\Downloads\facebook.mp4";

            // Carrega o arquivo de vídeo no controle AxWindowsMediaPlayer
            axWindowsMediaPlayer1.URL = caminhoDoVideo;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifique qual opção foi selecionada
            string opcaoSelecionada = comboBox1.SelectedItem.ToString();

            // Altere o PictureBox e o Label com base na opção selecionada
            switch (opcaoSelecionada)
            {
                case "• Gabriel Macht":
                    pictureBox7.Image = Properties.Resources.harvey; 
                    label2.Text = "Nascido em Nova York, Gabriel Macht estreou diante das câmeras aos oito anos de idade na comédia familiar Why Would I Lie?, que lhe rendeu uma indicação em 1980 no Youth in Film Awards por sua atuação quando criança. Ele passou o resto de sua juventude em Los Angeles, depois se formou na seção de Artes Dramáticas da Carnegie Mellon University em Pittsburgh.Depois de aparecer na telinha em Beverly Hills, Spin City e Sex & the City, o jovem voltou ao cinema no final dos anos 90 e participou das comédias românticas A Razão do Meu Afeto e Simplesmente Irresistível. \r\n\r\nEm 2006, o ator formou com John Travolta e Scarlett Johansson o trio dramático de Uma Canção De Amor Para Bobby Long, que o viu entrar na pele de Lawson Pines, um escritor focado no álcool e lutando para sobreviver. Gabriel Matcht finalmente ganha destaque em 2008 com o filme The Spirit, adaptação da história em quadrinhos de Will Eisner, em no qual ele interpreta o papel-título do vigilante mascarado que luta contra o crime nas ruas escuras de Central City. \r\n\r\nDepois de ter ajudado Kate Beckinsale no thriller polar Terror na Antárdica e estrelado em Intermediário.com e Amor e Outras Drogas, o ator fez um retorno notável à televisão em 2011 graças à série Suits: tailor-made advogados, criada pelo roteirista Aaron Korsh e foi ao ar na USA Network. Neste espetáculo de tribunal, salpicado de uma boa pitada de humor, Gabriel Macht é Harvey Specter, um ambicioso advogado nova-iorquino que contrata como assistente Mike Ross (Patrick J. Adams), um jovem brilhante, dotado de uma memória eidética, mas infelizmente sem nenhum diploma de direito.";
                    break;
                case "• Patrick Adams":
                    pictureBox7.Image = Properties.Resources.mike;
                    label2.Text = "Patrick Johannes Adams (Toronto, 27 de agosto de 1981) é um ator canadense, mais conhecido por interpretar o personagem Mike Ross na série Suits de 2011 até 2017. \r\n\r\nFrequentou a Universidade do Sul da Califórnia, graduando-se com um BFA no teatro em 2004.\r\n\r\nPatrick se casou com a atriz de Pretty Little Liars, Troian Bellisario, em uma cerimônia no dia 10 de dezembro de 2016 na Califórnia. No dia 8 de Outubro de 2018, Patrick e Troian Belissario tiveram sua primeira filha.\r\n\r\nPatrick fez diversos trabalhos para a TV. Fez participações nas séries Orphan Black e Legends of Tomorrow . Interpretou o personagem Mike Ross na série Suits entre 2011 e 2019. Em 2014, interpretou o personagem Guy Woodhouse, na minissérie Rosemary's Baby, adaptação para a TV de filme homônimo, feita pela diretora polonesa Agnieszka Holland.";
                    break;
                case "• Sarah Rafferty":
                    pictureBox7.Image = Properties.Resources.donna; 
                    label2.Text = "Rafferty foi criada em Greenwich, Connecticut, junto com suas três irmãs mais velhas: Maura, Ann e Constance. Segundo ela, sua mãe, Mary Lee Rafferty, e seu pai, Michael Griffin Rafferty Jr., foram os responsáveis por desenvolverem a sua paixão pela arte. \r\n\r\nRafferty conheceu, na Universidade Yale, Aleksanteri Olli-Pekka 'Santtu' Seppälä, americano de origem finlandesa, com quem é casada desde 23 de junho de 2001. O casal tem duas filhas, Oona Gray (nascida em 22 de outubro de 2007) e Iris Friday (nascida em janeiro de 2012). Ela é amiga do ator Gabriel Macht, conhecido como co-founder, seu companheiro de trabalho na série de televisão Suits, desde 1993, quando se conheceram no Williamstown Theatre Festival.";
                    break;
                case "• Rick Hoofman":
                    pictureBox7.Image = Properties.Resources.louis; 
                    label2.Text = "Rick Edward Hoffman (Nova Iorque, 12 de junho de 1970) é um ator estadunidense. Ele é mais conhecido pelo seu papel como Louis Litt na série de televisão da USA Network Suits, e tambem conhecido por interpretar Jerry Best no seriado da Fox The Bernie Mac Show (2002–2005), Chase Chapman na série de comédia da ABC Samantha Who? (2007–2009).\r\n\r\n Hoffman nasceu na cidade de Nova York, filho de Charles e Gail Hoffman. Ele cresceu em Roslyn Heights, Nova York, com seu irmão Jeff Hoffman. Ele é judeu.[4]Ele se formou na The Wheatley School em Old Westbury, Nova York, antes de frequentar a Universidade do Arizona, com especialização em artes teatrais. Depois de se formar, mudou-se para Los Angeles, Califórnia, para iniciar a carreira de ator.";
                    break;
                case "• Megan Markle":
                    pictureBox7.Image = Properties.Resources.rachel; 
                    label2.Text = "Nascida e criada em Los Angeles, na Califórnia, a sua carreira como atriz começou enquanto estudava na Universidade do Noroeste.[3] Markle ficou conhecida pelo seu papel como Rachel Zane no drama jurídico americano Suits durante sete temporadas entre 2011 e 2017. Também ganhou reconhecimento por criar e lançar duas linhas de roupas da moda em 2015 e 2016.\r\n\r\nMeghan Markle ficou noiva de Harry em 2017 e, após o casamento deles no ano seguinte, tornou-se Duquesa de Sussex. O seu filho, Archie Mountbatten-Windsor, nasceu em 2019 e a sua filha Lilibet Diana Mountbatten-Windsor em junho de 2021. Meghan e Harry deixaram o posto de membros seniores da família real e mudaram-se para o sul da Califórnia em 2020. Naquele mesmo ano eles lançaram a Archewell Inc., uma organização pública americana que concentra-se em atividades sem fins lucrativos e empreendimentos de mídia criativa.";
                    break;
                case "• Gina Torres":
                    pictureBox7.Image = Properties.Resources.jessica; 
                    label2.Text = "Gina Torres (Nova Iorque, 25 de abril de 1969) é uma atriz norte-americana mais conhecida pelos seus papéis nas séries Firefly, como Zoe Washburne, e Alias, como Anna Espinosa, por sua participação em The Vampire Diaries como Bree amiga de Damon Salvatore, na série Suits como Jessica Pearson e na quarta temporada de Revenge como Natalie. \r\n\r\nTorres nasceu em 25 de abril de 1969 no Flower Fifth Avenue Hospital, em Manhattan, Nova York, a caçula de três filhos. Sua família viveu brevemente em Washington Heights antes de se mudar para o Bronx. Seus pais eram ambos de ascendência cubana e porto-riquenha, e seu pai trabalhou como compositor para La Prensa e New York Daily News. Torres começou a cantar na infância e frequentou Fiorello H. LaGuardia High School of Music & Art e Performing Arts em New York City. Ela se inscreveu e foi aceita para várias faculdades, mas não podia se dar ao luxo de estudar. Torres decidiu posteriormente que a faculdade não era o que ela precisava e escolheu ir atrás de seu sonho de ser uma atriz. ";
                    break;
                default:
                    comboBox1.Text = "Selecione uma opção";
                    break;

            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifique qual opção foi selecionada
            string opcaoSelecionada2 = comboBox2.SelectedItem.ToString();

            
            switch (opcaoSelecionada2)
            {
                case "• Temporada 1":
                    pictureBox3.Image = Properties.Resources.temp1; 
                    label5.Text = "Temporada 1";
                    break;
                case "• Temporada 2":
                    pictureBox3.Image = Properties.Resources.temp2; 
                    label5.Text = "Temporada 2";
                    break;
                case "• Temporada 3":
                    pictureBox3.Image = Properties.Resources.temp3; 
                    label5.Text = "Temporada 3";
                    break;
                case "• Temporada 4":
                    pictureBox3.Image = Properties.Resources.temp4; 
                    label5.Text = "Temporada 4";
                    break;
                case "• Temporada 5":
                    pictureBox3.Image = Properties.Resources.temp5; 
                    label5.Text = "Temporada 5";
                    break;
                case "• Temporada 6":
                    pictureBox3.Image = Properties.Resources.temp6; 
                    label5.Text = "Temporada 6";
                    break;
                case "• Temporada 7":
                    pictureBox3.Image = Properties.Resources.temp7; 
                    label5.Text = "Temporada 7";
                    break;
                case "• Temporada 8":
                    pictureBox3.Image = Properties.Resources.temp8; 
                    label5.Text = "Temporada 8";
                    break;
                case "• Temporada 9":
                    pictureBox3.Image = Properties.Resources.temp9; 
                    label5.Text = "Temporada 9";
                    break;
                default:
                    comboBox2.Text = "Selecione uma opção";
                    break;
            }
        }
    }
}

using MetroSet_UI.Forms;
using Monitoramento.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Monitoramento
{
    public partial class Form1_Principal : Form
    {
        // Variávies que recebem os valores atualizados do formulário Dashboard //
        string RecebeID;
        string RecebeNome;
        string RecebeIP;
        string RecebeTamanhoPacote;
        string RecebeQtdPacote;
        Boolean RecebeFragmentaPacote;
        //
        // Labels do Form2 Analise //
        //
        static public int Envia_Maior;
        static public int Envia_Media;
        static public int Envia_Menor;
        static public int Envia_Sucesso;
        static public int Envia_Restante;
        static public int Envia_Perdidos;
        static public int Envia_Percent;
        static public int Envia_Atual;
        static public float Envia_PerdaPorcento;
        static public Boolean CalculoFinalizado;
        static public Boolean EnviaClicado;
        //
        // Variávies temporárias. Onde fica salvo o conteudo do formulário Dashboard//
        //
        static public String IDTEMP = "00001";
        static public String NOMETEMP = "Fulano Ciclano";
        static public String IPTEMP = "8.8.8.8";
        static public String TAMANHOTEMP = "32";
        static public String QTDPACOTETEMP = "10";
        static public Boolean FRAGMENTATEMP = true;
        static public List<long> ListaTempoPing = new List<long>();  // Uma lista que recebe os tempo de ping //
        // 
        // Variavéis de controle //
        //
        Boolean SAIDODASHBOARD;
        Boolean TextoMudou = Form2_Dashboard.TextoTrocado = true;
        String TempoEmSegundos;
        //
        // Inicio da persoanlização da Form. Deixa a form com bordas arredondadas //
        //
        static float Percent;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
             int nLeftRect,
             int nTopRect,
             int nRightRect,
             int nBottomRect,
             int nWidthEllipse,
             int nHeightEllipse
         );

        //
        // Fim da personalização //
        //
        public Form1_Principal()
        {
            InitializeComponent();
            
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            Pnl_Navegacao.Height = Btn1_Dashboard.Height;
            Pnl_Navegacao.Top = Btn1_Dashboard.Top;
            Pnl_Navegacao.Left = Btn1_Dashboard.Left;
            AbrirFormsFilhos(new Form2_Dashboard());
            if (backgroundWorker3.IsBusy == false)
            {
                backgroundWorker3.RunWorkerAsync(); // Thread 3 busca atualização no campo de texto
            }


        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        //
        // Controle do menu lateral esquerdo (Click nos botões) //
        // A cada click há alterações de cores e mudança de posição do painel lateral esquerdo, que indica qual opção está selecionada //
        // 
        private void Btn1_Dashboard_Click(object sender, EventArgs e)
        {
            //
            // Ao iniciar o dashboard, altera-se as cores e muda o painel a esquerda, indicando que este foi selecinado //
            // No click também é aberto o formulário correspondente , como Form filho
            // Quando eu entro no dashboard, a variavel de controle se estou ou não no dashboard recebe false.
            // Ela é usada para controlar o Worker 3 que faz a atualização dos dados do Form Analise, sendo este ativado apenas quando entro naquele Form.
            //
            SAIDODASHBOARD = false;
            Pnl2_Grade.Enabled = true;


            Pnl_Navegacao.Height = Btn1_Dashboard.Height;
            Pnl_Navegacao.Top = Btn1_Dashboard.Top;
            Pnl_Navegacao.Left = Btn1_Dashboard.Left;
            Btn1_Dashboard.BackColor = Color.FromArgb(46, 51, 73);
            AbrirFormsFilhos(new Form2_Dashboard());
            if (backgroundWorker3.IsBusy == false)
            {
                backgroundWorker3.RunWorkerAsync(); // Thread 3 busca atualização no campo de texto
            }
        }
        private void Btn1_Dashboard_Leave(object sender, EventArgs e)
        {
            Btn1_Dashboard.BackColor = Color.FromArgb(24, 30, 54);
            Pnl2_Grade.Enabled = true;
            SAIDODASHBOARD = true;
        }

        private void Btn2_Analise_Click(object sender, EventArgs e)
        {
            //
            // Quando eu clico 
            Pnl_Navegacao.Height = Btn2_Analise.Height;
            Pnl_Navegacao.Top = Btn2_Analise.Top;
            Pnl_Navegacao.Left = Btn2_Analise.Left;
            Btn2_Analise.BackColor = Color.FromArgb(46, 51, 73);
            AbrirFormsFilhos(new Form3_Analise());

        }
        private void Btn2_Analise_Leave(object sender, EventArgs e)
        {
            Btn2_Analise.BackColor = Color.FromArgb(24, 30, 54);

        }
        private void Btn_Grafico_Click(object sender, EventArgs e)
        {
            Pnl_Navegacao.Top = Btn4_Grafico.Top;
            Btn4_Grafico.BackColor = Color.FromArgb(46, 51, 73);
            
        }
        private void Btn_Grafico_Leave(object sender, EventArgs e)
        {
            Btn4_Grafico.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void Btn3_Historico_Click(object sender, EventArgs e)
        {
            Pnl_Navegacao.Height = Btn3_Historico.Height;
            Pnl_Navegacao.Top = Btn3_Historico.Top;
            Pnl_Navegacao.Left = Btn3_Historico.Left;
            Btn3_Historico.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void Btn3_Historico_Leave(object sender, EventArgs e)
        {
            Btn3_Historico.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void Btn4_Grafico_Click(object sender, EventArgs e)
        {
            Pnl_Navegacao.Height = Btn4_Grafico.Height;
            Pnl_Navegacao.Top = Btn4_Grafico.Top;
            Pnl_Navegacao.Left = Btn4_Grafico.Left;
            Btn4_Grafico.BackColor = Color.FromArgb(46, 51, 73);

        }
        private void Btn4_Grafico_Leave(object sender, EventArgs e)
        {
            Btn4_Grafico.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void Btn5_Config_Click(object sender, EventArgs e)
        {
        
            Pnl_Navegacao.Top = Btn5_Config.Top;
            Btn5_Config.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void Btn5_Config_Leave(object sender, EventArgs e)
        {
            Btn5_Config.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Form1_Principal_Load(object sender, EventArgs e)
        {
            Btn1_Dashboard_Click(null, e); // Inicio o programa principal com o botão Dashboard clicado
        }
        //
        // Controle dos botões Inciar e Parar //
        //
        private void Btn4_Iniciar_Click(object sender, EventArgs e)
        {
            //
            // Ao clicar em iniciar. Inicia-se o Back Worker 1 , que é o responsável pela função Ping
            //

            EnviaClicado = true;
            Envia_PerdaPorcento = 0;
           
            // Verifico antes da execução das thread, se já não há um trabalho em segundo plano. Caso sim, encerra-se este 
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
            else
                backgroundWorker1.CancelAsync();

            if (!backgroundWorker2.IsBusy)
                backgroundWorker2.RunWorkerAsync();
            else
                backgroundWorker2.CancelAsync();


            ListaTempoPing.Clear();

            Btn6_Iniciar.Enabled = false;
            Btn7_Parar.Enabled = true;
            progressBar1.Value = 0;
            Lbl_Porcentagem.Text = "0%";
            progressBar1.SetState(1);
        }
        private void Btn5_Parar_Click(object sender, EventArgs e)
        {
            EnviaClicado = false;
            backgroundWorker1.CancelAsync();
            backgroundWorker2.CancelAsync();
            Btn6_Iniciar.Enabled = true;
            Btn7_Parar.Enabled = false;
            progressBar1.SetState(2);
        }
        private void AbrirFormsFilhos(Form FormsFilhos)
        {
            if (this.Pnl2_Grade.Controls.Count > 0)
                this.Pnl2_Grade.Controls.RemoveAt(0);
            Form fh = FormsFilhos;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Pnl2_Grade.Controls.Add(fh);
            this.Pnl2_Grade.Tag = fh;
            fh.Show();

        }
        //
        // Configuração dos Background Workers //
        // Há 03 Workers no Painel Principal //
        // Worker 1 - Faz o calculo de ping //
        // Worker 2 - Atualiza a barra de progresso e a label do Tempo Restante //
        // Worker 3 - Envia os resultados em tempo real do Ping para o Form3 Análise //
        //
        // Inicio implementação Woker 1// 
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {   //
            //inicia o traballho de fazer o ping em segundo plano, outra thread
            //

            CalculoFinalizado = false;
            BackgroundWorker worker = sender as BackgroundWorker;
            string Dados = string.Concat(Enumerable.Repeat("a", int.Parse(RecebeTamanhoPacote)));
            byte[] Buffer = Encoding.ASCII.GetBytes(Dados);
            //
            // Fazendo o ping//
            // A lógica da implantação e calculo, é fazer a quantidade de Ping solicitada pelo usuário, juntamemte as personalização deste
            // E salvar em uma lista de inteiro o tempo que levou para execultar o Ping (Um número inteiro )
            // Com os valores de tempo, é utilizado manipulação de lista para encontrar o menor, maior , média e se houve perda de pacote (Tempo de ping = 0) //
            //
            Ping EnviaPing = new Ping();

            PingOptions Opcoes = new PingOptions();
            Opcoes.DontFragment = RecebeFragmentaPacote;
            {
                for (float i = 0.0f; i < int.Parse(RecebeQtdPacote); i++)
                {
                    if (worker.CancellationPending == true) // verifica a cada etapa, se há um pedido de cancelamento do trabalho. Se sim , aborta o trabalho, se não continua
                    {
                        e.Cancel = true;
                        break;
                    }
                    else
                    {
                        try
                        {
                            Percent = ((i + 1) / int.Parse(RecebeQtdPacote)) * 100;
                            int Porcento_Inteiro = (int)Percent;
                            System.Threading.Thread.Sleep(1000);
                            PingReply reply = EnviaPing.Send(RecebeIP, 1000, Buffer); // IP, Tempo de Espera, Buffer                                   
                            ListaTempoPing.Insert((int)i, reply.RoundtripTime); //Adiciona na lista posição do contador o tempo do ping                  
                            Envia_Maior = (int)ListaTempoPing.Max(); // acha o maior tempo 
                            Envia_Menor = (int)ListaTempoPing.Where(x => x != 0).DefaultIfEmpty().Min(); //Encontra o menor valor exceto zero;
                            Envia_Media = (int)ListaTempoPing.Average(); //Acha o tempo médio
                            Envia_Sucesso = (int)ListaTempoPing.Count(x => x != 0); // Acha quantidade ping com sucesso
                            Envia_Restante = int.Parse(RecebeQtdPacote) - (int)ListaTempoPing.Count();
                            Envia_Perdidos = ListaTempoPing.Count(x => x == 0); // Acha quantidade ping com sucesso
                            Envia_Atual = (int)ListaTempoPing[(int)i];       
                            float Perdidos = (float)Envia_Perdidos;
                            float Npacotes = float.Parse(RecebeQtdPacote);
                            float PorcentoPerda = (Perdidos / i) * 100;
                            if (PorcentoPerda > 100)
                            {
                                Envia_PerdaPorcento = 100;
                            }
                            else
                                Envia_PerdaPorcento = PorcentoPerda;
                            worker.ReportProgress(Porcento_Inteiro);

                        }
                        catch
                        {
                            MessageBox.Show("Ocorreu um erro ao execultar o ping. Verifique sua conexão com a internet " +
                               "e se o host é valido", "Erro de Ping",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;

                        }

                    }

                }
            }
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {   //
            // Controla as mudanças que devem ser feita pelo Worker. No caso a atualização das labels e o valor da barra de progresso//
            //
            int Porcentagem_Int = (int)Percent;
          
            Lbl_Porcentagem.Text = Porcentagem_Int.ToString() + "%";
            progressBar1.Value = Porcentagem_Int;
            TaskbarProgress.SetValue(this.Handle, Porcentagem_Int, 100);
            Lbl_TempoEstimado2.Text = TempoEmSegundos;


        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {   //
            // Recebe a resposta do Worker que ele terminou o trabalho. Trata os tipos de finalização : Sucesso, Erro e Cancelado pelo usuário //
            //
            EnviaClicado = false;
            Pnl2_Grade.Enabled = true;
            Btn6_Iniciar.Enabled = true;
            Btn7_Parar.Enabled = false;
            CalculoFinalizado = true;
            FlashWindow.Flash(this);
            if (e.Cancelled)
            {
                MessageBox.Show("Ping cancelado com sucesso", "Cancelado pelo usuário",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaskbarProgress.SetState(this.Handle, TaskbarProgress.TaskbarStates.Error);

            }
            if (e.Error == null)
            {
                MessageBox.Show("Monitoramento finalizado");
            }


        }

        //
        // Fim implementação Woker 1// 
        //
        // Inicio Implementação Worker 2 - Contagem do tempo restante// 
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            //
            // Cada solicitação de Ping irá aguardar 1 segundo até a proxima. A lógica do valor da barra de progresso é a quantidade de Pings transformada em segundos //
            // 10 Pings serão 10 Segundos por exemplo //
            // OBS: É subtraida 1 unidade da quantidade pacotes ao transformar em segundo, devido ao delay propistal entre finalizar o calculo Ping e transformar em label
            // Caso contrário, a barra de progresso é carregada até 100%, mas o tempo restante sempre ficará faltando 1 segundo para finalizar //
            //inicia o traballho de fazer o calculo de tempo em segundo plano, outra thread //
            //
            BackgroundWorker worker2 = sender as BackgroundWorker;
            int PegaQtdPacote = int.Parse(RecebeQtdPacote);
            int TempoBruto = PegaQtdPacote - 1;
            for (int j = TempoBruto; j >= 0; j--)
            {
                if (worker2.CancellationPending == true) // verifica a cada etapa, se há um pedido de cancelamento do trabalho. Se sim , aborta o trabalho, se não continua
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(1000); //Aguarda 1 segundo antes de atualizar a label
                    TimeSpan time = TimeSpan.FromSeconds(TempoBruto);
                    TempoEmSegundos = time.ToString(@"hh\:mm\:ss");
                    TempoBruto--;
                }
            }
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //
            // Atualiza a label a cada etapa concluida do Worker 2
            //
            Lbl_TempoEstimado2.Text = TempoEmSegundos;
        }
        //
        // Fim implementação Worker 2 - Tempo restante e barra de progresso //
        //
        // Inicio implantação Worker 3 - Envio dos dados atualizados para Form2 Dashboard //
        // A
        // A cada fim de uma unidade do loop do calculo de Ping, temos os resultados, estes são enviados ao Form Análise em tempo real pelo Worker3//
        // 
        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {

            BackgroundWorker worker = sender as BackgroundWorker;
            //
            // Monitoro as textbox por alterações e as envio através do Worker 3 para o formulário Dashboard //
            //
            do
            {   //
                // Até que seja detectado que sai que cliquei em INICIAR, eu envio os dados para o formulário dashboard //
                //
                RecebeID = Form2_Dashboard.EnviaID;
                RecebeNome = Form2_Dashboard.EnviaNome;
                RecebeIP = Form2_Dashboard.EnviaIP;
                RecebeTamanhoPacote = Form2_Dashboard.EnviaTamanhoPacote;
                RecebeQtdPacote = Form2_Dashboard.EnviaQtdPacote;
                RecebeFragmentaPacote = Form2_Dashboard.EnviaFragmentaPacote;
                TextoMudou = Form2_Dashboard.TextoTrocado;
                //
                // Envio também cada alteração para variáveis temporárias, salvado assim os dados, para que não se perca entre as trocas de formulários pelo usuário//
                //
                IDTEMP = RecebeID;
                NOMETEMP = RecebeNome;
                IPTEMP = RecebeIP;
                TAMANHOTEMP = RecebeTamanhoPacote;
                FRAGMENTATEMP = RecebeFragmentaPacote;
                QTDPACOTETEMP = RecebeQtdPacote;



            } while (EnviaClicado == false);

        }

       












        //

    }
    //
    //  Outras Implantações - // Implantações que mudam a interface mas que não dependem da função Ping //
    //

    // Função que troca a cor da barra de progresso        
    // Para utiliza-la , usase  progressBar1.SetState (1 a 3) , onde 1 é verde, 2 vermelho, 3 Amarelo
    public static class ModifyProgressBarColor2
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }


}

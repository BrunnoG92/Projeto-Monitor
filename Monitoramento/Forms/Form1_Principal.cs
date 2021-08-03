using MetroSet_UI.Forms;
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
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Monitoramento
{
    public partial class Form1_Principal : Form
    {
        string RecebeID;
        string RecebeNome;
        string RecebeIP;
        string RecebeTamanhoPacote;
        string RecebeQtdPacote;
        Boolean RecebeFragmentaPacote;
        // Labels do Form2 Analise //
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



        static public String IDTEMP ="00001";
        static public String NOMETEMP = "Fulano Ciclano";
        static public String IPTEMP = "8.8.8.8";
        static public String TAMANHOTEMP = "32";
        static public String QTDPACOTETEMP = "10";
        static public Boolean FRAGMENTATEMP = true;
        static public List<long> ListaTempoPing = new List<long>();  // Uma lista que recebe os tempo de ping //


        Boolean SAIDODASHBOARD; 
        Boolean TextoMudou = Form2_Dashboard.TextoTrocado = true;
        String TempoEmSegundos;


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
        public Form1_Principal()
        {
            InitializeComponent();
            
           


            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            Pnl_Navegacao.Height = Btn1_Dashboard.Height;
            Pnl_Navegacao.Top = Btn1_Dashboard.Top;
            Pnl_Navegacao.Left = Btn1_Dashboard.Left;
            Btn1_Dashboard.BackColor = Color.FromArgb(46, 51, 73);
            Lbl_Porcentagem.ForeColor = Color.White;
            Lbl_TempoDecorrido.ForeColor = Color.White;
            Lbl_TempoEstimado2.ForeColor = Color.White;
            Lbl_Progresso.ForeColor = Color.White;
            
            
                
            
        }
        // Click no menu lateral esquerdo //
        private void Btn1_Dashboard_Click(object sender, EventArgs e)
        {
            SAIDODASHBOARD = false;
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

        private void Btn2_Analise_Click(object sender, EventArgs e)
        {   

            Pnl_Navegacao.Height = Btn2_Analise.Height;
            Pnl_Navegacao.Top = Btn2_Analise.Top;
            Pnl_Navegacao.Left = Btn2_Analise.Left;
            Btn2_Analise.BackColor = Color.FromArgb(46, 51, 73);
            AbrirFormsFilhos(new Form3_Analise());
            SAIDODASHBOARD = true;

        }

        private void Btn3_Historico_Click(object sender, EventArgs e)
        {
            Pnl_Navegacao.Height = Btn3_Historico.Height;
            Pnl_Navegacao.Top = Btn3_Historico.Top;
            Pnl_Navegacao.Left = Btn3_Historico.Left;
            Btn3_Historico.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void Btn4_Configuracoes_Click(object sender, EventArgs e)
        {
            
            Pnl_Navegacao.Height = Btn4_Configuracoes.Height;
            Pnl_Navegacao.Top = Btn4_Configuracoes.Top;
            Pnl_Navegacao.Left = Btn4_Configuracoes.Left;
            Btn4_Configuracoes.BackColor = Color.FromArgb(46, 51, 73);
           
           
            MessageBox.Show($"IDTEMP: {IDTEMP}");
            MessageBox.Show($"ID: {RecebeID}");
            MessageBox.Show($"Nome: {RecebeNome}");
            MessageBox.Show($"IP: {RecebeIP}");
            MessageBox.Show($"TPacote: {RecebeTamanhoPacote}");
            MessageBox.Show($"QPacote: {RecebeQtdPacote}");
            MessageBox.Show($"FP: {RecebeFragmentaPacote}");

        }
        private void Btn1_Dashboard_Leave(object sender, EventArgs e)
        {
            Btn1_Dashboard.BackColor = Color.FromArgb(24, 30, 54);
            
           
           


        }
        // Opção do menu lateral esquerdo deixou de ser a ativa //
        private void Btn2_Analise_Leave(object sender, EventArgs e)
        {
            Btn2_Analise.BackColor = Color.FromArgb(24, 30, 54);
            
        }
        private void Btn3_Historico_Leave(object sender, EventArgs e)
        {
            Btn3_Historico.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void Btn4_Configuracoes_Leave(object sender, EventArgs e)
        {
            Btn4_Configuracoes.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void Btn4_Iniciar_Click(object sender, EventArgs e)
        {
            EnviaClicado = true;
            Envia_PerdaPorcento = 0;
            Lbl_TempoEstimado2.ForeColor = Color.White;
            Pnl2_Grade.Enabled = false;
            backgroundWorker1.RunWorkerAsync(); // Thread 1 faz ping
            backgroundWorker2.RunWorkerAsync(); // Thread 2 atualiza a barra de progresso
            ListaTempoPing.Clear();
           
            Btn4_Iniciar.Enabled = false;
            Btn5_Parar.Enabled = true;
            progressBar1.Value = 0;
            Lbl_Porcentagem.Text = "0%";
            progressBar1.SetState(1);
        }
        private void Btn5_Parar_Click(object sender, EventArgs e)
        {
            EnviaClicado = false;
            backgroundWorker1.CancelAsync();
            backgroundWorker2.CancelAsync();
            Btn4_Iniciar.Enabled = true;
            Btn5_Parar.Enabled = false;
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

        private void Form1_Principal_Load(object sender, EventArgs e)
        {
            Btn1_Dashboard_Click(null, e); // Inicio o programa principal com o botão Dashboard clicado
           
            


        }
       
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //inicia o traballho de fazer o ping em segundo plano, outra thread
            CalculoFinalizado = false;
            BackgroundWorker worker = sender as BackgroundWorker;
            string Dados = string.Concat(Enumerable.Repeat("a", int.Parse(RecebeTamanhoPacote)));
            byte[] Buffer = Encoding.ASCII.GetBytes(Dados);


            // Fazendo o ping
            Ping EnviaPing = new Ping();
            PingOptions Opcoes = new PingOptions();
            Opcoes.DontFragment = RecebeFragmentaPacote;
            string filename = @"C:\Users\Bruno\TESTEINTERFACE.txt";
            using (var writer = new StreamWriter(filename, false))
            {
                writer.WriteLine("Nº, Status,Host, Tam.Pacote, Tempo");
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
                           
                            //  MessageBox.Show("Procento inteiro: " + Porcento_Inteiro);
                            System.Threading.Thread.Sleep(1000);
                            PingReply reply = EnviaPing.Send(RecebeIP, 1000, Buffer);
                            writer.WriteLine("{0},{1},{2},{3},{4}", (i + 1), reply.Status, RecebeIP, RecebeTamanhoPacote, reply.RoundtripTime);
                            // Trabalho para calculos do Form2 Analise
                           
                            ListaTempoPing.Insert((int)i, reply.RoundtripTime); //Adiciona posição do contador de ping, o tempo do ping
                           
                            Envia_Maior = (int)ListaTempoPing.Max(); // acha o maior tempo 
                            Envia_Menor = (int)ListaTempoPing.Where(x => x != 0).DefaultIfEmpty().Min(); //Encontra o menor valor exceto zero;
                            Envia_Media = (int)ListaTempoPing.Average(); //Acha o tempo médio
                            Envia_Sucesso = (int)ListaTempoPing.Count(x => x != 0); // Acha quantidade ping com sucesso
                            Envia_Restante = int.Parse(RecebeQtdPacote) - (int)ListaTempoPing.Count();
                            Envia_Perdidos = ListaTempoPing.Count(x => x == 0); // Acha quantidade ping com sucesso
                            Envia_Atual = (int)ListaTempoPing[(int)i];
                            float Perdidos = (float)Envia_Perdidos;
                            float Npacotes = float.Parse (RecebeQtdPacote);
                            float PorcentoPerda = (Perdidos /Npacotes) * 100;
                            Envia_PerdaPorcento = PorcentoPerda;
                            worker.ReportProgress(Porcento_Inteiro);
                           
                        }
                        catch
                        {
                            MessageBox.Show("Ocorreu um erro ao execultar o ping. Verifique sua conexão com a internet " +
                                "e se o host é valido", "Erro de Ping",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            writer.WriteLine("ERRO NA EXECUÇÃO DO PING. NÃO FOI POSSIVEL COMPLETAR");
                            return;
                        }

                    }

                }
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            EnviaClicado = false;
            Pnl2_Grade.Enabled = true;
            Btn4_Iniciar.Enabled = true;
            Btn5_Parar.Enabled = false;
            CalculoFinalizado = true;
            if (e.Cancelled == true)
            {
                MessageBox.Show("Abortado pelo usuário", "Pìng Cancelado",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                Lbl_TempoEstimado2.Text = "Cancelado pelo usuário";
                Lbl_TempoEstimado2.ForeColor = Color.Red;
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Ocorreu um erro ao execultar o ping. Verifique sua conexão com a internet " +
                                "e se o host é valido", "Erro de Ping",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                Lbl_TempoEstimado2.Text = "Erro na execução";
                Lbl_TempoEstimado2.ForeColor = Color.Red;
            }
            else
            {
                MessageBox.Show("Monitoramento concluido com suceso!", "Finalizado com sucesso",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                Lbl_TempoEstimado2.Text = "Concluido com sucesso";
                Lbl_TempoEstimado2.ForeColor = Color.Chartreuse;

            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int Porcentagem_Int = (int)Percent;
            Lbl_Porcentagem.Text = Porcentagem_Int.ToString() + "%";
            progressBar1.Value = Porcentagem_Int;
            Lbl_TempoEstimado2.Text = TempoEmSegundos;

            
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {  

            //inicia o traballho de fazer o calculo de tempo em segundo plano, outra thread
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
                    System.Threading.Thread.Sleep(1000);
                    TimeSpan time = TimeSpan.FromSeconds(TempoBruto);
                    TempoEmSegundos = time.ToString(@"hh\:mm\:ss");
                    TempoBruto--;

                }

            }
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Lbl_TempoEstimado2.Text = TempoEmSegundos;
        }

        // atualiza caixa de texto //
        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
           
            BackgroundWorker worker = sender as BackgroundWorker;
          
            do
            {
                RecebeID = Form2_Dashboard.EnviaID;
                RecebeNome = Form2_Dashboard.EnviaNome;
                RecebeIP = Form2_Dashboard.EnviaIP;
                RecebeTamanhoPacote = Form2_Dashboard.EnviaTamanhoPacote;
                RecebeQtdPacote = Form2_Dashboard.EnviaQtdPacote;
                RecebeFragmentaPacote = Form2_Dashboard.EnviaFragmentaPacote;
                TextoMudou = Form2_Dashboard.TextoTrocado;
               
            } while (SAIDODASHBOARD == false);
            {
                // MessageBox.Show("Estou trabalhando");
               
                
                

                
            }
        }

        private void backgroundWorker3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           
            IDTEMP = RecebeID;
            NOMETEMP = RecebeNome;
            IPTEMP = RecebeIP;
            TAMANHOTEMP = RecebeTamanhoPacote;
            FRAGMENTATEMP = RecebeFragmentaPacote;
            QTDPACOTETEMP = RecebeQtdPacote;
        }
    }
    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}

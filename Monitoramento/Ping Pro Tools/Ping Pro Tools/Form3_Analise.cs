using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToastNotifications;

namespace Ping_Pro_Tools
{
    public partial class Form3_Analise : Form
    {
        int Recebe_Maior;
        int Recebe_Media;
        int Recebe_Menor;
        int Recebe_Sucesso;
        int Recebe_Restante;
        int Recebe_Perdidos;
        int Recebe_atual;
        float Recebe_PerdaPorcento;
        Boolean Recebe_Clicado;
        
         private string Servidor;
        private string Porta;
        private string Usuario;
        private string Senha;
        private string BD;
       

        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;
        public Form3_Analise()
        {
            InitializeComponent();
            TxtB_TotalPing.Text = Form2_Dashboard.EnviaQtdPacote;
            if (!backgroundWorker1.IsBusy) //Thread 1 
                backgroundWorker1.RunWorkerAsync();
            else
                backgroundWorker1.CancelAsync();
        }

       

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker1 = sender as BackgroundWorker;
            do
            {   //Recebendo os resultados do ping em tempo real //
                System.Threading.Thread.Sleep(100);
                Recebe_Maior = Form1_Principal.Envia_Maior;
                Recebe_Media = Form1_Principal.Envia_Media;
                Recebe_Menor = Form1_Principal.Envia_Menor;
                Recebe_Sucesso = Form1_Principal.Envia_Sucesso;
                Recebe_Perdidos = Form1_Principal.Envia_Perdidos;
                Recebe_Restante = Form1_Principal.Envia_Restante;
                Recebe_atual = Form1_Principal.Envia_Atual;
                Recebe_PerdaPorcento = Form1_Principal.Envia_PerdaPorcento;
                Recebe_Clicado = Form1_Principal.EnviaClicado;
                // Recebendo as configurações do banco de dados
                Servidor = Form5_Configuracoes.Servidor;
                Porta = Form5_Configuracoes.Porta;
                Usuario = Form5_Configuracoes.Usuario;
                Senha = Form5_Configuracoes.Senha;
                BD = Form5_Configuracoes.BD;
              worker1.ReportProgress(Form1_Principal.Envia_Percent);
            } while (Form1_Principal.CalculoFinalizado != true);   
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Atualiza os resultados //
            Lbl_PerdaPorcento.Refresh();
            TxtB_Maior.Text = Recebe_Maior.ToString();
            TxtB_Media.Text = Recebe_Media.ToString();
            TxtB_Menor.Text = Recebe_Menor.ToString();
            TxtB_PingSucesso.Text = Recebe_Sucesso.ToString();
            TxtB_PingRestante.Text = Recebe_Restante.ToString();
            TxtB_PingPerdido.Text = Recebe_Perdidos.ToString();
            TxtB_Atual.Text = Recebe_atual.ToString();
            int PorcentoInteiro = (int)Recebe_PerdaPorcento;
            TxtB_PerdaPorcento.Text = PorcentoInteiro.ToString() + "%";
            MessageBox.Show(Recebe_atual.ToString());
            if (Recebe_Perdidos == 0 && Recebe_Clicado == true)
            {
                Lbl_PerdaPorcento.Text = "Perda";
                Lbl_PerdaPorcento.ForeColor = Color.Chartreuse;

            }
            if (Recebe_Perdidos > 0 && Recebe_Clicado == true)
            {
                Lbl_PerdaPorcento.Text = "Perda";
                Lbl_PerdaPorcento.ForeColor = Color.Red;
            }

           

        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            MySqlConnection connection;
            string server;
            string database;
            string uid;
            string password;
            string porta;

            server = Servidor;
            database = BD;
            uid = Usuario;
            password = Senha;
            porta = Porta;
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "PORT=" + Porta + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
            try
            {
               
              
              conexao = new MySqlConnection(connectionString);
              strSQL = "INSERT INTO Ping (ID_CLIENTE, OPERADOR,  CLIENTE, HOST, QUANTIDADE_PING, TAMANHO_PACOTE, MAIOR_PING, MENOR_PING, MEDIA_PING, QTD_PACOTES_PERDIDOS, PORCENTO_PCTS_PERDIDOS, DATA  ) VALUES (@ID_CLIENTE, @OPERADOR, @CLIENTE, @HOST, @QUANTIDADE_PING, @TAMANHO_PACOTE, @MAIOR_PING, @MENOR_PING, @MEDIA_PING, @QTD_PACOTES_PERDIDOS, @PORCENTO_PCTS_PERDIDOS, @DATA )";
              comando = new MySqlCommand(strSQL, conexao);
              comando.Parameters.AddWithValue("@ID_CLIENTE", Form2_Dashboard.EnviaID);
              comando.Parameters.AddWithValue("@OPERADOR", Form2_Dashboard.EnviaOperador);
              comando.Parameters.AddWithValue("@CLIENTE", Form2_Dashboard.EnviaNome);
              comando.Parameters.AddWithValue("@HOST", Form2_Dashboard.EnviaIP);
              comando.Parameters.AddWithValue("@QUANTIDADE_PING", Form2_Dashboard.EnviaQtdPacote);
              comando.Parameters.AddWithValue("@TAMANHO_PACOTE", Form2_Dashboard.EnviaTamanhoPacote);
              comando.Parameters.AddWithValue("@MAIOR_PING", Recebe_Maior);
              comando.Parameters.AddWithValue("@MENOR_PING", Recebe_Menor);
              comando.Parameters.AddWithValue("@MEDIA_PING", Recebe_Media);
              comando.Parameters.AddWithValue("@QTD_PACOTES_PERDIDOS", Recebe_Perdidos);
              comando.Parameters.AddWithValue("@PORCENTO_PCTS_PERDIDOS", Recebe_PerdaPorcento);
              comando.Parameters.AddWithValue("@DATA", DateTime.Now.ToString("dd/MM/yyy"));
              conexao.Open();
               
                int salvo = comando.ExecuteNonQuery();
                if (salvo < 1)
                {
                    Notification.CorPainel = Color.Red;
                    Notification.Icone = Properties.Resources.Error;
                    Notification toastNotificationS = new Notification("Erro", "Os dados não foram salvo. Verifique sua conexão com o banco de dados!", 3, FormAnimator.AnimationMethod.Slide, FormAnimator.AnimationDirection.Up);
                    Form1_Principal.playaudio(Ping_Pro_Tools.Properties.Resources.zapsplat_error);
                    toastNotificationS.Show();
                }
                else
                {
                    Notification.CorPainel = Color.Green;
                    Notification.Icone = Properties.Resources.Sucess;
                    Notification toastNotificationS = new Notification("Salvo", "Os dados foram salvo com sucesso!", 3, FormAnimator.AnimationMethod.Slide, FormAnimator.AnimationDirection.Up);
                    Form1_Principal.playaudio(Ping_Pro_Tools.Properties.Resources.zapslat_sucess);
                    toastNotificationS.Show();
                }
            }
            catch
            {

            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
                 
            }

        private void Lbl_PerdaPorcento_Click(object sender, EventArgs e)
        {

        }

        
    }
}


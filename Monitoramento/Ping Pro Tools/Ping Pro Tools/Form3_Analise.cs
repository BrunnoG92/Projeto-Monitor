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

        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;
        public Form3_Analise()
        {
            InitializeComponent();
            TxtB_TotalPing.Text = Form2_Dashboard.EnviaQtdPacote;
            backgroundWorker1.RunWorkerAsync(); // Thread 1 do analise
        }

        private void TxtB_PingRestante_TextChanged(object sender, EventArgs e)
        {

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
                // Controle da cor da label perdeu pacote //

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

        private void Btn6_Iniciar_Click(object sender, EventArgs e)
        {
            try
            {
               
              
              conexao = new MySqlConnection("Server=bruno-dev.coswwudtnlbd.us-east-2.rds.amazonaws.com;Port=3306;Database=PingProTools;Uid=brunog;Pwd=98497389b;");
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
                    MessageBox.Show("Não enviado");
                }
                else
                {
                    MessageBox.Show("Enviado");
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
    }
}


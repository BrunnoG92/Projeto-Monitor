using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitoramento
{
    public partial class Form3_Analise : Form
    {
        int Maior;
        int Media;
        int Menor;
        int Sucesso;
        int Restante;
        int Perdidos;
        int Percent;
        public Form3_Analise()
        {
            InitializeComponent();
            TxtB_TotalPing.Text = Form2_Dashboard.EnviaQtdPacote;
           
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            for (int i = 0; i <= int.Parse(Form2_Dashboard.EnviaQtdPacote); i++)
            {
                Percent = ((i + 1) / int.Parse(Form2_Dashboard.EnviaQtdPacote)) * 100;
                int Porcento_Inteiro = (int)Percent;
                BackgroundWorker worker = sender as BackgroundWorker;
                System.Threading.Thread.Sleep(1000);

                foreach (int Tempos in Form1_Principal.ListaTempoPing)
                {
                   // MessageBox.Show(Tempos.ToString());
                }
                 Maior = (int)Form1_Principal.ListaTempoPing.Max(); // acha o maior tempo 
                 Menor = (int)Form1_Principal.ListaTempoPing.Where(x => x != 0).DefaultIfEmpty().Min(); //Encontra o menor valor exceto zero;
                 Media = (int)Form1_Principal.ListaTempoPing.Average(); //Acha o tempo médio
                 Sucesso = Form1_Principal.ListaTempoPing.Count(x => x != 0); // Acha quantidade ping com sucesso
                 Restante = int.Parse(Form2_Dashboard.EnviaQtdPacote) - (int)Form1_Principal.ListaTempoPing.Count();
                 Perdidos = Form1_Principal.ListaTempoPing.Count(x => x == 0); // Acha quantidade ping com sucesso
                 worker.ReportProgress(Porcento_Inteiro);

            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Atualiza os resultados //
            MessageBox.Show("A lista tem " + Form1_Principal.ListaTempoPing.Count());
            TxtB_Maior.Text = Maior.ToString();
            TxtB_Media.Text = Media.ToString();
            TxtB_Menor.Text = Menor.ToString();
            TxtB_PingSucesso.Text = Sucesso.ToString();
            TxtB_PingRestante.Text = Restante.ToString();
            TxtB_PingPerdido.Text = Perdidos.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync(); // Inicia o trabalho de monitorar os valores do ping
        }
    }
}

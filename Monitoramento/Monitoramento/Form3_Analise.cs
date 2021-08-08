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
        int Recebe_Maior;
        int Recebe_Media;
        int Recebe_Menor;
        int Recebe_Sucesso;
        int Recebe_Restante;
        int Recebe_Perdidos;
        int Recebe_atual;
        float Recebe_PerdaPorcento;
        Boolean Recebe_Clicado;


        public Form3_Analise()
        {
            InitializeComponent();
            TxtB_TotalPing.Text = Form2_Dashboard.EnviaQtdPacote;
            backgroundWorker1.RunWorkerAsync(); // Thread 1 do analise
            // Cor das label Analise //
            Lbl_TPing.ForeColor = Color.White;
            Lbl_Maior.ForeColor = Color.White;
            Lbl_Menor.ForeColor = Color.White;
            Lbl_Perdido.ForeColor = Color.White;
            Lbl_Restante.ForeColor = Color.White;
            Lbl_Sucesso.ForeColor = Color.White;
            Lbl_Media.ForeColor = Color.White;
            Lbl_PingAtual.ForeColor = Color.White;
            Lbl_PerdaPorcento.ForeColor = Color.White;





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


    }
}

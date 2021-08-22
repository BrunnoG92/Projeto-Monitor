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
    public partial class Form4_Historico : Form
    {
        private string Servidor;
        private string Porta;
        private string Usuario;
        private string Senha;
        private string BD;
        private bool Sucesso;
        public Form4_Historico()
        {
            InitializeComponent();
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //recebo os dados de login da pagina de configurações 
            Servidor = Form5_Configuracoes.Servidor;
            Porta = Form5_Configuracoes.Porta;
            Usuario = Form5_Configuracoes.Usuario;
            Senha = Form5_Configuracoes.Senha;
            BD = Form5_Configuracoes.BD;

            BackgroundWorker worker = sender as BackgroundWorker;
            DataRow row = (kryptonDataGridView1.SelectedRows[0].DataBoundItem as DataRowView).Row;

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

            // APAGA NO BANCO DE DADOS
            using (MySqlConnection sqlConn = new MySqlConnection(connectionString))
            {
                try
                {


                    sqlConn.Open();
                    using (MySqlCommand sqlCommand = new MySqlCommand("DELETE FROM Ping WHERE idPing = " + row["idPing"], sqlConn))
                    {

                        int sucesso = sqlCommand.ExecuteNonQuery();
                        if (sucesso < 1)
                        {
                            Sucesso = false;

                        }
                        else
                        {
                            Sucesso = true;

                        }
                    }
                }
                catch
                {


                }
            }

        }




        private void Btn6_Carregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.pingTableAdapter.Puxa_Historico(this.pingProToolsDataSet.Ping);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Btn_Apagar_Click(object sender, EventArgs e)
        {

            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();

            }

            else
                backgroundWorker1.CancelAsync();
        }

        private void Btn_EnviarAnalise_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Servidor.ToString());
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Apago no Datagridview local
            int row = kryptonDataGridView1.CurrentCell.RowIndex;
            kryptonDataGridView1.Rows.RemoveAt(row);

            // Exibo a notificação para sucesso ou falha ao deletar no banco
            if (Sucesso == false)
            {
                Notification.CorPainel = Color.Red;
                Notification.Icone = Properties.Resources.Error;
                Notification toastNotificationS = new Notification("Erro de conexão", "Os dados selecionados foram apagados apenas localmente !", 30, FormAnimator.AnimationMethod.Slide, FormAnimator.AnimationDirection.Up);
                Form1_Principal.playaudio(Ping_Pro_Tools.Properties.Resources.zapsplat_error);
                toastNotificationS.Show();
            }
            else
            {
                Notification.CorPainel = Color.Green;
                Notification.Icone = Properties.Resources.Sucess;
                Notification toastNotificationS = new Notification("Sucesso", "Os dados selecionados foram apagados com sucesso!", 5, FormAnimator.AnimationMethod.Slide, FormAnimator.AnimationDirection.Up);
                Form1_Principal.playaudio(Ping_Pro_Tools.Properties.Resources.zapslat_sucess);
                toastNotificationS.Show();
            }
        }
    }
}

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
    public partial class Form4_Historico : Form
    {
        private string Servidor;
        private string Porta;
        private string Usuario;
        private string Senha;
        private string BD;
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
            connectionString = "SERVER=" + server + ";"  + "PORT="+ Porta + ";" +  "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
         

            using (MySqlConnection sqlConn = new MySqlConnection(connectionString))
            {
                sqlConn.Open();
                using (MySqlCommand sqlCommand = new MySqlCommand("DELETE FROM Ping WHERE idPing = " + row["idPing"], sqlConn))
                {   
                    
                    int sucesso = sqlCommand.ExecuteNonQuery();
                    if (sucesso < 1)
                    {
                        MessageBox.Show("Não Apagado");
                    }
                    else
                    {
                        MessageBox.Show("Apagado");
                    }
                    
                }
 
            }
            foreach (DataGridViewRow linha in kryptonDataGridView1.SelectedRows)
            {
                if (!linha.IsNewRow)
                    kryptonDataGridView1.Rows.Remove(linha);
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
                backgroundWorker1.RunWorkerAsync();
            else
                backgroundWorker1.CancelAsync();
        }

        private void Btn_EnviarAnalise_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Servidor.ToString());
        }
    }
}

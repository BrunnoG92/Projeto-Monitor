using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ping_Pro_Tools
{
    public partial class Form5_Configuracoes : Form
    {
        public static string Servidor;
        public static string Porta;
        public static string BD;
        public static string Usuario;
        public static string Senha;

      

        public Form5_Configuracoes()
        {
            InitializeComponent();
            //recebem os valores ao iniciar o programa
            backgroundWorker1.RunWorkerAsync();

        }

        public void Btn_Conectar_Click(object sender, EventArgs e)
        {
            MySqlConnection connection;
            string server;
            string database;
            string uid;
            string password;
            string porta;
            //recebe os valores atualizados
            server = TxtB_Servidor.Text;
            database = Txtb_BD.Text;
            uid = TxtB_Usuario.Text;
            password = TxtB_Senha.Text;
            porta = Txtb_Porta.Text;

            string connectionString;
            connectionString = "SERVER=" + server + ";" + "PORT=" + porta + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);

            try
            {
                using (MySqlConnection sqlConn = new MySqlConnection(connectionString))
                {
                    sqlConn.Open();
                    if (sqlConn.State == ConnectionState.Open)
                    {
                        MessageBox.Show("Conectado com sucesso");
                    }


                }
            }
            catch
            {
                MessageBox.Show("Erro na conexão com o banco de dados");
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {   
            //atualiza constantemente os valores
            do
            {
                Servidor = TxtB_Servidor.Text;
                Porta = Txtb_Porta.Text;
                BD = Txtb_BD.Text;
                Usuario = TxtB_Usuario.Text;
                Senha = TxtB_Senha.Text;

            } while (true);
            
        }
    }
}

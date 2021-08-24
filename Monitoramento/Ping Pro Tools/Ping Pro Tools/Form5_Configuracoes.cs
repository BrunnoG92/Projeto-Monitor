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
           // backgroundWorker1.RunWorkerAsync();

        }

      
       
    }
}

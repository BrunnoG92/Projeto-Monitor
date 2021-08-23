using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ping_Pro_Tools
{
   
    public partial class Form0_Login : Form
    {
        public static string Usuario;
        public static string Senha;
        
        //
        // Inicio da persoanlização da Form. Deixa a form com bordas arredondadas //
        //

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
        public Form0_Login()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.icone_globo;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }




        // Arrastar a janela com o mouse : Com o evento MouseDown
        //
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        private void Form0_Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form_Login_Config Configura = new Form_Login_Config();
            Configura.ShowDialog();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {   // colocar para buscar usuários e senha ao clicar em logar. senha salva em hash
            string conectasql = ConfigurationManager.ConnectionStrings["MinhaConexao"].ConnectionString;
            try
            {

                MySqlConnection mysqlconn = new MySqlConnection(conectasql);
                mysqlconn.Open();
                string query = $"SELECT * FROM Usuarios WHERE Usuario ={TxtB_Usuario.Text}";
                

                if (mysqlconn.State == ConnectionState.Open)
                {   
                    Form1_Principal Iniciar = new Form1_Principal();
                    Iniciar.FormClosed += new FormClosedEventHandler(Iniciar_FormClosed); //Capturo o evento form close
                    this.Hide();
                    Iniciar.Show();
                }

            }
            catch
            {
                MessageBox.Show("Não foi possivel estabelecer uma conexão com o banco de dados. Verifique sua conexão com a internet ou as configurações de Banco De Dados", "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        void Iniciar_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true; // se form Principal estiver fechado, abro o form login
        }

        private void TxtB_Usuario_TextChanged(object sender, EventArgs e)
        {
            Usuario = TxtB_Usuario.Text.Trim();
           
        }

        private void TxtB_Senha_TextChanged(object sender, EventArgs e)
        {
            Senha = TxtB_Senha.Text.Trim();
        }



        // FIM ARRASTAR COM O MOUSE
    }
}

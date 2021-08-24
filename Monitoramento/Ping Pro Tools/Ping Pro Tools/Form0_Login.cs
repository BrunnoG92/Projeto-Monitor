using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
        string NomePasta = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
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
            System.IO.Directory.CreateDirectory(NomePasta);
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
        public static string getBetween(string strSource, string strStart, string strEnd)
        {
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                int Start, End;
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }

            return "";
        }
        private void Btn_Login_Click(object sender, EventArgs e)
        {   // colocar para buscar usuários e senha ao clicar em logar. senha salva em hash
            
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            string DBConn = ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString();
            string Servidor = getBetween(DBConn, "Data Source=", ";");
            string Porta = getBetween(DBConn, "port=", ";");
            string BancoDeDados = getBetween(DBConn,"Initial Catalog=", ";");

            // Update the setting.
             var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
             connectionStringsSection.ConnectionStrings["MinhaConexao"].ConnectionString = $"Data Source=" + Servidor + ";port=" + Porta + ";Initial Catalog=" + BancoDeDados + ";UID=" + Usuario + ";password=" +Senha + ";SslMode=none;";
             config.Save(ConfigurationSaveMode.Full);
             ConfigurationManager.RefreshSection("connectionStrings");
            try
            {
                string conectasql = ConfigurationManager.ConnectionStrings["MinhaConexao"].ConnectionString;
                MySqlConnection mysqlconn = new MySqlConnection(conectasql);
                mysqlconn.Open();
                if (mysqlconn.State == ConnectionState.Open)
                {   
                    Form1_Principal Iniciar = new Form1_Principal();
                    Iniciar.FormClosed += new FormClosedEventHandler(Iniciar_FormClosed); //Capturo o evento form close
                    this.Hide();
                    Iniciar.Show();
                   
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message,"Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }
        void Iniciar_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true; // se form Principal estiver fechado, abro o form login
            if (ChkB_Salva.Checked == false)
            {
                TxtB_Usuario.Text = null;
                TxtB_Senha.Text = null;

                System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                string DBConn = ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString();
                string Servidor = getBetween(DBConn, "Data Source=", ";");
                string Porta = getBetween(DBConn, "port=", ";");
                string BancoDeDados = getBetween(DBConn, "Initial Catalog=", ";");
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                connectionStringsSection.ConnectionStrings["MinhaConexao"].ConnectionString = $"Data Source=" + Servidor + ";port=" + Porta + ";Initial Catalog=" + BancoDeDados + ";UID=" + Usuario + ";password=" + Senha + ";SslMode=none;";
            }
        }
       

        private void TxtB_Usuario_TextChanged(object sender, EventArgs e)
        {
            Usuario = TxtB_Usuario.Text.Trim();
           
        }

        private void TxtB_Senha_TextChanged(object sender, EventArgs e)
        {
            Senha = TxtB_Senha.Text.Trim();
        }

        private void ovalPictureBox1_Click(object sender, EventArgs e)
        {
            // abre a caixa de diálogo do arquivo   
            OpenFileDialog open = new OpenFileDialog();
            // filtros de imagem  
            open.Filter = "Arquivos de imagem (*. jpg; * .jpeg; * .gif; * .bmp) | * .jpg; * .jpeg; * .gif; * .bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // exibe a imagem na caixa de imagem  
                ovalPictureBox1.Image = new  Bitmap(open.FileName);
               
            }
        }

        private void Form0_Login_Load(object sender, EventArgs e)
        {
            string N_Arquivo = TxtB_Usuario.Text + ".jpg";
            string Caminho = NomePasta + @"\" +  N_Arquivo;
          //  MessageBox.Show(Caminho);
            ovalPictureBox1.Image.Save(Caminho, ovalPictureBox1.Image.RawFormat);
        }







        // FIM ARRASTAR COM O MOUSE
    }
}

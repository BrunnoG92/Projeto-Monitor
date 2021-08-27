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
        string UsuarioSalvo;
        public static string Senha;
        Bitmap FotoUsuario;
        Bitmap FotoSalva;

        string NomePasta = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures); // pego o caminho da pasta imagens
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


            // pego o nome de usuario salvo
            string value = System.Configuration.ConfigurationManager.AppSettings["username"];
            UsuarioSalvo = value;
            Lbl_User.Text = value;
            TxtB_Usuario.Text = value;

            // defino a foto do usuario na picturebox se não for null na inicialização



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
        {

            // colocar para buscar usuários e senha ao clicar em logar. senha salva em hash

            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            string DBConn = ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString();
            string Servidor = getBetween(DBConn, "Data Source=", ";");
            string Porta = getBetween(DBConn, "port=", ";");
            string BancoDeDados = getBetween(DBConn, "Initial Catalog=", ";");

            // Update the setting.
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["MinhaConexao"].ConnectionString = $"Data Source=" + Servidor + ";port=" + Porta + ";Initial Catalog=" + BancoDeDados + ";UID=" + Usuario + ";password=" + Senha + ";SslMode=none;";
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
                MessageBox.Show(Ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // salvo o nome do usuário no appconfig se o usuario selecionou 
            if (ChkB_Salva.Checked == true)
            {
                config.AppSettings.Settings["username"].Value = TxtB_Usuario.Text;
                config.Save(ConfigurationSaveMode.Modified);
                // salvo a foto do usuario na pasta imagem
                string N_Arquivo = Usuario + ".jpg";
                string Caminho = NomePasta + @"\" + N_Arquivo;
                ovalPictureBox1.Image.Save(Caminho, ovalPictureBox1.Image.RawFormat);

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
                //string DBConn = ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString();
                // string Servidor = getBetween(DBConn, "Data Source=", ";");
                //string Porta = getBetween(DBConn, "port=", ";");
                //string BancoDeDados = getBetween(DBConn, "Initial Catalog=", ";");
                //var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                //connectionStringsSection.ConnectionStrings["MinhaConexao"].ConnectionString = $"Data Source=" + Servidor + ";port=" + Porta + ";Initial Catalog=" + BancoDeDados + ";UID=" + Usuario + ";password=" + Senha + ";SslMode=none;";
                Lbl_User.Text = "Usuario";
                ovalPictureBox1.Image = Properties.Resources.user;
            }
            else if (ChkB_Salva.Checked == true)
            {   // carrego a foto do usuario que esta na variavel FotoUsuario, quando a janela principal for fechada
                UsuarioSalvo = Usuario;
                Lbl_User.Text = UsuarioSalvo;
                if (FotoUsuario != null)
                {
                    ovalPictureBox1.Image = FotoUsuario;
                }
            }


        }



        private void TxtB_Usuario_TextChanged(object sender, EventArgs e)
        {   // pego o nome do usuario
            Usuario = TxtB_Usuario.Text.Trim();

        }

        private void TxtB_Senha_TextChanged(object sender, EventArgs e)
        {
            Senha = TxtB_Senha.Text.Trim();
        }

        private void ovalPictureBox1_Click(object sender, EventArgs e)
        {
            string N_Arquivo = TxtB_Usuario.Text + ".jpg";
            string Caminho = NomePasta + @"\" + N_Arquivo;
            // abre a caixa de diálogo do arquivo   
            File.Delete(Caminho);
            OpenFileDialog open = new OpenFileDialog();
            // filtros de imagem  
            open.Filter = "Arquivos de imagem (*. jpg; *. png; * .jpeg; * .gif; * .bmp) | * .jpg; * .png; * .jpeg; * .gif; * .bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // exibe a imagem na caixa de imagem  

                FotoSalva = new Bitmap(open.FileName);
                ovalPictureBox1.Image = FotoSalva;

            }
            //salvo a foto que o usuário escolheu após ela ser trocada na pasta imagems e na variavel foto
            ovalPictureBox1.Image.Save(Caminho, ovalPictureBox1.Image.RawFormat);
            FotoUsuario = (Bitmap)ovalPictureBox1.Image;

        }

        private void Form0_Login_Load(object sender, EventArgs e)
        {
            // Na inicialização, faço uma cópia da foto atual, se ela existir
            // Salvo essa cópia na variavel FotoSalva e então carrego para a picturebox
            // Se a cópia da imagem já existe, apago a cópia
            string N_Arquivo = TxtB_Usuario.Text + ".jpg";
            string Caminho = NomePasta + @"\" + N_Arquivo;
            if (File.Exists(Caminho))
            {
                string N_ArquivoCopia = TxtB_Usuario.Text + "1.jpg";
                string CaminhoCopia = NomePasta + @"\" + N_ArquivoCopia;
                if (File.Exists(CaminhoCopia))
                {
                    File.Delete(CaminhoCopia);
                }
                File.Copy(Caminho, CaminhoCopia);
                FotoSalva = (Bitmap)Image.FromFile(CaminhoCopia);
                ovalPictureBox1.Image = FotoSalva;
            }
            else
            {
                ovalPictureBox1.Image = Properties.Resources.user;
            }

        }














        // FIM ARRASTAR COM O MOUSE
    }
}

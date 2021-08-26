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
   
    public partial class Form_Login_Config : Form
    {
        public static string Servidor;
        public static string BancoDeDados;

        //
        // Inicio da persoanlização da Form. Deixa a form com bordas arredondadas //
        //
        public static bool salvo;

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

        public Form_Login_Config()
        {
            InitializeComponent();
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

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            // salvo até 03 banco de dados
            string server = System.Configuration.ConfigurationManager.AppSettings["servidor"];
            string bd = System.Configuration.ConfigurationManager.AppSettings["bancodedados"];

            string server2 = System.Configuration.ConfigurationManager.AppSettings["servidor2"];
            string bd2 = System.Configuration.ConfigurationManager.AppSettings["bancodedados2"];

            string server3 = System.Configuration.ConfigurationManager.AppSettings["servidor3"];
            string bd3 = System.Configuration.ConfigurationManager.AppSettings["bancodedados3"];

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["MinhaConexao"].ConnectionString = $"Data Source=" + CmB_Servidor.Text + ";Initial Catalog=" + CmB_Banco.Text + ";port=" + Txb_Porta.Text +";";
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");
          
            MessageBox.Show("Configurações salva com sucesso. ","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            BancoDeDados = CmB_Banco.Text;
            Servidor = CmB_Servidor.Text;

            if (string.IsNullOrEmpty(server))
                if (CmB_Servidor.SelectedIndex == 0)
                {
                    // salvo a config 1s e a config 1 estiver vazia
                    config.AppSettings.Settings["servidor"].Value = Servidor;
                    config.AppSettings.Settings["bancodedados"].Value = BancoDeDados;
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("servidor");
                    ConfigurationManager.RefreshSection("bancodedados");
                    CmB_Servidor.Items.Add(server);
                    CmB_Banco.Items.Add(bd);
                    ConfigurationManager.RefreshSection("appSettings");
                }


            if (string.IsNullOrEmpty(server) == false)
                if (CmB_Servidor.SelectedIndex == 1)
                {    // se ja há uma configuração1, salvo na config 2
                    config.AppSettings.Settings["servidor2"].Value = Servidor;
                    config.AppSettings.Settings["bancodedados2"].Value = BancoDeDados;
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("servidor2");
                    ConfigurationManager.RefreshSection("bancodedados2");
                    CmB_Servidor.Items.Add(server2);
                    CmB_Banco.Items.Add(bd2);
                    ConfigurationManager.RefreshSection("appSettings");
                }
                   
                  
                
            
            if (string.IsNullOrEmpty(server2) == false)
            {
                if (CmB_Servidor.SelectedIndex == 2)
                { // se ja há uma configuração2, salvo na config 3
                    config.AppSettings.Settings["servidor3"].Value = Servidor;
                    config.AppSettings.Settings["bancodedados3"].Value = BancoDeDados;
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("servidor3");
                    ConfigurationManager.RefreshSection("bancodedados3");
                    CmB_Servidor.Items.Add(server3);
                    CmB_Banco.Items.Add(bd3);
                    ConfigurationManager.RefreshSection("appSettings");
                }
            }
           
          



            this.Close();
        }

        private void Form_Login_Config_Load(object sender, EventArgs e)
        {
            string server = System.Configuration.ConfigurationManager.AppSettings["servidor"];
            string bd = System.Configuration.ConfigurationManager.AppSettings["bancodedados"];

            string server2 = System.Configuration.ConfigurationManager.AppSettings["servidor2"];
            string bd2 = System.Configuration.ConfigurationManager.AppSettings["bancodedados2"];

            string server3 = System.Configuration.ConfigurationManager.AppSettings["servidor3"];
            string bd3 = System.Configuration.ConfigurationManager.AppSettings["bancodedados3"];
           
            CmB_Servidor.Items.Add(server);
            CmB_Banco.Items.Add(bd);
            CmB_Servidor.Items.Add(server2);
            CmB_Banco.Items.Add(bd2);
            CmB_Servidor.Items.Add(server3);
            CmB_Banco.Items.Add(bd3);
            CmB_Banco.SelectedIndex = 0;
            CmB_Servidor.SelectedIndex = 0;
        }

        private void Btn_Apaga_Click(object sender, EventArgs e)
        {
            if (CmB_Servidor.SelectedIndex == 0)
            {
                MessageBox.Show("0 selecionado");
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["servidor"].Value = "";
                config.AppSettings.Settings["bancodedados"].Value = "";
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("servidor");
                ConfigurationManager.RefreshSection("bancodedados");
                MessageBox.Show("Apagado");
                CmB_Servidor.Items.RemoveAt(0);
                CmB_Banco.Items.RemoveAt(0);
                ConfigurationManager.RefreshSection("appSettings");
            }
            if (CmB_Servidor.SelectedIndex == 1)
            {
                MessageBox.Show("1 selecionado");
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["servidor2"].Value = "";
                config.AppSettings.Settings["bancodedados2"].Value = "";
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("servidor2");
                ConfigurationManager.RefreshSection("bancodedados2");
                MessageBox.Show("Apagado");
                CmB_Servidor.Items.RemoveAt(1);
                CmB_Banco.Items.RemoveAt(1);
                ConfigurationManager.RefreshSection("appSettings");
            }
            if (CmB_Servidor.SelectedIndex == 2)
            {
                MessageBox.Show("2 selecionado");
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["servidor3"].Value = "";
                config.AppSettings.Settings["bancodedados3"].Value = "";
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("servidor3");
                ConfigurationManager.RefreshSection("bancodedados3");
                MessageBox.Show("Apagado");
                CmB_Servidor.Items.RemoveAt(2);
                CmB_Banco.Items.RemoveAt(2);
                ConfigurationManager.RefreshSection("appSettings");
            }
        }
    }
}

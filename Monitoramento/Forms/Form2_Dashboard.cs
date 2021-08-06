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
    public partial class Form2_Dashboard : Form
    {
        public static string EnviaID;
        public static string EnviaNome;
        public static string EnviaIP;
        public static string EnviaTamanhoPacote;
        public static string EnviaQtdPacote;
        public static Boolean EnviaFragmentaPacote;
        public static Boolean TextoTrocado;





        public Form2_Dashboard()
        {   
            InitializeComponent();
           
            // Envia para o Form1 os valores das textbox para atualização em tempo real //
            EnviaID = TxtB_ID.Text;
            EnviaNome = TxtB_Nome.Text;
            EnviaIP = TxtB_IP.Text;
            EnviaTamanhoPacote = TxtB_TPacote.Text;
            EnviaQtdPacote = TxtB_QPacote.Text;
            EnviaFragmentaPacote = Rdo_Sim.Checked;

            // Envia para o Form1 os valores das textbox salvos, para quando sair do menu //
            TxtB_ID.Text = Form1_Principal.IDTEMP;
            TxtB_Nome.Text = Form1_Principal.NOMETEMP;
            TxtB_IP.Text = Form1_Principal.IPTEMP;
            TxtB_TPacote.Text = Form1_Principal.TAMANHOTEMP;
            TxtB_QPacote.Text = Form1_Principal.QTDPACOTETEMP;
            Rdo_Sim.Checked = Form1_Principal.FRAGMENTATEMP;

            // Cores das label do dashboard //
            Lbl_ID.ForeColor = Color.White;
            Lbl_Nome.ForeColor = Color.White;
            Lbl_IP.ForeColor = Color.White;
            Lbl_TPacote.ForeColor = Color.White;
            Lbl_QPacote.ForeColor = Color.White;
            Lbl_FPacote.ForeColor = Color.White;
          



        }

        

        private void TxtB_ID_TextChanged(object sender, EventArgs e)
        {
            TextoTrocado = true;
            EnviaID = TxtB_ID.Text;
            
        }

        private void TxtB_Nome_TextChanged(object sender, EventArgs e)
        {
            TextoTrocado = true;
            EnviaNome = TxtB_Nome.Text;
        }

        private void TxtB_IP_TextChanged(object sender, EventArgs e)
        {
            TextoTrocado = true;
            EnviaIP = TxtB_IP.Text;
        }

        private void TxtB_TPacote_TextChanged(object sender, EventArgs e)
        {
            TextoTrocado = true;
            EnviaTamanhoPacote = TxtB_TPacote.Text;
        }

        private void TxtB_QPacote_TextChanged(object sender, EventArgs e)
        {
            TextoTrocado = true;
            EnviaQtdPacote = TxtB_QPacote.Text;
        }

        private void Rdo_Sim_Click(object sender, EventArgs e)
        {
            TextoTrocado = true;
            EnviaFragmentaPacote = Rdo_Sim.Checked;
        }

        private void Rdo_Nao_Click(object sender, EventArgs e)
        {
            TextoTrocado = true;
            EnviaFragmentaPacote = Rdo_Nao.Checked;
        }

       
    }
    
}

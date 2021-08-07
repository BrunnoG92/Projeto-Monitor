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
            TxtB_ID.BackColor = Color.Red;



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

        // Valida o texto digitado pelo usuário nos campo Tamanho de Pacote e Quantidade de pacote, permetindo apenas números. Caso insira 
        // uma letra ou simbolo, retorna uma mensagem de erro. Também destaca as textbox quando ativas. Vermlha quando há letra e roxo quando há números.
        //

        // Destaque da TextBox Tamanho Pacote
        private void TxtB_TPacote_KeyPress(object sender, KeyPressEventArgs e)
        {   
            // Se o digitado for letra. Destaca com a cor vermelha e mostra uma mensagem de erro. Caso seja numero, permite a digitação e destaca em roxo
           
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
                MessageBox.Show("Somente números são permitidos no campo tamanho de pacote", "Caractere inválido",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtB_TPacote.StateCommon.Border.Color1 = Color.Red;
                
                TxtB_TPacote.StateCommon.Border.Width = 2;
               
            }


             else if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
           {
               e.Handled = false;

                            TxtB_TPacote.StateCommon.Border.Color1 = Color.FromArgb(72, 0, 224);

            TxtB_TPacote.StateCommon.Border.Width = 2;
            }

        }


        private void TxtB_TPacote_Leave(object sender, EventArgs e)
        {
            TxtB_TPacote.StateCommon.Border.Color1 = Color.Black;
            TxtB_TPacote.StateCommon.Border.Width = -1;
        }

        // // Destaque TextBox Quantidade de Pacote Ativo
        private void TxtB_QPacote_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Se o digitado for letra. Destaca com a cor vermelha e mostra uma mensagem de erro. Caso seja numero, permite a digitação e destaca em roxo
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Somente números são permitidos no campo tamanho de pacote", "Caractere inválido",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtB_QPacote.StateCommon.Border.Color1 = Color.Red;

                TxtB_QPacote.StateCommon.Border.Width = 2;
            }
           else if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = false;

                TxtB_QPacote.StateCommon.Border.Color1 = Color.FromArgb(72, 0, 224);

                TxtB_QPacote.StateCommon.Border.Width = 2;
            }
        }

        // Destaque TextBox Quantidade de pacote Inativo
        private void TxtB_QPacote_Leave(object sender, EventArgs e)
        {
            TxtB_QPacote.StateCommon.Border.Color1 = Color.Black;
            TxtB_QPacote.StateCommon.Border.Width = -1;
        }
        // Destaque TextBox ID Ativo
        private void TxtB_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
                TxtB_ID.StateCommon.Border.Color1 = Color.FromArgb(72, 0, 224);
                TxtB_ID.StateCommon.Border.Width = 2;
        }
        // Destaque TextBox ID Inativo
        private void TxtB_ID_Leave(object sender, EventArgs e)
        {
            TxtB_ID.StateCommon.Border.Color1 = Color.Black;
            TxtB_ID.StateCommon.Border.Width = -1;
        }
        // Destaque TextBox Nome Ativo
        private void TxtB_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            TxtB_Nome.StateCommon.Border.Color1 = Color.FromArgb(72, 0, 224);
            TxtB_Nome.StateCommon.Border.Width = 2;
        }
        // Destaque TextBox Nome Inativo
        private void TxtB_Nome_Leave(object sender, EventArgs e)
        {
            TxtB_Nome.StateCommon.Border.Color1 = Color.Black;
            TxtB_Nome.StateCommon.Border.Width = -1;
        }
        // Destaque TextBox IP Ativo
        private void TxtB_IP_KeyPress(object sender, KeyPressEventArgs e)
        {
            TxtB_IP.StateCommon.Border.Color1 = Color.FromArgb(72, 0, 224);
            TxtB_IP.StateCommon.Border.Width = 2;
        }
        // Destaque TextBox IP Inativo
        private void TxtB_IP_Leave(object sender, EventArgs e)
        {
            TxtB_IP.StateCommon.Border.Color1 = Color.Black;
            TxtB_IP.StateCommon.Border.Width = -1;
        }
    }
    
}

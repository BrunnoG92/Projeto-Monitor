using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MetroSet_UI.Forms;

namespace Monitoramento
{
    
    public partial class Form_Dashboard : Form
    {
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


        public Form_Dashboard()
        {
            InitializeComponent();
            Lbl_ID.ForeColor = Color.White;
            Lbl_Nome.ForeColor = Color.White;
            Lbl_TPacote.ForeColor = Color.White;
            Lbl_IP.ForeColor = Color.White;
            Lbl_QPacote.ForeColor = Color.White;
            Lbl_FPacote.ForeColor = Color.White;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            Pnl_Navegacao.Height = Btn1_Dashboard.Height;
            Pnl_Navegacao.Top = Btn1_Dashboard.Top;
            Pnl_Navegacao.Left = Btn1_Dashboard.Left;
            Btn1_Dashboard.BackColor = Color.FromArgb(46, 51, 73);

        }
        // INICIO DESTAQUE MENU LATERAL //

        private void Btn1_Dashboard_Click(object sender, EventArgs e)
        {
          
            Pnl_Navegacao.Height = Btn1_Dashboard.Height;
            Pnl_Navegacao.Top = Btn1_Dashboard.Top;
            Pnl_Navegacao.Left = Btn1_Dashboard.Left;
            Btn1_Dashboard.BackColor = Color.FromArgb(46, 51, 73);
        }


        private void Btn3_Historico_Click(object sender, EventArgs e)
        {
            Pnl_Navegacao.Height = Btn3_Historico.Height;
            Pnl_Navegacao.Top = Btn3_Historico.Top;
            Pnl_Navegacao.Left = Btn3_Historico.Left;
            Btn3_Historico.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Btn4_Configuracoes_Click(object sender, EventArgs e)
        {
            Pnl_Navegacao.Height = Btn4_Configuracoes.Height;
            Pnl_Navegacao.Top = Btn4_Configuracoes.Top;
            Pnl_Navegacao.Left = Btn4_Configuracoes.Left;
            Btn4_Configuracoes.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Btn1_Dashboard_Leave(object sender, EventArgs e)
        {
            Btn1_Dashboard.BackColor = Color.FromArgb(24, 30, 54);
        }
       

        private void Btn3_Historico_Leave(object sender, EventArgs e)
        {
            Btn3_Historico.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Btn4_Configuracoes_Leave(object sender, EventArgs e)
        {
            Btn4_Configuracoes.BackColor = Color.FromArgb(24, 30, 54);
        }


         // DESTAQUE NA TEXT BOX //
        private void TxtB_ID_TextChanged(object sender, EventArgs e)
        {
            TxtB_ID.StateCommon.Border.Color1 = Color.FromArgb(72, 0, 224);
            TxtB_ID.StateCommon.Border.Color2 = Color.FromArgb(72, 0, 224);
            TxtB_ID.StateCommon.Border.Width = 2;
        }
       
        private void TxtB_Nome_TextChanged(object sender, EventArgs e)
        {
            TxtB_Nome.StateCommon.Border.Color1 = Color.FromArgb(72, 0, 224);
            TxtB_Nome.StateCommon.Border.Color2 = Color.FromArgb(72, 0, 224);
            TxtB_Nome.StateCommon.Border.Width = 2;
        }
        private void TxtB_IP_TextChanged(object sender, EventArgs e)
        {
            TxtB_IP.StateCommon.Border.Color1 = Color.FromArgb(72, 0, 224);
            TxtB_IP.StateCommon.Border.Color2 = Color.FromArgb(72, 0, 224);
            TxtB_IP.StateCommon.Border.Width = 2;
        }
        private void TxtB_TPacote_TextChanged(object sender, EventArgs e)
        {
            TxtB_TPacote.StateCommon.Border.Color1 = Color.FromArgb(72, 0, 224);
            TxtB_TPacote.StateCommon.Border.Color2 = Color.FromArgb(72, 0, 224);
            TxtB_TPacote.StateCommon.Border.Width = 2;
        }
        private void TxtB_QPacote_TextChanged(object sender, EventArgs e)
        {
            TxtB_QPacote.StateCommon.Border.Color1 = Color.FromArgb(72, 0, 224);
            TxtB_QPacote.StateCommon.Border.Color2 = Color.FromArgb(72, 0, 224);
            TxtB_QPacote.StateCommon.Border.Width = 2;
        }


        private void TxtB_ID_Leave(object sender, EventArgs e)
        {
            TxtB_ID.StateCommon.Border.Color1 = Color.FromArgb(24, 30, 54);
            TxtB_ID.StateCommon.Border.Color2 = Color.FromArgb(24, 30, 54);
            TxtB_ID.StateCommon.Border.Width = -1;
        }

        private void TxtB_Nome_Leave(object sender, EventArgs e)
        {
            TxtB_Nome.StateCommon.Border.Color1 = Color.FromArgb(24, 30, 54);
            TxtB_Nome.StateCommon.Border.Color2 = Color.FromArgb(24, 30, 54);
            TxtB_Nome.StateCommon.Border.Width = -1;
        }

        private void TxtB_IP_Leave(object sender, EventArgs e)
        {
            TxtB_IP.StateCommon.Border.Color1 = Color.FromArgb(24, 30, 54);
            TxtB_IP.StateCommon.Border.Color2 = Color.FromArgb(24, 30, 54);
            TxtB_IP.StateCommon.Border.Width = -1;
        }

        private void TxtB_TPacote_Leave(object sender, EventArgs e)
        {
            TxtB_TPacote.StateCommon.Border.Color1 = Color.FromArgb(24, 30, 54);
            TxtB_TPacote.StateCommon.Border.Color2 = Color.FromArgb(24, 30, 54);
            TxtB_TPacote.StateCommon.Border.Width = -1;
        }

        private void TxtB_QPacote_Leave(object sender, EventArgs e)
        {
            TxtB_QPacote.StateCommon.Border.Color1 = Color.FromArgb(24, 30, 54);
            TxtB_QPacote.StateCommon.Border.Color2 = Color.FromArgb(24, 30, 54);
            TxtB_QPacote .StateCommon.Border.Width = -1;
        }

        private void Btn4_Iniciar_Click(object sender, EventArgs e)
        {
            var PegaIP = TxtB_IP.Text;
            int PegaTamPacote =  Convert.ToInt32(TxtB_TPacote);
            int PegaQtdPacote = Convert.ToInt32(TxtB_QPacote);



        }
    }
}

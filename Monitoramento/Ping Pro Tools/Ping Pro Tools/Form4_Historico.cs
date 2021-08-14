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
        public Form4_Historico()
        {
            InitializeComponent();
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            DataRow row = (kryptonDataGridView1.SelectedRows[0].DataBoundItem as DataRowView).Row;
           

                using (MySqlConnection sqlConn = new MySqlConnection("Server=bruno-dev.coswwudtnlbd.us-east-2.rds.amazonaws.com;Port=3306;Database=PingProTools;Uid=brunog;Pwd=98497389b;"))
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
                    foreach (DataGridViewRow linha in kryptonDataGridView1.SelectedRows)
                    {
                        if (!linha.IsNewRow)
                            kryptonDataGridView1.Rows.Remove(linha);
                    }
                }
                


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
            MessageBox.Show(DateTime.Now.ToString("dd/MM/yyy"));
        }

        private void Btn_Apagar_Click(object sender, EventArgs e)
        {

            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
            else
                backgroundWorker1.CancelAsync();
        }
        
    }
}

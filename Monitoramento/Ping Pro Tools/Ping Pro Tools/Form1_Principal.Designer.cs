
namespace Ping_Pro_Tools
{
    partial class Form1_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn4_Config = new System.Windows.Forms.Button();
            this.Btn3_Historico = new System.Windows.Forms.Button();
            this.Btn2_Analise = new System.Windows.Forms.Button();
            this.Pnl_Navegacao = new System.Windows.Forms.Panel();
            this.Btn1_Dashboard = new System.Windows.Forms.Button();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.Pnl2_Grade = new System.Windows.Forms.Panel();
            this.Pnl_BotoesDashboard = new System.Windows.Forms.Panel();
            this.Btn7_Parar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Btn6_Iniciar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Lbl_Progresso = new System.Windows.Forms.Label();
            this.Lbl_TempoEstimado2 = new System.Windows.Forms.Label();
            this.Lbl_TempoEstimado = new System.Windows.Forms.Label();
            this.Lbl_Porcentagem = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Pnl_BotoesDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Btn4_Config);
            this.panel2.Controls.Add(this.Btn3_Historico);
            this.panel2.Controls.Add(this.Btn2_Analise);
            this.panel2.Controls.Add(this.Pnl_Navegacao);
            this.panel2.Controls.Add(this.Btn1_Dashboard);
            this.panel2.Controls.Add(this.Lbl_Usuario);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 614);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-118, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 30);
            this.label1.TabIndex = 64;
            this.label1.Text = "Usuário:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn4_Config
            // 
            this.Btn4_Config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn4_Config.FlatAppearance.BorderSize = 0;
            this.Btn4_Config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn4_Config.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn4_Config.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn4_Config.Image = global::Ping_Pro_Tools.Properties.Resources.settings;
            this.Btn4_Config.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn4_Config.Location = new System.Drawing.Point(3, 566);
            this.Btn4_Config.Name = "Btn4_Config";
            this.Btn4_Config.Size = new System.Drawing.Size(167, 48);
            this.Btn4_Config.TabIndex = 7;
            this.Btn4_Config.Text = "Configurações";
            this.Btn4_Config.UseVisualStyleBackColor = true;
            this.Btn4_Config.Click += new System.EventHandler(this.Btn4_Config_Click);
            this.Btn4_Config.Leave += new System.EventHandler(this.Btn4_Config_Leave);
            // 
            // Btn3_Historico
            // 
            this.Btn3_Historico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn3_Historico.FlatAppearance.BorderSize = 0;
            this.Btn3_Historico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3_Historico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn3_Historico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn3_Historico.Image = global::Ping_Pro_Tools.Properties.Resources.calendar;
            this.Btn3_Historico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn3_Historico.Location = new System.Drawing.Point(3, 188);
            this.Btn3_Historico.Name = "Btn3_Historico";
            this.Btn3_Historico.Size = new System.Drawing.Size(167, 48);
            this.Btn3_Historico.TabIndex = 6;
            this.Btn3_Historico.Text = "Histórico   ";
            this.Btn3_Historico.UseVisualStyleBackColor = true;
            this.Btn3_Historico.Click += new System.EventHandler(this.Btn3_Historico_Click);
            this.Btn3_Historico.Leave += new System.EventHandler(this.Btn3_Historico_Leave);
            // 
            // Btn2_Analise
            // 
            this.Btn2_Analise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn2_Analise.FlatAppearance.BorderSize = 0;
            this.Btn2_Analise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2_Analise.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn2_Analise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn2_Analise.Image = global::Ping_Pro_Tools.Properties.Resources.diagram;
            this.Btn2_Analise.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn2_Analise.Location = new System.Drawing.Point(3, 143);
            this.Btn2_Analise.Name = "Btn2_Analise";
            this.Btn2_Analise.Size = new System.Drawing.Size(164, 48);
            this.Btn2_Analise.TabIndex = 5;
            this.Btn2_Analise.Text = "Análises    ";
            this.Btn2_Analise.UseVisualStyleBackColor = true;
            this.Btn2_Analise.Click += new System.EventHandler(this.Btn2_Analise_Click);
            this.Btn2_Analise.Leave += new System.EventHandler(this.Btn2_Analise_Leave);
            // 
            // Pnl_Navegacao
            // 
            this.Pnl_Navegacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Pnl_Navegacao.Location = new System.Drawing.Point(0, 95);
            this.Pnl_Navegacao.Name = "Pnl_Navegacao";
            this.Pnl_Navegacao.Size = new System.Drawing.Size(2, 75);
            this.Pnl_Navegacao.TabIndex = 4;
            // 
            // Btn1_Dashboard
            // 
            this.Btn1_Dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn1_Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn1_Dashboard.FlatAppearance.BorderSize = 0;
            this.Btn1_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1_Dashboard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn1_Dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn1_Dashboard.Image = global::Ping_Pro_Tools.Properties.Resources.home;
            this.Btn1_Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn1_Dashboard.Location = new System.Drawing.Point(0, 95);
            this.Btn1_Dashboard.Name = "Btn1_Dashboard";
            this.Btn1_Dashboard.Size = new System.Drawing.Size(170, 48);
            this.Btn1_Dashboard.TabIndex = 3;
            this.Btn1_Dashboard.Text = "Dashboard ";
            this.Btn1_Dashboard.UseVisualStyleBackColor = true;
            this.Btn1_Dashboard.Click += new System.EventHandler(this.Btn1_Dashboard_Click);
            this.Btn1_Dashboard.Leave += new System.EventHandler(this.Btn1_Dashboard_Leave);
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.Lbl_Usuario.Location = new System.Drawing.Point(48, 69);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(55, 17);
            this.Lbl_Usuario.TabIndex = 2;
            this.Lbl_Usuario.Text = "Usuário";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Ping_Pro_Tools.Properties.Resources.Untitled_11;
            this.pictureBox2.Location = new System.Drawing.Point(28, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 95);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(984, 0);
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 2;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // Pnl2_Grade
            // 
            this.Pnl2_Grade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Pnl2_Grade.BackgroundImage = global::Ping_Pro_Tools.Properties.Resources.dark;
            this.Pnl2_Grade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Pnl2_Grade.Location = new System.Drawing.Point(188, 46);
            this.Pnl2_Grade.Name = "Pnl2_Grade";
            this.Pnl2_Grade.Size = new System.Drawing.Size(837, 432);
            this.Pnl2_Grade.TabIndex = 0;
            // 
            // Pnl_BotoesDashboard
            // 
            this.Pnl_BotoesDashboard.Controls.Add(this.Btn7_Parar);
            this.Pnl_BotoesDashboard.Controls.Add(this.Btn6_Iniciar);
            this.Pnl_BotoesDashboard.Location = new System.Drawing.Point(188, 484);
            this.Pnl_BotoesDashboard.Name = "Pnl_BotoesDashboard";
            this.Pnl_BotoesDashboard.Size = new System.Drawing.Size(837, 67);
            this.Pnl_BotoesDashboard.TabIndex = 3;
            // 
            // Btn7_Parar
            // 
            this.Btn7_Parar.Location = new System.Drawing.Point(429, 19);
            this.Btn7_Parar.Name = "Btn7_Parar";
            this.Btn7_Parar.Size = new System.Drawing.Size(114, 31);
            this.Btn7_Parar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn7_Parar.StateCommon.Border.Rounding = 10;
            this.Btn7_Parar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.Btn7_Parar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Btn7_Parar.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.Btn7_Parar.StateDisabled.Back.Color2 = System.Drawing.Color.Silver;
            this.Btn7_Parar.TabIndex = 1;
            this.Btn7_Parar.Values.Text = "PARAR";
            this.Btn7_Parar.Click += new System.EventHandler(this.Btn7_Parar_Click);
            // 
            // Btn6_Iniciar
            // 
            this.Btn6_Iniciar.Location = new System.Drawing.Point(175, 19);
            this.Btn6_Iniciar.Name = "Btn6_Iniciar";
            this.Btn6_Iniciar.Size = new System.Drawing.Size(114, 31);
            this.Btn6_Iniciar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn6_Iniciar.StateCommon.Border.Rounding = 10;
            this.Btn6_Iniciar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.Btn6_Iniciar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Btn6_Iniciar.TabIndex = 0;
            this.Btn6_Iniciar.Values.Text = "INICIAR";
            this.Btn6_Iniciar.Click += new System.EventHandler(this.Btn6_Iniciar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(342, 566);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(405, 25);
            this.progressBar1.TabIndex = 4;
            // 
            // Lbl_Progresso
            // 
            this.Lbl_Progresso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Progresso.ForeColor = System.Drawing.Color.White;
            this.Lbl_Progresso.Location = new System.Drawing.Point(217, 554);
            this.Lbl_Progresso.Name = "Lbl_Progresso";
            this.Lbl_Progresso.Size = new System.Drawing.Size(109, 51);
            this.Lbl_Progresso.TabIndex = 5;
            this.Lbl_Progresso.Text = "Progresso:";
            this.Lbl_Progresso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_TempoEstimado2
            // 
            this.Lbl_TempoEstimado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_TempoEstimado2.ForeColor = System.Drawing.Color.White;
            this.Lbl_TempoEstimado2.Location = new System.Drawing.Point(950, 554);
            this.Lbl_TempoEstimado2.Name = "Lbl_TempoEstimado2";
            this.Lbl_TempoEstimado2.Size = new System.Drawing.Size(109, 51);
            this.Lbl_TempoEstimado2.TabIndex = 6;
            this.Lbl_TempoEstimado2.Text = "00:00:00";
            this.Lbl_TempoEstimado2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_TempoEstimado
            // 
            this.Lbl_TempoEstimado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_TempoEstimado.ForeColor = System.Drawing.Color.White;
            this.Lbl_TempoEstimado.Location = new System.Drawing.Point(805, 554);
            this.Lbl_TempoEstimado.Name = "Lbl_TempoEstimado";
            this.Lbl_TempoEstimado.Size = new System.Drawing.Size(150, 51);
            this.Lbl_TempoEstimado.TabIndex = 7;
            this.Lbl_TempoEstimado.Text = "Tempo Restante:";
            this.Lbl_TempoEstimado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Porcentagem
            // 
            this.Lbl_Porcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Porcentagem.ForeColor = System.Drawing.Color.White;
            this.Lbl_Porcentagem.Location = new System.Drawing.Point(753, 554);
            this.Lbl_Porcentagem.Name = "Lbl_Porcentagem";
            this.Lbl_Porcentagem.Size = new System.Drawing.Size(55, 51);
            this.Lbl_Porcentagem.TabIndex = 8;
            this.Lbl_Porcentagem.Text = "0%";
            this.Lbl_Porcentagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.WorkerReportsProgress = true;
            this.backgroundWorker3.WorkerSupportsCancellation = true;
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            // 
            // Form1_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1083, 614);
            this.Controls.Add(this.Lbl_Porcentagem);
            this.Controls.Add(this.Lbl_TempoEstimado);
            this.Controls.Add(this.Lbl_TempoEstimado2);
            this.Controls.Add(this.Lbl_Progresso);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Pnl_BotoesDashboard);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Pnl2_Grade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_Principal_MouseDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Pnl_BotoesDashboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl2_Grade;
        private System.Windows.Forms.Panel panel2;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Pnl_Navegacao;
        private System.Windows.Forms.Button Btn1_Dashboard;
        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.Button Btn4_Config;
        private System.Windows.Forms.Button Btn3_Historico;
        private System.Windows.Forms.Button Btn2_Analise;
        private System.Windows.Forms.Panel Pnl_BotoesDashboard;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn7_Parar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn6_Iniciar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label Lbl_Progresso;
        private System.Windows.Forms.Label Lbl_TempoEstimado2;
        private System.Windows.Forms.Label Lbl_TempoEstimado;
        private System.Windows.Forms.Label Lbl_Porcentagem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.Label label1;
    }
}


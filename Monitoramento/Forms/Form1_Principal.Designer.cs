
namespace Monitoramento
{
    partial class Form1_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_Principal));
            this.Pnl1_Menu = new System.Windows.Forms.Panel();
            this.Pnl_Navegacao = new System.Windows.Forms.Panel();
            this.Btn3_Historico = new System.Windows.Forms.Button();
            this.Btn4_Configuracoes = new System.Windows.Forms.Button();
            this.Btn2_Analise = new System.Windows.Forms.Button();
            this.Btn1_Dashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.dragControl1 = new Monitoramento.DragControl();
            this.Pnl2_Grade = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn5_Parar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Btn4_Iniciar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Lbl_TempoDecorrido = new MetroSet_UI.Controls.MetroSetLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Lbl_Progresso = new MetroSet_UI.Controls.MetroSetLabel();
            this.Lbl_Porcentagem = new System.Windows.Forms.Label();
            this.Lbl_TempoEstimado2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.Pnl1_Menu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl1_Menu
            // 
            this.Pnl1_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Pnl1_Menu.Controls.Add(this.Pnl_Navegacao);
            this.Pnl1_Menu.Controls.Add(this.Btn3_Historico);
            this.Pnl1_Menu.Controls.Add(this.Btn4_Configuracoes);
            this.Pnl1_Menu.Controls.Add(this.Btn2_Analise);
            this.Pnl1_Menu.Controls.Add(this.Btn1_Dashboard);
            this.Pnl1_Menu.Controls.Add(this.panel2);
            this.Pnl1_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pnl1_Menu.Location = new System.Drawing.Point(0, 0);
            this.Pnl1_Menu.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl1_Menu.Name = "Pnl1_Menu";
            this.Pnl1_Menu.Size = new System.Drawing.Size(170, 602);
            this.Pnl1_Menu.TabIndex = 0;
            // 
            // Pnl_Navegacao
            // 
            this.Pnl_Navegacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Pnl_Navegacao.Location = new System.Drawing.Point(2, 177);
            this.Pnl_Navegacao.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl_Navegacao.Name = "Pnl_Navegacao";
            this.Pnl_Navegacao.Size = new System.Drawing.Size(2, 75);
            this.Pnl_Navegacao.TabIndex = 2;
            // 
            // Btn3_Historico
            // 
            this.Btn3_Historico.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn3_Historico.FlatAppearance.BorderSize = 0;
            this.Btn3_Historico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3_Historico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn3_Historico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn3_Historico.Image = global::Monitoramento.Properties.Resources.calendar;
            this.Btn3_Historico.Location = new System.Drawing.Point(0, 218);
            this.Btn3_Historico.Margin = new System.Windows.Forms.Padding(2);
            this.Btn3_Historico.Name = "Btn3_Historico";
            this.Btn3_Historico.Size = new System.Drawing.Size(170, 52);
            this.Btn3_Historico.TabIndex = 4;
            this.Btn3_Historico.Text = "Histórico";
            this.Btn3_Historico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn3_Historico.UseVisualStyleBackColor = true;
            this.Btn3_Historico.Click += new System.EventHandler(this.Btn3_Historico_Click);
            this.Btn3_Historico.Leave += new System.EventHandler(this.Btn3_Historico_Leave);
            // 
            // Btn4_Configuracoes
            // 
            this.Btn4_Configuracoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn4_Configuracoes.FlatAppearance.BorderSize = 0;
            this.Btn4_Configuracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn4_Configuracoes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn4_Configuracoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn4_Configuracoes.Image = global::Monitoramento.Properties.Resources.settings;
            this.Btn4_Configuracoes.Location = new System.Drawing.Point(0, 570);
            this.Btn4_Configuracoes.Margin = new System.Windows.Forms.Padding(2);
            this.Btn4_Configuracoes.Name = "Btn4_Configuracoes";
            this.Btn4_Configuracoes.Size = new System.Drawing.Size(170, 32);
            this.Btn4_Configuracoes.TabIndex = 3;
            this.Btn4_Configuracoes.Text = "Configurações";
            this.Btn4_Configuracoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn4_Configuracoes.UseVisualStyleBackColor = true;
            this.Btn4_Configuracoes.Click += new System.EventHandler(this.Btn4_Configuracoes_Click);
            this.Btn4_Configuracoes.Leave += new System.EventHandler(this.Btn4_Configuracoes_Leave);
            // 
            // Btn2_Analise
            // 
            this.Btn2_Analise.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn2_Analise.FlatAppearance.BorderSize = 0;
            this.Btn2_Analise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2_Analise.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn2_Analise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn2_Analise.Image = global::Monitoramento.Properties.Resources.diagram;
            this.Btn2_Analise.Location = new System.Drawing.Point(0, 166);
            this.Btn2_Analise.Margin = new System.Windows.Forms.Padding(2);
            this.Btn2_Analise.Name = "Btn2_Analise";
            this.Btn2_Analise.Size = new System.Drawing.Size(170, 52);
            this.Btn2_Analise.TabIndex = 2;
            this.Btn2_Analise.Text = "Análises";
            this.Btn2_Analise.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn2_Analise.UseVisualStyleBackColor = true;
            this.Btn2_Analise.Click += new System.EventHandler(this.Btn2_Analise_Click);
            this.Btn2_Analise.Leave += new System.EventHandler(this.Btn2_Analise_Leave);
            // 
            // Btn1_Dashboard
            // 
            this.Btn1_Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn1_Dashboard.FlatAppearance.BorderSize = 0;
            this.Btn1_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1_Dashboard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn1_Dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn1_Dashboard.Image = global::Monitoramento.Properties.Resources.home;
            this.Btn1_Dashboard.Location = new System.Drawing.Point(0, 118);
            this.Btn1_Dashboard.Margin = new System.Windows.Forms.Padding(2);
            this.Btn1_Dashboard.Name = "Btn1_Dashboard";
            this.Btn1_Dashboard.Size = new System.Drawing.Size(170, 48);
            this.Btn1_Dashboard.TabIndex = 1;
            this.Btn1_Dashboard.Text = "Dashboard";
            this.Btn1_Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn1_Dashboard.UseVisualStyleBackColor = true;
            this.Btn1_Dashboard.Click += new System.EventHandler(this.Btn1_Dashboard_Click);
            this.Btn1_Dashboard.Leave += new System.EventHandler(this.Btn1_Dashboard_Leave);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 118);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(47, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Monitoramento.Properties.Resources.Untitled_11;
            this.pictureBox1.Location = new System.Drawing.Point(34, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
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
            this.metroSetControlBox1.Location = new System.Drawing.Point(998, 0);
            this.metroSetControlBox1.Margin = new System.Windows.Forms.Padding(2);
            this.metroSetControlBox1.MaximizeBox = false;
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
            this.metroSetControlBox1.TabIndex = 1;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this;
            // 
            // Pnl2_Grade
            // 
            this.Pnl2_Grade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Pnl2_Grade.BackgroundImage = global::Monitoramento.Properties.Resources.dark;
            this.Pnl2_Grade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Pnl2_Grade.Location = new System.Drawing.Point(196, 30);
            this.Pnl2_Grade.Name = "Pnl2_Grade";
            this.Pnl2_Grade.Size = new System.Drawing.Size(837, 432);
            this.Pnl2_Grade.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.Btn5_Parar);
            this.panel1.Controls.Add(this.Btn4_Iniciar);
            this.panel1.Location = new System.Drawing.Point(196, 468);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 67);
            this.panel1.TabIndex = 3;
            // 
            // Btn5_Parar
            // 
            this.Btn5_Parar.Location = new System.Drawing.Point(512, 18);
            this.Btn5_Parar.Name = "Btn5_Parar";
            this.Btn5_Parar.Size = new System.Drawing.Size(97, 31);
            this.Btn5_Parar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn5_Parar.StateCommon.Border.Rounding = 10;
            this.Btn5_Parar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn5_Parar.TabIndex = 11;
            this.Btn5_Parar.Values.Text = "PARAR";
            this.Btn5_Parar.Click += new System.EventHandler(this.Btn5_Parar_Click);
            // 
            // Btn4_Iniciar
            // 
            this.Btn4_Iniciar.Location = new System.Drawing.Point(179, 18);
            this.Btn4_Iniciar.Name = "Btn4_Iniciar";
            this.Btn4_Iniciar.Size = new System.Drawing.Size(97, 31);
            this.Btn4_Iniciar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn4_Iniciar.StateCommon.Border.Rounding = 10;
            this.Btn4_Iniciar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn4_Iniciar.TabIndex = 10;
            this.Btn4_Iniciar.Values.Text = "INICIAR";
            this.Btn4_Iniciar.Click += new System.EventHandler(this.Btn4_Iniciar_Click);
            // 
            // Lbl_TempoDecorrido
            // 
            this.Lbl_TempoDecorrido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_TempoDecorrido.IsDerivedStyle = true;
            this.Lbl_TempoDecorrido.Location = new System.Drawing.Point(738, 551);
            this.Lbl_TempoDecorrido.Name = "Lbl_TempoDecorrido";
            this.Lbl_TempoDecorrido.Size = new System.Drawing.Size(149, 23);
            this.Lbl_TempoDecorrido.Style = MetroSet_UI.Enums.Style.Light;
            this.Lbl_TempoDecorrido.StyleManager = null;
            this.Lbl_TempoDecorrido.TabIndex = 24;
            this.Lbl_TempoDecorrido.Text = "Tempo Restante:";
            this.Lbl_TempoDecorrido.ThemeAuthor = "Narwin";
            this.Lbl_TempoDecorrido.ThemeName = "MetroLite";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(293, 546);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(389, 28);
            this.progressBar1.TabIndex = 22;
            // 
            // Lbl_Progresso
            // 
            this.Lbl_Progresso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Progresso.IsDerivedStyle = true;
            this.Lbl_Progresso.Location = new System.Drawing.Point(184, 538);
            this.Lbl_Progresso.Name = "Lbl_Progresso";
            this.Lbl_Progresso.Size = new System.Drawing.Size(103, 34);
            this.Lbl_Progresso.Style = MetroSet_UI.Enums.Style.Light;
            this.Lbl_Progresso.StyleManager = null;
            this.Lbl_Progresso.TabIndex = 21;
            this.Lbl_Progresso.Text = "Progresso:";
            this.Lbl_Progresso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_Progresso.ThemeAuthor = "Narwin";
            this.Lbl_Progresso.ThemeName = "MetroLite";
            // 
            // Lbl_Porcentagem
            // 
            this.Lbl_Porcentagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Lbl_Porcentagem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Porcentagem.ForeColor = System.Drawing.Color.White;
            this.Lbl_Porcentagem.Location = new System.Drawing.Point(688, 546);
            this.Lbl_Porcentagem.Name = "Lbl_Porcentagem";
            this.Lbl_Porcentagem.Size = new System.Drawing.Size(56, 28);
            this.Lbl_Porcentagem.TabIndex = 23;
            this.Lbl_Porcentagem.Text = "0%";
            this.Lbl_Porcentagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_TempoEstimado2
            // 
            this.Lbl_TempoEstimado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_TempoEstimado2.IsDerivedStyle = true;
            this.Lbl_TempoEstimado2.Location = new System.Drawing.Point(886, 551);
            this.Lbl_TempoEstimado2.Name = "Lbl_TempoEstimado2";
            this.Lbl_TempoEstimado2.Size = new System.Drawing.Size(212, 34);
            this.Lbl_TempoEstimado2.Style = MetroSet_UI.Enums.Style.Light;
            this.Lbl_TempoEstimado2.StyleManager = null;
            this.Lbl_TempoEstimado2.TabIndex = 25;
            this.Lbl_TempoEstimado2.Text = "00:00:00";
            this.Lbl_TempoEstimado2.ThemeAuthor = "Narwin";
            this.Lbl_TempoEstimado2.ThemeName = "MetroLite";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1099, 602);
            this.Controls.Add(this.Lbl_TempoEstimado2);
            this.Controls.Add(this.Lbl_TempoDecorrido);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Lbl_Progresso);
            this.Controls.Add(this.Lbl_Porcentagem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pnl2_Grade);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.Pnl1_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Principal_Load);
            this.Pnl1_Menu.ResumeLayout(false);
            this.Pnl1_Menu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl1_Menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn4_Configuracoes;
        private System.Windows.Forms.Panel Pnl_Navegacao;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private DragControl dragControl1;
        private System.Windows.Forms.Button Btn3_Historico;
        private System.Windows.Forms.Button Btn2_Analise;
        private System.Windows.Forms.Button Btn1_Dashboard;
        private MetroSet_UI.Controls.MetroSetLabel Lbl_TempoDecorrido;
        private System.Windows.Forms.ProgressBar progressBar1;
        private MetroSet_UI.Controls.MetroSetLabel Lbl_Progresso;
        private System.Windows.Forms.Label Lbl_Porcentagem;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn5_Parar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn4_Iniciar;
        private MetroSet_UI.Controls.MetroSetLabel Lbl_TempoEstimado2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        public System.Windows.Forms.Panel Pnl2_Grade;
    }
}



namespace Monitoramento
{
    partial class Form1_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_Principal));
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn5_Config = new System.Windows.Forms.Button();
            this.Pnl_Navegacao = new System.Windows.Forms.Panel();
            this.Btn4_Grafico = new System.Windows.Forms.Button();
            this.Btn3_Historico = new System.Windows.Forms.Button();
            this.Btn2_Analise = new System.Windows.Forms.Button();
            this.Btn1_Dashboard = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pnl2_Grade = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn7_Parar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Btn6_Iniciar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Lbl_Porcentagem = new System.Windows.Forms.Label();
            this.Lbl_TempoEstimado = new System.Windows.Forms.Label();
            this.Lbl_TempoEstimado2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(999, 0);
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
            this.metroSetControlBox1.TabIndex = 0;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.Btn5_Config);
            this.panel1.Controls.Add(this.Pnl_Navegacao);
            this.panel1.Controls.Add(this.Btn4_Grafico);
            this.panel1.Controls.Add(this.Btn3_Historico);
            this.panel1.Controls.Add(this.Btn2_Analise);
            this.panel1.Controls.Add(this.Btn1_Dashboard);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 602);
            this.panel1.TabIndex = 1;
            // 
            // Btn5_Config
            // 
            this.Btn5_Config.FlatAppearance.BorderSize = 0;
            this.Btn5_Config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn5_Config.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn5_Config.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn5_Config.Image = global::Monitoramento.Properties.Resources.settings;
            this.Btn5_Config.Location = new System.Drawing.Point(2, 551);
            this.Btn5_Config.Margin = new System.Windows.Forms.Padding(2);
            this.Btn5_Config.Name = "Btn5_Config";
            this.Btn5_Config.Size = new System.Drawing.Size(168, 51);
            this.Btn5_Config.TabIndex = 10;
            this.Btn5_Config.Text = "Configurações";
            this.Btn5_Config.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn5_Config.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn5_Config.UseVisualStyleBackColor = true;
            this.Btn5_Config.Click += new System.EventHandler(this.Btn5_Config_Click);
            this.Btn5_Config.Leave += new System.EventHandler(this.Btn5_Config_Leave);
            // 
            // Pnl_Navegacao
            // 
            this.Pnl_Navegacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Pnl_Navegacao.Location = new System.Drawing.Point(2, 123);
            this.Pnl_Navegacao.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl_Navegacao.Name = "Pnl_Navegacao";
            this.Pnl_Navegacao.Size = new System.Drawing.Size(2, 75);
            this.Pnl_Navegacao.TabIndex = 3;
            // 
            // Btn4_Grafico
            // 
            this.Btn4_Grafico.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn4_Grafico.FlatAppearance.BorderSize = 0;
            this.Btn4_Grafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn4_Grafico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn4_Grafico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn4_Grafico.Image = ((System.Drawing.Image)(resources.GetObject("Btn4_Grafico.Image")));
            this.Btn4_Grafico.Location = new System.Drawing.Point(0, 270);
            this.Btn4_Grafico.Margin = new System.Windows.Forms.Padding(2);
            this.Btn4_Grafico.Name = "Btn4_Grafico";
            this.Btn4_Grafico.Size = new System.Drawing.Size(170, 52);
            this.Btn4_Grafico.TabIndex = 9;
            this.Btn4_Grafico.Text = "Gráfico";
            this.Btn4_Grafico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn4_Grafico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn4_Grafico.UseVisualStyleBackColor = true;
            this.Btn4_Grafico.Click += new System.EventHandler(this.Btn4_Grafico_Click);
            this.Btn4_Grafico.Leave += new System.EventHandler(this.Btn4_Grafico_Leave);
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
            this.Btn3_Historico.TabIndex = 8;
            this.Btn3_Historico.Text = "Histórico";
            this.Btn3_Historico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn3_Historico.UseVisualStyleBackColor = true;
            this.Btn3_Historico.Click += new System.EventHandler(this.Btn3_Historico_Click);
            this.Btn3_Historico.Leave += new System.EventHandler(this.Btn3_Historico_Leave);
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
            this.Btn2_Analise.TabIndex = 7;
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
            this.Btn1_Dashboard.TabIndex = 6;
            this.Btn1_Dashboard.Text = "Dashboard";
            this.Btn1_Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn1_Dashboard.UseVisualStyleBackColor = true;
            this.Btn1_Dashboard.Click += new System.EventHandler(this.Btn1_Dashboard_Click);
            this.Btn1_Dashboard.Leave += new System.EventHandler(this.Btn1_Dashboard_Leave);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(170, 118);
            this.panel4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.label5.Location = new System.Drawing.Point(49, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Usuário";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Monitoramento.Properties.Resources.Untitled_11;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Monitoramento.Properties.Resources.Untitled_11;
            this.pictureBox1.Location = new System.Drawing.Point(35, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 66);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Pnl2_Grade
            // 
            this.Pnl2_Grade.AutoSize = true;
            this.Pnl2_Grade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Pnl2_Grade.BackgroundImage = global::Monitoramento.Properties.Resources.dark;
            this.Pnl2_Grade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Pnl2_Grade.Location = new System.Drawing.Point(196, 30);
            this.Pnl2_Grade.Name = "Pnl2_Grade";
            this.Pnl2_Grade.Size = new System.Drawing.Size(837, 432);
            this.Pnl2_Grade.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Btn7_Parar);
            this.panel3.Controls.Add(this.Btn6_Iniciar);
            this.panel3.Location = new System.Drawing.Point(196, 468);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(837, 67);
            this.panel3.TabIndex = 3;
            // 
            // Btn7_Parar
            // 
            this.Btn7_Parar.Location = new System.Drawing.Point(430, 18);
            this.Btn7_Parar.Name = "Btn7_Parar";
            this.Btn7_Parar.Size = new System.Drawing.Size(114, 31);
            this.Btn7_Parar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn7_Parar.StateCommon.Border.Rounding = 10;
            this.Btn7_Parar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn7_Parar.TabIndex = 1;
            this.Btn7_Parar.Values.Text = "PARAR";
            this.Btn7_Parar.Click += new System.EventHandler(this.Btn5_Parar_Click);
            // 
            // Btn6_Iniciar
            // 
            this.Btn6_Iniciar.Location = new System.Drawing.Point(179, 18);
            this.Btn6_Iniciar.Name = "Btn6_Iniciar";
            this.Btn6_Iniciar.Size = new System.Drawing.Size(114, 31);
            this.Btn6_Iniciar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn6_Iniciar.StateCommon.Border.Rounding = 10;
            this.Btn6_Iniciar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn6_Iniciar.TabIndex = 0;
            this.Btn6_Iniciar.Values.Text = "INICIAR";
            this.Btn6_Iniciar.Click += new System.EventHandler(this.Btn4_Iniciar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(245, 549);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Progresso:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(374, 549);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(389, 28);
            this.progressBar1.TabIndex = 5;
            // 
            // Lbl_Porcentagem
            // 
            this.Lbl_Porcentagem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Porcentagem.ForeColor = System.Drawing.Color.White;
            this.Lbl_Porcentagem.Location = new System.Drawing.Point(769, 549);
            this.Lbl_Porcentagem.Name = "Lbl_Porcentagem";
            this.Lbl_Porcentagem.Size = new System.Drawing.Size(56, 28);
            this.Lbl_Porcentagem.TabIndex = 6;
            this.Lbl_Porcentagem.Text = "0%";
            this.Lbl_Porcentagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_TempoEstimado
            // 
            this.Lbl_TempoEstimado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_TempoEstimado.ForeColor = System.Drawing.Color.White;
            this.Lbl_TempoEstimado.Location = new System.Drawing.Point(812, 549);
            this.Lbl_TempoEstimado.Name = "Lbl_TempoEstimado";
            this.Lbl_TempoEstimado.Size = new System.Drawing.Size(155, 28);
            this.Lbl_TempoEstimado.TabIndex = 7;
            this.Lbl_TempoEstimado.Text = "Tempo Restante:";
            this.Lbl_TempoEstimado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_TempoEstimado2
            // 
            this.Lbl_TempoEstimado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_TempoEstimado2.ForeColor = System.Drawing.Color.White;
            this.Lbl_TempoEstimado2.Location = new System.Drawing.Point(956, 551);
            this.Lbl_TempoEstimado2.Name = "Lbl_TempoEstimado2";
            this.Lbl_TempoEstimado2.Size = new System.Drawing.Size(86, 27);
            this.Lbl_TempoEstimado2.TabIndex = 8;
            this.Lbl_TempoEstimado2.Text = "00:00:00";
            this.Lbl_TempoEstimado2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Controls.Add(this.Lbl_TempoEstimado);
            this.Controls.Add(this.Lbl_Porcentagem);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Pnl2_Grade);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroSetControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1_Principal";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Pnl2_Grade;
        private System.Windows.Forms.Panel panel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn7_Parar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn6_Iniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label Lbl_Porcentagem;
        private System.Windows.Forms.Label Lbl_TempoEstimado;
        private System.Windows.Forms.Label Lbl_TempoEstimado2;
        private System.Windows.Forms.Panel Pnl_Navegacao;
        private System.Windows.Forms.Button Btn4_Grafico;
        private System.Windows.Forms.Button Btn3_Historico;
        private System.Windows.Forms.Button Btn2_Analise;
        private System.Windows.Forms.Button Btn1_Dashboard;
        private System.Windows.Forms.Button Btn5_Config;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
    }
}
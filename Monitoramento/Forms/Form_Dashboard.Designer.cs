
namespace Monitoramento
{
    partial class Form_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pnl_Navegacao = new System.Windows.Forms.Panel();
            this.Btn3_Historico = new System.Windows.Forms.Button();
            this.Btn4_Configuracoes = new System.Windows.Forms.Button();
            this.Btn1_Dashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.dragControl1 = new Monitoramento.DragControl();
            this.TxtB_ID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Lbl_ID = new MetroSet_UI.Controls.MetroSetLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn5_Parar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Btn4_Iniciar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Lbl_FPacote = new MetroSet_UI.Controls.MetroSetLabel();
            this.Rdo_Nao = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.Rdo_Sim = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.TxtB_QPacote = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Lbl_QPacote = new MetroSet_UI.Controls.MetroSetLabel();
            this.TxtB_IP = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Lbl_IP = new MetroSet_UI.Controls.MetroSetLabel();
            this.TxtB_TPacote = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Lbl_TPacote = new MetroSet_UI.Controls.MetroSetLabel();
            this.TxtB_Nome = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Lbl_Nome = new MetroSet_UI.Controls.MetroSetLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.Pnl_Navegacao);
            this.panel1.Controls.Add(this.Btn3_Historico);
            this.panel1.Controls.Add(this.Btn4_Configuracoes);
            this.panel1.Controls.Add(this.Btn1_Dashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 574);
            this.panel1.TabIndex = 0;
            // 
            // Pnl_Navegacao
            // 
            this.Pnl_Navegacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Pnl_Navegacao.Location = new System.Drawing.Point(2, 134);
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
            this.Btn3_Historico.Location = new System.Drawing.Point(0, 166);
            this.Btn3_Historico.Margin = new System.Windows.Forms.Padding(2);
            this.Btn3_Historico.Name = "Btn3_Historico";
            this.Btn3_Historico.Size = new System.Drawing.Size(170, 52);
            this.Btn3_Historico.TabIndex = 11;
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
            this.Btn4_Configuracoes.Location = new System.Drawing.Point(0, 542);
            this.Btn4_Configuracoes.Margin = new System.Windows.Forms.Padding(2);
            this.Btn4_Configuracoes.Name = "Btn4_Configuracoes";
            this.Btn4_Configuracoes.Size = new System.Drawing.Size(170, 32);
            this.Btn4_Configuracoes.TabIndex = 12;
            this.Btn4_Configuracoes.Text = "Configurações";
            this.Btn4_Configuracoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn4_Configuracoes.UseVisualStyleBackColor = true;
            this.Btn4_Configuracoes.Click += new System.EventHandler(this.Btn4_Configuracoes_Click);
            this.Btn4_Configuracoes.Leave += new System.EventHandler(this.Btn4_Configuracoes_Leave);
            // 
            // Btn1_Dashboard
            // 
            this.Btn1_Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn1_Dashboard.FlatAppearance.BorderSize = 0;
            this.Btn1_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1_Dashboard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn1_Dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn1_Dashboard.Image = global::Monitoramento.Properties.Resources.diagram;
            this.Btn1_Dashboard.Location = new System.Drawing.Point(0, 118);
            this.Btn1_Dashboard.Margin = new System.Windows.Forms.Padding(2);
            this.Btn1_Dashboard.Name = "Btn1_Dashboard";
            this.Btn1_Dashboard.Size = new System.Drawing.Size(170, 48);
            this.Btn1_Dashboard.TabIndex = 1;
            this.Btn1_Dashboard.Text = "Análises";
            this.Btn1_Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn1_Dashboard.UseVisualStyleBackColor = true;
            this.Btn1_Dashboard.Click += new System.EventHandler(this.Btn1_Dashboard_Click);
            this.Btn1_Dashboard.Leave += new System.EventHandler(this.Btn1_Dashboard_Leave);
            // 
            // panel2
            // 
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
            this.label1.Location = new System.Drawing.Point(48, 91);
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
            this.metroSetControlBox1.Location = new System.Drawing.Point(905, 0);
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
            // TxtB_ID
            // 
            this.TxtB_ID.Location = new System.Drawing.Point(67, 47);
            this.TxtB_ID.MaxLength = 5;
            this.TxtB_ID.Name = "TxtB_ID";
            this.TxtB_ID.Size = new System.Drawing.Size(76, 29);
            this.TxtB_ID.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.TxtB_ID.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_ID.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_ID.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TxtB_ID.StateCommon.Border.Rounding = 10;
            this.TxtB_ID.StateCommon.Content.Color1 = System.Drawing.SystemColors.ScrollBar;
            this.TxtB_ID.TabIndex = 2;
            this.TxtB_ID.TextChanged += new System.EventHandler(this.TxtB_ID_TextChanged);
            this.TxtB_ID.Leave += new System.EventHandler(this.TxtB_ID_Leave);
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_ID.IsDerivedStyle = true;
            this.Lbl_ID.Location = new System.Drawing.Point(3, 30);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(47, 60);
            this.Lbl_ID.Style = MetroSet_UI.Enums.Style.Light;
            this.Lbl_ID.StyleManager = null;
            this.Lbl_ID.TabIndex = 3;
            this.Lbl_ID.Text = "ID:";
            this.Lbl_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_ID.ThemeAuthor = "Narwin";
            this.Lbl_ID.ThemeName = "MetroLite";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Controls.Add(this.Btn5_Parar);
            this.panel3.Controls.Add(this.Btn4_Iniciar);
            this.panel3.Controls.Add(this.Lbl_FPacote);
            this.panel3.Controls.Add(this.Rdo_Nao);
            this.panel3.Controls.Add(this.Rdo_Sim);
            this.panel3.Controls.Add(this.TxtB_QPacote);
            this.panel3.Controls.Add(this.Lbl_QPacote);
            this.panel3.Controls.Add(this.TxtB_IP);
            this.panel3.Controls.Add(this.Lbl_IP);
            this.panel3.Controls.Add(this.TxtB_TPacote);
            this.panel3.Controls.Add(this.Lbl_TPacote);
            this.panel3.Controls.Add(this.TxtB_Nome);
            this.panel3.Controls.Add(this.Lbl_Nome);
            this.panel3.Controls.Add(this.TxtB_ID);
            this.panel3.Controls.Add(this.Lbl_ID);
            this.panel3.Location = new System.Drawing.Point(197, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(755, 505);
            this.panel3.TabIndex = 4;
            // 
            // Btn5_Parar
            // 
            this.Btn5_Parar.Location = new System.Drawing.Point(418, 446);
            this.Btn5_Parar.Name = "Btn5_Parar";
            this.Btn5_Parar.Size = new System.Drawing.Size(97, 31);
            this.Btn5_Parar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn5_Parar.StateCommon.Border.Rounding = 10;
            this.Btn5_Parar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn5_Parar.TabIndex = 10;
            this.Btn5_Parar.Values.Text = "PARAR";
            // 
            // Btn4_Iniciar
            // 
            this.Btn4_Iniciar.Location = new System.Drawing.Point(189, 446);
            this.Btn4_Iniciar.Name = "Btn4_Iniciar";
            this.Btn4_Iniciar.Size = new System.Drawing.Size(97, 31);
            this.Btn4_Iniciar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn4_Iniciar.StateCommon.Border.Rounding = 10;
            this.Btn4_Iniciar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn4_Iniciar.TabIndex = 9;
            this.Btn4_Iniciar.Values.Text = "INICIAR";
            this.Btn4_Iniciar.Click += new System.EventHandler(this.Btn4_Iniciar_Click);
            // 
            // Lbl_FPacote
            // 
            this.Lbl_FPacote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_FPacote.IsDerivedStyle = true;
            this.Lbl_FPacote.Location = new System.Drawing.Point(3, 349);
            this.Lbl_FPacote.Name = "Lbl_FPacote";
            this.Lbl_FPacote.Size = new System.Drawing.Size(187, 60);
            this.Lbl_FPacote.Style = MetroSet_UI.Enums.Style.Light;
            this.Lbl_FPacote.StyleManager = null;
            this.Lbl_FPacote.TabIndex = 14;
            this.Lbl_FPacote.Text = "Fragmentar Pacote:";
            this.Lbl_FPacote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_FPacote.ThemeAuthor = "Narwin";
            this.Lbl_FPacote.ThemeName = "MetroLite";
            // 
            // Rdo_Nao
            // 
            this.Rdo_Nao.Location = new System.Drawing.Point(264, 369);
            this.Rdo_Nao.Name = "Rdo_Nao";
            this.Rdo_Nao.Size = new System.Drawing.Size(45, 20);
            this.Rdo_Nao.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.Rdo_Nao.TabIndex = 8;
            this.Rdo_Nao.Values.Text = "Não";
            // 
            // Rdo_Sim
            // 
            this.Rdo_Sim.Checked = true;
            this.Rdo_Sim.Location = new System.Drawing.Point(196, 369);
            this.Rdo_Sim.Name = "Rdo_Sim";
            this.Rdo_Sim.Size = new System.Drawing.Size(43, 20);
            this.Rdo_Sim.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.Rdo_Sim.TabIndex = 7;
            this.Rdo_Sim.Values.Text = "Sim";
            // 
            // TxtB_QPacote
            // 
            this.TxtB_QPacote.Location = new System.Drawing.Point(626, 275);
            this.TxtB_QPacote.MaxLength = 5;
            this.TxtB_QPacote.Name = "TxtB_QPacote";
            this.TxtB_QPacote.Size = new System.Drawing.Size(76, 29);
            this.TxtB_QPacote.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.TxtB_QPacote.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_QPacote.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_QPacote.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TxtB_QPacote.StateCommon.Border.Rounding = 10;
            this.TxtB_QPacote.StateCommon.Content.Color1 = System.Drawing.SystemColors.ScrollBar;
            this.TxtB_QPacote.TabIndex = 6;
            this.TxtB_QPacote.TextChanged += new System.EventHandler(this.TxtB_QPacote_TextChanged);
            this.TxtB_QPacote.Leave += new System.EventHandler(this.TxtB_QPacote_Leave);
            // 
            // Lbl_QPacote
            // 
            this.Lbl_QPacote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_QPacote.IsDerivedStyle = true;
            this.Lbl_QPacote.Location = new System.Drawing.Point(513, 260);
            this.Lbl_QPacote.Name = "Lbl_QPacote";
            this.Lbl_QPacote.Size = new System.Drawing.Size(107, 60);
            this.Lbl_QPacote.Style = MetroSet_UI.Enums.Style.Light;
            this.Lbl_QPacote.StyleManager = null;
            this.Lbl_QPacote.TabIndex = 11;
            this.Lbl_QPacote.Text = "N° Pacotes:";
            this.Lbl_QPacote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_QPacote.ThemeAuthor = "Narwin";
            this.Lbl_QPacote.ThemeName = "MetroLite";
            // 
            // TxtB_IP
            // 
            this.TxtB_IP.Location = new System.Drawing.Point(67, 157);
            this.TxtB_IP.MaxLength = 15;
            this.TxtB_IP.Name = "TxtB_IP";
            this.TxtB_IP.Size = new System.Drawing.Size(200, 29);
            this.TxtB_IP.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.TxtB_IP.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_IP.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_IP.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TxtB_IP.StateCommon.Border.Rounding = 10;
            this.TxtB_IP.StateCommon.Content.Color1 = System.Drawing.SystemColors.ScrollBar;
            this.TxtB_IP.TabIndex = 4;
            this.TxtB_IP.TextChanged += new System.EventHandler(this.TxtB_IP_TextChanged);
            this.TxtB_IP.Leave += new System.EventHandler(this.TxtB_IP_Leave);
            // 
            // Lbl_IP
            // 
            this.Lbl_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_IP.IsDerivedStyle = true;
            this.Lbl_IP.Location = new System.Drawing.Point(3, 145);
            this.Lbl_IP.Name = "Lbl_IP";
            this.Lbl_IP.Size = new System.Drawing.Size(47, 60);
            this.Lbl_IP.Style = MetroSet_UI.Enums.Style.Light;
            this.Lbl_IP.StyleManager = null;
            this.Lbl_IP.TabIndex = 9;
            this.Lbl_IP.Text = "IP:";
            this.Lbl_IP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_IP.ThemeAuthor = "Narwin";
            this.Lbl_IP.ThemeName = "MetroLite";
            // 
            // TxtB_TPacote
            // 
            this.TxtB_TPacote.Location = new System.Drawing.Point(196, 275);
            this.TxtB_TPacote.MaxLength = 4;
            this.TxtB_TPacote.Name = "TxtB_TPacote";
            this.TxtB_TPacote.Size = new System.Drawing.Size(61, 29);
            this.TxtB_TPacote.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.TxtB_TPacote.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_TPacote.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_TPacote.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TxtB_TPacote.StateCommon.Border.Rounding = 10;
            this.TxtB_TPacote.StateCommon.Content.Color1 = System.Drawing.SystemColors.ScrollBar;
            this.TxtB_TPacote.TabIndex = 5;
            this.TxtB_TPacote.Text = "32";
            this.TxtB_TPacote.TextChanged += new System.EventHandler(this.TxtB_TPacote_TextChanged);
            this.TxtB_TPacote.Leave += new System.EventHandler(this.TxtB_TPacote_Leave);
            // 
            // Lbl_TPacote
            // 
            this.Lbl_TPacote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_TPacote.IsDerivedStyle = true;
            this.Lbl_TPacote.Location = new System.Drawing.Point(3, 260);
            this.Lbl_TPacote.Name = "Lbl_TPacote";
            this.Lbl_TPacote.Size = new System.Drawing.Size(187, 60);
            this.Lbl_TPacote.Style = MetroSet_UI.Enums.Style.Light;
            this.Lbl_TPacote.StyleManager = null;
            this.Lbl_TPacote.TabIndex = 7;
            this.Lbl_TPacote.Text = "Tamanho do Pacote:";
            this.Lbl_TPacote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_TPacote.ThemeAuthor = "Narwin";
            this.Lbl_TPacote.ThemeName = "MetroLite";
            // 
            // TxtB_Nome
            // 
            this.TxtB_Nome.Location = new System.Drawing.Point(393, 47);
            this.TxtB_Nome.MaxLength = 30;
            this.TxtB_Nome.Name = "TxtB_Nome";
            this.TxtB_Nome.Size = new System.Drawing.Size(203, 29);
            this.TxtB_Nome.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.TxtB_Nome.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_Nome.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_Nome.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TxtB_Nome.StateCommon.Border.Rounding = 10;
            this.TxtB_Nome.StateCommon.Content.Color1 = System.Drawing.SystemColors.ScrollBar;
            this.TxtB_Nome.TabIndex = 3;
            this.TxtB_Nome.TextChanged += new System.EventHandler(this.TxtB_Nome_TextChanged);
            this.TxtB_Nome.Leave += new System.EventHandler(this.TxtB_Nome_Leave);
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Nome.IsDerivedStyle = true;
            this.Lbl_Nome.Location = new System.Drawing.Point(283, 30);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(60, 60);
            this.Lbl_Nome.Style = MetroSet_UI.Enums.Style.Light;
            this.Lbl_Nome.StyleManager = null;
            this.Lbl_Nome.TabIndex = 5;
            this.Lbl_Nome.Text = "Nome:";
            this.Lbl_Nome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_Nome.ThemeAuthor = "Narwin";
            this.Lbl_Nome.ThemeName = "MetroLite";
            // 
            // Form_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1006, 574);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn4_Configuracoes;
        private System.Windows.Forms.Panel Pnl_Navegacao;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private DragControl dragControl1;
        private System.Windows.Forms.Button Btn3_Historico;
        private System.Windows.Forms.Button Btn1_Dashboard;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_ID;
        private MetroSet_UI.Controls.MetroSetLabel Lbl_ID;
        private System.Windows.Forms.Panel panel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_TPacote;
        private MetroSet_UI.Controls.MetroSetLabel Lbl_TPacote;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_Nome;
        private MetroSet_UI.Controls.MetroSetLabel Lbl_Nome;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_IP;
        private MetroSet_UI.Controls.MetroSetLabel Lbl_IP;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_QPacote;
        private MetroSet_UI.Controls.MetroSetLabel Lbl_QPacote;
        private MetroSet_UI.Controls.MetroSetLabel Lbl_FPacote;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton Rdo_Nao;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton Rdo_Sim;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn5_Parar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn4_Iniciar;
    }
}


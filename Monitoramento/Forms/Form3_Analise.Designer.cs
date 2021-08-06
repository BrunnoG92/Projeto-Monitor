
namespace Monitoramento
{
    partial class Form3_Analise
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
            this.TxtB_Media = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Lbl_Media = new MetroSet_UI.Controls.MetroSetLabel();
            this.TxtB_Maior = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Lbl_Maior = new MetroSet_UI.Controls.MetroSetLabel();
            this.TxtB_PingRestante = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Lbl_Restante = new MetroSet_UI.Controls.MetroSetLabel();
            this.TxtB_Menor = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Lbl_Menor = new MetroSet_UI.Controls.MetroSetLabel();
            this.TxtB_PingPerdido = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Lbl_Perdido = new MetroSet_UI.Controls.MetroSetLabel();
            this.TxtB_PingSucesso = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Lbl_Sucesso = new MetroSet_UI.Controls.MetroSetLabel();
            this.TxtB_TotalPing = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Lbl_TPing = new MetroSet_UI.Controls.MetroSetLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TxtB_Atual = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Lbl_PingAtual = new MetroSet_UI.Controls.MetroSetLabel();
            this.TxtB_PerdaPorcento = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Lbl_PerdaPorcento = new MetroSet_UI.Controls.MetroSetLabel();
            this.SuspendLayout();
            // 
            // TxtB_Media
            // 
            this.TxtB_Media.Enabled = false;
            this.TxtB_Media.Location = new System.Drawing.Point(684, 295);
            this.TxtB_Media.MaxLength = 5;
            this.TxtB_Media.Name = "TxtB_Media";
            this.TxtB_Media.Size = new System.Drawing.Size(56, 29);
            this.TxtB_Media.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.TxtB_Media.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_Media.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_Media.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TxtB_Media.StateCommon.Border.Rounding = 10;
            this.TxtB_Media.StateCommon.Content.Color1 = System.Drawing.SystemColors.ScrollBar;
            this.TxtB_Media.TabIndex = 47;
            this.TxtB_Media.Text = "1";
            this.TxtB_Media.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_Media
            // 
            this.Lbl_Media.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Media.IsDerivedStyle = true;
            this.Lbl_Media.Location = new System.Drawing.Point(530, 277);
            this.Lbl_Media.Name = "Lbl_Media";
            this.Lbl_Media.Size = new System.Drawing.Size(174, 60);
            this.Lbl_Media.Style = MetroSet_UI.Enums.Style.Light;
            this.Lbl_Media.StyleManager = null;
            this.Lbl_Media.TabIndex = 46;
            this.Lbl_Media.Text = "Média de PING:";
            this.Lbl_Media.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_Media.ThemeAuthor = "Narwin";
            this.Lbl_Media.ThemeName = "MetroLite";
            // 
            // TxtB_Maior
            // 
            this.TxtB_Maior.Enabled = false;
            this.TxtB_Maior.Location = new System.Drawing.Point(708, 232);
            this.TxtB_Maior.MaxLength = 5;
            this.TxtB_Maior.Name = "TxtB_Maior";
            this.TxtB_Maior.Size = new System.Drawing.Size(56, 29);
            this.TxtB_Maior.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.TxtB_Maior.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_Maior.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_Maior.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TxtB_Maior.StateCommon.Border.Rounding = 10;
            this.TxtB_Maior.StateCommon.Content.Color1 = System.Drawing.SystemColors.ScrollBar;
            this.TxtB_Maior.TabIndex = 45;
            this.TxtB_Maior.Text = "1";
            this.TxtB_Maior.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_Maior
            // 
            this.Lbl_Maior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Maior.IsDerivedStyle = true;
            this.Lbl_Maior.Location = new System.Drawing.Point(544, 217);
            this.Lbl_Maior.Name = "Lbl_Maior";
            this.Lbl_Maior.Size = new System.Drawing.Size(174, 60);
            this.Lbl_Maior.Style = MetroSet_UI.Enums.Style.Light;
            this.Lbl_Maior.StyleManager = null;
            this.Lbl_Maior.TabIndex = 44;
            this.Lbl_Maior.Text = "Maior PING:";
            this.Lbl_Maior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_Maior.ThemeAuthor = "Narwin";
            this.Lbl_Maior.ThemeName = "MetroLite";
            // 
            // TxtB_PingRestante
            // 
            this.TxtB_PingRestante.Enabled = false;
            this.TxtB_PingRestante.Location = new System.Drawing.Point(684, 70);
            this.TxtB_PingRestante.MaxLength = 5;
            this.TxtB_PingRestante.Name = "TxtB_PingRestante";
            this.TxtB_PingRestante.Size = new System.Drawing.Size(56, 29);
            this.TxtB_PingRestante.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.TxtB_PingRestante.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_PingRestante.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_PingRestante.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TxtB_PingRestante.StateCommon.Border.Rounding = 10;
            this.TxtB_PingRestante.StateCommon.Content.Color1 = System.Drawing.SystemColors.ScrollBar;
            this.TxtB_PingRestante.TabIndex = 42;
            this.TxtB_PingRestante.Text = "1";
            this.TxtB_PingRestante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_Restante
            // 
            this.Lbl_Restante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Restante.IsDerivedStyle = true;
            this.Lbl_Restante.Location = new System.Drawing.Point(484, 62);
            this.Lbl_Restante.Name = "Lbl_Restante";
            this.Lbl_Restante.Size = new System.Drawing.Size(224, 40);
            this.Lbl_Restante.Style = MetroSet_UI.Enums.Style.Light;
            this.Lbl_Restante.StyleManager = null;
            this.Lbl_Restante.TabIndex = 43;
            this.Lbl_Restante.Text = "Restantes:";
            this.Lbl_Restante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_Restante.ThemeAuthor = "Narwin";
            this.Lbl_Restante.ThemeName = "MetroLite";
            // 
            // TxtB_Menor
            // 
            this.TxtB_Menor.Enabled = false;
            this.TxtB_Menor.Location = new System.Drawing.Point(719, 170);
            this.TxtB_Menor.MaxLength = 5;
            this.TxtB_Menor.Name = "TxtB_Menor";
            this.TxtB_Menor.Size = new System.Drawing.Size(56, 29);
            this.TxtB_Menor.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.TxtB_Menor.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_Menor.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_Menor.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TxtB_Menor.StateCommon.Border.Rounding = 10;
            this.TxtB_Menor.StateCommon.Content.Color1 = System.Drawing.SystemColors.ScrollBar;
            this.TxtB_Menor.TabIndex = 41;
            this.TxtB_Menor.Text = "1";
            this.TxtB_Menor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_Menor
            // 
            this.Lbl_Menor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Menor.IsDerivedStyle = true;
            this.Lbl_Menor.Location = new System.Drawing.Point(560, 157);
            this.Lbl_Menor.Name = "Lbl_Menor";
            this.Lbl_Menor.Size = new System.Drawing.Size(174, 60);
            this.Lbl_Menor.Style = MetroSet_UI.Enums.Style.Light;
            this.Lbl_Menor.StyleManager = null;
            this.Lbl_Menor.TabIndex = 40;
            this.Lbl_Menor.Text = "Menor PING:";
            this.Lbl_Menor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_Menor.ThemeAuthor = "Narwin";
            this.Lbl_Menor.ThemeName = "MetroLite";
            // 
            // TxtB_PingPerdido
            // 
            this.TxtB_PingPerdido.Enabled = false;
            this.TxtB_PingPerdido.Location = new System.Drawing.Point(188, 204);
            this.TxtB_PingPerdido.MaxLength = 5;
            this.TxtB_PingPerdido.Name = "TxtB_PingPerdido";
            this.TxtB_PingPerdido.Size = new System.Drawing.Size(62, 29);
            this.TxtB_PingPerdido.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.TxtB_PingPerdido.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_PingPerdido.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_PingPerdido.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TxtB_PingPerdido.StateCommon.Border.Rounding = 10;
            this.TxtB_PingPerdido.StateCommon.Content.Color1 = System.Drawing.SystemColors.ScrollBar;
            this.TxtB_PingPerdido.TabIndex = 39;
            this.TxtB_PingPerdido.Text = "1";
            this.TxtB_PingPerdido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_Perdido
            // 
            this.Lbl_Perdido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Perdido.IsDerivedStyle = true;
            this.Lbl_Perdido.Location = new System.Drawing.Point(-4, 189);
            this.Lbl_Perdido.Name = "Lbl_Perdido";
            this.Lbl_Perdido.Size = new System.Drawing.Size(197, 60);
            this.Lbl_Perdido.Style = MetroSet_UI.Enums.Style.Light;
            this.Lbl_Perdido.StyleManager = null;
            this.Lbl_Perdido.TabIndex = 38;
            this.Lbl_Perdido.Text = "Pacotes Perdidos:";
            this.Lbl_Perdido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_Perdido.ThemeAuthor = "Narwin";
            this.Lbl_Perdido.ThemeName = "MetroLite";
            // 
            // TxtB_PingSucesso
            // 
            this.TxtB_PingSucesso.Enabled = false;
            this.TxtB_PingSucesso.Location = new System.Drawing.Point(188, 145);
            this.TxtB_PingSucesso.MaxLength = 5;
            this.TxtB_PingSucesso.Name = "TxtB_PingSucesso";
            this.TxtB_PingSucesso.Size = new System.Drawing.Size(62, 29);
            this.TxtB_PingSucesso.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.TxtB_PingSucesso.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_PingSucesso.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_PingSucesso.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TxtB_PingSucesso.StateCommon.Border.Rounding = 10;
            this.TxtB_PingSucesso.StateCommon.Content.Color1 = System.Drawing.SystemColors.ScrollBar;
            this.TxtB_PingSucesso.TabIndex = 37;
            this.TxtB_PingSucesso.Text = "1";
            this.TxtB_PingSucesso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_Sucesso
            // 
            this.Lbl_Sucesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Sucesso.IsDerivedStyle = true;
            this.Lbl_Sucesso.Location = new System.Drawing.Point(-4, 129);
            this.Lbl_Sucesso.Name = "Lbl_Sucesso";
            this.Lbl_Sucesso.Size = new System.Drawing.Size(197, 60);
            this.Lbl_Sucesso.Style = MetroSet_UI.Enums.Style.Light;
            this.Lbl_Sucesso.StyleManager = null;
            this.Lbl_Sucesso.TabIndex = 36;
            this.Lbl_Sucesso.Text = "Ping com Sucesso:";
            this.Lbl_Sucesso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_Sucesso.ThemeAuthor = "Narwin";
            this.Lbl_Sucesso.ThemeName = "MetroLite";
            // 
            // TxtB_TotalPing
            // 
            this.TxtB_TotalPing.Enabled = false;
            this.TxtB_TotalPing.Location = new System.Drawing.Point(179, 73);
            this.TxtB_TotalPing.MaxLength = 5;
            this.TxtB_TotalPing.Name = "TxtB_TotalPing";
            this.TxtB_TotalPing.Size = new System.Drawing.Size(62, 29);
            this.TxtB_TotalPing.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.TxtB_TotalPing.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_TotalPing.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_TotalPing.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TxtB_TotalPing.StateCommon.Border.Rounding = 10;
            this.TxtB_TotalPing.StateCommon.Content.Color1 = System.Drawing.SystemColors.ScrollBar;
            this.TxtB_TotalPing.TabIndex = 34;
            this.TxtB_TotalPing.Text = "1";
            this.TxtB_TotalPing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_TPing
            // 
            this.Lbl_TPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_TPing.IsDerivedStyle = true;
            this.Lbl_TPing.Location = new System.Drawing.Point(12, 70);
            this.Lbl_TPing.Name = "Lbl_TPing";
            this.Lbl_TPing.Size = new System.Drawing.Size(146, 40);
            this.Lbl_TPing.Style = MetroSet_UI.Enums.Style.Light;
            this.Lbl_TPing.StyleManager = null;
            this.Lbl_TPing.TabIndex = 35;
            this.Lbl_TPing.Text = "Total de Pings";
            this.Lbl_TPing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_TPing.ThemeAuthor = "Narwin";
            this.Lbl_TPing.ThemeName = "MetroLite";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // TxtB_Atual
            // 
            this.TxtB_Atual.Enabled = false;
            this.TxtB_Atual.Location = new System.Drawing.Point(699, 115);
            this.TxtB_Atual.MaxLength = 5;
            this.TxtB_Atual.Name = "TxtB_Atual";
            this.TxtB_Atual.Size = new System.Drawing.Size(56, 29);
            this.TxtB_Atual.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.TxtB_Atual.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_Atual.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_Atual.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TxtB_Atual.StateCommon.Border.Rounding = 10;
            this.TxtB_Atual.StateCommon.Content.Color1 = System.Drawing.SystemColors.ScrollBar;
            this.TxtB_Atual.TabIndex = 49;
            this.TxtB_Atual.Text = "1";
            this.TxtB_Atual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_PingAtual
            // 
            this.Lbl_PingAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_PingAtual.IsDerivedStyle = true;
            this.Lbl_PingAtual.Location = new System.Drawing.Point(560, 102);
            this.Lbl_PingAtual.Name = "Lbl_PingAtual";
            this.Lbl_PingAtual.Size = new System.Drawing.Size(117, 60);
            this.Lbl_PingAtual.Style = MetroSet_UI.Enums.Style.Light;
            this.Lbl_PingAtual.StyleManager = null;
            this.Lbl_PingAtual.TabIndex = 48;
            this.Lbl_PingAtual.Text = "Ping Atual";
            this.Lbl_PingAtual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_PingAtual.ThemeAuthor = "Narwin";
            this.Lbl_PingAtual.ThemeName = "MetroLite";
            // 
            // TxtB_PerdaPorcento
            // 
            this.TxtB_PerdaPorcento.Enabled = false;
            this.TxtB_PerdaPorcento.Location = new System.Drawing.Point(405, 357);
            this.TxtB_PerdaPorcento.MaxLength = 5;
            this.TxtB_PerdaPorcento.Name = "TxtB_PerdaPorcento";
            this.TxtB_PerdaPorcento.Size = new System.Drawing.Size(62, 29);
            this.TxtB_PerdaPorcento.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.TxtB_PerdaPorcento.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_PerdaPorcento.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_PerdaPorcento.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TxtB_PerdaPorcento.StateCommon.Border.Rounding = 10;
            this.TxtB_PerdaPorcento.StateCommon.Content.Color1 = System.Drawing.SystemColors.ScrollBar;
            this.TxtB_PerdaPorcento.TabIndex = 51;
            this.TxtB_PerdaPorcento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_PerdaPorcento
            // 
            this.Lbl_PerdaPorcento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_PerdaPorcento.IsDerivedStyle = true;
            this.Lbl_PerdaPorcento.Location = new System.Drawing.Point(320, 357);
            this.Lbl_PerdaPorcento.Name = "Lbl_PerdaPorcento";
            this.Lbl_PerdaPorcento.Size = new System.Drawing.Size(79, 33);
            this.Lbl_PerdaPorcento.Style = MetroSet_UI.Enums.Style.Light;
            this.Lbl_PerdaPorcento.StyleManager = null;
            this.Lbl_PerdaPorcento.TabIndex = 50;
            this.Lbl_PerdaPorcento.Text = " Perda:";
            this.Lbl_PerdaPorcento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_PerdaPorcento.ThemeAuthor = "Narwin";
            this.Lbl_PerdaPorcento.ThemeName = "MetroLite";
            // 
            // Form3_Analise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Monitoramento.Properties.Resources.dark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(837, 432);
            this.Controls.Add(this.TxtB_PerdaPorcento);
            this.Controls.Add(this.Lbl_PerdaPorcento);
            this.Controls.Add(this.TxtB_Atual);
            this.Controls.Add(this.Lbl_PingAtual);
            this.Controls.Add(this.TxtB_Media);
            this.Controls.Add(this.Lbl_Media);
            this.Controls.Add(this.TxtB_Maior);
            this.Controls.Add(this.Lbl_Maior);
            this.Controls.Add(this.TxtB_PingRestante);
            this.Controls.Add(this.Lbl_Restante);
            this.Controls.Add(this.TxtB_Menor);
            this.Controls.Add(this.Lbl_Menor);
            this.Controls.Add(this.TxtB_PingPerdido);
            this.Controls.Add(this.Lbl_Perdido);
            this.Controls.Add(this.TxtB_PingSucesso);
            this.Controls.Add(this.Lbl_Sucesso);
            this.Controls.Add(this.TxtB_TotalPing);
            this.Controls.Add(this.Lbl_TPing);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3_Analise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_Media;
        private MetroSet_UI.Controls.MetroSetLabel Lbl_Media;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_Maior;
        private MetroSet_UI.Controls.MetroSetLabel Lbl_Maior;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_PingRestante;
        private MetroSet_UI.Controls.MetroSetLabel Lbl_Restante;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_Menor;
        private MetroSet_UI.Controls.MetroSetLabel Lbl_Menor;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_PingPerdido;
        private MetroSet_UI.Controls.MetroSetLabel Lbl_Perdido;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_PingSucesso;
        private MetroSet_UI.Controls.MetroSetLabel Lbl_Sucesso;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_TotalPing;
        private MetroSet_UI.Controls.MetroSetLabel Lbl_TPing;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_Atual;
        private MetroSet_UI.Controls.MetroSetLabel Lbl_PingAtual;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_PerdaPorcento;
        private MetroSet_UI.Controls.MetroSetLabel Lbl_PerdaPorcento;
    }
}



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
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.TxtB_Maior = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.TxtB_PingRestante = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.TxtB_Menor = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.TxtB_PingPerdido = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.TxtB_PingSucesso = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Lbl_Nome = new MetroSet_UI.Controls.MetroSetLabel();
            this.TxtB_TotalPing = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Lbl_TPing = new MetroSet_UI.Controls.MetroSetLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtB_Media
            // 
            this.TxtB_Media.Location = new System.Drawing.Point(710, 294);
            this.TxtB_Media.MaxLength = 5;
            this.TxtB_Media.Name = "TxtB_Media";
            this.TxtB_Media.Size = new System.Drawing.Size(76, 29);
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
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel5.IsDerivedStyle = true;
            this.metroSetLabel5.Location = new System.Drawing.Point(544, 277);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(174, 60);
            this.metroSetLabel5.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel5.StyleManager = null;
            this.metroSetLabel5.TabIndex = 46;
            this.metroSetLabel5.Text = "Média de PING:";
            this.metroSetLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroSetLabel5.ThemeAuthor = "Narwin";
            this.metroSetLabel5.ThemeName = "MetroLite";
            // 
            // TxtB_Maior
            // 
            this.TxtB_Maior.Location = new System.Drawing.Point(710, 234);
            this.TxtB_Maior.MaxLength = 5;
            this.TxtB_Maior.Name = "TxtB_Maior";
            this.TxtB_Maior.Size = new System.Drawing.Size(76, 29);
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
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(544, 217);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(174, 60);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 44;
            this.metroSetLabel2.Text = "Maior PING:";
            this.metroSetLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // TxtB_PingRestante
            // 
            this.TxtB_PingRestante.Location = new System.Drawing.Point(666, 70);
            this.TxtB_PingRestante.MaxLength = 5;
            this.TxtB_PingRestante.Name = "TxtB_PingRestante";
            this.TxtB_PingRestante.Size = new System.Drawing.Size(64, 29);
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
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel4.IsDerivedStyle = true;
            this.metroSetLabel4.Location = new System.Drawing.Point(484, 62);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(224, 40);
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 43;
            this.metroSetLabel4.Text = "Restantes:";
            this.metroSetLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroLite";
            // 
            // TxtB_Menor
            // 
            this.TxtB_Menor.Location = new System.Drawing.Point(710, 174);
            this.TxtB_Menor.MaxLength = 5;
            this.TxtB_Menor.Name = "TxtB_Menor";
            this.TxtB_Menor.Size = new System.Drawing.Size(76, 29);
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
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(544, 157);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(174, 60);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 40;
            this.metroSetLabel3.Text = "Menor PING:";
            this.metroSetLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // TxtB_PingPerdido
            // 
            this.TxtB_PingPerdido.Location = new System.Drawing.Point(170, 233);
            this.TxtB_PingPerdido.MaxLength = 5;
            this.TxtB_PingPerdido.Name = "TxtB_PingPerdido";
            this.TxtB_PingPerdido.Size = new System.Drawing.Size(76, 29);
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
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(-19, 217);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(197, 60);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 38;
            this.metroSetLabel1.Text = "Pacotes Perdidos:";
            this.metroSetLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // TxtB_PingSucesso
            // 
            this.TxtB_PingSucesso.Location = new System.Drawing.Point(170, 174);
            this.TxtB_PingSucesso.MaxLength = 5;
            this.TxtB_PingSucesso.Name = "TxtB_PingSucesso";
            this.TxtB_PingSucesso.Size = new System.Drawing.Size(76, 29);
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
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Nome.IsDerivedStyle = true;
            this.Lbl_Nome.Location = new System.Drawing.Point(-19, 157);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(197, 60);
            this.Lbl_Nome.Style = MetroSet_UI.Enums.Style.Light;
            this.Lbl_Nome.StyleManager = null;
            this.Lbl_Nome.TabIndex = 36;
            this.Lbl_Nome.Text = "Ping com Sucesso:";
            this.Lbl_Nome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_Nome.ThemeAuthor = "Narwin";
            this.Lbl_Nome.ThemeName = "MetroLite";
            // 
            // TxtB_TotalPing
            // 
            this.TxtB_TotalPing.Location = new System.Drawing.Point(230, 62);
            this.TxtB_TotalPing.MaxLength = 5;
            this.TxtB_TotalPing.Name = "TxtB_TotalPing";
            this.TxtB_TotalPing.Size = new System.Drawing.Size(76, 29);
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
            // 
            // Lbl_TPing
            // 
            this.Lbl_TPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_TPing.IsDerivedStyle = true;
            this.Lbl_TPing.Location = new System.Drawing.Point(-1, 59);
            this.Lbl_TPing.Name = "Lbl_TPing";
            this.Lbl_TPing.Size = new System.Drawing.Size(236, 40);
            this.Lbl_TPing.Style = MetroSet_UI.Enums.Style.Light;
            this.Lbl_TPing.StyleManager = null;
            this.Lbl_TPing.TabIndex = 35;
            this.Lbl_TPing.Text = "Total de Pings a Execultar";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3_Analise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Monitoramento.Properties.Resources.dark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(837, 432);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtB_Media);
            this.Controls.Add(this.metroSetLabel5);
            this.Controls.Add(this.TxtB_Maior);
            this.Controls.Add(this.metroSetLabel2);
            this.Controls.Add(this.TxtB_PingRestante);
            this.Controls.Add(this.metroSetLabel4);
            this.Controls.Add(this.TxtB_Menor);
            this.Controls.Add(this.metroSetLabel3);
            this.Controls.Add(this.TxtB_PingPerdido);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.TxtB_PingSucesso);
            this.Controls.Add(this.Lbl_Nome);
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
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_Maior;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_PingRestante;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_Menor;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_PingPerdido;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_PingSucesso;
        private MetroSet_UI.Controls.MetroSetLabel Lbl_Nome;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_TotalPing;
        private MetroSet_UI.Controls.MetroSetLabel Lbl_TPing;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
    }
}


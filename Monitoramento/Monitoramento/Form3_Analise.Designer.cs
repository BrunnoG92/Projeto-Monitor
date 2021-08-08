
namespace Monitoramento
{
    partial class Form3_Analise
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
            this.TxtB_PerdaPorcento = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TxtB_Atual = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TxtB_Media = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TxtB_Maior = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TxtB_PingRestante = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TxtB_Menor = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TxtB_PingPerdido = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TxtB_PingSucesso = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TxtB_TotalPing = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Lbl_TPing = new System.Windows.Forms.Label();
            this.Lbl_Sucesso = new System.Windows.Forms.Label();
            this.Lbl_Perdido = new System.Windows.Forms.Label();
            this.Lbl_Restante = new System.Windows.Forms.Label();
            this.Lbl_PingAtual = new System.Windows.Forms.Label();
            this.Lbl_Menor = new System.Windows.Forms.Label();
            this.Lbl_Maior = new System.Windows.Forms.Label();
            this.Lbl_Media = new System.Windows.Forms.Label();
            this.Lbl_PerdaPorcento = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // TxtB_PerdaPorcento
            // 
            this.TxtB_PerdaPorcento.Enabled = false;
            this.TxtB_PerdaPorcento.Location = new System.Drawing.Point(391, 362);
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
            this.TxtB_PerdaPorcento.TabIndex = 60;
            this.TxtB_PerdaPorcento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtB_Atual
            // 
            this.TxtB_Atual.Enabled = false;
            this.TxtB_Atual.Location = new System.Drawing.Point(669, 138);
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
            this.TxtB_Atual.TabIndex = 59;
            this.TxtB_Atual.Text = "1";
            this.TxtB_Atual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtB_Media
            // 
            this.TxtB_Media.Enabled = false;
            this.TxtB_Media.Location = new System.Drawing.Point(660, 313);
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
            this.TxtB_Media.TabIndex = 58;
            this.TxtB_Media.Text = "1";
            this.TxtB_Media.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtB_Maior
            // 
            this.TxtB_Maior.Enabled = false;
            this.TxtB_Maior.Location = new System.Drawing.Point(672, 253);
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
            this.TxtB_Maior.TabIndex = 57;
            this.TxtB_Maior.Text = "1";
            this.TxtB_Maior.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtB_PingRestante
            // 
            this.TxtB_PingRestante.Enabled = false;
            this.TxtB_PingRestante.Location = new System.Drawing.Point(660, 83);
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
            this.TxtB_PingRestante.TabIndex = 56;
            this.TxtB_PingRestante.Text = "1";
            this.TxtB_PingRestante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtB_Menor
            // 
            this.TxtB_Menor.Enabled = false;
            this.TxtB_Menor.Location = new System.Drawing.Point(686, 195);
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
            this.TxtB_Menor.TabIndex = 55;
            this.TxtB_Menor.Text = "1";
            this.TxtB_Menor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtB_PingPerdido
            // 
            this.TxtB_PingPerdido.Enabled = false;
            this.TxtB_PingPerdido.Location = new System.Drawing.Point(194, 224);
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
            this.TxtB_PingPerdido.TabIndex = 54;
            this.TxtB_PingPerdido.Text = "1";
            this.TxtB_PingPerdido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtB_PingSucesso
            // 
            this.TxtB_PingSucesso.Enabled = false;
            this.TxtB_PingSucesso.Location = new System.Drawing.Point(194, 138);
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
            this.TxtB_PingSucesso.TabIndex = 53;
            this.TxtB_PingSucesso.Text = "1";
            this.TxtB_PingSucesso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtB_TotalPing
            // 
            this.TxtB_TotalPing.Enabled = false;
            this.TxtB_TotalPing.Location = new System.Drawing.Point(172, 70);
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
            this.TxtB_TotalPing.TabIndex = 52;
            this.TxtB_TotalPing.Text = "1";
            this.TxtB_TotalPing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_TPing
            // 
            this.Lbl_TPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_TPing.ForeColor = System.Drawing.Color.White;
            this.Lbl_TPing.Location = new System.Drawing.Point(12, 51);
            this.Lbl_TPing.Name = "Lbl_TPing";
            this.Lbl_TPing.Size = new System.Drawing.Size(128, 61);
            this.Lbl_TPing.TabIndex = 61;
            this.Lbl_TPing.Text = "Toal de Pings:";
            this.Lbl_TPing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Sucesso
            // 
            this.Lbl_Sucesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Sucesso.ForeColor = System.Drawing.Color.White;
            this.Lbl_Sucesso.Location = new System.Drawing.Point(12, 124);
            this.Lbl_Sucesso.Name = "Lbl_Sucesso";
            this.Lbl_Sucesso.Size = new System.Drawing.Size(176, 61);
            this.Lbl_Sucesso.TabIndex = 62;
            this.Lbl_Sucesso.Text = "Pings com Sucesso:";
            this.Lbl_Sucesso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Perdido
            // 
            this.Lbl_Perdido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Perdido.ForeColor = System.Drawing.Color.White;
            this.Lbl_Perdido.Location = new System.Drawing.Point(12, 208);
            this.Lbl_Perdido.Name = "Lbl_Perdido";
            this.Lbl_Perdido.Size = new System.Drawing.Size(166, 61);
            this.Lbl_Perdido.TabIndex = 63;
            this.Lbl_Perdido.Text = "Pacotes Perdidos:";
            this.Lbl_Perdido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Restante
            // 
            this.Lbl_Restante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Restante.ForeColor = System.Drawing.Color.White;
            this.Lbl_Restante.Location = new System.Drawing.Point(536, 70);
            this.Lbl_Restante.Name = "Lbl_Restante";
            this.Lbl_Restante.Size = new System.Drawing.Size(118, 61);
            this.Lbl_Restante.TabIndex = 64;
            this.Lbl_Restante.Text = "Restantes:";
            this.Lbl_Restante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_PingAtual
            // 
            this.Lbl_PingAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_PingAtual.ForeColor = System.Drawing.Color.White;
            this.Lbl_PingAtual.Location = new System.Drawing.Point(560, 124);
            this.Lbl_PingAtual.Name = "Lbl_PingAtual";
            this.Lbl_PingAtual.Size = new System.Drawing.Size(103, 61);
            this.Lbl_PingAtual.TabIndex = 65;
            this.Lbl_PingAtual.Text = "Ping Atual:";
            this.Lbl_PingAtual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Menor
            // 
            this.Lbl_Menor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Menor.ForeColor = System.Drawing.Color.White;
            this.Lbl_Menor.Location = new System.Drawing.Point(560, 175);
            this.Lbl_Menor.Name = "Lbl_Menor";
            this.Lbl_Menor.Size = new System.Drawing.Size(120, 61);
            this.Lbl_Menor.TabIndex = 66;
            this.Lbl_Menor.Text = "Menor Ping:";
            this.Lbl_Menor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Maior
            // 
            this.Lbl_Maior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Maior.ForeColor = System.Drawing.Color.White;
            this.Lbl_Maior.Location = new System.Drawing.Point(551, 236);
            this.Lbl_Maior.Name = "Lbl_Maior";
            this.Lbl_Maior.Size = new System.Drawing.Size(103, 61);
            this.Lbl_Maior.TabIndex = 67;
            this.Lbl_Maior.Text = "Maior Ping:";
            this.Lbl_Maior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Media
            // 
            this.Lbl_Media.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Media.ForeColor = System.Drawing.Color.White;
            this.Lbl_Media.Location = new System.Drawing.Point(531, 297);
            this.Lbl_Media.Name = "Lbl_Media";
            this.Lbl_Media.Size = new System.Drawing.Size(123, 61);
            this.Lbl_Media.TabIndex = 68;
            this.Lbl_Media.Text = "Média de Ping:";
            this.Lbl_Media.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_PerdaPorcento
            // 
            this.Lbl_PerdaPorcento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_PerdaPorcento.ForeColor = System.Drawing.Color.White;
            this.Lbl_PerdaPorcento.Location = new System.Drawing.Point(308, 347);
            this.Lbl_PerdaPorcento.Name = "Lbl_PerdaPorcento";
            this.Lbl_PerdaPorcento.Size = new System.Drawing.Size(77, 61);
            this.Lbl_PerdaPorcento.TabIndex = 69;
            this.Lbl_PerdaPorcento.Text = "Perda:";
            this.Lbl_PerdaPorcento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // Form3_Analise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Monitoramento.Properties.Resources.dark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(837, 432);
            this.Controls.Add(this.Lbl_PerdaPorcento);
            this.Controls.Add(this.Lbl_Media);
            this.Controls.Add(this.Lbl_Maior);
            this.Controls.Add(this.Lbl_Menor);
            this.Controls.Add(this.Lbl_PingAtual);
            this.Controls.Add(this.Lbl_Restante);
            this.Controls.Add(this.Lbl_Perdido);
            this.Controls.Add(this.Lbl_Sucesso);
            this.Controls.Add(this.Lbl_TPing);
            this.Controls.Add(this.TxtB_PerdaPorcento);
            this.Controls.Add(this.TxtB_Atual);
            this.Controls.Add(this.TxtB_Media);
            this.Controls.Add(this.TxtB_Maior);
            this.Controls.Add(this.TxtB_PingRestante);
            this.Controls.Add(this.TxtB_Menor);
            this.Controls.Add(this.TxtB_PingPerdido);
            this.Controls.Add(this.TxtB_PingSucesso);
            this.Controls.Add(this.TxtB_TotalPing);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3_Analise";
            this.Text = "Form3_Analise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_PerdaPorcento;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_Atual;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_Media;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_Maior;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_PingRestante;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_Menor;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_PingPerdido;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_PingSucesso;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_TotalPing;
        private System.Windows.Forms.Label Lbl_TPing;
        private System.Windows.Forms.Label Lbl_Sucesso;
        private System.Windows.Forms.Label Lbl_Perdido;
        private System.Windows.Forms.Label Lbl_Restante;
        private System.Windows.Forms.Label Lbl_PingAtual;
        private System.Windows.Forms.Label Lbl_Menor;
        private System.Windows.Forms.Label Lbl_Maior;
        private System.Windows.Forms.Label Lbl_Media;
        private System.Windows.Forms.Label Lbl_PerdaPorcento;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
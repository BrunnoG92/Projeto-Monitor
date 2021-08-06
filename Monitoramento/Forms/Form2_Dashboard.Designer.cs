
namespace Monitoramento
{
    partial class Form2_Dashboard
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
            this.Lbl_ID = new MetroSet_UI.Controls.MetroSetLabel();
            this.TxtB_ID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Lbl_IP = new MetroSet_UI.Controls.MetroSetLabel();
            this.TxtB_IP = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TxtB_Nome = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Lbl_Nome = new MetroSet_UI.Controls.MetroSetLabel();
            this.Lbl_TPacote = new MetroSet_UI.Controls.MetroSetLabel();
            this.TxtB_QPacote = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Lbl_QPacote = new MetroSet_UI.Controls.MetroSetLabel();
            this.TxtB_TPacote = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Lbl_FPacote = new MetroSet_UI.Controls.MetroSetLabel();
            this.Rdo_Sim = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.Rdo_Nao = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.SuspendLayout();
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_ID.IsDerivedStyle = true;
            this.Lbl_ID.Location = new System.Drawing.Point(23, 9);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(47, 60);
            this.Lbl_ID.Style = MetroSet_UI.Enums.Style.Light;
            this.Lbl_ID.StyleManager = null;
            this.Lbl_ID.TabIndex = 31;
            this.Lbl_ID.Text = "ID:";
            this.Lbl_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_ID.ThemeAuthor = "Narwin";
            this.Lbl_ID.ThemeName = "MetroLite";
            // 
            // TxtB_ID
            // 
            this.TxtB_ID.Location = new System.Drawing.Point(108, 25);
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
            this.TxtB_ID.TabIndex = 29;
            this.TxtB_ID.Text = "1";
            this.TxtB_ID.TextChanged += new System.EventHandler(this.TxtB_ID_TextChanged);
            this.TxtB_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtB_ID_KeyPress);
            this.TxtB_ID.Leave += new System.EventHandler(this.TxtB_ID_Leave);
            // 
            // Lbl_IP
            // 
            this.Lbl_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_IP.IsDerivedStyle = true;
            this.Lbl_IP.Location = new System.Drawing.Point(23, 139);
            this.Lbl_IP.Name = "Lbl_IP";
            this.Lbl_IP.Size = new System.Drawing.Size(67, 28);
            this.Lbl_IP.Style = MetroSet_UI.Enums.Style.Light;
            this.Lbl_IP.StyleManager = null;
            this.Lbl_IP.TabIndex = 39;
            this.Lbl_IP.Text = "Host:";
            this.Lbl_IP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_IP.ThemeAuthor = "Narwin";
            this.Lbl_IP.ThemeName = "MetroLite";
            // 
            // TxtB_IP
            // 
            this.TxtB_IP.Location = new System.Drawing.Point(89, 138);
            this.TxtB_IP.MaxLength = 30;
            this.TxtB_IP.Name = "TxtB_IP";
            this.TxtB_IP.Size = new System.Drawing.Size(169, 29);
            this.TxtB_IP.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.TxtB_IP.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_IP.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_IP.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TxtB_IP.StateCommon.Border.Rounding = 10;
            this.TxtB_IP.StateCommon.Content.Color1 = System.Drawing.SystemColors.ScrollBar;
            this.TxtB_IP.TabIndex = 32;
            this.TxtB_IP.Text = "8.8.8.8";
            this.TxtB_IP.TextChanged += new System.EventHandler(this.TxtB_IP_TextChanged);
            this.TxtB_IP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtB_IP_KeyPress);
            this.TxtB_IP.Leave += new System.EventHandler(this.TxtB_IP_Leave);
            // 
            // TxtB_Nome
            // 
            this.TxtB_Nome.Location = new System.Drawing.Point(527, 25);
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
            this.TxtB_Nome.TabIndex = 30;
            this.TxtB_Nome.Text = "1";
            this.TxtB_Nome.TextChanged += new System.EventHandler(this.TxtB_Nome_TextChanged);
            this.TxtB_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtB_Nome_KeyPress);
            this.TxtB_Nome.Leave += new System.EventHandler(this.TxtB_Nome_Leave);
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Nome.IsDerivedStyle = true;
            this.Lbl_Nome.Location = new System.Drawing.Point(448, 22);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(73, 32);
            this.Lbl_Nome.Style = MetroSet_UI.Enums.Style.Light;
            this.Lbl_Nome.StyleManager = null;
            this.Lbl_Nome.TabIndex = 34;
            this.Lbl_Nome.Text = "Nome:";
            this.Lbl_Nome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_Nome.ThemeAuthor = "Narwin";
            this.Lbl_Nome.ThemeName = "MetroLite";
            // 
            // Lbl_TPacote
            // 
            this.Lbl_TPacote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_TPacote.IsDerivedStyle = true;
            this.Lbl_TPacote.Location = new System.Drawing.Point(12, 222);
            this.Lbl_TPacote.Name = "Lbl_TPacote";
            this.Lbl_TPacote.Size = new System.Drawing.Size(187, 60);
            this.Lbl_TPacote.Style = MetroSet_UI.Enums.Style.Light;
            this.Lbl_TPacote.StyleManager = null;
            this.Lbl_TPacote.TabIndex = 37;
            this.Lbl_TPacote.Text = "Tamanho do Pacote:";
            this.Lbl_TPacote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_TPacote.ThemeAuthor = "Narwin";
            this.Lbl_TPacote.ThemeName = "MetroLite";
            // 
            // TxtB_QPacote
            // 
            this.TxtB_QPacote.Location = new System.Drawing.Point(682, 238);
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
            this.TxtB_QPacote.TabIndex = 35;
            this.TxtB_QPacote.Text = "10";
            this.TxtB_QPacote.TextChanged += new System.EventHandler(this.TxtB_QPacote_TextChanged);
            this.TxtB_QPacote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtB_QPacote_KeyPress);
            this.TxtB_QPacote.Leave += new System.EventHandler(this.TxtB_QPacote_Leave);
            // 
            // Lbl_QPacote
            // 
            this.Lbl_QPacote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_QPacote.IsDerivedStyle = true;
            this.Lbl_QPacote.Location = new System.Drawing.Point(554, 222);
            this.Lbl_QPacote.Name = "Lbl_QPacote";
            this.Lbl_QPacote.Size = new System.Drawing.Size(107, 60);
            this.Lbl_QPacote.Style = MetroSet_UI.Enums.Style.Light;
            this.Lbl_QPacote.StyleManager = null;
            this.Lbl_QPacote.TabIndex = 40;
            this.Lbl_QPacote.Text = "N° Pacotes:";
            this.Lbl_QPacote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_QPacote.ThemeAuthor = "Narwin";
            this.Lbl_QPacote.ThemeName = "MetroLite";
            // 
            // TxtB_TPacote
            // 
            this.TxtB_TPacote.Location = new System.Drawing.Point(205, 238);
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
            this.TxtB_TPacote.TabIndex = 33;
            this.TxtB_TPacote.Text = "32";
            this.TxtB_TPacote.TextChanged += new System.EventHandler(this.TxtB_TPacote_TextChanged);
            this.TxtB_TPacote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtB_TPacote_KeyPress);
            this.TxtB_TPacote.Leave += new System.EventHandler(this.TxtB_TPacote_Leave);
            // 
            // Lbl_FPacote
            // 
            this.Lbl_FPacote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_FPacote.IsDerivedStyle = true;
            this.Lbl_FPacote.Location = new System.Drawing.Point(23, 327);
            this.Lbl_FPacote.Name = "Lbl_FPacote";
            this.Lbl_FPacote.Size = new System.Drawing.Size(187, 60);
            this.Lbl_FPacote.Style = MetroSet_UI.Enums.Style.Light;
            this.Lbl_FPacote.StyleManager = null;
            this.Lbl_FPacote.TabIndex = 41;
            this.Lbl_FPacote.Text = "Fragmentar Pacote:";
            this.Lbl_FPacote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_FPacote.ThemeAuthor = "Narwin";
            this.Lbl_FPacote.ThemeName = "MetroLite";
            // 
            // Rdo_Sim
            // 
            this.Rdo_Sim.Checked = true;
            this.Rdo_Sim.Location = new System.Drawing.Point(237, 347);
            this.Rdo_Sim.Name = "Rdo_Sim";
            this.Rdo_Sim.Size = new System.Drawing.Size(43, 20);
            this.Rdo_Sim.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.Rdo_Sim.TabIndex = 36;
            this.Rdo_Sim.Values.Text = "Sim";
            this.Rdo_Sim.Click += new System.EventHandler(this.Rdo_Sim_Click);
            // 
            // Rdo_Nao
            // 
            this.Rdo_Nao.Location = new System.Drawing.Point(305, 347);
            this.Rdo_Nao.Name = "Rdo_Nao";
            this.Rdo_Nao.Size = new System.Drawing.Size(45, 20);
            this.Rdo_Nao.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.Rdo_Nao.TabIndex = 38;
            this.Rdo_Nao.Values.Text = "Não";
            this.Rdo_Nao.Click += new System.EventHandler(this.Rdo_Nao_Click);
            // 
            // Form2_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Monitoramento.Properties.Resources.dark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(837, 432);
            this.Controls.Add(this.Lbl_ID);
            this.Controls.Add(this.TxtB_ID);
            this.Controls.Add(this.Lbl_IP);
            this.Controls.Add(this.TxtB_IP);
            this.Controls.Add(this.TxtB_Nome);
            this.Controls.Add(this.Lbl_Nome);
            this.Controls.Add(this.Lbl_TPacote);
            this.Controls.Add(this.TxtB_QPacote);
            this.Controls.Add(this.Lbl_QPacote);
            this.Controls.Add(this.TxtB_TPacote);
            this.Controls.Add(this.Lbl_FPacote);
            this.Controls.Add(this.Rdo_Sim);
            this.Controls.Add(this.Rdo_Nao);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroSet_UI.Controls.MetroSetLabel Lbl_ID;
        private MetroSet_UI.Controls.MetroSetLabel Lbl_IP;
        private MetroSet_UI.Controls.MetroSetLabel Lbl_Nome;
        private MetroSet_UI.Controls.MetroSetLabel Lbl_TPacote;
        private MetroSet_UI.Controls.MetroSetLabel Lbl_QPacote;
        private MetroSet_UI.Controls.MetroSetLabel Lbl_FPacote;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_IP;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_Nome;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_QPacote;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_TPacote;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton Rdo_Sim;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton Rdo_Nao;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_ID;
    }
}


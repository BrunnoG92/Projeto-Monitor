
namespace Monitoramento
{
    partial class Form2_Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.TxtB_ID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TxtB_IP = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TxtB_Nome = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TxtB_QPacote = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TxtB_TPacote = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Rdo_Sim = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.Rdo_Nao = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.Lbl_ID = new System.Windows.Forms.Label();
            this.Lbl_IP = new System.Windows.Forms.Label();
            this.Lbl_TPacote = new System.Windows.Forms.Label();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Lbl_QPacote = new System.Windows.Forms.Label();
            this.Lbl_FPacote = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // TxtB_ID
            // 
            this.TxtB_ID.Location = new System.Drawing.Point(95, 25);
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
            this.TxtB_ID.TabIndex = 39;
            this.TxtB_ID.Text = "1";
            this.TxtB_ID.TextChanged += new System.EventHandler(this.TxtB_ID_TextChanged);
            this.TxtB_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtB_ID_KeyPress);
            this.TxtB_ID.Leave += new System.EventHandler(this.TxtB_ID_Leave);
            // 
            // TxtB_IP
            // 
            this.TxtB_IP.Location = new System.Drawing.Point(76, 138);
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
            this.TxtB_IP.TabIndex = 41;
            this.TxtB_IP.Text = "8.8.8.8";
            this.TxtB_IP.TextChanged += new System.EventHandler(this.TxtB_IP_TextChanged);
            this.TxtB_IP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtB_IP_KeyPress);
            this.TxtB_IP.Leave += new System.EventHandler(this.TxtB_IP_Leave);
            // 
            // TxtB_Nome
            // 
            this.TxtB_Nome.Location = new System.Drawing.Point(514, 25);
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
            this.TxtB_Nome.TabIndex = 40;
            this.TxtB_Nome.Text = "1";
            this.TxtB_Nome.TextChanged += new System.EventHandler(this.TxtB_Nome_TextChanged);
            this.TxtB_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtB_Nome_KeyPress);
            this.TxtB_Nome.Leave += new System.EventHandler(this.TxtB_Nome_Leave);
            // 
            // TxtB_QPacote
            // 
            this.TxtB_QPacote.Location = new System.Drawing.Point(669, 238);
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
            this.TxtB_QPacote.TabIndex = 43;
            this.TxtB_QPacote.Text = "10";
            this.TxtB_QPacote.TextChanged += new System.EventHandler(this.TxtB_QPacote_TextChanged);
            this.TxtB_QPacote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtB_QPacote_KeyPress);
            this.TxtB_QPacote.Leave += new System.EventHandler(this.TxtB_QPacote_Leave);
            // 
            // TxtB_TPacote
            // 
            this.TxtB_TPacote.Location = new System.Drawing.Point(192, 238);
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
            this.TxtB_TPacote.TabIndex = 42;
            this.TxtB_TPacote.Text = "32";
            this.TxtB_TPacote.TextChanged += new System.EventHandler(this.TxtB_TPacote_TextChanged);
            this.TxtB_TPacote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtB_TPacote_KeyPress);
            this.TxtB_TPacote.Leave += new System.EventHandler(this.TxtB_TPacote_Leave);
            // 
            // Rdo_Sim
            // 
            this.Rdo_Sim.Checked = true;
            this.Rdo_Sim.Location = new System.Drawing.Point(224, 347);
            this.Rdo_Sim.Name = "Rdo_Sim";
            this.Rdo_Sim.Size = new System.Drawing.Size(43, 20);
            this.Rdo_Sim.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.Rdo_Sim.TabIndex = 44;
            this.toolTip1.SetToolTip(this.Rdo_Sim, "Permite ou não a fragmentação de pacotes. Altere somente se necessário");
            this.Rdo_Sim.Values.Text = "Sim";
            this.Rdo_Sim.Click += new System.EventHandler(this.Rdo_Sim_Click);
            // 
            // Rdo_Nao
            // 
            this.Rdo_Nao.Location = new System.Drawing.Point(292, 347);
            this.Rdo_Nao.Name = "Rdo_Nao";
            this.Rdo_Nao.Size = new System.Drawing.Size(45, 20);
            this.Rdo_Nao.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.Rdo_Nao.TabIndex = 45;
            this.toolTip1.SetToolTip(this.Rdo_Nao, "Permite ou não a fragmentação de pacotes. Altere somente se necessário");
            this.Rdo_Nao.Values.Text = "Não";
            this.Rdo_Nao.Click += new System.EventHandler(this.Rdo_Nao_Click);
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_ID.ForeColor = System.Drawing.Color.White;
            this.Lbl_ID.Location = new System.Drawing.Point(12, 9);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(76, 61);
            this.Lbl_ID.TabIndex = 46;
            this.Lbl_ID.Text = "ID:";
            this.Lbl_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.Lbl_ID, "Número do cliente");
            // 
            // Lbl_IP
            // 
            this.Lbl_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_IP.ForeColor = System.Drawing.Color.White;
            this.Lbl_IP.Location = new System.Drawing.Point(12, 123);
            this.Lbl_IP.Name = "Lbl_IP";
            this.Lbl_IP.Size = new System.Drawing.Size(58, 61);
            this.Lbl_IP.TabIndex = 47;
            this.Lbl_IP.Text = "Host:";
            this.Lbl_IP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.Lbl_IP, "IP ou site que deseja monitorar");
            // 
            // Lbl_TPacote
            // 
            this.Lbl_TPacote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_TPacote.ForeColor = System.Drawing.Color.White;
            this.Lbl_TPacote.Location = new System.Drawing.Point(12, 221);
            this.Lbl_TPacote.Name = "Lbl_TPacote";
            this.Lbl_TPacote.Size = new System.Drawing.Size(174, 61);
            this.Lbl_TPacote.TabIndex = 48;
            this.Lbl_TPacote.Text = "Tamanho do Pacote:";
            this.Lbl_TPacote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.Lbl_TPacote, "MTU do Ping. Altere somente se souber o que está fazendo");
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Nome.ForeColor = System.Drawing.Color.White;
            this.Lbl_Nome.Location = new System.Drawing.Point(432, 9);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(76, 61);
            this.Lbl_Nome.TabIndex = 49;
            this.Lbl_Nome.Text = "Nome:";
            this.Lbl_Nome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_QPacote
            // 
            this.Lbl_QPacote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_QPacote.ForeColor = System.Drawing.Color.White;
            this.Lbl_QPacote.Location = new System.Drawing.Point(540, 221);
            this.Lbl_QPacote.Name = "Lbl_QPacote";
            this.Lbl_QPacote.Size = new System.Drawing.Size(107, 61);
            this.Lbl_QPacote.TabIndex = 50;
            this.Lbl_QPacote.Text = "N° Pacotes";
            this.Lbl_QPacote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.Lbl_QPacote, "Quantidade de pings que deseja fazer");
            // 
            // Lbl_FPacote
            // 
            this.Lbl_FPacote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_FPacote.ForeColor = System.Drawing.Color.White;
            this.Lbl_FPacote.Location = new System.Drawing.Point(26, 323);
            this.Lbl_FPacote.Name = "Lbl_FPacote";
            this.Lbl_FPacote.Size = new System.Drawing.Size(174, 61);
            this.Lbl_FPacote.TabIndex = 51;
            this.Lbl_FPacote.Text = "Fragmentar Pacote:";
            this.Lbl_FPacote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Monitoramento.Properties.Resources.dark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(837, 432);
            this.Controls.Add(this.Lbl_FPacote);
            this.Controls.Add(this.Lbl_QPacote);
            this.Controls.Add(this.Lbl_Nome);
            this.Controls.Add(this.Lbl_TPacote);
            this.Controls.Add(this.Lbl_IP);
            this.Controls.Add(this.Lbl_ID);
            this.Controls.Add(this.TxtB_ID);
            this.Controls.Add(this.TxtB_IP);
            this.Controls.Add(this.TxtB_Nome);
            this.Controls.Add(this.TxtB_QPacote);
            this.Controls.Add(this.TxtB_TPacote);
            this.Controls.Add(this.Rdo_Sim);
            this.Controls.Add(this.Rdo_Nao);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2_Dashboard";
            this.Text = "Form2_Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_ID;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_IP;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_Nome;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_QPacote;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_TPacote;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton Rdo_Sim;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton Rdo_Nao;
        private System.Windows.Forms.Label Lbl_ID;
        private System.Windows.Forms.Label Lbl_IP;
        private System.Windows.Forms.Label Lbl_TPacote;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.Label Lbl_QPacote;
        private System.Windows.Forms.Label Lbl_FPacote;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
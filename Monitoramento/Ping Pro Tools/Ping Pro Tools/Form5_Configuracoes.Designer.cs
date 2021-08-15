
namespace Ping_Pro_Tools
{
    partial class Form5_Configuracoes
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
            this.TxtB_Servidor = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Lbl_Servidor = new System.Windows.Forms.Label();
            this.Txtb_Porta = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Lbl_Porta = new System.Windows.Forms.Label();
            this.Lbl_BD = new System.Windows.Forms.Label();
            this.Txtb_BD = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Lbl_Senha = new System.Windows.Forms.Label();
            this.TxtB_Usuario = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TxtB_Senha = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Btn_Conectar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // TxtB_Servidor
            // 
            this.TxtB_Servidor.Location = new System.Drawing.Point(153, 65);
            this.TxtB_Servidor.MaxLength = 100;
            this.TxtB_Servidor.Name = "TxtB_Servidor";
            this.TxtB_Servidor.Size = new System.Drawing.Size(321, 29);
            this.TxtB_Servidor.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.TxtB_Servidor.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_Servidor.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_Servidor.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TxtB_Servidor.StateCommon.Border.Rounding = 10;
            this.TxtB_Servidor.StateCommon.Content.Color1 = System.Drawing.SystemColors.ScrollBar;
            this.TxtB_Servidor.TabIndex = 55;
            this.TxtB_Servidor.Text = "bruno-dev.coswwudtnlbd.us-east-2.rds.amazonaws.com";
            // 
            // Lbl_Servidor
            // 
            this.Lbl_Servidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Servidor.ForeColor = System.Drawing.Color.White;
            this.Lbl_Servidor.Location = new System.Drawing.Point(26, 52);
            this.Lbl_Servidor.Name = "Lbl_Servidor";
            this.Lbl_Servidor.Size = new System.Drawing.Size(99, 53);
            this.Lbl_Servidor.TabIndex = 54;
            this.Lbl_Servidor.Text = "Servidor:";
            this.Lbl_Servidor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lbl_Servidor.UseCompatibleTextRendering = true;
            // 
            // Txtb_Porta
            // 
            this.Txtb_Porta.Location = new System.Drawing.Point(600, 65);
            this.Txtb_Porta.MaxLength = 100;
            this.Txtb_Porta.Name = "Txtb_Porta";
            this.Txtb_Porta.Size = new System.Drawing.Size(174, 29);
            this.Txtb_Porta.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.Txtb_Porta.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Txtb_Porta.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Txtb_Porta.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Txtb_Porta.StateCommon.Border.Rounding = 10;
            this.Txtb_Porta.StateCommon.Content.Color1 = System.Drawing.SystemColors.ScrollBar;
            this.Txtb_Porta.TabIndex = 57;
            this.Txtb_Porta.Text = "3306";
            // 
            // Lbl_Porta
            // 
            this.Lbl_Porta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Porta.ForeColor = System.Drawing.Color.White;
            this.Lbl_Porta.Location = new System.Drawing.Point(473, 52);
            this.Lbl_Porta.Name = "Lbl_Porta";
            this.Lbl_Porta.Size = new System.Drawing.Size(99, 53);
            this.Lbl_Porta.TabIndex = 56;
            this.Lbl_Porta.Text = "Porta:";
            this.Lbl_Porta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lbl_Porta.UseCompatibleTextRendering = true;
            // 
            // Lbl_BD
            // 
            this.Lbl_BD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_BD.ForeColor = System.Drawing.Color.White;
            this.Lbl_BD.Location = new System.Drawing.Point(24, 131);
            this.Lbl_BD.Name = "Lbl_BD";
            this.Lbl_BD.Size = new System.Drawing.Size(148, 53);
            this.Lbl_BD.TabIndex = 58;
            this.Lbl_BD.Text = "Banco de Dados:";
            this.Lbl_BD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lbl_BD.UseCompatibleTextRendering = true;
            // 
            // Txtb_BD
            // 
            this.Txtb_BD.Location = new System.Drawing.Point(178, 142);
            this.Txtb_BD.MaxLength = 100;
            this.Txtb_BD.Name = "Txtb_BD";
            this.Txtb_BD.Size = new System.Drawing.Size(121, 29);
            this.Txtb_BD.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.Txtb_BD.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Txtb_BD.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Txtb_BD.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Txtb_BD.StateCommon.Border.Rounding = 10;
            this.Txtb_BD.StateCommon.Content.Color1 = System.Drawing.SystemColors.ScrollBar;
            this.Txtb_BD.TabIndex = 59;
            this.Txtb_BD.Text = "PingProTools";
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Usuario.ForeColor = System.Drawing.Color.White;
            this.Lbl_Usuario.Location = new System.Drawing.Point(38, 203);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(99, 53);
            this.Lbl_Usuario.TabIndex = 60;
            this.Lbl_Usuario.Text = "Usuário:";
            this.Lbl_Usuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lbl_Usuario.UseCompatibleTextRendering = true;
            // 
            // Lbl_Senha
            // 
            this.Lbl_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Senha.ForeColor = System.Drawing.Color.White;
            this.Lbl_Senha.Location = new System.Drawing.Point(574, 203);
            this.Lbl_Senha.Name = "Lbl_Senha";
            this.Lbl_Senha.Size = new System.Drawing.Size(99, 53);
            this.Lbl_Senha.TabIndex = 61;
            this.Lbl_Senha.Text = "Senha:";
            this.Lbl_Senha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lbl_Senha.UseCompatibleTextRendering = true;
            // 
            // TxtB_Usuario
            // 
            this.TxtB_Usuario.Location = new System.Drawing.Point(153, 215);
            this.TxtB_Usuario.MaxLength = 100;
            this.TxtB_Usuario.Name = "TxtB_Usuario";
            this.TxtB_Usuario.Size = new System.Drawing.Size(94, 29);
            this.TxtB_Usuario.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.TxtB_Usuario.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_Usuario.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_Usuario.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TxtB_Usuario.StateCommon.Border.Rounding = 10;
            this.TxtB_Usuario.StateCommon.Content.Color1 = System.Drawing.SystemColors.ScrollBar;
            this.TxtB_Usuario.TabIndex = 62;
            this.TxtB_Usuario.Text = "brunog";
            // 
            // TxtB_Senha
            // 
            this.TxtB_Senha.Location = new System.Drawing.Point(680, 215);
            this.TxtB_Senha.MaxLength = 100;
            this.TxtB_Senha.Name = "TxtB_Senha";
            this.TxtB_Senha.PasswordChar = '*';
            this.TxtB_Senha.Size = new System.Drawing.Size(94, 29);
            this.TxtB_Senha.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.TxtB_Senha.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_Senha.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtB_Senha.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TxtB_Senha.StateCommon.Border.Rounding = 10;
            this.TxtB_Senha.StateCommon.Content.Color1 = System.Drawing.SystemColors.ScrollBar;
            this.TxtB_Senha.TabIndex = 63;
            this.TxtB_Senha.Text = "98497389b";
            // 
            // Btn_Conectar
            // 
            this.Btn_Conectar.Location = new System.Drawing.Point(362, 368);
            this.Btn_Conectar.Name = "Btn_Conectar";
            this.Btn_Conectar.Size = new System.Drawing.Size(112, 31);
            this.Btn_Conectar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_Conectar.StateCommon.Border.Rounding = 10;
            this.Btn_Conectar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.Btn_Conectar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Btn_Conectar.TabIndex = 64;
            this.Btn_Conectar.Values.Text = "CONECTAR";
            this.Btn_Conectar.Click += new System.EventHandler(this.Btn_Conectar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(38, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Configurações do Banco de Dados";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Form5_Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Ping_Pro_Tools.Properties.Resources.dark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(837, 432);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btn_Conectar);
            this.Controls.Add(this.TxtB_Usuario);
            this.Controls.Add(this.TxtB_Senha);
            this.Controls.Add(this.Lbl_Senha);
            this.Controls.Add(this.Lbl_Usuario);
            this.Controls.Add(this.Txtb_BD);
            this.Controls.Add(this.Lbl_BD);
            this.Controls.Add(this.Lbl_Porta);
            this.Controls.Add(this.Txtb_Porta);
            this.Controls.Add(this.Lbl_Servidor);
            this.Controls.Add(this.TxtB_Servidor);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5_Configuracoes";
            this.Text = "Form6_Configuracoes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_Servidor;
        private System.Windows.Forms.Label Lbl_Servidor;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Txtb_Porta;
        private System.Windows.Forms.Label Lbl_Porta;
        private System.Windows.Forms.Label Lbl_BD;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Txtb_BD;
        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.Label Lbl_Senha;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_Usuario;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtB_Senha;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Conectar;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
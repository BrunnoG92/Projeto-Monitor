namespace ToastNotifications
{
    partial class Notification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notification));
            this.lifeTimer = new System.Windows.Forms.Timer(this.components);
            this.labelBody = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.PicB_Icone = new System.Windows.Forms.PictureBox();
            this.Pnl_Notificacao = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PicB_Icone)).BeginInit();
            this.Pnl_Notificacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // lifeTimer
            // 
            this.lifeTimer.Tick += new System.EventHandler(this.lifeTimer_Tick);
            // 
            // labelBody
            // 
            this.labelBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBody.BackColor = System.Drawing.Color.Transparent;
            this.labelBody.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBody.ForeColor = System.Drawing.Color.White;
            this.labelBody.Location = new System.Drawing.Point(68, 24);
            this.labelBody.Name = "labelBody";
            this.labelBody.Size = new System.Drawing.Size(271, 54);
            this.labelBody.TabIndex = 0;
            this.labelBody.Text = "Body goes here and here and here and here and here";
            this.labelBody.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBody.Click += new System.EventHandler(this.labelRO_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitle.Location = new System.Drawing.Point(86, 3);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(216, 21);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "title goes here";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // PicB_Icone
            // 
            this.PicB_Icone.Image = global::Ping_Pro_Tools.Properties.Resources.Error;
            this.PicB_Icone.Location = new System.Drawing.Point(3, 12);
            this.PicB_Icone.Name = "PicB_Icone";
            this.PicB_Icone.Size = new System.Drawing.Size(59, 66);
            this.PicB_Icone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PicB_Icone.TabIndex = 1;
            this.PicB_Icone.TabStop = false;
            // 
            // Pnl_Notificacao
            // 
            this.Pnl_Notificacao.BackColor = System.Drawing.Color.Red;
            this.Pnl_Notificacao.Controls.Add(this.PicB_Icone);
            this.Pnl_Notificacao.Controls.Add(this.labelTitle);
            this.Pnl_Notificacao.Controls.Add(this.labelBody);
            this.Pnl_Notificacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Notificacao.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Notificacao.Name = "Pnl_Notificacao";
            this.Pnl_Notificacao.Size = new System.Drawing.Size(351, 90);
            this.Pnl_Notificacao.TabIndex = 2;
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(351, 90);
            this.ControlBox = false;
            this.Controls.Add(this.Pnl_Notificacao);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Notification";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "EDGE Shop Flag Notification";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Notification_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Notification_FormClosed);
            this.Load += new System.EventHandler(this.Notification_Load);
            this.Shown += new System.EventHandler(this.Notification_Shown);
            this.Click += new System.EventHandler(this.Notification_Click);
            ((System.ComponentModel.ISupportInitialize)(this.PicB_Icone)).EndInit();
            this.Pnl_Notificacao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer lifeTimer;
        private System.Windows.Forms.Label labelBody;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox PicB_Icone;
        public System.Windows.Forms.Panel Pnl_Notificacao;
    }
}
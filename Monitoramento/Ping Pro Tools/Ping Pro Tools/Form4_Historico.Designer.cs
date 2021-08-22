
namespace Ping_Pro_Tools
{
    partial class Form4_Historico
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
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.idPing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operadorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadePingDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pingProToolsDataSet = new Ping_Pro_Tools.PingProToolsDataSet();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Btn6_Carregar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Btn_Apagar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.pingTableAdapter = new Ping_Pro_Tools.PingProToolsDataSetTableAdapters.PingTableAdapter();
            this.Btn_EnviarAnalise = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pingProToolsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AllowUserToAddRows = false;
            this.kryptonDataGridView1.AllowUserToOrderColumns = true;
            this.kryptonDataGridView1.AutoGenerateColumns = false;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPing,
            this.Data,
            this.operadorDataGridViewTextBoxColumn1,
            this.clienteDataGridViewTextBoxColumn1,
            this.quantidadePingDataGridViewTextBoxColumn1,
            this.hostDataGridViewTextBoxColumn1});
            this.kryptonDataGridView1.DataSource = this.pingBindingSource;
            this.kryptonDataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonDataGridView1.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.kryptonDataGridView1.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonCommand;
            this.kryptonDataGridView1.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.kryptonDataGridView1.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.kryptonDataGridView1.Margin = new System.Windows.Forms.Padding(10);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.ReadOnly = true;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(856, 390);
            this.kryptonDataGridView1.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonCommand;
            this.kryptonDataGridView1.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.kryptonDataGridView1.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.kryptonDataGridView1.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonDataGridView1.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonDataGridView1.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDataGridView1.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Border.Rounding = 2;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonDataGridView1.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.kryptonDataGridView1.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.kryptonDataGridView1.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateCommon.HeaderRow.Content.Color2 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.kryptonDataGridView1.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.kryptonDataGridView1.TabIndex = 3;
            // 
            // idPing
            // 
            this.idPing.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idPing.DataPropertyName = "idPing";
            this.idPing.HeaderText = "Teste N°";
            this.idPing.Name = "idPing";
            this.idPing.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // operadorDataGridViewTextBoxColumn1
            // 
            this.operadorDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.operadorDataGridViewTextBoxColumn1.DataPropertyName = "Operador";
            this.operadorDataGridViewTextBoxColumn1.HeaderText = "Operador";
            this.operadorDataGridViewTextBoxColumn1.Name = "operadorDataGridViewTextBoxColumn1";
            this.operadorDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // clienteDataGridViewTextBoxColumn1
            // 
            this.clienteDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clienteDataGridViewTextBoxColumn1.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn1.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn1.Name = "clienteDataGridViewTextBoxColumn1";
            this.clienteDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // quantidadePingDataGridViewTextBoxColumn1
            // 
            this.quantidadePingDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantidadePingDataGridViewTextBoxColumn1.DataPropertyName = "Quantidade_Ping";
            this.quantidadePingDataGridViewTextBoxColumn1.HeaderText = "Total Ping";
            this.quantidadePingDataGridViewTextBoxColumn1.Name = "quantidadePingDataGridViewTextBoxColumn1";
            this.quantidadePingDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // hostDataGridViewTextBoxColumn1
            // 
            this.hostDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hostDataGridViewTextBoxColumn1.DataPropertyName = "Host";
            this.hostDataGridViewTextBoxColumn1.HeaderText = "Host";
            this.hostDataGridViewTextBoxColumn1.Name = "hostDataGridViewTextBoxColumn1";
            this.hostDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pingBindingSource
            // 
            this.pingBindingSource.DataMember = "Ping";
            this.pingBindingSource.DataSource = this.pingProToolsDataSet;
            // 
            // pingProToolsDataSet
            // 
            this.pingProToolsDataSet.DataSetName = "PingProToolsDataSet";
            this.pingProToolsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Btn6_Carregar
            // 
            this.Btn6_Carregar.Location = new System.Drawing.Point(132, 384);
            this.Btn6_Carregar.Name = "Btn6_Carregar";
            this.Btn6_Carregar.Size = new System.Drawing.Size(173, 31);
            this.Btn6_Carregar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn6_Carregar.StateCommon.Border.Rounding = 10;
            this.Btn6_Carregar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.Btn6_Carregar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Btn6_Carregar.TabIndex = 5;
            this.Btn6_Carregar.Values.Text = "CARREGAR HISTORICO";
            this.Btn6_Carregar.Click += new System.EventHandler(this.Btn6_Carregar_Click_1);
            // 
            // Btn_Apagar
            // 
            this.Btn_Apagar.Location = new System.Drawing.Point(346, 384);
            this.Btn_Apagar.Name = "Btn_Apagar";
            this.Btn_Apagar.Size = new System.Drawing.Size(171, 31);
            this.Btn_Apagar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_Apagar.StateCommon.Border.Rounding = 10;
            this.Btn_Apagar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.Btn_Apagar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Btn_Apagar.TabIndex = 6;
            this.Btn_Apagar.Values.Text = "APAGAR SELECIONADO";
            this.Btn_Apagar.Click += new System.EventHandler(this.Btn_Apagar_Click);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            // 
            // pingTableAdapter
            // 
            this.pingTableAdapter.ClearBeforeFill = true;
            // 
            // Btn_EnviarAnalise
            // 
            this.Btn_EnviarAnalise.Location = new System.Drawing.Point(550, 384);
            this.Btn_EnviarAnalise.Name = "Btn_EnviarAnalise";
            this.Btn_EnviarAnalise.Size = new System.Drawing.Size(171, 31);
            this.Btn_EnviarAnalise.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_EnviarAnalise.StateCommon.Border.Rounding = 10;
            this.Btn_EnviarAnalise.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.Btn_EnviarAnalise.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Btn_EnviarAnalise.TabIndex = 7;
            this.Btn_EnviarAnalise.Values.Text = "ENVIAR PARA ANÁLISE";
            this.Btn_EnviarAnalise.Click += new System.EventHandler(this.Btn_EnviarAnalise_Click);
            // 
            // Form4_Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Ping_Pro_Tools.Properties.Resources.dark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(856, 444);
            this.Controls.Add(this.Btn_EnviarAnalise);
            this.Controls.Add(this.Btn_Apagar);
            this.Controls.Add(this.Btn6_Carregar);
            this.Controls.Add(this.kryptonDataGridView1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4_Historico";
            this.Text = "Form4_Historico";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pingProToolsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PingProToolsDataSet pingProToolsDataSet;
        private System.Windows.Forms.BindingSource pingBindingSource;
        private PingProToolsDataSetTableAdapters.PingTableAdapter pingTableAdapter;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn6_Carregar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Apagar;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPing;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn operadorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadePingDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostDataGridViewTextBoxColumn1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_EnviarAnalise;
    }
}
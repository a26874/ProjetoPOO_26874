namespace Desktop
{
    partial class InsereAssist
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
            this.InserirAssist = new System.Windows.Forms.Button();
            this.dataHoraAssist = new System.Windows.Forms.TextBox();
            this.DataHoraAssistLabel = new System.Windows.Forms.Label();
            this.DescriçãoAssistLabel = new System.Windows.Forms.Label();
            this.descricaoAssist = new System.Windows.Forms.TextBox();
            this.NomeTipoAssistLabel = new System.Windows.Forms.Label();
            this.precoAssist = new System.Windows.Forms.TextBox();
            this.PrecoAssistLabel = new System.Windows.Forms.Label();
            this.nifClienteLabel = new System.Windows.Forms.Label();
            this.IDOperadorLabel = new System.Windows.Forms.Label();
            this.nifClienteAssist = new System.Windows.Forms.TextBox();
            this.idOperadorAssist = new System.Windows.Forms.TextBox();
            this.menuTipoAssistenciaButton = new System.Windows.Forms.MenuStrip();
            this.selecioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atendimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entregasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManutencaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataHoraLabel = new System.Windows.Forms.Label();
            this.DataHoraTimer = new System.Windows.Forms.Timer(this.components);
            this.menuTipoAssistenciaButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // InserirAssist
            // 
            this.InserirAssist.Location = new System.Drawing.Point(40, 386);
            this.InserirAssist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InserirAssist.Name = "InserirAssist";
            this.InserirAssist.Size = new System.Drawing.Size(75, 23);
            this.InserirAssist.TabIndex = 5;
            this.InserirAssist.Text = "Inserir";
            this.InserirAssist.UseVisualStyleBackColor = true;
            this.InserirAssist.Click += new System.EventHandler(this.InserirAssist_Click);
            // 
            // dataHoraAssist
            // 
            this.dataHoraAssist.Location = new System.Drawing.Point(220, 54);
            this.dataHoraAssist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataHoraAssist.Name = "dataHoraAssist";
            this.dataHoraAssist.Size = new System.Drawing.Size(100, 22);
            this.dataHoraAssist.TabIndex = 0;
            // 
            // DataHoraAssistLabel
            // 
            this.DataHoraAssistLabel.AutoSize = true;
            this.DataHoraAssistLabel.Location = new System.Drawing.Point(217, 25);
            this.DataHoraAssistLabel.Name = "DataHoraAssistLabel";
            this.DataHoraAssistLabel.Size = new System.Drawing.Size(83, 16);
            this.DataHoraAssistLabel.TabIndex = 4;
            this.DataHoraAssistLabel.Text = "Data e Hora:";
            // 
            // DescriçãoAssistLabel
            // 
            this.DescriçãoAssistLabel.AutoSize = true;
            this.DescriçãoAssistLabel.Location = new System.Drawing.Point(355, 25);
            this.DescriçãoAssistLabel.Name = "DescriçãoAssistLabel";
            this.DescriçãoAssistLabel.Size = new System.Drawing.Size(72, 16);
            this.DescriçãoAssistLabel.TabIndex = 5;
            this.DescriçãoAssistLabel.Text = "Descrição:";
            // 
            // descricaoAssist
            // 
            this.descricaoAssist.Location = new System.Drawing.Point(358, 54);
            this.descricaoAssist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descricaoAssist.Name = "descricaoAssist";
            this.descricaoAssist.Size = new System.Drawing.Size(100, 22);
            this.descricaoAssist.TabIndex = 4;
            // 
            // NomeTipoAssistLabel
            // 
            this.NomeTipoAssistLabel.AutoSize = true;
            this.NomeTipoAssistLabel.Location = new System.Drawing.Point(37, 25);
            this.NomeTipoAssistLabel.Name = "NomeTipoAssistLabel";
            this.NomeTipoAssistLabel.Size = new System.Drawing.Size(129, 16);
            this.NomeTipoAssistLabel.TabIndex = 8;
            this.NomeTipoAssistLabel.Text = "Tipo de Assistência:";
            // 
            // precoAssist
            // 
            this.precoAssist.Location = new System.Drawing.Point(358, 136);
            this.precoAssist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.precoAssist.Name = "precoAssist";
            this.precoAssist.Size = new System.Drawing.Size(100, 22);
            this.precoAssist.TabIndex = 3;
            // 
            // PrecoAssistLabel
            // 
            this.PrecoAssistLabel.AutoSize = true;
            this.PrecoAssistLabel.Location = new System.Drawing.Point(355, 98);
            this.PrecoAssistLabel.Name = "PrecoAssistLabel";
            this.PrecoAssistLabel.Size = new System.Drawing.Size(46, 16);
            this.PrecoAssistLabel.TabIndex = 12;
            this.PrecoAssistLabel.Text = "Preço:";
            // 
            // nifClienteLabel
            // 
            this.nifClienteLabel.AutoSize = true;
            this.nifClienteLabel.Location = new System.Drawing.Point(217, 98);
            this.nifClienteLabel.Name = "nifClienteLabel";
            this.nifClienteLabel.Size = new System.Drawing.Size(75, 16);
            this.nifClienteLabel.TabIndex = 13;
            this.nifClienteLabel.Text = "NIF Cliente:";
            // 
            // IDOperadorLabel
            // 
            this.IDOperadorLabel.AutoSize = true;
            this.IDOperadorLabel.Location = new System.Drawing.Point(217, 181);
            this.IDOperadorLabel.Name = "IDOperadorLabel";
            this.IDOperadorLabel.Size = new System.Drawing.Size(84, 16);
            this.IDOperadorLabel.TabIndex = 14;
            this.IDOperadorLabel.Text = "ID Operador:";
            // 
            // nifClienteAssist
            // 
            this.nifClienteAssist.Location = new System.Drawing.Point(220, 136);
            this.nifClienteAssist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nifClienteAssist.Name = "nifClienteAssist";
            this.nifClienteAssist.Size = new System.Drawing.Size(100, 22);
            this.nifClienteAssist.TabIndex = 1;
            // 
            // idOperadorAssist
            // 
            this.idOperadorAssist.Location = new System.Drawing.Point(220, 217);
            this.idOperadorAssist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idOperadorAssist.Name = "idOperadorAssist";
            this.idOperadorAssist.Size = new System.Drawing.Size(100, 22);
            this.idOperadorAssist.TabIndex = 2;
            // 
            // menuTipoAssistenciaButton
            // 
            this.menuTipoAssistenciaButton.Dock = System.Windows.Forms.DockStyle.None;
            this.menuTipoAssistenciaButton.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTipoAssistenciaButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selecioneToolStripMenuItem});
            this.menuTipoAssistenciaButton.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuTipoAssistenciaButton.Location = new System.Drawing.Point(40, 48);
            this.menuTipoAssistenciaButton.Name = "menuTipoAssistenciaButton";
            this.menuTipoAssistenciaButton.Size = new System.Drawing.Size(93, 28);
            this.menuTipoAssistenciaButton.TabIndex = 15;
            this.menuTipoAssistenciaButton.Text = "TipoAssistencia";
            // 
            // selecioneToolStripMenuItem
            // 
            this.selecioneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atendimentoToolStripMenuItem,
            this.entregasToolStripMenuItem,
            this.ManutencaoToolStripMenuItem,
            this.assistenciaToolStripMenuItem});
            this.selecioneToolStripMenuItem.Name = "selecioneToolStripMenuItem";
            this.selecioneToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.selecioneToolStripMenuItem.Text = "Selecione";
            this.selecioneToolStripMenuItem.Click += new System.EventHandler(this.selecioneToolStripMenuItem_Click);
            // 
            // atendimentoToolStripMenuItem
            // 
            this.atendimentoToolStripMenuItem.Name = "atendimentoToolStripMenuItem";
            this.atendimentoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.atendimentoToolStripMenuItem.Text = "Atendimento";
            this.atendimentoToolStripMenuItem.Click += new System.EventHandler(this.AtendimentoToolStripMenuItem_Click);
            // 
            // entregasToolStripMenuItem
            // 
            this.entregasToolStripMenuItem.Name = "entregasToolStripMenuItem";
            this.entregasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.entregasToolStripMenuItem.Text = "Entregas";
            this.entregasToolStripMenuItem.Click += new System.EventHandler(this.EntregasToolStripMenuItem_Click);
            // 
            // ManutencaoToolStripMenuItem
            // 
            this.ManutencaoToolStripMenuItem.Name = "ManutencaoToolStripMenuItem";
            this.ManutencaoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ManutencaoToolStripMenuItem.Text = "Manutencao";
            this.ManutencaoToolStripMenuItem.Click += new System.EventHandler(this.ManutencaoToolStripMenuItem_Click);
            // 
            // assistenciaToolStripMenuItem
            // 
            this.assistenciaToolStripMenuItem.Name = "assistenciaToolStripMenuItem";
            this.assistenciaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.assistenciaToolStripMenuItem.Text = "Assistencia";
            this.assistenciaToolStripMenuItem.Click += new System.EventHandler(this.assistenciaToolStripMenuItem_Click);
            // 
            // DataHoraLabel
            // 
            this.DataHoraLabel.AutoSize = true;
            this.DataHoraLabel.Location = new System.Drawing.Point(414, 393);
            this.DataHoraLabel.Name = "DataHoraLabel";
            this.DataHoraLabel.Size = new System.Drawing.Size(66, 16);
            this.DataHoraLabel.TabIndex = 16;
            this.DataHoraLabel.Text = "DataHora";
            // 
            // DataHoraTimer
            // 
            this.DataHoraTimer.Tick += new System.EventHandler(this.DataHoraTimer_Tick);
            // 
            // InsereAssist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 428);
            this.Controls.Add(this.DataHoraLabel);
            this.Controls.Add(this.idOperadorAssist);
            this.Controls.Add(this.nifClienteAssist);
            this.Controls.Add(this.IDOperadorLabel);
            this.Controls.Add(this.nifClienteLabel);
            this.Controls.Add(this.PrecoAssistLabel);
            this.Controls.Add(this.precoAssist);
            this.Controls.Add(this.NomeTipoAssistLabel);
            this.Controls.Add(this.descricaoAssist);
            this.Controls.Add(this.DescriçãoAssistLabel);
            this.Controls.Add(this.DataHoraAssistLabel);
            this.Controls.Add(this.dataHoraAssist);
            this.Controls.Add(this.InserirAssist);
            this.Controls.Add(this.menuTipoAssistenciaButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InsereAssist";
            this.Text = "Inserir Assistência";
            this.Load += new System.EventHandler(this.InsereAssist_Load);
            this.menuTipoAssistenciaButton.ResumeLayout(false);
            this.menuTipoAssistenciaButton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InserirAssist;
        private System.Windows.Forms.TextBox dataHoraAssist;
        private System.Windows.Forms.Label DataHoraAssistLabel;
        private System.Windows.Forms.Label DescriçãoAssistLabel;
        private System.Windows.Forms.TextBox descricaoAssist;
        private System.Windows.Forms.Label NomeTipoAssistLabel;
        private System.Windows.Forms.TextBox precoAssist;
        private System.Windows.Forms.Label PrecoAssistLabel;
        private System.Windows.Forms.Label nifClienteLabel;
        private System.Windows.Forms.Label IDOperadorLabel;
        private System.Windows.Forms.TextBox nifClienteAssist;
        private System.Windows.Forms.TextBox idOperadorAssist;
        private System.Windows.Forms.MenuStrip menuTipoAssistenciaButton;
        private System.Windows.Forms.ToolStripMenuItem selecioneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atendimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entregasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManutencaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assistenciaToolStripMenuItem;
        private System.Windows.Forms.Label DataHoraLabel;
        private System.Windows.Forms.Timer DataHoraTimer;
    }
}


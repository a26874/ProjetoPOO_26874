namespace Desktop
{
    partial class HelpDesk
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
            this.InserirAssist = new System.Windows.Forms.Button();
            this.dataHoraAssist = new System.Windows.Forms.TextBox();
            this.DataHoraAssistLabel = new System.Windows.Forms.Label();
            this.DescriçãoAssistLabel = new System.Windows.Forms.Label();
            this.descricaoAssist = new System.Windows.Forms.TextBox();
            this.nomeTipoAssist = new System.Windows.Forms.TextBox();
            this.NomeTipoAssistLabel = new System.Windows.Forms.Label();
            this.IDTipoLabel = new System.Windows.Forms.Label();
            this.idTipoAssist = new System.Windows.Forms.TextBox();
            this.precoAssist = new System.Windows.Forms.TextBox();
            this.PrecoAssistLabel = new System.Windows.Forms.Label();
            this.nifClienteLabel = new System.Windows.Forms.Label();
            this.IDOperadorLabel = new System.Windows.Forms.Label();
            this.nifClienteAssist = new System.Windows.Forms.TextBox();
            this.idOperadorAssist = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InserirAssist
            // 
            this.InserirAssist.Location = new System.Drawing.Point(40, 387);
            this.InserirAssist.Name = "InserirAssist";
            this.InserirAssist.Size = new System.Drawing.Size(75, 23);
            this.InserirAssist.TabIndex = 0;
            this.InserirAssist.Text = "Inserir";
            this.InserirAssist.UseVisualStyleBackColor = true;
            this.InserirAssist.Click += new System.EventHandler(this.InserirAssist_Click);
            // 
            // dataHoraAssist
            // 
            this.dataHoraAssist.Location = new System.Drawing.Point(40, 131);
            this.dataHoraAssist.Name = "dataHoraAssist";
            this.dataHoraAssist.Size = new System.Drawing.Size(100, 22);
            this.dataHoraAssist.TabIndex = 3;
            // 
            // DataHoraAssistLabel
            // 
            this.DataHoraAssistLabel.AutoSize = true;
            this.DataHoraAssistLabel.Location = new System.Drawing.Point(37, 101);
            this.DataHoraAssistLabel.Name = "DataHoraAssistLabel";
            this.DataHoraAssistLabel.Size = new System.Drawing.Size(80, 16);
            this.DataHoraAssistLabel.TabIndex = 4;
            this.DataHoraAssistLabel.Text = "Data e Hora";
            // 
            // DescriçãoAssistLabel
            // 
            this.DescriçãoAssistLabel.AutoSize = true;
            this.DescriçãoAssistLabel.Location = new System.Drawing.Point(213, 101);
            this.DescriçãoAssistLabel.Name = "DescriçãoAssistLabel";
            this.DescriçãoAssistLabel.Size = new System.Drawing.Size(69, 16);
            this.DescriçãoAssistLabel.TabIndex = 5;
            this.DescriçãoAssistLabel.Text = "Descrição";
            // 
            // descricaoAssist
            // 
            this.descricaoAssist.Location = new System.Drawing.Point(216, 131);
            this.descricaoAssist.Name = "descricaoAssist";
            this.descricaoAssist.Size = new System.Drawing.Size(100, 22);
            this.descricaoAssist.TabIndex = 6;
            // 
            // nomeTipoAssist
            // 
            this.nomeTipoAssist.Location = new System.Drawing.Point(216, 46);
            this.nomeTipoAssist.Name = "nomeTipoAssist";
            this.nomeTipoAssist.Size = new System.Drawing.Size(100, 22);
            this.nomeTipoAssist.TabIndex = 7;
            // 
            // NomeTipoAssistLabel
            // 
            this.NomeTipoAssistLabel.AutoSize = true;
            this.NomeTipoAssistLabel.Location = new System.Drawing.Point(213, 18);
            this.NomeTipoAssistLabel.Name = "NomeTipoAssistLabel";
            this.NomeTipoAssistLabel.Size = new System.Drawing.Size(35, 16);
            this.NomeTipoAssistLabel.TabIndex = 8;
            this.NomeTipoAssistLabel.Text = "Tipo";
            // 
            // IDTipoLabel
            // 
            this.IDTipoLabel.AutoSize = true;
            this.IDTipoLabel.Location = new System.Drawing.Point(213, 174);
            this.IDTipoLabel.Name = "IDTipoLabel";
            this.IDTipoLabel.Size = new System.Drawing.Size(51, 16);
            this.IDTipoLabel.TabIndex = 9;
            this.IDTipoLabel.Text = "ID Tipo";
            // 
            // idTipoAssist
            // 
            this.idTipoAssist.Location = new System.Drawing.Point(216, 212);
            this.idTipoAssist.Name = "idTipoAssist";
            this.idTipoAssist.Size = new System.Drawing.Size(100, 22);
            this.idTipoAssist.TabIndex = 10;
            // 
            // precoAssist
            // 
            this.precoAssist.Location = new System.Drawing.Point(216, 293);
            this.precoAssist.Name = "precoAssist";
            this.precoAssist.Size = new System.Drawing.Size(100, 22);
            this.precoAssist.TabIndex = 11;
            // 
            // PrecoAssistLabel
            // 
            this.PrecoAssistLabel.AutoSize = true;
            this.PrecoAssistLabel.Location = new System.Drawing.Point(216, 257);
            this.PrecoAssistLabel.Name = "PrecoAssistLabel";
            this.PrecoAssistLabel.Size = new System.Drawing.Size(43, 16);
            this.PrecoAssistLabel.TabIndex = 12;
            this.PrecoAssistLabel.Text = "Preço";
            // 
            // nifClienteLabel
            // 
            this.nifClienteLabel.AutoSize = true;
            this.nifClienteLabel.Location = new System.Drawing.Point(37, 174);
            this.nifClienteLabel.Name = "nifClienteLabel";
            this.nifClienteLabel.Size = new System.Drawing.Size(75, 16);
            this.nifClienteLabel.TabIndex = 13;
            this.nifClienteLabel.Text = "NIF Cliente:";
            // 
            // IDOperadorLabel
            // 
            this.IDOperadorLabel.AutoSize = true;
            this.IDOperadorLabel.Location = new System.Drawing.Point(37, 257);
            this.IDOperadorLabel.Name = "IDOperadorLabel";
            this.IDOperadorLabel.Size = new System.Drawing.Size(84, 16);
            this.IDOperadorLabel.TabIndex = 14;
            this.IDOperadorLabel.Text = "ID Operador:";
            // 
            // nifClienteAssist
            // 
            this.nifClienteAssist.Location = new System.Drawing.Point(40, 212);
            this.nifClienteAssist.Name = "nifClienteAssist";
            this.nifClienteAssist.Size = new System.Drawing.Size(100, 22);
            this.nifClienteAssist.TabIndex = 15;
            // 
            // idOperadorAssist
            // 
            this.idOperadorAssist.Location = new System.Drawing.Point(40, 293);
            this.idOperadorAssist.Name = "idOperadorAssist";
            this.idOperadorAssist.Size = new System.Drawing.Size(100, 22);
            this.idOperadorAssist.TabIndex = 16;
            // 
            // HelpDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.idOperadorAssist);
            this.Controls.Add(this.nifClienteAssist);
            this.Controls.Add(this.IDOperadorLabel);
            this.Controls.Add(this.nifClienteLabel);
            this.Controls.Add(this.PrecoAssistLabel);
            this.Controls.Add(this.precoAssist);
            this.Controls.Add(this.idTipoAssist);
            this.Controls.Add(this.IDTipoLabel);
            this.Controls.Add(this.NomeTipoAssistLabel);
            this.Controls.Add(this.nomeTipoAssist);
            this.Controls.Add(this.descricaoAssist);
            this.Controls.Add(this.DescriçãoAssistLabel);
            this.Controls.Add(this.DataHoraAssistLabel);
            this.Controls.Add(this.dataHoraAssist);
            this.Controls.Add(this.InserirAssist);
            this.Name = "HelpDesk";
            this.Text = "HelpDesk";
            this.Load += new System.EventHandler(this.HelpDesk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InserirAssist;
        private System.Windows.Forms.TextBox dataHoraAssist;
        private System.Windows.Forms.Label DataHoraAssistLabel;
        private System.Windows.Forms.Label DescriçãoAssistLabel;
        private System.Windows.Forms.TextBox descricaoAssist;
        private System.Windows.Forms.TextBox nomeTipoAssist;
        private System.Windows.Forms.Label NomeTipoAssistLabel;
        private System.Windows.Forms.Label IDTipoLabel;
        private System.Windows.Forms.TextBox idTipoAssist;
        private System.Windows.Forms.TextBox precoAssist;
        private System.Windows.Forms.Label PrecoAssistLabel;
        private System.Windows.Forms.Label nifClienteLabel;
        private System.Windows.Forms.Label IDOperadorLabel;
        private System.Windows.Forms.TextBox nifClienteAssist;
        private System.Windows.Forms.TextBox idOperadorAssist;
    }
}


namespace Desktop
{
    partial class ApresentarAssist
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
            this.TodasAssistButton = new System.Windows.Forms.Button();
            this.ApenasConcluidasButton = new System.Windows.Forms.Button();
            this.PorConcluirButton = new System.Windows.Forms.Button();
            this.MostrarAssistenciasListView = new System.Windows.Forms.ListView();
            this.DetalhadaButton = new System.Windows.Forms.Button();
            this.detalhadaTextBox = new System.Windows.Forms.TextBox();
            this.regrasDeNegocioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.regrasDeNegocioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TodasAssistButton
            // 
            this.TodasAssistButton.Location = new System.Drawing.Point(85, 31);
            this.TodasAssistButton.Margin = new System.Windows.Forms.Padding(2);
            this.TodasAssistButton.Name = "TodasAssistButton";
            this.TodasAssistButton.Size = new System.Drawing.Size(146, 32);
            this.TodasAssistButton.TabIndex = 0;
            this.TodasAssistButton.Text = "Todas as Assistencias";
            this.TodasAssistButton.UseVisualStyleBackColor = true;
            this.TodasAssistButton.Click += new System.EventHandler(this.TodasAssistButton_Click);
            // 
            // ApenasConcluidasButton
            // 
            this.ApenasConcluidasButton.Location = new System.Drawing.Point(294, 31);
            this.ApenasConcluidasButton.Margin = new System.Windows.Forms.Padding(2);
            this.ApenasConcluidasButton.Name = "ApenasConcluidasButton";
            this.ApenasConcluidasButton.Size = new System.Drawing.Size(146, 32);
            this.ApenasConcluidasButton.TabIndex = 1;
            this.ApenasConcluidasButton.Text = "Apenas Concluidas";
            this.ApenasConcluidasButton.UseVisualStyleBackColor = true;
            this.ApenasConcluidasButton.Click += new System.EventHandler(this.ApenasConcluidasButton_Click);
            // 
            // PorConcluirButton
            // 
            this.PorConcluirButton.Location = new System.Drawing.Point(506, 31);
            this.PorConcluirButton.Margin = new System.Windows.Forms.Padding(2);
            this.PorConcluirButton.Name = "PorConcluirButton";
            this.PorConcluirButton.Size = new System.Drawing.Size(146, 32);
            this.PorConcluirButton.TabIndex = 2;
            this.PorConcluirButton.Text = "Por Concluir";
            this.PorConcluirButton.UseVisualStyleBackColor = true;
            this.PorConcluirButton.Click += new System.EventHandler(this.PorConcluirButton_Click);
            // 
            // MostrarAssistenciasListView
            // 
            this.MostrarAssistenciasListView.HideSelection = false;
            this.MostrarAssistenciasListView.Location = new System.Drawing.Point(85, 97);
            this.MostrarAssistenciasListView.Name = "MostrarAssistenciasListView";
            this.MostrarAssistenciasListView.Size = new System.Drawing.Size(780, 238);
            this.MostrarAssistenciasListView.TabIndex = 5;
            this.MostrarAssistenciasListView.UseCompatibleStateImageBehavior = false;
            // 
            // DetalhadaButton
            // 
            this.DetalhadaButton.Location = new System.Drawing.Point(719, 31);
            this.DetalhadaButton.Margin = new System.Windows.Forms.Padding(2);
            this.DetalhadaButton.Name = "DetalhadaButton";
            this.DetalhadaButton.Size = new System.Drawing.Size(146, 32);
            this.DetalhadaButton.TabIndex = 6;
            this.DetalhadaButton.Text = "Detalhada";
            this.DetalhadaButton.UseVisualStyleBackColor = true;
            this.DetalhadaButton.Click += new System.EventHandler(this.DetalhadaButton_Click);
            // 
            // detalhadaTextBox
            // 
            this.detalhadaTextBox.Location = new System.Drawing.Point(742, 68);
            this.detalhadaTextBox.Name = "detalhadaTextBox";
            this.detalhadaTextBox.Size = new System.Drawing.Size(100, 20);
            this.detalhadaTextBox.TabIndex = 7;
            this.detalhadaTextBox.Visible = false;
            // 
            // regrasDeNegocioBindingSource
            // 
            this.regrasDeNegocioBindingSource.DataSource = typeof(RegrasNegocio.RegrasDeNegocio);
            // 
            // ApresentarAssist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(922, 366);
            this.Controls.Add(this.detalhadaTextBox);
            this.Controls.Add(this.DetalhadaButton);
            this.Controls.Add(this.MostrarAssistenciasListView);
            this.Controls.Add(this.PorConcluirButton);
            this.Controls.Add(this.ApenasConcluidasButton);
            this.Controls.Add(this.TodasAssistButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ApresentarAssist";
            this.Text = "Apresentar Assistências";
            ((System.ComponentModel.ISupportInitialize)(this.regrasDeNegocioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TodasAssistButton;
        private System.Windows.Forms.Button ApenasConcluidasButton;
        private System.Windows.Forms.Button PorConcluirButton;
        private System.Windows.Forms.BindingSource regrasDeNegocioBindingSource;
        private System.Windows.Forms.ListView MostrarAssistenciasListView;
        private System.Windows.Forms.Button DetalhadaButton;
        private System.Windows.Forms.TextBox detalhadaTextBox;
    }
}
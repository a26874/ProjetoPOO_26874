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
            this.MostrarAssistenciasGrid = new System.Windows.Forms.DataGridView();
            this.testeButton = new System.Windows.Forms.Button();
            this.regrasDeNegocioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MostrarAssistenciasGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regrasDeNegocioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TodasAssistButton
            // 
            this.TodasAssistButton.Location = new System.Drawing.Point(311, 50);
            this.TodasAssistButton.Name = "TodasAssistButton";
            this.TodasAssistButton.Size = new System.Drawing.Size(155, 39);
            this.TodasAssistButton.TabIndex = 0;
            this.TodasAssistButton.Text = "Todas as Assistencias";
            this.TodasAssistButton.UseVisualStyleBackColor = true;
            // 
            // ApenasConcluidasButton
            // 
            this.ApenasConcluidasButton.Location = new System.Drawing.Point(515, 50);
            this.ApenasConcluidasButton.Name = "ApenasConcluidasButton";
            this.ApenasConcluidasButton.Size = new System.Drawing.Size(155, 39);
            this.ApenasConcluidasButton.TabIndex = 1;
            this.ApenasConcluidasButton.Text = "Apenas Concluidas";
            this.ApenasConcluidasButton.UseVisualStyleBackColor = true;
            // 
            // PorConcluirButton
            // 
            this.PorConcluirButton.Location = new System.Drawing.Point(733, 50);
            this.PorConcluirButton.Name = "PorConcluirButton";
            this.PorConcluirButton.Size = new System.Drawing.Size(155, 39);
            this.PorConcluirButton.TabIndex = 2;
            this.PorConcluirButton.Text = "Por Concluir";
            this.PorConcluirButton.UseVisualStyleBackColor = true;
            // 
            // MostrarAssistenciasGrid
            // 
            this.MostrarAssistenciasGrid.AutoGenerateColumns = false;
            this.MostrarAssistenciasGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MostrarAssistenciasGrid.DataSource = this.regrasDeNegocioBindingSource;
            this.MostrarAssistenciasGrid.Location = new System.Drawing.Point(42, 114);
            this.MostrarAssistenciasGrid.Name = "MostrarAssistenciasGrid";
            this.MostrarAssistenciasGrid.RowHeadersWidth = 51;
            this.MostrarAssistenciasGrid.RowTemplate.Height = 24;
            this.MostrarAssistenciasGrid.Size = new System.Drawing.Size(1175, 324);
            this.MostrarAssistenciasGrid.TabIndex = 3;
            // 
            // testeButton
            // 
            this.testeButton.Location = new System.Drawing.Point(113, 59);
            this.testeButton.Name = "testeButton";
            this.testeButton.Size = new System.Drawing.Size(75, 23);
            this.testeButton.TabIndex = 4;
            this.testeButton.Text = "teste";
            this.testeButton.UseVisualStyleBackColor = true;
            this.testeButton.Click += new System.EventHandler(this.testeButton_Click);
            // 
            // regrasDeNegocioBindingSource
            // 
            this.regrasDeNegocioBindingSource.DataSource = typeof(RegrasNegocio.RegrasDeNegocio);
            // 
            // ApresentarAssist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1229, 450);
            this.Controls.Add(this.testeButton);
            this.Controls.Add(this.MostrarAssistenciasGrid);
            this.Controls.Add(this.PorConcluirButton);
            this.Controls.Add(this.ApenasConcluidasButton);
            this.Controls.Add(this.TodasAssistButton);
            this.Name = "ApresentarAssist";
            this.Text = "Apresentar Assistências";
            ((System.ComponentModel.ISupportInitialize)(this.MostrarAssistenciasGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regrasDeNegocioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TodasAssistButton;
        private System.Windows.Forms.Button ApenasConcluidasButton;
        private System.Windows.Forms.Button PorConcluirButton;
        private System.Windows.Forms.DataGridView MostrarAssistenciasGrid;
        private System.Windows.Forms.BindingSource regrasDeNegocioBindingSource;
        private System.Windows.Forms.Button testeButton;
    }
}
namespace Desktop
{
    partial class MenuAssistencia
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
            this.InsereAssistButton = new System.Windows.Forms.Button();
            this.RemoverAssistButton = new System.Windows.Forms.Button();
            this.ApresentaAssistButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InsereAssistButton
            // 
            this.InsereAssistButton.Location = new System.Drawing.Point(44, 55);
            this.InsereAssistButton.Name = "InsereAssistButton";
            this.InsereAssistButton.Size = new System.Drawing.Size(211, 45);
            this.InsereAssistButton.TabIndex = 0;
            this.InsereAssistButton.Text = "Inserir Assistencia";
            this.InsereAssistButton.UseVisualStyleBackColor = true;
            this.InsereAssistButton.Click += new System.EventHandler(this.InsereAssistButton_Click);
            // 
            // RemoverAssistButton
            // 
            this.RemoverAssistButton.Location = new System.Drawing.Point(44, 184);
            this.RemoverAssistButton.Name = "RemoverAssistButton";
            this.RemoverAssistButton.Size = new System.Drawing.Size(211, 45);
            this.RemoverAssistButton.TabIndex = 1;
            this.RemoverAssistButton.Text = "Remover Assistencia";
            this.RemoverAssistButton.UseVisualStyleBackColor = true;
            // 
            // ApresentaAssistButton
            // 
            this.ApresentaAssistButton.Location = new System.Drawing.Point(44, 318);
            this.ApresentaAssistButton.Name = "ApresentaAssistButton";
            this.ApresentaAssistButton.Size = new System.Drawing.Size(211, 45);
            this.ApresentaAssistButton.TabIndex = 2;
            this.ApresentaAssistButton.Text = "Apresentar Assistencias";
            this.ApresentaAssistButton.UseVisualStyleBackColor = true;
            this.ApresentaAssistButton.Click += new System.EventHandler(this.ApresentaAssistButton_Click);
            // 
            // MenuAssistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ApresentaAssistButton);
            this.Controls.Add(this.RemoverAssistButton);
            this.Controls.Add(this.InsereAssistButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuAssistencia";
            this.Text = "MenuAssistencia";
            this.Load += new System.EventHandler(this.MenuAssistencia_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InsereAssistButton;
        private System.Windows.Forms.Button RemoverAssistButton;
        private System.Windows.Forms.Button ApresentaAssistButton;
    }
}
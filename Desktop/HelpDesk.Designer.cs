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
            this.InsereAssistButton = new System.Windows.Forms.Button();
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
            // HelpDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.InsereAssistButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HelpDesk";
            this.Text = "HelpDesk";
            this.Load += new System.EventHandler(this.HelpDesk_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InsereAssistButton;
    }
}
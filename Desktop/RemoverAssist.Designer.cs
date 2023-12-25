namespace Desktop
{
    partial class RemoverAssist
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
            this.RemoverAssistLabel = new System.Windows.Forms.Label();
            this.textBoxRemoverAssist = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RemoverAssistLabel
            // 
            this.RemoverAssistLabel.AutoSize = true;
            this.RemoverAssistLabel.Location = new System.Drawing.Point(75, 45);
            this.RemoverAssistLabel.Name = "RemoverAssistLabel";
            this.RemoverAssistLabel.Size = new System.Drawing.Size(58, 13);
            this.RemoverAssistLabel.TabIndex = 0;
            this.RemoverAssistLabel.Text = "Insira o ID:";
            // 
            // textBoxRemoverAssist
            // 
            this.textBoxRemoverAssist.Location = new System.Drawing.Point(56, 80);
            this.textBoxRemoverAssist.Name = "textBoxRemoverAssist";
            this.textBoxRemoverAssist.Size = new System.Drawing.Size(100, 20);
            this.textBoxRemoverAssist.TabIndex = 1;
            this.textBoxRemoverAssist.TextChanged += new System.EventHandler(this.textBoxRemoverAssist_TextChanged);
            // 
            // RemoverAssist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 183);
            this.Controls.Add(this.textBoxRemoverAssist);
            this.Controls.Add(this.RemoverAssistLabel);
            this.Name = "RemoverAssist";
            this.Text = "RemoverAssist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RemoverAssistLabel;
        private System.Windows.Forms.TextBox textBoxRemoverAssist;
    }
}
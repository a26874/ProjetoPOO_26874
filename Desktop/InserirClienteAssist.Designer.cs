namespace Desktop
{
    partial class InserirClienteAssist
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
            this.inserirClienteAssistButton = new System.Windows.Forms.Button();
            this.inserirClienteNIFAssistTextBox = new System.Windows.Forms.TextBox();
            this.inserirClienteNIFAssistLabel = new System.Windows.Forms.Label();
            this.inserirClienteAssistIDLabel = new System.Windows.Forms.Label();
            this.inserirClienteAssistIDTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inserirClienteAssistButton
            // 
            this.inserirClienteAssistButton.Location = new System.Drawing.Point(52, 181);
            this.inserirClienteAssistButton.Name = "inserirClienteAssistButton";
            this.inserirClienteAssistButton.Size = new System.Drawing.Size(100, 23);
            this.inserirClienteAssistButton.TabIndex = 2;
            this.inserirClienteAssistButton.Text = "Inserir";
            this.inserirClienteAssistButton.UseVisualStyleBackColor = true;
            this.inserirClienteAssistButton.Click += new System.EventHandler(this.inserirClienteAssistButton_Click);
            // 
            // inserirClienteNIFAssistTextBox
            // 
            this.inserirClienteNIFAssistTextBox.Location = new System.Drawing.Point(52, 132);
            this.inserirClienteNIFAssistTextBox.Name = "inserirClienteNIFAssistTextBox";
            this.inserirClienteNIFAssistTextBox.Size = new System.Drawing.Size(100, 20);
            this.inserirClienteNIFAssistTextBox.TabIndex = 1;
            // 
            // inserirClienteNIFAssistLabel
            // 
            this.inserirClienteNIFAssistLabel.AutoSize = true;
            this.inserirClienteNIFAssistLabel.Location = new System.Drawing.Point(64, 101);
            this.inserirClienteNIFAssistLabel.Name = "inserirClienteNIFAssistLabel";
            this.inserirClienteNIFAssistLabel.Size = new System.Drawing.Size(62, 13);
            this.inserirClienteNIFAssistLabel.TabIndex = 2;
            this.inserirClienteNIFAssistLabel.Text = "NIF Cliente:";
            // 
            // inserirClienteAssistIDLabel
            // 
            this.inserirClienteAssistIDLabel.AutoSize = true;
            this.inserirClienteAssistIDLabel.Location = new System.Drawing.Point(64, 28);
            this.inserirClienteAssistIDLabel.Name = "inserirClienteAssistIDLabel";
            this.inserirClienteAssistIDLabel.Size = new System.Drawing.Size(77, 13);
            this.inserirClienteAssistIDLabel.TabIndex = 3;
            this.inserirClienteAssistIDLabel.Text = "ID Assistência:";
            // 
            // inserirClienteAssistIDTextBox
            // 
            this.inserirClienteAssistIDTextBox.Location = new System.Drawing.Point(52, 63);
            this.inserirClienteAssistIDTextBox.Name = "inserirClienteAssistIDTextBox";
            this.inserirClienteAssistIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.inserirClienteAssistIDTextBox.TabIndex = 0;
            // 
            // InserirClienteAssist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 247);
            this.Controls.Add(this.inserirClienteAssistIDTextBox);
            this.Controls.Add(this.inserirClienteAssistIDLabel);
            this.Controls.Add(this.inserirClienteNIFAssistLabel);
            this.Controls.Add(this.inserirClienteNIFAssistTextBox);
            this.Controls.Add(this.inserirClienteAssistButton);
            this.Name = "InserirClienteAssist";
            this.Text = "InserirClienteAssist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inserirClienteAssistButton;
        private System.Windows.Forms.TextBox inserirClienteNIFAssistTextBox;
        private System.Windows.Forms.Label inserirClienteNIFAssistLabel;
        private System.Windows.Forms.Label inserirClienteAssistIDLabel;
        private System.Windows.Forms.TextBox inserirClienteAssistIDTextBox;
    }
}
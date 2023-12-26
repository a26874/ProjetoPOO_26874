namespace Desktop
{
    partial class InserirOperadorAssist
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
            this.inserirOperadorAssistButton = new System.Windows.Forms.Button();
            this.inserirOperadorAssistIDTextBox = new System.Windows.Forms.TextBox();
            this.inserirOperadorIDAssistTextBox = new System.Windows.Forms.TextBox();
            this.inserirOperadorIDAssistLabel = new System.Windows.Forms.Label();
            this.inserirOperadorAssistIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inserirOperadorAssistButton
            // 
            this.inserirOperadorAssistButton.Location = new System.Drawing.Point(79, 197);
            this.inserirOperadorAssistButton.Name = "inserirOperadorAssistButton";
            this.inserirOperadorAssistButton.Size = new System.Drawing.Size(75, 23);
            this.inserirOperadorAssistButton.TabIndex = 2;
            this.inserirOperadorAssistButton.Text = "Inserir";
            this.inserirOperadorAssistButton.UseVisualStyleBackColor = true;
            this.inserirOperadorAssistButton.Click += new System.EventHandler(this.inserirOperadorAssistButton_Click);
            // 
            // inserirOperadorAssistIDTextBox
            // 
            this.inserirOperadorAssistIDTextBox.Location = new System.Drawing.Point(69, 58);
            this.inserirOperadorAssistIDTextBox.Name = "inserirOperadorAssistIDTextBox";
            this.inserirOperadorAssistIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.inserirOperadorAssistIDTextBox.TabIndex = 0;
            // 
            // inserirOperadorIDAssistTextBox
            // 
            this.inserirOperadorIDAssistTextBox.Location = new System.Drawing.Point(69, 148);
            this.inserirOperadorIDAssistTextBox.Name = "inserirOperadorIDAssistTextBox";
            this.inserirOperadorIDAssistTextBox.Size = new System.Drawing.Size(100, 20);
            this.inserirOperadorIDAssistTextBox.TabIndex = 1;
            // 
            // inserirOperadorIDAssistLabel
            // 
            this.inserirOperadorIDAssistLabel.AutoSize = true;
            this.inserirOperadorIDAssistLabel.Location = new System.Drawing.Point(66, 113);
            this.inserirOperadorIDAssistLabel.Name = "inserirOperadorIDAssistLabel";
            this.inserirOperadorIDAssistLabel.Size = new System.Drawing.Size(68, 13);
            this.inserirOperadorIDAssistLabel.TabIndex = 3;
            this.inserirOperadorIDAssistLabel.Text = "ID Operador:";
            // 
            // inserirOperadorAssistIDLabel
            // 
            this.inserirOperadorAssistIDLabel.AutoSize = true;
            this.inserirOperadorAssistIDLabel.Location = new System.Drawing.Point(66, 20);
            this.inserirOperadorAssistIDLabel.Name = "inserirOperadorAssistIDLabel";
            this.inserirOperadorAssistIDLabel.Size = new System.Drawing.Size(77, 13);
            this.inserirOperadorAssistIDLabel.TabIndex = 4;
            this.inserirOperadorAssistIDLabel.Text = "ID Assistência:";
            // 
            // InserirOperadorAssist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 257);
            this.Controls.Add(this.inserirOperadorAssistIDLabel);
            this.Controls.Add(this.inserirOperadorIDAssistLabel);
            this.Controls.Add(this.inserirOperadorIDAssistTextBox);
            this.Controls.Add(this.inserirOperadorAssistIDTextBox);
            this.Controls.Add(this.inserirOperadorAssistButton);
            this.Name = "InserirOperadorAssist";
            this.Text = "InserirOperadorAssist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inserirOperadorAssistButton;
        private System.Windows.Forms.TextBox inserirOperadorAssistIDTextBox;
        private System.Windows.Forms.TextBox inserirOperadorIDAssistTextBox;
        private System.Windows.Forms.Label inserirOperadorIDAssistLabel;
        private System.Windows.Forms.Label inserirOperadorAssistIDLabel;
    }
}
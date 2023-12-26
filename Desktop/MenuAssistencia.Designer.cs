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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAssistencia));
            this.InsereAssistButton = new System.Windows.Forms.Button();
            this.RemoverAssistButton = new System.Windows.Forms.Button();
            this.ApresentaAssistButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerDataHora = new System.Windows.Forms.Timer(this.components);
            this.DataHoraLabel = new System.Windows.Forms.Label();
            this.inserirClienteButton = new System.Windows.Forms.Button();
            this.inserirOperadorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // InsereAssistButton
            // 
            this.InsereAssistButton.Location = new System.Drawing.Point(36, 51);
            this.InsereAssistButton.Margin = new System.Windows.Forms.Padding(2);
            this.InsereAssistButton.Name = "InsereAssistButton";
            this.InsereAssistButton.Size = new System.Drawing.Size(158, 37);
            this.InsereAssistButton.TabIndex = 0;
            this.InsereAssistButton.Text = "Inserir Assistencia";
            this.InsereAssistButton.UseVisualStyleBackColor = true;
            this.InsereAssistButton.Click += new System.EventHandler(this.InsereAssistButton_Click);
            // 
            // RemoverAssistButton
            // 
            this.RemoverAssistButton.Location = new System.Drawing.Point(36, 114);
            this.RemoverAssistButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoverAssistButton.Name = "RemoverAssistButton";
            this.RemoverAssistButton.Size = new System.Drawing.Size(158, 37);
            this.RemoverAssistButton.TabIndex = 1;
            this.RemoverAssistButton.Text = "Remover Assistencia";
            this.RemoverAssistButton.UseVisualStyleBackColor = true;
            this.RemoverAssistButton.Click += new System.EventHandler(this.RemoverAssistButton_Click);
            // 
            // ApresentaAssistButton
            // 
            this.ApresentaAssistButton.Location = new System.Drawing.Point(36, 182);
            this.ApresentaAssistButton.Margin = new System.Windows.Forms.Padding(2);
            this.ApresentaAssistButton.Name = "ApresentaAssistButton";
            this.ApresentaAssistButton.Size = new System.Drawing.Size(158, 37);
            this.ApresentaAssistButton.TabIndex = 2;
            this.ApresentaAssistButton.Text = "Apresentar Assistencias";
            this.ApresentaAssistButton.UseVisualStyleBackColor = true;
            this.ApresentaAssistButton.Click += new System.EventHandler(this.ApresentaAssistButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(211, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 319);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // timerDataHora
            // 
            this.timerDataHora.Tick += new System.EventHandler(this.timerDataHora_Tick);
            // 
            // DataHoraLabel
            // 
            this.DataHoraLabel.AutoSize = true;
            this.DataHoraLabel.Location = new System.Drawing.Point(424, 428);
            this.DataHoraLabel.Name = "DataHoraLabel";
            this.DataHoraLabel.Size = new System.Drawing.Size(53, 13);
            this.DataHoraLabel.TabIndex = 4;
            this.DataHoraLabel.Text = "DataHora";
            // 
            // inserirClienteButton
            // 
            this.inserirClienteButton.Location = new System.Drawing.Point(36, 256);
            this.inserirClienteButton.Name = "inserirClienteButton";
            this.inserirClienteButton.Size = new System.Drawing.Size(158, 37);
            this.inserirClienteButton.TabIndex = 5;
            this.inserirClienteButton.Text = "Inserir Cliente";
            this.inserirClienteButton.UseVisualStyleBackColor = true;
            this.inserirClienteButton.Click += new System.EventHandler(this.inserirClienteButton_Click);
            // 
            // inserirOperadorButton
            // 
            this.inserirOperadorButton.Location = new System.Drawing.Point(36, 333);
            this.inserirOperadorButton.Name = "inserirOperadorButton";
            this.inserirOperadorButton.Size = new System.Drawing.Size(158, 37);
            this.inserirOperadorButton.TabIndex = 6;
            this.inserirOperadorButton.Text = "Inserir Operador";
            this.inserirOperadorButton.UseVisualStyleBackColor = true;
            this.inserirOperadorButton.Click += new System.EventHandler(this.inserirOperadorButton_Click);
            // 
            // MenuAssistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.inserirOperadorButton);
            this.Controls.Add(this.inserirClienteButton);
            this.Controls.Add(this.DataHoraLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ApresentaAssistButton);
            this.Controls.Add(this.RemoverAssistButton);
            this.Controls.Add(this.InsereAssistButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuAssistencia";
            this.Text = "MenuAssistencia";
            this.Load += new System.EventHandler(this.MenuAssistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InsereAssistButton;
        private System.Windows.Forms.Button RemoverAssistButton;
        private System.Windows.Forms.Button ApresentaAssistButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerDataHora;
        private System.Windows.Forms.Label DataHoraLabel;
        private System.Windows.Forms.Button inserirClienteButton;
        private System.Windows.Forms.Button inserirOperadorButton;
    }
}
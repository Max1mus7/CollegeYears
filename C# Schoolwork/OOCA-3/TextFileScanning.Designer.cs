namespace OOCA_3
{
    partial class TextFileScanning
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileButton = new System.Windows.Forms.Button();
            this.fileDisplay = new System.Windows.Forms.TextBox();
            this.statsDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fileButton
            // 
            this.fileButton.Location = new System.Drawing.Point(44, 33);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(120, 30);
            this.fileButton.TabIndex = 0;
            this.fileButton.Text = "Open File";
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // fileDisplay
            // 
            this.fileDisplay.Location = new System.Drawing.Point(412, 33);
            this.fileDisplay.Multiline = true;
            this.fileDisplay.Name = "fileDisplay";
            this.fileDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.fileDisplay.Size = new System.Drawing.Size(311, 114);
            this.fileDisplay.TabIndex = 1;
            // 
            // statsDisplay
            // 
            this.statsDisplay.Location = new System.Drawing.Point(412, 191);
            this.statsDisplay.Multiline = true;
            this.statsDisplay.Name = "statsDisplay";
            this.statsDisplay.Size = new System.Drawing.Size(314, 97);
            this.statsDisplay.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statsDisplay);
            this.Controls.Add(this.fileDisplay);
            this.Controls.Add(this.fileButton);
            this.Name = "Form1";
            this.Text = "File Opener";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.TextBox fileDisplay;
        private System.Windows.Forms.TextBox statsDisplay;
    }
}


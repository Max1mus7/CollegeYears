namespace HeroMaker
{
    partial class HeroList
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
            this.lbNames = new System.Windows.Forms.ListBox();
            this.tbHeroDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbNames
            // 
            this.lbNames.FormattingEnabled = true;
            this.lbNames.ItemHeight = 20;
            this.lbNames.Location = new System.Drawing.Point(24, 32);
            this.lbNames.Name = "lbNames";
            this.lbNames.Size = new System.Drawing.Size(150, 304);
            this.lbNames.TabIndex = 0;
            this.lbNames.SelectedIndexChanged += new System.EventHandler(this.lbNames_SelectedIndexChanged);
            // 
            // tbHeroDescription
            // 
            this.tbHeroDescription.Location = new System.Drawing.Point(210, 32);
            this.tbHeroDescription.Multiline = true;
            this.tbHeroDescription.Name = "tbHeroDescription";
            this.tbHeroDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbHeroDescription.Size = new System.Drawing.Size(426, 304);
            this.tbHeroDescription.TabIndex = 1;
            // 
            // HeroList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 375);
            this.Controls.Add(this.tbHeroDescription);
            this.Controls.Add(this.lbNames);
            this.Name = "HeroList";
            this.Text = "HeroList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNames;
        private System.Windows.Forms.TextBox tbHeroDescription;
    }
}
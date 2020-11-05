using System.Drawing;
using System.Windows.Forms;

namespace PEO_App
{
    partial class Form1
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
            this.baseballDiamond = new System.Windows.Forms.PictureBox();
            this.firstBaseLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.blueTeamLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.baseballDiamond)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseballDiamond
            // 
            this.baseballDiamond.BackColor = System.Drawing.SystemColors.Control;
            this.baseballDiamond.Enabled = false;
            this.baseballDiamond.Image = global::PEO_App.Properties.Resources.Baseball_Diamond;
            this.baseballDiamond.Location = new System.Drawing.Point(460, 67);
            this.baseballDiamond.Name = "baseballDiamond";
            this.baseballDiamond.Size = new System.Drawing.Size(874, 733);
            this.baseballDiamond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.baseballDiamond.TabIndex = 0;
            this.baseballDiamond.TabStop = false;
            // 
            // firstBaseLabel
            // 
            this.firstBaseLabel.AutoSize = true;
            this.firstBaseLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(203)))), ((int)(((byte)(130)))));
            this.firstBaseLabel.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstBaseLabel.Location = new System.Drawing.Point(1288, 479);
            this.firstBaseLabel.Name = "firstBaseLabel";
            this.firstBaseLabel.Size = new System.Drawing.Size(26, 16);
            this.firstBaseLabel.TabIndex = 1;
            this.firstBaseLabel.Text = "1B";
            this.firstBaseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.blueTeamLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 911);
            this.panel1.TabIndex = 2;
            // 
            // blueTeamLabel
            // 
            this.blueTeamLabel.AutoSize = true;
            this.blueTeamLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.blueTeamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueTeamLabel.Location = new System.Drawing.Point(3, 0);
            this.blueTeamLabel.Name = "blueTeamLabel";
            this.blueTeamLabel.Size = new System.Drawing.Size(191, 39);
            this.blueTeamLabel.TabIndex = 0;
            this.blueTeamLabel.Text = "Blue Team";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1513, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(355, 911);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "White Team";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1870, 890);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.firstBaseLabel);
            this.Controls.Add(this.baseballDiamond);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.baseballDiamond)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void GoFullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }
        #endregion

        private PictureBox baseballDiamond;
        private Label firstBaseLabel;
        private Panel panel1;
        private Label blueTeamLabel;
        private Panel panel2;
        private Label label1;
    }
}


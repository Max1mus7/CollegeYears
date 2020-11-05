

namespace ChessboardGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.rowIn = new System.Windows.Forms.TextBox();
            this.colIn = new System.Windows.Forms.TextBox();
            this.rowLabel = new System.Windows.Forms.Label();
            this.colLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 372);
            this.panel1.TabIndex = 0;
            // 
            // rowIn
            // 
            this.rowIn.Location = new System.Drawing.Point(407, 30);
            this.rowIn.Name = "rowIn";
            this.rowIn.Size = new System.Drawing.Size(25, 27);
            this.rowIn.TabIndex = 1;
            // 
            // colIn
            // 
            this.colIn.Location = new System.Drawing.Point(502, 30);
            this.colIn.Name = "colIn";
            this.colIn.Size = new System.Drawing.Size(24, 27);
            this.colIn.TabIndex = 2;
            // 
            // rowLabel
            // 
            this.rowLabel.AutoSize = true;
            this.rowLabel.Location = new System.Drawing.Point(360, 37);
            this.rowLabel.Name = "rowLabel";
            this.rowLabel.Size = new System.Drawing.Size(41, 20);
            this.rowLabel.TabIndex = 3;
            this.rowLabel.Text = "Row:";
            // 
            // colLabel
            // 
            this.colLabel.AutoSize = true;
            this.colLabel.Location = new System.Drawing.Point(433, 37);
            this.colLabel.Name = "colLabel";
            this.colLabel.Size = new System.Drawing.Size(63, 20);
            this.colLabel.TabIndex = 3;
            this.colLabel.Text = "Column:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please input the row and column you would\r\n like to move a piece to, then click y" +
    "our piece!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 596);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colLabel);
            this.Controls.Add(this.rowLabel);
            this.Controls.Add(this.colIn);
            this.Controls.Add(this.rowIn);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox rowIn;
        private System.Windows.Forms.TextBox colIn;
        private System.Windows.Forms.Label rowLabel;
        private System.Windows.Forms.Label colLabel;
        private System.Windows.Forms.Label label1;
    }
}


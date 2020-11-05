namespace MinesweeperGUI
{
    partial class frmResult
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
            this.btnTryAgain = new System.Windows.Forms.Button();
            this.btnTryAgainButDifferent = new System.Windows.Forms.Button();
            this.btnCloseAll = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTryAgain
            // 
            this.btnTryAgain.Location = new System.Drawing.Point(53, 196);
            this.btnTryAgain.Name = "btnTryAgain";
            this.btnTryAgain.Size = new System.Drawing.Size(264, 29);
            this.btnTryAgain.TabIndex = 1;
            this.btnTryAgain.Text = "Try Again";
            this.btnTryAgain.UseVisualStyleBackColor = true;
            this.btnTryAgain.Click += new System.EventHandler(this.btnTryAgain_Click);
            // 
            // btnTryAgainButDifferent
            // 
            this.btnTryAgainButDifferent.Location = new System.Drawing.Point(53, 231);
            this.btnTryAgainButDifferent.Name = "btnTryAgainButDifferent";
            this.btnTryAgainButDifferent.Size = new System.Drawing.Size(264, 29);
            this.btnTryAgainButDifferent.TabIndex = 2;
            this.btnTryAgainButDifferent.Text = "Try Again with Different Numbers";
            this.btnTryAgainButDifferent.UseVisualStyleBackColor = true;
            this.btnTryAgainButDifferent.Click += new System.EventHandler(this.btnTryAgainButDifferent_Click);
            // 
            // btnCloseAll
            // 
            this.btnCloseAll.Location = new System.Drawing.Point(53, 267);
            this.btnCloseAll.Name = "btnCloseAll";
            this.btnCloseAll.Size = new System.Drawing.Size(264, 29);
            this.btnCloseAll.TabIndex = 3;
            this.btnCloseAll.Text = "Close All";
            this.btnCloseAll.UseVisualStyleBackColor = true;
            this.btnCloseAll.Click += new System.EventHandler(this.btnCloseAll_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(53, 27);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 20);
            this.lblMessage.TabIndex = 4;
            // 
            // frmResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 405);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnCloseAll);
            this.Controls.Add(this.btnTryAgainButDifferent);
            this.Controls.Add(this.btnTryAgain);
            this.Name = "frmResult";
            this.Text = "frmResult";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTryAgain;
        private System.Windows.Forms.Button btnTryAgainButDifferent;
        private System.Windows.Forms.Button btnCloseAll;
        private System.Windows.Forms.Label lblMessage;
    }
}
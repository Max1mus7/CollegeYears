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
            this.lblCongrats = new System.Windows.Forms.Label();
            this.lblInitials = new System.Windows.Forms.Label();
            this.tbInitials = new System.Windows.Forms.TextBox();
            this.btnAddScore = new System.Windows.Forms.Button();
            this.dgScores = new System.Windows.Forms.DataGridView();
            this.lblScoreText = new System.Windows.Forms.Label();
            this.lblScoreNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgScores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTryAgain
            // 
            this.btnTryAgain.Location = new System.Drawing.Point(307, 345);
            this.btnTryAgain.Name = "btnTryAgain";
            this.btnTryAgain.Size = new System.Drawing.Size(264, 29);
            this.btnTryAgain.TabIndex = 1;
            this.btnTryAgain.Text = "Try Again";
            this.btnTryAgain.UseVisualStyleBackColor = true;
            this.btnTryAgain.Click += new System.EventHandler(this.btnTryAgain_Click);
            // 
            // btnTryAgainButDifferent
            // 
            this.btnTryAgainButDifferent.Location = new System.Drawing.Point(307, 380);
            this.btnTryAgainButDifferent.Name = "btnTryAgainButDifferent";
            this.btnTryAgainButDifferent.Size = new System.Drawing.Size(264, 29);
            this.btnTryAgainButDifferent.TabIndex = 2;
            this.btnTryAgainButDifferent.Text = "Try Again with Different Numbers";
            this.btnTryAgainButDifferent.UseVisualStyleBackColor = true;
            this.btnTryAgainButDifferent.Click += new System.EventHandler(this.btnTryAgainButDifferent_Click);
            // 
            // btnCloseAll
            // 
            this.btnCloseAll.Location = new System.Drawing.Point(307, 416);
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
            // lblCongrats
            // 
            this.lblCongrats.AutoSize = true;
            this.lblCongrats.Location = new System.Drawing.Point(12, 278);
            this.lblCongrats.Name = "lblCongrats";
            this.lblCongrats.Size = new System.Drawing.Size(193, 40);
            this.lblCongrats.TabIndex = 4;
            this.lblCongrats.Text = "Congratulations! Enter your \ninitials to save your score!";
            // 
            // lblInitials
            // 
            this.lblInitials.AutoSize = true;
            this.lblInitials.Location = new System.Drawing.Point(57, 374);
            this.lblInitials.Name = "lblInitials";
            this.lblInitials.Size = new System.Drawing.Size(55, 20);
            this.lblInitials.TabIndex = 3;
            this.lblInitials.Text = "Initials:";
            // 
            // tbInitials
            // 
            this.tbInitials.Location = new System.Drawing.Point(57, 397);
            this.tbInitials.Name = "tbInitials";
            this.tbInitials.Size = new System.Drawing.Size(125, 27);
            this.tbInitials.TabIndex = 2;
            this.tbInitials.TextChanged += new System.EventHandler(this.tbInitials_TextChanged);
            // 
            // btnAddScore
            // 
            this.btnAddScore.Location = new System.Drawing.Point(74, 430);
            this.btnAddScore.Name = "btnAddScore";
            this.btnAddScore.Size = new System.Drawing.Size(94, 29);
            this.btnAddScore.TabIndex = 1;
            this.btnAddScore.Text = "Submit";
            this.btnAddScore.UseVisualStyleBackColor = true;
            this.btnAddScore.Click += new System.EventHandler(this.btnAddScore_Click);
            // 
            // dgScores
            // 
            this.dgScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgScores.Location = new System.Drawing.Point(13, 13);
            this.dgScores.Name = "dgScores";
            this.dgScores.RowHeadersWidth = 51;
            this.dgScores.Size = new System.Drawing.Size(649, 249);
            this.dgScores.TabIndex = 5;
            this.dgScores.Text = "dataGridView1";
            // 
            // lblScoreText
            // 
            this.lblScoreText.AutoSize = true;
            this.lblScoreText.Location = new System.Drawing.Point(57, 345);
            this.lblScoreText.Name = "lblScoreText";
            this.lblScoreText.Size = new System.Drawing.Size(49, 20);
            this.lblScoreText.TabIndex = 6;
            this.lblScoreText.Text = "Score:";
            // 
            // lblScoreNum
            // 
            this.lblScoreNum.AutoSize = true;
            this.lblScoreNum.Location = new System.Drawing.Point(112, 345);
            this.lblScoreNum.Name = "lblScoreNum";
            this.lblScoreNum.Size = new System.Drawing.Size(0, 20);
            this.lblScoreNum.TabIndex = 7;
            // 
            // frmResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 464);
            this.Controls.Add(this.lblScoreNum);
            this.Controls.Add(this.lblScoreText);
            this.Controls.Add(this.dgScores);
            this.Controls.Add(this.btnAddScore);
            this.Controls.Add(this.tbInitials);
            this.Controls.Add(this.lblInitials);
            this.Controls.Add(this.lblCongrats);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnCloseAll);
            this.Controls.Add(this.btnTryAgainButDifferent);
            this.Controls.Add(this.btnTryAgain);
            this.Name = "frmResult";
            this.Text = "frmResult";
            ((System.ComponentModel.ISupportInitialize)(this.dgScores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTryAgain;
        private System.Windows.Forms.Button btnTryAgainButDifferent;
        private System.Windows.Forms.Button btnCloseAll;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblCongrats;
        private System.Windows.Forms.Label lblInitials;
        private System.Windows.Forms.TextBox tbInitials;
        private System.Windows.Forms.Button btnAddScore;
        private System.Windows.Forms.DataGridView dgScores;
        private System.Windows.Forms.Label lblScoreText;
        private System.Windows.Forms.Label lblScoreNum;
    }
}
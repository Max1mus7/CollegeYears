namespace MinesweeperGUI
{
    partial class frmGamePrep
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
            this.tbarGridSize = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGridSize = new System.Windows.Forms.Label();
            this.btnPassToGUI2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbarGridSize)).BeginInit();
            this.SuspendLayout();
            // 
            // tbarGridSize
            // 
            this.tbarGridSize.Location = new System.Drawing.Point(103, 51);
            this.tbarGridSize.Maximum = 30;
            this.tbarGridSize.Minimum = 8;
            this.tbarGridSize.Name = "tbarGridSize";
            this.tbarGridSize.Size = new System.Drawing.Size(563, 56);
            this.tbarGridSize.TabIndex = 0;
            this.tbarGridSize.Value = 8;
            this.tbarGridSize.Scroll += new System.EventHandler(this.tbarGridSize_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(103, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Minesweeper Difficulty:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(103, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(527, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "The higher the difficulty, the bigger the board!";
            // 
            // lblGridSize
            // 
            this.lblGridSize.AutoSize = true;
            this.lblGridSize.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGridSize.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGridSize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGridSize.Location = new System.Drawing.Point(479, 2);
            this.lblGridSize.Name = "lblGridSize";
            this.lblGridSize.Size = new System.Drawing.Size(0, 46);
            this.lblGridSize.TabIndex = 3;
            // 
            // btnPassToGUI2
            // 
            this.btnPassToGUI2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPassToGUI2.Location = new System.Drawing.Point(267, 197);
            this.btnPassToGUI2.Name = "btnPassToGUI2";
            this.btnPassToGUI2.Size = new System.Drawing.Size(212, 47);
            this.btnPassToGUI2.TabIndex = 4;
            this.btnPassToGUI2.Text = "Start Game";
            this.btnPassToGUI2.UseVisualStyleBackColor = true;
            this.btnPassToGUI2.Click += new System.EventHandler(this.btnPassToGUI2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(103, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(422, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Choose a number between 8 and 30!";
            // 
            // frmGamePrep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPassToGUI2);
            this.Controls.Add(this.lblGridSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbarGridSize);
            this.Name = "frmGamePrep";
            this.Text = "Minesweeper Prep";
            ((System.ComponentModel.ISupportInitialize)(this.tbarGridSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbarGridSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGridSize;
        private System.Windows.Forms.Button btnPassToGUI2;
        private System.Windows.Forms.Label label3;
    }
}


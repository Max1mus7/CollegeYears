namespace Milestone4Wed
{
    partial class frmGUI1
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
            this.label1.Size = new System.Drawing.Size(361, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Minesweeper Grid Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(103, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(455, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Change prop Min from 8 and Max to 30";
            // 
            // lblGridSize
            // 
            this.lblGridSize.AutoSize = true;
            this.lblGridSize.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblGridSize.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGridSize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGridSize.Location = new System.Drawing.Point(685, 51);
            this.lblGridSize.Name = "lblGridSize";
            this.lblGridSize.Size = new System.Drawing.Size(0, 46);
            this.lblGridSize.TabIndex = 3;
            // 
            // btnPassToGUI2
            // 
            this.btnPassToGUI2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPassToGUI2.Location = new System.Drawing.Point(295, 195);
            this.btnPassToGUI2.Name = "btnPassToGUI2";
            this.btnPassToGUI2.Size = new System.Drawing.Size(212, 47);
            this.btnPassToGUI2.TabIndex = 4;
            this.btnPassToGUI2.Text = "Pass to GUI 2";
            this.btnPassToGUI2.UseVisualStyleBackColor = true;
            this.btnPassToGUI2.Click += new System.EventHandler(this.btnPassToGUI2_Click);
            // 
            // frmGUI1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPassToGUI2);
            this.Controls.Add(this.lblGridSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbarGridSize);
            this.Name = "frmGUI1";
            this.Text = "GUI One";
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
    }
}


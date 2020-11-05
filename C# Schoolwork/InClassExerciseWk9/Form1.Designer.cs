namespace InClassExerciseWk9
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
            this.components = new System.ComponentModel.Container();
            this.btnSetProp = new System.Windows.Forms.Button();
            this.btnChanged = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblScoreFrm = new System.Windows.Forms.Label();
            this.lblScoreBtn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStopWatch = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblElapsedTime = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSetProp
            // 
            this.btnSetProp.Location = new System.Drawing.Point(37, 13);
            this.btnSetProp.Name = "btnSetProp";
            this.btnSetProp.Size = new System.Drawing.Size(94, 29);
            this.btnSetProp.TabIndex = 0;
            this.btnSetProp.Text = "Set Button Properties";
            this.btnSetProp.UseVisualStyleBackColor = true;
            this.btnSetProp.Click += new System.EventHandler(this.btnSetProp_Click);
            // 
            // btnChanged
            // 
            this.btnChanged.Location = new System.Drawing.Point(37, 95);
            this.btnChanged.Name = "btnChanged";
            this.btnChanged.Size = new System.Drawing.Size(94, 29);
            this.btnChanged.TabIndex = 1;
            this.btnChanged.Text = "button2";
            this.btnChanged.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblScoreFrm);
            this.panel1.Controls.Add(this.lblScoreBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(187, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 207);
            this.panel1.TabIndex = 2;
            // 
            // lblScoreFrm
            // 
            this.lblScoreFrm.AutoSize = true;
            this.lblScoreFrm.Location = new System.Drawing.Point(501, 91);
            this.lblScoreFrm.Name = "lblScoreFrm";
            this.lblScoreFrm.Size = new System.Drawing.Size(17, 20);
            this.lblScoreFrm.TabIndex = 4;
            this.lblScoreFrm.Text = "0";
            // 
            // lblScoreBtn
            // 
            this.lblScoreBtn.AutoSize = true;
            this.lblScoreBtn.Location = new System.Drawing.Point(59, 91);
            this.lblScoreBtn.Name = "lblScoreBtn";
            this.lblScoreBtn.Size = new System.Drawing.Size(17, 20);
            this.lblScoreBtn.TabIndex = 3;
            this.lblScoreBtn.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Form Clicks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Button Clicks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(258, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score";
            // 
            // lblStopWatch
            // 
            this.lblStopWatch.AutoSize = true;
            this.lblStopWatch.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStopWatch.Location = new System.Drawing.Point(187, 303);
            this.lblStopWatch.Name = "lblStopWatch";
            this.lblStopWatch.Size = new System.Drawing.Size(407, 89);
            this.lblStopWatch.TabIndex = 3;
            this.lblStopWatch.Text = "00:00:00.000";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(122, 271);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(94, 29);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(327, 271);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(94, 29);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(545, 271);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 29);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.AutoSize = true;
            this.lblElapsedTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblElapsedTime.Location = new System.Drawing.Point(545, 240);
            this.lblElapsedTime.Name = "lblElapsedTime";
            this.lblElapsedTime.Size = new System.Drawing.Size(123, 28);
            this.lblElapsedTime.TabIndex = 3;
            this.lblElapsedTime.Text = "00:00:00.000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblElapsedTime);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblStopWatch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnChanged);
            this.Controls.Add(this.btnSetProp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetProp;
        private System.Windows.Forms.Button btnChanged;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblScoreFrm;
        private System.Windows.Forms.Label lblScoreBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStopWatch;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblElapsedTime;
    }
}


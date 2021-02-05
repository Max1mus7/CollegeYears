namespace InClassExerciseWk10
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
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnAppend = new System.Windows.Forms.Button();
            this.btnScores = new System.Windows.Forms.Button();
            this.txtAppend = new System.Windows.Forms.TextBox();
            this.dgScores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgScores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(658, 12);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(110, 39);
            this.btnWrite.TabIndex = 0;
            this.btnWrite.Text = "Write to File";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnAppend
            // 
            this.btnAppend.Location = new System.Drawing.Point(636, 57);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(132, 47);
            this.btnAppend.TabIndex = 0;
            this.btnAppend.Text = "Append to File";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // btnScores
            // 
            this.btnScores.Location = new System.Drawing.Point(236, 22);
            this.btnScores.Name = "btnScores";
            this.btnScores.Size = new System.Drawing.Size(276, 49);
            this.btnScores.TabIndex = 0;
            this.btnScores.Text = "Show Scores With Highest First";
            this.btnScores.UseVisualStyleBackColor = true;
            this.btnScores.Click += new System.EventHandler(this.btnScores_Click);
            // 
            // txtAppend
            // 
            this.txtAppend.Location = new System.Drawing.Point(646, 134);
            this.txtAppend.Name = "txtAppend";
            this.txtAppend.Size = new System.Drawing.Size(122, 27);
            this.txtAppend.TabIndex = 1;
            // 
            // dgScores
            // 
            this.dgScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgScores.Location = new System.Drawing.Point(212, 93);
            this.dgScores.Name = "dgScores";
            this.dgScores.RowHeadersWidth = 51;
            this.dgScores.Size = new System.Drawing.Size(327, 358);
            this.dgScores.TabIndex = 2;
            this.dgScores.Text = "dataGridView1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgScores);
            this.Controls.Add(this.txtAppend);
            this.Controls.Add(this.btnScores);
            this.Controls.Add(this.btnAppend);
            this.Controls.Add(this.btnWrite);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgScores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.Button btnScores;
        private System.Windows.Forms.TextBox txtAppend;
        private System.Windows.Forms.DataGridView dgScores;
    }
}


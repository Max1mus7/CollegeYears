namespace CST_117_Out_Of_Class_Assignment_2
{
    partial class Shapes
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
            this.emptyButton = new System.Windows.Forms.RadioButton();
            this.shapesList = new System.Windows.Forms.ListBox();
            this.filledButton = new System.Windows.Forms.RadioButton();
            this.nameBox = new System.Windows.Forms.CheckBox();
            this.rotateBox = new System.Windows.Forms.CheckBox();
            this.imageWindow = new System.Windows.Forms.PictureBox();
            this.shapeNameDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // emptyButton
            // 
            this.emptyButton.AutoSize = true;
            this.emptyButton.Location = new System.Drawing.Point(49, 71);
            this.emptyButton.Name = "emptyButton";
            this.emptyButton.Size = new System.Drawing.Size(68, 21);
            this.emptyButton.TabIndex = 1;
            this.emptyButton.Text = "Empty";
            this.emptyButton.UseVisualStyleBackColor = true;
            this.emptyButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // shapesList
            // 
            this.shapesList.FormattingEnabled = true;
            this.shapesList.ItemHeight = 16;
            this.shapesList.Items.AddRange(new object[] {
            "Square",
            "Rectangle",
            "Circle",
            "Trapezoid",
            "Hexagon"});
            this.shapesList.Location = new System.Drawing.Point(49, 141);
            this.shapesList.Name = "shapesList";
            this.shapesList.Size = new System.Drawing.Size(120, 84);
            this.shapesList.TabIndex = 3;
            this.shapesList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // filledButton
            // 
            this.filledButton.AutoSize = true;
            this.filledButton.Checked = global::CST_117_Out_Of_Class_Assignment_2.Properties.Settings.Default.Start;
            this.filledButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::CST_117_Out_Of_Class_Assignment_2.Properties.Settings.Default, "Start", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.filledButton.Location = new System.Drawing.Point(49, 44);
            this.filledButton.Name = "filledButton";
            this.filledButton.Size = new System.Drawing.Size(58, 21);
            this.filledButton.TabIndex = 0;
            this.filledButton.TabStop = true;
            this.filledButton.Text = "Filled";
            this.filledButton.UseCompatibleTextRendering = true;
            this.filledButton.UseVisualStyleBackColor = true;
            this.filledButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // nameBox
            // 
            this.nameBox.AutoSize = true;
            this.nameBox.Location = new System.Drawing.Point(49, 275);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(105, 21);
            this.nameBox.TabIndex = 4;
            this.nameBox.Text = "Show Name";
            this.nameBox.UseVisualStyleBackColor = true;
            this.nameBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // rotateBox
            // 
            this.rotateBox.AutoSize = true;
            this.rotateBox.Location = new System.Drawing.Point(49, 315);
            this.rotateBox.Name = "rotateBox";
            this.rotateBox.Size = new System.Drawing.Size(72, 21);
            this.rotateBox.TabIndex = 5;
            this.rotateBox.Text = "Rotate";
            this.rotateBox.UseVisualStyleBackColor = true;
            this.rotateBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // imageWindow
            // 
            this.imageWindow.Location = new System.Drawing.Point(250, 44);
            this.imageWindow.Name = "imageWindow";
            this.imageWindow.Size = new System.Drawing.Size(538, 394);
            this.imageWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageWindow.TabIndex = 2;
            this.imageWindow.TabStop = false;
            this.imageWindow.Click += new System.EventHandler(this.imageWindow_Click);
            // 
            // shapeNameDisplay
            // 
            this.shapeNameDisplay.AutoSize = true;
            this.shapeNameDisplay.Location = new System.Drawing.Point(533, 9);
            this.shapeNameDisplay.Name = "shapeNameDisplay";
            this.shapeNameDisplay.Size = new System.Drawing.Size(0, 17);
            this.shapeNameDisplay.TabIndex = 6;
            // 
            // Shapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shapeNameDisplay);
            this.Controls.Add(this.rotateBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.shapesList);
            this.Controls.Add(this.imageWindow);
            this.Controls.Add(this.emptyButton);
            this.Controls.Add(this.filledButton);
            this.Name = "Shapes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton filledButton;
        private System.Windows.Forms.RadioButton emptyButton;
        private System.Windows.Forms.PictureBox imageWindow;
        private System.Windows.Forms.ListBox shapesList;
        private System.Windows.Forms.CheckBox nameBox;
        private System.Windows.Forms.CheckBox rotateBox;
        private System.Windows.Forms.Label shapeNameDisplay;
    }
}


namespace CarShopGUI
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
            this.carLabel = new System.Windows.Forms.Label();
            this.makeLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.milesLabel = new System.Windows.Forms.Label();
            this.makeIn = new System.Windows.Forms.TextBox();
            this.modelIn = new System.Windows.Forms.TextBox();
            this.priceIn = new System.Windows.Forms.TextBox();
            this.yearsIn = new System.Windows.Forms.TextBox();
            this.milesIn = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.storeInventory = new System.Windows.Forms.ListBox();
            this.cartButton = new System.Windows.Forms.Button();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.shoppingCart = new System.Windows.Forms.ListBox();
            this.shoppingCartLabel = new System.Windows.Forms.Label();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // carLabel
            // 
            this.carLabel.AutoSize = true;
            this.carLabel.Location = new System.Drawing.Point(12, 9);
            this.carLabel.Name = "carLabel";
            this.carLabel.Size = new System.Drawing.Size(92, 17);
            this.carLabel.TabIndex = 0;
            this.carLabel.Text = "Create a Car:";
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(12, 40);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(46, 17);
            this.makeLabel.TabIndex = 1;
            this.makeLabel.Text = "Make:";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(12, 71);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(50, 17);
            this.modelLabel.TabIndex = 2;
            this.modelLabel.Text = "Model:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(12, 103);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(44, 17);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Price:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(12, 133);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(42, 17);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "Year:";
            // 
            // milesLabel
            // 
            this.milesLabel.AutoSize = true;
            this.milesLabel.Location = new System.Drawing.Point(12, 166);
            this.milesLabel.Name = "milesLabel";
            this.milesLabel.Size = new System.Drawing.Size(44, 17);
            this.milesLabel.TabIndex = 5;
            this.milesLabel.Text = "Miles:";
            // 
            // makeIn
            // 
            this.makeIn.Location = new System.Drawing.Point(65, 40);
            this.makeIn.Name = "makeIn";
            this.makeIn.Size = new System.Drawing.Size(118, 22);
            this.makeIn.TabIndex = 6;
            // 
            // modelIn
            // 
            this.modelIn.Location = new System.Drawing.Point(65, 71);
            this.modelIn.Name = "modelIn";
            this.modelIn.Size = new System.Drawing.Size(118, 22);
            this.modelIn.TabIndex = 7;
            // 
            // priceIn
            // 
            this.priceIn.Location = new System.Drawing.Point(65, 103);
            this.priceIn.Name = "priceIn";
            this.priceIn.Size = new System.Drawing.Size(118, 22);
            this.priceIn.TabIndex = 8;
            // 
            // yearsIn
            // 
            this.yearsIn.Location = new System.Drawing.Point(65, 133);
            this.yearsIn.Name = "yearsIn";
            this.yearsIn.Size = new System.Drawing.Size(118, 22);
            this.yearsIn.TabIndex = 9;
            // 
            // milesIn
            // 
            this.milesIn.Location = new System.Drawing.Point(65, 166);
            this.milesIn.Name = "milesIn";
            this.milesIn.Size = new System.Drawing.Size(118, 22);
            this.milesIn.TabIndex = 10;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(65, 194);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(90, 23);
            this.createButton.TabIndex = 11;
            this.createButton.Text = "Create Car";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // storeInventory
            // 
            this.storeInventory.FormattingEnabled = true;
            this.storeInventory.ItemHeight = 16;
            this.storeInventory.Location = new System.Drawing.Point(189, 40);
            this.storeInventory.Name = "storeInventory";
            this.storeInventory.Size = new System.Drawing.Size(207, 308);
            this.storeInventory.TabIndex = 12;
            // 
            // cartButton
            // 
            this.cartButton.Location = new System.Drawing.Point(402, 194);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(120, 23);
            this.cartButton.TabIndex = 13;
            this.cartButton.Text = "Add To Cart -->";
            this.cartButton.UseVisualStyleBackColor = true;
            this.cartButton.Click += new System.EventHandler(this.cartButton_Click);
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Location = new System.Drawing.Point(186, 9);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(92, 17);
            this.inventoryLabel.TabIndex = 14;
            this.inventoryLabel.Text = "Car Inventory";
            // 
            // shoppingCart
            // 
            this.shoppingCart.FormattingEnabled = true;
            this.shoppingCart.ItemHeight = 16;
            this.shoppingCart.Location = new System.Drawing.Point(529, 41);
            this.shoppingCart.Name = "shoppingCart";
            this.shoppingCart.Size = new System.Drawing.Size(207, 308);
            this.shoppingCart.TabIndex = 15;
            // 
            // shoppingCartLabel
            // 
            this.shoppingCartLabel.AutoSize = true;
            this.shoppingCartLabel.Location = new System.Drawing.Point(529, 10);
            this.shoppingCartLabel.Name = "shoppingCartLabel";
            this.shoppingCartLabel.Size = new System.Drawing.Size(102, 17);
            this.shoppingCartLabel.TabIndex = 16;
            this.shoppingCartLabel.Text = "Shopping Cart:";
            // 
            // checkoutButton
            // 
            this.checkoutButton.Location = new System.Drawing.Point(599, 355);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(87, 23);
            this.checkoutButton.TabIndex = 17;
            this.checkoutButton.Text = "Checkout";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(526, 396);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(76, 17);
            this.totalCostLabel.TabIndex = 18;
            this.totalCostLabel.Text = "Total Cost:";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(608, 396);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(44, 17);
            this.costLabel.TabIndex = 19;
            this.costLabel.Text = "$0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.shoppingCartLabel);
            this.Controls.Add(this.shoppingCart);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.cartButton);
            this.Controls.Add(this.storeInventory);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.milesIn);
            this.Controls.Add(this.yearsIn);
            this.Controls.Add(this.priceIn);
            this.Controls.Add(this.modelIn);
            this.Controls.Add(this.makeIn);
            this.Controls.Add(this.milesLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.makeLabel);
            this.Controls.Add(this.carLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label carLabel;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label milesLabel;
        private System.Windows.Forms.TextBox makeIn;
        private System.Windows.Forms.TextBox modelIn;
        private System.Windows.Forms.TextBox priceIn;
        private System.Windows.Forms.TextBox yearsIn;
        private System.Windows.Forms.TextBox milesIn;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.ListBox storeInventory;
        private System.Windows.Forms.Button cartButton;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.ListBox shoppingCart;
        private System.Windows.Forms.Label shoppingCartLabel;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label costLabel;
    }
}


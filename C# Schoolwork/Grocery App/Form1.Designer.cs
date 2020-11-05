namespace Grocery_App
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
            this.lbShoppingCart = new System.Windows.Forms.ListBox();
            this.cbGroceryItems = new System.Windows.Forms.ComboBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblGrocery = new System.Windows.Forms.Label();
            this.lblShoppingCart = new System.Windows.Forms.Label();
            this.btnTotal = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbShoppingCart
            // 
            this.lbShoppingCart.FormattingEnabled = true;
            this.lbShoppingCart.ItemHeight = 20;
            this.lbShoppingCart.Location = new System.Drawing.Point(36, 158);
            this.lbShoppingCart.Name = "lbShoppingCart";
            this.lbShoppingCart.Size = new System.Drawing.Size(212, 244);
            this.lbShoppingCart.TabIndex = 0;
            // 
            // cbGroceryItems
            // 
            this.cbGroceryItems.FormattingEnabled = true;
            this.cbGroceryItems.Items.AddRange(new object[] {
            "Loaf of Bread - $2.12",
            "Quart of Milk - $1.47",
            "Dozen Eggs - $1.90"});
            this.cbGroceryItems.Location = new System.Drawing.Point(36, 39);
            this.cbGroceryItems.Name = "cbGroceryItems";
            this.cbGroceryItems.Size = new System.Drawing.Size(212, 28);
            this.cbGroceryItems.TabIndex = 1;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(277, 80);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(94, 29);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblGrocery
            // 
            this.lblGrocery.AutoSize = true;
            this.lblGrocery.Location = new System.Drawing.Point(36, 13);
            this.lblGrocery.Name = "lblGrocery";
            this.lblGrocery.Size = new System.Drawing.Size(100, 20);
            this.lblGrocery.TabIndex = 3;
            this.lblGrocery.Text = "Grocery Items";
            // 
            // lblShoppingCart
            // 
            this.lblShoppingCart.AutoSize = true;
            this.lblShoppingCart.Location = new System.Drawing.Point(36, 123);
            this.lblShoppingCart.Name = "lblShoppingCart";
            this.lblShoppingCart.Size = new System.Drawing.Size(104, 20);
            this.lblShoppingCart.TabIndex = 4;
            this.lblShoppingCart.Text = "Shopping Cart";
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(277, 342);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(94, 29);
            this.btnTotal.TabIndex = 5;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(277, 256);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 20);
            this.lblTotal.TabIndex = 6;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(200, 80);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(48, 27);
            this.tbQuantity.TabIndex = 7;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(126, 87);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(68, 20);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "Quantity:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(277, 373);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 29);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 478);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.lblShoppingCart);
            this.Controls.Add(this.lblGrocery);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.cbGroceryItems);
            this.Controls.Add(this.lbShoppingCart);
            this.Name = "Form1";
            this.Text = "Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbShoppingCart;
        private System.Windows.Forms.ComboBox cbGroceryItems;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblGrocery;
        private System.Windows.Forms.Label lblShoppingCart;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnClear;
    }
}


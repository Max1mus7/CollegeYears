using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Grocery_App
{
    public partial class Form1 : Form
    {
        private List<String> pricesAndQuantities = new List<String>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (cbGroceryItems.SelectedIndex != -1)
            {
                lbShoppingCart.Items.Add(cbGroceryItems.Items[cbGroceryItems.SelectedIndex] + " Qty: " + tbQuantity.Text);

                if (cbGroceryItems.SelectedIndex == 0)
                {
                    pricesAndQuantities.Add("$2.12," + int.Parse(tbQuantity.Text));
                }
                if (cbGroceryItems.SelectedIndex == 1)
                {
                    pricesAndQuantities.Add("$1.47," + int.Parse(tbQuantity.Text));
                }
                if (cbGroceryItems.SelectedIndex == 2)
                {
                    pricesAndQuantities.Add("$1.90," + int.Parse(tbQuantity.Text));
                }
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double totalPrice = 0;
            for (int i = 0; i < pricesAndQuantities.Count; i++)
            {
                string[] newStrings = pricesAndQuantities[i].Split(',');
                string price = newStrings[0];
                string quantity = newStrings[1];
                totalPrice += (double.Parse(price.Substring(1)) * int.Parse(quantity));
            }
            lblTotal.Text = "The total price is:\n$" + String.Format("{0:#####.00}",totalPrice);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbShoppingCart.Items.Clear();
            pricesAndQuantities.Clear();
            lblTotal.Text = "";
        }
    }
}
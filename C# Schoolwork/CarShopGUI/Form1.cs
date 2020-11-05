using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShopGUI
{
    public partial class Form1 : Form
    {
        //create a new object of the Store class
        Store store = new Store();
        //create two new BindingSource objects in order to connect to the CarList and ShoppingList lists from the store object
        BindingSource CarListBinding = new BindingSource();
        BindingSource ShoppingListBinding = new BindingSource();
        //creates the window and actually binds the lists
        public Form1()
        {
            InitializeComponent();
            SetBindings();
        }
        //binds the data from CarList to the store's inventory on the GUI
        private void SetBindings()
        {
        CarListBinding.DataSource = store.CarList;
        storeInventory.DataSource = CarListBinding;
        storeInventory.DisplayMember = "Display";
        //storeInventory.ValueMember = "Display";
        
        //binds the data from ShoppingList to the customer's shopping cart on the GUI
        ShoppingListBinding.DataSource = store.ShoppingList;
        shoppingCart.DataSource = ShoppingListBinding;
        shoppingCart.DisplayMember = "Display";
        //shoppingCart.ValueMember = "Display";
        }

        //button that creates a car object and adds it to the store's inventory
        private void createButton_Click(object sender, EventArgs e)
        {
            //takes input from text boxes

            string make = makeIn.Text.ToString();
            string model = modelIn.Text.ToString();
            decimal price = (decimal)(double.Parse(priceIn.Text.ToString()));
            int year = int.Parse(yearsIn.Text.ToString());
            int miles = int.Parse(milesIn.Text.ToString());
            //creates a new Car object with the inputs from the user
            store.CarList.Add(new Car(make, model, price, year, miles));
            //resets the store's inventory on the GUI
            CarListBinding.ResetBindings(false);
        }
        //method to add a car to the customer's shopping list from the store's inventory
        private void cartButton_Click(object sender, EventArgs e)
        {
            //Adds the specified car from the store's inventory to the customer's shopping cart
            store.ShoppingList.Add((Car)storeInventory.SelectedItem);
            //resets the customer's shopping list
            ShoppingListBinding.ResetBindings(false);
        }

        //method to allow the user to checkout and shows total cost of items in shopping cart
        private void checkoutButton_Click(object sender, EventArgs e)
        {
            costLabel.Text = "$" + store.Checkout() + "";
        }
    }
}

using System.Collections.Generic;

namespace CarClassLibrary
{
    public class Store
    {
        //define properties for of a car store
        //declares two lists of type Car, one to hold the store's cars and one to hold the customer's cars
        public List<Car> CarList { get; set; }
        public List<Car> ShoppingList { get; set; }

        //no-args constructor
        public Store()
        {
            //initialize properties
            CarList = new List<Car>();
            ShoppingList = new List<Car>();
        }

        //method returning the total price of items in a user's shopping cart
        public decimal Checkout()
        {
            decimal totalcost = 0;

            foreach (Car c in ShoppingList)
            {
                totalcost += c.Price;
            }
            ShoppingList.Clear();

            return totalcost;
        }
        //method returning a string representation of the store's inventory
        public string StoreToString()
        {
            string result = "";

            //for loop iterates through the store's inventory and adds a string representation of each Car object to a string to be returned
            for (int i = 0; i < CarList.Count; i++)
            {
                result += "\n" + (i + 1) + ".\t" + CarList[i].ToString();
            }
            //returns a string representation of the store's inventory
            return result;
        }
        //method returning a string representation of the customer's shopping cart
        public string CustomerToString()
        {
            string result = "";
            //for loop iterates through the customer's shopping cart and adds a string representation of each Car object to a string...
            //...to be returned
            for (int i = 0; i < ShoppingList.Count; i++)
            {
                result += "\n" + (i + 1) + ".\t" + ShoppingList[i].ToString();
            }
            //returns a string representation of the customer's shopping cart
            return result;
        }
    }
}
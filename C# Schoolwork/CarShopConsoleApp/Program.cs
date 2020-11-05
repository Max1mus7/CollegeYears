using CarClassLibrary;
using System;

namespace CarShopConsoleApp
{
    internal class CarShopConsoleApp
    {
        //create a new object of the Store class to be used in the console app
        private static Store CarStore = new Store();

        private static void Main(string[] args)
        {
            //create an int to be modified by the user and enable the loop to begin
            int action = -1;
            while (action != 0)
            {
                //give the user the ability to decide what action they want to take via the ChooseAction method
                action = ChooseAction();
                switch (action)
                {
                    //Case 1 adds a car to the inventory of the store
                    case 1:
                        {
                            //explain to user what to do
                            Console.WriteLine("Add a new car to the store:");

                            //prompt user to input the make of the car
                            Console.WriteLine("\nWhat is the car make?  (Ford, GM, Toyota, etc.)");
                            //take user input
                            string carMake = Console.ReadLine();

                            //prompt user to input the model of the car
                            Console.WriteLine("\nWhat is the car model? (Corvette, Focus, Ranger, etc.)");
                            //take user input
                            string carModel = Console.ReadLine();

                            //prompt user to input the price of the car
                            Console.WriteLine("\nWhat is the car price?");
                            //take user input
                            decimal carPrice = (decimal)(double.Parse(Console.ReadLine()));

                            //prompt user to input the year the car was made
                            Console.WriteLine("\nWhat year was the car made?");
                            //take user input
                            int carYear = int.Parse(Console.ReadLine());

                            //prompt user to input the amount of miles that car has on it
                            Console.WriteLine("\nHow many miles has the car been driven?");
                            //take user input
                            int carMiles = int.Parse(Console.ReadLine());

                            //user user input to create a new object of the Car class
                            Car c = new Car(carMake, carModel, carPrice, carYear, carMiles);

                            //add the new Car object to the store's inventory
                            CarStore.CarList.Add(c);
                            //print the store inventory
                            PrintStoreInventory(CarStore);
                            break;
                        }
                    //Case 2 adds lets a user add a car in the store to the user's cart
                    case 2:
                        {
                            //prints the store's inventory
                            PrintStoreInventory(CarStore);

                            
                            
                            //makes sure that there is at least a car in the store
                            if (CarStore.CarList.Count == 0)
                            {
                                Console.WriteLine("\nPlease add cars to the store and try again.\n");
                                break;
                            }
                            //create a new int to hold the user's car choice
                            int choice = 0;
                            //get a car number from the user to indicate which car they would like to purchase
                            Console.WriteLine("Which car would you like to add to the cart?\nPlease enter the number next to the car:");
                            choice = int.Parse(Console.ReadLine());
                            //add a car from the store inventory to the shopping cart
                            CarStore.ShoppingList.Add(CarStore.CarList[choice - 1]);

                            //prints the user's shopping cart
                            PrintShoppingList(CarStore);

                            break;
                        }
                    //Case 3 allows the user to check out
                    case 3:
                        {
                            //prints the user's shopping list
                            PrintShoppingList(CarStore);
                            //prints the user's total cost
                            Console.WriteLine("Your total is: $" + CarStore.Checkout());
                            action = 0;
                            Console.ReadKey();
                            break;
                        }

                    default:
                        {
                            break;
                        }
                }
            }
        }
        //holds the logic for a user choosing an action in the console application
        static public int ChooseAction()
        {
            int choice = -1;

            //create an array to help with exception handling(contents are unnecessary)
            int[] arr = new int[4] { 1, 2, 3, 4 };

            //prompts the user to select an action
            Console.WriteLine("Please choose one of three actions.\n" +
                "0: Quit\n" +
                "1: Add a car\n" +
                "2: Add item to cart\n" +
                "3: Checkout");
            //Handles exceptions
            try
            {
                //allows the user to select an action
                choice = int.Parse(Console.ReadLine());
                try
                {
                    //assign a local variable to a value in the exception handling array
                    //if it fails, throw an IndexOutOfRangeException
                    int a = arr[choice];
                    //returns the user's choice of action
                }
                //catches exception and allow the user to try making a selection again.
                catch (System.IndexOutOfRangeException)
                {
                    Console.WriteLine("\nInvalid option selected, please try again\n");
                    //allows the user to try again
                    choice = -1;
                }
            }
            //checks to make sure the input number is not a string
            catch (System.FormatException)
            {
                Console.WriteLine("\nInvalid option selected, please try again\n");
                choice = -1;
            }

            return choice;
        }
        //a method to print out the inventory of the car store
        static public void PrintStoreInventory(Store store)
        {
            //only prints if there is at least one car in the store's inventory
            if (CarStore.CarList.Count > 0)
            {
                //formatting to make it more pleasing to the customer
                Console.WriteLine("\n\n\n************************STORE INVENTORY************************");
                Console.WriteLine(store.StoreToString() + "\n\n\n");
            }
        }
        //a method to print out a shopper's shopping cart
        static public void PrintShoppingList(Store store)
        {
            //only prints if there is at least one car in the shopping cart
            if (CarStore.ShoppingList.Count > 0)
            {
                //formatting to make it look better to the customer
                Console.WriteLine("\n\n\n*************************SHOPPING CART*************************");
                Console.WriteLine(store.CustomerToString() + "\n\n\n");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace CarClassLibrary
{
    public class Car
    {
        //define properties that a car could have
        //declare two strings, one to hold the make of the car and one to hold the model
        public string Make { get; set; }
        public string Model { get; set; }
        //declare a decimal to hold the price of the car
        public decimal Price { get; set; }
        //declare two ints, one to hold the year the car was made and another to hold the amount of miles the car has on it
        public int Year { get; set; }
        public int Miles { get; set; }
        //No-args constructor that defines an invalid car
        public Car()
        {
            Make = "N/A";
            Model = "N/A";
            Price = (decimal)-1.00;
            Year = -1;
            Miles = -1;
        }
        //full-args constructor used to create a proper car object
        public Car(string make, string model, decimal price, int year, int miles)
        {
            Make = make;
            Model = model;
            Price = price;
            Year = year;
            Miles = miles;
        }
        //returns a string representation of the car
        public override string ToString()
        {
            return "Make: " + Make + "\tModel: " + Model + "\tPrice: " + Price + "\tYear: " + Year + "\tMiles: " + Miles;
        }
    }
}

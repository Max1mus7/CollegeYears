using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(); //Create a Car Object
            Car myDodgeRam = new CarType1(); //Create a CarType1 object
            Car myDodgeCharger = new CarType2(); //Create a CarType2 object

            myCar.CarSound();
            myDodgeRam.CarSound();
            myDodgeCharger.CarSound();
            Car myObj = new Car();

            myObj.MyMethod();
            Console.ReadKey();
        }
    }

    interface IFirstInterface
    {
        void MyMethod();
    }

    interface ISecondInterface
    {
        void MyOtherMethod();
    }


    class Car : IFirstInterface //Parent class
    {
        public virtual void CarSound()
        {
            Console.WriteLine("The horn makes a honk...honk...");
        }

        public void MyMethod()
        {
            Console.WriteLine("Some text...");
        }

        public void MyOtherMethod()
        {
            Console.WriteLine("Some other text");
        }

    }

    class CarType1 : Car //Derived class
    {
        public override void CarSound()
        {
            Console.WriteLine("My car makes a toot...toot...");
        }
    }

    class CarType2 : Car //Derived class
    {
        public override void CarSound()
        {
            Console.WriteLine("This car has a loud horn.");
        }
    }

    


}

using System;
using Animal;

namespace AnimalDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal.Animal beast = new Animal.Animal();

            //beast.Talk();
            //beast.Greet();
            //beast.Sing();

            Dog bowser = new Dog();

            bowser.Talk();
            bowser.Greet();
            bowser.Sing();
            bowser.Fetch("stick");
            bowser.FeedMe();
            bowser.TouchMe();

            Robin red = new Robin();

            red.Talk();
            red.Greet();
            red.Sing();
            //red.Fetch("worm");
            //red.FeedMe();
            //red.TouchMe();

            Mosquito buzzy = new Mosquito();
            buzzy.Fly();

            Horse gerald = new Horse();
            gerald.Ride();

            Griffon flamel = new Griffon();
            flamel.Fly();
            flamel.Ride();

            Console.ReadKey();

        }
    }
}

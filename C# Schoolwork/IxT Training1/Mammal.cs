using System;

namespace IxT_Training1
{
    public abstract class Mammal
    {
        protected double Weight;
        protected double Height;
        protected int BoneCount;
        protected string name = "";

        public void Move(double speed)
        {
            Console.WriteLine("A " + this.GetName() + " moves at " + speed.ToString() + " miles per hour");
        }

        abstract public void MethodOfWaste(string method);

        abstract public string GetName();

        public static void Main(String[] args)
        {
            Mammal dog = new Dog();
            Mammal whale = new Whale();
            dog.Move(32);
            whale.MethodOfWaste("swimming");
        }
    }
}
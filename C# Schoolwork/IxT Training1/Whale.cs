using System;
using IxT_Training1;

public class Whale : Mammal
{
    private string Name = "whale";

    public override void MethodOfWaste(string method)
    {
        Console.WriteLine("A " + Name + " goes to the bathroom by " + method);
    }

    public new void Move(double speed)
    {
        Move(speed);
    }

    public override string GetName()
    {
        return Name;
    }
}
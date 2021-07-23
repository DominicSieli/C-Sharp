using System;

public class BaseClass
{
    public int Width {get; set;}
    public int Height {get; set;}

    public void Copy()
    {
        Console.WriteLine("Copied!");
    }

    public void Duplicate()
    {
        Console.WriteLine("Duplicated!");
    }
}

public class SubClass : BaseClass
{
    public int X {get; set;}
    public int Y {get; set;}

    public void Coordinates()
    {
        Console.WriteLine("X: {0} Y: {1}", X, Y);
    }
}

class Program
{
    static void Main()
    {
        SubClass subClass = new SubClass();
        subClass.X = 200;
        subClass.Y = 400;
        subClass.Width = 40;
        subClass.Height = 80;
        subClass.Copy();
        subClass.Duplicate();
        subClass.Coordinates();
        Console.WriteLine("Width: {0} Height {1}", subClass.Width, subClass.Height);
    }
}
using System;

public class ComponentClass
{
    public void PrintText(string text)
    {
        Console.WriteLine(text);
    }
}

public class CompositClass
{
    private readonly ComponentClass _componentClass = new ComponentClass();

    public void Print(string text)
    {
        _componentClass.PrintText(text);
    }
}

class Program
{
    static void Main()
    {
        CompositClass compositClass = new CompositClass();
        compositClass.Print("Yes it worked!");
    }
}
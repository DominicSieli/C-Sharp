using System;

class Properties
{
    private int value;
    public int GetValue() {return this.value;}
    public void SetValue(int value) {this.value = value;}
}

class Program
{
    static void Main()
    {
        Properties property = new Properties();
        property.SetValue(400);
        Console.WriteLine(property.GetValue());
    }
}
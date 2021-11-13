using System;

public class Properties
{
	private int field = 0;

	public int Field {get{return this.field;} set{this.field = value;}}
}

class Program
{
	static void Main()
	{
		Properties properties = new Properties();

		properties.Field = 400;

		Console.WriteLine(properties.Field);
	}
}
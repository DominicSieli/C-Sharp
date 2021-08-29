using System;
using System.Collections.Generic;

public class MultipleParameters
{
    public static List<int> Parameters(params int[] parameters)
    {
        List<int> list = new List<int>();
		
        foreach(int x in parameters)
		{
			list.Add(x);
		}
		
        return list;
    }
}

class Program
{
    static void Main()
    {
        List<int> list = MultipleParameters.Parameters(1,2,3,4,5,6,7,8,9,10);
		
        foreach(int x in list)
		{
			Console.WriteLine(x);
		}
    }
}
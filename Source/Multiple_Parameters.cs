using System;
using System.Collections.Generic;

class Multiple_Parameters
{
    public static List<int> Multi_Params(params int[] par)
    {
        List<int> list = new List<int>();
        foreach(int i in par) list.Add(i);
        return list;
    }
}

class Program
{
    static void Main()
    {
        List<int> list = Multiple_Parameters.Multi_Params(1,2,3,4,5,6,7,8,9,10);
        foreach (int i in list) Console.WriteLine(i);
    }
}
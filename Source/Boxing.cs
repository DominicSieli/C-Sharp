using System;

class Program
{
    static void Main()
    {
        object heapInt = 10;          // Boxing (Heap allocated reference type)
        int stackInt = (int)heapInt;  // Unboxing (stack allocated value type)
    }
}
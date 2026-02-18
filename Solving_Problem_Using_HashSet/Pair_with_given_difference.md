
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
         int[] arr = {4,1,3,5,7,6,2};
         int k = 2;
         HashSet<int> a = new HashSet<int>(arr);
         foreach(var n in a){
             if(a.Contains(n+k))
{
    Console.WriteLine($"({n},{n+k})");
}         }
         
        }
}

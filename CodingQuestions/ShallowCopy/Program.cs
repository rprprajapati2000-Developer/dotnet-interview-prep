// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
public class Student 
{
    public  string studentName;
    public  Address address;
}

public class Address {
    
    public string pincode;
    public string city;
}
public class HelloWorld
{
    public static void Main(string[] args)
    {
       Student a = new Student{ 
           studentName = "Rahul",
           address = new Address{city = "Klayan"}};
    
          
      Student c = a;
       c.address.city = "ChinchPada";
       Console.WriteLine("Currnt City Is : " + a.address.city);
       
    }
}
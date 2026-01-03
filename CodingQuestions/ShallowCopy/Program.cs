using System;

class Address
{
    public string City;
}

class Student
{
    public string Name;
    public Address Address;
}

class Program
{
    static void Main()
    {
        Student a = new Student
        {
            Name = "Rahul",
            Address = new Address { City = "Kalyan" }
        };

        Student b = a; // Shallow copy
        b.Address.City = "ChinchPada";

        Console.WriteLine(a.Address.City);
    }
}

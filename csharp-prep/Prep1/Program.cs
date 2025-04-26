using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello, please give us your first name: ");
        string givenname = Console.ReadLine();
        Console.Write("Please now enter your last name: ");
        string secondname = Console.ReadLine();
        Console.WriteLine($"Welcome {secondname}, {givenname} {secondname}.");
    }
}
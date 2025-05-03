using System;

class Program
{
    static void Main(string[] args)
    {   
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(0,9);
        int number = randomGenerator.Next(0,9);
        Console.WriteLine("Please enter the two digit password:");
        string guess = Console.ReadLine();
        string realPassword = $"{magic}{number}";
        int pass = int.Parse(realPassword);
        int weird = int.Parse(guess);
        while (guess != realPassword)
         {   if (weird > pass)
            {
                Console.WriteLine("The password is Lower");
            }
            else
            {
                Console.WriteLine("The password is Higher");
            } 
            Console.WriteLine("Try Again:");
            guess = Console.ReadLine();
            weird = int.Parse(guess);
        }
        Console.WriteLine("You got it correct!");
    }
}
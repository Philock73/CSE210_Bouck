using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name:");
        string name = Console.ReadLine();
        return name;
    }
    static int ChangeString(string word)
    {
        int numb = int.Parse(word);
        return numb;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is a number:");
        string num = Console.ReadLine();
        int number = ChangeString(num);
        return number;
    }
    static int SquareNumber(int one)
    {
        int squared = one * one;
        return squared;
    }
    static void DisplayResult()
    {   
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squared = SquareNumber(number);
        Console.WriteLine($"{name}, {number} squared is {squared}");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        DisplayResult();
    }
}
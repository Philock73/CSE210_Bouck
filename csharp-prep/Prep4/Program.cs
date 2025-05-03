using System;

class Program
{
    static void Main(string[] args)
    {   int listItem = 1;
        List<int> numbers = new List<int>();
        int i = 0;
        int big = 0;
        int total = 0;
        int mean = 0; 
        Console.WriteLine("Please keep entering numbers and when you are finished put a 0, thanks.");
        do
        {
        string newItem = Console.ReadLine();
        listItem = int.Parse(newItem);
        numbers.Add(listItem);
        }while (listItem != 0);
        numbers.Remove(0);
        foreach (int input in numbers)
        {
            Console.WriteLine(input);
            total = total + input;
            i = i +1;
            mean = total / i;
            if (input > big)
            {
                big = input;
            }
        }
        Console.WriteLine($"Your Sum is {total}");
        Console.WriteLine($"Your average is {mean}");
        Console.WriteLine($"Your largest number is {big}");
    }
}
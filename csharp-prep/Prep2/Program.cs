using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Thank you for using us for finding your grade. Please what percentage did you get?");
        string letter = Console.ReadLine();
        int grade = int.Parse(letter);
        string credit = "No grade";
        if (grade >= 70)
        {
            credit = "passed";
            if (grade >= 90)
            {
                letter = "an A";
            }
            else if (grade >= 80)
            {
                letter = "a B";
            }
            else
            {
                letter = "a C";
            }
        }
        else
        {
            credit = "failed";
            if (grade >= 60)
            {
                letter = "a D";
            }
            else
            {
                letter = "a F";
            }

        }
        Console.WriteLine($"You {credit} with {letter}");
    }
}
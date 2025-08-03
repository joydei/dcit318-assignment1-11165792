using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Grade Calculator!");

        Console.Write("Enter your score (0-100): ");
        string input = Console.ReadLine();
        int score;
        if (int.TryParse(input, out score))
        {
            if (score < 0 || score > 100)
            {
                Console.WriteLine("Invalid score. Please enter a score between 0 and 100.");
            }
            else
            {
                string grade;
                if (score >= 90)
                {
                    grade = "A";
                }
                else if (score >= 80)
                {
                    grade = "B";
                }
                else if (score >= 70)
                {
                    grade = "C";
                }
                else if (score >= 60)
                {
                    grade = "D";
                }
                else
                {
                    grade = "F";
                }
                Console.WriteLine($"Your grade is: {grade}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numeric score.");
        }
        Console.WriteLine("Thank you for using the Grade Calculator!");
    }
}
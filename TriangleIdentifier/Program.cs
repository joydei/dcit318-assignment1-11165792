using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Triangle Identifier!");

        Console.Write("Enter the length of the first side: ");
        string input1 = Console.ReadLine() ?? string.Empty;
        Console.Write("Enter the length of the second side: ");
        string input2 = Console.ReadLine() ?? string.Empty;
        Console.Write("Enter the length of the third side: ");
        string input3 = Console.ReadLine() ?? string.Empty;

        if (double.TryParse(input1, out double side1) &&
            double.TryParse(input2, out double side2) &&
            double.TryParse(input3, out double side3))
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                Console.WriteLine("Invalid input. Please enter positive numbers for the sides.");
            }
            else
            {
                if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("The triangle is equilateral.");
                }
                else if (side1 == side2 || side2 == side3 || side1 == side3)
                {
                    Console.WriteLine("The triangle is isosceles.");
                }
                else
                {
                    Console.WriteLine("The triangle is scalene.");
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter numeric values for the sides.");
        }

        Console.WriteLine("Thank you for using the Triangle Identifier!");
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Ticket Price Calculator!");

        Console.Write("Enter the age of the ticket buyer: ");
        string input = Console.ReadLine();
        
        if (int.TryParse(input, out int age))
        {
            if (age < 0)
            {
                Console.WriteLine("Invalid age. Please enter a valid age.");
            }
            else
            {
                double ticketPrice;
                if (age <= 12 || age >= 65)
                {
                    ticketPrice = 7.0; 
                }
                else
                {
                    ticketPrice = 10.0; 
                }
                
                Console.WriteLine($"The ticket price is: GHC{ticketPrice}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numeric age.");
        }

        Console.WriteLine("Thank you for using the Ticket Price Calculator!");
    }
}
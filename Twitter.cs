using System;

class Program
{
    static void Main(string[] args)
    {
        const int MaxMessageLength = 140;

        Console.WriteLine("Enter your message:");
        string message = Console.ReadLine();

        if (message.Length <= MaxMessageLength)
        {
            Console.WriteLine("Posted");
        }
        else
        {
            Console.WriteLine("Rejected");
        }
    }
}
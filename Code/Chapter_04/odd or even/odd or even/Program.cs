﻿namespace odd_or_even
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());            
            if (number % 2 == 0)
            {
                Console.WriteLine("Even.");
            }
            else
            {
                Console.WriteLine("Odd.");
            }
        }
    }
}
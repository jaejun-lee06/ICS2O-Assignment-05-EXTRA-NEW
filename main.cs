// Created by: Jaejun Lee
// Created on: May 2022
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function calculates the value of π
        const int NUMERATOR = 4;
        int integer;
        int counter = 0;
        double answer = 0;
        double denominator = 1;

        // input
        Console.WriteLine("PI, with CSharp");

        Console.WriteLine("");
        Console.Write("Please enter a positive integer: ");
        integer = Convert.ToInt32(Console.ReadLine());

        // process
        if (integer < 0)
        {
            Console.Clear();
            Console.WriteLine("This is not a positive integer. Please enter a positive integer");
        }
        else
        {
            while (counter < integer)
            {
                if (counter % 2 == 0)
                {
                    denominator = counter * 2 + 1;
                    answer += NUMERATOR / denominator;
                }
                else
                {
                    denominator = counter * 2 + 1;
                    answer += -(NUMERATOR / denominator);
                }

                counter++;
            }
            // output
            Console.WriteLine("");
            Console.WriteLine("The answer is: " + answer);
        }

        Console.WriteLine("\nDone.");
    }
}

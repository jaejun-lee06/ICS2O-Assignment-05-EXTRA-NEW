// Created by: Jaejun Lee
// Created on: May 2022
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        double userInteger = 0;
        double pi = 0;
        double number = 1;
        var positiveOrNegative = "minus";

        Console.Write("Enter a positive number: ");
        userInteger = Convert.ToInt32(Console.ReadLine());

        pi = 4.00 / number;
        while (userInteger > 1.00)
        {
            if (positiveOrNegative == "minus")
        {
            number = number + 2.00;
            pi = pi - (4.00 / number);
            positiveOrNegative = "plus";
        }
        else if (positiveOrNegative == "plus")
        {
            number = number + 2.00;
            pi = pi + (4.00 / number);
            positiveOrNegative = "minus";
        }
        userInteger = userInteger - 1;
        }
        positiveOrNegative = "minus";
        number = 1;
        Console.WriteLine("Your answer is: " + pi.ToString("0.00"));
        Console.Write("Done.");
    }
}

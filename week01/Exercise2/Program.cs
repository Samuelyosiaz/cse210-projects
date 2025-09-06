using System;
using System.Diagnostics;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percentage = int.Parse(answer);

        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int remanent = percentage % 10;

        string sign = "";

        if (remanent >= 7)
        {
            sign = "+";
        }
        else if (remanent <= 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (sign == "+" && letter == "A" || letter == "F")
        {
            sign = "";
        }
        else if (letter == "F")
        {
            sign = "";
        }


        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (percentage >= 70)
        {
            Console.WriteLine("You have passed");
        }
        else
        {
            Console.WriteLine("Try your best next time");
        }
    }
}
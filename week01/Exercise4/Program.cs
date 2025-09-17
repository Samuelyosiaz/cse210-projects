using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        string number = "0";
        List<int> numbers = new List<int>();
        int totalSum = 0;
        int largestNumber = -99999999;
        int shortestNumber = 99999999;

        do
        {
            Console.Write("Enter a list of numbers, type 0 when finished. ");
            number = Console.ReadLine();
            int intNumber = int.Parse(number);

            if (intNumber != 0)
            {
                numbers.Add(intNumber);
            }


        } while (number != "0");

        for (int i = 0; i < numbers.Count; i++)
        {
            totalSum += numbers[i];
        }   

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > largestNumber)
            {
                largestNumber = numbers[i];
            }

            if (numbers[i] < shortestNumber && numbers[i] > 0)
            {
                shortestNumber = numbers[i];
            }

        }

        int average = totalSum / numbers.Count;

        numbers.Sort();

        Console.WriteLine($"The sum is: {totalSum}");
        Console.WriteLine($"The average number is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {shortestNumber}");
        Console.WriteLine($"The sorted list is:");

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

    }
}
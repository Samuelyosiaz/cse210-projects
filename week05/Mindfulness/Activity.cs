using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    private string _name;
    private string _title;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _title = $"Welcome to the {name} Activity";
        _description = description;
        
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine(_title);
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for this session? ");
        string input = Console.ReadLine();
        _duration = int.Parse(input);
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine();

    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(5);
        Console.WriteLine($"\nYou have completed another {_duration} of the {_name} Activity.");
        ShowSpinner(5);
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animation = new List<string> { "|", "/", "-", "\\" };
        int i = 0;

        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.Write($"\r{animation[i]}");
            Thread.Sleep(200);

            i = (i + 1) % animation.Count;
        }

        Console.Write("\b \b");
        
    }
    public void ShowCountDown()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
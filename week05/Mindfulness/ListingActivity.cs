using System;
using System.Collections.Generic;
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    public ListingActivity() : base(
        "Listing",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string> {"Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"};
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.Write("You may begin in: "); ShowCountDown(); Console.WriteLine("Press enter to write a new answer");
        List<string> _list = GetListFromUser();
        _count = _list.Count;
        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        return _prompts[index];
    }
    public List<string> GetListFromUser()
    {
        List<string> _list = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                _list.Add(input);
            }
        }
        return _list;
    }

}
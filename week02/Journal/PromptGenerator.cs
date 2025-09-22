using System;
using System.Collections.Generic;
public class PromptGenerator
{
    public List<String> _prompts;
    private static Random _rand = new Random();

    public string GetRandomPrompt()
    {
        _prompts = new List<String>()
        {
            "What made you want to write in your journal?",
            "What was the best part of your day?",
            "How did you see the hand of the Lord in your life today?",
            "Was there something that made you feel happy or sad?",
            "Do you have a memory you'd like to remember forever?",
            "If I had one thing I could do over today what would it be?"
        };

        int index = _rand.Next(0, _prompts.Count);

        return _prompts[index];
    }
}
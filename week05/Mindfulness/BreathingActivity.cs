using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing",
        "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        int timing = 3;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now <= endTime)
        {

            Console.Write($"Breath in ");
            IncreaseBreath(timing);
            Console.WriteLine();
            Console.Write($"Breath Out ");
            DecreaseBreath(timing);
            Console.WriteLine();
            Console.WriteLine();

            if (timing < 6)
            {
                timing += 1;
            }

        }
        DisplayEndingMessage();
    }
    public void IncreaseBreath(int time)
    {
        for (int i = 0; i < time; i++)
        {
            Console.Write("█");
            Thread.Sleep(1000);
        }
    }
    public void DecreaseBreath(int time)
    {
    string barra = new string('█', time);  // '█' es un char
    Console.Write(barra);

    for (int i = time; i > 0; i--)
    {
        Thread.Sleep(1000);
        Console.Write("\b \b");  // borra un bloque visual
    }

    }
}
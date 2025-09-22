using System;
using System.Security.Cryptography.X509Certificates;
// The program can read some csv files

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator createPrompt = new PromptGenerator();

        Console.WriteLine("Welcome to the Jorunal Program!");

        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            string choice = Console.ReadLine()?.Trim() ?? "";

            if (choice == "1")
            {
                string _prompt = createPrompt.GetRandomPrompt();
                Console.WriteLine(_prompt);
                string answer = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._prompText = _prompt;
                newEntry._entryText = answer;

                theJournal.AddEntry(newEntry);

            }
            else if (choice == "2")
            {
                theJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.WriteLine("What is the filename? ");
                string file = Console.ReadLine();

                theJournal.LoadFromFile(file);
            }
            else if (choice == "4")
            {
                Console.WriteLine("What is the filename? ");
                string file = Console.ReadLine();

                theJournal.SaveToFile(file);
            }
            else if (choice == "5")
            {
                continuar = false;
            }

        }
    }
}
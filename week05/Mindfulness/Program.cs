using System;
using System.Xml.Serialization;

// I added a option to Display a bar that increases and decreases with every breath instead the countdown.
class Program
{
    static void Main(string[] args)
    {
        bool playing = true;
        while (playing)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Start breathing activity");
            Console.WriteLine("    2. Start reflecting activity");
            Console.WriteLine("    3. Start listing activity");
            Console.WriteLine("    4. Quit");
            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            { BreathingActivity breathingActivity = new BreathingActivity(); breathingActivity.Run(); }
            if (choice == 2)
            { ReflectingActivity reflectingActivity = new ReflectingActivity(); reflectingActivity.Run(); }
            if (choice == 3)
            { ListingActivity listingActivity = new ListingActivity(); listingActivity.Run(); }
            if (choice == 4)
            { playing = false; }
        }

    }
}
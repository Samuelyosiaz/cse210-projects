using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video video1 = new Video();
        video1._author = "Pianistos";
        video1._title = "Song from a Secret Garden (Piano Cover)";
        video1._lenghtSeconds = 121;

        Comment video1c1 = new Comment();
        video1c1._name = "Jacobo";
        video1c1._comment = "What a beautiful song";
        video1.AddComment(video1c1);
        Comment video1c2 = new Comment();
        video1c2._name = "Ashley";
        video1c2._comment = "This song made cry, loved it";
        video1.AddComment(video1c2);
        Comment video1c3 = new Comment();
        video1c3._name = "Liliana";
        video1c3._comment = "What a talent for playing piano like this";
        video1.AddComment(video1c3);

        _videos.Add(video1);

        Video video2 = new Video();
        video2._author = "Fernanfloo";
        video2._title = "The goat simulator";
        video2._lenghtSeconds = 725;

        Comment video2c1 = new Comment();
        video2c1._name = "Joshua";
        video2c1._comment = "Hahaha he is a crack";
        video2.AddComment(video2c1);
        Comment video2c2 = new Comment();
        video2c2._name = "Samuel";
        video2c2._comment = "lmao i gotta try this game";
        video2.AddComment(video2c2);
        Comment video2c3 = new Comment();
        video2c3._name = "Ashley";
        video2c3._comment = "How can he be so unlucky? jaja";
        video2.AddComment(video2c3);
        Comment video2c4 = new Comment();
        video2c4._name = "Jacobo";
        video2c4._comment = "What a disgusting video.";
        video2.AddComment(video2c4);

        _videos.Add(video2);

        Video video3 = new Video();
        video3._author = "Mr Beast";
        video3._title = "Giving a Random Homeless Man $10,000";
        video3._lenghtSeconds = 602;

        Comment video3c1 = new Comment();
        video3c1._name = "Ashley";
        video3c1._comment = "Wow, you are a great man";
        video3.AddComment(video3c1);
        Comment video3c2 = new Comment();
        video3c2._name = "Samuel";
        video3c2._comment = "I wanna meet mr beast so he would give me some money jaja";
        video3.AddComment(video3c2);
        Comment video3c3 = new Comment();
        video3c3._name = "Liliana";
        video3c3._comment = "I hope this man can use this oportunity in his life";
        video3.AddComment(video3c3);

        _videos.Add(video3);

        Console.WriteLine("Videos disponibles:");
        Console.WriteLine();

        for (int i = 0; i < _videos.Count; i++)
        {
            Console.WriteLine($"Video #{i + 1}");
            _videos[i].DisplayDetails();
            Console.WriteLine();
        }

        
    }
}
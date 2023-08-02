using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static List<string> days = new List<string> {
        "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"
    };

    static List<string> months = new List<string> {
        "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"
    };

    static List<string> fruits = new List<string> {
        "Apple", "Banana", "Orange", "Grapes", "Watermelon", "Strawberry", "Mango", "Pineapple", "Cherry", "Kiwi"
    };

    static Dictionary<string, string> wordsAndMeanings = new Dictionary<string, string> {
        { "Happy", "Feeling or showing pleasure or contentment." },
        { "Brave", "Ready to face and endure danger or pain; showing courage." },
        { "Beautiful", "Pleasing the senses or mind aesthetically." },
        { "Friend", "A person with whom one has a bond of mutual affection." },
        { "Explore", "Travel through (an unfamiliar area) in order to learn about it." }
    };

    static void DisplayDays()
    {
        Console.WriteLine("---------------Welcome to Learning-----------");
        foreach (var day in days)
        {
            Console.WriteLine(day);
            Thread.Sleep(2000); // Wait for 2 seconds before displaying the next day
        }
    }

    static void DisplayMonths()
    {
        Thread.Sleep(5000); // Wait for 5 seconds before displaying months
        foreach (var month in months)
        {
            Console.WriteLine(month);
            Thread.Sleep(2000); // Wait for 2 seconds before displaying the next month
        }
    }

    static void DisplayFruitsAndWords()
    {
        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine("\n--- Words and Meanings ---");
        foreach (var pair in wordsAndMeanings)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }

    static void Main()
    {
        // Create and start three threads for each display task
        Thread daysThread = new Thread(DisplayDays);
        Thread monthsThread = new Thread(DisplayMonths);
        Thread fruitsAndWordsThread = new Thread(DisplayFruitsAndWords);

        daysThread.Start();
        daysThread.Join(); // Wait for the days thread to complete before starting the months thread

        monthsThread.Start();
        monthsThread.Join(); // Wait for the months thread to complete before starting the fruits and words thread

        fruitsAndWordsThread.Start();
        fruitsAndWordsThread.Join(); // Wait for the fruits and words thread to complete

        Console.WriteLine("Learning session completed!");
    }
}

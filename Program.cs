// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;


PrintGreeting();

Random rand = new Random();

Dictionary<string, List<string>> categories = new Dictionary<string, List<string>>(){
    {"Anime", new List<string> {"Code Geass", "One Piece", "Fairy Tale", "My Hero Academia"}},
    {"Horror", new List<string> {"Chucky", "Blade", "Scream", "Scream 2", "Brightburn"}},
    {"Comedy", new List<string> {"Friends", "How I met your mother", "Big Bang theory", "Fresh Prince of Bel Air", "My Wife and Kids"}},
    {"Sci fi", new List<string> {"Black Mirror", "Lost", "Stranger Things", "Fallout"}}
};

Console.WriteLine("What kind of show are you feeling?");
Console.WriteLine("Anime - Horror - Comedy - Sci Fi");

string choice = Console.ReadLine();

if (categories.ContainsKey(choice))
{
    Console.WriteLine("You have selected Anime");
    string selectedShow = selectOption(choice, categories[choice]);
    Console.WriteLine($"You should watch: {selectedShow}");
}
else if (choice == "Horror")
{
    Console.WriteLine("You have selected Anime");
    string selectedShow = selectOption(choice, categories[choice]);
    Console.WriteLine($"You should watch: {selectedShow}");
}
else if (choice == "Comedy")
{
    Console.WriteLine("You have selected Anime");
    string selectedShow = selectOption(choice, categories[choice]);
    Console.WriteLine($"You should watch: {selectedShow}");
}
else
{
    Console.WriteLine("Please enter a valid option");
}

static void PrintGreeting()
{
    Console.WriteLine("Hello, This is a simple project to help decide what show I should watch");
}

static string selectOption(string category, List<string> options)
{
    Random rand = new Random();
    return options[rand.Next(options.Count)];
}
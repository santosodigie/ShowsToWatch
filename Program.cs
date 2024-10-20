// See https://aka.ms/new-console-template for more information
PrintGreeting();

Random rand = new Random();
// string[] list_of_shows = { "Code Geass", "One Piece, Fairy Tale", "My Hero Academia", "Demon Slayer", "Kaiju no. 8", "Mashle", "Blue lock", "Charlotte", "Saiki k", "Tokyo Ghoul", "Horimiya", "Sword Art Online", "That time I got reincarnated as a slime", "Noragami", "Kill la kill", "Eminence in Shadow", "Berserk", "Hells paradise", "Elfin lied", "Spy x family", "God of high school", "Kenshin", "Shawmin king", "Fog hill of 5 elements" };

Dictionary<string, List<string>> categories = new Dictionary<string, List<string>>(){
    {"Anime", new List<string> {"Code Geass", "One Piece", "Fairy Tale", "My Hero Academia"}},
    {"Horror", new List<string> {"Chucky", "Blade", "Scream", "Scream 2", "Brightburn"}},
    {"Comedy", new List<string> {"Friends", "How I met your mother", "Big Bang theory", "Fresh Prince of Bel Air", "My Wife and Kids"}},
    {"Sci fi", new List<string> {"Black Mirror", "Lost", "Stranger Things", "Fallout"}}
};

Console.WriteLine("What kind of show are you feeling?");
Console.WriteLine("Anime - Horror - Comedy - Sci Fi");

string choice = Console.ReadLine();

if (choice == "Anime")
{
    Console.WriteLine("You have selected Anime");
}
else if (choice == "Horror")
{
    Console.WriteLine("You have selected Horror");
}
else if (choice == "Comedy")
{
    Console.WriteLine("You have selected Comedy");
}
else
{
    Console.WriteLine("Please enter a valid option");
}
// int index = rand.Next(list_of_shows.Length); // generates a random index within the bounds of the array
// string pick = list_of_shows[index];

// Console.WriteLine(pick);

static void PrintGreeting()
{
    Console.WriteLine("Hello, This is a simple project to help decide what show I should watch");
}
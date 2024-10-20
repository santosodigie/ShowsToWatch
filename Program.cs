// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, This is a simple project to help decide what show I should watch");

Random rand = new Random();
string[] list_of_shows = { "Code Geass", "One Piece, Fairy Tale", "My Hero Academia", "Demon Slayer", "Kaiju no. 8", "Mashle", "Blue lock", "Charlotte", "Saiki k", "Tokyo Ghoul", "Horimiya", "Sword Art Online", "That time I got reincarnated as a slime", "Noragami", "Kill la kill", "Eminence in Shadow", "Berserk", "Hells paradise", "Elfin lied", "Spy x family", "God of high school", "Kenshin", "Shawmin king", "Fog hill of 5 elements" };

int index = rand.Next(list_of_shows.Length); // generates a random index within the bounds of the array
string pick = list_of_shows[index];

Console.WriteLine(pick);
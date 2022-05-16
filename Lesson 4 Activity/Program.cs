Console.WriteLine ("Welcome to the Movie Maker");
Console.WriteLine("Which type of movie do you like? (horror, comedy, sci-fi");
string movieType = Console.ReadLine().Trim().ToLower();

if (movieType == "horror")
{
    Console.WriteLine("Please put rating as a percentage %" );
    double percentage = double.Parse(Console.ReadLine().Trim());
        if (percentage == 100) 
        {
            Console.WriteLine("You should watch Frankenstein or Host");
        }
        else if (percentage < 100 && 20<percentage) 
        {
        Console.WriteLine ( "You should watcth ; Ready or Not , Don't Breathe , Upgrade , Let Me In ");
        }
        else 
        {
        Console.WriteLine("Horror movie is not your cup of tea ");
        }
}
else if (movieType == "comedy")
{
    Console.WriteLine("Do you want to search for 2022?");
    Console.Write("Please answer Yes or No. ");
    string answer = Console.ReadLine().Trim().ToLower();
    if (answer == "yes")
    {
        Console.WriteLine("You should watch this:");
        Console.WriteLine("I Want You Back , Marry Me , Dog");
    }
    else 
    {
     Console.WriteLine("Crazy, Stupid, Love !");
    }
}
else 
{
Console.WriteLine("Best Sci-Fi movie is Black Panter.");
}
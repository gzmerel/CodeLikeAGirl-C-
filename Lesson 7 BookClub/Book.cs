namespace BookClub
{    public class Book
    {
        public string title;
        public string author;
        public void PrintBook()
        {
         Console.WriteLine($"{title} written by {author}");
        }
    }
}
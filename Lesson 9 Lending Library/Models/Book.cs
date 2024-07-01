namespace LendingLibrary.Models
{
    public abstract class Book : Media 
    {
        public string Author { get; set; }

         protected Book(string title, string author, int publicationYear)
        : base(title, publicationYear)
    {
        Author = author;
    }

    }

    


}
namespace LendingLibrary.Models
{
    public class Novel: Book
    {
        public string Genre { get; set; }

        public Novel(string title, string author, int publicationYear, string genre): base(title, author, publicationYear)
        {
            Genre = genre;
        }
    public override string ToString()
    {
        return $"{Title} by {Author} , {PublicationYear} - Genre : {Genre}"; 
    }
    }
}
namespace LendingLibrary.Models
{
    public class AudioBook  : CD
    {
        public string Author { get; set; }

  public AudioBook(string title, string author, int numberOfTracks, int publicationYear)
        : base(title, publicationYear, numberOfTracks)
    {
        Author = author;
    }

        public override string ToString()
        {
            return $"{Title}, by {Author}, {PublicationYear} -  Tracks: {NumberOfTracks}";
        }
    }
}
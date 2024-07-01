namespace LendingLibrary.Models
{
    public class Album : CD
    {
        public string Artist{ get; set; }
        
        public Album(string title, string artist, int numberOfTracks, int publicationYear)
            : base(title, publicationYear, numberOfTracks)
        {
            Artist=artist;
        }

        public override string ToString()
        {
            return $"{Title} by {Artist}, {PublicationYear} - Tracks: {NumberOfTracks}";
        }
    }

}
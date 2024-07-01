namespace LendingLibrary.Models
{
     public abstract class CD : Media
     {
         public int NumberOfTracks { get; set; }
     
      protected CD(string title, int publicationYear, int numberOfTracks) 
        : base(title, publicationYear)
    {
        NumberOfTracks = numberOfTracks;
    }
     }
}
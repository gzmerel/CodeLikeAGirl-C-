using System.Diagnostics.CodeAnalysis;

namespace LendingLibrary.Models
{
    public class TextBook : Book
    {
        public string Subject { get; set; }

        public TextBook(string title, string author, int publicationYear, string subject)
        : base(title, author, publicationYear)
        {
            Subject =subject;
        }

        public override string ToString()
        {
            return $"{Title} by {Author} , {PublicationYear} - Subject: {Subject}";
        }

    }
}
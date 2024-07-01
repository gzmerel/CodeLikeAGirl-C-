using System;
using System.Collections.Generic;

namespace LendingLibrary.Models
{
    public abstract class Media 
    {
        public string Title { get; set; }
        public int PublicationYear { get; set; }

        protected Media(string title, int publicationYear)
    {
        Title = title;
        PublicationYear = publicationYear;
    }
       
    }
}
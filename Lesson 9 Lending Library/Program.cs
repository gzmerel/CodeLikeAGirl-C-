using System;
using LendingLibrary.Models;


namespace LendingLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
               Library library= new Library();

               Novel novel = new Novel ("Don Quixote","Miguel De Cervantes",1605,"novel");
               TextBook textBook= new TextBook("Introduction to Programming ","Thomas H. Cormen",2009,"Computer Science");
               Album album= new Album("The Darkside of the Moon","Pink Floyd",10,1973);
               AudioBook audioBook = new AudioBook("Becoming","Michelle Obama", 19, 2018);

               library.AddNovel(novel);
               library.AddTextBook(textBook);
               library.AddAlbum(album);
               library.AddAudioBook(audioBook);

        Console.WriteLine("Library Contents");

        foreach(var novel1 in library.Novels)
        {
            Console.WriteLine(novel1);
        } 
        foreach(var textBook1 in library.TextBooks)
        {
            Console.WriteLine(textBook1);
        }    
                foreach(var album1 in library.Albums)
        {
            Console.WriteLine(album1);
        } 
        foreach(var audiobook1 in library.AudioBooks)
        {
            Console.WriteLine(audiobook1);
        }        

        }
    }
}
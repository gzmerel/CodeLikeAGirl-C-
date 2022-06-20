using System;
namespace BookClub
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Welcome to the library?");
        var members = CreateMembers();
        var recommendedBooks = CreateBookList();

        foreach(var member in members)
        {
            member.PrintMember();
        foreach (var book in recommendedBooks)
            {
            
                Book.PrintBook();
            }
        }
    

    static List<Member> CreateMembers()
    {
        var person1 = new Member{
            firstName = "Jane",
            lastName = "Doe",
            readingList = new List<Book> { new Book() }
        };
        var person2 = new Member{
            firstName = "Gary",
            lastName = "Brown",
            readingList = new List<Book> { new Book() }
        };

        var members = new List<Member>{ 
            person1 , person2,
        };

        return members;
    }
    static List<Book> CreateBookList()
    {
        var book1 = new Book{
            title = "atomic habits",
            author = "James Clear",
            
        };
        var book2 = new Book{
            title = "The Museum of Innocence",
            author = "Orhan Pamuk",
            
        };

        var books = new List<Book>{ 
            book1 , book2,
        };

        return books;
    }

        }
    }
}

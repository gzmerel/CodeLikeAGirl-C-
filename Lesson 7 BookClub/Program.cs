

Console.WriteLine("Welcome to the library?");
var members = CreateMembers();
var recommendedBooks = CreateBookList();

foreach(var member in members)
{
Console.WriteLine($"{member.firstName}'s favourite book is: ");

foreach (var book in recommendedBooks)
    {
        Console.WriteLine($"{book.title} written by {book.author}");
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
    public class Book
    {
        public string title;
        public string author;
    }
  public class Member
    {
        public string firstName;
        public string lastName;
        // add a field to hold the member's favourite book
        public string favouriteBook;
        public List<Book> readingList;
    }
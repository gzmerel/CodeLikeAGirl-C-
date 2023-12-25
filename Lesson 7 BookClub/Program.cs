using System.Collections.Generic;
using System;
using System.Collections;

namespace BookClub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string Name = Console.ReadLine();
            Console.WriteLine($"Hello {Name}");
            Menu.DisplayMenu();
            
            var members = CreateMembers();
            var recommendedBooks = CreateBookList();

            int userInput;

            while (true)
            {
                Console.WriteLine("Enter your choice:");
                userInput = int.Parse(Console.ReadLine().Trim());
                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Books recommemded by the book club");
                        PrintBooks(recommendedBooks);
                        break;

                    case 2:
                        Console.WriteLine("Print List of Members");
                        PrintMembers(members);
                        break;

                    case 3:
                        Console.WriteLine("3.Add a new Member");
                        AddNewMember(members);
                        break;

                    case 4:
                        Console.WriteLine("Add new book to the new recommended book list");
                        AddNewBook(recommendedBooks);
                        break;
                    case 0:
                        Console.WriteLine("Exiting the program, GoodBye!");
                        return;

                    default:
                        Console.WriteLine("Invalid input.Please enter a valid number.");
                        break;
                }
                Menu.DisplayMenu();
            }
                
            void PrintBooks(List<Book> books)
            {
                foreach ( var book in books)
                {
                    book.PrintBook();
                }
            }

            void PrintMembers(List<Member> memberlist)
            {
                foreach ( var member in members)
                {
                    member.PrintMember();
                }
            }

            
            void AddNewMember(List<Member> member)
            {
                Console.WriteLine("Enter first name:");
                string firstName = Console.ReadLine().Trim().ToString();
                Console.WriteLine("Enter surname: ");
                string lastName = Console.ReadLine().Trim().ToString();

                member.Add(new Member
                {
                    firstName = firstName,
                    lastName = lastName,
                    readingList = new List<Book>()
                });
                Console.WriteLine("New member successfully added");

            }
            void AddNewBook(List<Book> book)
            {
                Console.WriteLine("Enter title:");
                string title = Console.ReadLine().Trim().ToString(); ;
                Console.WriteLine("Enter author");
                string author = Console.ReadLine().Trim().ToString(); ;
                
                book.Add(new Book { 
                    title = title,
                    author = author 
                });
                Console.WriteLine("New book successfully added");

            }


                List<Member> CreateMembers()
                {
                    var person1 = new Member
                    {
                        firstName = "Jane",
                        lastName = "Doe",
                        readingList = new List<Book> { new Book() }
                    };
                    var person2 = new Member
                    {
                        firstName = "Gary",
                        lastName = "Brown",
                        readingList = new List<Book> { new Book() }
                    };

                    var member = new List<Member>
                {
                    person1 , person2,
                };

                return member;
            }

                List<Book> CreateBookList()
                {
                    var book1 = new Book
                    {
                        title = "atomic habits",
                        author = "James Clear",

                    };
                    var book2 = new Book
                    {
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
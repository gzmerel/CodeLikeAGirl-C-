using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookClub
{
    public class Member
    {
        public string firstName;
        public string lastName;
        public void PrintMember()
        {
            Console.WriteLine($"{firstName} {lastName}'");
        }
        public string favouriteBook;
        public List<Book> readingList;
    }
}

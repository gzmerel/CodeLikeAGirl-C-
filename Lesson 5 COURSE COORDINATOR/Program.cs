var students =new List<string>{"Hayley", "Sal", "Andrew","David"};
var courses = new List<string>{"C# Coding","Chemistry","Art"};
var codingClass = new List<string>{"Andrew","Sal"};
var chemistryClass = new List<string>{"David"};
var artClass = new List<string>{"Hayley"};
var numberOfTotalCourses = courses.Count();
var totalStudent = students.Count();
Console.WriteLine("Welcome to Kaplan College");
Console.WriteLine("Please press number for transactions");
Console.WriteLine("1 . list students at the university");
Console.WriteLine("2 . list the courses on offer at the university");
Console.WriteLine("3 . list the courses each student is enrolled on");
Console.WriteLine("4 . enrol more students to the university");
Console.WriteLine("5 . unenrol students from courses");
Console.WriteLine("0. Exit");
var number = int.Parse(Console.ReadLine().Trim());
while (number != 0)
{
    if (number == 1)
        {
        
            foreach( var student in students)
            {
                Console.WriteLine(student);
            }        
        }
    else if (number == 2)
        {
            foreach ( var course in courses)
            {
                Console.WriteLine(course);
            }     
        }
    else if (number == 3)
        { 
            Console.WriteLine("Students are in coding class;");
            foreach( var student in codingClass )
            {
                Console.WriteLine( " "+ $"{student}");
            }
            Console.WriteLine("Students are in chemistry class;");
            foreach( var student in chemistryClass )
            {
                Console.WriteLine( " "+ $"{student}");
            }
            Console.WriteLine("Students are in art class;");
            foreach( var student in artClass )
            {
                Console.WriteLine( " "+ $"{student}");
            }
        }
    else if (number == 4)
        {
            Console.WriteLine("Please enter new student name;");
            var newStudent = Console.ReadLine().Trim();
            students.Add(newStudent);
        }
    else if (number == 5)
        {
            Console.WriteLine("Please enter index number of the student");
            foreach(var student in students)
            {
                Console.WriteLine(student);
            }
            int i = 0;
            var indexOfUnenrollStudent = int.Parse(Console.ReadLine().Trim());
            int IndexOfStudent = i - 1 ;
            students.RemoveAt(i);
            foreach(var student in students)
            {
                Console.WriteLine(student);
            }
        }    
Console.WriteLine("Welcome to Kaplan College");
Console.WriteLine("Please press number for transactions");
Console.WriteLine("1 . list students at the university");
Console.WriteLine("2 . list the courses on offer at the university");
Console.WriteLine("3 . list the courses each student is enrolled on");
Console.WriteLine("4 . enrol more students to the university");
Console.WriteLine("5 . unenrol students from courses");
Console.WriteLine("0. Exit");
number = int.Parse(Console.ReadLine().Trim());              
}

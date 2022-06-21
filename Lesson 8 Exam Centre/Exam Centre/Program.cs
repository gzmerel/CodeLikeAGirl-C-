using ExamCentre.Models;
namespace ExamCentre
{ 
    public class Program
    {
    static void Main(string[] args) 
    {
       
        var exam = new Exam("Bioinformatics");
        var student1 = new Student("Ama", 3314);
        var student2 = new Student("Jess", 3315);
        Console.WriteLine($"{student1.candidateNumber}");
        exam.AddStudent(student1);
        foreach(Student student in exam.Students)
        {
            student.PrintStudent(student); 
        }

    }
} 
}
    
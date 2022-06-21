namespace ExamCentre.Models
{
   public class Student
   {
      public Student(string studentName , int candidateNumber ){
         studentName = studentName;
         candidateNumber = candidateNumber;
      }
      public int candidateNumber;
      private string studentName;
      public int[] score;
      public void PrintStudent(Student student){
         Console.WriteLine($"{student.candidateNumber} belongs to {student.studentName}"); 
      }
       
   };
}
